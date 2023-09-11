using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        public void agregarEmpleado(Dictionary<string, string> parameters)
        {
            this.snEmpleados.agregarEmpleado(parameters);
        }
    }
}
