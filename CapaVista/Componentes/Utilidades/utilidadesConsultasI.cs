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
        public Controlador ctrl;
        public string tabla = "andrea";
        public utilidadesConsultasI(ControladorNavegador ctrlNav)
        {
            this.ctrl = new Controlador();
        }
        public utilidadesConsultasI()
        {
        }

        public void setTabla(string tabla)
        {
            this.tabla = tabla;
            this.ctrl.setTabla(tabla);
        }

        public void guardar(Form child)
        {
            this.guardarInventario(child);
        }




        public void guardarInventario(Form child)
        {
            Controlador ctriv = new Controlador();
            var dictionary = new Dictionary<string, string>();
            List<string> columns = this.ctrl.getColumns(this.tabla);

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
            ctriv.setTabla(this.tabla);
            ctriv.guardar(dictionary);
            MessageBox.Show("INVENTARIO GUARDADO");
        }

    }
}
