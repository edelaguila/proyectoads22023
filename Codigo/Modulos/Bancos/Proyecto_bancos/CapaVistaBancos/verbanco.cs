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
    public partial class verbanco : Form
    {
        public verbanco()
        {
            InitializeComponent();
        }

        private void verbanco_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet10.tbl_banco' Puede moverla o quitarla según sea necesario.
            this.tbl_bancoTableAdapter.Fill(this.dataSet10.tbl_banco);
            // TODO: esta línea de código carga datos en la tabla 'dataSet9.tbl_mantenimientos_agregar_bancos' Puede moverla o quitarla según sea necesario.
            this.tbl_mantenimientos_agregar_bancosTableAdapter.Fill(this.dataSet9.tbl_mantenimientos_agregar_bancos);

        }
    }
}
