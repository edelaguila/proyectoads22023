using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaBancos
{
    public partial class vertransaccion : Form
    {
        public vertransaccion()
        {
            InitializeComponent();
        }

        private void vertransaccion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet11.tbl_mantenimientos_tipo_movimiento' Puede moverla o quitarla según sea necesario.
            this.tbl_mantenimientos_tipo_movimientoTableAdapter.Fill(this.dataSet11.tbl_mantenimientos_tipo_movimiento);

        }
    }
}
