using System.Collections.Generic;
using rltpMVC.Models;

namespace rltpMVC.ViewModels
{
    public class AgendamentoViewModel : BaseViewModel
    {
        public Cliente Cliente {get; set;}
        public Evento Evento {get; set;}
        public Pagamento Pagamento {get; set;}
        public string NomeCliente {get; set;}
        public Agendamento Agendamento {get;set;}
        public List<Cliente> Clientes {get; set;}
        public List<Evento> Eventos {get; set;}
        public List<Pagamento> Pagamentos {get; set;}
        public List<Agendamento> Agendamentos {get; set;}

        public AgendamentoViewModel()
        {
            this.Cliente = new Cliente();
            this.Evento = new Evento();
            this.Pagamento = new Pagamento();
            this.Pagamentos = new List<Pagamento>();
            this.Eventos = new List<Evento>();
            this.Agendamentos = new List<Agendamento>();
            this.Agendamento = new Agendamento();


            this.NomeCliente = "Pede aí, Corno!";
        }
    }
}