
using System;
using System.Collections.Generic;
using System.Data;
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
        public Veiculo BuscausuarioExistente(String Marca)
        {
            var VeiculoEncontrado = new Veiculo();
            try
            {

                VeiculoEncontrado = context.Set<Veiculo>().Where(w => w.Marca == Marca).FirstOrDefault();
            }
            catch (Exception e)
            {

            }



            if (VeiculoEncontrado != null)
            {

                return VeiculoEncontrado;
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

        internal object RetornarPorPlaca(object veiculoId)
        {
            throw new NotImplementedException();
        }

        public Veiculo RetornarPorVeiculo(string veiculo)
        {
            var Veiculo = context.Set<Veiculo>().Where(w => w.Marca == veiculo).FirstOrDefault();

            return Veiculo;

        }
        public Veiculo RetornarPorCompleto(string completo)
        {
            var Completo = context.Set<Veiculo>().Where(w => w.Marca == completo).FirstOrDefault();

            return Completo;

        }
        public Veiculo RetornarPorNome(string veiculo)
        {
            var Veiculo = context.Set<Veiculo>().Where(w => w.Modelo == veiculo).FirstOrDefault();

            return Veiculo;
        }
        public Veiculo RetornarPorPlaca(String Placa)
        {
            var Veiculo = context.Set<Veiculo>().Where(w => w.Placa == Placa).FirstOrDefault();

            //return Veiculo

            if(Veiculo != null)
            {
                return Veiculo;
            }
            else
            {

                return new Veiculo();
            }
        }
    }


}
