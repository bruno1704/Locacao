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
        readonly VeiculoRepository reposVeiculo = new VeiculoRepository(new ApplicationContext());
        readonly MultaRepository repos = new MultaRepository(new ApplicationContext());
        

        readonly UsuarioRepository reposUsuario = new UsuarioRepository(new ApplicationContext());
        public CadastrarMulta()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var multa = new Multa();

            multa.Valor = Convert.ToDecimal(TxtValor.Text);
            multa.Local = TxtLocal.Text;
            multa.Veiculo = reposVeiculo.RetornarPorVeiculo(TxtVeiculo.Text);
            multa.Ponto = Convert.ToInt32(TxtPonto.Text);
            multa.Usuario = reposUsuario.RetornarPorEmail(TxtUsuario.Text);

            repos.SaveMulta(multa);

            if (multa.Valor != 00 && multa.Local != null && multa.Veiculo != null && multa.Ponto != 00 && multa.Usuario != null)
            {
                repos.SaveMulta(multa);

                MessageBox.Show("Multa cadastrada");


            }
            else
            {
                if (multa.Valor == 00)
                {

                    MessageBox.Show("O campo valor não pode seer vazio");
                }
                else if(multa.Local == null && multa.Veiculo == null && multa.Ponto == 00 && multa.Usuario == null)
                {
                    MessageBox.Show(" Os campos não podem ser vazio");

                }
                else
                {
                    MessageBox.Show(" Os Campos  não pode ser vazio, preencha", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                }


            }



              

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
