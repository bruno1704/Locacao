using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Locacao.Models;
using Locacao.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Locacao.Controllers
{



    public class ReservaController : Controller
    {
        private readonly IReservaRepository reservaRepository;
        private readonly IUsuarioRepository usuarioRepository;
        private readonly IPedidoRepository pedidoRepository;
        private readonly IVeiculoRepository veiculoRepository;
        private readonly IStatusPedidoRepository statusPedidoRepository;



        public ReservaController(IUsuarioRepository usuarioRepository, IReservaRepository reservaRepository, IPedidoRepository pedidoRepository, IVeiculoRepository veiculoRepository,
    IStatusPedidoRepository statusPedidoRepository)
        {
            this.usuarioRepository = usuarioRepository;
            this.reservaRepository = reservaRepository;
            this.pedidoRepository = pedidoRepository;
            this.veiculoRepository = veiculoRepository;
            this.statusPedidoRepository = statusPedidoRepository;

        }


        public IActionResult Index()
        {
            var lista = reservaRepository.BuscaListaReserva();
            return View(lista);
        }

        public IActionResult Reservar(int Id)
        {
            var UsuarioLogado = usuarioRepository.GetUsuarioLogado();
            var VeiculoSelecionado = veiculoRepository.GetVeiculoId(Id);
            var reserva = new Reserva();
            reserva.DataReserva = DateTime.Now;
            reserva.usuario = UsuarioLogado;
            reserva.Veiculo = VeiculoSelecionado;
             reservaRepository.SaveReserva(reserva);
            
            return View();
        }
    }
}