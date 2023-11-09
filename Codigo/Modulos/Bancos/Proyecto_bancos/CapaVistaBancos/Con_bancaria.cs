using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CapaControladorBancos;

namespace CapaVistaBancos
{
    public partial class Con_bancaria : Form
    {
        ControladorBanco cn = new ControladorBanco();
        string mov = "tbl_movimientosbancarios";
        public Con_bancaria()
        {
            InitializeComponent();
        }

        public void actualizardatagridView()
        {
            DataTable dt = cn.llenarTbl(mov);
            dgv_movimientos_conciliacion.DataSource = dt;

        }


        private void btn_salir_dispo_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btn_asignar_Click(object sender, EventArgs e)
        {
            //ASIGNACION DE VALOR EN LABEL.
            string strSaldoInicial = txt_saldoinicial.Text;
            int bandera = 0;
            if (strSaldoInicial.Equals("") || strSaldoInicial.Equals(" "))
            {
                MessageBox.Show("Para continuar por favor ingrese un saldo inicial");
            }
            else
            {
                for (int i = 0; i < strSaldoInicial.Length; i++)
                {


                    if (strSaldoInicial.Substring(i, 1).Equals("."))
                    {
                        lbl_valbanco.Text = (txt_saldoinicial.Text.ToString());
                        bandera = 1;
                        Habilitar();
                        CargardgvMovimientos();
                        i = strSaldoInicial.Length + 2;
                    }
                }

                if (bandera != 1)
                {
                    lbl_valbanco.Text = (txt_saldoinicial.Text.ToString() + ".00");
                    Habilitar();
                    CargardgvMovimientos();
                }
            }
            decimal saldoTotal = cn.ObtenerSaldoTotal();
            lbl_vallibro.Text = saldoTotal.ToString();
            //CONFIGURACION DE DIFERENCIA.
            DiferenciaLbl();


        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Deshabilitar();
        }

        public void Habilitar()
        {
            txt_transaccion.Enabled = true;
            txt_valor.Enabled = true;
            txt_cuenta.Enabled = true;
            txt_fecha.Enabled = true;
            txt_tipo_pago.Enabled = true;
            dgv_conciliado.Enabled = true;
            dgv_movimientos_conciliacion.Enabled = true;
            btn_conciliar.Enabled = true;
            btn_cancelar.Enabled = true;

            txt_saldoinicial.Enabled = false;
            btn_asignar.Enabled = false;

            txt_transaccion.Focus();
        }

        public void Deshabilitar()
        {
            //bloquea los componentes
            txt_transaccion.Enabled = false;
            txt_valor.Enabled = false;
            txt_cuenta.Enabled = false;
            txt_fecha.Enabled = false;
            txt_tipo_pago.Enabled = false;
            dgv_conciliado.Enabled = false;
            dgv_movimientos_conciliacion.Enabled = false;
            btn_conciliar.Enabled = false;
            btn_cancelar.Enabled = false;

            btn_asignar.Enabled = true;

            //limpia los componentes
            txt_transaccion.Clear();
            txt_valor.Clear();
            txt_fecha.Clear();
            txt_tipo_pago.Clear();
            txt_cuenta.Clear();
            dgv_movimientos_conciliacion.DataSource = null;
            dgv_conciliado.DataSource = null;

            txt_saldoinicial.Clear();
            lbl_valbanco.Text = "0.00";
            lbl_vallibro.Text = "0.00";
            lbl_diferencia.Text = "0.00";

            //Limpiza y foco a saldo inicial

            txt_saldoinicial.Enabled = true;
            txt_saldoinicial.Focus();

        }

        public void CargardgvMovimientos()
        {
            actualizardatagridView();

            dgv_movimientos_conciliacion.Columns[0].HeaderText = "ID";
            dgv_movimientos_conciliacion.Columns[1].HeaderText = "Valor";
            dgv_movimientos_conciliacion.Columns[2].HeaderText = "Descripcion";
            dgv_movimientos_conciliacion.Columns[3].HeaderText = "Numero de cuenta";
            dgv_movimientos_conciliacion.Columns[4].HeaderText = "Transaccion";
            dgv_movimientos_conciliacion.Columns[5].HeaderText = "Estatus";
            dgv_movimientos_conciliacion.Columns[6].HeaderText = "Fecha de ingreso";
        }

        public void DiferenciaLbl()
        {
            double lblvbanco = Convert.ToDouble(lbl_valbanco.Text);
            double lblvlibro = Convert.ToDouble(lbl_vallibro.Text);
            lbl_diferencia.Text = (lblvbanco - lblvlibro).ToString();
        }


        private void btn_cancelar_Click_1(object sender, EventArgs e)
        {
            Deshabilitar();
        }



        private void dgv_movimientos_conciliacion_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(this.dgv_movimientos_conciliacion.SelectedRows[0].Cells[0].Value);
                double dblvalor = Convert.ToDouble(this.dgv_movimientos_conciliacion.SelectedRows[0].Cells[1].Value);
                int cuenta = Convert.ToInt32(this.dgv_movimientos_conciliacion.SelectedRows[0].Cells[4].Value);
                string tipo = Convert.ToString(this.dgv_movimientos_conciliacion.SelectedRows[0].Cells[5].Value);
                string fecha = Convert.ToString(this.dgv_movimientos_conciliacion.SelectedRows[0].Cells[7].Value);

                txt_transaccion.Text = id.ToString();
                txt_valor.Text = dblvalor.ToString();
                txt_cuenta.Text = cuenta.ToString();
                txt_tipo_pago.Text = tipo.ToString();
                txt_fecha.Text = fecha.Substring(0, 9).ToString();
            }
            catch (Exception)
            {

                return;
            }
        }

        private void btn_conciliar_Click(object sender, EventArgs e)
        {

        }
    }
}
