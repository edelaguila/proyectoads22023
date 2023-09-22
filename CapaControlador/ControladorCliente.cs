using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo;

namespace CapaControlador
{
    public class ControladorCliente
    {
        public SentenciasCliente snClientes;


        public ControladorCliente()
        {
            this.snClientes = new SentenciasCliente();

        }

        public void agregarCliente(Dictionary<string, string> parameters)
        {
            this.snClientes.agregarClientes(parameters);
        }


        public List<string> getColumns(string tabla)
        {
            return this.snClientes.getColumns(tabla);
        }

    }
}
