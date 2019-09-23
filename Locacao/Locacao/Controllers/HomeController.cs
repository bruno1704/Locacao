﻿using System;
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
            return View(pedidoRepository.BuscaListaPedido());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
