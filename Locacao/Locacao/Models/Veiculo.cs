using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Locacao.Models
{
    public class Veiculo:BaseModel
    {
        public string Modelo { get; set; }
        //public DetalheVeiculo DetalheVeiculo { get; set; }
        public bool Completo { get; set; }
        public string Marca { get; set; }
        public decimal ValorHora { get; set; }

    }

    //public class DetalheVeiculo:BaseModel
    //{
    //    public bool Completo { get; set; }
    //    public string Marca { get; set; }
    //}

    public class Reserva : BaseModel
    {
        //public bool status { get; set; }
        public DateTime DataReserva { get; set; }
        public Usuario usuario { get; set; }
        public Veiculo Veiculo { get; private set; }
    }

    public class Pedido : BaseModel
    {
        [Required]
        public Reserva Reserva { get; private set; }
        [Required]
        public  Veiculo Veiculo { get; private set; }
        
        [Required]
        public DateTime DataRetirada { get; private set; }

        [Required]
        public DateTime DataEntrega { get; private set; }

        [Required]
        public decimal PrecoUnitario { get; private set; }

        public List<StatusPedido> Status { get; set; } = new List<StatusPedido>();

        public Pedido()
        {

        }

        public Pedido(Reserva reserva, Veiculo veiculo, DateTime dataRetirada, decimal precoUnitario, List<StatusPedido> status)
        {
            Reserva = reserva;
            Veiculo = veiculo;
            DataRetirada = dataRetirada;
            PrecoUnitario = precoUnitario;
            Status = status;
        }
    }

    public class StatusPedido:BaseModel
    {        
        public string Descricao { get; set; }
        public Pedido Pedido { get; set; }
    }
}
