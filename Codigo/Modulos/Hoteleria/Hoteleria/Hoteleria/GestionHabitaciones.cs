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
            this.ctrl = new Controlador();
            this.fill();
        }

        public void fill()
        {
            List<string> types = this.ctrl.getTypes();
            foreach(string str in types)
            {
                this.combo.Items.Add(str);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo2.Items.Clear();
            this.ctrl.fillHabitaciones(this.combo2, this.combo.SelectedItem.ToString());
        }
    }
}
