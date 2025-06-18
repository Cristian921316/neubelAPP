using BlazorApp2.Models;

namespace BlazorApp2.Services
{
    public class ProductoState
    {
        public bool IsDataLoaded { get; set; } = false;
        public List<Productos> Productos { get; set; } = new();

    }
}
