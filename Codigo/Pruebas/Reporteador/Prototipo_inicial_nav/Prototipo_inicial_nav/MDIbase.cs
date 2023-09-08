using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo_inicial_nav
{
    public partial class MDIbase : Form
    {
        public MDIbase()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrar sesión?", "Mensaje",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();//Cierra el formulario
        }

        private void integrante1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIntegrante1 formIntegrante1 = new frmIntegrante1();
            formIntegrante1.MdiParent = this;
            formIntegrante1.Show();
        }

        private void MDIbase_Load(object sender, EventArgs e)
        {

        }
    }
}
