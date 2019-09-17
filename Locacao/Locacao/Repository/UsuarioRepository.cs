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

        public void SaveUsuario(Usuario user)
        {
            context.Set<Usuario>().Add(user);
            context.SaveChanges();
        }
    }
}
