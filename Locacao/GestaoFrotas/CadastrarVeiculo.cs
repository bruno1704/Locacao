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
    public partial class CadastrarVeiculo : Form
    {
        readonly VeiculoRepository reposCompleto = new VeiculoRepository(new ApplicationContext());
        readonly VeiculoRepository repos = new VeiculoRepository(new ApplicationContext());


        public CadastrarVeiculo()
        {
            InitializeComponent();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            var veiculo = new Veiculo();
            veiculo.Modelo = TxtModelo.Text;
            veiculo.Completo = true;//reposCompleto.RetornarPorCompleto(TxtCompleto.Text); //coverter
            veiculo.Marca = TxtMarca.Text;

            

            if (veiculo.Modelo != null && veiculo.Completo != true && veiculo.Marca != null)
            {
                repos.SaveVeiculo(veiculo);

                MessageBox.Show("Veículo Cadasrado");
            }
            else
            {
                if (veiculo.Modelo == null)
                {
                    MessageBox.Show("O campo Modelo Não pode ser vazio");

                }
                else if(veiculo.Completo == true )
                {
                    MessageBox.Show("O campo Modelo Não pode ser vazio");

                }
                else
                {

                    MessageBox.Show(" Campo Marca não pode ser vazio, preencha", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                   


            }

        }
    }
}
