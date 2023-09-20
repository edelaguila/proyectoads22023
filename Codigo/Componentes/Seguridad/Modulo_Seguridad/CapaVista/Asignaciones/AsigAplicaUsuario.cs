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
    public partial class AsigAplicaUsuario : Form
    {
        public AsigAplicaUsuario()
        {
            InitializeComponent();
            LlenarCombo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tabla = "tbl_USUARIOS_APLICACIONES";

            string nombreUsuario = comboBox1.SelectedItem.ToString();
            string aplicacion = comboBox2.SelectedItem.ToString();

            Dictionary<string, object> valores = new Dictionary<string, object>
            {
                { "Nombre", nombreUsuario },
                { "Aplicacion", aplicacion }
            };

            Controlador controlador = new Controlador();
            bool exito = controlador.GuardarDatos(tabla, valores);

            if (exito)
            {

                dataGridView1.Rows.Add(nombreUsuario, aplicacion);
                MessageBox.Show("Los datos se han guardado correctamente.");
            }
            else
            {
                MessageBox.Show("Error al guardar los datos.");
            }
        }

        public void LlenarCombo()
        {

            List<string> datos = cn.ObtenerDatos();
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(datos.ToArray());
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(datos.ToArray());
            comboBox3.Items.Clear();
            comboBox3.Items.AddRange(datos.ToArray());


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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*mas tarde para insercion
            int a = dataGridView1.RowCount;

            for (int i = 1; i <= a; i++)
            {

            }
            */

            /* string tabla = "tbl_usuario_aplicacion";

             Dictionary<string, object> valores = new Dictionary<string, object>
             {
                 { "Nombre", nombreUsuario },
                 { "Aplicacion", aplicacion }

             };

             Controlador controlador = new Controlador();
             bool exito = controlador.GuardarDatos(tabla, valores);

             if (exito)
             {

                 dataGridView1.Rows.Add(nombreUsuario, aplicacion);
                 MessageBox.Show("Los datos se han guardado correctamente.");
             }
             else
             {
                 MessageBox.Show("Error al guardar los datos.");
             }
             */

            //int hola = dataGridView1.GetCellCount
            /*int[] valoresCasillas = new int[2];
            for (int i = 2; i < 2; i++)
            {
                DataGridViewCheckBoxCell casilla = dataGridView1.Rows[0].Cells[i] as DataGridViewCheckBoxCell;
                valoresCasillas[i] = (Convert.ToBoolean(casilla.Value)) ? 1 : 0;
                MessageBox.Show("" + valoresCasillas[i]);
            }*/
        }
    }
}
