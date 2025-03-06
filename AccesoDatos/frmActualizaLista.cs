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
    public partial class frmActualizaLista : Form
    {
        public frmActualizaLista(string title_id, string title, string type, string pub_id,
            string price, string advance, string royalty, string ytd_sales, string notes, string pubdates)

        {
            InitializeComponent();
            txtTitleId.Text = title_id;
            txtTitle.Text = title;
            txtType.Text = type;
            cmbPubId.Text = pub_id;
            txtPrice.Text = price;
            txtAdvance.Text = advance;
            txtRoyalty.Text = royalty;
            txtYtdSales.Text = ytd_sales;
            txtNotes.Text = notes;
            dtpPub.Text = pubdates;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pubId = cmbPubId.SelectedValue != null ? cmbPubId.SelectedValue.ToString() : "";
            Datos datos = new Datos();
            bool f = datos.comando("update titles set " +
                 "title='" + txtTitle.Text +
                 "', type='" + txtType.Text +
                 "', pub_id='" + pubId +
                 "', price='" + txtPrice.Text +
                 "', advance='" + txtAdvance.Text +
                 "', royalty='" + txtRoyalty.Text +
                 "', ytd_sales='" + txtYtdSales.Text +
                 "', notes='" + txtNotes.Text +
                 "', pubdate='" + dtpPub.Value.Year + "-" + dtpPub.Value.Month + "-" + dtpPub.Value.Day +
                 "' where title_id='" + txtTitleId.Text + "'");
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
                bool f = datos.comando("delete from titles where title_id = '" + txtTitleId.Text + "'");
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

        private void frmActualizaLista_Load(object sender, EventArgs e)
        {
            Datos objPub = new Datos();
            DataSet dsPub = objPub.Consulta("SELECT pub_id, pub_name FROM publishers ORDER BY pub_id");
            if (dsPub != null && dsPub.Tables.Count > 0)
            {
                cmbPubId.DataSource = dsPub.Tables[0];
                cmbPubId.DisplayMember = "pub_name";
                cmbPubId.ValueMember = "pub_id";



            }
        }
    }
}
