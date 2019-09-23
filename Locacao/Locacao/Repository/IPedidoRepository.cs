using Locacao.Models;

namespace Locacao.Repository
{
    public interface IPedidoRepository
    {
        void SaveReserva(Pedido Pedido);
    }
}