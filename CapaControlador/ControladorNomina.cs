using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo;
namespace CapaControlador
{
   public class ControladorNomina
    {
        public SentenciasNomina snNomina;

        public ControladorNomina()
        {
            this.snNomina = new SentenciasNomina();


        }

        public void agregarEmpleadoNomina(Dictionary<string, string> parameters)
        {
            this.snNomina.agregarEmpleadoNomina(parameters);
        }

        public List<string> getColumns(string tabla)
        {
            return this.snNomina.getColumns(tabla);
        }

    }
}
