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

namespace CapaVista.Asignaciones
{
    public partial class AsigAplicaPerfiles : Form
    {
        public AsigAplicaPerfiles()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
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



        private void button4_Click(object sender, EventArgs e)
        {

        }


    }
}
