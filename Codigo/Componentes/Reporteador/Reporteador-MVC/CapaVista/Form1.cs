using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Reporteador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario "Vista de Reportes"
            CapaVista.vista_rp_navegador vistareportenavegador = new CapaVista.vista_rp_navegador();

            // Mostrar el formulario "Vista de Reportes navegador"
            vistareportenavegador.Show();
        }

        private void dgv_categorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
