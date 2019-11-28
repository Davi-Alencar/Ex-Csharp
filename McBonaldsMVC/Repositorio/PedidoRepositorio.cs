using System;
using System.Collections.Generic;
using System.IO;
using McBonaldsMVC.Models;
using McBonaldsMVC.Repositorio;

namespace McBonaldsMVC.Repositories
{
   public class PedidoRepositorio : RepositorioBase
   {
       private const string PATH = "Database/Pedido.csv";
       public PedidoRepositorio()
       {
           if(!File.Exists(PATH))
           {
               File.Create(PATH).Close();
           }
       }

       public bool Inserir(Pedido pedido)
       {
           var quantidadePedidos = File.ReadAllLines(PATH).Length;
           pedido.Id = (ulong) ++quantidadePedidos;
           var linha = new string[] {PrepararPedidoCSV(pedido)};
           File.AppendAllLines(PATH, linha);
           return true;
       }

       public List<Pedido> ObterTodosPorCliente(string emailCliente)
       {
           var pedidos = ObterTodos();
           List<Pedido> pedidosCliente = new List<Pedido>();

           foreach (var pedido in pedidos)
           {
               if(pedido.Cliente.Email.Equals(emailCliente))
               {
                   pedidosCliente.Add(pedido);
               }
           }
            return pedidosCliente;
       }

        public List<Pedido> ObterTodos()
        {
            var linhas = File.ReadAllLines(PATH);
            List<Pedido> pedidos = new List<Pedido>();

            foreach (var linha in linhas)
            {
                Pedido pedido = new Pedido();
                
                pedido.Id = ulong.Parse(ExtrairValorDoCAmpo("id", linha));
                pedido.Status = uint.Parse(ExtrairValorDoCAmpo("status_pedido", linha));
                pedido.Cliente = new Cliente();
                pedido.Cliente.Nome = ExtrairValorDoCAmpo("cliente_nome", linha);
                pedido.Cliente.Endereco = ExtrairValorDoCAmpo("cliente_endereco", linha);
                pedido.Cliente.Telefone = ExtrairValorDoCAmpo("cliente_telefone", linha);
                pedido.Cliente.Email = ExtrairValorDoCAmpo("cliente_email", linha);
                pedido.Hamburguer.Nome = ExtrairValorDoCAmpo("hamburguer_nome", linha);
                pedido.Hamburguer.Preco = double.Parse(ExtrairValorDoCAmpo("hamburguer_preco", linha));
                pedido.Shake.Nome = ExtrairValorDoCAmpo("shake_nome", linha);
                pedido.Shake.Preco = double.Parse(ExtrairValorDoCAmpo("shake_preco", linha));
                pedido.PrecoTotal = double.Parse(ExtrairValorDoCAmpo("preco_total", linha));
                pedido.DataDoPedido = DateTime.Parse(ExtrairValorDoCAmpo("data_pedido", linha));
                
                pedidos.Add(pedido);
            }
            return pedidos;
        }
       private string PrepararPedidoCSV(Pedido pedido)
       {
           Cliente c = pedido.Cliente;
           Hamburguer h = pedido.Hamburguer;
           Shake s = pedido.Shake;

           var Alfândega = 1.5; 
           pedido.PrecoTotal = (s.Preco + h.Preco) * Alfândega;

           return $"id={pedido.Id};status_pedido={pedido.Status};cliente_nome={c.Nome};cliente_endereco={c.Endereco};cliente_telefone={c.Telefone};cliente_email={c.Email};hamburguer_nome={h.Nome};hamburguer_preco={h.Preco};shake_nome={s.Nome};shake_preco={s.Preco};data_pedido={pedido.DataDoPedido};preco_total={pedido.PrecoTotal}";
       }
   }
}