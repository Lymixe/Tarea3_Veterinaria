using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Tarea3_Veterianria.Models;

namespace Tarea3_Veterianria.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    
    [HttpPost]
    public IActionResult Formulario(Mascota mascota)
    {
        if (ModelState.IsValid)
        {
            TempData["mensaje"] = "Gracias " + mascota.nombreD + " por haberte registrado a " + mascota.nombreM + " :D";
            return RedirectToAction("Index");
        }
        return View(mascota);
    }

    public IActionResult InteresadoEnProductos()
{
    TempData["mensaje"] = "Si estas interesado en algunos de los productos escribe al 123456789 :D";
    return RedirectToAction("Index");
}
    public IActionResult Formulario()
    {
        return View();
    }
    
    public IActionResult Productos()
    {
    return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
