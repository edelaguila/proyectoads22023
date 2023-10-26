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
        //Carol Chuy
        private void ocultarMenu()
        {
            panelMovSubmenu.Visible = false;
            panelCotizacionesPedidosFact.Visible = false;
            panelOrdenesdeCompraCompras.Visible = false;
            panelMantenimientos.Visible = false;
        }

        //Carol Chuy
        private void mostrarsubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                ocultarMenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }


        private void Abrir(object abrirform)
        {
            if (this.panelhijo.Controls.Count > 0)
                this.panelhijo.Controls.RemoveAt(0);

            Form fh = abrirform as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.None;
            this.panelhijo.Controls.Add(fh);
            this.panelhijo.Tag = fh;
            fh.Show();
        }


        public MenuMDI()
        {
            InitializeComponent();
        }

        private void MenuMDI_Load(object sender, EventArgs e)
        {
            //Carol Chuy
            ocultarMenu();
        }


        private void asignarCalificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abrir(new Procedimientos.MantCalificacion());
        }

        private void btnMovClientesyProveedores_Click(object sender, EventArgs e)
        {
            mostrarsubMenu(panelMovSubmenu);
        }

        private void btnCotiPedidoFact_Click(object sender, EventArgs e)
        {
            mostrarsubMenu(panelCotizacionesPedidosFact);
        }

        private void btnOrdenesyCompras_Click(object sender, EventArgs e)
        {
            mostrarsubMenu(panelOrdenesdeCompraCompras);
        }

        private void btnMantenimientos_Click(object sender, EventArgs e)
        {
            mostrarsubMenu(panelMantenimientos);
        }

        private void btnMovClientes_Click(object sender, EventArgs e)
        {
            Abrir(new Procedimientos.Movimiento_cliente());
        }

        private void btnMovProveedores_Click(object sender, EventArgs e)
        {
            Abrir(new Procedimientos.Movimiento_Proveedor());
        }

        private void btnCotizaciones_Click(object sender, EventArgs e)
        {
            Abrir(new Procesos.Cotizaciones__pedidos_y_facturas.Cotizaciones());
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            Abrir(new Procesos.Cotizaciones__pedidos_y_facturas.Pedidos());
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            Abrir(new Procesos.Cotizaciones__pedidos_y_facturas.Factura());
        }

        private void btnOrdenesCompra_Click(object sender, EventArgs e)
        {
            Abrir(new Procedimientos.OrdenesdeCompra());
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            Abrir(new Procedimientos.Compras());
        }

        private void btnManteniClientes_Click(object sender, EventArgs e)
        {

        }
    }
}
