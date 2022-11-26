using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UrlShortner.Models;

namespace UrlShortner.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        bool flag = false;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.flagvalue = flag;
            return View();
        }

        [HttpPost]
        public IActionResult Index(string UrlShortner)
        {
            flag = true;
            ViewBag.flagvalue = flag;
            ViewBag.Name = UrlShortner;
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