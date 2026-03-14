using Microsoft.AspNetCore.Mvc;
using appdemomvc.Models;

namespace appdemomvc.Controllers;

public class IWishController : Controller
{
    // Método para obtener los productos disponibles
    private List<Product> ObtenerProductos()
    {
        return new List<Product>
        {
            new Product { Id = 1, Nombre = "Laptop Gaming", Descripcion = "Laptop de alto rendimiento para juegos", Precio = 1299.99m },
            new Product { Id = 2, Nombre = "Auriculares Inalámbricos", Descripcion = "Auriculares con cancelación de ruido", Precio = 199.99m },
            new Product { Id = 3, Nombre = "Mouse RGB", Descripcion = "Mouse gaming con iluminación RGB", Precio = 49.99m },
            new Product { Id = 4, Nombre = "Teclado Mecánico", Descripcion = "Teclado mecánico retroiluminado", Precio = 89.99m }
        };
    }

    public IActionResult Index()
    {
        var viewModel = new WishListViewModel
        {
            ProductosDisponibles = ObtenerProductos()
        };
        return View(viewModel);
    }

    [HttpPost]
    public IActionResult AgregarALista(List<int> ProductosSeleccionados)
    {
        if (ProductosSeleccionados == null || !ProductosSeleccionados.Any())
        {
            TempData["Mensaje"] = "Por favor, selecciona al menos un producto.";
            return RedirectToAction("Index");
        }

        var todosLosProductos = ObtenerProductos();
        var productosEnLista = todosLosProductos
            .Where(p => ProductosSeleccionados.Contains(p.Id))
            .ToList();

        return View("MiLista", productosEnLista);
    }
}
