using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo_PrototipoMenu;
using Modelo_PrototipoMenu.templates;
using System.Windows.Forms;

namespace Controlador_PrototipoMenu
{
    public class Controller
    {
        public List<TipoHabitacion> thabs = new List<TipoHabitacion>();
        public List<Habitacion> habitaciones = new List<Habitacion>();
        public List<Empleado> empleados = new List<Empleado>();
        public List<Cliente> clientes = new List<Cliente>();
        GeneralSentence sn = new GeneralSentence();
        public Controller()
        {
            this.thabs = sn.getTiposHabitacion();
            habitaciones = sn.getHabitaciones();
            this.empleados = sn.GetEmpleados();
            this.clientes = sn.GetClientes();
        }

        public List<string> getTypes(ComboBox cmb)
        {
            List<string> types = new List<string>();
            foreach (TipoHabitacion th in thabs)
            {
                cmb.Items.Add(th.thab_nombre);
            }
            return types;
        }

        public void fillEmpleados(ComboBox cmb)
        {
            foreach (Empleado emp in empleados)
            {
                cmb.Items.Add(emp.EmpNombre);
            }
        }

        public void fillSelectEmp(string selected, TextBox txt)
        {
            int id_seleccionado = 0;
            foreach (Empleado th in empleados)
            {
                if (th.EmpNombre.Equals(selected))
                {
                    id_seleccionado = th.EmpId;
                }
            }
            txt.Text = id_seleccionado.ToString();
        }

        public int getClientID(string reference)
        {
            foreach (Cliente cl in clientes)
            {
                if (cl.CliNombre.Equals(reference))
                {
                    return cl.CliId;
                }
            }
            return -1;
        }




        public void fillHabitaciones(string selected, TextBox txt)
        {
            int id_seleccionado = 0;
            foreach (TipoHabitacion th in thabs)
            {
                if (th.thab_nombre.Equals(selected))
                {
                    id_seleccionado = th.thab_id;
                }
            }
            txt.Text = id_seleccionado.ToString();
        }

        public void fillComboHabitaciones(ComboBox cmb, string selected, Label lbl)
        {

            MessageBox.Show("Habiaciones: " + habitaciones.Count.ToString());
            int id_seleccionado = 0;
            foreach (TipoHabitacion th in thabs)
            {
                if (th.thab_nombre.Equals(selected))
                {
                    lbl.Text = "Q." + th.thab_precio.ToString() + ".00";
                    id_seleccionado = th.thab_id;
                }
            }

            foreach (Habitacion _h in habitaciones)
            {
                if (_h.tipo == id_seleccionado && _h.estado == 0)
                {
                    cmb.Items.Add(_h.numero.ToString());
                }
            }
            this.habitaciones = sn.getHabitaciones();
        }

        public void fillHabitacionesByDate(ComboBox cmb, DateTimePicker d1, DateTimePicker d2, Label lbl, string selected)
        {
            List<Reservacion> reservaciones = sn.ObtenerReservacionesEntreFechas(d1.Value, d2.Value);
            if (reservaciones.Count == 0)
            {
                this.fillComboHabitaciones(cmb, selected, lbl);
            }
            else
            {

                List<Habitacion> habitaciones_desocupadas = new List<Habitacion>();
                foreach (Habitacion hab in habitaciones)
                {
                    foreach (Reservacion res in reservaciones)
                    {
                        if (!res.Res_id_habitacion.Equals(hab.id))
                        {
                            habitaciones_desocupadas.Add(hab);
                        }
                    }
                }
                habitaciones = habitaciones_desocupadas;
                this.fillComboHabitaciones(cmb, selected, lbl);
            }
        }





    }
}
