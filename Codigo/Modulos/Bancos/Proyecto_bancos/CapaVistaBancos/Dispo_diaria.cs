using System;
using System.Windows.Forms;
using Seguridad_Controlador;

namespace CapaVistaBancos
{
    public partial class Dispo_diaria : Form
    {
        Seguridad_Controlador.Controlador cn = new Seguridad_Controlador.Controlador();
        CapaControladorBancos.ControladorBanco cbanco = new CapaControladorBancos.ControladorBanco();

        //public void fillBancos()
       // {
           // cbanco.fillBanco(combo_banco);
       // }
        
        
        public Dispo_diaria()
        {
            InitializeComponent();
            NavegadorVista.Navegador.idApp = "5004";
            _navegador.actual = this;
            _navegador.tabla = dataGridView1;
            TextBox[] Grupotextbox = { txt_id, txt_idbancoag, txt_nombrebanco, txt_status, txt_statusc };
            TextBox[] Idtextbox = { txt_id, txt_idbancoag };
            _navegador.textbox = Grupotextbox;
            _navegador.textboxi = Idtextbox;
            _navegador.cargar(dataGridView1, Grupotextbox, cn.getNombreBd());
            //this.fillBancos();
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
