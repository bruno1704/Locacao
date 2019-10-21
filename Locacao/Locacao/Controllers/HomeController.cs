using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Locacao.Models;
using Locacao.Repository;

namespace Locacao.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUsuarioRepository usuarioRepository;
        private readonly IReservaRepository reservaRepository;
        private readonly IPedidoRepository pedidoRepository;
        private readonly IVeiculoRepository veiculoRepository;
        private readonly IStatusPedidoRepository statusPedidoRepository;

        public HomeController(IUsuarioRepository usuarioRepository, IReservaRepository reservaRepository, IPedidoRepository pedidoRepository, IVeiculoRepository veiculoRepository,
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


            return View();

        }

        public IActionResult Veiculos()
        {
            return View(veiculoRepository.BuscaListaVeiculo());

        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult MeusPedidos()
        {
            var id = usuarioRepository.GetUsuarioCashId();
            return View(pedidoRepository.BuscaListaPedido(Convert.ToInt32(id)));
        }

        public IActionResult Pedidos()
        {
            

            var Adm = usuarioRepository.GetUsuarioLogado();
            if (!Adm.Administrador)
            {
                ViewBag.Titulo = "Meus Pedidos";
                var lista = pedidoRepository.BuscaListaPedido(Adm.Id);
                return View(lista);
            }
            else
            {
                ViewBag.Titulo = "Pedidos";
                var lista = pedidoRepository.BuscaListaPedido();
                return View(lista);
            }
            
        }

        public IActionResult FecharPedido(int Id)
        {
            //ViewBag.Titulo = "Pedidos";
            var Pedido = pedidoRepository.BuscaIdPedido(Id);
            Pedido.DataEntrega=DateTime.Now.AddDays(3);
            var Qtddias = (Pedido.DataEntrega.Value.Day) - (Pedido.DataRetirada.Day);
            Pedido.Total=(Qtddias*Pedido.Reserva.Veiculo.ValorDiaria);
            Pedido.Status = statusPedidoRepository.GetstatusId(2);
            pedidoRepository.SavePedido(Pedido);
            //var Titulo = "Pedido Fechado";
            return View(Pedido);
        }

        public IActionResult CadastrarCarro()
        {
            return View();

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
