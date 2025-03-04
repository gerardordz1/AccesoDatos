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
            menuStrip1 = new MenuStrip();
            autoresToolStripMenuItem = new ToolStripMenuItem();
            listaToolStripMenuItem = new ToolStripMenuItem();
            títulosToolStripMenuItem = new ToolStripMenuItem();
            listaDeTítulosToolStripMenuItem = new ToolStripMenuItem();
            empleadosToolStripMenuItem = new ToolStripMenuItem();
            listaDeEmpleadosToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { autoresToolStripMenuItem, títulosToolStripMenuItem, empleadosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // autoresToolStripMenuItem
            // 
            autoresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listaToolStripMenuItem });
            autoresToolStripMenuItem.Name = "autoresToolStripMenuItem";
            autoresToolStripMenuItem.Size = new Size(74, 24);
            autoresToolStripMenuItem.Text = "Autores";
            // 
            // listaToolStripMenuItem
            // 
            listaToolStripMenuItem.Name = "listaToolStripMenuItem";
            listaToolStripMenuItem.Size = new Size(198, 26);
            listaToolStripMenuItem.Text = "Lista de Autores";
            listaToolStripMenuItem.Click += listaToolStripMenuItem_Click;
            // 
            // títulosToolStripMenuItem
            // 
            títulosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listaDeTítulosToolStripMenuItem });
            títulosToolStripMenuItem.Name = "títulosToolStripMenuItem";
            títulosToolStripMenuItem.Size = new Size(67, 24);
            títulosToolStripMenuItem.Text = "Títulos";
            // 
            // listaDeTítulosToolStripMenuItem
            // 
            listaDeTítulosToolStripMenuItem.Name = "listaDeTítulosToolStripMenuItem";
            listaDeTítulosToolStripMenuItem.Size = new Size(191, 26);
            listaDeTítulosToolStripMenuItem.Text = "Lista de Títulos";
            listaDeTítulosToolStripMenuItem.Click += listaDeTítulosToolStripMenuItem_Click;
            // 
            // empleadosToolStripMenuItem
            // 
            empleadosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listaDeEmpleadosToolStripMenuItem });
            empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            empleadosToolStripMenuItem.Size = new Size(97, 24);
            empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // listaDeEmpleadosToolStripMenuItem
            // 
            listaDeEmpleadosToolStripMenuItem.Name = "listaDeEmpleadosToolStripMenuItem";
            listaDeEmpleadosToolStripMenuItem.Size = new Size(224, 26);
            listaDeEmpleadosToolStripMenuItem.Text = "Lista de Empleados";
            listaDeEmpleadosToolStripMenuItem.Click += listaDeEmpleadosToolStripMenuItem_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmMenu";
            Text = "frmMenu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem autoresToolStripMenuItem;
        private ToolStripMenuItem listaToolStripMenuItem;
        private ToolStripMenuItem títulosToolStripMenuItem;
        private ToolStripMenuItem listaDeTítulosToolStripMenuItem;
        private ToolStripMenuItem empleadosToolStripMenuItem;
        private ToolStripMenuItem listaDeEmpleadosToolStripMenuItem;
    }
}