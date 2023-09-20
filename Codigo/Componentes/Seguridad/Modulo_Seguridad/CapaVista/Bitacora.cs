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
            actualizardatagriew();
        }

        string bitacora = "tbl_perfil_encabezado";

        Controlador cn = new Controlador();
        public void actualizardatagriew()
        {
            DataTable dt = cn.llenarTblBitacora(bitacora);
            dtTabla.DataSource = dt;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
