using CapaControlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista.Componentes.Utilidades
{
    public class utilidadesConsultasI
    {
        public ControladorNavegador ctrNav = new ControladorNavegador();
        public ControladorRegistro ctrReg = new ControladorRegistro();
        public utilidadesConsultasI(ControladorNavegador ctrlNav)
        {
            this.ctrNav = ctrNav;
        }
        public utilidadesConsultasI()
        {

        }
        public void guardarCliente(Form child)
        {
            ControladorCliente ctrclick = new ControladorCliente();
            var dictionary = new Dictionary<string, string>();
            List<string> columns = this.ctrNav.getColumns("tbl_clientes");

            foreach (Control c in child.Controls)
            {
                if (c is TextBox)
                {
                    string tag = c.Tag.ToString();
                    if (columns.Contains(tag))
                    {
                        dictionary.Add(tag, c.Text);
                    }
                    c.Text = "";
                }
            }
            ctrclick.agregarCliente(dictionary);
            MessageBox.Show("Cliente Creado Correctamente");
        }
        public void guardarReservacion(Form child)
        {
            var dictionary = new Dictionary<string, string>();
            List<string> columns = this.ctrNav.getColumns("empleados");

            foreach (Control c in child.Controls)
            {
                if (c is TextBox)
                {
                    string tag = c.Tag.ToString();
                    if (columns.Contains(tag))
                    {
                        dictionary.Add(tag, c.Text);
                    }
                    c.Text = "";
                }
            }
            this.ctrNav.agregarEmpleado(dictionary);
            MessageBox.Show("Empleado creado");
        }


        public void guardarUsuario(Form child)
        {
            ControladorRegistro ctrol = new ControladorRegistro();
            var dictionary = new Dictionary<string, string>();
            List<string> columns = this.ctrNav.getColumns("usuario");

            foreach (Control c in child.Controls)
            {
                if (c is TextBox)
                {
                    string tag = c.Tag.ToString();
                    if (columns.Contains(tag))
                    {
                        dictionary.Add(tag, c.Text);
                    }
                    c.Text = "";
                }
            }
            ctrol.agregarUsuario(dictionary);
            MessageBox.Show("Usuario Creado Correctamente");
        }

        public void guardarInventario(Form child)
        {
            ControladorInventario ctriv = new ControladorInventario();
            var dictionary = new Dictionary<string, string>();
            List<string> columns = this.ctrNav.getColumns("tbl_INVENTARIO");

            foreach (Control c in child.Controls)
            {
                if (c is TextBox)
                {
                    string tag = c.Tag.ToString();
                    if (columns.Contains(tag))
                    {
                        dictionary.Add(tag, c.Text);
                    }
                    c.Text = "";
                }
                else if (c is DateTimePicker)
                {
                    string tag = c.Tag.ToString();
                    if (columns.Contains(tag))
                    {

                        DateTimePicker dateTimePicker = c as DateTimePicker;
                        DateTime fechaHora = dateTimePicker.Value;
                        dictionary.Add(tag, fechaHora.ToString("yyyy-MM-dd"));
                    }
                }
            }
            ctriv.agregarInventario(dictionary);
            MessageBox.Show("INVENTARIO GUARDADO");
        }

        public void guardarEmpleadoNom(Form child)
        {
            ControladorNomina ctrolnom = new ControladorNomina();
            var dictionary = new Dictionary<string, string>();
            List<string> columns = this.ctrNav.getColumns("tbl_nomina");

            foreach (Control c in child.Controls)
            {
                if (c is TextBox)
                {
                    string tag = c.Tag.ToString();
                    if (columns.Contains(tag))
                    {
                        dictionary.Add(tag, c.Text);
                    }
                    c.Text = "";
                }
            }
            ctrolnom.agregarEmpleadoNomina(dictionary);
            MessageBox.Show("Empleado Agregado a Nomina");
        }
        public void guardarEmpleado(Form child)
        {
            ControladorEmpleado cEmple = new ControladorEmpleado();
            var dictionary = new Dictionary<string, string>();
            List<string> columns = this.ctrNav.getColumns("tbl_empleado");

            foreach (Control c in child.Controls)
            {
                if (c is TextBox)
                {
                    string tag = c.Tag.ToString();
                    if (columns.Contains(tag))
                    {
                        dictionary.Add(tag, c.Text);
                    }
                    c.Text = "";
                }
            }
            cEmple.agregarEmpleado(dictionary);
            MessageBox.Show("Empleado Creado Correctamente");
        }

    }
}
