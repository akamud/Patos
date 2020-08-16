using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Patos.Dominio;
using Patos.Models;

namespace Patos.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var patos = new List<Pato>
            {
                new PatoBranco(),
                new PatoReal(),
                new PatoVermelho()
            };

            return View(patos);
        }

        public IActionResult Completo()
        {
            var patos = new List<Pato>
            {
                new PatoBranco(),
                new PatoReal(),
                new PatoVermelho(),
                new PatoPreto(),
                new PatoCape(),
                new PatoMarrom(),
                new PatoB()
            };

            return View(patos);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}