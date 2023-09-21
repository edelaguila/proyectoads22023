using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo;

namespace CapaControlador
{
    public class ControladorEmpleado
    {

        public SentenciasEmpleado snEmpleado;


        public ControladorEmpleado()
        {
            this.snEmpleado = new SentenciasEmpleado();

        }

        public void agregarEmpleado(Dictionary<string, string> parameters)
        {
            this.snEmpleado.agregarEmpleado(parameters);
        }


        public List<string> getColumns(string tabla)
        {
            return this.snEmpleado.getColumns(tabla);
        }


    }
}
