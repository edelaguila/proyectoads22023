using System;
using System.Windows.Forms;

namespace CapaVistaBancos
{
    public partial class Mantenimiento_Agregar_Bancos : Form
    {
        public Mantenimiento_Agregar_Bancos()
        {
            InitializeComponent();
            this.navegador1.config("tbl_mantenimientos_agregar_bancos", this, "");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_salir_dispo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Mantenimiento_Agregar_Bancos_Load(object sender, EventArgs e)
        {

        }


        private void txt_estadoban_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrEmpty(textBox.Text))
            {
                ((TextBox)sender).Text = "1";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
