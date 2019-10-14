using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoDeFrota
{
    public class Veiculo : BaseModel
    {       
        public string Modelo { get; set; }        
        public bool Completo { get; set; }
        public string Marca { get; set; }
        public string Placa { get; set; }
        public decimal ValorDiaria { get; set; }
        
    }

   public class EntradaSaidaVeiculo: BaseModel
    {
        public int UsuarioId { get; set; }
        public int VeiculoId { get; set; }
        public DateTime Retirada { get; set; }
        public DateTime Entrega { get; set; }
    }

    public class Reserva : BaseModel
    {
        //public bool status { get; set; }
        public DateTime DataReserva { get; set; }
        public Usuario usuario { get; set; }
        public Veiculo Veiculo { get; set; }

        public StatusPedido StatusPedido { get; set; }
    }

    public class Pedido : BaseModel
    {
        [Required]
        public Reserva Reserva { get; private set; }

        [Required]
        public DateTime DataRetirada { get; private set; }

        [Required]
        public DateTime? DataEntrega { get; set; }

        [Required]
        public decimal Total { get; set; }

        //public List<StatusPedido> Status { get; set; } = new List<StatusPedido>();
        public StatusPedido Status { get; set; }

        public Pedido()
        {

        }
        public Pedido(Reserva reserva, DateTime dataRetirada, DateTime dataEntrega, decimal total, StatusPedido status)
        {
            Reserva = reserva;
            DataEntrega = dataEntrega;
            DataRetirada = dataRetirada;
            Total = total;
            Status = status;
        }
    }
    public class StatusPedido : BaseModel
    {
        public string Descricao { get; set; }
    }
}
