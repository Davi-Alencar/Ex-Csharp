using rltpMVC.Models;

namespace rltpMVC.ViewModels
{
    public class AgendamentoViewModel : BaseViewModel
    {
        public Cliente Cliente {get; set;}
        public string NomeCliente {get; set;}

        public AgendamentoViewModel()
        {
            this.Cliente = new Cliente();
            this.NomeCliente = "Pede aí, Corno!";
        }
    }
}