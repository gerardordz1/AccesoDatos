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
    public partial class FrmAutores : Form
    {
        public FrmAutores()
        {
            InitializeComponent();
        }

        private void FrmAutores_Load(object sender, EventArgs e)
        {
            Datos obj = new Datos();
            DataSet ds = obj.Consulta("SELECT * FROM authors");
            if (ds != null)
            {
                dgvAuthors.DataSource = ds.Tables[0];

            }
        }



        private void dgvAuthors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            ActualizaAutor actualiza = new ActualizaAutor(dgvAuthors[0, e.RowIndex].Value.ToString(),
                dgvAuthors[1, e.RowIndex].Value.ToString(),
                dgvAuthors[2, e.RowIndex].Value.ToString(),
                dgvAuthors[3, e.RowIndex].Value.ToString(),
                dgvAuthors[4, e.RowIndex].Value.ToString(),
                dgvAuthors[5, e.RowIndex].Value.ToString(),
                dgvAuthors[6, e.RowIndex].Value.ToString(),
                dgvAuthors[7, e.RowIndex].Value.ToString(),
                Convert.ToBoolean(dgvAuthors[8, e.RowIndex].Value));
            actualiza.Show();


        }


        public void ActualizaGrid()
        {
            Datos obj = new Datos();
            DataSet ds = obj.Consulta("SELECT au_id AS ID,au_lname AS " +
     "[Last Name],au_fname AS [First Name],phone as PHONE," +
     "authors.address AS Address,city AS City,state as State," +
     "zip AS Zip,contract AS Contract FROM authors");

            if (ds != null)
            {
                dgvAuthors.DataSource = ds.Tables[0];
            }

        }

        private void FrmAutores_Activated(object sender, EventArgs e)
        {
            ActualizaGrid();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            frmInsertarAutores insertarAutores = new frmInsertarAutores();
            insertarAutores.Show();
        }

        private void titulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaDeTitulos listaDeTitulos = new frmListaDeTitulos();
            listaDeTitulos.Show();
            this.Hide();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListaEmpleados listaEmpleados = new FrmListaEmpleados();
            listaEmpleados.Show();
            this.Hide();
        }
    }
}
