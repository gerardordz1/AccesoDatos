namespace AccesoDatos
{
    partial class frmInsertarEmpleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dtpHire = new DateTimePicker();
            btnCancelar = new Button();
            btnInsertar = new Button();
            label8 = new Label();
            txtPubId = new TextBox();
            label7 = new Label();
            txtJobLvl = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txtJobId = new TextBox();
            label4 = new Label();
            txtLName = new TextBox();
            label3 = new Label();
            txtMinit = new TextBox();
            label2 = new Label();
            txtFirst = new TextBox();
            label1 = new Label();
            txtEmpId = new TextBox();
            SuspendLayout();
            // 
            // dtpHire
            // 
            dtpHire.Location = new Point(311, 241);
            dtpHire.Name = "dtpHire";
            dtpHire.Size = new Size(286, 27);
            dtpHire.TabIndex = 78;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(491, 284);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 27);
            btnCancelar.TabIndex = 77;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(361, 284);
            btnInsertar.Margin = new Padding(2);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(90, 27);
            btnInsertar.TabIndex = 76;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(168, 218);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(52, 20);
            label8.TabIndex = 75;
            label8.Text = "pub Id";
            // 
            // txtPubId
            // 
            txtPubId.Location = new Point(168, 241);
            txtPubId.Margin = new Padding(2);
            txtPubId.Name = "txtPubId";
            txtPubId.Size = new Size(121, 27);
            txtPubId.TabIndex = 74;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 218);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(51, 20);
            label7.TabIndex = 73;
            label7.Text = "Job lvl";
            // 
            // txtJobLvl
            // 
            txtJobLvl.Location = new Point(28, 241);
            txtJobLvl.Margin = new Padding(2);
            txtJobLvl.Name = "txtJobLvl";
            txtJobLvl.Size = new Size(121, 27);
            txtJobLvl.TabIndex = 72;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(311, 218);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 71;
            label6.Text = "Hire Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(168, 152);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 70;
            label5.Text = "Job Id";
            // 
            // txtJobId
            // 
            txtJobId.Location = new Point(168, 174);
            txtJobId.Margin = new Padding(2);
            txtJobId.Name = "txtJobId";
            txtJobId.Size = new Size(283, 27);
            txtJobId.TabIndex = 69;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 152);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 68;
            label4.Text = "Last Name";
            // 
            // txtLName
            // 
            txtLName.Location = new Point(28, 174);
            txtLName.Margin = new Padding(2);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(121, 27);
            txtLName.TabIndex = 67;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(248, 91);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 66;
            label3.Text = "Minit";
            // 
            // txtMinit
            // 
            txtMinit.Location = new Point(248, 113);
            txtMinit.Margin = new Padding(2);
            txtMinit.Name = "txtMinit";
            txtMinit.Size = new Size(203, 27);
            txtMinit.TabIndex = 65;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 91);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 64;
            label2.Text = "First Name";
            // 
            // txtFirst
            // 
            txtFirst.Location = new Point(28, 113);
            txtFirst.Margin = new Padding(2);
            txtFirst.Name = "txtFirst";
            txtFirst.Size = new Size(203, 27);
            txtFirst.TabIndex = 63;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 30);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 61;
            label1.Text = "Emp Id";
            // 
            // txtEmpId
            // 
            txtEmpId.Location = new Point(28, 62);
            txtEmpId.Margin = new Padding(2);
            txtEmpId.Name = "txtEmpId";
            txtEmpId.Size = new Size(121, 27);
            txtEmpId.TabIndex = 79;
            // 
            // frmInsertarEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 393);
            Controls.Add(txtEmpId);
            Controls.Add(dtpHire);
            Controls.Add(btnCancelar);
            Controls.Add(btnInsertar);
            Controls.Add(label8);
            Controls.Add(txtPubId);
            Controls.Add(label7);
            Controls.Add(txtJobLvl);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtJobId);
            Controls.Add(label4);
            Controls.Add(txtLName);
            Controls.Add(label3);
            Controls.Add(txtMinit);
            Controls.Add(label2);
            Controls.Add(txtFirst);
            Controls.Add(label1);
            Name = "frmInsertarEmpleados";
            Text = "frmInsertarEmpleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpHire;
        private Button btnCancelar;
        private Button btnInsertar;
        private Label label8;
        private TextBox txtPubId;
        private Label label7;
        private TextBox txtJobLvl;
        private Label label6;
        private Label label5;
        private TextBox txtJobId;
        private Label label4;
        private TextBox txtLName;
        private Label label3;
        private TextBox txtMinit;
        private Label label2;
        private TextBox txtFirst;
        private Label label1;
        private TextBox txtEmpId;
    }
}