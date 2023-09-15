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
            LlenarCombo();

        }

        //Erick Ramirez
        public void limpiar()
        {
            textBox2.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox4.Text = string.Empty;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            textBox1.Focus();
        }

        Controlador cn = new Controlador();

        //carlos enrique
        public void Buscar()
        {
            //Erick Ramirez

            

            string dato = textBox1.Text;
            string tabla = "tbl_aplicacion";
            string columna = "PK_id_aplicacion";
            DataTable dt = cn.Buscar(tabla, columna, dato);




            if (dt.Rows.Count > 0)
            {


                DataRow row = dt.Rows[0]; // Tomamos la primera fila (si hay resultados)

                // Llenamos los controles con los valores del resultado
                //Erick Ramirez
                textBox2.Text = row["PK_id_aplicacion"].ToString();

                textBox4.Text = row["nbr_nombre_aplicacion"].ToString();
                textBox5.Text = row["nbr_descripcion_aplicacion"].ToString();

                // Verificamos el estado y marcamos el RadioButton correspondiente
                bool estadoActivo = Convert.ToInt32(row["nbr_estado_aplicacion"]) == 1;
                radioButton1.Checked = estadoActivo;
                radioButton2.Checked = !estadoActivo;
            }
            else
            {
                // Limpiamos los controles si no se encontraron resultados
                limpiar();
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
            string tabla = "tbl_aplicacion"; // Nombre de la tabla
            string columna = "PK_Id_aplicacion"; // Nombre de la columna
            EliminarDato(tabla, columna, valor);

            limpiar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Erick Ramirez
            string tabla = "tbl_aplicacion";
            Dictionary<string, object> valores = new Dictionary<string, object>();

            Controlador controlador = new Controlador();

            valores.Add("PK_Id_aplicacion", int.Parse(textBox2.Text));
            valores.Add("nbr_nombre_aplicacion", textBox4.Text);
            valores.Add("nbr_descripcion_aplicacion", textBox5.Text);

            if (radioButton1.Checked == true)
            {
                valores.Add("nbr_estado_aplicacion", 1);
            }
            else if (radioButton2.Checked == true)
            {
                valores.Add("nbr_estado_aplicacion", 0);
            }

            bool exito = controlador.GuardarDatos(tabla, valores);

            limpiar();


            if (exito)
            {

                MessageBox.Show("Los datos se han guardado correctamente.");
            }
            else
            {
                MessageBox.Show("Error al guardar los datos.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //BOTON MODIFICAR
            //Erick Ramirez
            string tabla = "tbl_aplicacion";
            Dictionary<string, object> valores = new Dictionary<string, object>();
            Controlador controlador = new Controlador();

            //Erick Ramirez
            valores.Add("PK_Id_aplicacion", int.Parse(textBox2.Text));
            valores.Add("nbr_nombre_aplicacion", textBox4.Text);
            valores.Add("nbr_descripcion_aplicacion", textBox5.Text);
            string condicion = $"PK_Id_aplicacion = '{int.Parse(textBox2.Text)}'";

            if (radioButton1.Checked == true)
            {
                valores.Add("nbr_estado_aplicacion", 1);
            }
            else if (radioButton2.Checked == true)
            {
                valores.Add("nbr_estado_aplicacion", 0);
            }


            bool exito = controlador.Modificar(tabla, valores, condicion);


            limpiar();


            if (exito)
            {

                MessageBox.Show("Los datos se han modificado correctamente.");
            }
            else
            {
                MessageBox.Show("Error al modificar los datos.");
            }
        }


        public void LlenarCombo()
        {
            
            List<string> datos = cn.ObtenerDatos();
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(datos.ToArray());


        }




    }
}
