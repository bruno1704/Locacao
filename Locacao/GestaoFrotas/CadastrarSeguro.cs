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
    //repos
    

    public partial class CadastrarSeguro : Form
    {
        
        readonly SeguroRepository repos = new SeguroRepository(new ApplicationContext());
        readonly SeguroRepository reposSeguro = new SeguroRepository(new ApplicationContext());
        readonly UsuarioRepository reposUsuario = new UsuarioRepository(new ApplicationContext());
        readonly VeiculoRepository reposVeiculo = new VeiculoRepository(new ApplicationContext());

        public CadastrarSeguro()
        {
            InitializeComponent();
            foreach (var v in reposVeiculo.BuscaListaVeiculo()) 
            {
                cmbV.Items.Add(v.Placa);
            }
            foreach (var u in reposUsuario.BuscaListaUsuario())
            {
                cmbUs.Items.Add(u.Nome);
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {

        }

        private void BtnCadastarSeg_Click(object sender, EventArgs e)
        {
            var seguro = new Seguro();
            seguro.VeiculoId = reposVeiculo.RetornarPorPlaca(cmbV.SelectedItem.ToString()).Id;            
            seguro.PerdaTotal = ChkPerda.Checked;
            seguro.Valor = Convert.ToDecimal(TxtVlr.Text);
            seguro.UsuarioId = reposUsuario.RetornarPorEmail(cmbUs.SelectedItem.ToString()).Id;
            seguro.Inicio = dtini.Value;
            seguro.Final = dtfina.Value;

            if (seguro.VeiculoId != 00 && seguro.Valor != 0 && seguro.UsuarioId != 00)
            {
                repos.SaveSeguro(seguro);
                MessageBox.Show("Seguro cadastrado");

            }
            else
            {
                if (seguro.Valor == 0)
                {
                    MessageBox.Show("O campo valor não pode seer vazio");

                }
                else if(seguro.UsuarioId == 00)
                {
                    MessageBox.Show(" O campo Usuario não pode ser vazio");

                }
                else
                {
                    MessageBox.Show(" Os Campos  não pode ser vazio, preencha", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }



            }

        }   

        private void ChkPerda_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
