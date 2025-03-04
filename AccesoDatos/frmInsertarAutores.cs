﻿using System;
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
    public partial class frmInsertarAutores : Form
    {
        public frmInsertarAutores()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            bool f = datos.comando("insert into authors values('" + txtId.Text + "','" +
                txtLast.Text + "','" + txtFirst.Text + "','" + txtPhone.Text + "','" +
                txtAddress.Text + "','" + txtCity.Text + "','" + txtState.Text + "','" +
                txtZipCode.Text + "'," + (chkContract.Checked ? 1 : 0) + ")");
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
