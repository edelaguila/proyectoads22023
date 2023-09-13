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
            string columna = "id_usuarios";
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
        private void button1_Click(object sender, EventArgs e)
        {
            Buscar();
        }
    }
}
