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
    public partial class ReservaHabitacion : Form
    {
        Controlador ctrl = new Controlador();
        public ReservaHabitacion()
        {
            InitializeComponent();
            this.fill();
        }
        public void fill()
        {
            List<string> types = this.ctrl.getTypes();
            foreach (string str in types)
            {
                this.comboTipo.Items.Add(str);
            }
        }



        private void comboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            comoHabitacion.Items.Clear();
            this.ctrl.fillHabitaciones(this.comoHabitacion, this.comboTipo.SelectedItem.ToString());
        }
    }
}
