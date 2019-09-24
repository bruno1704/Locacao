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

        public IActionResult CadastrarLogin(Usuario usuario)
        {
            var cadastrado = "";
            
            if (usuario.Nome != null && usuario.Email != null && usuario.Senha != null)//|| quer dizr ou != dirente de vazio null
            {
             
              var usuarioEncontrado = usuarioRepository.BuscaUsuarioExistente(usuario.Email);//f11

                if (usuarioEncontrado==null)// a parti daqui f10
                {
                    usuarioRepository.SaveUsuario(usuario);//repository responsavel gravar dados no banco
                    var msg = "Usuário cadastrado com sucesso";
                    @ViewBag.Msg = msg;
                }
                else
                {
                    var msg = "Usuario Já existe cadastrado";
                    @ViewBag.Msg = msg;
                }
                
                
            }
            else
            {
                if (usuario.Nome ==null)
                {
                    var msg = "nome não pode ser vazio";
                    @ViewBag.Msg = msg;
                }
                else if (usuario.Email ==null)
                {
                    var msg = "email não pode ser vazio";
                    @ViewBag.Msg = msg;
                }
                
                else
                {
                    var msg = "Senha não pode ser vazio";
                    @ViewBag.Msg = msg;
                }
            }

          

            return View();
        }

        public IActionResult Acessar(string Email, string Senha) // logar com a senha e email
        {
            //pronto faltou um negocio na view por isso nao tava conseguindo.
            //já pode testar denovo
            if (Email != null && Senha != null) // verifica se o email e a senha é null ou não
            {
             var usuarioEncontrado = usuarioRepository.BuscaUsuarioExistente(Email); // vai para o repositório
                //usuarioRepository.SaveUsuario(usuarioEncontrado);
                var cash = usuarioRepository.GetUsuarioCashId();
                if (usuarioEncontrado!=null)
                {
                    return RedirectToAction("Index","Reserva");
                }
                else
                {
                    return RedirectToAction("Error", "Home");
                }
                
            }
            else

            {
             var msg = "Usuario não encontrado";
                return RedirectToAction("Error", "Home");

            }


        }
        public IActionResult AlterarUsuario()
        {
            var lista = usuarioRepository.BuscaListaUsuario();
            return View(lista);
        }

        public IActionResult Logout()
        {
             usuarioRepository.ClearCashId();
             return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public IActionResult ValidaAdm()
        {
            var adm=usuarioRepository.ValidaAdm();
            return Json(adm);
        }
        public IActionResult cadastrarcarro()
        {
            usuarioRepository.ClearCashId();
            return RedirectToAction("Index", "Home");
        }
    }
}
