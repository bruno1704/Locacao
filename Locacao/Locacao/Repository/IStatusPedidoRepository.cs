using Locacao.Models;

namespace Locacao.Repository
{
    public interface IStatusPedidoRepository
    {
        void SaveStatus(StatusPedido StatusPedido);
        StatusPedido GetstatusId(int id);
    }
}