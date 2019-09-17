using Locacao.Models;
using Locacao.Repository;
using Microsoft.EntityFrameworkCore;

namespace Locacao
{
    public partial class Startup
    {
        class DataService : IDataService
        {
            private readonly ApplicationContext contexto;
            private readonly IUsuarioRepository usuarioRepository;
            public DataService(ApplicationContext contexto, IUsuarioRepository usuarioRepository)
            {
                this.contexto = contexto;
                this.usuarioRepository = usuarioRepository;
            }

            public void InicializaDB()
            {
                contexto.Database.Migrate();

                //usuarioRepository.SaveUsuario();
            }
        }
    }
}
