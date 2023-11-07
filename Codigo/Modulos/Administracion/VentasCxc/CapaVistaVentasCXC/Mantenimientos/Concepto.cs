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
    public partial class Concepto : Form
    {
        Controlador cn = new Controlador();
        public Concepto()
        {
            InitializeComponent();
        }

        private void Concepto_Load(object sender, EventArgs e)
        {

        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "3008";  //código aplicación asignado al formulario
            navegador1.actual = this;
            navegador1.tabla = dataGridView1;
            TextBox[] Grupotextbox = { txtidconcepto, txtdescripcion, txttipo, txtserie };
            TextBox[] Idtextbox = { txtidconcepto, txtdescripcion };
            navegador1.textbox = Grupotextbox;
            navegador1.textboxi = Idtextbox;
            navegador1.cargar(dataGridView1, Grupotextbox, cn.getNombreBd());

        }
    }
}
