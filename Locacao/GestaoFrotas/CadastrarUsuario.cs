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
    public partial class CadastrarUsuario : Form
    {
        readonly UsuarioRepository repos = new UsuarioRepository(new ApplicationContext());
        public CadastrarUsuario()
        {
            InitializeComponent();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario();

            usuario.Nome = TxtNome.Text;
            usuario.Cpf = textCPF.Text;
            usuario.Telefone = textTelefone.Text;
            usuario.DataDeNascimento = DtN.Value;
            usuario.Email = TxtEmail.Text;
            usuario.Senha = TxtSenha.Text;
            usuario.Administrador = Master.Checked;

            
            if (usuario.Nome!="" && usuario.Cpf != "" && usuario.Telefone != "" && usuario.Senha != "" && usuario.Email != "")
            {
                repos.SaveUsuario(usuario);
                var msg = MessageBox.Show("Usuario Cadastrado com sucesso", "", MessageBoxButtons.OK);

            }
            else
            {
                if (usuario.Nome=="")
                {
                    MessageBox.Show(" Campo Nome não pode ser vazio, preencha");
                }
                else if (usuario.Senha == "")
                {
                    MessageBox.Show(" Campo Senha não pode ser vazio, preencha");
                }
                else  
                {
                    MessageBox.Show( " Campo Email não pode ser vazio, preencha","Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void Master_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CadastrarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
