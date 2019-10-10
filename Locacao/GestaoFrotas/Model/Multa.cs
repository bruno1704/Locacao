using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeFrota.inicio.Model
{
    public class Multa:BaseModel
    {
        
        public decimal Valor { get; set; }
        public string Local { get; set; }

        public Usuario Usuario { get; set; }

        public Veiculo Veiculo { get; set; }

        public int Ponto { get; set; }
    }
}
