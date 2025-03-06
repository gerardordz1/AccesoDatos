namespace AccesoDatos
{
    partial class FrmAutores
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
            dgvAuthors = new DataGridView();
            btnInsertar = new Button();
            menuStrip1 = new MenuStrip();
            tablasToolStripMenuItem = new ToolStripMenuItem();
            titulosToolStripMenuItem = new ToolStripMenuItem();
            empleadosToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvAuthors).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvAuthors
            // 
            dgvAuthors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAuthors.Location = new Point(0, 80);
            dgvAuthors.Name = "dgvAuthors";
            dgvAuthors.RowHeadersWidth = 51;
            dgvAuthors.Size = new Size(1079, 536);
            dgvAuthors.TabIndex = 0;
            dgvAuthors.CellContentClick += dgvAuthors_CellContentClick;
            // 
            // btnInsertar
            // 
            btnInsertar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnInsertar.BackColor = Color.LightCyan;
            btnInsertar.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsertar.Location = new Point(456, 36);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(106, 43);
            btnInsertar.TabIndex = 1;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = false;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.LightCyan;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tablasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1079, 33);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // tablasToolStripMenuItem
            // 
            tablasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { titulosToolStripMenuItem, empleadosToolStripMenuItem });
            tablasToolStripMenuItem.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tablasToolStripMenuItem.Name = "tablasToolStripMenuItem";
            tablasToolStripMenuItem.Size = new Size(99, 29);
            tablasToolStripMenuItem.Text = "Tablas";
            // 
            // titulosToolStripMenuItem
            // 
            titulosToolStripMenuItem.Name = "titulosToolStripMenuItem";
            titulosToolStripMenuItem.Size = new Size(220, 30);
            titulosToolStripMenuItem.Text = "Titulos";
            titulosToolStripMenuItem.Click += titulosToolStripMenuItem_Click;
            // 
            // empleadosToolStripMenuItem
            // 
            empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            empleadosToolStripMenuItem.Size = new Size(220, 30);
            empleadosToolStripMenuItem.Text = "Empleados";
            empleadosToolStripMenuItem.Click += empleadosToolStripMenuItem_Click;
            // 
            // FrmAutores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 616);
            Controls.Add(btnInsertar);
            Controls.Add(dgvAuthors);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmAutores";
            Text = "Autores";
            Activated += FrmAutores_Activated;
            Load += FrmAutores_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAuthors).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAuthors;
        private Button btnInsertar;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tablasToolStripMenuItem;
        private ToolStripMenuItem titulosToolStripMenuItem;
        private ToolStripMenuItem empleadosToolStripMenuItem;
    }
}