using System;
using McBonaldsMVC.Models;
using McBonaldsMVC.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace McBonaldsMVC.Controllers
{
    public class CadastroController : Controller
    {
        public IActionResult Index()
        {
            return View();
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
                    clienterepositorio.Inserir(cliente);

                    return View("Sucesso");
                
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
                return View("Erro");
                
            }
        }
    }
}