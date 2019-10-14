using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Locacao.Models
{
    public class Usuario : BaseModel
    {
        [Required]       
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool Administrador { get; set; }
    }

    public class Multa : BaseModel
    {
        public Usuario Usuario { get; set; }
        public Veiculo Veiculo { get; set; }        
        public string Local { get; set; }
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }
        public int Ponto { get; set; }
    }

    public class Seguro : BaseModel
    {
        public Usuario Usuario { get; set; }
        public Veiculo Veiculo { get; set; }
        public decimal Valor { get; set; }
        public DateTime Inicio { get; set; }
        public bool PerdaTotal { get; set; }
        public DateTime Final { get; set; }
    }

    public class Sinistro : BaseModel
    {
        public Usuario Usuario { get; set; }
        public Veiculo Veiculo { get; set; }
        public string Local { get; set; }
        public bool PerdaTotal { get; set; }     
        public DateTime Data { get; set; }
        
    }
}
