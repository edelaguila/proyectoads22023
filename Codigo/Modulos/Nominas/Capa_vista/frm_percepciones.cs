using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador_PrototipoMenu;
using Modelo_PrototipoMenu;
using System.Data.Odbc;

namespace CapaVistaNomina
{
    public partial class frm_percepciones : Form
    {
        Controlador ctrl = new Controlador();
        string tabla = "tbl_dedu_perc";
        int movimiento = 2;

        public void llenar()
        {
            DataTable dt = ctrl.llenartablaMov(tabla, movimiento);
            dataGridView1.DataSource = dt;

        }

        public frm_percepciones()
        {
            InitializeComponent();
            this.ctrl = new Controlador();
            llenar();
            LlenarComboBoxDeduPerc();




        }

        private void frm_deduccion_percepciones_Load(object sender, EventArgs e)
        {

        }



        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txt_id_empleado.Text, out int idEmpleado))
                {
                    Empleado empleadoEncontrado = ctrl.BuscarEmpleadoPorID(idEmpleado);
                    string departamentoEncontrado = ctrl.ObtenerDepartamento(idEmpleado);

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
                MessageBox.Show("Error" + ex);
            }
        }


        double percepcionTotal = 0.0;

        private Dictionary<string, double> tasasPercepciones = new Dictionary<string, double>
{
        { "Bono", 0.10 }, // Ejemplo: un bono del 10% del sueldo base
        { "Horas Extras", 0.20 }, // Ejemplo: 20% del sueldo base para horas extras
        { "Incentivos", 0.05 }, // Ejemplo: 5% del sueldo base como incentivo
        { "Gratificaciones", 0.15 }, // Ejemplo: 15% del sueldo base como gratificación
        { "Pagos de Vacaciones", 0.25 }, // Ejemplo: 25% del sueldo base como pago de vacaciones
        
};

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            try
            {
                decimal sueldo = Convert.ToDecimal(txt_sueldoB_empleado.Text);
                string percepcionSeleccionada = comboBoxperc.SelectedValue.ToString();

                if (tasasPercepciones.ContainsKey(percepcionSeleccionada))
                {
                    double tasa = tasasPercepciones[percepcionSeleccionada];
                    decimal percepcion = sueldo * (decimal)tasa;


                    percepcionTotal += (double) percepcion;
                    txt_percepcion_total.Text = percepcionTotal.ToString("N5");
                }
                else
                {
                    MessageBox.Show("La percepción seleccionada no está en la lista de tasas.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }






        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            int idPercepcion = int.Parse(txt_id_percepcion.Text);
            string descripcion = txt_percepcion_descripcion.Text;
            double monto = double.Parse(txt_percepcion_valor.Text);
            int movimiento = 1;


            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dataGridView1);

            row.Cells[0].Value = idPercepcion;
            row.Cells[1].Value = descripcion;
            row.Cells[2].Value = monto;
            row.Cells[3].Value = movimiento;

            dataGridView1.Rows.Add(row);
            txt_id_percepcion.Clear();
            txt_percepcion_descripcion.Clear();
            txt_percepcion_valor.Clear();
        }

        private void btn_guardar_percepcion_Click(object sender, EventArgs e)
        {
            try { 
            int idEmpleado = Convert.ToInt32(txt_id_percepcion.Text);
            string dedperc_nombre = txt_percepcion_descripcion.Text;
            float dedperc_monto = Convert.ToSingle(txt_percepcion_valor.Text);
            int dedperc_movimiento = 2;

            txt_id_percepcion.Clear();
            txt_percepcion_descripcion.Clear();
            txt_percepcion_valor.Clear();

            ctrl.InsertarPercepcion(idEmpleado, dedperc_nombre, dedperc_monto, dedperc_movimiento);
            dataGridView1.Refresh();
            llenar();
            LlenarComboBoxDeduPerc();
            }
            catch(Exception ex)
            {
                MessageBox.Show("id duplicada" + ex);
            }
        }

        private void LlenarComboBoxDeduPerc()
        {
            DataTable deduPercionesData = ctrl.ObtenerDatosPerc();

            if (deduPercionesData != null)
            {
                comboBoxperc.DataSource = deduPercionesData;
                comboBoxperc.DisplayMember = "dedperc_nombre";
                comboBoxperc.ValueMember = "dedperc_nombre";
            }
            else
            {
                MessageBox.Show("Error al cargar datos de las percepciones en el combobox");
            }
        }

        private void btn_Guardar_calculo_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_id_empleado.Text, out int idEmpleado) &&
             DateTime.TryParse(dateTimePicker1.Text, out DateTime fecha) &&
             double.TryParse(txt_percepcion_total.Text, out double percepcionTotal))

            {

                string percepciontotal = percepcionTotal.ToString("N5");
                Sentencias sentencias = new Sentencias();
                sentencias.GuardarPercepcionTotal(idEmpleado, fecha, percepciontotal);
                MessageBox.Show("Datos guardados con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Los valores ingresados no son válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_id_empleado_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void btn_Guardar_calculo_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_percepcion_total_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


    

