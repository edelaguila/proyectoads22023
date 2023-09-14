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

namespace CapaVista.Mantenimiento
{
    public partial class MantAplicaciones : Form
    {
        public MantAplicaciones()
        {
            InitializeComponent();
        }



        Controlador cn = new Controlador();

        //carlos enrique
        public void Buscar()
        {
            string dato = textBox1.Text;
            string tabla = "tbl_aplicacion";
            string columna = "PK_id_aplicacion";
            DataTable dt = cn.Buscar(tabla,columna,dato);
            
            if (dt.Rows.Count > 0)
            {
              

                DataRow row = dt.Rows[0]; // Tomamos la primera fila (si hay resultados)

                // Llenamos los controles con los valores del resultado
                textBox2.Text = row["PK_id_aplicacion"].ToString();
                comboBox1.SelectedItem = row["id_modulos"].ToString();
                textBox4.Text = row["nombre_aplicacion"].ToString();
                textBox5.Text = row["descripcion"].ToString();

                // Verificamos el estado y marcamos el RadioButton correspondiente
                bool estadoActivo = Convert.ToInt32(row["estado"]) == 1;
                radioButton1.Checked = estadoActivo;
                radioButton2.Checked = !estadoActivo;
            }
            else
            {
                // Limpiamos los controles si no se encontraron resultados
                textBox1.Text = string.Empty;
                comboBox1.SelectedItem = null;
                textBox2.Text = string.Empty;
                textBox4.Text = string.Empty;
                textBox5.Text = string.Empty;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
            }
        }


        // carlos enrique
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
            string tabla = "aplicaciones"; // Nombre de la tabla
            string columna = "id_aplicacion"; // Nombre de la columna
            EliminarDato(tabla, columna, valor);
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
