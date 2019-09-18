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
            this.usuarioRepository = usuarioRepository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CadastrarLogin(string Nome, string Email, string Senha)
        {
            var cadastrado = "";
            if (Nome!=null && Email!=null && Senha!=null)//|| quer dizr ou != dirente de vazio null
            {
                var usuario = new Usuario();//cria obj usario vazio
                usuario.Nome = Nome; //seta propriedade
                usuario.Senha = Senha;
                usuario.Email = Email;

                var usuarioEncontrado = usuarioRepository.BuscaUsuarioExistente(Email);//f11

                if (usuarioEncontrado==0)
                {
                    usuarioRepository.SaveUsuario(usuario);//repository responsavel gravar dados no banco
                    cadastrado = "cadastrado com sucesso";
                }
                else
                {
                    var msg = "Usuario não encontrado";
                }
                
                
            }
            else
            {
                if (Nome==null)
                {
                    cadastrado = "nome não pode ser vazio";
                }
                else if (Email==null)
                {
                    cadastrado = "email não pode ser vazio";
                }
                
                else
                {

                }
            }

          

            return View();
        }

        public IActionResult Acessar(string Email, string Senha)
        {

            if (Email != null && Senha != null)
            {
             var usuarioEncontrado = usuarioRepository.BuscaUsuarioExistente(Email);
;
            }
            else
            {
             var msg = "Usuario não encontrado";

            }

            return View();
        }
    }
}
