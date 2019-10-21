using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoDeFrota
{
    public class Usuario : BaseModel
    {
        [Required]               
        public string Email { get; set; }

        public string Cpf { get; set; }

        public DateTime DataDeNascimento { get; set; }

        public string Telefone { get; set; }

        public string Nome { get; set; }

        public string Senha { get; set; }      


        public bool Administrador { get; set; }
        //public object Veiculo { get; set; }
    }
}
