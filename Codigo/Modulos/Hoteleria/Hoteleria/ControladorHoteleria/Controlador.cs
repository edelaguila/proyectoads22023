using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloHoteleria;
using System.Drawing;
using System.Windows.Forms;
using ModeloHoteleria.templates;

namespace ControladorHoteleria
{
    public class Controlador
    {
        public Sentencias sn;

        private List<Empleado> empleados = new List<Empleado>();
        private List<TipoHabitacion> habs;
        private List<Habitacion> habitaciones;
        private List<Cliente> clientes;

        public int getEvaID()
        {
            return this.sn.ObtenerUltimaId();
        }

        List<Control> controles_evaluacion = new List<Control>();
        public Controlador()
        {
            this.sn = new Sentencias();
            this.habs = this.sn.getTiposHabitacion();
            this.habitaciones = this.sn.getHabitaciones();
            this.empleados = this.sn.ObtenerEmpleados();
            this.clientes = this.sn.ObtenerClientes();
        }

        public void fillEmpleados(ComboBox cmb)
        {
            foreach (Empleado emp in empleados)
            {
                cmb.Items.Add(emp.nombre);
            }
        }

        public void fillClientes(ComboBox cmb)
        {
            foreach (Cliente emp in clientes)
            {
                cmb.Items.Add(emp.nombre);
            }
        }



        public void changeEmpleado(string reference, TextBox txt)
        {
            foreach (Empleado emp in empleados)
            {
                if (reference.Equals(emp.nombre))
                {
                    txt.Text = emp.id.ToString();
                }
            }
        }

        public List<string> getTypes()
        {
            List<string> types = new List<string>();
            foreach (TipoHabitacion th in habs)
            {
                types.Add(th.thab_nombre);
            }
            return types;
        }

        public void fillHabitaciones(ComboBox cmb, string selected)
        {
            int id_seleccionado = 0;
            foreach (TipoHabitacion th in habs)
            {
                if (th.thab_nombre.Equals(selected))
                {
                    id_seleccionado = th.thab_id;
                }
            }

            foreach (Habitacion _h in habitaciones)
            {
                if (_h.tipo == id_seleccionado)
                {
                    cmb.Items.Add(_h.numero.ToString());
                }
            }
        }
    }

}
