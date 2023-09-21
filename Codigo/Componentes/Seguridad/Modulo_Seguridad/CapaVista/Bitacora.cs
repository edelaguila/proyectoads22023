using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;
namespace CapaVista
{
    public partial class Bitacora : Form
    {
        public Bitacora()
        {
            InitializeComponent();
            //actualizardatagriew();
        }

        /*string bitacora = "tbl_perfil_encabezado";

        Controlador cn = new Controlador();
        public void actualizardatagriew()
        {
            DataTable dt = cn.llenarTblBitacora(bitacora);
            dtTabla.DataSource = dt;

        }*/

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtTabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "ComponenteSeguridadAyuda/AyudaSeguridad.chm", "Reportes.html");
            //Help.ShowHelp(this, "C:/Users/rayju/OneDrive/Escritorio/GitHub AnotherWork/proyectoads22023/Codigo/Componentes/Seguridad/Modulo_Seguridad/CapaVista/bin/Debug/ComponenteSeguridadAyuda/AyudaSeguridad.chm", "Ayuda.html");
        }
    }
}
