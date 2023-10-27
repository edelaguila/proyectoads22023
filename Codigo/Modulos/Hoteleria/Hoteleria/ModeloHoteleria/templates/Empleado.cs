using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloHoteleria.templates
{
    public class Empleado
    {
        public int id;
        public string nombre;
        public string apellido;
        public string correo;
        public string telefono;
        public string nit;

        public Empleado(int id, string nombre, string apellido, string correo, string telefono, string nit)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.correo = correo;
            this.telefono = telefono;
            this.nit = nit;
        }

        public Empleado(string nombre, string apellido, string correo, string telefono, string nit)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.correo = correo;
            this.telefono = telefono;
            this.nit = nit;
        }
    }
}
