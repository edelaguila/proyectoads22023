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
        public void limpiardatagridView()
        {
            DataTable dt = cn.llenarTbl(mov);
            dt.Rows.Clear();
            dgv_movimientos_conciliacion.Refresh();
        }
        private void Con_bancaria_Load(object sender, EventArgs e)
        {

        }

        private void btn_salir_dispo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_asignar_Click(object sender, EventArgs e)
        {

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
                        lbl_valbanco.Text = ("Q." + txt_saldoinicial.Text.ToString());
                        bandera = 1;
                        Habilitar();
                        CargardgvMovimientos();
                        i = strSaldoInicial.Length + 2;
                    }
                }

                if (bandera != 1)
                {
                    lbl_valbanco.Text = ("Q." + txt_saldoinicial.Text.ToString() + ".00");
                    Habilitar();
                    CargardgvMovimientos();
                }
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Deshabilitar();
        }

        public void Habilitar()
        {
            txt_transaccion.Enabled = true;
            txt_valor.Enabled = true;
            cb_cuenta.Enabled = true;
            txt_banco.Enabled = true;
            cb_tipo_pago.Enabled = true;
            rb_correcta.Enabled = true;
            rb_incorrecta.Enabled = true;
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
            cb_cuenta.Enabled = false;
            txt_banco.Enabled = false;
            cb_tipo_pago.Enabled = false;
            rb_correcta.Enabled = false;
            rb_incorrecta.Enabled = false;
            dgv_conciliado.Enabled = false;
            dgv_movimientos_conciliacion.Enabled = false;
            btn_conciliar.Enabled = false;
            btn_cancelar.Enabled = false;

            btn_asignar.Enabled = true;

            //limpia los componentes
            txt_transaccion.Clear();
            txt_valor.Clear();
            txt_banco.Clear();
            cb_tipo_pago.SelectedIndex = -1;
            cb_cuenta.SelectedIndex = -1;
            dgv_conciliado.Rows.Clear();

            txt_saldoinicial.Clear();
            lbl_valbanco.Text = "0.00";

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

        private void btn_conciliar_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click_1(object sender, EventArgs e)
        {
            Deshabilitar();
        }
    }
}
