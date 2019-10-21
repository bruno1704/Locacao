using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeFrota.inicio.Repositories
{
    public class ReservaRepository : BaseRepository<Reserva>, IReservaRepository
    {
        public ReservaRepository(ApplicationContext context) : base(context)
        {

        }

        public void SaveReserva(Reserva reserva)
        {
            if (reserva.Id > 0)
            {
                dbSet.Update(reserva);
                context.SaveChanges();
            }
            else
            {
                dbSet.Add(reserva);
                context.SaveChanges();

            }
        }
       






    }
    



}
