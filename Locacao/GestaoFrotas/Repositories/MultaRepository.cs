using GestaoDeFrota.inicio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeFrota.inicio.Repositories
{
    public class MultaRepository : BaseRepository<Multa>, IMultaRepository
    {

        public MultaRepository(ApplicationContext context) : base(context)
        {
            //this.context = context;
            //this.contextAccessor = contextAccessor;
        }

        public void SaveMulta(Multa Multa)//void não retorna nada
        {


            if (Multa.Id > 0)
            {

                dbSet.Update(Multa);
                context.SaveChanges();
            }
            else
            {
                //context.Set<Usuario>().Add(user);//contexto é o banco dados
                dbSet.Add(Multa);
                context.SaveChanges();//salva
            }

        }

        public Multa BuscaUsuarioExistente(Usuario Usuario)
        {
           
            var idEncontrado = new Multa();
            try
            {
                idEncontrado = context.Set<Multa>().Where(w => w.Usuario == Usuario).FirstOrDefault(); // faz a busca no banco de dados
            }
            catch (Exception e)
            {

            }



            // where busca tudo
            if (idEncontrado != null) // se estiver 1 é pq está cadastrado, comforme o numero de Id do usuário que fica no Sql
            {
                //SetUsuarioCashId(idEncontrado.Id);
                return idEncontrado;

            }
            else
            {
                return new Multa();
            }
        }

        public List<Multa> BuscaListaMulta()
        {

            try
            {
                var lista = context.Set<Multa>().ToList(); // faz a busca no banco de dados
                return lista;
            }
            catch (Exception e)
            {
                return new List<Multa>();
            }

        }

    }
}
