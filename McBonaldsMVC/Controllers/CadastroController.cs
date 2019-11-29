using System;
using McBonaldsMVC.Enums;
using McBonaldsMVC.Models;
using McBonaldsMVC.Repositories;
using McBonaldsMVC.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace McBonaldsMVC.Controllers
{
    public class CadastroController : AbstractController
    {
        public IActionResult Index()
        {
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
                   form["endereco"],
                   form["telefone"],
                   form["email"],
                   form["senha"],
                   DateTime.Parse(form["data-nascimento"]
                   ));

                    cliente.TipoUsuario = (uint) TiposUsuario.CLIENTE;

                    clienterepositorio.Inserir(cliente);

                    return View("Sucesso", new RespostaViewModel()
                    {
                        NomeView = "Cadastro",
                        UsuarioEmail = ObterUsuarioSession(),
                        UsuarioNome = ObterNomeSession()
                    });
                
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
                return View("Erro", new RespostaViewModel("Mensagem"));
                
            }
        }
    }
}