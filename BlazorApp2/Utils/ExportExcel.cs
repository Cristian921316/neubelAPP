using ClosedXML.Excel;
using System.Reflection;

namespace BlazorApp2.Utils
{

    public static class ExportExcel
    {
        /// <summary>
        /// Exporta una lista de objetos a un archivo Excel (.xlsx),
        /// usando las propiedades del objeto como encabezados.
        /// </summary>
        /// <typeparam name="T">El tipo de los objetos en la lista.</typeparam>
        /// <param name="data">La lista de objetos a exportar.</param>
        /// <param name="fileName">El nombre del archivo Excel a generar (ej. "Productos.xlsx").</param>
        /// <param name="sheetName">El nombre de la hoja dentro del archivo Excel (ej. "Datos").</param>
        /// <returns>Un Stream que contiene el archivo Excel.</returns>
        public static MemoryStream ExportToExcel<T>(IEnumerable<T> data, string fileName, string sheetName = "Sheet1")
            where T : class // Restringimos T para que sea una clase
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data), "La lista de datos no puede ser nula.");
            }

            var memoryStream = new MemoryStream();

            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add(sheetName);

                // --- 1. Leer dinámicamente las propiedades para los encabezados ---
                var properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
                int col = 1; // Columna inicial para los encabezados

                foreach (var prop in properties)
                {
                    // Puedes agregar lógica para ignorar ciertas propiedades si lo deseas
                    // Ejemplo: if (prop.Name == "Id" && typeof(T) == typeof(Producto)) continue;
                    worksheet.Cell(1, col).Value = prop.Name;
                    worksheet.Cell(1, col).Style.Font.Bold = true; // Negrita para los encabezados
                    worksheet.Cell(1, col).Style.Fill.BackgroundColor = XLColor.LightGray; // Color de fondo
                    col++;
                }

                // --- 2. Leer los datos y insertarlos en las filas ---
                int row = 2; // Fila inicial para los datos (después de los encabezados)
                foreach (var item in data)
                {
                    col = 1; // Resetear la columna para cada nueva fila
                    foreach (var prop in properties)
                    {
                        var value = prop.GetValue(item);

                        // Manejo básico de tipos de datos para ClosedXML
                        if (value != null)
                        {
                            if (prop.PropertyType == typeof(DateTime) || prop.PropertyType == typeof(DateTime?))
                            {
                                worksheet.Cell(row, col).Value = (DateTime)value;
                                worksheet.Cell(row, col).Style.NumberFormat.Format = "yyyy-MM-dd HH:mm:ss"; // Formato de fecha y hora
                            }
                            else if (prop.PropertyType == typeof(decimal) || prop.PropertyType == typeof(decimal?))
                            {
                                worksheet.Cell(row, col).Value = (decimal)value;
                                worksheet.Cell(row, col).Style.NumberFormat.Format = "#,##0.00"; // Formato de moneda/decimal
                            }
                            else if (prop.PropertyType == typeof(int) || prop.PropertyType == typeof(int?) ||
                                     prop.PropertyType == typeof(double) || prop.PropertyType == typeof(double?) ||
                                     prop.PropertyType == typeof(float) || prop.PropertyType == typeof(float?))
                            {
                                worksheet.Cell(row, col).Value = Convert.ToDouble(value);
                            }
                            else if (prop.PropertyType == typeof(bool) || prop.PropertyType == typeof(bool?))
                            {
                                worksheet.Cell(row, col).Value = (bool)value ? "Sí" : "No"; // Mostrar Sí/No para booleanos
                            }
                            else
                            {
                                worksheet.Cell(row, col).Value = value.ToString();
                            }
                        }
                        else
                        {
                            worksheet.Cell(row, col).Value = string.Empty; // Celdas vacías para valores nulos
                        }
                        col++;
                    }
                    row++;
                }

                // Ajustar el ancho de las columnas para que el contenido sea visible
                worksheet.ColumnsUsed().AdjustToContents();

                // Guardar el libro de trabajo en el MemoryStream
                workbook.SaveAs(memoryStream);
            }

            memoryStream.Position = 0; // Reiniciar la posición del stream para que pueda ser leído
            return memoryStream;
        }
    }

}
