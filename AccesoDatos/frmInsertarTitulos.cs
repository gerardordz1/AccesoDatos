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
    public partial class frmInsertarTitulos : Form
    {
        public frmInsertarTitulos()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            bool f = datos.comando("insert into titles values('" + txtTitleId.Text + "','" +
                txtTitle.Text + "','" + txtType.Text + "','" + txtPub.Text + "','" +
                txtPrice.Text + "','" + txtAdvance.Text + "','" + txtRoyalty.Text + "','" + txtYtdSales.Text + "','"+ txtNotes.Text + "','"+ dtpPub.Value.Year + "/" + dtpPub.Value.Month
                + "/" + dtpPub.Value.Day + "')"); ;
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
