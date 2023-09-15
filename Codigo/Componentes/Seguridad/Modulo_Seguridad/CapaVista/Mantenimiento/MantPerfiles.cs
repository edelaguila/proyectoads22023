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
    public partial class MantPerfiles : Form
    {
        public MantPerfiles()
        {
            InitializeComponent();
        }
        Controlador cn = new Controlador();

        //carlos enrique
        public void Buscar()
        {
            string dato = txt_busqueda.Text;
            string tabla = "perfiles";
            string columna = "id_perfil";
            DataTable dt = cn.Buscar(tabla, columna, dato);

            if (dt.Rows.Count > 0)
            {
             

                DataRow row = dt.Rows[0]; // Tomamos la primera fila (si hay resultados)

                // Llenamos los controles con los valores del resultado
                txt_codigo.Text = row["id_perfil"].ToString();
                txt_nombre.Text = row["nombre"].ToString();
                txt_descripcion.Text = row["descripcion"].ToString();


                // Verificamos el estado y marcamos el RadioButton correspondiente
                bool estadoActivo = Convert.ToInt32(row["estado"]) == 1;
                rb_habilitado.Checked = estadoActivo;
                rb_inhabilitado.Checked = !estadoActivo;
            }
            else
            {
                // Limpiamos los controles si no se encontraron resultados
                txt_busqueda.Text = string.Empty;
                txt_codigo.Text = string.Empty;
                txt_nombre.Text = string.Empty;
                txt_descripcion.Text = string.Empty;
                rb_habilitado.Checked = false;
                rb_inhabilitado.Checked = false;
            }
        }

        //carlos enrique

        public void modificar() {

            public void Modificar()
            {
                string tabla = "NombreDeTuTabla";
                Dictionary<string, object> nuevosValores = new Dictionary<string, object>();

                // Obtener los nuevos valores de los TextBox
                nuevosValores["Campo1"] = txt_codigo.Text;
                nuevosValores["Campo2"] = txt_descripcion.Text;
                nuevosValores["Campo3"] = txt_nombre.Text;
                // Agrega más campos según tu modelo

                // Obtener el valor seleccionado de los radio botones
                if (rb_habilitado.Checked)
                {
                    nuevosValores["campo_estado"] = "1";
                }
                else if (rb_inhabilitado.Checked)
                {
                    nuevosValores["campo_estado"] = "0";
                }
                

                string condicion = "campo_ID = " + txt_busqueda.Text; // Campo ID para identificar el registro a modificar

                Controlador controlador = new Controlador();
                bool exito = controlador.Modificar(tabla, nuevosValores, condicion);

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


        private void button1_Click(object sender, EventArgs e)
        {
            //carlos enrique
            Buscar();
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void btn_modificar_Click(object sender, EventArgs e)
        {

        }
    }
}
