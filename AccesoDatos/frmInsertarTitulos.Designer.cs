namespace AccesoDatos
{
    partial class frmInsertarTitulos
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
            dtpPub = new DateTimePicker();
            label10 = new Label();
            label9 = new Label();
            txtNotes = new TextBox();
            btnCancelar = new Button();
            btnInsertar = new Button();
            label8 = new Label();
            txtRoyalty = new TextBox();
            label7 = new Label();
            txtAdvance = new TextBox();
            label6 = new Label();
            txtYtdSales = new TextBox();
            label5 = new Label();
            txtPrice = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtType = new TextBox();
            label2 = new Label();
            txtTitle = new TextBox();
            label1 = new Label();
            txtTitleId = new TextBox();
            cmbPubId = new ComboBox();
            SuspendLayout();
            // 
            // dtpPub
            // 
            dtpPub.CalendarMonthBackground = SystemColors.ActiveBorder;
            dtpPub.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpPub.Location = new Point(161, 312);
            dtpPub.Name = "dtpPub";
            dtpPub.Size = new Size(346, 26);
            dtpPub.TabIndex = 105;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label10.Location = new Point(161, 289);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(92, 18);
            label10.TabIndex = 104;
            label10.Text = "Pub Dates";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label9.Location = new Point(21, 289);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(56, 18);
            label9.TabIndex = 103;
            label9.Text = "Notes";
            // 
            // txtNotes
            // 
            txtNotes.BackColor = SystemColors.Window;
            txtNotes.ForeColor = SystemColors.ControlText;
            txtNotes.Location = new Point(21, 312);
            txtNotes.Margin = new Padding(2);
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(121, 27);
            txtNotes.TabIndex = 102;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.LightCyan;
            btnCancelar.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            btnCancelar.Location = new Point(354, 356);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(106, 38);
            btnCancelar.TabIndex = 101;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.BackColor = Color.LightCyan;
            btnInsertar.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            btnInsertar.Location = new Point(192, 356);
            btnInsertar.Margin = new Padding(2);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(116, 38);
            btnInsertar.TabIndex = 100;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = false;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label8.Location = new Point(161, 212);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(71, 18);
            label8.TabIndex = 99;
            label8.Text = "Royalty";
            // 
            // txtRoyalty
            // 
            txtRoyalty.BackColor = SystemColors.Window;
            txtRoyalty.ForeColor = SystemColors.ControlText;
            txtRoyalty.Location = new Point(161, 235);
            txtRoyalty.Margin = new Padding(2);
            txtRoyalty.Name = "txtRoyalty";
            txtRoyalty.Size = new Size(121, 27);
            txtRoyalty.TabIndex = 98;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label7.Location = new Point(21, 212);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(78, 18);
            label7.TabIndex = 97;
            label7.Text = "Advance";
            // 
            // txtAdvance
            // 
            txtAdvance.BackColor = SystemColors.Window;
            txtAdvance.ForeColor = SystemColors.ControlText;
            txtAdvance.Location = new Point(21, 235);
            txtAdvance.Margin = new Padding(2);
            txtAdvance.Name = "txtAdvance";
            txtAdvance.Size = new Size(121, 27);
            txtAdvance.TabIndex = 96;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label6.Location = new Point(304, 212);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(90, 18);
            label6.TabIndex = 95;
            label6.Text = "YTD Sales";
            // 
            // txtYtdSales
            // 
            txtYtdSales.BackColor = SystemColors.Window;
            txtYtdSales.ForeColor = SystemColors.ControlText;
            txtYtdSales.Location = new Point(304, 235);
            txtYtdSales.Margin = new Padding(2);
            txtYtdSales.Name = "txtYtdSales";
            txtYtdSales.Size = new Size(121, 27);
            txtYtdSales.TabIndex = 94;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label5.Location = new Point(161, 146);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(48, 18);
            label5.TabIndex = 93;
            label5.Text = "Price";
            // 
            // txtPrice
            // 
            txtPrice.BackColor = SystemColors.Window;
            txtPrice.ForeColor = SystemColors.ControlText;
            txtPrice.Location = new Point(161, 168);
            txtPrice.Margin = new Padding(2);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(283, 27);
            txtPrice.TabIndex = 92;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label4.Location = new Point(21, 146);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(62, 18);
            label4.TabIndex = 91;
            label4.Text = "Pub Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label3.Location = new Point(307, 85);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(48, 18);
            label3.TabIndex = 89;
            label3.Text = "Type";
            // 
            // txtType
            // 
            txtType.BackColor = SystemColors.Window;
            txtType.ForeColor = SystemColors.ControlText;
            txtType.Location = new Point(304, 107);
            txtType.Margin = new Padding(2);
            txtType.Name = "txtType";
            txtType.Size = new Size(203, 27);
            txtType.TabIndex = 88;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label2.Location = new Point(21, 85);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(43, 18);
            label2.TabIndex = 87;
            label2.Text = "Title";
            // 
            // txtTitle
            // 
            txtTitle.BackColor = SystemColors.Window;
            txtTitle.ForeColor = SystemColors.ControlText;
            txtTitle.Location = new Point(21, 107);
            txtTitle.Margin = new Padding(2);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(261, 27);
            txtTitle.TabIndex = 86;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label1.Location = new Point(21, 24);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(66, 18);
            label1.TabIndex = 84;
            label1.Text = "Title Id";
            // 
            // txtTitleId
            // 
            txtTitleId.BackColor = SystemColors.Window;
            txtTitleId.ForeColor = SystemColors.ControlText;
            txtTitleId.Location = new Point(22, 46);
            txtTitleId.Margin = new Padding(2);
            txtTitleId.Name = "txtTitleId";
            txtTitleId.Size = new Size(121, 27);
            txtTitleId.TabIndex = 106;
            // 
            // cmbPubId
            // 
            cmbPubId.FormattingEnabled = true;
            cmbPubId.Location = new Point(21, 168);
            cmbPubId.Name = "cmbPubId";
            cmbPubId.Size = new Size(127, 28);
            cmbPubId.TabIndex = 107;
            // 
            // frmInsertarTitulos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(543, 405);
            Controls.Add(cmbPubId);
            Controls.Add(txtTitleId);
            Controls.Add(dtpPub);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txtNotes);
            Controls.Add(btnCancelar);
            Controls.Add(btnInsertar);
            Controls.Add(label8);
            Controls.Add(txtRoyalty);
            Controls.Add(label7);
            Controls.Add(txtAdvance);
            Controls.Add(label6);
            Controls.Add(txtYtdSales);
            Controls.Add(label5);
            Controls.Add(txtPrice);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtType);
            Controls.Add(label2);
            Controls.Add(txtTitle);
            Controls.Add(label1);
            ForeColor = SystemColors.WindowText;
            Name = "frmInsertarTitulos";
            Text = "Insertar Titulos";
            Load += frmInsertarTitulos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpPub;
        private Label label10;
        private Label label9;
        private TextBox txtNotes;
        private Button btnCancelar;
        private Button btnInsertar;
        private Label label8;
        private TextBox txtRoyalty;
        private Label label7;
        private TextBox txtAdvance;
        private Label label6;
        private TextBox txtYtdSales;
        private Label label5;
        private TextBox txtPrice;
        private Label label4;
        private Label label3;
        private TextBox txtType;
        private Label label2;
        private TextBox txtTitle;
        private Label label1;
        private TextBox txtTitleId;
        private ComboBox cmbPubId;
    }
}