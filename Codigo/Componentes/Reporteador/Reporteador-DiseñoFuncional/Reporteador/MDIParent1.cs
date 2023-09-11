using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reporteador
{
    public partial class MdiParent : Form
    {
        public MdiParent()
        {
            InitializeComponent();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes nuevo = new Reportes();
            nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void navegadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 nuevo = new Form1();
            nuevo.MdiParent = this;
            nuevo.Show();
        }
    }
}
