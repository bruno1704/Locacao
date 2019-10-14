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
       
        readonly SinistroRepository reposSinistro= new SinistroRepository(new ApplicationContext());
        readonly SinistroRepository repos = new SinistroRepository(new ApplicationContext());
        readonly VeiculoRepository reposVeiculo = new VeiculoRepository(new ApplicationContext());
        readonly UsuarioRepository reposUsuario = new UsuarioRepository(new ApplicationContext());

        public CadastrarSinistro()
        {
            
            InitializeComponent();
            foreach (var v in reposVeiculo.BuscaListaVeiculo())
            {
                cmbVei.Items.Add(v.Placa);
            }
            
            foreach (var i in reposUsuario.BuscaListaUsuario())
            {
                cmbUsu.Items.Add(i.Nome);
            }


        }

        private void BtnCadastar_Click(object sender, EventArgs e)
        {
            
            //se a propriedade é um obj nao pode passar um stringg
            //se for int nao pode passar string
            //sempre de ter o mesmo tipo
            //se objeto tem de ser objo
            //strig tem de string
            //bool tem de ser bool
            //manda no wats se entendeu
            if (cmbVei.SelectedItem.ToString() != "" && TxtLocal.Text != ""  && cmbUsu.SelectedItem.ToString() != "")//&& sinistro.PerdaTotal != null && sinistro.Usuario != "" )
            {
                var sinistro = new Sinistro();

                sinistro.VeiculoId = reposVeiculo.RetornarPorPlaca(cmbVei.SelectedItem.ToString()).Id;
                sinistro.Local = TxtLocal.Text;
                sinistro.Data = DtSini.Value;
                sinistro.PerdaTotal = chkSin.Checked;
                sinistro.UsuarioId = reposUsuario.RetornarPorEmail(cmbUsu.SelectedItem.ToString()).Id; //vc tem que fazer assim cria os repositoria pra pegar pelo nome

                repos.SaveSinistro(sinistro);
                MessageBox.Show("Sinistro cadastrado com sucesso");

            }
            else
            {
                if (cmbVei.SelectedItem.ToString() == "")
                {
                    MessageBox.Show("O campo Veículo não pode ser vazio");
                }
                else if (TxtLocal.Text == "") 
                {
                    MessageBox.Show("O campo Local não pode ser vazio");
                }
           
                else
                {
                    MessageBox.Show(" UsuarioId  não pode ser vazio, preencha", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                    

        

            }

        }

      

        private void CadastrarSinistro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27))
            {
                this.Close();
            }else if (e.KeyValue.Equals(13))
            {
                BtnCadastar_Click(sender,e);
            }
        }

        private void Master_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
