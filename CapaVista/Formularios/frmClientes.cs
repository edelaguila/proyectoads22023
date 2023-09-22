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

namespace CapaVista.Formularios
{
    public partial class frmClientes : Form
    {
        ControladorCliente ctrCliente = new ControladorCliente();
        private utilidadesConsultasI utilConsultasI;
        public frmClientes()
        {
            InitializeComponent();
            this.ctrCliente = new ControladorCliente();
            utilConsultasI = new utilidadesConsultasI();
        }

        public void identificarFormularioReg(Form child, string operacion)
        {
            MessageBox.Show("Idenfiticando");
            if (child.Tag.ToString().Equals("frClientes"))
            {
                MessageBox.Show("IF");
                if (operacion.Equals("g")) this.utilConsultasI.guardarCliente(child);
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {

                this.identificarFormularioReg(this, "g");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cliente no creado" + ex);

            }
        }
    }
}
