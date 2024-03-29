﻿using GestaoDeFrota.inicio.Model;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Core.Mapping;

namespace GestaoDeFrota.inicio.Repositories
{
    public class RetiradaEntradaVeiculoRepository : BaseRepository<EntradaSaidaVeiculo>, IRetiradaEntradaVeiculoRepository
    {
        public RetiradaEntradaVeiculoRepository(ApplicationContext context) : base(context)
        {
        }

        public void SaveEntradaSaidaVeiculo(EntradaSaidaVeiculo EntradaSaidaVeiculo)//void não retorna nada
        {


            if (EntradaSaidaVeiculo.Id > 0)
            {

                dbSet.Update(EntradaSaidaVeiculo);
                context.SaveChanges();
            }
            else
            {
                //context.Set<Usuario>().Add(user);//contexto é o banco dados
                dbSet.Add(EntradaSaidaVeiculo);
                context.SaveChanges();//salva
            }

        }

         public async Task<(bool,EntradaSaidaVeiculo)> ExisteEntrega(int id, string data)//void não retorna nada
        {
            var existe = await
                 Task.Run(() =>  
                 context.Set<EntradaSaidaVeiculo>()
                .Where(x => x.Id==id).FirstOrDefault()
                );           

            if (existe.Entrega.ToString()==data)
            {
                return (false, new EntradaSaidaVeiculo());
            }
            else
            {
                return (true, existe);
            }

        }

        public List<EntradaSaidaVeiculo> BuscaListaEntradaSaidaVeiculo()
        {

            try
            {
                var lista = context.Set<EntradaSaidaVeiculo>().ToList(); // faz a busca no banco de dados
                return lista;
            }
            catch (Exception e)
            {
                return new List<EntradaSaidaVeiculo>();
            }


        }
        public void DeletarEntradaeSaida(EntradaSaidaVeiculo user)
        {
            try
            {
                var ES = dbSet.Remove(user);
                context.SaveChanges();

            }
            catch (Exception e)
            {


            }

        }
    }
}
