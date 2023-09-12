using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo;

namespace CapaControlador
{
    public class ControladorRegistro
    {

        private SentenciasRegistros snRegistros;


        public ControladorRegistro()
        {
            this.snRegistros = new SentenciasRegistros();

        }

        public void agregarUsuario(Dictionary<string,string> parameters)
        {
            this.snRegistros.agregarUsuario(parameters);
        }


        public List<string> getColumns(string tabla)
        {
            return this.snRegistros.getColumns(tabla);
        }


    }
}
