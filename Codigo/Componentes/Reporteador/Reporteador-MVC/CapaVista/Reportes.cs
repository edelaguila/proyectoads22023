using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CapaControlador;


namespace Reporteador
{
    public partial class Reportes : Form
    {
        private List<string> rutas = new List<string>(); // Lista para almacenar las rutas
        Controlador cn = new Controlador();
        string rep = "reportes";
        public Reportes()
        {
            InitializeComponent();
            actualizardatagriew();
        }
        public void actualizardatagriew()
        {
            DataTable dt = cn.llenarTbl(rep);
            dgv_reportes.DataSource = dt;

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_ruta_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_ruta_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\"; // Directorio inicial
                openFileDialog.Filter = "Archivos de texto (*.pdf)|*.pdf|Todos los archivos (*.*)|*.*";
                openFileDialog.FilterIndex = 1;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Obtener la ruta del archivo seleccionado y mostrarla en el TextBox
                    txt_ruta.Text = openFileDialog.FileName;
                }
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
                string ruta = txt_ruta.Text.Trim();

                if (!string.IsNullOrEmpty(ruta) && File.Exists(ruta))
                {
                    // Agregar la ruta a la lista
                    rutas.Add(ruta);

                    // Limpiar el TextBox
                    txt_ruta.Clear();

                    // Mostrar un mensaje de confirmación
                    MessageBox.Show("Reporte agregado Correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                else
                {
                    MessageBox.Show("La ruta no es válida o no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        private void btn_ver_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario "Vista de Reportes"
            Vista_de_Reportes vistaDeReportesForm = new Vista_de_Reportes();

            // Mostrar el formulario "Vista de Reportes"
            vistaDeReportesForm.Show();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {

        }

        private void dgv_reportes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

   