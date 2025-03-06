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
    public partial class frmInsertarEmpleados : Form
    {
        public frmInsertarEmpleados()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            bool f = datos.comando("insert into employee values('" + txtEmpId.Text + "','" +
        txtFirst.Text + "','" + txtMinit.Text + "','" + txtLName.Text + "','" +
        cmbJobId.SelectedValue.ToString() + "','" + txtJobLvl.Text + "','" +
        cmbPubId.SelectedValue.ToString() + "','" + dtpHire.Value.Year + "/" + dtpHire.Value.Month
        + "/" + dtpHire.Value.Day + "')");
            
            
            if (f == true)
            {
                MessageBox.Show("Empleado agregado", "Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al agregar al empleado", "Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmInsertarEmpleados_Load(object sender, EventArgs e)
        {
            Datos obj = new Datos();

            
            DataSet ds = obj.Consulta("SELECT pub_id, pub_name FROM publishers");
            if (ds != null)
            {
                cmbPubId.DataSource = ds.Tables[0];
                cmbPubId.DisplayMember = "pub_name";
                cmbPubId.ValueMember = "pub_id";
            }

            
            DataSet ds2 = obj.Consulta("SELECT job_id, job_desc FROM jobs");
            if (ds2 != null)
            {
                cmbJobId.DataSource = ds2.Tables[0];
                cmbJobId.DisplayMember = "job_desc";
                cmbJobId.ValueMember = "job_id";
            }


        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NivelMaximoyMinimo(int jobID)
        {
            string query = "SELECT min_lvl AS MinLevel, max_lvl AS MaxLevel FROM jobs WHERE job_id = " + jobID;
            Datos datos = new Datos();
            DataSet ds = datos.Consulta(query);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                DataRow row = ds.Tables[0].Rows[0];
                labMaxMin.Text = "Niveles: " + row["MinLevel"].ToString() + " - " + row["MaxLevel"].ToString();
            }
            else
            {
                labMaxMin.Text = "Niveles: N/A";
            }
        }

        private void cmbJobId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbJobId.SelectedValue != null)
            {
                
                int jobId;
                if (int.TryParse(cmbJobId.SelectedValue.ToString(), out jobId))
                {
                    NivelMaximoyMinimo(jobId);
                }
            }
        }
    }
}
