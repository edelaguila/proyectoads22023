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
    public partial class AsigPerfUsuario : Form
    {
        public AsigPerfUsuario()
        {
            InitializeComponent();
            LlenarCombo();
        }
        Controlador cn = new Controlador();

        public void LlenarCombo()
        {
            List<string> datos = cn.ObtenerDatos("nbr_username_usuario", "tbl_usuario");
            List<string> datos2 = cn.ObtenerDatos("nbr_nombre_perfil", "tbl_perfil_encabezado");
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(datos.ToArray());
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(datos.ToArray());
            comboBox3.Items.Clear();
            comboBox3.Items.AddRange(datos2.ToArray());

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Erick Ramirez
            cn.datosBitacora("btn_agregar_AsigPerfUsuario", "tbl_usuario_perfil");
            int n = dataGridView2.Rows.Add();
            dataGridView2.Rows[n].Cells[0].Value = comboBox2.SelectedItem;
            dataGridView2.Rows[n].Cells[1].Value = comboBox3.SelectedItem;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Erick Ramirez
            cn.datosBitacora("btn_ayuda_AsigPerfUsuario", "tbl_usuario_perfil");
            Help.ShowHelp(this, "ComponenteSeguridadAyuda/AyudaSeguridad.chm", "Procesos.html");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Erick Ramirez
            cn.datosBitacora("btn_finalizar_AsigPerfUsuario", "tbl_usuario_perfil");
            string FK_Usuario = "";
            string FK_Perfil = "";
            bool exito = true;
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                //BUSQUEDA USUARIO
                string dato = Convert.ToString(dataGridView2.Rows[i].Cells["dgv_columna_Usuario2"].Value);
                string tabla = "tbl_usuario";
                string columna = "nbr_username_usuario";


                DataTable dt = cn.Buscar(tabla, columna, dato);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0]; // Tomamos la primera fila (si hay resultados)
                                              // Llenamos los controles con los valores del resultado
                    FK_Usuario = row["PK_id_usuario"].ToString();
                }
                ///////////////
                ///

                //BUSQUEDA PERFIL

                string dato2 = Convert.ToString(dataGridView2.Rows[i].Cells["dgv_columna_Perfil"].Value);
                string tabla2 = "tbl_perfil_encabezado";
                string columna2 = "nbr_nombre_perfil";
                DataTable dt2 = cn.Buscar(tabla2, columna2, dato2);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt2.Rows[0]; // Tomamos la primera fila (si hay resultados)
                                               // Llenamos los controles con los valores del resultado
                    FK_Perfil = row["PK_id_perfil"].ToString();
                }

                ////////////////////////
                ///

                // INGRESO DE DATOS A TABLA TBL_USUARIO_APLICACION
                string tabla1 = "tbl_usuario_perfil";
                Dictionary<string, object> valores = new Dictionary<string, object>();
                Controlador controlador = new Controlador();

                valores.Add("FK_id_usuario", FK_Usuario);
                valores.Add("FK_id_perfil", FK_Perfil);

                exito = controlador.GuardarDatos(tabla1, valores);


            }
            if (exito == true)
            {
                MessageBox.Show("Los datos se han guardado correctamente");
            }
            else
            {
                MessageBox.Show("Error al guardar los datos");
            }

            dataGridView2.Rows.Clear();
            comboBox2.Text = "";
            comboBox3.Text = "";
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Erick Ramirez
            cn.datosBitacora("combo_AsigPerfUsuario", "tbl_usuario_perfil");
            string id = "";
            string valor = comboBox1.SelectedItem.ToString();


            // BUSQUEDA USUARIO
            string dato = valor;
            string tabla = "tbl_usuario";
            string columna = "nbr_username_usuario";


            DataTable dt = cn.Buscar(tabla, columna, dato);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0]; // Tomamos la primera fila (si hay resultados)
                                          // Llenamos los controles con los valores del resultado
                id = row["PK_id_usuario"].ToString();
            }

            dataGridView1.DataSource = cn.Llenardatagrid(id);
            dataGridView1.Columns["ID_Perfil_Usuario"].HeaderText = "Codigo";
            dataGridView1.Columns["Nombre_Perfil"].HeaderText = "Perfil";
            
        }
    }
}
