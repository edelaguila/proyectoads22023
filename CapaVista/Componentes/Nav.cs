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

namespace CapaVista.Componentes
{
    public partial class Nav : Form
    {

        public Navegador parent;
        public void printControls()
        {
            foreach(Control control in this.parent.frm_container.Controls)
            {
                MessageBox.Show(control.Name);
            }
        }
        public Nav(Navegador parent)
        {
            this.parent = parent;
            InitializeComponent();
            this.printControls();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
