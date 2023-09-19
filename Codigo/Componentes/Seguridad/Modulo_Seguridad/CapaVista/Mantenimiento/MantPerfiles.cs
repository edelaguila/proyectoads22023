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
            string tabla = "tbl_perfil_encabezado";
            string columna = "PK_id_perfil";
            DataTable dt = cn.Buscar(tabla, columna, dato);

            if (dt.Rows.Count > 0)
            {


                DataRow row = dt.Rows[0]; // Tomamos la primera fila (si hay resultados)

                // Llenamos los controles con los valores del resultado
                txt_codigo.Text = row["PK_id_perfil"].ToString();
                txt_nombre.Text = row["nombre_perfil"].ToString();
                txt_descripcion.Text = row["descripcion_perfil"].ToString();


                // Verificamos el estado y marcamos el RadioButton correspondiente
                bool estadoActivo = Convert.ToInt32(row["estado_perfil"]) == 1;
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

        private void button3_Click(object sender, EventArgs e)
        {

            //BOTON GUARDAR
            //Carlos enrique
            string tabla = "tbl_perfil_encabezado";
            Dictionary<string, object> valores = new Dictionary<string, object>();
            Controlador controlador = new Controlador();

            valores.Add("PK_id_perfil", int.Parse(txt_codigo.Text));
            valores.Add("nombre_perfil", txt_nombre.Text);
            valores.Add("descripcion_perfil", txt_descripcion.Text);

            if (rb_habilitado.Checked == true)
            {
                valores.Add("estado_perfil", 1);
            }
            else if (rb_inhabilitado.Checked == true)
            {
                valores.Add("estado_perfil", 0);
            }


            bool exito = controlador.GuardarDatos(tabla, valores);


            txt_busqueda.Text = string.Empty;
            txt_codigo.Text = string.Empty;
            txt_nombre.Text = string.Empty;
            txt_descripcion.Text = string.Empty;
            rb_habilitado.Checked = false;
            rb_inhabilitado.Checked = false;
            txt_busqueda.Focus();


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
            //carlos enrique 
            string tabla = "tbl_perfil_encabezado";
            Dictionary<string, object> valores = new Dictionary<string, object>();
            Controlador controlador = new Controlador();


            valores.Add("PK_id_perfil", int.Parse(txt_codigo.Text));
            valores.Add("nombre_perfil", txt_nombre.Text);
            valores.Add("descripcion_perfil", txt_descripcion.Text);
            string condicion = $"PK_id_perfil = '{int.Parse(txt_codigo.Text)}'";

            if (rb_habilitado.Checked == true)
            {
                valores.Add("estado_perfil", 1);
            }
            else if (rb_inhabilitado.Checked == true)
            {
                valores.Add("estado_perfil", 0);
            }


            bool exito = controlador.Modificar(tabla, valores, condicion);


            txt_busqueda.Text = string.Empty;
            txt_codigo.Text = string.Empty;
            txt_nombre.Text = string.Empty;
            txt_descripcion.Text = string.Empty;
            rb_habilitado.Checked = false;
            rb_inhabilitado.Checked = false;
            txt_busqueda.Focus();


            if (exito)
            {

                MessageBox.Show("Los datos se han modificado correctamente.");
            }
            else
            {
                MessageBox.Show("Error al modificar los datos.");
            }

        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            //carlos enrique
            string valor = txt_busqueda.Text;

            // Llama a la función de eliminación pasando los parámetros necesarios
            string tabla = "tbl_perfil_encabezado"; // Nombre de la tabla
            string columna = "PK_id_perfil"; // Nombre de la columna
            EliminarDato(tabla, columna, valor);

            txt_busqueda.Text = string.Empty;
            txt_codigo.Text = string.Empty;
            txt_nombre.Text = string.Empty;
            txt_descripcion.Text = string.Empty;
            rb_habilitado.Checked = false;
            rb_inhabilitado.Checked = false;
            txt_busqueda.Focus();
            MessageBox.Show("Datos Borrados Correctamente");
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
