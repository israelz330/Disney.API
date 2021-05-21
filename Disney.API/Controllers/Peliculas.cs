using Microsoft.AspNetCore.Mvc;

namespace Disney.API.Controllers
{
    public class Peliculas : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}