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
        DataGridViewRow selected = new DataGridViewRow();
        public utilidadesConsultasI()
        {
            this.ctrl = new Controlador();
        }

        public void setTabla(string tabla)
        {
            this.tabla = tabla;
            this.ctrl.setTabla(tabla);
        }






        public void guardar(Form child)
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

        public void cargarModificar(Form child, DataGridView dgvname)
        {
 
            if (dgvname.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvname.SelectedRows[0];
                selected = selectedRow;
                foreach (Control c in child.Controls)
                {
                    if (c is TextBox textBox && textBox.Tag != null)
                    {
                        string columnName = textBox.Tag.ToString();

                        int columnIndex = dgvname.Columns[columnName].Index;

                        textBox.Text = selectedRow.Cells[columnIndex].Value.ToString();
                    }
                }
            }
        }

        public void modificar(Form child) 
        {   
            Controlador ctriv = new Controlador();
            var dictionary = new Dictionary<string, string>();
            List<string> columns = this.ctrl.getColumns(this.tabla);
            string pk = selected.Cells[0].OwningColumn.HeaderText;
            int id = Convert.ToInt32(selected.Cells[0].Value);
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
            ctriv.modificar(dictionary,pk, id);
            MessageBox.Show("MODIFICANDO");

        }


        private string ObtenerDatoDesdeDataGridView(string tag, DataGridViewRow selectedRow)
        {
            throw new NotImplementedException();
        }

        
    }
}