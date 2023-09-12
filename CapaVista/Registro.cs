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
using CapaVista.Componentes.Utilidades;

namespace CapaVista
{
    public partial class Registro : Form
    {
        private ControladorRegistro ctrReg;
        private utilidadesConsultasI utilConsultasI;
        
        public Registro()
        {
            InitializeComponent();
            this.ctrReg = new ControladorRegistro();
        }
        public void identificarFormularioReg(Form child, string operacion)
        {
            if (child.Tag.ToString().Equals("fRegistro"))
            {
                if (operacion.Equals("g")) this.utilConsultasI.guardarUsuario(child);
            }
        }

        private void bt_save_user_Click(object sender, EventArgs e)
        {
            
        }

        private void bt_save_user_Click_1(object sender, EventArgs e)
        {
            Form child_form = null;
            foreach (Control control in this.pn_contenedor.Controls)
            {
                if (control is Form)
                {
                    child_form = (Form)control;
                    Console.WriteLine(child_form);
                    break;
                }
            }

            this.identificarFormularioReg(child_form, "g");
        }
    }
}
