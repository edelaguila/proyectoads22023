using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows. Forms;
using CapaControlador;
using CapaVista.Componentes.Utilidades;

namespace CapaVista.Formularios
{
    public partial class frmEmpleado : Form
    {
        ControladorEmpleado ctrEmple = new ControladorEmpleado();
        private utilidadesConsultasI utilConsultasI;

        public frmEmpleado()
        {
            InitializeComponent();
            this.ctrEmple = new ControladorEmpleado();
            utilConsultasI = new utilidadesConsultasI();
        }

        public void identificarFormularioEmp(Form child, string operacion)
        {
            MessageBox.Show("Idenfiticando");
            if (child.Tag.ToString().Equals("frmEmpleado"))
            {
                MessageBox.Show("IF");
                if (operacion.Equals("g")) this.utilConsultasI.guardarEmpleado(child);
            }
        }


        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.identificarFormularioEmp(this, "g");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Inventario creado" + ex);

            }
        }
    }
}
