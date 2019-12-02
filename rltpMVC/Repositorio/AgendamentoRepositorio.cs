using System;
using System.Collections.Generic;
using System.IO;
using rltpMVC.Models;

namespace rltpMVC.Repositorio
{
    public class AgendamentoRepositorio
    {
       private const string PATH = "Database/Agendamento.csv";

       public AgendamentoRepositorio()
       {
           if(!File.Exists(PATH))
           {
               File.Create(PATH).Close();
           }
       }

       public bool Inserir(Agendamento agendamento)
       {
           var quantidadePedidos = File.ReadAllLines(PATH).Length;
           agendamento.Id = (ulong) ++quantidadePedidos;
           var linha = new string[] {PrepararPedidoCSV(agendamento)};
           File.AppendAllLines(PATH, linha);
           return true;
       }

       private string PrepararPedidoCSV(Agendamento agendamento)
       {
           Cliente c = agendamento.Cliente;

           return $"id={agendamento.Id};status_pedido={agendamento.Status};cliente_nome={c.Nome};cliente_telefone={c.Telefone};cliente_email={c.Email};data_pedido={agendamento.DataDoPedido};preco_total={agendamento.PrecoTotal}";
       }

    }
}