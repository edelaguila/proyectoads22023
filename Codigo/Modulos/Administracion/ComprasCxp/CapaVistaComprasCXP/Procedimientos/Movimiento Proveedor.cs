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
    public partial class Movimiento_Proveedor : Form
    {

        ControladorCOMPRASCXP cn = new ControladorCOMPRASCXP();
        public Movimiento_Proveedor()
        {
            InitializeComponent();
            LlenarComboCliente();
            LlenarComboConcepto();
            actualizardatagrid();
            dtTabla.CellClick += dataGridView1_CellClick;
            ActualizarSaldoTotal();
        }

        public void actualizardatagrid()
        {
            string tabla1 = "tbl_encabezadoMovimientoProveedor";
            DataTable dtp = cn.llenarTblP(tabla1);
            dtTabla.DataSource = dtp;
        }


        public void BuscarCliente()
        {
            string tabla = "tbl_proveedor";

            string columna = "id_proveedor";
            string dato = cb_busquedaProveedor.SelectedItem.ToString();
            DataTable dt = cn.Buscar(tabla, columna, dato);

            if (dt.Rows.Count > 0)
            {

                MessageBox.Show("Datos Encontrados");
                DataRow row = dt.Rows[0]; // Tomamos la primera fila (si hay resultados)

                // Llenamos los controles con los valores del resultado

                txt_nombre.Text = row["pro_Nombre"].ToString();
                txt_estado.Text = row["pro_Estado"].ToString();
                txt_tipo.Text = row["pro_Tipo"].ToString();
                txt_empresa.Text = row["pro_Empresa"].ToString();

            }
            else
            {
                MessageBox.Show("No se encontro el dato");
            }
        }


        public void BuscarConcepto()
        {
            string tabla = "tbl_concepto";

            string columna = "id_concepto";
            string dato = cb_busquedaConcepto.SelectedItem.ToString();
            DataTable dt = cn.Buscar(tabla, columna, dato);

            if (dt.Rows.Count > 0)
            {

                MessageBox.Show("Datos Encontrados");
                DataRow row = dt.Rows[0]; // Tomamos la primera fila (si hay resultados)

                // Llenamos los controles con los valores del resultado

                txt_concepto.Text = row["con_Descripcion"].ToString();
                txt_tipoConcepto.Text = row["con_Tipo"].ToString();
                txt_serieConcepto.Text = row["con_SerieConcepto"].ToString();

            }
            else
            {
                MessageBox.Show("No se encontro el dato");
            }
        }

        public void insertEncabezado()
        {
            string tabla = "tbl_encabezadomovimientoproveedor";
            Dictionary<string, object> valores = new Dictionary<string, object>();
            ControladorCOMPRASCXP controlador = new ControladorCOMPRASCXP();

            valores.Add("CodigoProveedor", int.Parse(cb_busquedaProveedor.SelectedItem.ToString()));
            valores.Add("encabezadoProveedor_FechaEmision", dtp_fechaEmision.Value.Date);
            valores.Add("encabezadoProveedor_FechaVencimiento", dtp_fechaVencimiento.Value.Date);
            valores.Add("encabezadoProveedor_Factura", int.Parse(txt_Factura.Text));

            controlador.GuardarDatos(tabla, valores);
        }



        public void insertDetalle()
        {
            string tabla = "tbl_detallemovimientoproveedor";
            Dictionary<string, object> valores = new Dictionary<string, object>();
            ControladorCOMPRASCXP controlador = new ControladorCOMPRASCXP();

            valores.Add("CodigoEncabezadoProveedor", IDE);
            valores.Add("CodigoConceptoProveedor", int.Parse(cb_busquedaConcepto.SelectedItem.ToString()));
            valores.Add("detalleProveedor_valor", int.Parse(txt_conceptoValor.Text));


            controlador.GuardarDatos(tabla, valores);
        }

        int IDE = 0;

        public void BuscarUltimoIDEncabezado()
        {
            string tabla = "tbl_encabezadomovimientoproveedor";
            string columna = "id_EncabezadoProveedor";
            DataTable dt = cn.BuscarE(tabla, columna);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];

                // Obtén el valor del ID máximo
                if (row["MaxID"] != DBNull.Value)
                {
                    IDE = Convert.ToInt32(row["MaxID"]);
                }
            }
        }


        public void LlenarComboCliente()
        {
            List<string> cliente = cn.llenarCombo("id_proveedor", "tbl_proveedor");
            cb_busquedaProveedor.Items.Clear();
            cb_busquedaProveedor.Items.AddRange(cliente.ToArray());

        }

        public void LlenarComboConcepto()
        {
            List<string> concepto = cn.llenarCombo("id_concepto", "tbl_concepto");
            cb_busquedaConcepto.Items.Clear();
            cb_busquedaConcepto.Items.AddRange(concepto.ToArray());

        }

        public void EliminarDato(string tabla, string columna, string valor)
        {
            bool eliminado = cn.Eliminar(tabla, columna, valor);
            if (eliminado)
            {
                MessageBox.Show("Registro eliminado correctamente.");
            }
            else
            {
                MessageBox.Show($"No se pudo eliminar el registro. Verifique el {columna}.");
            }
        }


        public void eliminacionEncabezado()
        {

            string valor = txt_eliminacion.Text;


            // Llama a la función de eliminación pasando los parámetros necesarios
            string tabla = "tbl_encabezadomovimientoproveedor"; // Nombre de la tabla
            string columna = "id_EncabezadoProveedor"; // Nombre de la columna
            EliminarDato(tabla, columna, valor);

        }

        public void eliminacionDetalle()
        {

            string valor = txt_eliminacion.Text;


            // Llama a la función de eliminación pasando los parámetros necesarios
            string tabla = "tbl_detallemovimientoproveedor"; // Nombre de la tabla
            string columna = "id_DetalleProveedor"; // Nombre de la columna
            EliminarDato(tabla, columna, valor);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verifica que se haya hecho clic en una fila válida
            {
                DataGridViewRow selectedRow = dtTabla.Rows[e.RowIndex];

                if (selectedRow.Cells["id_EncabezadoProveedor"].Value != null)
                {
                    txt_eliminacion.Text = selectedRow.Cells["id_EncabezadoProveedor"].Value.ToString();
                }

            }
        }

        public void ActualizarSaldoTotal()
        {
            int suma = cn.ObtenerSumaDetalleValor();
            lbl_saldoTotal.Text = suma.ToString();
        }


        public void limpieza()
        {
            txt_concepto.Text = "";
            txt_conceptoValor.Text = "";
            txt_eliminacion.Text = "";
            txt_empresa.Text = "";
            txt_estado.Text = "";
            txt_Factura.Text = "";
            txt_nombre.Text = "";
            txt_serieConcepto.Text = "";
            txt_tipo.Text = "";
            txt_tipoConcepto.Text = "";
            cb_busquedaConcepto.SelectedIndex = -1;
            cb_busquedaProveedor.SelectedIndex = -1;
            dtp_fechaEmision.Value = DateTime.Now;
            dtp_fechaVencimiento.Value = DateTime.Now; 

        }


        private void btn_busquedaProveedor_Click(object sender, EventArgs e)
        {
            BuscarCliente();
        }

        private void btn_BusquedaConcepto_Click(object sender, EventArgs e)
        {
            BuscarConcepto();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            insertEncabezado();
            BuscarUltimoIDEncabezado();
            insertDetalle();
            actualizardatagrid();
            ActualizarSaldoTotal();
            limpieza();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            eliminacionDetalle();
            eliminacionEncabezado();
            actualizardatagrid();
            ActualizarSaldoTotal();
            limpieza();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dtp_fechaVencimiento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void lbl_saldoTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
