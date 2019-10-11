using GestaoDeFrota.inicio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeFrota.inicio.Repositories
{
    public interface ISeguroRepository
    {
         void SaveSeguro(Seguro Seguro);

         Seguro BuscaUsuarioExistente(Usuario Usuario);

         List<Seguro> BuscaListaSeguro();

        

    }
}
