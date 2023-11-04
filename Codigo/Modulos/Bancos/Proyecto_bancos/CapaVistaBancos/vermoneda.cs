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
    public partial class vermoneda : Form
    {
        public vermoneda()
        {
            InitializeComponent();
        }

        private void vermoneda_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet8.tbl_monedabanco' Puede moverla o quitarla según sea necesario.
            this.tbl_monedabancoTableAdapter.Fill(this.dataSet8.tbl_monedabanco);

        }
    }
}
