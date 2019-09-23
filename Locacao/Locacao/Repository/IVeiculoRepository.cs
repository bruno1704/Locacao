using Locacao.Models;

namespace Locacao.Repository
{
    public interface IVeiculoRepository
    {
        void SaveReserva(Veiculo Veiculo);
    }
}