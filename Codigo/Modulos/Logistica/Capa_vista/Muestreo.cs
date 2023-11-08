using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Controlador_PrototipoMenu;

namespace Vista_PrototipoMenu
{
    public partial class Muestreo : Form
    {
        public Muestreo()
        {
            InitializeComponent();
        }

        Controlador_PrototipoMenu.ControladorInventario crud = new Controlador_PrototipoMenu.ControladorInventario();
        private void button2_Click(object sender, EventArgs e)
        {
            bool resultado = crud.UpdateMues(txt_id.Text, txtNumero.Text, dateTimePicker1.Text, dateTimePicker2.Text, txtMantenimiento.Text, txtInventario.Text, cboServicios.Text, txtSeguridad.Text, txtEstado.Text);
            if (resultado)
            {
                dataGridView1.Rows.Add(new object[] { txt_id.Text, txtNumero.Text, dateTimePicker1.Text, dateTimePicker2.Text, txtMantenimiento.Text, txtInventario.Text, cboServicios.Text, txtSeguridad.Text, txtEstado.Text });
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            String col = "";
            String data = "";
            if (string.IsNullOrEmpty(txt_id.Text))
            {
                if (string.IsNullOrEmpty(txtNumero.Text))
                {
                    if (string.IsNullOrEmpty(dateTimePicker1.Text))
                    {
                        if (string.IsNullOrEmpty(dateTimePicker2.Text))
                        {
                            if (string.IsNullOrEmpty(txtMantenimiento.Text))
                            {
                                if (string.IsNullOrEmpty(txtInventario.Text))
                                {
                                    if (string.IsNullOrEmpty(cboServicios.Text))
                                    {
                                        if (string.IsNullOrEmpty(txtSeguridad.Text))
                                        {
                                            if (string.IsNullOrEmpty(txtEstado.Text))
                                            {
                                                String textalert = " El campo buscar, se encuentra vacio. Debe llenar un solo campo para realizar la busqueda";
                                                MessageBox.Show(textalert);
                                            }
                                            else
                                            {
                                                data = txtEstado.Text;
                                                col = "Estado";
                                            }
                                        }
                                        else
                                        {
                                            data = txtSeguridad.Text;
                                            col = "Seguridad";
                                        }
                                    }
                                    else
                                    {
                                        data = cboServicios.Text;
                                        col = "Servicios";
                                    }
                                }
                                else
                                {
                                    data = txtInventario.Text;
                                    col = "Inventario";
                                }
                            }
                            else
                            {
                                data = txtMantenimiento.Text;
                                col = "Mantenimiento";
                            }
                        }
                        else
                        {
                            data = dateTimePicker2.Text;
                            col = "fecha de salida";
                        }
                    }
                    else
                    {
                        data = dateTimePicker1.Text;
                        col = "Fecha de entrada";
                    }
                }
                else
                {
                    data = txtNumero.Text;
                    col = "Numero de Habitacion";
                }
            }
            else
            {
                data = txt_id.Text;
                col = "ID";
            }

            DataTable dt = new DataTable();
            //crud.BuscarProducto(data, col, dt);
            crud.BuscarDato(data, col, dt);
            dataGridView1.DataSource = dt;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string table = "";
            DataTable dt = new DataTable();
            table = "tbl_muestreo";
            crud.Actualizarmues(table, dt);
            dataGridView1.DataSource = dt;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bool resultado = crud.DeleteMues(txt_id.Text);
            if (resultado)
            {
                dataGridView1.Rows.Add(new object[] { txt_id.Text });
            }
        }
    }
}
