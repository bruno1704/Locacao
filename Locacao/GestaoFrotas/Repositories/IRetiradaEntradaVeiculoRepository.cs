using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestaoDeFrota.inicio.Repositories
{
    public interface IRetiradaEntradaVeiculoRepository
    {
        void SaveEntradaSaidaVeiculo(EntradaSaidaVeiculo EntradaSaidaVeiculo);
        List<EntradaSaidaVeiculo> BuscaListaEntradaSaidaVeiculo();

        //bool ExisteEntrega(int id, string data);

         Task<(bool, EntradaSaidaVeiculo)> ExisteEntrega(int id, string data);

        void DeletarEntradaeSaida(EntradaSaidaVeiculo user);
    }
}
