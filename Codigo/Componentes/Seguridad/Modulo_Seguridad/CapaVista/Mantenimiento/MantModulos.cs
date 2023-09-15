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
    public partial class MantModulos : Form
    {
        public MantModulos()
        {
            InitializeComponent();
        }

        Controlador cn = new Controlador();

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

        //carlos enrique
        public void Buscar()
        {
            string dato = textBox1.Text;
            string tabla = "tbl_modulo";
            string columna = "PK_id_Modulo";
            DataTable dt = cn.Buscar(tabla, columna, dato);

            if (dt.Rows.Count > 0)
            {
                

                DataRow row = dt.Rows[0]; // Tomamos la primera fila (si hay resultados)

                // Llenamos los controles con los valores del resultado
                textBox2.Text = row["PK_id_Modulo"].ToString();
                textBox5.Text = row["nbr_nombre_modulo"].ToString();
                textBox3.Text = row["nbr_descripcion_modulo"].ToString();
               

                // Verificamos el estado y marcamos el RadioButton correspondiente
                bool estadoActivo = Convert.ToInt32(row["nbr_estado_modulo"]) == 1;
                radioButton1.Checked = estadoActivo;
                radioButton2.Checked = !estadoActivo;
            }
            else
            {
                // Limpiamos los controles si no se encontraron resultados
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                textBox5.Text = string.Empty;
                textBox3.Text = string.Empty;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //carlos enrique
            Buscar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //BOTON GUARDAR
            //Justin Pennant
            string tabla = "tbl_modulo";
            Dictionary<string, object> valores = new Dictionary<string, object>();
            Controlador controlador = new Controlador();

            valores.Add("PK_id_Modulo", int.Parse(textBox2.Text));
            valores.Add("nbr_nombre_modulo", textBox5.Text);
            valores.Add("nbr_descripcion_modulo", textBox3.Text);

            if (radioButton1.Checked == true)
            {
                valores.Add("nbr_estado_modulo", 1);
            }
            else if (radioButton2.Checked == true)
            {
                valores.Add("nbr_estado_modulo", 0);
            }


            bool exito = controlador.GuardarDatos(tabla, valores);


            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox3.Text = string.Empty;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            textBox1.Focus();


            if (exito)
            {

                MessageBox.Show("Los datos se han guardado correctamente.");
            }
            else
            {
                MessageBox.Show("Error al guardar los datos.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //BOTON NUEVO
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //BOTON ACTUALIZAR
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //BOTON MODIFICAR
            //Justin Pennant
            string tabla = "tbl_modulo";
            Dictionary<string, object> valores = new Dictionary<string, object>();
            Controlador controlador = new Controlador();


            valores.Add("PK_id_Modulo", int.Parse(textBox2.Text));
            valores.Add("nbr_nombre_modulo", textBox5.Text);
            valores.Add("nbr_descripcion_modulo", textBox3.Text);
            string condicion = $"PK_id_Modulo = '{int.Parse(textBox2.Text)}'";

            if (radioButton1.Checked == true)
            {
                valores.Add("nbr_estado_modulo", 1);
            }
            else if (radioButton2.Checked == true)
            {
                valores.Add("nbr_estado_modulo", 0);
            }


            bool exito = controlador.Modificar(tabla, valores, condicion);


            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox3.Text = string.Empty;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            textBox1.Focus();


            if (exito)
            {

                MessageBox.Show("Los datos se han modificado correctamente.");
            }
            else
            {
                MessageBox.Show("Error al modificar los datos.");
            }
        }



        private void button6_Click(object sender, EventArgs e)
        {
            //BOTON ELIMINAR
            //Justin Pennant
            string valor = textBox1.Text;

            // Llama a la función de eliminación pasando los parámetros necesarios
            string tabla = "tbl_modulo"; // Nombre de la tabla
            string columna = "PK_id_Modulo"; // Nombre de la columna
            EliminarDato(tabla, columna, valor);

            //Limpieza de datos 
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox3.Text = string.Empty;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            textBox1.Focus();
            MessageBox.Show("Datos Borrados Correctamente");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //BOTON SALIR
            this.Hide();
        }
    }
}
