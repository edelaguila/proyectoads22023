using System;
using System.Windows.Forms;
using Seguridad_Controlador;

namespace CapaVistaBancos
{

    public partial class Mantenimiento_agregar_cuenta : Form
    {
        Controlador cn = new Controlador();
        
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

        private void button1_Click(object sender, EventArgs e)
        {
            vermoneda moneda = new vermoneda();
            moneda.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            verbanco banco = new verbanco();
            banco.Show();
        }

        private void btn_cuentaexis_Click(object sender, EventArgs e)
        {
            
        }
    }
}
