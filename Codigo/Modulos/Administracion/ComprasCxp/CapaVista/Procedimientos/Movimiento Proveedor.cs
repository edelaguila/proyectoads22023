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
    public partial class Movimiento_Proveedor : Form
    {

        Controlador cn = new Controlador();

        public Movimiento_Proveedor()
        {
            InitializeComponent();
            LlenarComboCliente();
            LlenarComboConcepto();
            actualizardatagrid();
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
            string tabla = "tbl_encabezadoMovimientoProveedor";
            Dictionary<string, object> valores = new Dictionary<string, object>();
            Controlador controlador = new Controlador();

            valores.Add("CodigoProveedor", int.Parse(cb_busquedaProveedor.SelectedItem.ToString()));
            valores.Add("encabezadoProveedor_FechaEmision", dtp_fechaEmision.Value.Date);
            valores.Add("encabezadoProveedor_FechaVencimiento", dtp_fechaVencimiento.Value.Date);


            controlador.GuardarDatos(tabla, valores);
        }



        public void insertDetalle()
        {
            string tabla = "tbl_detalleMovimientoProveedor";
            Dictionary<string, object> valores = new Dictionary<string, object>();
            Controlador controlador = new Controlador();

            valores.Add("CodigoEncabezadoProveedor", IDE);
            valores.Add("CodigoConceptoProveedor", int.Parse(cb_busquedaConcepto.SelectedItem.ToString()));
            valores.Add("detalleProveedor_valor", int.Parse(txt_conceptoValor.Text));


            controlador.GuardarDatos(tabla, valores);
        }

        int IDE = 0;

        public void BuscarUltimoIDEncabezado()
        {
            string tabla = "tbl_encabezadoMovimientoProveedor";
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

        private void btn_busquedaCliente_Click(object sender, EventArgs e)
        {
            BuscarCliente();
        }

        private void btn_Busqueda_Click(object sender, EventArgs e)
        {
            BuscarConcepto();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            insertEncabezado();
            BuscarUltimoIDEncabezado();
            insertDetalle();
            actualizardatagrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
