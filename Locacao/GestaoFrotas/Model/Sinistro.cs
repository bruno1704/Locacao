using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeFrota.inicio.Model
{
    public class Sinistro: BaseModel
    {
        public Veiculo Veiculo { get; set; }
        public string Local { get; set; }
        public bool PerdaTotal { get; set; }

        public Usuario Usuario { get; set; }






    }
}
