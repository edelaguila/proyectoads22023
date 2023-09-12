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
            var dictionary = new Dictionary<string, string>();
            List<string> columns = this.ctrNav.getColumns("empleados");

            foreach (Control c in child.Controls)
            {
                if (c is TextBox)
                {
                    string tag = c.Tag.ToString();
                    if (columns.Contains(tag))
                    {
                        dictionary.Add(tag, c.Text);
                    }
                    c.Text = "";
                }
            }
            this.ctrNav.agregarEmpleado(dictionary);
            MessageBox.Show("Empleado creado");
        }


    }
}
