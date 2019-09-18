using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Locacao.Models
{
    public class Usuario : BaseModel
    {
        
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
    }
}
