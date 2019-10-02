using Locacao.Models;
using System.Collections.Generic;

namespace Locacao.Repository
{
    public interface IVeiculoRepository
    {
        void SaveReserva(Veiculo Veiculo);
        //List<Veiculo> BuscaListaReserva();
        List<Veiculo> BuscaListaVeiculo();

        Veiculo GetVeiculoId(int IdVeiculo);

        Veiculo Carro(Veiculo veiculo);
    }
}