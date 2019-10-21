using Locacao.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Locacao.Repository
{
    public class ReservaRepository : BaseRepository<Reserva>, IReservaRepository
    {
        private readonly IHttpContextAccessor contextAccessor;
        public ReservaRepository(ApplicationContext context, IHttpContextAccessor contextAccessor) : base(context)
        {
            this.contextAccessor = contextAccessor;
        }

        public void SaveReserva(Reserva reserva)//void não retorna nada
        {


            if (reserva.Id > 0)
            {
                
                dbSet.Update(reserva);
                context.SaveChanges();
            }
            else
            {
                //context.Set<Usuario>().Add(user);//contexto é o banco dados
                dbSet.Add(reserva);
                context.SaveChanges();//salva
            }

        }


        //Metodo Busca usuario
        public List<Reserva> BuscaListaReserva()
        {

            try
            {
                var lista = dbSet
                    .Include(v => v.Veiculo)
                    .Include(v=>v.StatusPedido)
                    .Include(u => u.usuario)
                    .ToList(); // faz a busca no banco de dados
                return lista;
            }
            catch (Exception e)
            {
                return new List<Reserva>();
            }

        }

        public List<Reserva> BuscaListaReserva(int idUser)
        {

            try
            {
                var lista = dbSet
                    .Include(v => v.Veiculo)
                    .Include(u => u.usuario)
                    .Include(s=>s.StatusPedido)
                    .Where(u=>u.usuario.Id== idUser)
                    .ToList(); // faz a busca no banco de dados
                return lista;
            }
            catch (Exception e)
            {
                return new List<Reserva>();
            }

        }

        public Reserva BuscaReservaId(int IdReserva)
        {

            try
            {
                var Reserva = dbSet
                    .Include(v => v.Veiculo)
                    .Include(u => u.usuario)
                    .Where(r=>r.Id==IdReserva)
                    .FirstOrDefault(); // faz a busca no banco de dados
                return Reserva;
            }
            catch (Exception e)
            {
                return new Reserva();
            }

        }

        public string algumacoisaretornaporstring(string parametrox)
        {

            var s = parametrox;


            return "";
        }
    }
}
