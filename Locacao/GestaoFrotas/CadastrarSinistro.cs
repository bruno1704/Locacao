using GestaoDeFrota.inicio.Model;
using GestaoDeFrota.inicio.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoDeFrota.inicio
{
    public partial class CadastrarSinistro : Form
    {
        readonly SinistroRepository repos = new SinistroRepository(new ApplicationContext());

        readonly UsuarioRepository reposUsuario = new UsuarioRepository(new ApplicationContext());

        public CadastrarSinistro()
        {
            InitializeComponent();
        }

        private void BtnCadastar_Click(object sender, EventArgs e)
        {
            var sinistro = new Sinistro();

            //sinistro.Veiculo = TxtVeiculo.Text;//TxtVeiculo ñ vai da certo vc ta passando um string e ele espera
            //objeto veiculo
            sinistro.Local = TxtLocal.Text;
            //sinistro.PerdaTotal = TxtPerdaTotal.Text
            //sinistro.PerdaTotal = TxtPerdaTotal.Text;//é string e precisa ser bool
            sinistro.Usuario = reposUsuario.RetornarPorEmail(TxtUsuario.Text); //vc tem que fazer assim cria os repositoria pra pegar pelo nome
                //TxtUsuario.Text;//passando string e precisa de um usuario
                //cira um metodo na repositorio usuario com esse nome BuscaNomeString(parametrovaiserstring)
                //ai ele vai retornar um usuario tenta fazer la igual o de id a diferenca que busca por nome ou email
                //melhor por email
                //vai fazer o msm para o veiculo
                //nao faz o perda total dps te exploic

            //se a propriedade é um obj nao pode passar um stringg
            //se for int nao pode passar string
            //sempre de ter o mesmo tipo
            //se objeto tem de ser objo
            //strig tem de string
            //bool tem de ser bool
            //manda no wats se entendeu
            if (sinistro.Veiculo != null && sinistro.Local != "" )//&& sinistro.PerdaTotal != null && sinistro.Usuario != "" )
            {
                repos.SaveSinistro(sinistro);
                MessageBox.Show("Sinistro cadastrado com sucesso");
            }
            else
            {


            }

        }

        private void CadastrarSinistro_Load(object sender, EventArgs e)
        {

        }
    }
}
