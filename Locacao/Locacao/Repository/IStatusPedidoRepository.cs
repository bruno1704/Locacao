using Locacao.Models;

namespace Locacao.Repository
{
    public interface IStatusPedidoRepository
    {
        void SaveReserva(StatusPedido StatusPedido);
    }
}