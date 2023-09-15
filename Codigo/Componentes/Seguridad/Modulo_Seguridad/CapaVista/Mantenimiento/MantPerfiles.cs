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
    }
}
