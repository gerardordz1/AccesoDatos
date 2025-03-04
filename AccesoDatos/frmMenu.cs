using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccesoDatos
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void datosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAutores frmAutores = new FrmAutores();
            frmAutores.Show();
        }

        private void datosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void actualizarAutoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listaDeTítulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaDeTitulos listaDeTitulos = new frmListaDeTitulos();
            listaDeTitulos.Show();
        }

        private void listaDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListaEmpleados listaEmpleados = new FrmListaEmpleados();
            listaEmpleados.Show();
        }
    }
}
