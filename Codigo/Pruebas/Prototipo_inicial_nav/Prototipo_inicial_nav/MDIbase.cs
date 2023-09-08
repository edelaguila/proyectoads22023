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

        private void integrante2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIntegrante2 formIntegrante2 = new frmIntegrante2();
            formIntegrante2.MdiParent = this;
            formIntegrante2.Show();
        }

        private void integrante4ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmIntegrante4 formIntegrante4 = new frmIntegrante4();
            formIntegrante4.MdiParent = this;
            formIntegrante4.Show();
        }

       

        private void integrante6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIntegrante6 formIntegrante6 = new frmIntegrante6();
            formIntegrante6.MdiParent = this;
            formIntegrante6.Show();
        }

        private void integrante7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIntegrante7 formIntegrante7 = new frmIntegrante7();
            formIntegrante7.MdiParent = this;
            formIntegrante7.Show();
        }

        private void integrante3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIntegrante3 formIntegrante3 = new frmIntegrante3();
            formIntegrante3.MdiParent = this;
            formIntegrante3.Show();
        }

        private void integrante5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIntegrante5 formIntegrante5 = new frmIntegrante5();
            formIntegrante5.MdiParent = this;
            formIntegrante5.Show();
        }
    }
}
