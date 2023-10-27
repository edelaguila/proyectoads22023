using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControladorHoteleria;

namespace Hoteleria
{
    public partial class GestionHabitaciones : Form
    {
        public Controlador ctrl;
        public GestionHabitaciones()
        {
            InitializeComponent();
            this.navegador1.config("tbl_entrada", this, "");
            this.ctrl = new Controlador();
            this.fill();
        }

        public void showHide(bool estado, string reference)
        {
            foreach (Control c in this.Controls)
            {
                if (c.Tag == null) continue;
                if (c.Tag.ToString().Contains(reference))
                {
                    c.Visible = estado;
                }
            }
            txt_ideva.Visible = false;
            txt_id_cliente.Visible = false;
            txt_id_empleado.Visible = false;
        }

        public void fill()
        {
            List<string> types = this.ctrl.getTypes();
            foreach (string str in types)
            {
                this.combo.Items.Add(str);
            }
            this.ctrl.fillEmpleados(this.comboEmpleados);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo2.Items.Clear();
            this.ctrl.fillHabitaciones(this.combo2, this.combo.SelectedItem.ToString());
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            this.navegador1.config("tbl_evaluacion", this, "");
            this.checkBox3.Checked = !this.checkBox4.Checked;
            this.showHide(false, "in");
            this.showHide(true, "eva");
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Switch to entrada");
            this.navegador1.config("tbl_entrada", this, "");
            this.checkBox4.Checked = !this.checkBox3.Checked;
            this.showHide(false, "eva");
            this.showHide(true, "in");
            txt_ideva.Text = this.ctrl.getEvaID().ToString();
        }

        private void comboEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ctrl.changeEmpleado(this.comboEmpleados.Text, txt_id_empleado);
        }
    }
}
