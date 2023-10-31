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

namespace CapaVista.Procedimientos
{
    public partial class BuscarProveedor : Form
    {
        private OrdenesdeCompra OrdendeCompra;

        String tabla1 = "tbl_proveedor";
        Controlador cn = new Controlador();
        public BuscarProveedor(OrdenesdeCompra ordenesdeCompra)
        {
            InitializeComponent();
            actualizardatagridview();
            OrdendeCompra = ordenesdeCompra;
        }

        public void actualizardatagridview()
        {
            DataTable dt = cn.llenarTbl2(tabla1);
            dgv_proveedores.DataSource = dt;
        }

        private void btn_seleccionar_Click_1(object sender, EventArgs e)
        {
            if (dgv_proveedores.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgv_proveedores.SelectedRows[0];
                string id = filaSeleccionada.Cells["id_proveedor"].Value.ToString();
                string nombre = filaSeleccionada.Cells["pro_Nombre"].Value.ToString();
                string domicilio = filaSeleccionada.Cells["pro_Domicilio"].Value.ToString();
                string telefono = filaSeleccionada.Cells["pro_Telefono"].Value.ToString();

                OrdendeCompra.RecibirDatosDesdeBuscarProveedor(id, nombre, domicilio, telefono);
                this.Close();
            }
        }
    }
}
