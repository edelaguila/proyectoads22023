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
                    if (c.Text.Equals(""))
                    {
                        MessageBox.Show("Debe llenar todos los campos para poder guardar");
                        return;
                    }

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


        public void refrescar(Form child)
        {
            Controlador ctriv = new Controlador();
            ctriv.setTabla(this.tabla);

            bool refrescadoExitosamente = false; // Bandera para saber si se refrescó con éxito

            foreach (Control c in child.Controls)
            {
                if (c is DataGridView)
                {
                    try
                    {
                        ((DataGridView)c).DataSource = ctriv.refrescar();
                        MessageBox.Show("Refrescado");
                        refrescadoExitosamente = true; // Si no hubo excepción, se refrescó con éxito
                    }
                    catch (Exception ex) // Captura el error
                    {
                        // Si llegamos aquí, ocurrió un error durante el refrescamiento
                        MessageBox.Show("Error al refrescar. Detalles: " + ex.Message);
                    }
                }
            }

            // Si no se refrescó con éxito, mostrar el mensaje "No hay tabla"
            if (!refrescadoExitosamente)
            {
                MessageBox.Show("No hay tabla en este formulario");
            }
        }

        public void cargarModificar(Form child, DataGridView dgvname)
        {
            try
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
                        if (c is DateTimePicker dateTimePicker && dateTimePicker.Tag != null)
                        {
                            string columnName = dateTimePicker.Tag.ToString();
                            int columnIndex = dgvname.Columns[columnName].Index;

                            DateTime cellValue = (DateTime)selectedRow.Cells[columnIndex].Value;
                            dateTimePicker.Value = cellValue;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Fila sin datos o tabla faltante");
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
            ctriv.modificar(dictionary, pk, id);
            MessageBox.Show("MODIFICANDO");

        }

        //Carol Chuy
        public void eliminar(Form child, DataGridView dgvname)
        {

            if (dgvname == null)
            {
                // Si no existe un datagridview mostrar este mensaje
                MessageBox.Show("No se puede realizar esta acción en este formulario porque no existe una tabla de datos");
                return; // Salir del método

            }
            else
            {

                Controlador ctriv = new Controlador();
                if (dgvname.SelectedRows.Count > 0)
                {
                    if (dgvname.SelectedRows.Count > 1)
                    {
                        MessageBox.Show("Seleccionar únicamente un fila por favor");
                        return;
                    }

                    // Obtener la primera fila seleccionada
                    DataGridViewRow selectedRow = dgvname.SelectedRows[0];

                    // Obtiene el valor de la primera celda de esa fila y la convierte a entero
                    if (selectedRow.Cells[0].Value != null)
                    {
                        if (MessageBox.Show("¿Esta seguro que desea eliminar este registro?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int llave = Convert.ToInt32(selectedRow.Cells[0].Value);
                            string campo = dgvname.Columns[0].HeaderText;
                            ctriv.setTabla(this.tabla);
                            ctriv.eliminar(campo, llave);
                            MessageBox.Show("Registro Eliminado Exitosamente");
                        }
                    }
                    else
                    {
                        MessageBox.Show("La fila seleccionada está vacía, por favor elegir otra para realizar esta acción");
                    }
                }
                else
                {
                    // Manejar el caso en el que no hay filas seleccionadas
                    MessageBox.Show("No hay ninguna fila seleccionada, por favor seleccionar la fila  del registro que desea eliminar");
                }
            }
        }


    }
}
