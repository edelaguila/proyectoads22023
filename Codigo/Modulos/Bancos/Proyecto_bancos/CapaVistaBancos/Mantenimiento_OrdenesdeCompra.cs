using System;
using System.Windows.Forms;

namespace CapaVistaBancos
{
    public partial class Mantenimiento_OrdenesdeCompra : Form
    {
        public Mantenimiento_OrdenesdeCompra()
        {
            InitializeComponent();
        }

        private void btn_salir_dispo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
