using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Locacao.Models;
using Locacao.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Locacao.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUsuarioRepository usuarioRepository;

        public LoginController(IUsuarioRepository usuarioRepository)
        {
            usuarioRepository = usuarioRepository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CadastrarLogin(string Nome, string Email, string Senha)
        {
            var usuario = new Usuario();
            usuario.Nome = Nome;
            usuario.Senha = Senha;
            usuario.Email = Email;

            usuarioRepository.SaveUsuario(usuario);

            return View();
        }

        public IActionResult Acessar(string Email, string Senha)
        {
            return View();
        }
    }
}
