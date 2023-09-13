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
        ControladorRegistro ctrReg = new ControladorRegistro();
        private utilidadesConsultasI utilConsultasI;
        
        public Registro()
        {
            InitializeComponent();
            this.ctrReg = new ControladorRegistro();
            utilConsultasI = new utilidadesConsultasI();
        }
        public void identificarFormularioReg(Form child, string operacion)
        {
            MessageBox.Show("Idenfiticando");
            if (child.Tag.ToString().Equals("fRegistro"))
            {
                MessageBox.Show("IF");
                if (operacion.Equals("g")) this.utilConsultasI.guardarUsuario(child);
            }
        }

        private void bt_save_user_Click(object sender, EventArgs e)
        {
            
        }

        private void bt_save_user_Click_1(object sender, EventArgs e)
        {

            try
            {
             
             this.identificarFormularioReg(this, "g");
            }catch(Exception ex)
            {
                MessageBox.Show("Empleado creado" + ex);

            }
            }
    }
}
