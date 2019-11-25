using System;
using McBonaldsMVC.Models;
using McBonaldsMVC.Repositories;
using McBonaldsMVC.Repositorio;
using McBonaldsMVC.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace McBonaldsMVC.Controllers
{
    public class PedidoController : AbstractController
    {
        PedidoViewModel pedidoViewModel = new PedidoViewModel();
        ClienteRepositorio clienterepositorio = new ClienteRepositorio();
        PedidoRepositorio pedidorepositorio = new PedidoRepositorio();
        HamburguerRepositorio hamburguerrepositorio = new HamburguerRepositorio();
        ShakeRepositorio shakerepositorio = new ShakeRepositorio();

        public IActionResult Index()
        {
            PedidoViewModel pvm = new PedidoViewModel();
            pvm.Hamburgueres = hamburguerrepositorio.ObterTodos();
            pvm.Shakes = shakerepositorio.ObterTodos();

            var usuarioLogado = ObterUsuarioSession();
            var nomeUsuarioLogado = ObterNomeSession();
            if(!string.IsNullOrEmpty(nomeUsuarioLogado))
            {
                pvm.NomeCliente = nomeUsuarioLogado;
            }
            
            var clienteLogado = clienterepositorio.ObterPor(usuarioLogado);
            if(clienteLogado != null)
            {
                pvm.Cliente = clienteLogado;
            }

            Pedido pedido = new Pedido();
            var emailCliente = ObterUsuarioSession();
            if(!string.IsNullOrEmpty(emailCliente))
            {
                pvm.Cliente = clienterepositorio.ObterPor(emailCliente);
            }

            var nomeUsuario = ObterNomeSession();
            if(!string.IsNullOrEmpty(nomeUsuario))
            {
                pvm.NomeCliente = nomeUsuario;
            }

            pvm.NomeView = "Pedido";
            pvm.UsuarioEmail = ObterUsuarioSession();
            pvm.UsuarioNome = ObterNomeSession();

            return View(pvm);
        }

        public IActionResult Registrar(IFormCollection form)
        {
            ViewData["Action"] = "Pedido";
            Pedido pedido = new Pedido();

            var nomeShake = form["shake"];
            Shake shake = new Shake (nomeShake, shakerepositorio.ObterPrecoDe(nomeShake));

            pedido.Shake = shake;


            var nomeHamburguer = form["hamburguer"];
            Hamburguer hamburguer = new Hamburguer (nomeHamburguer, hamburguerrepositorio.ObterPrecoDe(nomeHamburguer));

            pedido.Hamburguer = hamburguer;

            Cliente cliente = new Cliente()
            {
                Nome = form["nome"],
                Endereco = form["endereco"],
                Telefone = form["telefone"],
                Email = form["email"]
            };

            pedido.Cliente = cliente;
            pedido.DataDoPedido = DateTime.Now;
            pedido.PrecoTotal= 0.0;

            if(pedidorepositorio.Inserir(pedido))
            {
                return View("Sucesso");
            } else {
                return View ("Erro");
            }
        }
    }
}