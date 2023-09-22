using CapaControlador;
using CapaVista.Componentes.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class Navegador : UserControl
    {

        private ControladorNavegador ctrNav;
        private utilidadesConsultasI utilConsultasI;
        public string operacion = "";

        public Form parent;
        public Navegador()
        {
            InitializeComponent();
            this.parent = new Form();
            this.ctrNav = new ControladorNavegador();
            this.utilConsultasI = new utilidadesConsultasI(this.ctrNav);
            this.cambiarEstado(false);
        }



        public void identificarFormulario(Form child, string operacion)
        {
            if (child.Tag.ToString().Equals("fReservacion"))
            {
                if (operacion.Equals("g")) this.utilConsultasI.guardarReservacion(child);
            }
            if (child.Tag.ToString().Equals("frmInventario"))
            {
                if (operacion.Equals("g")) this.utilConsultasI.guardarInventario(child);
            }
            if (child.Tag.ToString().Equals("frmEmpleado"))
            {
                if (operacion.Equals("g")) this.utilConsultasI.guardarEmpleado(child);
            }
            if (child.Tag.ToString().Equals("frmNomina"))
            {
                if (operacion.Equals("g")) this.utilConsultasI.guardarEmpleadoNom(child);
            }
            if (child.Tag.ToString().Equals("frmClientes"))
            {
                if (operacion.Equals("g")) this.utilConsultasI.guardarCliente(child);
            }
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            this.identificarFormulario(this.parent, "g");
            this.cambiarEstado(false);
        }

        public void cambiarEstado(bool estado)
        {
            foreach (Control control in this.panel.Controls)
            {
                if (control is Button)
                {
                    Button btn = (Button)control;
                    if (btn.Name.Equals("btn_guardar") || btn.Name.Equals("btn_cancelar"))
                    {
                        btn.Enabled = estado;
                    }
                    else
                    {
                        btn.Enabled = !estado;
                    }
                }
            }

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            this.cambiarEstado(true);
        }

        public void limpiarControles()
        {
            foreach (Control control in this.parent.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                else if (control is DateTimePicker)
                {
                    ((DateTimePicker)control).Value = DateTime.Now;
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = 0;
                }
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.limpiarControles();
            this.cambiarEstado(false);
        }

        private void btn_ayuda_Click_1(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Ayudas/AyudaSO2.chm", "NavAyuda.html");
        }
    }
}
