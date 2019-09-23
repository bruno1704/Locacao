using Locacao.Models;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Locacao.Repository
{
    public class UsuarioRepository : BaseRepository<Usuario>,IUsuarioRepository
    {
        //private readonly ApplicationContext context;//variavel tipada
        private readonly IHttpContextAccessor contextAccessor;

        public UsuarioRepository(ApplicationContext context, IHttpContextAccessor contextAccessor) :base(context)
        {
            //this.context = context;
            this.contextAccessor = contextAccessor;


        }

        //Metodo Salvar 
        public void SaveUsuario(Usuario user)//void não retorna nada
        {
            

            if (user.Id>0)            {
                
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


        //Metodo Busca usuario
        public Usuario BuscaUsuarioExistente (string Email)
        {
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

            var idEncontrado=new Usuario();
            try
            {
                 idEncontrado = context.Set<Usuario>().Where(w => w.Email == Email).FirstOrDefault(); // faz a busca no banco de dados
            }
            catch (Exception e )
            {
                
            }
           

            
            // where busca tudo
            if (idEncontrado !=null ) // se estiver 1 é pq está cadastrado, comforme o numero de Id do usuário que fica no Sql
            {
                SetUsuarioCashId(idEncontrado.Id);
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

        public int? GetUsuarioCashId()
        {
            return contextAccessor.HttpContext.Session.GetInt32("Id");
        }

        public void SetUsuarioCashId(int IdUsuario)
        {
            contextAccessor.HttpContext.Session.SetInt32("Id", IdUsuario);
        }

        public Usuario GetUsuarioLogado()
        {
            var id = contextAccessor.HttpContext.Session.GetInt32("Id");
            
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
        
    }
}
