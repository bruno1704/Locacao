using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeFrota.inicio.Repositories
{
    public class VeiculoRepository : BaseRepository<Veiculo>, IVeiculoRepository
    {
        public VeiculoRepository(ApplicationContext context) : base(context)
        {

        }


        public void SaveVeiculo(Veiculo Veiculo)
        {
            if (Veiculo.Id > 0)
            {
                dbSet.Update(Veiculo);
                context.SaveChanges();
            }
            else
            {
                dbSet.Add(Veiculo);
                context.SaveChanges();

            }

        }
        public Veiculo BuscausuarioExistente(Usuario Usuario)
        {
            var idEncontrado = new Veiculo();
            try
            {

                idEncontrado = context.Set<Veiculo>().Where(w => w.Usuario == Usuario).FirstOrDefault();
            }
            catch (Exception e)
            {

            }



            if (idEncontrado != null)
            {

                return idEncontrado;
            }
            else
            {
                return new Veiculo();

            }

        }

        public List<Veiculo> BuscaListaVeiculo()
        {

            try
            {
                var lista = context.Set<Veiculo>().ToList(); // faz a busca no banco de dados
                return lista;
            }
            catch (Exception e)
            {
                return new List<Veiculo>();
            }

        }
        public Veiculo RetornarPorVeiculo(string veiculo)
        {
            var Veiculo = context.Set<Veiculo>().Where(w => w.veiculo == veiculo).FirstOrDefault();

            return Veiculo;

        }
        public Veiculo RetornarPorCompleto(string completo)
        {
            var Completo = context.Set<Veiculo>().Where(w => w.completo == completo).FirstOrDefault();

            return Completo;

        }

    }


}
