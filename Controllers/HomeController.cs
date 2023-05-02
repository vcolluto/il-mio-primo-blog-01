using Microsoft.AspNetCore.Mvc;
using NetCore_01.Models;
using System.Diagnostics;

namespace NetCore_01.Controllers
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
            // ViewData["News"] = "Berlusconi dimesso dall'ospedale!";
            List<Notizia> elencoNotizie = new List<Notizia>();
            elencoNotizie.Add(new Notizia("Ultime dall'ospedale", "Berlusconi dimesso dall'ospedale!"));
            elencoNotizie.Add(new Notizia("Festa rimandata", "Il Napoli rimanda la festa scudetto"));
            return View(elencoNotizie); 
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

    public class Notizia
    {
        public string Titolo { get; set; }  
        public string Testo { get; set; }

       
        public Notizia(string titolo, string testo) 
        {
            Titolo = titolo;
            Testo = testo;
        }
    }
}