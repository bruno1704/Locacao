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
    public partial class CadastrarMulta : Form
    {
        
        readonly MultaRepository repos = new MultaRepository(new ApplicationContext());
        readonly UsuarioRepository reposUsuario = new UsuarioRepository(new ApplicationContext());
        public CadastrarMulta()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var multa = new Multa();//te falei aqui que precisa do control + ponto 

            multa.Valor = Convert.ToDecimal(TxtValor.Text);
            multa.Local = TxtLocal.Text;
            //multa.Veiculo = TxtVeiculo.Text;
            multa.Ponto = Convert.ToInt32(TxtPonto.Text);
            multa.Usuario = reposUsuario.RetornarPorEmail(TxtUsuario.Text);

            repos.SaveMulta(multa);
              

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
