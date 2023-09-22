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
    public partial class frmInventario : Form
    {

        ControladorInventario ctrInv = new ControladorInventario();
        private utilidadesConsultasI utilConsultasI;



        public frmInventario()
        {
            InitializeComponent();
            this.ctrInv = new ControladorInventario();
            utilConsultasI = new utilidadesConsultasI();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        public void identificarFormularioReg(Form child, string operacion)
        {
            MessageBox.Show("Idenfiticando");
            if (child.Tag.ToString().Equals("frINVE"))
            {
                MessageBox.Show("IF");
                if (operacion.Equals("g")) this.utilConsultasI.guardarInventario(child);
            }
        }

        public void guardar()
        {
            try
            {

                this.identificarFormularioReg(this, "g");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Inventario creado" + ex);

            }
        }

        private void btn_guardar_inv_Click(object sender, EventArgs e)
        {

        }
    }
}

