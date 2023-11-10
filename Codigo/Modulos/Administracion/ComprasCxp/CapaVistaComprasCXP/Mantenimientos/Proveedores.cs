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

namespace CapaVistaComprasCXP.Mantenimientos
{
    public partial class Proveedores : Form
    {
        Controlador cn = new Controlador();
        public Proveedores()
        {
            InitializeComponent();
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {

        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "2001";  //código aplicación asignado al formulario
            navegador1.actual = this;
            navegador1.tabla = dataGridView1;
            TextBox[] Grupotextbox = { txtid, txtnombre, txtdomicilio, txtnit, txttelefono, txttipo, txtestado, txtrepresentante, txtempresa };
            TextBox[] Idtextbox = { txtid, txtnombre };
            navegador1.textbox = Grupotextbox;
            navegador1.textboxi = Idtextbox;
            navegador1.cargar(dataGridView1, Grupotextbox, cn.getNombreBd());
        }
    }
}
