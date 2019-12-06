using System;
using System.Collections.Generic;
using System.IO;
using rltpMVC.Models;

namespace rltpMVC.Repositorio
{
    public class AgendamentoRepositorio : RepositorioBase
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

       public List<Agendamento> ObterTodosPorCliente(string emailCliente)
       {
           var pedidos = ObterTodos();
           List<Agendamento> agendamentosCliente = new List<Agendamento>();

           foreach (var agendamento in pedidos)
           {
               if(agendamento.Cliente.Email.Equals(emailCliente))
               {
                   agendamentosCliente.Add(agendamento);
               }
           }
            return agendamentosCliente;
       }

        public List<Agendamento> ObterTodos()
        {
            var linhas = File.ReadAllLines(PATH);
            List<Agendamento> agendamentos = new List<Agendamento>();

            foreach (var linha in linhas)
            {
                Agendamento agendamento = new Agendamento();
                
                agendamento.Id = ulong.Parse(ExtrairValorDoCampo("id", linha));
                agendamento.Status = uint.Parse(ExtrairValorDoCampo("status_pedido", linha));
                agendamento.Cliente = new Cliente();
                agendamento.Cliente.Nome = ExtrairValorDoCampo("cliente_nome", linha);
                agendamento.Cliente.Telefone = ExtrairValorDoCampo("cliente_telefone", linha);
                agendamento.Cliente.Email = ExtrairValorDoCampo("cliente_email", linha);
                agendamento.PrecoTotal = double.Parse(ExtrairValorDoCampo("preco_total", linha));
                agendamento.DataDoPedido = DateTime.Parse(ExtrairValorDoCampo("data_pedido", linha));
                
                agendamentos.Add(agendamento);
            }
            return agendamentos;
        }

        public Agendamento ObterPor(ulong id)
        {
            var agendamentosTotais = ObterTodos();
            foreach(var agendamento in agendamentosTotais)
            {
                if(id.Equals(agendamento.Id))
                {
                    return agendamento;
                }
            }
            return null;
        }
        public bool Atualizar(Agendamento agendamento)
        {
            var pedidosTotais = File.ReadAllLines(PATH);
            var pedidosCSV = PrepararPedidoCSV(agendamento);
            var linhaPedido = -1;
            var resultado = false;

            for(int i = 0; i < pedidosTotais.Length; i++)
            {
                var idConvertido = ulong.Parse(ExtrairValorDoCampo("id", pedidosTotais[i]));
                if(agendamento.Id.Equals(idConvertido))
                {
                    linhaPedido = i;
                    resultado = true;
                }
            }

            if(resultado)
            {
                pedidosTotais[linhaPedido] = pedidosCSV;
                File.WriteAllLines(PATH,pedidosTotais);
            }

            return resultado;
        }

       private string PrepararPedidoCSV(Agendamento agendamento)
       {
           Cliente c = agendamento.Cliente;

           return $"id={agendamento.Id};status_pedido={agendamento.Status};cliente_nome={c.Nome};cliente_telefone={c.Telefone};cliente_email={c.Email};data_pedido={agendamento.DataDoPedido};preco_total={agendamento.PrecoTotal}";
       }

    }
}