using Locacao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Locacao.Repository
{
    public class StatusPedidoRepository : BaseRepository<StatusPedido>, IStatusPedidoRepository
    {
        public StatusPedidoRepository(ApplicationContext context) : base(context)
        {
        }
        public void SaveReserva(StatusPedido StatusPedido)//void não retorna nada
        {


            if (StatusPedido.Id > 0)
            {

                dbSet.Update(StatusPedido);
                context.SaveChanges();
            }
            else
            {
                //context.Set<Usuario>().Add(user);//contexto é o banco dados
                dbSet.Add(StatusPedido);
                context.SaveChanges();//salva
            }

        }
    }

}
