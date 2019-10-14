using GestaoDeFrota.inicio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeFrota.inicio.Repositories
{
    public interface ISinistroRepository
    {
        void SaveSinistro(Sinistro Sinistro);

        Sinistro BuscaUsuarioExistente(Usuario Usuario);

        List<Sinistro> BuscaListaSinistro();

        Usuario RetornarPorEmail(string nome);

        



    }
}
