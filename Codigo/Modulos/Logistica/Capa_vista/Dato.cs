using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista_PrototipoMenu
{
    public partial class Dato : Form
    {
        Controlador_PrototipoMenu.ControladorInventario crud = new Controlador_PrototipoMenu.ControladorInventario();
        OdbcConnection conn = new OdbcConnection("Dsn=Colchoneria");
        String tablabusqueda;
        public Dato()
        {
            InitializeComponent();
        }

        private void Dgv_Data_Docs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            new Auditoria().Show();  // Crear una instancia de Auditoria sin argumentos
            this.Hide();
        }

        private void Dato_Load(object sender, EventArgs e)
        {
            DataTable dt = crud.llenartb3("TBL_Doc_Auditoria");
            Dgv_Data_Docs.DataSource = dt;
        }
    }
}
