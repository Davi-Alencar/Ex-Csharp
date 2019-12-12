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
                agendamento.Cliente = new Cliente();
                agendamento.Pagamento = new Pagamento();
                agendamento.Evento = new Evento();
                
                agendamento.Id = ulong.Parse(ExtrairValorDoCampo("id", linha));
                agendamento.Status = uint.Parse(ExtrairValorDoCampo("status_pedido", linha));
                agendamento.Cliente.Nome = ExtrairValorDoCampo("cliente_nome", linha);
                agendamento.Cliente.Cpfcnpj = ExtrairValorDoCampo("cliente_cpfcnpj", linha);
                agendamento.Cliente.Telefone = ExtrairValorDoCampo("cliente_telefone", linha);
                agendamento.Cliente.Email = ExtrairValorDoCampo("cliente_email", linha);
                agendamento.Evento.tipoEvento = ExtrairValorDoCampo("evento_tipoEvento", linha);
                agendamento.Evento.dataEvento = DateTime.Parse(ExtrairValorDoCampo("evento_dataEvento", linha));
                agendamento.Evento.inicioEvento = ExtrairValorDoCampo("evento_inicioEvento", linha);
                agendamento.Evento.terminoEvento = ExtrairValorDoCampo("evento_terminoEvento", linha);
                agendamento.Evento.numPessoas = ExtrairValorDoCampo("evento_numPessoas", linha);
                agendamento.Evento.descricaoEvento = ExtrairValorDoCampo("evento_descricaoEvento", linha);
                agendamento.Pagamento.metodoPagamento = ExtrairValorDoCampo("pagamento_metodoPagamento", linha);
                agendamento.Pagamento.Bandeira = ExtrairValorDoCampo("pagamento_Bandeira", linha);
                agendamento.Pagamento.numCartao = ExtrairValorDoCampo("pagamento_numCartao", linha);
                agendamento.Pagamento.nomeTitular = ExtrairValorDoCampo("pagamento_nomeTitular", linha);
                agendamento.Pagamento.Validade = ExtrairValorDoCampo("pagamento_Validade", linha);
                agendamento.Pagamento.CVV = ExtrairValorDoCampo("pagamento_CVV", linha);
                agendamento.Pagamento.Som = ExtrairValorDoCampo("pagamento_Som", linha);
                agendamento.Pagamento.Luz = ExtrairValorDoCampo("pagamento_Luz", linha);
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

        public int ObterPorPedidosTotais(Agendamento agendamento)
        {
            var pedidosTotais = ObterTodos();
            int eventos = 0;
            foreach(var item in pedidosTotais)
            {
                if(item.Status != (uint) Enumeradores.StatusPedido.PENDENTE)
                {
                    eventos++;
                }
            }
            return eventos;
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
                    break;
                }
            }

            if(resultado)
            {
                pedidosTotais[linhaPedido] = pedidosCSV;
                File.WriteAllLines(PATH,pedidosTotais);
            }

            return resultado;
        }

       public string PrepararPedidoCSV(Agendamento agendamento)
       {
           Cliente c = agendamento.Cliente;
           Evento e = agendamento.Evento;
           Pagamento p = agendamento.Pagamento;

           return $"id={agendamento.Id};status_pedido={agendamento.Status};cliente_nome={c.Nome};cliente_cpfcnpj={c.Cpfcnpj};cliente_telefone={c.Telefone};cliente_email={c.Email};evento_tipoEvento={e.tipoEvento};evento_dataEvento={e.dataEvento};evento_inicioEvento={e.inicioEvento};evento_terminoEvento={e.terminoEvento};evento_numPessoas={e.numPessoas};evento_descricaoEvento={e.descricaoEvento};pagamento_metodoPagamento={p.metodoPagamento};pagamento_Bandeira={p.Bandeira};pagamento_numCartao={p.numCartao};pagamento_nomeTitular={p.nomeTitular};pagamento_Validade={p.Validade};pagamento_CVV={p.CVV};pagamento_Som={p.Som};pagamento_Luz={p.Luz};data_pedido={agendamento.DataDoPedido};preco_total={agendamento.PrecoTotal}";
       }

    }
}