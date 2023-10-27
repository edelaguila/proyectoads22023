using System;
using System.Windows.Forms;

namespace CapaVistaBancos
{
    public partial class Mantenimiento_OrdenesdeCompra : Form
    {
        public Mantenimiento_OrdenesdeCompra()
        {
            InitializeComponent();
            this.navegador1.config("tbl_mantenimientos_ordenes_compra", this, "");
        }

        private void btn_salir_dispo_Click(object sender, EventArgs e)
        {
            this.Close();
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
