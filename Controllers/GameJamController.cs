using Microsoft.AspNetCore.Mvc;
using appdemomvc.Models;

namespace appdemomvc.Controllers;

public class GameJamController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Registrar(GameJamRegistration model)
    {
        if (ModelState.IsValid)
        {
            return View("Resultado", model);
        }
        
        return View("Index", model);
    }
}
