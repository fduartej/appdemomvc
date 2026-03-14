namespace appdemomvc.Models;

public class WishListViewModel
{
    public List<Product> ProductosDisponibles { get; set; } = new List<Product>();
    public List<int> ProductosSeleccionados { get; set; } = new List<int>();
}
