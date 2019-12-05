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
            AgendamentoViewModel avm = new AgendamentoViewModel();

            var usuarioLogado = ObterUsuarioSession();
            var nomeUsuarioLogado = ObterNomeSession();
            if(!string.IsNullOrEmpty(nomeUsuarioLogado))
            {
                avm.NomeCliente = nomeUsuarioLogado;
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

            ViewData["navView"] = "Nav";
            ViewData["NomeView"] = "Agendamento";
            avm.UsuarioEmail = ObterUsuarioSession();
            avm.UsuarioNome = ObterNomeSession();

            return View(avm);
        }
    }
}