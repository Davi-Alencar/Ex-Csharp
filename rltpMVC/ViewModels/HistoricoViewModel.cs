using System.Collections.Generic;
using rltpMVC.Models;

namespace rltpMVC.ViewModels
{
    public class HistoricoViewModel : BaseViewModel
    {
        public List<Agendamento> Agendamentos {get;set;}
    }
}