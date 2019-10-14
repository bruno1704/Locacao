using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeFrota.inicio.Model
{
    public class Sinistro: BaseModel
    {
        public int VeiculoId { get; set; }
        public int UsuarioId { get; set; }
        public string Local { get; set; }
        public bool PerdaTotal { get; set; }
        
        public DateTime Data { get; internal set; }
    }
}
