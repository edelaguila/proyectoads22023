using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hoteleria
{
    public partial class TipoHabitacion : Form
    {
        public TipoHabitacion()
        {
            InitializeComponent();
            this.navegador1.config("tbl_tipohabitacion", this, "");
            this.navegador1._initSeguridad();
        }

        private void txt_correo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
