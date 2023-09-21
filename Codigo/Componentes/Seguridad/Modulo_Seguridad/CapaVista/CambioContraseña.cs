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
        //Erick Ramirez
        Controlador cn = new Controlador();

        //Erick Ramirez
        public void Buscar()
        {
            string dato = textBox1.Text;
            string tabla = "tbl_usuario";
            string columna = "PK_id_usuario";
            DataTable dt = cn.Buscar(tabla, columna, dato);

            if (dt.Rows.Count > 0)
            {
                //Erick Ramirez
                MessageBox.Show("El dato se encontro correctamente");
                DataRow row = dt.Rows[0]; // Tomamos la primera fila (si hay resultados)

                // Llenamos los controles con los valores del resultado
                textBox2.Text = row["PK_id_usuario"].ToString();
                textBox3.Text = row["nbr_password_usuario"].ToString();
                textBox4.Text = row["nbr_nombre_usuario"].ToString();
                textBox5.Text = row["nbr_apellido_usuario"].ToString();

            }
            else
            {
                // Limpiamos los controles si no se encontraron resultados
                //Limpieza de datos 
                //Erick Ramirez
                Limpiar();
                MessageBox.Show("No se encontro el dato");
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        //Erick Ramirez
        public void Limpiar()
        {
            //Erick Ramirez
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Erick Ramirez
            //BOTON MODIFICAR
            string tabla = "tbl_usuario";
            Dictionary<string, object> valores = new Dictionary<string, object>();
            Controlador controlador = new Controlador();


            valores.Add("PK_id_usuario", int.Parse(textBox2.Text));

            if (textBox3.Text.Length == 64)
            {
                valores.Add("nbr_password_usuario", textBox3.Text);
            }
            else if (textBox3.Text.Length < 64)
            {
                valores.Add("nbr_password_usuario", cn.Encriptacion(textBox3.Text));

            }

            valores.Add("nbr_nombre_usuario", textBox4.Text);
            valores.Add("nbr_apellido_usuario", textBox5.Text);
            string condicion = $"PK_id_usuario = '{int.Parse(textBox2.Text)}'";

            bool exito = controlador.Modificar(tabla, valores, condicion);

            Limpiar();
             
            if (exito)
            {

                MessageBox.Show("Los datos se han modificado correctamente.");
            }
            else
            {
                MessageBox.Show("Error al modificar los datos.");
            }
        }
    }
}
