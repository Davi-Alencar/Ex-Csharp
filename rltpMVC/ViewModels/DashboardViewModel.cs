using System.Collections.Generic;
using rltpMVC.Models;

namespace rltpMVC.ViewModels
{
    public class DashboardViewModel : BaseViewModel
    {
        public List<Agendamento> Agendamentos {get;set;}
        public uint PedidosAprovados {get;set;}
        public uint PedidosReprovados {get;set;}
        public uint PedidosPendentes {get;set;}
        public DashboardViewModel()
        {
            this.Agendamentos = new List<Agendamento>();
        }
    }
}