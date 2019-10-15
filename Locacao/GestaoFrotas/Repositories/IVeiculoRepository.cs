using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeFrota.inicio.Repositories
{
    interface IVeiculoRepository
    {
        void SaveVeiculo(Veiculo Veiculo);

        Veiculo BuscausuarioExistente(string Marca);

        List<Veiculo> BuscaListaVeiculo();

        Veiculo RetornarPorVeiculo(string veiculo);

        Veiculo RetornarPorCompleto(string Completo);

        Veiculo RetornarPorNome(string veiculo);

        Veiculo RetornarPorPlaca(String Placa);

        void DeletarVeiculo(Veiculo user);



    }
}
