using GestaoDeFrota.inicio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeFrota.inicio.Repositories
{
    public class SinistroRepository : BaseRepository<Sinistro>,ISinistroRepository
    {

        public SinistroRepository(ApplicationContext context): base(context)
        {

        }

        public void SaveSinistro(Sinistro Sinistro)
        {
            if (Sinistro.Id > 0)
            {                
                dbSet.Update(Sinistro);
                context.SaveChanges();
            }
            else
            {
                //context.Set<Usuario>().Add(user);//contexto é o banco dados
                dbSet.Add(Sinistro);
                context.SaveChanges();//salva
            }
        }
        public Sinistro BuscaUsuarioExistente(Usuario Usuario)
        {
            var idEncontrado = new Sinistro();
            try
            {
                idEncontrado = context.Set<Sinistro>().Where(w => w.Usuario == Usuario).FirstOrDefault(); // faz a busca no banco de dados
            }
            catch (Exception e)
            {

            }

            if (idEncontrado != null) // se estiver 1 é pq está cadastrado, comforme o numero de Id do usuário que fica no Sql
            {
                //SetUsuarioCashId(idEncontrado.Id);
                return idEncontrado;

            }
            else
            {
                return new Sinistro();
            }


        }
        public List<Sinistro> BuscaListaSinistro()
        {
            try
            {
                var lista = context.Set<Sinistro>().ToList(); // faz a busca no banco de dados
                return lista;
            }
            catch (Exception e)
            {
                return new List<Sinistro>();
            }

        }
        public Usuario RetornarPorEmail(string nome)
        {
            var usuario = context.Set<Usuario>().Where(w => w.Nome == nome).FirstOrDefault();

            return usuario;
        }

            



    }
}
