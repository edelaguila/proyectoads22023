using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class MDIParent1 : Form
    {
        
        public MDIParent1()
        {
            InitializeComponent();
        }

        private void percepcionesYDeduccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_deduccion dp = new frm_deduccion();
            dp.MdiParent = this;
            dp.Show();

        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_mantenimiento mn = new frm_mantenimiento();
            mn.MdiParent = this;
            mn.Show();
        }
    }
}
