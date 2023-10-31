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
//using Controlador_InventariosMenu();

namespace Vista_PrototipoMenu
{
    public partial class Mantenimiento : Form
    {
        public Mantenimiento()
        {
            InitializeComponent();
        }


        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "4400";  //código aplicación asignado al formulario
            navegador1.actual = this;
            navegador1.tabla = Dgv_tablas;
            TextBox[] Grupotextbox = { Txt_codigo, Txt_nombre, Txt_cuenta, Txt_fecha, Txt_almacen };
            TextBox[] Idtextbox = { txt_IdCuenta};
            navegador1.textbox = Grupotextbox;
            navegador1.textboxi = Idtextbox;
            //navegador1.cargar(Dgv_tablas, Grupotextbox, cn.getNombreBd());

        }

        private void Mantenimiento_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
