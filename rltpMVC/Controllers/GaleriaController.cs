using Microsoft.AspNetCore.Mvc;

namespace rltpMVC.Controllers
{
    public class GaleriaController : Controller
    {
        public IActionResult Index()
        {
            ViewData["NomeView"] = "Galeria";
            ViewData["navView"] = "Nav";
            return View();
        }
    }
}