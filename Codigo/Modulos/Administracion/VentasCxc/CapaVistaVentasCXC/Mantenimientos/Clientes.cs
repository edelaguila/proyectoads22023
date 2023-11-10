using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Seguridad_Controlador;

namespace CapaVistaVentasCXC.Mantenimientos
{
    public partial class Clientes : Form
    {
        Controlador cn = new Controlador();
        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {

        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "3007";  //código aplicación asignado al formulario
            navegador1.actual = this;
            navegador1.tabla = dataGridView1;
            TextBox[] Grupotextbox = { txtid, txtnombre, txttelefono, txtnit, txtestado, txttipo };
            TextBox[] Idtextbox = { txtid, txtnombre };
            navegador1.textbox = Grupotextbox;
            navegador1.textboxi = Idtextbox;
            navegador1.cargar(dataGridView1, Grupotextbox, cn.getNombreBd());

        }
    }
}
