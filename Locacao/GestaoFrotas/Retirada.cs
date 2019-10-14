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
    public partial class Retirada : Form
    {
        readonly VeiculoRepository reposVeiculo = new VeiculoRepository(new ApplicationContext());
        readonly RetiradaEntradaVeiculoRepository repos = new RetiradaEntradaVeiculoRepository(new ApplicationContext());
        readonly UsuarioRepository reposUsuario = new UsuarioRepository(new ApplicationContext());
        public Retirada()
        {
            InitializeComponent();
            foreach (var i in reposUsuario.BuscaListaUsuario())
            {
                cmbUsuarioR.Items.Add(i.Nome);
            }

            foreach (var i in reposVeiculo.BuscaListaVeiculo())
            {
                cmbVeiculoR.Items.Add(i.Placa);
            }
        }

        private void BtaCadastrarR_Click(object sender, EventArgs e)
        {

            if (cmbUsuarioR.SelectedItem.ToString() != "" && cmbVeiculoR.SelectedItem.ToString() != "")
            {
                var EntradaSaida = new EntradaSaidaVeiculo();
                EntradaSaida.UsuarioId = reposUsuario.RetornarPorEmail(cmbUsuarioR.SelectedItem.ToString()).Id;
                EntradaSaida.VeiculoId = reposVeiculo.RetornarPorPlaca(cmbVeiculoR.SelectedItem.ToString()).Id;
                EntradaSaida.Retirada = DtRet.Value;

                repos.SaveEntradaSaidaVeiculo(EntradaSaida);

                MessageBox.Show(" Retirada Registrada Com Sucesso", "Retirada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (cmbUsuarioR.SelectedItem.ToString() == "")
                {
                    MessageBox.Show(" Campo Usuario não pode ser vazio, preencha", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(" Campo Veiculo não pode ser vazio, preencha", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }






        }
    }
}
