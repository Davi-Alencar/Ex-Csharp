using System.Collections.Generic;
using rltpMVC.Models;

namespace rltpMVC.ViewModels
{
    public class DashboardViewModel : BaseViewModel
    {
        public List<Agendamento> Agendamentos {get;set;}
        public List<Agendamento> AgendamentosVistos {get;set;}
        public uint PedidosAprovados {get;set;}
        public uint PedidosReprovados {get;set;}
        public uint PedidosPendentes {get;set;}
        public List<int> PedidosTotais {get;set;}
        public DashboardViewModel()
        {
            this.Agendamentos = new List<Agendamento>();
            this.PedidosTotais = new List<int>();
            this.AgendamentosVistos = new List<Agendamento>();
        }
    }
}