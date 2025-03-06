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
    public partial class frmActualizaEmpleados : Form
    {
        public frmActualizaEmpleados(string emp_id, string fname, string minit, string lname,
            string job_id, string job_lvl, string pub_id, string hire_date)
        {
            InitializeComponent();
            txtEmpId.Text = emp_id;
            txtFirst.Text = fname;
            txtMinit.Text = minit;
            txtLName.Text = lname;
            cmbJobId.Text = job_id;
            txtJobLvl.Text = job_lvl;
            cmbPubId.Text = pub_id;
            dtpHire.Text = hire_date;
        }

        private void frmActualizaEmpleados_Load(object sender, EventArgs e)
        {
            
            Datos objJob = new Datos();
            DataSet dsJob = objJob.Consulta("SELECT job_id, job_desc FROM jobs ORDER BY job_id");
            if (dsJob != null && dsJob.Tables.Count > 0)
            {
                cmbJobId.DataSource = dsJob.Tables[0];
                cmbJobId.DisplayMember = "job_desc";
                cmbJobId.ValueMember = "job_id";
            }
            Datos objPub = new Datos();
            DataSet dsPub = objPub.Consulta("SELECT pub_id, pub_name FROM publishers ORDER BY pub_id");
            if (dsPub != null && dsPub.Tables.Count > 0)
            {
                cmbPubId.DataSource = dsPub.Tables[0];
                cmbPubId.DisplayMember = "pub_name";
                cmbPubId.ValueMember = "pub_id";



            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string jobId = cmbJobId.SelectedValue != null ? cmbJobId.SelectedValue.ToString() : "";
            string pubId = cmbPubId.SelectedValue != null ? cmbPubId.SelectedValue.ToString() : "";

            Datos datos = new Datos();
            bool f = datos.comando("update employee set " +
                "fname='" + txtFirst.Text +
                "', minit='" + txtMinit.Text +
                "', lname='" + txtLName.Text +
                "', job_id='" + jobId +  
                "', job_lvl='" + txtJobLvl.Text +
                "', pub_id='" + pubId +  
                "', hire_date='" + dtpHire.Value.Year + "-" + dtpHire.Value.Month + "-" + dtpHire.Value.Day +
                "' where emp_id='" + txtEmpId.Text + "'");

            if (f == true)
            {
                MessageBox.Show("Datos Actualizados", "Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Error al actualizar", "Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void btnBorrar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Estas seguro de eliminar el registro?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                Datos datos = new Datos();
                bool f = datos.comando("delete from employee where emp_id= '" + txtEmpId.Text + "'");
                if (f)
                {
                    MessageBox.Show("AUTOR ELIMINADO", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error De Sistema", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
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
    }
}
