using Locacao.Models;

namespace Locacao.Repository
{
    public interface ISeguroRepository
    {
        void SaveSeguro(Seguro seguro);


        int AlgumacoisaId();

        int numeroQualquer();

        string Aluno(int id);
    }


   
}


