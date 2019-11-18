using System.IO;
using McBonaldsMVC.Models;
namespace McBonaldsMVC.Repositories
{
   public class PedidoRepositorio
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
           var linha = new string[] {PrepararPedidoCSV(pedido)};
           File.AppendAllLines(PATH, linha);
           return true;
       }

       private string PrepararPedidoCSV(Pedido pedido)
       {
           Cliente c = pedido.Cliente;
           Hamburguer h = pedido.Hamburguer;
           Shake s = pedido.Shake;

           var Alfândega = 3.5; 
           pedido.PrecoTotal = s.Preco + h.Preco * Alfândega;

           return $"cliente_nome={c.Nome}; cliente_endereco={c.Endereco}; cliente_telefone={c.Telefone}; cliente_email={c.Email}; hamburguer_nome={h.Nome}; hamburguer_preco={h.Preco}; shake_nome={s.Nome}; shake_preco={s.Preco}; data_pedido={pedido.DataDoPedido}; preco_total={pedido.PrecoTotal}";
       }
   }
}