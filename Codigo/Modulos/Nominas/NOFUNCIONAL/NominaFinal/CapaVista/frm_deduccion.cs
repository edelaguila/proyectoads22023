using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControladorNomina;
using CapaModeloNomina;


namespace CapaVista
{
    public partial class frm_deduccion : Form
    {

        Controlador ctrl = new Controlador();

        public frm_deduccion()
        {
            InitializeComponent();
            this.ctrl = new Controlador();
          


        }

        private void frm_deduccion_percepciones_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_id_empleado.Text, out int idEmpleado))
            {
                Empleado empleadoEncontrado = ctrl.BuscarEmpleadoPorID(idEmpleado);

                if (empleadoEncontrado != null)
                {
                   
                    foreach (Control control in this.Controls)
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
                                else if (campo == "cargo")
                                {
                                    textBox.Text = empleadoEncontrado.Cargo;
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

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            try
            {
                decimal sueldo = Convert.ToDecimal(txt_sueldoB_empleado.Text);
                int cargo = Convert.ToInt32(txt_cargo_empleado.Text);
                float seguroPensiones = (float)Convert.ToDouble(txt_seguro_pensiones.Text);
                decimal seguroPensionesDecimal = (decimal)seguroPensiones;

                decimal isr = 0;
                decimal iggss = 0;

                if (sueldo <= 30000)
                {
                    isr = sueldo * 0.05M;
                }

                if (cargo == 2)
                {
                    isr = sueldo * 0.10M;
                    iggss = sueldo * 0.0483M;  
                }

                decimal seguroMedico = 500;

                decimal sueldoTotal = sueldo - isr - iggss - seguroPensionesDecimal - seguroMedico;

                txt_impuestos.Text = isr.ToString();
                txt_seguro_pensiones.Text = seguroPensiones.ToString();
                txt_seguro_medico.Text = seguroMedico.ToString();
                txt_sueldo_total.Text = sueldoTotal.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Llene todos los campos");
            }
        }
    }
}
