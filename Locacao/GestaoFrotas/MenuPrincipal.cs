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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();//inicar os componentes //exibir design ou shift +7
            panel1.Visible = false;
        }

        private void MnuCadastrar_Click(object sender, EventArgs e)
        {
            new CadastrarUsuario().Show();
        }

        private void MnuVCadastrar_Click(object sender, EventArgs e)
        {
            new CadastrarVeiculo().Show();
            

        }

        private void VeiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MnuMcadastrar_Click(object sender, EventArgs e)
        {
            new CadastrarMulta().Show();
        }

        private void TesteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CadastrarSinistro().Show();
        }

        private void SinistoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
