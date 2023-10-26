using System;
using System.Windows.Forms;

namespace CapaVistaBancos
{
    public partial class Mov_bancarios : Form
    {
        public Mov_bancarios()
        {
            InitializeComponent();
        }

        private void btn_salir_dispo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_vistaTransacciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
