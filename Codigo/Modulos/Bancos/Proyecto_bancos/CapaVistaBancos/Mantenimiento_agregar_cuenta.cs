using System;
using System.Windows.Forms;

namespace CapaVistaBancos
{
    public partial class Mantenimiento_agregar_cuenta : Form
    {
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

        }
    }
}
