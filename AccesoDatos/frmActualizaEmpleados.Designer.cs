namespace AccesoDatos
{
    partial class frmActualizaEmpleados
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
            btnCancelar = new Button();
            button1 = new Button();
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
            txtEmpId = new TextBox();
            label1 = new Label();
            btnBorrar = new Button();
            dtpHire = new DateTimePicker();
            cmbJobId = new ComboBox();
            cmbPubId = new ComboBox();
            labMaxMin = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.LightCyan;
            btnCancelar.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            btnCancelar.Location = new Point(484, 295);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(113, 46);
            btnCancelar.TabIndex = 58;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightCyan;
            button1.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            button1.Location = new Point(346, 295);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(120, 46);
            button1.TabIndex = 57;
            button1.Text = "Actualizar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label8.Location = new Point(164, 208);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(61, 18);
            label8.TabIndex = 55;
            label8.Text = "pub Id";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label7.Location = new Point(24, 208);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(59, 18);
            label7.TabIndex = 53;
            label7.Text = "Job lvl";
            // 
            // txtJobLvl
            // 
            txtJobLvl.Location = new Point(24, 231);
            txtJobLvl.Margin = new Padding(2);
            txtJobLvl.Name = "txtJobLvl";
            txtJobLvl.Size = new Size(121, 27);
            txtJobLvl.TabIndex = 52;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label6.Location = new Point(307, 208);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(85, 18);
            label6.TabIndex = 51;
            label6.Text = "Hire Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label5.Location = new Point(164, 142);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(59, 18);
            label5.TabIndex = 49;
            label5.Text = "Job Id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label4.Location = new Point(24, 142);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(97, 18);
            label4.TabIndex = 47;
            label4.Text = "Last Name";
            // 
            // txtLName
            // 
            txtLName.Location = new Point(24, 164);
            txtLName.Margin = new Padding(2);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(121, 27);
            txtLName.TabIndex = 46;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label3.Location = new Point(244, 81);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(47, 18);
            label3.TabIndex = 45;
            label3.Text = "Minit";
            // 
            // txtMinit
            // 
            txtMinit.Location = new Point(244, 103);
            txtMinit.Margin = new Padding(2);
            txtMinit.Name = "txtMinit";
            txtMinit.Size = new Size(203, 27);
            txtMinit.TabIndex = 44;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label2.Location = new Point(24, 81);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(98, 18);
            label2.TabIndex = 43;
            label2.Text = "First Name";
            // 
            // txtFirst
            // 
            txtFirst.Location = new Point(24, 103);
            txtFirst.Margin = new Padding(2);
            txtFirst.Name = "txtFirst";
            txtFirst.Size = new Size(203, 27);
            txtFirst.TabIndex = 42;
            // 
            // txtEmpId
            // 
            txtEmpId.Location = new Point(24, 43);
            txtEmpId.Margin = new Padding(2);
            txtEmpId.Name = "txtEmpId";
            txtEmpId.ReadOnly = true;
            txtEmpId.Size = new Size(121, 27);
            txtEmpId.TabIndex = 41;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label1.Location = new Point(24, 20);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(67, 18);
            label1.TabIndex = 40;
            label1.Text = "Emp Id";
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.LightCyan;
            btnBorrar.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            btnBorrar.Location = new Point(206, 295);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(114, 45);
            btnBorrar.TabIndex = 39;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // dtpHire
            // 
            dtpHire.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpHire.Location = new Point(307, 231);
            dtpHire.Name = "dtpHire";
            dtpHire.Size = new Size(331, 26);
            dtpHire.TabIndex = 59;
            // 
            // cmbJobId
            // 
            cmbJobId.FormattingEnabled = true;
            cmbJobId.Location = new Point(169, 167);
            cmbJobId.Name = "cmbJobId";
            cmbJobId.Size = new Size(151, 28);
            cmbJobId.TabIndex = 60;
            cmbJobId.SelectedIndexChanged += cmbJobId_SelectedIndexChanged;
            // 
            // cmbPubId
            // 
            cmbPubId.FormattingEnabled = true;
            cmbPubId.Location = new Point(164, 229);
            cmbPubId.Name = "cmbPubId";
            cmbPubId.Size = new Size(137, 28);
            cmbPubId.TabIndex = 61;
            // 
            // labMaxMin
            // 
            labMaxMin.AutoSize = true;
            labMaxMin.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labMaxMin.Location = new Point(25, 307);
            labMaxMin.Name = "labMaxMin";
            labMaxMin.Size = new Size(0, 20);
            labMaxMin.TabIndex = 86;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label9.Location = new Point(24, 274);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(119, 18);
            label9.TabIndex = 85;
            label9.Text = "Lvl Max y Min";
            // 
            // frmActualizaEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 369);
            Controls.Add(labMaxMin);
            Controls.Add(label9);
            Controls.Add(cmbPubId);
            Controls.Add(cmbJobId);
            Controls.Add(dtpHire);
            Controls.Add(btnCancelar);
            Controls.Add(button1);
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
            Controls.Add(txtEmpId);
            Controls.Add(label1);
            Controls.Add(btnBorrar);
            Name = "frmActualizaEmpleados";
            Text = "Actualiza Empleados";
            Load += frmActualizaEmpleados_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button button1;
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
        private TextBox txtEmpId;
        private Label label1;
        private Button btnBorrar;
        private DateTimePicker dtpHire;
        private ComboBox cmbJobId;
        private ComboBox cmbPubId;
        private Label labMaxMin;
        private Label label9;
    }
}