using Locacao.Models;
using System.Collections.Generic;

namespace Locacao.Repository
{
    public interface IPedidoRepository
    {

        Pedido SavePedido(Pedido Pedido);
        List<Pedido> BuscaListaPedido();
        List<Pedido> BuscaListaPedido(int iduser);

        Pedido BuscaIdPedido(int id);
    }
}