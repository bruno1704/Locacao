using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeFrota.inicio.Model
{
    public class Multa:BaseModel
    {
        public int UsuarioId { get; set; }
        public int VeiculoId { get; set; }
        public string Local { get; set; }
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }
        public int Ponto { get; set; }
    }
}
