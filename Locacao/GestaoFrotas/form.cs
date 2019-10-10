using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoDeFrota.inicio.Repositories
{
    public partial class Consultarform : Form
    {
        readonly MultaRepository repos = new MultaRepository(new ApplicationContext());
        public Consultarform()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            var listamulta = repos.BuscaListaMulta();
            if (listamulta == null)  //varial lista = null ou "" (vazio) retornar mensagem
            {
                //var naotem = new Form();

            }     
            else //senão retorna a lista
            {

                MessageBox.Show("Não existe");
                //criar novo form olhar igual no usuario
            }




        }

     
    }
}
