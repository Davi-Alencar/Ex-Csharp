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
    }
}