using Locacao.Models;
using Microsoft.EntityFrameworkCore;
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

        public Pedido SavePedido(Pedido Pedido)//void não retorna nada
        {


            if (Pedido.Id > 0)
            {

                dbSet.Update(Pedido);
                 context.SaveChanges();
                return Pedido;
            }
            else
            {
                //context.Set<Usuario>().Add(user);//contexto é o banco dados
                dbSet.Add(Pedido);
                context.SaveChanges();//salva
                return Pedido;
            }

        }
        public List<Pedido> BuscaListaPedido()
        {

            try
            {
                var lista = context.Set<Pedido>()
                   .Include(r => r.Reserva).ThenInclude(u => u.Veiculo).Include(v=>v.Reserva.usuario)
                   //.Include(r=>r.Reserva.usuario)
                   .Include(s => s.Status)
                   //.Include(v => v.Veiculo)
                   //.Where(u=>u.Reserva.usuario.Id==iduser)
                   .ToList();  // faz a busca no banco de dados
                return lista;
            }
            catch (Exception e)
            {
                return new List<Pedido>();
            }

        }

        public List<Pedido> BuscaListaPedido(int iduser)
        {

            try
            {
                var lista = context.Set<Pedido>()
                    .Include(r=>r.Reserva).ThenInclude(u => u.Veiculo).Include(v => v.Reserva.usuario)
                    //.Include(r=>r.Reserva.usuario)
                    .Include(s=>s.Status)
                    //.Include(v=>v.Veiculo)
                    //.Where(u=>u.Reserva.usuario.Id==iduser)
                    .ToList(); // faz a busca no banco de dados
                return lista;
            }
            catch (Exception e)
            {
                return new List<Pedido>();
            }

        }

        public Pedido BuscaIdPedido(int id)
        {

            try
            {
                var pedido = context.Set<Pedido>()
                    .Include(r=>r.Reserva).ThenInclude(v=>v.Veiculo)
                    .Include(s=>s.Status)
                    .Where(x=>x.Id==id).FirstOrDefault(); // faz a busca no banco de dados
                return pedido;
            }
            catch (Exception e)
            {
                return new Pedido();
            }

        }
    }
}
