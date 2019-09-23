﻿using Locacao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Locacao.Repository
{
    public class ReservaRepository : BaseRepository<Reserva>, IReservaRepository
    {
        public ReservaRepository(ApplicationContext context) : base(context)
        {
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
                var lista = context.Set<Reserva>().ToList(); // faz a busca no banco de dados
                return lista;
            }
            catch (Exception e)
            {
                return new List<Reserva>();
            }

        }
    }
}