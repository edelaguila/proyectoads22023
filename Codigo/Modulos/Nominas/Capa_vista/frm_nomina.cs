using System;
using Controlador_PrototipoMenu;
using Modelo_PrototipoMenu;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista_PrototipoMenu
{
    public partial class frm_nomina : Form
    {
        Controlador ctrl = new Controlador();
        public frm_nomina()
        {
            InitializeComponent();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txt_id_empleado.Text, out int idEmpleado))
                {
                    Empleado empleadoEncontrado = ctrl.BuscarEmpleadoPorID(idEmpleado);
                    string departamentoEncontrado = ctrl.ObtenerDepartamento(idEmpleado);
                    string deduccionTotalEncontrada = ctrl.ObtenerDeduccionTotal(idEmpleado);
                    string percepcionTotalEncontrada = ctrl.ObtenerPercepcionTotal(idEmpleado);

                    if (empleadoEncontrado != null)
                    {
                        foreach (Control control in groupBox3.Controls)
                        {
                            if (control is TextBox)
                            {
                                TextBox textBox = (TextBox)control;
                                if (textBox.Tag != null && textBox.Tag.ToString() != "")
                                {
                                    string campo = textBox.Tag.ToString();
                                    if (campo == "emp_nombre")
                                    {
                                        textBox.Text = empleadoEncontrado.Nombre;
                                    }
                                    else if (campo == "emp_apellido")
                                    {
                                        textBox.Text = empleadoEncontrado.Apellido;
                                    }
                                    else if (campo == "emp_sueldo")
                                    {
                                        textBox.Text = empleadoEncontrado.Sueldo;
                                    }
                                    else if (campo == "emp_cargo")
                                    {
                                        textBox.Text = empleadoEncontrado.Cargo;
                                    }
                                    else if (campo == "emp_tipo_moneda")
                                    {
                                        textBox.Text = empleadoEncontrado.Moneda;
                                    }
                                    else if (campo == "tbl_departamento_Pk_id_departamento")
                                    {
                                        textBox.Text = departamentoEncontrado;
                                    }
                                    else if (campo == "tbl_empleado_Pk_id_empleado")  // Corrección aquí
                                    {
                                        textBox.Text = deduccionTotalEncontrada; // Asignar el total de deducciones
                                    }
                                    else if (campo == "tbl_empleado_Pk_id_empleado")
                                    {
                                        textBox.Text = percepcionTotalEncontrada;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Empleado no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("ID de empleado no válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
