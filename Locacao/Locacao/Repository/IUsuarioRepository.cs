using Locacao.Models;
using System.Collections.Generic;

namespace Locacao.Repository
{
    public interface IUsuarioRepository
    {
        void SaveUsuario(Usuario user);
        Usuario BuscaUsuarioExistente(string Email);

        List<Usuario> BuscaListaUsuario();

        void SetUsuarioCashId(int IdUsuario);
        int? GetUsuarioCashId();

        Usuario GetUsuarioLogado();
    }
}