using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Seguridad_Controlador;
using CapaControladorBancos;
using System.Data;

namespace CapaVistaBancos
{
    //Codigo escrito por Andrea Corado
    public partial class Mantenimiento_agregar_cuenta : Form
    {
        Controlador cn = new Controlador();
        ControladorBanco con = new ControladorBanco();
        public Mantenimiento_agregar_cuenta()
        {
            InitializeComponent();

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_salir_dispo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Mantenimiento_agregar_cuenta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet6.tbl_mantenimientos_agregar_cuenta' Puede moverla o quitarla según sea necesario.
            this.tbl_mantenimientos_agregar_cuentaTableAdapter.Fill(this.dataSet6.tbl_mantenimientos_agregar_cuenta);
            // TODO: esta línea de código carga datos en la tabla 'dataSet5.tbl_mantenimientos_agregar_bancos' Puede moverla o quitarla según sea necesario.
            this.tbl_mantenimientos_agregar_bancosTableAdapter.Fill(this.dataSet5.tbl_mantenimientos_agregar_bancos);
            // TODO: esta línea de código carga datos en la tabla 'dataSet4.tbl_monedabanco' Puede moverla o quitarla según sea necesario.
            this.tbl_monedabancoTableAdapter.Fill(this.dataSet4.tbl_monedabanco);
            // Obtener tipos de moneda y cargar en el ComboBox
            DataTable tiposMoneda = con.ObtenerTiposMoneda();
            if (tiposMoneda != null)
            {
                foreach (DataRow row in tiposMoneda.Rows)
                {
                    cb_tipoMoneda.Items.Add(row["mon_nomMoneda"].ToString());
                }
            }

            DataTable Bancos = con.ObtenerBancos();
            if (Bancos != null)
            {
                foreach (DataRow row in Bancos.Rows)
                {
                    cb_Banco.Items.Add(row["manag_nombre_banco"].ToString());
                }
            }

            DataTable tcuenta = con.ObtenerTipoCuenta();
            if (tcuenta != null)
            {
                foreach (DataRow row in tcuenta.Rows)
                {
                    cb_tipocuenta.Items.Add(row["movtm_transacciones_existentes"].ToString());
                }
            }
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "5007";  //código aplicación asignado al formulario
            navegador1.actual = this;
            navegador1.tabla = dgv_agCuentas;
            TextBox[] Grupotextbox = { txt_id_agCuenta, txt_numcuenta, txt_tipo_mon, txt_tipocuenta, txt_sect_banco, txt_alias, txt_estado };
            TextBox[] Idtextbox = { txt_id_agCuenta, txt_numcuenta };
            navegador1.textbox = Grupotextbox;
            navegador1.textboxi = Idtextbox;
            navegador1.cargar(dgv_agCuentas, Grupotextbox, cn.getNombreBd());
        }

        private void cb_tipomoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_estado_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrEmpty(textBox.Text))
            {
                ((TextBox)sender).Text = "1";
            }
        }

        private void cb_tipoMoneda_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cb_tipoMoneda.SelectedItem != null)
            {
                string tipoMonedaSeleccionada = cb_tipoMoneda.SelectedItem.ToString();
                txt_tipo_mon.Text = tipoMonedaSeleccionada; // Muestra la selección en el TextBox txt_tipo_mon
            }
        }

        private void cb_Banco_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Banco.SelectedItem != null)
            {
                string bancoSeleccionado = cb_Banco.SelectedItem.ToString();
                txt_sect_banco.Text = bancoSeleccionado; // Muestra la selección en el TextBox txt_tipo_mon
            }
        }

        private void txt_tipocuenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_tipocuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_tipocuenta.SelectedItem != null)
            {
                string bancoSeleccionado = cb_tipocuenta.SelectedItem.ToString();
                txt_tipocuenta.Text = bancoSeleccionado; // Muestra la selección en el TextBox txt_tipo_mon
            }
        }

        private void btn_Ayuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "AyudasBancos/AyudasBancos.chm", "Mantenimientos.html");
        }
    }
}
