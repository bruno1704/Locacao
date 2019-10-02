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
        private readonly IVeiculoRepository veiculoRepository;
        private readonly ISeguroRepository seguroRepository;
        public LoginController(IUsuarioRepository usuarioRepository, IVeiculoRepository veiculoRepository,
            ISeguroRepository seguroRepository)
        {
            this.usuarioRepository = usuarioRepository;
            this.veiculoRepository = veiculoRepository;
            this.seguroRepository = seguroRepository;

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

                if (usuarioEncontrado.Email==null)// a parti daqui f10
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
        public IActionResult CadastrarVeiculo(Veiculo Veiculo)
        {
            if (Veiculo.Modelo != null && Veiculo.Marca != null) 
            {

               
                var selecionar = veiculoRepository.Carro(Veiculo);

                if (selecionar != null)
                {
                     ViewBag.Msg = "carro cadastrado";
                }
                else
                {
                    veiculoRepository.SaveReserva(Veiculo);
                    ViewBag.Msg = "veiculo cadastrado com sucesso";
                }
                    

                //alterar view bag
            }
            else
            {
                var algo = "Não cadastrado";

                if (Veiculo.Marca == null)
                {
                    var podepa = "Marca não pode ser vazio";

                }
                else if(Veiculo.Modelo == null)
                {

                    var podepa = "volte e preencha os campos que estão vazio";

                }



                
                

                

            }
            //veiculoRepository.SaveReserva(Veiculo);
           // veiculoRepository.

            //ViewBag.Msg = "Padrão";
            return View();
        }

        //
        public IActionResult TornarAdm(int Id)
        {
            //usuario pegar esse usuario
            var usuario = usuarioRepository.BuscaUsuarioporId(Id);
            //usuariorepositori.buscausuario(id)

            //suavarial.save()  //se for void nao retorna nada senao for void e for int,string,usario retorna seu respectivo tipo
            usuario.Administrador = true;
            //suavariavel.adm se era false vai ser true (suavariavel.administrador e atribuir o valor (false ou true))
            usuarioRepository.SaveUsuario(usuario);

            //reposotory.save(suaviavel)
            return View(usuario);
        }
        public IActionResult Desabilitado(int id)
        {
            var AdmCriado = usuarioRepository.BuscaUsuarioporId(id);

            AdmCriado.Administrador = false;

            var veiculo = veiculoRepository.GetVeiculoId(1);

            var blablalbal = usuarioRepository.BuscaNome(id);

            //usuarioRepository.SaveUsuario(AdmCriado);

            
            //ciom parametro
            var ViewModel = new ViewModelUsuario(AdmCriado,veiculo);

            var AlgumacoisaId = seguroRepository.AlgumacoisaId();

            var seila = seguroRepository.numeroQualquer();

            var hahah = seguroRepository.Aluno(id);
            
            //sem poassar parametro
            //ViewModel.Usuario = AdmCriado;
            //ViewModel.Veiculo = veiculo;

            return View(ViewModel);


        }

        

    }
}
