using System;
using System.Windows.Forms;
using CapaControladorBancos;
using System.Data;
namespace CapaVistaBancos
{
    public partial class Tipo_cambio : Form
    {
        Seguridad_Controlador.Controlador cn = new Seguridad_Controlador.Controlador();

        
        public Tipo_cambio()
        {
            InitializeComponent();
            NavegadorVista.Navegador.idApp = "1003";
            _navegador.actual = this;
            _navegador.tabla = dataGridView1;
            TextBox[] Grupotextbox = { txt_id, txt_tipo_moneda, txt_valor_moneda, txt_fecha, txt_estado  };
            TextBox[] Idtextbox = { txt_id, txt_tipo_moneda };
            _navegador.textbox = Grupotextbox;
            _navegador.textboxi = Idtextbox;
            _navegador.cargar(dataGridView1, Grupotextbox, cn.getNombreBd());
        }

        private void btn_salir_dispo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void txt_estado_TextChanged(object sender, EventArgs e)
        {
            txt_estado.Text = "1";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string fechaSeleccionada = ((DateTimePicker)sender).Value.ToString("yyyy-MM-dd"); // Convierte la fecha al formato deseado
            txt_fecha.Text = fechaSeleccionada;
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void _navegador_Load(object sender, EventArgs e)
        {

        }
    }
}
