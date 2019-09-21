using Locacao.Models;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Locacao.Repository
{
    public class UsuarioRepository : BaseRepository<Usuario>,IUsuarioRepository
    {
        private readonly ApplicationContext context;//variavel tipada
      
        public UsuarioRepository(ApplicationContext context):base(context)
        {
            //this.context = context;
            
        }

        //Metodo Salvar 
        public void SaveUsuario(Usuario user)//void não retorna nada
        {
            //context.Set<Usuario>().Add(user);//contexto é o banco dados
            dbSet.Add(user);
            context.SaveChanges();//salva
            
        }


        //Metodo Busca usuario
        public int BuscaUsuarioExistente (string Email)
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

            var idEncontrado = context.Set<Usuario>().Where(w => w.Email == Email).Select(s => s.IdUsuario).FirstOrDefault(); // faz a busca no banco de dados

            
            // where busca tudo
            if (idEncontrado == 0 ) // se estiver 1 é pq está cadastrado, comforme o numero de Id do usuário que fica no Sql
            {
                return idEncontrado;

            }
            else
            {
                return 0;
            }
        }//f10
    }
}
