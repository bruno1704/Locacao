using Locacao.Models;
using System.Collections.Generic;

namespace Locacao.Repository
{
    public interface IPedidoRepository
    {

        void SaveReserva(Pedido Pedido);
        List<Pedido> BuscaListaPedido();
    }
}