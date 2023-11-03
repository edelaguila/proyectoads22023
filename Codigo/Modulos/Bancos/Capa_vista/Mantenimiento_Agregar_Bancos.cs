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

namespace Vista_BancoMenu
{
    Controlador cn = new Controlador();

    public partial class Mantenimiento_Agregar_Bancos : Form
    {

        public Mantenimiento_Agregar_Bancos()
        {
            InitializeComponent();
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "1003";  //código aplicación asignado al formulario
            navegador1.actual = this;
            navegador1.tabla = Dgv_perfiles;
            TextBox[] Grupotextbox = { txtIdPerfiles, txtNombre, txtDescripcion, txtEstado };
            TextBox[] Idtextbox = { txtIdPerfiles, txtNombre };
            navegador1.textbox = Grupotextbox;
            navegador1.textboxi = Idtextbox;
            navegador1.cargar(Dgv_perfiles, Grupotextbox, cn.getNombreBd());
        }



        private void Mantenimiento_Agregar_Bancos_Load(object sender, EventArgs e)
        {

        }
    }
}
