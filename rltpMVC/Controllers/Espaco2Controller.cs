using Microsoft.AspNetCore.Mvc;

namespace rltpMVC.Controllers
{
    public class Espaco2Controller : Controller
    {
        public IActionResult Index()
        {
            ViewData["NomeView"] = "Espaco2";
            ViewData["navView"] = "Nav";
            return View();
        }
    }
}