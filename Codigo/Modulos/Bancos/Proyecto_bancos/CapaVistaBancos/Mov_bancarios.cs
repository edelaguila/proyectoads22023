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
    public partial class Mov_bancarios : Form
    {
        ControladorBanco cn = new ControladorBanco();
        string mov = "tbl_movimientosbancarios";
        public Mov_bancarios()
        {
            InitializeComponent();
            actualizardatagridView();

            dgv_vistaTransacciones.Columns[0].HeaderText = "ID";
            dgv_vistaTransacciones.Columns[1].HeaderText = "Valor";
            dgv_vistaTransacciones.Columns[2].HeaderText = "Descripcion";
            dgv_vistaTransacciones.Columns[3].HeaderText = "Numero de cuenta";
            dgv_vistaTransacciones.Columns[4].HeaderText = "Transaccion";
            dgv_vistaTransacciones.Columns[5].HeaderText = "Estatus";
            dgv_vistaTransacciones.Columns[6].HeaderText = "Fecha de ingreso";
        }

        private void btn_salir_dispo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_vistaTransacciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void actualizardatagridView()
        {
            DataTable dt = cn.llenarTbl(mov);
           dgv_vistaTransacciones.DataSource = dt;

        }
        private void Mov_bancarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet3.tbl_mantenimientos_tipo_movimiento' Puede moverla o quitarla según sea necesario.
            //this.tbl_mantenimientos_tipo_movimientoTableAdapter2.Fill(this.dataSet3.tbl_mantenimientos_tipo_movimiento);
            // TODO: esta línea de código carga datos en la tabla 'dataSet2.tbl_mantenimientos_tipo_movimiento' Puede moverla o quitarla según sea necesario.
            this.tbl_mantenimientos_tipo_movimientoTableAdapter1.Fill(this.dataSet2.tbl_mantenimientos_tipo_movimiento);

        }

        private void btn_rtrans_Click(object sender, EventArgs e)
        {
            string estado = "1";
            DialogResult result = MessageBox.Show("¿Desea guardar el archivo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question); //OTTO ADRIAN LOPEZ VENTURA 0901-20-1069 

            if (result == DialogResult.Yes) 
            {
                //LUIS ALBERTO FRANCO MORAN 0901-20-23979
                // Llamar al Controlador para insertar el movimiento en la base de datos
                cn.InsertarMovimiento(txt_valorTransferencia.Text, txt_descripcionTransferencia.Text, txt_numeroCuenta.Text, txt_ttransaccion.Text, estado);

                // Actualizar el DataGridView con los datos actualizados
                actualizardatagridView();

                // Limpiar los TextBox
                txt_ttransaccion.Clear();
                txt_estado.Clear();
                txt_numeroCuenta.Clear();
                txt_valorTransferencia.Clear();
                txt_descripcionTransferencia.Clear();


                // Mostrar un mensaje de éxito
                MessageBox.Show("Movimiento realizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //LUIS ALBERTO FRANCO MORAN 0901-20-23979
                // Limpiar los TextBox si el usuario elige "No"
                txt_numeroCuenta.Clear();
                txt_valorTransferencia.Clear();
                txt_descripcionTransferencia.Clear();

                // Mostrar un mensaje informativo
                MessageBox.Show("No se guardó el archivo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);//OTTO ADRIAN LOPEZ VENTURA 0901-20-1069 
            }
        }
    }
}
