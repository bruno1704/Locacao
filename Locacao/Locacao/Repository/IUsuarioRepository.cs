using Locacao.Models;

namespace Locacao.Repository
{
    public interface IUsuarioRepository
    {
        void SaveUsuario(Usuario user);
    }
}