using Locacao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Locacao.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly ApplicationContext context;
      
        public UsuarioRepository(ApplicationContext context)
        {
            this.context = context;
            
        }

        public void SaveUsuario(Usuario user)//void não retorna nada
        {
            context.Set<Usuario>().Add(user);//contexto é o banco dados
            context.SaveChanges();//salva
        }

        public int BuscaUsuarioExistente (string Email)
        {
            var idEncontrado= context.Set<Usuario>().Where(w => w.Email == Email).Select(s => s.IdUsuario).FirstOrDefault();

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
