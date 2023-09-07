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
        public void openFormOnPanel(Panel panel, Form child)
        {
            if(this.current_form != null)
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
            this.openFormOnPanel(pnl_navegador, new Nav(this));
        }

        public Principal()
        {
            InitializeComponent();
            this.inicializador();
        }

        private void reservacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.openFormOnPanel(pnl_contenedor, new frmReservacion());
        }

        private void reportesSemanalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.openFormOnPanel(pnl_contenedor, new frmReportes());
        }

    }
}
