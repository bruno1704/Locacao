using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Locacao.Models
{
    public class ViewModelUsuario
    {
      
        public Usuario Usuario{ get; set; }
        public Veiculo Veiculo { get; set; }

        public ViewModelUsuario()
        {
        }

        public ViewModelUsuario(Usuario usuario , Veiculo veiculo)
        {
            this.Usuario = usuario;
            this.Veiculo = veiculo;
        }
    }
}
