using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using rltpMVC.Enumeradores;
using rltpMVC.Models;
using rltpMVC.Repositorio;
using rltpMVC.ViewModels;

namespace rltpMVC.Controllers
{
    public class ClienteController : AbstractController
    {
        private ClienteRepositorio clienteRepositorio = new ClienteRepositorio();
        private AgendamentoRepositorio agendamentoRepositorio = new AgendamentoRepositorio();
        
        [HttpGet]
        public IActionResult Login()
        {
            ViewData["NomeView"] = "Login";
            ViewData["navView"] = "Nav";
            return View(new BaseViewModel()
            {
                NomeView = "Login",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterNomeSession()

            });
        }

    [HttpPost]
    public IActionResult Login(IFormCollection form)
        {
            ViewData["Action"] = "Login";
            try
            {
                System.Console.WriteLine("===================");
                System.Console.WriteLine(form["email"]);
                System.Console.WriteLine(form["senha"]);
                System.Console.WriteLine("===================");

                var usuario = form["email"];
                var senha = form["senha"];
                
                var cliente = clienteRepositorio.ObterPor(usuario);

                if(cliente != null)
                {
                    if(cliente.Senha.Equals(senha))
                    {
                        switch(cliente.TipoUsuario)
                        {
                            case (uint) TipoUsuario.CLIENTE:
                                HttpContext.Session.SetString(SESSION_CLIENTE_EMAIL,usuario);
                                HttpContext.Session.SetString(SESSION_CLIENTE_NOME,cliente.Nome);
                                HttpContext.Session.SetString(SESSION_CLIENTE_TIPO, cliente.TipoUsuario.ToString());

                            return RedirectToAction("Historico","Cliente");

                            default:
                                HttpContext.Session.SetString(SESSION_CLIENTE_EMAIL,usuario);
                                HttpContext.Session.SetString(SESSION_CLIENTE_NOME,cliente.Nome);
                                HttpContext.Session.SetString(SESSION_CLIENTE_TIPO, cliente.TipoUsuario.ToString());

                            return RedirectToAction("Dashboard","Administrador");

                        }
                        

                    } else {
                        return View("Erro", new RespostaViewModel("Senha Incorreta"));
                    } 
                } else {
                    return View("Erro", new RespostaViewModel($"Usuário {usuario} não encontrado"));
                }
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
                return View("Erro", new RespostaViewModel("Usuário não encontrado"));
            }
        }


        public IActionResult Historico()
        {
            var emailCliente = HttpContext.Session.GetString(SESSION_CLIENTE_EMAIL);
            var agendamentosCliente = agendamentoRepositorio.ObterTodosPorCliente(emailCliente);

            return View(new HistoricoViewModel()
            {
                Agendamentos = agendamentosCliente,
                NomeView = "Historico",
                UsuarioEmail =  ObterUsuarioSession(),
                UsuarioNome =  ObterNomeSession()
            });
        }

        public IActionResult Logoff()
        {
            HttpContext.Session.Remove(SESSION_CLIENTE_EMAIL);
            HttpContext.Session.Remove(SESSION_CLIENTE_NOME);
            HttpContext.Session.Clear();

            return RedirectToAction("Index", "Home");
        }
    }
}