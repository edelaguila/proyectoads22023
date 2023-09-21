using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaVista.Componentes.Utilidades;
using CapaControlador;
namespace CapaVista.Formularios
{
    public partial class frmNomina : Form
    {
        ControladorNomina ctrNom = new ControladorNomina();

        private utilidadesConsultasI utilConsultasI;
        public frmNomina()
        {
            InitializeComponent();
            utilConsultasI = new utilidadesConsultasI();
        }
        public void identificarFormulario(Form child, string operacion)
        {
            if (child.Tag.ToString().Equals("fNomina"))
            {
                if (operacion.Equals("g")) this.utilConsultasI.guardarEmpleadoNom(child);
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {

                this.identificarFormulario(this, "g");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Empeado Creado" + ex);

            }

        }
    }
}
