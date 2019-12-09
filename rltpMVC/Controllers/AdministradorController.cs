using Microsoft.AspNetCore.Mvc;
using rltpMVC.Enumeradores;
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
                ADMViewModel admViewModel = new ADMViewModel();

                foreach(var pedido in pedidos)
                {
                    switch(pedido.Status)
                    {
                        case (uint) StatusPedido.APROVADO:
                            admViewModel.PedidosAprovados++;
                        break;

                        case (uint) StatusPedido.REPROVADO:
                            admViewModel.PedidosReprovados++;
                        break;

                        default:
                            admViewModel.PedidosPendentes++;
                            admViewModel.Agendamentos.Add(pedido);
                        break;
                    }
                }
                admViewModel.NomeView = "Dashboard";
                admViewModel.UsuarioEmail= ObterUsuarioSession();

                return View(admViewModel); 
            } else {
                return View("Erro", new RespostaViewModel()
                {
                    NomeView = "Dashboard",
                    Mensagem = "Você não tem permissão para acessar como Adm"
                });
            }
        }
    }
}