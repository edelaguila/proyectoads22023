using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;
using System.IO;
using System.Diagnostics;

namespace CapaVista
{
    public partial class MenuMDI : Form
    {



        private void Abrir(object abrirform)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);

            Form fh = abrirform as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.None;
            this.panel1.Controls.Add(fh);
            this.panel1.Tag = fh;
            fh.Show();
        }


        public MenuMDI()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void bitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void asignacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void seguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
     
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }


        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MenuMDI_Load(object sender, EventArgs e)
        {

        }


        private void asignarCalificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abrir(new Procedimientos.MantCalificacion());
        }

        private void mDIToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Abrir(new Mantenimiento."nombre de la form"());
        }

        private void mantenimientoProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Abrir(new Mantenimiento."nombre de la form"());
        }

        private void movimientoClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir(new Procedimientos.Movimiento_cliente());
        }

        private void movimientoProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir(new Procedimientos.Movimiento_Proveedor());
        }

        private void cotizacionesPedidosYFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abrir(new Procedimientos."nombre de la form"());
        }

        private void ordenesDeCompraYComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abrir(new Procedimientos."nombre de la form"());
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir(new Procesos.Cotizaciones__pedidos_y_facturas.Pedidos());
        }

        private void cotizacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir(new Procesos.Cotizaciones__pedidos_y_facturas.Cotizaciones());
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir(new Procesos.Cotizaciones__pedidos_y_facturas.Factura());
        }

        private void órdenesDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir(new Procedimientos.OrdenesdeCompra());
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir(new Procedimientos.Compras());
        }
    }
}
