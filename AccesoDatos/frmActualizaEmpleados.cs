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
            txtJobId.Text = job_id;
            txtJobLvl.Text = job_lvl;
            txtPubId.Text = pub_id;
            dtpHire.Text = hire_date;
        }

        private void frmActualizaEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            bool f = datos.comando("update employee set " +
    "fname='" + txtFirst.Text +
    "', minit='" + txtMinit.Text +
    "', lname='" + txtLName.Text +
    "', job_id='" + txtJobId.Text +
    "', job_lvl='" + txtJobLvl.Text +
    "', pub_id='" + txtPubId.Text +
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
    }
}
