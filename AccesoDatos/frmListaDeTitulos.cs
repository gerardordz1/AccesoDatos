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
            DataSet ds = obj.Consulta("SELECT title_id AS TitleID,title AS " +
     "Title,type as Type,pub_id AS PubId," +
     "price AS Price,advance AS Advance,royalty AS Royalty," +
     "ytd_sales AS YtdSales,notes AS Notes,pubdate AS PubDate FROM titles");

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
    }
}
