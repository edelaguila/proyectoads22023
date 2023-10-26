using System;
using System.Windows.Forms;

namespace CapaVistaBancos
{
    public partial class Tipo_cambio : Form
    {
        public Tipo_cambio()
        {
            InitializeComponent();
        }

        private void btn_salir_dispo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
