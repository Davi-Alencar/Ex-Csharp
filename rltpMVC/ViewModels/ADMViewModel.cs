using System.Collections.Generic;
using rltpMVC.Models;

namespace rltpMVC.ViewModels
{
    public class ADMViewModel : BaseViewModel
    {
        public List<Agendamento> Agendamentos {get;set;}
        public uint PedidosAprovados {get;set;}
        public uint PedidosReprovados {get;set;}
        public uint PedidosPendentes {get;set;}
        public ADMViewModel()
        {
            this.Agendamentos = new List<Agendamento>();
        }
    }
}