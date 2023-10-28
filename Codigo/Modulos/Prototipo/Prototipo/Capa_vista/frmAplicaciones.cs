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

namespace Vista_PrototipoMenu
{
    public partial class frmAplicaciones : Form
    {
        Controlador cn = new Controlador();

        public frmAplicaciones()
        {
            InitializeComponent();
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "1003";
            navegador1.actual = this;
            navegador1.tabla = dataGridView1;
            TextBox[] Grupotextbox = { txtIdAplicacion, txtNombreAplicacion, txtDescripcionAplicacion, txtEstadoAplicacion };
            TextBox[] Idtextbox = { txtIdAplicacion, txtNombreAplicacion };
            navegador1.textbox = Grupotextbox;
            navegador1.textboxi = Idtextbox;
            navegador1.cargar(dataGridView1, Grupotextbox, cn.getNombreBd());
        }
    }
}
