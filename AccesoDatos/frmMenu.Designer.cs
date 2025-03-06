namespace AccesoDatos
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            menuStrip1 = new MenuStrip();
            tablasToolStripMenuItem = new ToolStripMenuItem();
            autoresToolStripMenuItem1 = new ToolStripMenuItem();
            títulosToolStripMenuItem1 = new ToolStripMenuItem();
            empleadosToolStripMenuItem1 = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tablasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(513, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tablasToolStripMenuItem
            // 
            tablasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { autoresToolStripMenuItem1, títulosToolStripMenuItem1, empleadosToolStripMenuItem1 });
            tablasToolStripMenuItem.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tablasToolStripMenuItem.Name = "tablasToolStripMenuItem";
            tablasToolStripMenuItem.Size = new Size(99, 29);
            tablasToolStripMenuItem.Text = "Tablas";
            // 
            // autoresToolStripMenuItem1
            // 
            autoresToolStripMenuItem1.Name = "autoresToolStripMenuItem1";
            autoresToolStripMenuItem1.Size = new Size(220, 30);
            autoresToolStripMenuItem1.Text = "Autores";
            autoresToolStripMenuItem1.Click += autoresToolStripMenuItem1_Click;
            // 
            // títulosToolStripMenuItem1
            // 
            títulosToolStripMenuItem1.Name = "títulosToolStripMenuItem1";
            títulosToolStripMenuItem1.Size = new Size(220, 30);
            títulosToolStripMenuItem1.Text = "Títulos";
            títulosToolStripMenuItem1.Click += títulosToolStripMenuItem1_Click;
            // 
            // empleadosToolStripMenuItem1
            // 
            empleadosToolStripMenuItem1.Name = "empleadosToolStripMenuItem1";
            empleadosToolStripMenuItem1.Size = new Size(220, 30);
            empleadosToolStripMenuItem1.Text = "Empleados";
            empleadosToolStripMenuItem1.Click += empleadosToolStripMenuItem1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(513, 407);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 446);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmMenu";
            Text = "Menu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tablasToolStripMenuItem;
        private ToolStripMenuItem autoresToolStripMenuItem1;
        private ToolStripMenuItem títulosToolStripMenuItem1;
        private ToolStripMenuItem empleadosToolStripMenuItem1;
        private PictureBox pictureBox1;
    }
}