using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using teoria.Models;

namespace teoria.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult contacto(){
            return View();
        }

        [HttpPost]
        public IActionResult contacto(string nombre_completo, string mensaje){
            //guardarlo en BD
            //enviar un correo
            //no hacer nada
            Console.WriteLine(nombre_completo);
            Console.WriteLine(mensaje);
            return RedirectToAction("ContactoConfirmacion");
        }

        public IActionResult ContactoConfirmacion(){
            return View();
        }

        public IActionResult Index(string mensaje, int n)
        {
            ViewData["n"] = n;
            ViewData["mensaje"] = mensaje;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
