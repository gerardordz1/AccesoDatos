namespace AccesoDatos
{
    partial class frmInsertar
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
            chkContract = new CheckBox();
            txtZipCode = new TextBox();
            label8 = new Label();
            txtState = new TextBox();
            label7 = new Label();
            txtCity = new TextBox();
            label6 = new Label();
            txtAddress = new TextBox();
            label5 = new Label();
            txtPhone = new TextBox();
            label4 = new Label();
            txtLastName = new TextBox();
            label3 = new Label();
            txtFirstName = new TextBox();
            label2 = new Label();
            txtId = new TextBox();
            label1 = new Label();
            btnInsertar = new Button();
            SuspendLayout();
            // 
            // chkContract
            // 
            chkContract.AutoSize = true;
            chkContract.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkContract.Location = new Point(26, 501);
            chkContract.Name = "chkContract";
            chkContract.Size = new Size(115, 32);
            chkContract.TabIndex = 33;
            chkContract.Text = "Contract";
            chkContract.UseVisualStyleBackColor = true;
            // 
            // txtZipCode
            // 
            txtZipCode.Location = new Point(451, 405);
            txtZipCode.Name = "txtZipCode";
            txtZipCode.Size = new Size(164, 27);
            txtZipCode.TabIndex = 32;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(451, 367);
            label8.Name = "label8";
            label8.Size = new Size(73, 20);
            label8.TabIndex = 31;
            label8.Text = "ZIP CODE";
            // 
            // txtState
            // 
            txtState.Location = new Point(236, 405);
            txtState.Name = "txtState";
            txtState.Size = new Size(164, 27);
            txtState.TabIndex = 30;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(236, 367);
            label7.Name = "label7";
            label7.Size = new Size(43, 20);
            label7.TabIndex = 29;
            label7.Text = "State";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(12, 405);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(164, 27);
            txtCity.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 367);
            label6.Name = "label6";
            label6.Size = new Size(34, 20);
            label6.TabIndex = 27;
            label6.Text = "City";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(236, 280);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(296, 27);
            txtAddress.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(236, 248);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 25;
            label5.Text = "Address";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(12, 280);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(164, 27);
            txtPhone.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 257);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 23;
            label4.Text = "Phone";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(344, 155);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(296, 27);
            txtLastName.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(344, 123);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 21;
            label3.Text = "Last Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(12, 155);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(257, 27);
            txtFirstName.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 123);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 19;
            label2.Text = "First Name";
            // 
            // txtId
            // 
            txtId.Location = new Point(73, 12);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 17;
            label1.Text = "ID";
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(306, 501);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(94, 29);
            btnInsertar.TabIndex = 34;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // frmInsertar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 556);
            Controls.Add(btnInsertar);
            Controls.Add(chkContract);
            Controls.Add(txtZipCode);
            Controls.Add(label8);
            Controls.Add(txtState);
            Controls.Add(label7);
            Controls.Add(txtCity);
            Controls.Add(label6);
            Controls.Add(txtAddress);
            Controls.Add(label5);
            Controls.Add(txtPhone);
            Controls.Add(label4);
            Controls.Add(txtLastName);
            Controls.Add(label3);
            Controls.Add(txtFirstName);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Name = "frmInsertar";
            Text = "frmInsertar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkContract;
        private TextBox txtZipCode;
        private Label label8;
        private TextBox txtState;
        private Label label7;
        private TextBox txtCity;
        private Label label6;
        private TextBox txtAddress;
        private Label label5;
        private TextBox txtPhone;
        private Label label4;
        private TextBox txtLastName;
        private Label label3;
        private TextBox txtFirstName;
        private Label label2;
        private TextBox txtId;
        private Label label1;
        private Button btnInsertar;
    }
}