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
        //Erick Ramirez
        Controlador cn = new Controlador();
        //Erick Ramirez
        public Bitacora()
        {
            InitializeComponent();
            columnBita();

        }

        //Erick Ramirez
        public void columnBita()
        {
            //Erick Ramirez
            dgv_bitacora.DataSource = cn.FillBitacora();
            dgv_bitacora.Columns["PK_id_bitacora"].HeaderText = "Codigo";
            dgv_bitacora.Columns["nbr_fecha"].HeaderText = "Fecha";
            dgv_bitacora.Columns["nbr_host1"].HeaderText = "Host";
            dgv_bitacora.Columns["nbr_ip"].HeaderText = "Ip";
            dgv_bitacora.Columns["nbr_accion"].HeaderText = "Accion";
            dgv_bitacora.Columns["nbr_tabla"].HeaderText = "Tabla";
            dgv_bitacora.Columns["FK_id_Modulo"].HeaderText = "Id Modulo";
            dgv_bitacora.Columns["FK_id_usuario"].HeaderText = "Id Usuario";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtTabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Justin Pennant
            Help.ShowHelp(this, "ComponenteSeguridadAyuda/AyudaSeguridad.chm", "Reportes.html");
            //Help.ShowHelp(this, "C:/Users/rayju/OneDrive/Escritorio/GitHub AnotherWork/proyectoads22023/Codigo/Componentes/Seguridad/Modulo_Seguridad/CapaVista/bin/Debug/ComponenteSeguridadAyuda/AyudaSeguridad.chm", "Ayuda.html");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            columnBita();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Erick Ramirez
            this.Hide();
        }
    }
}
