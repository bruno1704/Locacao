using Locacao.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Locacao.Repository
{
    public class SeguroRepository : BaseRepository<Seguro>, ISeguroRepository
    {
        private readonly IHttpContextAccessor contextAccessor;
        public SeguroRepository(ApplicationContext context, IHttpContextAccessor contextAccessor) : base(context)
        {
            this.contextAccessor = contextAccessor;
        }

        public void SaveSeguro(Seguro seguro)//void não retorna nada
        {


            if (seguro.Id > 0)
            {

                dbSet.Update(seguro);
                context.SaveChanges();
            }
            else
            {
                //context.Set<Usuario>().Add(user);//contexto é o banco dados
                dbSet.Add(seguro);
                context.SaveChanges();//salva
            }

        }
        public int AlgumacoisaId()
        {
            var Número = 12;

            return Número;


        }
        public int numeroQualquer()
        {
            var lalala = 14;

            return lalala;

        }

        public string Aluno(int id)
        {
            if (id > 1)
            {
                var lallaa = "Correto é maior";
                return lallaa;
            }
            else
            {
                var lallaa = "não é correto";
                return lallaa;
            }


        }
    }
}
