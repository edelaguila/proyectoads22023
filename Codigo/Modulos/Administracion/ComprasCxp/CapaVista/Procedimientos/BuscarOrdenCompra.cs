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
    public partial class BuscarOrdenCompra : Form
    {
        private Compras Compras;

        String tabla1 = "tbl_ordenescompra";
        Controlador cn = new Controlador();
        public BuscarOrdenCompra(Compras compra)
        {
            InitializeComponent();
            actualizardatagridview();
            Compras = compra;
        }

        public void actualizardatagridview()
        {
            DataTable dt = cn.llenarTbl2(tabla1);
            dgv_orden.DataSource = dt;
        }

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            if (dgv_orden.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgv_orden.SelectedRows[0];
                string id = filaSeleccionada.Cells["ord_id"].Value.ToString();
                string fechaS = filaSeleccionada.Cells["ord_FechaSolicitud"].Value.ToString();
                string fechaE = filaSeleccionada.Cells["ord_FechaEntrega"].Value.ToString();
                string solicitante = filaSeleccionada.Cells["ord_deptosolicitante"].Value.ToString();
                string proveedor = filaSeleccionada.Cells["fk_proveedor_id"].Value.ToString();
                Compras.RecibirDatosDesdeBuscarOrdenes(id, fechaS, fechaE, solicitante, proveedor);
                this.Close();
            }
        }

        private void BuscarOrdenCompra_Load(object sender, EventArgs e)
        {

        }
    }
}
