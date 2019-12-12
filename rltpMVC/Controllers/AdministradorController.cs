using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using rltpMVC.Enumeradores;
using rltpMVC.Models;
using rltpMVC.Repositorio;
using rltpMVC.ViewModels;

namespace rltpMVC.Controllers
{
    public class AdministradorController : AbstractController
    {
        AgendamentoRepositorio agendamentoRepositorio = new AgendamentoRepositorio(); 
        ClienteRepositorio clienteRepositorio = new ClienteRepositorio();
        AgendamentoViewModel agendamentoViewModel = new AgendamentoViewModel();
        public IActionResult Dashboard()
        {
            ViewData["NomeView"] = "Administrador";
            ViewData["navView"] = "Nav";
            
            var ninguemLogado = string.IsNullOrEmpty(ObterUsuarioTipoSession());
            
            if (!ninguemLogado && (uint) TipoUsuario.ADMINISTRADOR == uint.Parse(ObterUsuarioTipoSession()))
            {

                var pedidos = agendamentoRepositorio.ObterTodos();
                DashboardViewModel dashboardViewModel = new DashboardViewModel();

                foreach(var pedido in pedidos)
                {
                    switch(pedido.Status)
                    {
                        case (uint) StatusPedido.APROVADO:
                            dashboardViewModel.PedidosAprovados++;
                        break;

                        case (uint) StatusPedido.REPROVADO:
                            dashboardViewModel.PedidosReprovados++;
                        break;

                        default:
                            dashboardViewModel.PedidosPendentes++;
                            dashboardViewModel.Agendamentos.Add(pedido);
                        break;
                    }

                    var pedidosTotais= agendamentoRepositorio.ObterPorPedidosTotais(pedido);
                    dashboardViewModel.PedidosTotais.Add(pedidosTotais);
                }

                
                dashboardViewModel.NomeView = "Dashboard";
                dashboardViewModel.UsuarioEmail= ObterUsuarioSession();

                return View(dashboardViewModel); 
            } else {
                return View("Erro", new RespostaViewModel()
                {
                    NomeView = "Dashboard",
                    Mensagem = "Você não tem permissão para acessar o Dashboard"
                });
            }
        }

        public IActionResult DadosPedidos(ulong id)
        {
            ViewData["navView"] = "Nav";
            ViewData["NomeView"] = "Menu";
            
            AgendamentoViewModel avm = new AgendamentoViewModel();
            var evento = agendamentoRepositorio.ObterPor(id);

            avm.Agendamento = evento;
            avm.UsuarioEmail = ObterUsuarioSession();
            avm.UsuarioNome = ObterNomeSession();
            avm.NomeView = "Nao sei";

            return View(avm);
        }
    }
}