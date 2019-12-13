using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using rltpMVC.Models;
using rltpMVC.Repositorio;
using rltpMVC.ViewModels;

namespace rltpMVC.Controllers
{
    public class MenuController : AbstractController
    {
        ClienteRepositorio clienteRepositorio = new ClienteRepositorio();
        AgendamentoViewModel agendamentoViewModel = new AgendamentoViewModel();
        AgendamentoRepositorio agendamentoRepositorio = new AgendamentoRepositorio();
        public IActionResult Index()
        {
            ViewData["navView"] = "Nav";
            ViewData["NomeView"] = "Menu";
            AgendamentoViewModel avm = new AgendamentoViewModel();

            var usuarioLogado = ObterUsuarioSession();
            var nomeUsuarioLogado = ObterNomeSession();
            if(!string.IsNullOrEmpty(nomeUsuarioLogado))
            {
                avm.Cliente = clienteRepositorio.ObterPor(usuarioLogado);
            }
            
            var clienteLogado = clienteRepositorio.ObterPor(usuarioLogado);
            if(clienteLogado != null)
            {
                avm.Cliente = clienteLogado;
            }

            Agendamento agendamento = new Agendamento();
            var emailCliente = ObterUsuarioSession();
            if(!string.IsNullOrEmpty(emailCliente))
            {
                avm.Cliente = clienteRepositorio.ObterPor(emailCliente);
            }

            var nomeUsuario = ObterNomeSession();
            if(!string.IsNullOrEmpty(nomeUsuario))
            {
                avm.NomeCliente = nomeUsuario;
            }

            avm.UsuarioEmail = ObterUsuarioSession();
            avm.UsuarioNome = ObterNomeSession();

            return View(avm);
        }

        public IActionResult Historico()
        {
            ViewData["navView"] = "Nav";
            ViewData["NomeView"] = "Historico";
            
            var emailCliente = HttpContext.Session.GetString(SESSION_CLIENTE_EMAIL);
            var agendamentoCliente = agendamentoRepositorio.ObterTodosPorCliente(emailCliente);

            return View(new HistoricoViewModel()
            {
                Agendamentos = agendamentoCliente,
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterNomeSession()
            });
        }
    }
}