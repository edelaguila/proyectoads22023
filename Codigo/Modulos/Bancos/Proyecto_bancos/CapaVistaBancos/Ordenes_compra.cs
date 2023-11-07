using System;
using System.Windows.Forms;

using CapaControladorBancos;

namespace CapaVistaBancos
{
    public partial class Ordenes_compra : Form
    {
        public Ordenes_compra()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string noCuenta = textBox1.Text;
            negocios.ObtenerSaldo(noCuenta);
            MessageBox.Show("El saldo de la cuenta " + noCuenta + " es " + negocios.SCuenta);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string nCuenta = textBox1.Text;
            negocios.ObtenertMoneda(nCuenta);


        }

        

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        public void Habilitador_timer()
        {
            timer1.Interval = 50400000;
            timer1.Enabled = true;
            // Hook up timer's tick event handler.
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ControladorBanco.actualizacion_saldos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            negocios.ObtenerValorM("Dolares"); //Prueba de funcion Obtener ValorM   AUN NO FUNCIONAL
            MessageBox.Show("Valor: " + negocios.VMoneda); //Muestra valor moneda AUN NO FUNCIONAL

        }



      

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void txt_traslado_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            // string nBancoO;
            string noCuentaO = textBox1.Text;
            //nBancoO = Convert.ToString(oBancoCB.SelectedItem.ToString());
            //negocios.ObtenerID(nBancoO);

            negocios.ObtenerSaldo(noCuentaO);
            negocios.ObtenertMoneda(noCuentaO);
            negocios.ObtenerIdBanco(noCuentaO);
            negocios.ObtenerID(negocios.nomBanco);

            lbl_saldo.Text = Convert.ToString(negocios.saldo);
            lbl_Tmoneda.Text = negocios.tMoneda;
            lbl_nBancoO.Text = negocios.bancoN;
            string noCuentaD = textBox4.Text;
            //string nBancoD;

            //nBancoD = Convert.ToString(dBancoCB.SelectedItem.ToString());
            //negocios.ObtenerID(nBancoD);
            negocios.ObtenerSaldo(noCuentaD);
            negocios.ObtenertMoneda(noCuentaD);
            negocios.ObtenerIdBanco(noCuentaD);
            negocios.ObtenerID(negocios.nomBanco);

            lbl_SaldoD.Text = Convert.ToString(negocios.saldo);
            lbl_tMonedaD.Text = negocios.tMoneda;
            lbl_nBancoD.Text = negocios.bancoN;


        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Datos de origen/////////////////////////////////////////////////

            string noCuentaO = textBox1.Text;
            negocios.ObtenerSaldo(noCuentaO);
            negocios.ObtenertMoneda(noCuentaO);
            double saldoO = negocios.saldo;

            //Datos del destino////////////////////////////////////////////////
            string noCuentaD = textBox4.Text;
            negocios.ObtenerSaldo(noCuentaD);
            negocios.ObtenertMoneda(noCuentaD);
            double saldoD = negocios.saldo;

            //Monto del traslado///////////////////////////////////////
            double tras = Convert.ToDouble(txt_traslado.Text);

            // LLamada a negocios ////////////////////////////////////
            negocios.TraspasoSaldo(noCuentaO, noCuentaD, saldoO, saldoD, tras);
            //Carga de labels;

            negocios.ObtenerSaldo(noCuentaO);
            negocios.ObtenertMoneda(noCuentaO);

            lbl_saldo.Text = Convert.ToString(negocios.saldo);
            lbl_Tmoneda.Text = negocios.tMoneda;

            // string noCuentaD = textBox4.Text;
            //string nBancoD;

            //nBancoD = Convert.ToString(dBancoCB.SelectedItem.ToString());
            //negocios.ObtenerID(nBancoD);
            negocios.ObtenerSaldo(noCuentaD);
            negocios.ObtenertMoneda(noCuentaD);
            lbl_SaldoD.Text = Convert.ToString(negocios.saldo);
            lbl_tMonedaD.Text = negocios.tMoneda;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            lbl_SaldoD.Text = "";
            lbl_tMonedaD.Text = "";
            lbl_nBancoD.Text = "";
            lbl_saldo.Text = "";
            lbl_Tmoneda.Text = "";
            lbl_nBancoO.Text = "";
            textBox1.Text = "";
            textBox4.Text = "";
        }

        private void btn_salir_dispo_Click(object sender, EventArgs e)
        {

        }
    }
}


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_salir_dispo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

