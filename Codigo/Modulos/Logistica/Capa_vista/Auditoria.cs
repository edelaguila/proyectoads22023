using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Controlador_PrototipoMenu;

namespace Vista_PrototipoMenu
{
    public partial class Auditoria : Form
    {
        public Auditoria()
        {
            InitializeComponent();
        }

        Controlador_PrototipoMenu.ControladorInventario crud = new Controlador_PrototipoMenu.ControladorInventario();
        private void button2_Click(object sender, EventArgs e)
        {
            bool resultado = crud.UpdateAudi(txt_id.Text, txtnumero.Text, dateTimePicker1.Text, dateTimePicker2.Text, cboclientes.Text, cbotipo.Text, dateTimePicker3.Text, txtConsumo.Text, txtRecepcion.Text, txtcheck.Text,  txtServivio.Text, txttotal.Text, txtMantenimiento.Text,  txtSeguridad.Text, txt_estado.Text);
            if (resultado)
            {
                dataGridView1.Rows.Add(new object[] { txt_id.Text, txtnumero.Text, dateTimePicker1.Text, dateTimePicker2.Text, cboclientes.Text, cbotipo.Text, dateTimePicker3.Text, txtConsumo.Text, txtRecepcion.Text, txtcheck.Text, txtServivio.Text, txttotal.Text, txtMantenimiento.Text, txtSeguridad.Text, txt_estado.Text });
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string table = "";
            DataTable dt = new DataTable();
            table = "tbl_auditoria";
            crud.Actualizarmues(table, dt);
            dataGridView1.DataSource = dt;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bool resultado = crud.DeleteAudi(txt_id.Text);
            if (resultado)
            {
                dataGridView1.Rows.Add(new object[] { txt_id.Text });
            }
        }
    }
}
