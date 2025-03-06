namespace AccesoDatos
{
    partial class frmInsertarAutores
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
            btn = new Button();
            chkContract = new CheckBox();
            label8 = new Label();
            txtState = new TextBox();
            label7 = new Label();
            txtCity = new TextBox();
            label6 = new Label();
            txtZipCode = new TextBox();
            label5 = new Label();
            txtAddress = new TextBox();
            label4 = new Label();
            txtPhone = new TextBox();
            label3 = new Label();
            txtLast = new TextBox();
            label2 = new Label();
            txtFirst = new TextBox();
            label1 = new Label();
            txtId = new TextBox();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.LightCyan;
            btnCancelar.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            btnCancelar.Location = new Point(349, 289);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 37);
            btnCancelar.TabIndex = 58;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btn
            // 
            btn.BackColor = Color.LightCyan;
            btn.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            btn.Location = new Point(219, 289);
            btn.Margin = new Padding(2);
            btn.Name = "btn";
            btn.Size = new Size(105, 37);
            btn.TabIndex = 57;
            btn.Text = "Insertar";
            btn.UseVisualStyleBackColor = false;
            btn.Click += btn_Click;
            // 
            // chkContract
            // 
            chkContract.AutoSize = true;
            chkContract.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkContract.Location = new Point(26, 296);
            chkContract.Margin = new Padding(2);
            chkContract.Name = "chkContract";
            chkContract.Size = new Size(112, 24);
            chkContract.TabIndex = 56;
            chkContract.Text = "Contract";
            chkContract.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label8.Location = new Point(166, 206);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(53, 18);
            label8.TabIndex = 55;
            label8.Text = "State";
            // 
            // txtState
            // 
            txtState.Location = new Point(166, 229);
            txtState.Margin = new Padding(2);
            txtState.Name = "txtState";
            txtState.Size = new Size(121, 27);
            txtState.TabIndex = 54;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label7.Location = new Point(26, 206);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(40, 18);
            label7.TabIndex = 53;
            label7.Text = "City";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(26, 229);
            txtCity.Margin = new Padding(2);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(121, 27);
            txtCity.TabIndex = 52;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label6.Location = new Point(309, 206);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(83, 18);
            label6.TabIndex = 51;
            label6.Text = "ZIP Code";
            // 
            // txtZipCode
            // 
            txtZipCode.Location = new Point(309, 229);
            txtZipCode.Margin = new Padding(2);
            txtZipCode.Name = "txtZipCode";
            txtZipCode.Size = new Size(121, 27);
            txtZipCode.TabIndex = 50;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label5.Location = new Point(166, 140);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(75, 18);
            label5.TabIndex = 49;
            label5.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(166, 162);
            txtAddress.Margin = new Padding(2);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(283, 27);
            txtAddress.TabIndex = 48;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label4.Location = new Point(26, 140);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(59, 18);
            label4.TabIndex = 47;
            label4.Text = "Phone";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(26, 162);
            txtPhone.Margin = new Padding(2);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(121, 27);
            txtPhone.TabIndex = 46;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label3.Location = new Point(246, 79);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(97, 18);
            label3.TabIndex = 45;
            label3.Text = "Last Name";
            // 
            // txtLast
            // 
            txtLast.Location = new Point(246, 101);
            txtLast.Margin = new Padding(2);
            txtLast.Name = "txtLast";
            txtLast.Size = new Size(203, 27);
            txtLast.TabIndex = 44;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label2.Location = new Point(26, 79);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(98, 18);
            label2.TabIndex = 43;
            label2.Text = "First Name";
            // 
            // txtFirst
            // 
            txtFirst.Location = new Point(26, 101);
            txtFirst.Margin = new Padding(2);
            txtFirst.Name = "txtFirst";
            txtFirst.Size = new Size(203, 27);
            txtFirst.TabIndex = 42;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label1.Location = new Point(26, 18);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(26, 18);
            label1.TabIndex = 40;
            label1.Text = "Id";
            // 
            // txtId
            // 
            txtId.Location = new Point(26, 40);
            txtId.Margin = new Padding(2);
            txtId.Name = "txtId";
            txtId.Size = new Size(121, 27);
            txtId.TabIndex = 59;
            // 
            // frmInsertarAutores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 359);
            Controls.Add(txtId);
            Controls.Add(btnCancelar);
            Controls.Add(btn);
            Controls.Add(chkContract);
            Controls.Add(label8);
            Controls.Add(txtState);
            Controls.Add(label7);
            Controls.Add(txtCity);
            Controls.Add(label6);
            Controls.Add(txtZipCode);
            Controls.Add(label5);
            Controls.Add(txtAddress);
            Controls.Add(label4);
            Controls.Add(txtPhone);
            Controls.Add(label3);
            Controls.Add(txtLast);
            Controls.Add(label2);
            Controls.Add(txtFirst);
            Controls.Add(label1);
            Name = "frmInsertarAutores";
            Text = "Insertar Autores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btn;
        private CheckBox chkContract;
        private Label label8;
        private TextBox txtState;
        private Label label7;
        private TextBox txtCity;
        private Label label6;
        private TextBox txtZipCode;
        private Label label5;
        private TextBox txtAddress;
        private Label label4;
        private TextBox txtPhone;
        private Label label3;
        private TextBox txtLast;
        private Label label2;
        private TextBox txtFirst;
        private Label label1;
        private TextBox txtId;
    }
}