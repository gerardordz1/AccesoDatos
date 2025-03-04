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
                txtJobId.Text + "','" + txtJobLvl.Text + "','" + txtPubId.Text + "','" + dtpHire.Value.Year + "/" + dtpHire.Value.Month
                + "/" + dtpHire.Value.Day + "')"); ;
            if (f == true)
            {
                MessageBox.Show("Datos insertados", "Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al insertar", "Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
