namespace AccesoDatos
{
    partial class FrmListaEmpleados
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
            btnInsertar = new Button();
            dgvAuthors = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvAuthors).BeginInit();
            SuspendLayout();
            // 
            // btnInsertar
            // 
            btnInsertar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnInsertar.Location = new Point(345, 7);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(395, 29);
            btnInsertar.TabIndex = 5;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // dgvAuthors
            // 
            dgvAuthors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAuthors.Location = new Point(1, 60);
            dgvAuthors.Name = "dgvAuthors";
            dgvAuthors.RowHeadersWidth = 51;
            dgvAuthors.Size = new Size(1079, 536);
            dgvAuthors.TabIndex = 4;
            dgvAuthors.CellContentClick += dgvAuthors_CellContentClick;
            // 
            // FrmListaEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 603);
            Controls.Add(btnInsertar);
            Controls.Add(dgvAuthors);
            Name = "FrmListaEmpleados";
            Text = "FrmListaEmpleados";
            Activated += FrmListaEmpleados_Activated;
            Load += FrmListaEmpleados_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAuthors).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnInsertar;
        private DataGridView dgvAuthors;
    }
}