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
    public partial class Navegador : Form
    {

        public Form frm_container;
        public void openFormOnPanel(Panel panel, Form child)
        {
            child.Dock = DockStyle.Fill;
            child.TopLevel = false;
            panel.Controls.Add(child);
            panel.Tag = child;
            child.Show();
        }

        public void inicializador()
        {
            Reporte rpt = new Reporte();
            this.frm_container = rpt;
            this.openFormOnPanel(pnl_navegador, new Nav(this));
            this.openFormOnPanel(pnl_contenedor, rpt);
        }

        public Navegador()
        {
            InitializeComponent();
            this.inicializador();
        }
    }
}
