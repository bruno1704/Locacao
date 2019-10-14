
using System.Linq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
//using Microsoft.AspNetCore.Http;

namespace GestaoDeFrota
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        //private readonly ApplicationContext context;//variavel tipada
        //private readonly IHttpContextAccessor contextAccessor;

        public UsuarioRepository(ApplicationContext context) : base(context)
        {
            //this.context = context;
            //this.contextAccessor = contextAccessor;


        }

        //Metodo Salvar 
        public void SaveUsuario(Usuario user)//void não retorna nada
        {


            if (user.Id > 0)
            {

                dbSet.Update(user);
                context.SaveChanges();
            }
            else
            {
                //context.Set<Usuario>().Add(user);//contexto é o banco dados
                dbSet.Add(user);
                context.SaveChanges();//salva
            }

        }

        internal IEnumerable<object> BuscarListaUsuario()
        {
            throw new NotImplementedException();
        }


        //Metodo Busca usuario
        public Usuario BuscaUsuarioExistente(string Email)
        {
            #region Ex
            // ex: para percorrer lista select mais de uma linha usa no final . Tolist
            //var listaidEncontrado = context.Set<Usuario>().Where(w => w.Email == Email).ToList();

            // criar uma variavel x, o in vai dentro da lista e seleciona a primeira posição, depois eu uso x com as propriedades da
            //primeria posição
            // foreach (var x in listaidEncontrado)
            //{
            // aqui eu uso o x para fazer a priemira posição com os dados dentro do x
            //    SaveUsuario(x);
            //} 

            // esse exemplo eu acesso a posição desejada dentro do colchete, se add isso [1].Nome;
            //acesso 
            //var r = listaidEncontrado[1];
            #endregion
            var idEncontrado = new Usuario();
            try
            {
                idEncontrado = context.Set<Usuario>().Where(w => w.Email == Email).FirstOrDefault(); // faz a busca no banco de dados
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
                return new Usuario();
            }
        }//f10

        public List<Usuario> BuscaListaUsuario()
        {

            try
            {
                var lista = context.Set<Usuario>().ToList(); // faz a busca no banco de dados
                return lista;
            }
            catch (Exception e)
            {
                return new List<Usuario>();
            }

        }

        //public int? GetUsuarioCashId()
        //{
        //    return contextAccessor.HttpContext.Session.GetInt32("Id");
        //}

        //public void SetUsuarioCashId(int IdUsuario)
        //{
        //    contextAccessor.HttpContext.Session.SetInt32("Id", IdUsuario);
        //}

        //public void ClearCashId()
        //{
        //    var id = contextAccessor.HttpContext.Session.GetInt32("Id");
        //    contextAccessor.HttpContext.Session.Clear();

        //    id = contextAccessor.HttpContext.Session.GetInt32("Id");

        //}

        public bool ValidaAdm(int id)
        {
            //var id = contextAccessor.HttpContext.Session.GetInt32("Id");
            var user = dbSet.Where(u => u.Id == id).SingleOrDefault();
            if (user.Administrador)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        public Usuario GetUsuarioLogado(int id)
        {
            //var id = contextAccessor.HttpContext.Session.GetInt32("Id");

            try
            {
                var UserLogado = context.Set<Usuario>().Where(w => w.Id == id).FirstOrDefault(); // faz a busca no banco de dados
                return UserLogado;
                // return new Usuario();
            }
            catch (Exception e)
            {
                return new Usuario();
            }
        }
        public Usuario BuscaUsuarioporId(int Idusuario)
        {
            var usuario = context.Set<Usuario>().Where(w => w.Id == Idusuario).FirstOrDefault();

            return usuario;

        }

        public string BuscaNome(int Id)
        {
            if (Id == 1)
            {
                var retornostring = "é adm";

                return retornostring;
            }
            else
            {
                var retornostring = "ñ é adm";
                return retornostring;
            }

        }

        public bool ExisteUsuario(Usuario Usuario)
        {
            var usuarioencontrado = context.Set<Usuario>().Where(w => w.Email == Usuario.Email && w.Senha == Usuario.Senha).FirstOrDefault();

            if (usuarioencontrado == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public Usuario RetornarPorEmail(string nome)
        {
            var usuario = context.Set<Usuario>().Where(w => w.Nome == nome).FirstOrDefault();

            return usuario;

           
        }
        

    }



}

