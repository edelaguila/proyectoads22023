using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.IO;
namespace CapaVista
{
    public partial class vista_rp_navegador : Form
    {

   

        public vista_rp_navegador()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void lbl_titulo_Click(object sender, EventArgs e)
        {

        }

        private void Vista_de_Reportes_Load(object sender, EventArgs e)
        {

        }

        private void crystalReport51_InitReport(object sender, EventArgs e)
        {



        }

        private void vista_rp_navegador_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.tbl_reportes' Puede moverla o quitarla según sea necesario.
            this.tbl_reportesTableAdapter.Fill(this.dataSet1.tbl_reportes);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Plantilla3 reporte = new Plantilla3();
            reporte.Show();


        }
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Plantilla4 reporte = new Plantilla4();
            reporte.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            prubacrystal reporte = new prubacrystal();
            reporte.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            prueba2 reporte = new prueba2();
            reporte.Show();
        }
    }
}