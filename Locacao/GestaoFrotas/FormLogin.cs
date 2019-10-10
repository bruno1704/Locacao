using GestaoDeFrota.inicio;
using GestaoFrotas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoDeFrota
{
    public partial class FormLogin : Form
    {
         public ApplicationContext App = new ApplicationContext() ;
        readonly UsuarioRepository repos = new UsuarioRepository(new ApplicationContext());

        public FormLogin()
        {
            InitializeComponent();
            //this.usuario = new Usuario();
               this.AcessoLiberado = false;
            //this.UsuarioRepository = UsuarioRepository;
        }

        public bool AcessoLiberado { get; set; }

        //construtor
        //public FormLogin()
        //{
        //    InitializeComponent();
        //    this.usuario = new Usuario();
        //    this.AcessoLiberado = false;
            
            
        //}

        private void FormInicioUso_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Entrar_Click(object sender, EventArgs e)
        {
             var Usuario = new Usuario();
            Usuario.Email = textBox1.Text;
           Usuario.Senha = textBox2.Text;

          

            if (Usuario.Email != "" && Usuario.Senha != "")//this.usuario.Verificarlogin()
            {
                var existeounao = repos.ExisteUsuario(Usuario);
                var lista = repos.BuscaListaUsuario();
                if (existeounao)
                {
                    var x = new MenuPrincipal();
                    x.Show();
                    //retornar o menu prin\cippal (form)
                }
                else
                {
                    MessageBox.Show("usuario nao encontrado verifique os dados ou solicite cadastro");
                }

            }
            else
            {
                if (Usuario.Senha == "" && Usuario.Email == "")
                {
                    MessageBox.Show(" email e senha não podem ser vazio, preencha");
                }
                else if (Usuario.Email == "")
                {
                   
                    MessageBox.Show("email  não podem ser vazio, preencha"); 
                 
                }
                else
                {
                    MessageBox.Show(" senha não podem ser vazio, preencha");
                }
                      
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
