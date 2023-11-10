using System;
using System.Windows.Forms;
using Seguridad_Controlador;

namespace CapaVistaBancos
{
    public partial class Mantenimiento_Agregar_Bancos : Form
    {
        //Codigo escrito por Andrea Corado
        Controlador cn = new Controlador();
        public Mantenimiento_Agregar_Bancos()
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

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "5007";  //código aplicación asignado al formulario
            navegador1.actual = this;
            navegador1.tabla = dgv_agBancos;
            TextBox[] Grupotextbox = { txt_id_banco, txt_numbanco, txt_nombrebanco, txt_estadoban };
            TextBox[] Idtextbox = { txt_id_banco, txt_numbanco };
            navegador1.textbox = Grupotextbox;
            navegador1.textboxi = Idtextbox;
            navegador1.cargar(dgv_agBancos, Grupotextbox, cn.getNombreBd());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrEmpty(textBox.Text))
            {
                ((TextBox)sender).Text = "0";
            }
        }

        private void btn_Ayuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "AyudasBancos/AyudasBancos.chm", "Mantenimientos.html");
        }
    }
}
