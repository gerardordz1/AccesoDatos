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
            label7 = new Label();
            txtJobLvl = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtLName = new TextBox();
            label3 = new Label();
            txtMinit = new TextBox();
            label2 = new Label();
            txtFirst = new TextBox();
            label1 = new Label();
            txtEmpId = new TextBox();
            cmbJobId = new ComboBox();
            cmbPubId = new ComboBox();
            label9 = new Label();
            labMaxMin = new Label();
            SuspendLayout();
            // 
            // dtpHire
            // 
            dtpHire.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpHire.Location = new Point(301, 244);
            dtpHire.Name = "dtpHire";
            dtpHire.Size = new Size(333, 26);
            dtpHire.TabIndex = 78;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Azure;
            btnCancelar.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            btnCancelar.Location = new Point(385, 328);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(124, 40);
            btnCancelar.TabIndex = 77;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.BackColor = Color.Azure;
            btnInsertar.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            btnInsertar.Location = new Point(215, 328);
            btnInsertar.Margin = new Padding(2);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(129, 40);
            btnInsertar.TabIndex = 76;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = false;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label8.Location = new Point(168, 218);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(61, 18);
            label8.TabIndex = 75;
            label8.Text = "pub Id";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label7.Location = new Point(28, 218);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(59, 18);
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
            label6.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label6.Location = new Point(340, 218);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(85, 18);
            label6.TabIndex = 71;
            label6.Text = "Hire Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label5.Location = new Point(168, 152);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(59, 18);
            label5.TabIndex = 70;
            label5.Text = "Job Id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label4.Location = new Point(28, 152);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(97, 18);
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
            label3.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label3.Location = new Point(248, 91);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(47, 18);
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
            label2.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label2.Location = new Point(28, 91);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(98, 18);
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
            label1.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label1.Location = new Point(28, 30);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(67, 18);
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
            // cmbJobId
            // 
            cmbJobId.FormattingEnabled = true;
            cmbJobId.Location = new Point(168, 173);
            cmbJobId.Name = "cmbJobId";
            cmbJobId.Size = new Size(151, 28);
            cmbJobId.TabIndex = 80;
            cmbJobId.SelectedIndexChanged += cmbJobId_SelectedIndexChanged;
            // 
            // cmbPubId
            // 
            cmbPubId.FormattingEnabled = true;
            cmbPubId.Location = new Point(168, 244);
            cmbPubId.Name = "cmbPubId";
            cmbPubId.Size = new Size(127, 28);
            cmbPubId.TabIndex = 81;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label9.Location = new Point(28, 277);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(119, 18);
            label9.TabIndex = 83;
            label9.Text = "Lvl Max y Min";
            label9.Click += label9_Click;
            // 
            // labMaxMin
            // 
            labMaxMin.AutoSize = true;
            labMaxMin.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labMaxMin.Location = new Point(29, 310);
            labMaxMin.Name = "labMaxMin";
            labMaxMin.Size = new Size(0, 20);
            labMaxMin.TabIndex = 84;
            // 
            // frmInsertarEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 402);
            Controls.Add(labMaxMin);
            Controls.Add(label9);
            Controls.Add(cmbPubId);
            Controls.Add(cmbJobId);
            Controls.Add(txtEmpId);
            Controls.Add(dtpHire);
            Controls.Add(btnCancelar);
            Controls.Add(btnInsertar);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtJobLvl);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtLName);
            Controls.Add(label3);
            Controls.Add(txtMinit);
            Controls.Add(label2);
            Controls.Add(txtFirst);
            Controls.Add(label1);
            Name = "frmInsertarEmpleados";
            Text = "Insertar Empleados";
            Load += frmInsertarEmpleados_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpHire;
        private Button btnCancelar;
        private Button btnInsertar;
        private Label label8;
        private Label label7;
        private TextBox txtJobLvl;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtLName;
        private Label label3;
        private TextBox txtMinit;
        private Label label2;
        private TextBox txtFirst;
        private Label label1;
        private TextBox txtEmpId;
        private ComboBox cmbJobId;
        private ComboBox cmbPubId;
        private Label label9;
        private Label labMaxMin;
    }
}