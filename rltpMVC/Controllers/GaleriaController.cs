using Microsoft.AspNetCore.Mvc;
using rltpMVC.ViewModels;

namespace rltpMVC.Controllers
{
    public class GaleriaController : AbstractController
    {
        public IActionResult Index()
        {
            ViewData["NomeView"] = "Galeria";
            ViewData["navView"] = "Nav";
            
            return View(new BaseViewModel()
            {
                NomeView = "Galeria",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterNomeSession()
            });
        }
    }
}