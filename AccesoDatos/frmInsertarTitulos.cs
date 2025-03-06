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
                txtTitle.Text + "','" + txtType.Text + "','" + cmbPubId.SelectedValue.ToString() + "','" +
                txtPrice.Text + "','" + txtAdvance.Text + "','" + txtRoyalty.Text + "','" + txtYtdSales.Text + "','" + txtNotes.Text + "','" + dtpPub.Value.Year + "/" + dtpPub.Value.Month
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmInsertarTitulos_Load(object sender, EventArgs e)
        {
            Datos obj = new Datos();


            DataSet ds = obj.Consulta("SELECT pub_id, pub_name FROM publishers");
            if (ds != null)
            {
                cmbPubId.DataSource = ds.Tables[0];
                cmbPubId.DisplayMember = "pub_name";
                cmbPubId.ValueMember = "pub_id";
            }
        }
    }
}
