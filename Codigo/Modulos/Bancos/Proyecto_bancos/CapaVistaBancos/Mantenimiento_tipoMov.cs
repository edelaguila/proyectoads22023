using System;
using System.Windows.Forms;

namespace CapaVistaBancos
{
    public partial class Mantenimiento_tipoMov : Form
    {
        public Mantenimiento_tipoMov()
        {
            InitializeComponent();
            this.navegador1.config("tbl_mantenimientos_tipo_movimiento", this, "");
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

        }

        private void txt_estado_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrEmpty(textBox.Text))
            {
                ((TextBox)sender).Text = "1";
            }
        }
    }
}
