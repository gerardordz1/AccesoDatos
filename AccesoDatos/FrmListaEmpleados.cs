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
    public partial class FrmListaEmpleados : Form
    {
        public FrmListaEmpleados()
        {
            InitializeComponent();
        }

        public void ActualizaGrid()
        {
            Datos obj = new Datos();
            DataSet ds = obj.Consulta("SELECT e.emp_id AS ID, e.fname AS [First Name], " +
                "e.minit as MINIT, e.lname AS [Last Name], " +
                "j.job_desc AS JOB, e.job_lvl AS JOB_LEVEL, p.pub_name AS PUBLISHER, " +
                "e.hire_date AS HIRE_DATE " +
                "FROM employee e " +
                "JOIN jobs j ON e.job_id = j.job_id " +
                "JOIN publishers p ON e.pub_id = p.pub_id");

            if (ds != null)
            {
                dgvAuthors.DataSource = ds.Tables[0];
            }

        }

        private void FrmListaEmpleados_Activated(object sender, EventArgs e)
        {
            ActualizaGrid();
        }

        private void FrmListaEmpleados_Load(object sender, EventArgs e)
        {
            Datos obj = new Datos();
            DataSet ds = obj.Consulta("SELECT * FROM employee");
            if (ds != null)
            {
                dgvAuthors.DataSource = ds.Tables[0];

            }
        }

        private void dgvAuthors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmActualizaEmpleados actualiza = new frmActualizaEmpleados(dgvAuthors[0, e.RowIndex].Value.ToString(),
                dgvAuthors[1, e.RowIndex].Value.ToString(),
                dgvAuthors[2, e.RowIndex].Value.ToString(),
                dgvAuthors[3, e.RowIndex].Value.ToString(),
                dgvAuthors[4, e.RowIndex].Value.ToString(),
                dgvAuthors[5, e.RowIndex].Value.ToString(),
                dgvAuthors[6, e.RowIndex].Value.ToString(),
                dgvAuthors[7, e.RowIndex].Value.ToString());
            actualiza.Show();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            frmInsertarEmpleados InsertarEmpleados = new frmInsertarEmpleados();
            InsertarEmpleados.Show();

        }

        private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAutores autores = new FrmAutores();
            autores.Show();
            this.Hide();
        }

        private void titulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaDeTitulos listaDeTitulos = new frmListaDeTitulos();
            listaDeTitulos.Show();
            this.Hide();
        }
    }
}
