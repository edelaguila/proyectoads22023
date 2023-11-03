using System;
using System.Windows.Forms;
using Seguridad_Controlador;

namespace CapaVistaBancos
{
    public partial class Mantenimiento_OrdenesdeCompra : Form
    {
        Controlador cn = new Controlador();
        public Mantenimiento_OrdenesdeCompra()
        {
            InitializeComponent();
           
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

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "5009";  //código aplicación asignado al formulario
            navegador1.actual = this;
            navegador1.tabla = dgv_Man_ordenesCompra;
            TextBox[] Grupotextbox = { txt_id_ordenCom,txt_idauto,txt_nombrecompra,txt_nombrepro,txt_monto,txt_descripcion,txt_tipocompra,txt_tipo_moneda,txt_estado};
            TextBox[] Idtextbox = { txt_id_ordenCom, txt_idauto };
            navegador1.textbox = Grupotextbox;
            navegador1.textboxi = Idtextbox;
            navegador1.cargar(dgv_Man_ordenesCompra, Grupotextbox, cn.getNombreBd());
        }
    }
}
