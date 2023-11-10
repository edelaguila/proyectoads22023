using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControladorComprasCXP;

namespace CapaVistaComprasCXP.Procedimientos
{
    public partial class BuscarOrdenCompra : Form
    {
        private Compras Compras;

        String tabla1 = "tbl_ordenescompra";
        ControladorCOMPRASCXP cn = new ControladorCOMPRASCXP();
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
            else
            {
                MessageBox.Show("Seleccione una fila.", "Selección de Orden", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_buscarOrden_Click(object sender, EventArgs e)
        {
            if (dgv_orden != null && dgv_orden.Rows.Count > 0)
            {
                if (int.TryParse(txt_Orden.Text, out int idOrdenBuscar))
                {
                    bool encontrado = false;

                    foreach (DataGridViewRow fila in dgv_orden.Rows)
                    {
                        if (!fila.IsNewRow)
                        {
                            int idOrdenEnFila = int.Parse(fila.Cells["ord_id"].Value.ToString());

                            if (idOrdenEnFila == idOrdenBuscar)
                            {
                                fila.Selected = true;
                                dgv_orden.CurrentCell = fila.Cells[0];
                                encontrado = true;
                                break;
                            }
                        }
                    }

                    if (!encontrado)
                    {
                        MessageBox.Show("Orden de compra no encontrada.", "Búsqueda de Orden de Compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un número de orden válido.", "Búsqueda de Orden de Compra", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
