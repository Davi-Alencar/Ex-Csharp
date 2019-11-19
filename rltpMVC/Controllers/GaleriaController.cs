using Microsoft.AspNetCore.Mvc;

namespace rltpMVC.Controllers
{
    public class GaleriaController : Controller
    {
        public IActionResult Galeria()
        {
            ViewData["NomeView"] = "Galeria";
            return View();
        }
    }
}