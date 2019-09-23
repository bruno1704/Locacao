using Locacao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Locacao.Repository
{
    public class PedidoRepository : BaseRepository<Pedido>, IPedidoRepository
    {
        public PedidoRepository(ApplicationContext context) : base(context)
        {
        }

        public void SaveReserva(Pedido Pedido)//void não retorna nada
        {


            if (Pedido.Id > 0)
            {

                dbSet.Update(Pedido);
                context.SaveChanges();
            }
            else
            {
                //context.Set<Usuario>().Add(user);//contexto é o banco dados
                dbSet.Add(Pedido);
                context.SaveChanges();//salva
            }

        }
    }
}
