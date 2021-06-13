using immo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ImmoApp.domain;
using ImmoApp.Data;


namespace immo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private static CoproprietaireContext context = new CoproprietaireContext();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var copro = new Coproprietaire();
            copro.Name = "index";
            context.Coproprietaires.Add(copro);
            context.SaveChanges();




            var copros = context.Coproprietaires.ToList();
            foreach (var copro1 in copros)
            { 
            
            }
              
            return View();
        }

        public IActionResult Privacy()
        {
            // context.Database.EnsureCreated();

            var copro = new Coproprietaire();
            copro.Name = "privacy";
            context.Coproprietaires.Add(copro);
            context.SaveChanges();

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
