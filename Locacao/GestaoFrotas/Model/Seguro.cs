using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeFrota.inicio.Model
{
    public class Seguro:BaseModel
    {
        public int UsuarioId { get; set; }
        public int VeiculoId { get; set; }   
        public decimal Valor { get;  set; }
        public DateTime Inicio { get; set; }
        public bool PerdaTotal { get; set; }
        public DateTime Final { get; set; }

    }
}
