using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class frm_mantenimiento : Form
    {
        public frm_mantenimiento()
        {
            InitializeComponent();
            this.navegador1.config("tbl_empleado", this, "");
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
           
        }
    }
}
