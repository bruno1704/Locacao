using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Locacao.Repository
{
    public interface Itestando
    {
        string AlgumacoisPorString(String Parametro);

        int AlgumacoisporInt(int Algo);

        bool AlgumaCoisaporbool(bool parametro);

        decimal AlgumaCoisaporDEcimal(decimal Nome);

        DateTime retornaDateTime(string data);
    }
}
