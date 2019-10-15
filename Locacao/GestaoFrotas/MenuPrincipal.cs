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
    public partial class MenuPrincipal : Form
    {
        readonly MultaRepository reposMulta = new MultaRepository(new ApplicationContext());
        readonly VeiculoRepository reposCompleto = new VeiculoRepository(new ApplicationContext());
        readonly RetiradaEntradaVeiculoRepository reposRetirada = new RetiradaEntradaVeiculoRepository(new ApplicationContext());
        readonly UsuarioRepository reposUsuario = new UsuarioRepository(new ApplicationContext());
        readonly SeguroRepository reposSeguro = new SeguroRepository(new ApplicationContext());
        public SinistroRepository reposSinistro = new SinistroRepository(new ApplicationContext());
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

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new CadastrarSeguro().Show();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var listausuario = reposUsuario.BuscaListaUsuario();
            panel1.Visible = true;
            DtgMenuP.DataSource = listausuario;
            TxtTitulo.Text = "Edição Usuario";
        }

        private void editarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var listaveiculo = reposCompleto.BuscaListaVeiculo();
            //DataTable l = listaveiculo.CopyTo<DataTable>();
            var datatable = new DataTable();

            //datatable
            panel1.Visible = true;

            DtgMenuP.DataSource = listaveiculo;         

            TxtTitulo.Text = "Edição Veículo";
        }

        private void editarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var Listamulta = reposMulta.BuscaListaMulta();

           

            panel1.Visible = true;

            DtgMenuP.DataSource = Listamulta;

            TxtTitulo.Text = "Edição Multa";

        }

        private void retiradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Retirada().Show();
        }

        private void entregaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ListaRetirada = reposRetirada.BuscaListaEntradaSaidaVeiculo();

            panel1.Visible = true;

            DtgMenuP.DataSource = ListaRetirada;            

            TxtTitulo.Text = "Entrega Veículo";
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                var l = DtgMenuP.SelectedRows[0].DataBoundItem.ToString();

                //var l = x.ToString();

                switch (l)
                {
                    
                    case "GestaoDeFrota.Multa":
                        var m = (Multa)DtgMenuP.SelectedRows[0].DataBoundItem;
                       
                            reposMulta.SaveMulta(m);
                            MessageBox.Show("Alteração Realizada", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                               
                       
                        break;
                    case "GestaoDeFrota.EntradaSaidaVeiculo":
                        var i = (EntradaSaidaVeiculo) DtgMenuP.SelectedRows[0].DataBoundItem;
                        if (i.Entrega.ToString()!= "01/01/0001 00:00:00")
                        {                            
                                reposRetirada.SaveEntradaSaidaVeiculo(i);
                                MessageBox.Show("Data Entrega Realizada", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                          
                        }
                        else
                        {
                            MessageBox.Show("Data Entrega Não Pode Ser Vazio", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        break;
                    case "GestaoDeFrota.Veiculo":
                        var v = (Veiculo)DtgMenuP.SelectedRows[0].DataBoundItem;

                        reposCompleto.SaveVeiculo(v);
                        MessageBox.Show("Alteração Realizada", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        break;
                    case "GestaoDeFrota.Sinistro":
                        var s = (Sinistro)DtgMenuP.SelectedRows[0].DataBoundItem;

                        reposSinistro.SaveSinistro(s);
                        MessageBox.Show("Alteração Realizada", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        break;
                    case "GestaoDeFrota.Usuario":

                        var u = (Usuario)DtgMenuP.SelectedRows[0].DataBoundItem;

                        reposUsuario.SaveUsuario(u);
                        MessageBox.Show("Alteração Realizada", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;

                    case "GestaoDeFrota.Seguro":

                        var Sg = (Seguro)DtgMenuP.SelectedRows[0].DataBoundItem;

                        reposSeguro.SaveSeguro(Sg);
                        MessageBox.Show("Alteração Realizada", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;

                }
            }
            catch (Exception )
            {
                MessageBox.Show("Nenhuma Linha Selecionada, Selecione atraves do icone "+">", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
                
            
        }

        private void editarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            var ListaSinistro = reposSinistro.BuscaListaSinistro();

            panel1.Visible = true;

            DtgMenuP.DataSource = ListaSinistro;

            TxtTitulo.Text = "Edição Sinsitro";
        }

        private void editarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            var ListaSeguro = reposSeguro.BuscaListaSeguro();

            panel1.Visible = true;

            DtgMenuP.DataSource = ListaSeguro;

            TxtTitulo.Text = "Edição Seguro";
        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            // aqui vai a lógica 
            try
            {//se der algum erro vai no catch senao continua no case
                var l = DtgMenuP.SelectedRows[0].DataBoundItem.ToString();

                switch (l)
                {
                    case "GestaoDeFrota.Usuario":
                        var u = (Usuario)DtgMenuP.SelectedRows[0].DataBoundItem;

                        reposUsuario.DeletarUsuario(u);

                        //força atualizar a lista
                        var listaatualizadausuario = reposUsuario.BuscaListaUsuario();

                        DtgMenuP.DataSource = listaatualizadausuario;

                        MessageBox.Show("Registro Deletado com Sucesso não sera possivel recuperar ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        break;

                    case "trocapleopçãoselecionada vai vir na variavel l (L)":
                    //sua  logica aqui


                    //faz os outros qlqr coisa me manda msg no hanout

                    case "GestaoDeFrota.Veiculo":
                        var vei = (Veiculo)DtgMenuP.SelectedRows[0].DataBoundItem;

                        reposCompleto.DeletarVeiculo(vei);

                        var Listaatualizadaveiculo = reposCompleto.BuscaListaVeiculo();

                        DtgMenuP.DataSource = Listaatualizadaveiculo;

                        MessageBox.Show("Registro Deletado com Sucesso não sera possivel recuperar ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                        break;

                    case "GestaoDeFrota.Multa":

                        var Mul = (Multa)DtgMenuP.SelectedRows[0].DataBoundItem;

                        reposMulta.DeletarMulta(Mul);

                        var listaatualizadamulta = reposMulta.BuscaListaMulta();

                        DtgMenuP.DataSource = listaatualizadamulta;

                        MessageBox.Show("Registro Deletado com Sucesso não sera possivel recuperar ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                        break;

                    case "GestaoDeFrota.Sinistro":

                        var Sin = (Sinistro)DtgMenuP.SelectedRows[0].DataBoundItem;

                        reposSinistro.DeletarSinistro(Sin);

                        var listaatualizadasinistro = reposSinistro.BuscaListaSinistro();

                        DtgMenuP.DataSource = listaatualizadasinistro;

                        MessageBox.Show("Registro Deletado com Sucesso não sera possivel recuperar ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);




                        break;
                    case "GestãoDeFrota.Seguro":

                        var Seg = (Seguro)DtgMenuP.SelectedRows[0].DataBoundItem;

                        reposSeguro.DeletarSeguro(Seg);

                        var listaatualizadaseguro = reposSeguro.BuscarListaSeguro();

                        DtgMenuP.DataSource = listaatualizadaseguro;

                        MessageBox.Show("Registro Deletado com Sucesso não sera possivel recuperar ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                        break;

                    case "GestaoDeFrota.EntradaSaidaVeiculo":

                         var ES = (EntradaSaidaVeiculo)DtgMenuP.SelectedRows[0].DataBoundItem;
                        reposRetirada.DeletarEntradaeSaida(ES);
                        var listaatualizadaRetirada = reposRetirada.BuscaListaEntradaSaidaVeiculo();
                        DtgMenuP.DataSource = listaatualizadaRetirada;

                        MessageBox.Show("Registro Deletado com Sucesso não sera possivel recuperar ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        break;


                }
            }
            catch (Exception )
            {
                MessageBox.Show("Nenhuma Linha Selecionada, Selecione atraves do icone " + ">", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
          
                
        }
    }
}
