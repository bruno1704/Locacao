using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeFrota.inicio.Model
{
    public class Seguro:BaseModel
    {
        public Veiculo Veiculo { get; set; }
        public decimal Valor { get; set; }
        public Usuario Usuario { get; internal set; } //ou vc vai ter um obj Seguro Seguro ou Usuario Usuario Lé o codigo dps
        //ache o erro
        
        //um obj usuario nao pode ter o nome do seu objeto seguro
    }
}
