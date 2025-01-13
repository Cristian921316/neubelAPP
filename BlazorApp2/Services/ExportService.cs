namespace BlazorApp2.Services
{
    using ClosedXML.Excel;
    using Microsoft.JSInterop;
    using System.IO;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using BlazorApp2.Models;
    using BlazorApp2.Components.Pages;

    public class ExportService
    {
        private readonly IJSRuntime _jsRuntime;

        public ExportService(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public async Task ExportarAExcel(List<ViewerPagoTrx> pagos)
        {
            try
            {

                using var workbook = new XLWorkbook();
                var worksheet = workbook.Worksheets.Add("ListadoPagos");

                // Agregar una imagen (reemplaza la ruta por tu imagen)
                var imagenPath = "wwwroot/images/LgLogo.png"; // Ruta de la imagen
                worksheet.AddPicture(imagenPath)
                                        .MoveTo(worksheet.Cell("A1")) // Posicionar la imagen en la celda A1
                                        .Scale(0.2); // Escalar la imagen al 50% de su tamaño orig



                worksheet.Cell(10, 1).Value = "CLIENTE";
                worksheet.Cell(10, 2).Value = "SECTOR";
                worksheet.Cell(10, 3).Value = "ANIO";
                worksheet.Cell(10, 4).Value = "PERIODO";
                worksheet.Cell(10, 5).Value = "COMPROBANTE";
                worksheet.Cell(10, 6).Value = "VALOR";

                //negrilla a los titulos
                worksheet.Range("A10:F10").Style.Font.SetBold(true);
                worksheet.Range("A10:F10").Style.Fill.BackgroundColor = XLColor.LightBlue;

                // Agregar datos
                for (int i = 0; i < pagos.Count; i++)
                {
                    worksheet.Cell(i + 11, 1).Value = pagos[i].clienteName;
                    worksheet.Cell(i + 11, 2).Value = pagos[i].sector;
                    worksheet.Cell(i + 11, 3).Value = pagos[i].anio;
                    worksheet.Cell(i + 11, 4).Value = pagos[i].periodo;
                    worksheet.Cell(i + 11, 5).Value = pagos[i].comprobante;
                    worksheet.Cell(i + 11, 6).Value = pagos[i].valor;
                }

                //se agrega bodes
                worksheet.Range("A10:F"+ (pagos.Count+11).ToString()).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                worksheet.Range("A10:F" + (pagos.Count + 11).ToString()).Style.Border.InsideBorder = XLBorderStyleValues.Thin;

                // Guardar el archivo en un stream
                using var stream = new MemoryStream();
                workbook.SaveAs(stream);
                stream.Seek(0, SeekOrigin.Begin);

                // Descargar el archivo

                await FileUtil.SaveAs(_jsRuntime, "ListadoPagos.xlsx", stream.ToArray());

            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }

    public static class FileUtil
    {
        public static async Task SaveAs(IJSRuntime jsRuntime, string filename, byte[] data)
        {
            try
            {
                await jsRuntime.InvokeVoidAsync("BlazorDownloadFile", filename, data);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }

            
        }
    }



}
