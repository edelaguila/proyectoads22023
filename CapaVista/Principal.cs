using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaVista.Componentes;
using CapaVista.Formularios;

namespace CapaVista
{
    public partial class Principal : Form
    {

        public Form frm_container;
        public Form current_form;
        public void openFormOnPanel(Panel panel, Form child, bool isNav)
        {
            if (this.current_form != null && isNav == false)
            {
                this.current_form.Close();
            }
            child.Dock = DockStyle.Fill;
            child.TopLevel = false;
            panel.Controls.Add(child);
            panel.Tag = child;
            this.current_form = child;
            child.Show();
        }

        public void inicializador()
        {
            this.openFormOnPanel(pnl_navegador, new Nav(this), true);
            this.current_form = null;
        }

        public Principal()
        {
            InitializeComponent();
            this.inicializador();
        }

        private void reservacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.openFormOnPanel(pnl_contenedor, new frmReservacion(), false);
        }

        private void reportesSemanalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.openFormOnPanel(pnl_contenedor, new frmReportes(), false);
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.openFormOnPanel(pnl_contenedor, new frmInventario(), false);
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.openFormOnPanel(pnl_contenedor, new frmEmpleado(), false);
        }

        private void seguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.openFormOnPanel(pnl_contenedor, new frmNomina(), false);
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.openFormOnPanel(pnl_contenedor, new frmClientes(), false);
        }
    }
}
