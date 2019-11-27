using Microsoft.AspNetCore.Mvc;

namespace rltpMVC.Controllers
{
    public class EspacoController : Controller
    {
        public IActionResult Index()
        {
            ViewData["NomeView"] = "Espaco";
            ViewData["navView"] = "Nav";
            return View();
        }
    }
}