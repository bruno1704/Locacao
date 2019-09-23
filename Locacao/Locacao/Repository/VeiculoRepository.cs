using Locacao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Locacao.Repository
{
    public class VeiculoRepository : BaseRepository<Veiculo>,IVeiculoRepository
    {
        public VeiculoRepository(ApplicationContext context) : base(context)
        {
        }

        public void SaveReserva(Veiculo Veiculo)//void não retorna nada
        {


            if (Veiculo.Id > 0)
            {

                dbSet.Update(Veiculo);
                context.SaveChanges();
            }
            else
            {
                //context.Set<Usuario>().Add(user);//contexto é o banco dados
                dbSet.Add(Veiculo);
                context.SaveChanges();//salva
            }

        }
    }
}
