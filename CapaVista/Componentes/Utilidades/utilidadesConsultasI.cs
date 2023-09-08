using CapaControlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista.Componentes.Utilidades
{
    public class utilidadesConsultasI
    {
        public ControladorNavegador ctrNav = new ControladorNavegador();
        public utilidadesConsultasI(ControladorNavegador ctrlNav)
        {
            this.ctrNav = ctrNav;
        }
        public void guardarReservacion(Form child)
        {
            var cities = new Dictionary<string, string>(){
    {"nombre", ""},
    {"puesto", ""},
    {"departamento", ""}
};
            foreach (Control c in child.Controls)
            {
                if (c is TextBox)
                {
                    string tag = c.Tag.ToString();
                    cities[tag] = c.Text;
                }
            }
            this.ctrNav.agregarEmpleado(cities["nombre"], cities["puesto"], cities["departamento"]);
            MessageBox.Show("Empleado creado");

        }


    }
}
