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
            menuStrip1 = new MenuStrip();
            tablaToolStripMenuItem = new ToolStripMenuItem();
            autoresToolStripMenuItem = new ToolStripMenuItem();
            titulosToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvAuthors).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnInsertar
            // 
            btnInsertar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnInsertar.BackColor = Color.LightCyan;
            btnInsertar.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsertar.Location = new Point(354, 25);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(395, 29);
            btnInsertar.TabIndex = 5;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = false;
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
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.LightCyan;
            menuStrip1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tablaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1085, 33);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // tablaToolStripMenuItem
            // 
            tablaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { autoresToolStripMenuItem, titulosToolStripMenuItem });
            tablaToolStripMenuItem.Name = "tablaToolStripMenuItem";
            tablaToolStripMenuItem.Size = new Size(87, 29);
            tablaToolStripMenuItem.Text = "Tabla";
            // 
            // autoresToolStripMenuItem
            // 
            autoresToolStripMenuItem.Name = "autoresToolStripMenuItem";
            autoresToolStripMenuItem.Size = new Size(186, 30);
            autoresToolStripMenuItem.Text = "Autores";
            autoresToolStripMenuItem.Click += autoresToolStripMenuItem_Click;
            // 
            // titulosToolStripMenuItem
            // 
            titulosToolStripMenuItem.Name = "titulosToolStripMenuItem";
            titulosToolStripMenuItem.Size = new Size(186, 30);
            titulosToolStripMenuItem.Text = "Titulos";
            titulosToolStripMenuItem.Click += titulosToolStripMenuItem_Click;
            // 
            // FrmListaEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 603);
            Controls.Add(btnInsertar);
            Controls.Add(dgvAuthors);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmListaEmpleados";
            Text = "Lista de Empleados";
            Activated += FrmListaEmpleados_Activated;
            Load += FrmListaEmpleados_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAuthors).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInsertar;
        private DataGridView dgvAuthors;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tablaToolStripMenuItem;
        private ToolStripMenuItem autoresToolStripMenuItem;
        private ToolStripMenuItem titulosToolStripMenuItem;
    }
}