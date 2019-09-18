using Locacao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Locacao.Repository
{
    public class UsuarioRepository : BaseRepository<Usuario>,IUsuarioRepository
    {
        //private readonly ApplicationContext context;
      
        public UsuarioRepository(ApplicationContext context):base(context)
        {
            //this.context = context;
            
        }

        public void SaveUsuario(Usuario user)//void não retorna nada
        {
            //context.Set<Usuario>().Add(user);//contexto é o banco dados
            dbSet.Add(user);
            context.SaveChanges();//salva
            
        }

        public int BuscaUsuarioExistente (string Email)
        {
            var idEncontrado= dbSet.Where(w => w.Email == Email).Select(s => s.Id).FirstOrDefault(); //context.Set<Usuario>().Where(w => w.Email == Email).Select(s => s.Id).FirstOrDefault();

            if (idEncontrado==0 )
            {
                return 0;

            }
            else
            {
                return idEncontrado;
            }
        }
    }
}
