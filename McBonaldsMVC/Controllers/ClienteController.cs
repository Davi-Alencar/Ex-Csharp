using System;
using McBonaldsMVC.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace McBonaldsMVC.Controllers
{
    public class ClienteController : Controller
    {
        private ClienteRepositorio clienteRepositorio = new ClienteRepositorio();

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(IFormCollection form)
        {
            try
            {
                System.Console.WriteLine("===================");
                System.Console.WriteLine(form["email"]);
                System.Console.WriteLine(form["senha"]);
                System.Console.WriteLine("===================");

                var usuario = form["email"];
                var senha = form["senha"];

                var cliente = clienteRepositorio.ObterPor(usuario);

                return View("Sucesso");
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
            }
            return View();
        }
    }
}