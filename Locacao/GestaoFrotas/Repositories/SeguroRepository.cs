using GestaoDeFrota.inicio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeFrota.inicio.Repositories
{
    public class SeguroRepository : BaseRepository<Seguro>,ISeguroRepository
    {
        
        public SeguroRepository(ApplicationContext context): base(context)
        {
            //this.context = context;
            //this.contextAccessor = contextAccessor;


        }
        public void SaveSeguro(Seguro Seguro)
        {
            if (Seguro.Id > 0)
            {
                dbSet.Update(Seguro);
                context.SaveChanges();
            }
            else
            {
                dbSet.Add(Seguro);
                context.SaveChanges();

            }
   
        }

        internal IEnumerable<object> BuscarListaSeguro()
        {
            throw new NotImplementedException();
        }

        public Seguro BuscaUsuarioExistente(Usuario Usuario)
        {
            var idEncontrado = new Seguro();
            try
            {
                idEncontrado = context.Set<Seguro>().Where(w => w.UsuarioId == Usuario.Id).FirstOrDefault(); // faz a busca no banco de dados
                //propriedade seguro é o mesmo que usuario?
                //ja te falei que tudo que é usuario muda pra seguro a nao ser que tenho um usuario dentro da seguro
                //aparentemetne nao esta comparando direito as propriedades
            }
            catch (Exception e)
            {

            }

            if (idEncontrado != null) // se estiver 1 é pq está cadastrado, comforme o numero de Id do usuário que fica no Sql
            {
                //SetUsuarioCashId(idEncontrado.Id);
                return idEncontrado;

            }
            else
            {
                return new Seguro();
            }

        }

        public List<Seguro> BuscaListaSeguro()
        {
            try
            {
                var lista = context.Set<Seguro>().ToList(); // faz a busca no banco de dados
                return lista;
            }
            catch (Exception e)
            {
                return new List<Seguro>();
            }

        }

    }
}
