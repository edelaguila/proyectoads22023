
namespace CapaVista
{
    partial class MenuMDI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientoClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientoProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cotizacionesPedidosYFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenesDeCompraYComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitacoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cotizacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1233, 611);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seguridadToolStripMenuItem,
            this.mantenimientoToolStripMenuItem,
            this.asignacionesToolStripMenuItem,
            this.bitacoraToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1233, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.seguridadToolStripMenuItem.Text = "Sesion";
            this.seguridadToolStripMenuItem.Click += new System.EventHandler(this.seguridadToolStripMenuItem_Click);
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.mantenimientoProveedoresToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimientos";
            this.mantenimientoToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.clientesToolStripMenuItem.Text = "Mantenimiento Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // mantenimientoProveedoresToolStripMenuItem
            // 
            this.mantenimientoProveedoresToolStripMenuItem.Name = "mantenimientoProveedoresToolStripMenuItem";
            this.mantenimientoProveedoresToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.mantenimientoProveedoresToolStripMenuItem.Text = "Mantenimiento Proveedores";
            this.mantenimientoProveedoresToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoProveedoresToolStripMenuItem_Click);
            // 
            // asignacionesToolStripMenuItem
            // 
            this.asignacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movimientoClientesToolStripMenuItem,
            this.movimientoProveedorToolStripMenuItem,
            this.cotizacionesPedidosYFacturasToolStripMenuItem,
            this.ordenesDeCompraYComprasToolStripMenuItem});
            this.asignacionesToolStripMenuItem.Name = "asignacionesToolStripMenuItem";
            this.asignacionesToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.asignacionesToolStripMenuItem.Text = "Procesos";
            this.asignacionesToolStripMenuItem.Click += new System.EventHandler(this.asignacionesToolStripMenuItem_Click);
            // 
            // movimientoClientesToolStripMenuItem
            // 
            this.movimientoClientesToolStripMenuItem.Name = "movimientoClientesToolStripMenuItem";
            this.movimientoClientesToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.movimientoClientesToolStripMenuItem.Text = "Movimiento Cliente";
            this.movimientoClientesToolStripMenuItem.Click += new System.EventHandler(this.movimientoClientesToolStripMenuItem_Click);
            // 
            // movimientoProveedorToolStripMenuItem
            // 
            this.movimientoProveedorToolStripMenuItem.Name = "movimientoProveedorToolStripMenuItem";
            this.movimientoProveedorToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.movimientoProveedorToolStripMenuItem.Text = "Movimiento Proveedor";
            this.movimientoProveedorToolStripMenuItem.Click += new System.EventHandler(this.movimientoProveedorToolStripMenuItem_Click);
            // 
            // cotizacionesPedidosYFacturasToolStripMenuItem
            // 
            this.cotizacionesPedidosYFacturasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cotizacionesToolStripMenuItem,
            this.pedidosToolStripMenuItem,
            this.facturasToolStripMenuItem});
            this.cotizacionesPedidosYFacturasToolStripMenuItem.Name = "cotizacionesPedidosYFacturasToolStripMenuItem";
            this.cotizacionesPedidosYFacturasToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.cotizacionesPedidosYFacturasToolStripMenuItem.Text = "Cotizaciones, pedidos y facturas";
            this.cotizacionesPedidosYFacturasToolStripMenuItem.Click += new System.EventHandler(this.cotizacionesPedidosYFacturasToolStripMenuItem_Click);
            // 
            // ordenesDeCompraYComprasToolStripMenuItem
            // 
            this.ordenesDeCompraYComprasToolStripMenuItem.Name = "ordenesDeCompraYComprasToolStripMenuItem";
            this.ordenesDeCompraYComprasToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.ordenesDeCompraYComprasToolStripMenuItem.Text = "Ordenes de compra y compras";
            this.ordenesDeCompraYComprasToolStripMenuItem.Click += new System.EventHandler(this.ordenesDeCompraYComprasToolStripMenuItem_Click);
            // 
            // bitacoraToolStripMenuItem
            // 
            this.bitacoraToolStripMenuItem.Name = "bitacoraToolStripMenuItem";
            this.bitacoraToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.bitacoraToolStripMenuItem.Text = "Reportes";
            this.bitacoraToolStripMenuItem.Click += new System.EventHandler(this.bitacoraToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // cotizacionesToolStripMenuItem
            // 
            this.cotizacionesToolStripMenuItem.Name = "cotizacionesToolStripMenuItem";
            this.cotizacionesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cotizacionesToolStripMenuItem.Text = "Cotizaciones";
            this.cotizacionesToolStripMenuItem.Click += new System.EventHandler(this.cotizacionesToolStripMenuItem_Click);
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            this.pedidosToolStripMenuItem.Click += new System.EventHandler(this.pedidosToolStripMenuItem_Click);
            // 
            // facturasToolStripMenuItem
            // 
            this.facturasToolStripMenuItem.Name = "facturasToolStripMenuItem";
            this.facturasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.facturasToolStripMenuItem.Text = "Facturas";
            this.facturasToolStripMenuItem.Click += new System.EventHandler(this.facturasToolStripMenuItem_Click);
            // 
            // MenuMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 635);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MenuMDI";
            this.Text = "Gestion Comercial";
            this.Load += new System.EventHandler(this.MenuMDI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitacoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimientoClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimientoProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cotizacionesPedidosYFacturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenesDeCompraYComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cotizacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturasToolStripMenuItem;
    }
}