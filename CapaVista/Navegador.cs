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
        private utilidadesConsultasI utilConsultasI;
        public string operacion = "";
        public string tabla = "";

        public Form parent;
        public Navegador()
        {
            InitializeComponent();
            this.parent = new Form();
            this.utilConsultasI = new utilidadesConsultasI();
            this.cambiarEstado(false);
        }

        public void config(string tabla, Form parent)
        {
            this.tabla = tabla;
            this.parent = parent;
            this.utilConsultasI.setTabla(this.tabla);
        }


        public void identificarFormulario(Form child, string operacion)
        {
            if (operacion.Equals("g")) this.utilConsultasI.guardar(child);
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
