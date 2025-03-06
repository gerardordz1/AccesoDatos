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
    public partial class frmListaDeTitulos : Form
    {
        public frmListaDeTitulos()
        {

            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {

            frmInsertarTitulos insertarTitulos = new frmInsertarTitulos();
            insertarTitulos.Show();
        }

        private void frmListaDeTitulos_Load(object sender, EventArgs e)
        {
            Datos obj = new Datos();
            DataSet ds = obj.Consulta("SELECT * FROM titles");
            if (ds != null)
            {
                dgvAuthors.DataSource = ds.Tables[0];

            }
        }
        public void ActualizaGrid()
        {
            Datos obj = new Datos();
            DataSet ds = obj.Consulta("SELECT t.title_id AS TitleID,t.title AS " +
             "Title,t.type as Type,p.pub_name AS PUBLISHER," +
             "t.price AS Price,t.advance AS Advance,t.royalty AS Royalty," +
             "t.ytd_sales AS YtdSales,t.notes AS Notes,t.pubdate AS PubDate FROM titles t "
             + "JOIN publishers p ON t.pub_id = p.pub_id");

            if (ds != null)
            {
                dgvAuthors.DataSource = ds.Tables[0];
            }

        }
        private void frmListaDeTitulos_Activated(object sender, EventArgs e)
        {

        }

        private void frmListaDeTitulos_Activated_1(object sender, EventArgs e)
        {
            ActualizaGrid();
        }

        private void dgvAuthors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmActualizaLista actualiza = new frmActualizaLista(dgvAuthors[0, e.RowIndex].Value.ToString(),
                dgvAuthors[1, e.RowIndex].Value.ToString(),
                dgvAuthors[2, e.RowIndex].Value.ToString(),
                dgvAuthors[3, e.RowIndex].Value.ToString(),
                dgvAuthors[4, e.RowIndex].Value.ToString(),
                dgvAuthors[5, e.RowIndex].Value.ToString(),
                dgvAuthors[6, e.RowIndex].Value.ToString(),
                dgvAuthors[7, e.RowIndex].Value.ToString(),
                dgvAuthors[8, e.RowIndex].Value.ToString(),
                dgvAuthors[9, e.RowIndex].Value.ToString()
                );
            actualiza.Show();
        }

        private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAutores autores = new FrmAutores();
            autores.Show();
            this.Hide();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListaEmpleados listaEmpleados = new FrmListaEmpleados();
            listaEmpleados.Show();
            this.Hide();

        }

        private void frmListaDeTitulos_Load_1(object sender, EventArgs e)
        {

        }
    }
}
