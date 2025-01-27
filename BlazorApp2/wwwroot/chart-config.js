// Método para crear el gráfico de pastel
function crearGraficoPastel(labels, data) {
    var ctx = document.getElementById('graficoPastel').getContext('2d');
    new Chart(ctx, {
        type: 'pie', // Tipo de gráfico: pastel
        data: {
            labels: labels, // Etiquetas dinámicas
            datasets: [{
                label: 'Distribución',
                data: data, // Datos dinámicos
                backgroundColor: ['#36A2EB', '#ff5c00'], // Colores
                hoverOffset: 4
            }]
        },
        options: {
            responsive: true,
            plugins: {
                legend: {
                    position: 'top'
                },
                tooltip: {
                    enabled: true
                }
            }
        }
    });
}



