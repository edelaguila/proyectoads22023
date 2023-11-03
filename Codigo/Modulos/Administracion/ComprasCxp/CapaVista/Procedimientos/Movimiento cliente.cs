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
    public partial class Movimiento_cliente : Form
    {
        Controlador cn = new Controlador();

        public Movimiento_cliente()
        {
            InitializeComponent();
            LlenarComboCliente();
            LlenarComboConcepto();
            actualizardatagrid();
        }

        public void actualizardatagrid()
        {
            string tabla = "tbl_encabezadoMovimientoCliente";
            DataTable dt = cn.llenarTbl(tabla);
            dtTabla.DataSource = dt;
        }


        public void BuscarCliente()
        {
            string tabla = "tbl_cliente";

            string columna = "id_cliente";
            string dato = cb_busquedaCliente.SelectedItem.ToString();
            DataTable dt = cn.Buscar(tabla, columna, dato);

            if (dt.Rows.Count > 0)
            {

                MessageBox.Show("Datos Encontrados");
                DataRow row = dt.Rows[0]; // Tomamos la primera fila (si hay resultados)

                // Llenamos los controles con los valores del resultado

                txt_nombre.Text = row["cli_Nombre"].ToString();
                txt_estado.Text = row["cli_Estado"].ToString();
                txt_tipo.Text = row["cli_tipo"].ToString();

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
            string tabla = "tbl_encabezadoMovimientoCliente";
            Dictionary<string, object> valores = new Dictionary<string, object>();
            Controlador controlador = new Controlador();

            valores.Add("codigoCliente", int.Parse(cb_busquedaCliente.SelectedItem.ToString()));
            valores.Add("encabezadoCliente_FechaEmision", dtp_fechaEmision.Value.Date);
            valores.Add("encabezadoCliente_FechaVencimiento", dtp_fechaVencimiento.Value.Date);


            controlador.GuardarDatos(tabla, valores);         
        }



        public void insertDetalle()
        {
            string tabla = "tbl_detalleMovimientoCliente";
            Dictionary<string, object> valores = new Dictionary<string, object>();
            Controlador controlador = new Controlador();

            valores.Add("CodigoEncabezadoCliente", IDE);
            valores.Add("CodigoConceptoCliente", int.Parse(cb_busquedaConcepto.SelectedItem.ToString()));
            valores.Add("Detalle_valor", int.Parse(txt_conceptoValor.Text));


            controlador.GuardarDatos(tabla, valores);
        }

        int IDE = 0;

        public void BuscarUltimoIDEncabezado()
        {
            string tabla = "tbl_encabezadoMovimientoCliente";
            string columna = "id_EncabezadoCliente";
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
            List<string> cliente = cn.llenarCombo("id_cliente", "tbl_cliente");
            cb_busquedaCliente.Items.Clear();
            cb_busquedaCliente.Items.AddRange(cliente.ToArray());

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


        public void eliminacionEncabezado() {

            string valor = txt_eliminacion.Text;


            // Llama a la función de eliminación pasando los parámetros necesarios
            string tabla = "tbl_encabezadoMovimientoCliente"; // Nombre de la tabla
            string columna = "id_EncabezadoCliente"; // Nombre de la columna
            EliminarDato(tabla, columna, valor);

        }

        public void eliminacionDetalle()
        {

            string valor = txt_eliminacion.Text;


            // Llama a la función de eliminación pasando los parámetros necesarios
            string tabla = "tbl_detalleMovimientoCliente"; // Nombre de la tabla
            string columna = "id_DetalleCliente"; // Nombre de la columna
            EliminarDato(tabla, columna, valor);

        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }


        private void cb_busquedaCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Busqueda_Click(object sender, EventArgs e)
        {
            BuscarConcepto();
        }

        private void btn_busquedaCliente_Click(object sender, EventArgs e)
        {
            BuscarCliente();
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
            eliminacionDetalle();
            eliminacionEncabezado();
            actualizardatagrid();
        }
    }
}
