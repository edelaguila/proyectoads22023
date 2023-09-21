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

namespace CapaVista.Formularios
{
    public partial class frmVisualizarInventario : Form

    {

        ControladorInventario continv = new ControladorInventario();



        public frmVisualizarInventario()
        {
            InitializeComponent();
            mostrarInventario();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        String inv = "tbl_INVENTARIO";
        public void mostrarInventario()
        {
            DataTable dt = continv.llenarTbl(inv);
            dt_inv.DataSource = dt;

        }



    }
}
