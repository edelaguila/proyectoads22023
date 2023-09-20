
namespace CapaVista
{
    partial class Principal
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
            this.pnl_navegador = new System.Windows.Forms.Panel();
            this.pnl_contenedor = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasInteligentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesSemanalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_navegador
            // 
            this.pnl_navegador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(161)))), ((int)(((byte)(116)))));
            this.pnl_navegador.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_navegador.Location = new System.Drawing.Point(29, 48);
            this.pnl_navegador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_navegador.Name = "pnl_navegador";
            this.pnl_navegador.Size = new System.Drawing.Size(1010, 110);
            this.pnl_navegador.TabIndex = 1;
            // 
            // pnl_contenedor
            // 
            this.pnl_contenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(161)))), ((int)(((byte)(116)))));
            this.pnl_contenedor.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_contenedor.Location = new System.Drawing.Point(29, 186);
            this.pnl_contenedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_contenedor.Name = "pnl_contenedor";
            this.pnl_contenedor.Size = new System.Drawing.Size(1008, 373);
            this.pnl_contenedor.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(120)))), ((int)(((byte)(81)))));
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.consultasInteligentesToolStripMenuItem,
            this.seguridadToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1089, 30);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.archivoToolStripMenuItem.Text = "Inicio";
            // 
            // consultasInteligentesToolStripMenuItem
            // 
            this.consultasInteligentesToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.consultasInteligentesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservacionesToolStripMenuItem});
            this.consultasInteligentesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.consultasInteligentesToolStripMenuItem.Name = "consultasInteligentesToolStripMenuItem";
            this.consultasInteligentesToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.consultasInteligentesToolStripMenuItem.Text = "Mantenimiento";
            // 
            // reservacionesToolStripMenuItem
            // 
            this.reservacionesToolStripMenuItem.Name = "reservacionesToolStripMenuItem";
            this.reservacionesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.reservacionesToolStripMenuItem.Text = "Reservaciones";
            this.reservacionesToolStripMenuItem.Click += new System.EventHandler(this.reservacionesToolStripMenuItem_Click);
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.seguridadToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.seguridadToolStripMenuItem.Text = "Procesos";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportesSemanalesToolStripMenuItem});
            this.reportesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reportesSemanalesToolStripMenuItem
            // 
            this.reportesSemanalesToolStripMenuItem.Name = "reportesSemanalesToolStripMenuItem";
            this.reportesSemanalesToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.reportesSemanalesToolStripMenuItem.Text = "Reportes Semanales";
            this.reportesSemanalesToolStripMenuItem.Click += new System.EventHandler(this.reportesSemanalesToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.ayudaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(235)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(1089, 622);
            this.Controls.Add(this.pnl_navegador);
            this.Controls.Add(this.pnl_contenedor);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Principal";
            this.Text = "Navegador";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Panel pnl_navegador;
        public System.Windows.Forms.Panel pnl_contenedor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasInteligentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesSemanalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
    }
}