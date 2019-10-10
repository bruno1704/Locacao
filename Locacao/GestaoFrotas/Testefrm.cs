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
    public partial class Testefrm : Form
    {
        readonly UsuarioRepository repos = new UsuarioRepository(new ApplicationContext());
        readonly List<Usuario> Lista; 
        public Testefrm(List<Usuario> lista)
        {
            this.Lista = lista;
            
            InitializeComponent();
            MontarDataGrid();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var listausuario = ""; //repos.listausario();
            //dglistauser.DataSource = Lista;
            var lista = repos.BuscaListaUsuario();
            MontarDataGrid();
        }

        public void MontarDataGrid()
        {
            dglistauser.Rows.Clear();
            var l = Lista.Select(s => new user
            {
                nome=s.Nome,
                senha=s.Senha,
                //Id=s.Id
            }).ToList();

         dglistauser.DataSource = l;

            //dglistauser.Columns[0].HeaderText = "huh";
            //dglistauser.Columns[0].DisplayIndex = 4;
        }
    }

    public class user
    {
        public string nome { get; set; }
        public string senha { get; set; }

        public int Id { get; set; }
    }
}
