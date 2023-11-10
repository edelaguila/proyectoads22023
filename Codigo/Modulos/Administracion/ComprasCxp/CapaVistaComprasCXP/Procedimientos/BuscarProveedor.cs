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
    public partial class BuscarProveedor : Form
    {
        private OrdenesdeCompra OrdendeCompra;

        String tabla1 = "tbl_proveedor";
        ControladorCOMPRASCXP cn = new ControladorCOMPRASCXP();
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

        private void btn_seleccionar_Click(object sender, EventArgs e)
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
            else
            {
                MessageBox.Show("Seleccione una fila.", "Selección de Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_buscarProveedor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Prov.Text))
            {
                MessageBox.Show("Ingrese el nombre del proveedor.", "Búsqueda de Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgv_proveedores != null && dgv_proveedores.Rows.Count > 0)
            {
                string nombreProveedorABuscar = txt_Prov.Text.ToLower();
                bool encontrado = false;

                foreach (DataGridViewRow fila in dgv_proveedores.Rows)
                {
                    if (!fila.IsNewRow)
                    {
                        string nombreProveedorEnFila = fila.Cells["pro_Nombre"].Value.ToString().ToLower();

                        if (nombreProveedorEnFila.Contains(nombreProveedorABuscar))
                        {
                            fila.Selected = true;
                            dgv_proveedores.CurrentCell = fila.Cells[0];
                            encontrado = true;
                            break;
                        }
                    }
                }

                if (!encontrado)
                {
                    MessageBox.Show("Proveedor no encontrado.", "Búsqueda de Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            
             }
        }


  }
}
