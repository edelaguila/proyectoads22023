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
    public partial class AsigAplicaPerfiles : Form
    {
        public AsigAplicaPerfiles()
        {
            InitializeComponent();
            //Erick Ramirez
            LlenarCombo();
        }

        Controlador cn = new Controlador();
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Erick Ramireez
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = comboBox1.SelectedItem;
            dataGridView1.Rows[n].Cells[1].Value = comboBox3.SelectedItem;
        }



        private void button4_Click(object sender, EventArgs e)
        {

        }

        //Erick Ramirez
        public void LlenarCombo()
        {
            //Erick Ramirez
            List<string> datos = cn.ObtenerDatos("nbr_nombre_perfil", "tbl_perfil_encabezado");
            List<string> datos2 = cn.ObtenerDatos("nbr_nombre_modulo", "tbl_modulo");
            List<string> datos3 = cn.ObtenerDatos("nbr_nombre_aplicacion", "tbl_aplicacion");
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(datos.ToArray());
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(datos2.ToArray());
            comboBox3.Items.Clear();
            comboBox3.Items.AddRange(datos3.ToArray());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Erick Ramirez
            bool exito = true;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string FK_Perfiles = "";
                string FK_Aplicacion = "";

                //BUSQUEDA USUARIO
                string dato = Convert.ToString(dataGridView1.Rows[i].Cells["dgv_columna_Perfiles"].Value);
                string tabla = "tbl_perfil_encabezado";
                string columna = "nbr_nombre_perfil";


                DataTable dt = cn.Buscar(tabla, columna, dato);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0]; // Tomamos la primera fila (si hay resultados)
                                              // Llenamos los controles con los valores del resultado
                    FK_Perfiles = row["PK_id_perfil"].ToString();
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


                // INGRESO DE DATOS A TABLA TBL_PERFIL_DETALLE
                string tabla1 = "tbl_perfil_detalle";
                Dictionary<string, object> valores = new Dictionary<string, object>();
                Controlador controlador = new Controlador();

                valores.Add("FK_id_perfil", FK_Perfiles);
                valores.Add("FK_id_aplicacion", FK_Aplicacion);
                valores.Add("nbr_ingresar", Convert.ToInt64(dataGridView1.Rows[i].Cells["dgv_columna_Ingresar"].Value));
                valores.Add("nbr_consultar", Convert.ToInt64(dataGridView1.Rows[i].Cells["dgv_columna_Consultar"].Value));
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

        private void button3_Click(object sender, EventArgs e)
        {
            //Erick Ramirez
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "ComponenteSeguridadAyuda/AyudaSeguridad.chm", "Procesos.html");
        }
    }
}
