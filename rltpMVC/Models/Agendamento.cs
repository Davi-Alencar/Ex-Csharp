using System;
using rltpMVC.Enumeradores;

namespace rltpMVC.Models
{
    public class Agendamento
    {
        public ulong Id {get;set;}
       public Cliente Cliente {get;set;}
       public DateTime DataDoPedido {get;set;}
       public double PrecoTotal {get;set;}
       public uint Status {get;set;}

       public Agendamento()
       {
           this.Cliente = new Cliente();
           this.Id = 0;
           this.Status = (uint) StatusPedido.PENDENTE;
       }
    }
}