using Microsoft.AspNetCore.Mvc;
using rltpMVC.ViewModels;

namespace rltpMVC.Controllers
{
    public class Espaco2Controller : AbstractController
    {
        public IActionResult Index()
        {
            ViewData["NomeView"] = "Espaco2";
            ViewData["navView"] = "Nav";
            
            return View(new BaseViewModel()
            {
                NomeView = "Espaco2",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterNomeSession()
            });
        }
    }
}