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
    public partial class frmTipoHabitacion : Form
    {
        Seguridad_Controlador.Controlador cn;
        public frmTipoHabitacion()
        {
            this.cn = new Seguridad_Controlador.Controlador();
            InitializeComponent();
            navegador1.config("tbl_tipohabitacion", this, "");
        }

        private void _navegador_Load(object sender, EventArgs e)
        {
        }

        private void frmTipoHabitacion_Load(object sender, EventArgs e)
        {

        }
    }
}
