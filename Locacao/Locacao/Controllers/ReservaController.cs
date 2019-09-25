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
            var Adm = usuarioRepository.GetUsuarioLogado();
            if (!Adm.Administrador)
            {
                var lista = reservaRepository.BuscaListaReserva(Adm.Id);
                return View(lista);
            }
            else
            {
                var lista = reservaRepository.BuscaListaReserva();
                return View(lista);
            }
            
           
        }

        public IActionResult Reservar(int Id)
        {
            var UsuarioLogado = usuarioRepository.GetUsuarioLogado();
            var VeiculoSelecionado = veiculoRepository.GetVeiculoId(Id);
            var reserva = new Reserva();
            reserva.DataReserva = DateTime.Now;
            reserva.usuario = UsuarioLogado;
            reserva.Veiculo = VeiculoSelecionado;
            reserva.StatusPedido = statusPedidoRepository.GetstatusId(1);
             reservaRepository.SaveReserva(reserva);
            
            return View(reserva);
        }

        public IActionResult GeraPedido(int Id)
        {
            var UsuarioLogado = usuarioRepository.GetUsuarioLogado();
            var reservaselecionada = reservaRepository.BuscaReservaId(Id);
            reservaselecionada.StatusPedido = statusPedidoRepository.GetstatusId(2);
            reservaRepository.SaveReserva(reservaselecionada);
            var VeiculoSelecionado = veiculoRepository.GetVeiculoId(Id);
            var NewPedido = new Pedido(reservaselecionada,DateTime.Now,DateTime.Now,Convert.ToDecimal(0),statusPedidoRepository.GetstatusId(1));
            var sucesso = pedidoRepository.SavePedido(NewPedido);
            ViewBag.Titulo = "Pedido Realizado";
            return View(sucesso);
        }

        public IActionResult GeraPedido(Pedido Pedido)
        {
         
            ViewBag.Titulo = "Pedido Fechado";
            return View(Pedido);
        }

    }
}