
namespace Prototipo_inicial_nav
{
    partial class MDIbase
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.integrantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.integrante1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.integrante2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.integrante3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.integrante4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.integrante5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem1});
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem1.Text = "Salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem,
            this.integrantesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(527, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // integrantesToolStripMenuItem
            // 
            this.integrantesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.integrante1ToolStripMenuItem,
            this.integrante2ToolStripMenuItem,
            this.integrante3ToolStripMenuItem,
            this.integrante4ToolStripMenuItem,
            this.integrante5ToolStripMenuItem});
            this.integrantesToolStripMenuItem.Name = "integrantesToolStripMenuItem";
            this.integrantesToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.integrantesToolStripMenuItem.Text = "Integrantes";
            // 
            // integrante1ToolStripMenuItem
            // 
            this.integrante1ToolStripMenuItem.Name = "integrante1ToolStripMenuItem";
            this.integrante1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.integrante1ToolStripMenuItem.Text = "Integrante1";
            this.integrante1ToolStripMenuItem.Click += new System.EventHandler(this.integrante1ToolStripMenuItem_Click);
            // 
            // integrante2ToolStripMenuItem
            // 
            this.integrante2ToolStripMenuItem.Name = "integrante2ToolStripMenuItem";
            this.integrante2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.integrante2ToolStripMenuItem.Text = "Integrante2";
            this.integrante2ToolStripMenuItem.Click += new System.EventHandler(this.integrante2ToolStripMenuItem_Click);
            // 
            // integrante3ToolStripMenuItem
            // 
            this.integrante3ToolStripMenuItem.Name = "integrante3ToolStripMenuItem";
            this.integrante3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.integrante3ToolStripMenuItem.Text = "Integrante3";
            // 
            // integrante4ToolStripMenuItem
            // 
            this.integrante4ToolStripMenuItem.Name = "integrante4ToolStripMenuItem";
            this.integrante4ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.integrante4ToolStripMenuItem.Text = "Integrante4";
            this.integrante4ToolStripMenuItem.Click += new System.EventHandler(this.integrante4ToolStripMenuItem_Click);
            // 
            // integrante5ToolStripMenuItem
            // 
            this.integrante5ToolStripMenuItem.Name = "integrante5ToolStripMenuItem";
            this.integrante5ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.integrante5ToolStripMenuItem.Text = "Integrante5";
            this.integrante5ToolStripMenuItem.Click += new System.EventHandler(this.integrante5ToolStripMenuItem_Click);
            // 
            // MDIbase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 330);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MDIbase";
            this.Text = "Contenedor";
            this.Load += new System.EventHandler(this.MDIbase_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem integrantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem integrante1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem integrante2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem integrante3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem integrante4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem integrante5ToolStripMenuItem;
    }
}

