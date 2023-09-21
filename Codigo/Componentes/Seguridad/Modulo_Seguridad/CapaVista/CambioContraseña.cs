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

namespace CapaVista
{
    public partial class CambioContraseña : Form
    {
        public CambioContraseña()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tabla = "NombreDeTuTabla";
            Dictionary<string, object> valores = new Dictionary<string, object>();

            Controlador controlador = new Controlador();
            bool exito = controlador.GuardarDatos(tabla, valores);

            if (exito)
            {
                MessageBox.Show("Los datos se han guardado correctamente.");
            }
            else
            {
                MessageBox.Show("Error al guardar los datos.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "ComponenteSeguridadAyuda/AyudaSeguridad.chm", "Seguridad.html");
            //Help.ShowHelp(this, "C:/Users/rayju/OneDrive/Escritorio/GitHub AnotherWork/proyectoads22023/Codigo/Componentes/Seguridad/Modulo_Seguridad/CapaVista/bin/Debug/ComponenteSeguridadAyuda/AyudaSeguridad.chm", "Ayuda.html");
        }
    }
}
