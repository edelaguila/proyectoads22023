using System;
using System.Windows.Forms;
using Seguridad_Controlador;
using System.Data;
using CapaControladorBancos;

namespace CapaVistaBancos
{
    //Codigo escrito por Andrea Corado
    public partial class Mantenimiento_tipoMov : Form
    {
        Controlador cn = new Controlador();
        ControladorBanco con = new ControladorBanco();
        public Mantenimiento_tipoMov()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_salir_dispo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_transaexis_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Mantenimiento_tipoMov_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet7.tbl_mantenimientos_tipo_movimiento' Puede moverla o quitarla según sea necesario.
            this.tbl_mantenimientos_tipo_movimientoTableAdapter.Fill(this.dataSet7.tbl_mantenimientos_tipo_movimiento);

            DataTable tcuenta = con.ObtenerTipoCuenta();
            if (tcuenta != null)
            {
                foreach (DataRow row in tcuenta.Rows)
                {
                    cb_transaccionex.Items.Add(row["movtm_transacciones_existentes"].ToString());
                }
            }
        }

        private void txt_estado_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrEmpty(textBox.Text))
            {
                ((TextBox)sender).Text = "1";
            }
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "5008";  //código aplicación asignado al formulario
            navegador1.actual = this;
            navegador1.tabla = dgv_tipoMov;
            TextBox[] Grupotextbox = { txt_idtras, txt_transexiten, txt_estado, txt_valorTrans};
            TextBox[] Idtextbox = { txt_idtras, txt_transexiten };
            navegador1.textbox = Grupotextbox;
            navegador1.textboxi = Idtextbox;
            navegador1.cargar(dgv_tipoMov, Grupotextbox, cn.getNombreBd());
        }

        

        private void txt_estado_TextChanged_1(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrEmpty(textBox.Text))
            {
                ((TextBox)sender).Text = "1";
            }
        }

        private void cb_transaccionex_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_transaccionex.SelectedItem != null)
            {
                string tipoMonedaSeleccionada = cb_transaccionex.SelectedItem.ToString();
                txt_transexiten.Text = tipoMonedaSeleccionada; // Muestra la selección en el TextBox txt_tipo_mon
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_tipoMov.SelectedItem != null)
            {
                if (cb_tipoMov.SelectedItem.ToString().Equals( "Activo"))
                {
                    txt_valorTrans.Text = "1";
                }
                else
                {
                    txt_valorTrans.Text = "0";
                }
            }
        }

        private void btn_Ayuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "AyudasBancos/AyudasBancos.chm", "Mantenimientos.html");
        }
    }
}
