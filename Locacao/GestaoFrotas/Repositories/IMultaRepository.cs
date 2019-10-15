using GestaoDeFrota.inicio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeFrota.inicio.Repositories
{
    public interface IMultaRepository
    {

        void SaveMulta(Multa Multa);

        Multa BuscaUsuarioExistente(Usuario Usuario);

        List<Multa> BuscaListaMulta();

        Multa RetornarMultaPorVeiculo(Veiculo veiculo);

        void DeletarMulta(Multa user);
    }
}
