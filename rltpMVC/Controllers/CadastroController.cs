using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using rltpMVC.Enumeradores;
using rltpMVC.Models;
using rltpMVC.Repositorio;
using rltpMVC.ViewModels;

namespace rltpMVC.Controllers
{
    public class CadastroController : AbstractController
    {
        public IActionResult Index()
        {
            ViewData["NomeView"] = "Cadastro";
            ViewData["navView"] = "Nav";

            return View(new BaseViewModel()
            {
                NomeView = "Cadastro",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterNomeSession()
            });
        }

        ClienteRepositorio clienterepositorio = new ClienteRepositorio();
        public IActionResult CadastrarCliente(IFormCollection form)
        {
            try
            {
               Cliente cliente = new Cliente(
                   form["nome"],
                   form["cpfcnpj"],
                   form["telefone"],
                   form["email"],
                   form["senha"],
                   DateTime.Parse(form["data-nascimento"]
                   ));

                    cliente.TipoUsuario = (uint) TipoUsuario.CLIENTE;

                    clienterepositorio.Inserir(cliente);

                    return View("Sucesso", new RespostaViewModel());
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
                return View("Erro", new RespostaViewModel("Erro404"));
                
            }
        }
    }
}