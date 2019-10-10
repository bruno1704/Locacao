
using System.Collections.Generic;

namespace GestaoDeFrota
{
    public interface IUsuarioRepository
    {
        void SaveUsuario(Usuario user);
        Usuario BuscaUsuarioExistente(string Email);

        List<Usuario> BuscaListaUsuario();

        //void SetUsuarioCashId(int IdUsuario);
        //int? GetUsuarioCashId(int id);
        Usuario GetUsuarioLogado(int id);

        //void ClearCashId();

        bool ValidaAdm(int id);

        Usuario BuscaUsuarioporId(int Idusuario);

        string BuscaNome(int Id);

        bool ExisteUsuario(Usuario Usuario);

        Usuario RetornarPorEmail(string nome);

        //string MultaRepository 
    }
}