using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Locacao.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Locacao.Controllers
{
    public class ReservaController : Controller
    {
        private readonly IReservaRepository reservaRepository;

        public ReservaController(IReservaRepository reservaRepository)
        {
            this.reservaRepository = reservaRepository;

        }
       

        public IActionResult Index()
        {
            var lista = reservaRepository.BuscaListaReserva();
            return View(lista);
        }
    }
}