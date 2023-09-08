using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using CapaModelo;

namespace CapaControlador
{
    public class ControladorNavegador
    {
        private SentenciasEmpleados snEmpleados;

        public ControladorNavegador()
        {
            this.snEmpleados = new SentenciasEmpleados();
        }

        public void agregarEmpleado(string nombre, string puesto, string departamento)
        {
            this.snEmpleados.agregarEmpleado(nombre, puesto, departamento);
        }
    }
}
