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
            ViewBag.Name = UrlShortner;
            ViewBag.ShortUrl = IndexApi(UrlShortner);
           return View();
            
        }

        [HttpPost]
        [Route("index")]
        public string IndexApi(string UrlShortner)
        {
            flag = true;
            string shortValue;
            ViewBag.flagvalue = flag;
            string shortUrl = "";
            
            shortValue = Helper.ReadList(UrlShortner);
            if (shortValue == "")
            {
                shortUrl= Helper.GenerateShortUrl();
                Helper.AddList(UrlShortner, shortUrl);
                ViewBag.ShortUrl = shortUrl;
            }
            else
                ViewBag.ShortUrl = shortValue;
            return ViewBag.ShortUrl;
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