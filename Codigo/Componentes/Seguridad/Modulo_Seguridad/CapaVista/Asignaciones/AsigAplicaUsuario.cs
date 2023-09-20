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
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = comboBox1.SelectedItem;
            dataGridView1.Rows[n].Cells[1].Value = comboBox3.SelectedItem; 
        }

        public void LlenarCombo()
        {
            List<string> datos = cn.ObtenerDatos("nbr_username_usuario", "tbl_usuario");
            List<string> datos2 = cn.ObtenerDatos("nbr_nombre_modulo","tbl_modulo");
            List<string> datos3 = cn.ObtenerDatos("nbr_nombre_aplicacion", "tbl_aplicacion");
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(datos.ToArray());
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(datos2.ToArray());
            comboBox3.Items.Clear();
            comboBox3.Items.AddRange(datos3.ToArray());

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
            bool exito = true;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string FK_Usuario = "";
                string FK_Aplicacion = "";

                //BUSQUEDA USUARIO
                string dato = Convert.ToString(dataGridView1.Rows[i].Cells["dgv_columna_Usuarios"].Value);
                string tabla = "tbl_usuario";
                string columna = "nbr_username_usuario";


                DataTable dt = cn.Buscar(tabla, columna, dato);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0]; // Tomamos la primera fila (si hay resultados)
                                              // Llenamos los controles con los valores del resultado
                    FK_Usuario = row["PK_id_usuario"].ToString();
                }

                //BUSQUEDA APLICACION

                string dato2 = Convert.ToString(dataGridView1.Rows[i].Cells["dgv_columna_Aplicacion"].Value);
                string tabla2 = "tbl_aplicacion";
                string columna2 = "nbr_nombre_aplicacion";
                DataTable dt2 = cn.Buscar(tabla2, columna2, dato2);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt2.Rows[0]; // Tomamos la primera fila (si hay resultados)
                                               // Llenamos los controles con los valores del resultado
                    FK_Aplicacion = row["PK_id_aplicacion"].ToString();
                }


                // INGRESO DE DATOS A TABLA TBL_USUARIO_APLICACION
                string tabla1 = "tbl_usuario_aplicacion";
                Dictionary<string, object> valores = new Dictionary<string, object>();
                Controlador controlador = new Controlador();

                valores.Add("FK_id_usuario", FK_Usuario);
                valores.Add("FK_id_aplicacion", FK_Aplicacion);
                valores.Add("nbr_ingresar", Convert.ToInt64(dataGridView1.Rows[i].Cells["dgv_columna_Ingresar"].Value));
                valores.Add("nbr_consulta", Convert.ToInt64(dataGridView1.Rows[i].Cells["dgv_columna_consultar"].Value));
                valores.Add("nbr_modificar", Convert.ToInt64(dataGridView1.Rows[i].Cells["dgv_columna_Modificar"].Value));
                valores.Add("nbr_eliminar", Convert.ToInt64(dataGridView1.Rows[i].Cells["dgv_columna_Eliminar"].Value));
                valores.Add("nbr_imprimir", Convert.ToInt64(dataGridView1.Rows[i].Cells["dgv_columna_Imprimir"].Value));
                exito = controlador.GuardarDatos(tabla1, valores);
            }

            if (exito == true)
            {
                MessageBox.Show("Los datos se han ingresado correctamente");
            }
            else
            {
                MessageBox.Show("Hubo un problema al ingresar los datos");
            }

        }

            
          

            
        
    }
}
