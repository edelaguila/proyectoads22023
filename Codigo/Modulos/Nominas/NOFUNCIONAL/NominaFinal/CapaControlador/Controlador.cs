using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModeloNomina;


namespace CapaControladorNomina
{
    public class Controlador
    {
        public Sentencias sn;
       
        public Controlador()
        {
            sn = new Sentencias();
        }

        public Empleado BuscarEmpleadoPorID(int id)
        {
            Empleado empleado = sn.BuscarEmpleadoPorID(id);
            return empleado;
        }

    }
}
