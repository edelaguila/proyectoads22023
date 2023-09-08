using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;
using CapaVista.Componentes.Utilidades;

namespace CapaVista.Componentes
{
    public partial class Nav : Form
    {
        private ControladorNavegador ctrNav;
        private utilidadesConsultasI utilConsultasI;

        public Principal parent;
        public void printControls()
        {
            foreach (Control control in this.parent.frm_container.Controls)
            {
                MessageBox.Show(control.Name);
            }
        }
        public Nav(Principal parent)
        {
            this.ctrNav = new ControladorNavegador();
            this.utilConsultasI = new utilidadesConsultasI(this.ctrNav);
            this.parent = parent;
            InitializeComponent();
            //this.printControls();
        }



        public void identificarFormulario(Form child, string operacion)
        {
            if (child.Tag.ToString().Equals("fReservacion"))
            {
                if (operacion.Equals("g")) this.utilConsultasI.guardarReservacion(child);
            }
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Form child_form = null;
            foreach (Control control in this.parent.pnl_contenedor.Controls)
            {
                if (control is Form)
                {
                    child_form = (Form)control;
                    break;
                }
            }

            this.identificarFormulario(child_form, "g");
        }


    }
}
