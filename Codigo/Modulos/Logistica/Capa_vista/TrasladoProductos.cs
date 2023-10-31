﻿using System;
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
    public partial class TrasladoProductos : Form
    {
        public TrasladoProductos()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            // BOTON ACEPTAR, PARA MANDAR LOS DATOS DE LOS TXT AL DATAGRIDVIEW
            // Justin Emmanuel Ramos Pennant

            // Obtén los valores de los TextBox
            string valor1 = txt_idDoc.Text;
            string valor2 = txt_nombreDoc.Text;
            string valor3 = txt_destino.Text;
            string valor4 = txt_fecha.Text;
            string valor5 = txt_idProc.Text;
            string valor6 = txt_nombreProc.Text;
            string valor7 = txt_almacen.Text;
            string valor8 = txt_bodega.Text;
            string valor9 = txt_cantidad.Text;
            string valor10 = txt_costoTotal.Text;
            string valor11 = txt_precioTotal.Text;
            string valor12 = txt_precioUnit.Text;

            // Añade los valores al DataGridView
            dgv_traslaProd.Rows.Add(valor1, valor2, valor3, valor4, valor5, valor6, valor7, valor8, valor9, valor10, valor11, valor12);

            // Limpia los TextBox después de agregar los datos al DataGridView
            txt_idDoc.Text = "";
            txt_nombreDoc.Text = "";
            txt_destino.Text = "";
            txt_fecha.Text = "";
            txt_idProc.Text = "";
            txt_nombreProc.Text = "";
            txt_almacen.Text = "";
            txt_bodega.Text = "";
            txt_cantidad.Text = "";
            txt_costoTotal.Text = "";
            txt_precioTotal.Text = "";
            txt_precioUnit.Text = "";
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            // BOTON ACEPTAR, PARA MANDAR LOS DATOS DE LOS TXT AL DATAGRIDVIEW
            // Justin Emmanuel Ramos Pennant

            // Verifica si hay al menos una fila seleccionada en el DataGridView
            if (dgv_traslaProd.SelectedRows.Count > 0)
            {
                // Recorre las filas seleccionadas en reversa para evitar problemas con los índices
                for (int i = dgv_traslaProd.SelectedRows.Count - 1; i >= 0; i--)
                {
                    dgv_traslaProd.Rows.RemoveAt(dgv_traslaProd.SelectedRows[i].Index);
                }
            }
            else
            {
                // Muestra un mensaje si no se ha seleccionado ninguna fila
                MessageBox.Show("Seleccione uno o varios datos antes de remover", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}