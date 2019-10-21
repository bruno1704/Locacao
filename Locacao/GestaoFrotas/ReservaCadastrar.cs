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
    public partial class ReservaCadastrar : Form
    {

        readonly UsuarioRepository reposUsuario = new UsuarioRepository(new ApplicationContext());
        readonly VeiculoRepository reposVeiculo = new VeiculoRepository(new ApplicationContext());


        public ReservaCadastrar()
        {
            InitializeComponent();
            //aqui monta os componentes do form e tas
            foreach (var u  in reposUsuario.BuscaListaUsuario())
            {
                cmbsUsu.Items.Add(u.Nome);

            }
            foreach (var v in reposVeiculo.BuscaListaVeiculo())
            {
                cmbsVei.Items.Add(v.Placa);

            }
            

        }

        private void ReservaCadastrar_Load(object sender, EventArgs e)
        {

        }

        private void BotCadastrar_Click(object sender, EventArgs e)
        {
            var reserva = new Reserva();

            reserva.UsuarioId = reposUsuario.RetornarPorEmail(cmbsUsu.SelectedItem.ToString()).Id;
            reserva.VeiculoId = reposVeiculo.RetornarPorPlaca(cmbsVei.SelectedItem.ToString()).Id;
            //reserva.StatusPedido = Repositories
            reserva.DataReserva = DtSinis.Value;

            //parece que esta copiando o codigo toma cuidado isso pode dar erado se tiver fzndo isso

            if (reserva.UsuarioId != 0 && reserva.VeiculoId != 0 && reserva.DataReserva != null )
            {
                //repos.SavaReserva();

                MessageBox.Show("Reserva Cadastrada");

            }
            else
            {
                if (reserva.UsuarioId == 0  )
                {
                    MessageBox.Show(" O campo Usuario não pode ser vazio, preencha! ");

                }else if(reserva.VeiculoId == 0 )
                {
                    MessageBox.Show(" O campo Veiculo não pode ser vazio, preencha! ");

                }
                else
                {
                    MessageBox.Show(" Os Campos  não pode ser vazio, preencha", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }



                


            }




        }
    }
}
