using Microsoft.AspNetCore.Mvc;
using rltpMVC.ViewModels;

namespace rltpMVC.Controllers
{
    public class EspacoController : AbstractController
    {
        public IActionResult Index()
        {
            ViewData["NomeView"] = "Espaco";
            ViewData["navView"] = "Nav";
            
            return View(new BaseViewModel()
            {
                NomeView = "Home",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterNomeSession()
            });
        }
    }
}