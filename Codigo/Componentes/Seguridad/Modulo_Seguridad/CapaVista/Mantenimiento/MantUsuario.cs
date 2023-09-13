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
    public partial class MantUsuario : Form
    {
        public MantUsuario()
        {
            InitializeComponent();
        }

        Controlador cn = new Controlador();

        //carlos enrique
        public void Buscar()
        {
            string dato = textBox1.Text;
            string tabla = "usuarios";
            string columna = "id_usuario";
            DataTable dt = cn.Buscar(tabla, columna, dato);

            if (dt.Rows.Count > 0)
            {
                

                DataRow row = dt.Rows[0]; // Tomamos la primera fila (si hay resultados)

                // Llenamos los controles con los valores del resultado
                textBox2.Text = row["id_usuario"].ToString();
                textBox3.Text = row["contraseña"].ToString();
                textBox5.Text = row["nombre"].ToString();
                textBox4.Text = row["apellido"].ToString();

                // Verificamos el estado y marcamos el RadioButton correspondiente
                bool estadoActivo = Convert.ToInt32(row["estado"]) == 1;
                radioButton1.Checked = estadoActivo;
                radioButton2.Checked = !estadoActivo;
            }
            else
            {
                // Limpiamos los controles si no se encontraron resultados
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                textBox5.Text = string.Empty;
                textBox4.Text = string.Empty;
                textBox3.Text = string.Empty;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
            }
        }

        //carlos enrique
        public void EliminarDato(string tabla, string columna, string valor)
        {
            bool eliminado = cn.Eliminar(tabla, columna, valor);
            if (eliminado)
            {
                MessageBox.Show("Registro eliminado correctamente.");
            }
            else
            {
                MessageBox.Show($"No se pudo eliminar el registro. Verifique el {columna}.");
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            //carlos enrique
            Buscar();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //carlos enrique
            string valor = textBox1.Text;

            // Llama a la función de eliminación pasando los parámetros necesarios
            string tabla = "usuarios"; // Nombre de la tabla
            string columna = "id_usuario"; // Nombre de la columna
            EliminarDato(tabla, columna, valor);
        }

        private void button6_Click(object sender, EventArgs e)
        {

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
    }
}
