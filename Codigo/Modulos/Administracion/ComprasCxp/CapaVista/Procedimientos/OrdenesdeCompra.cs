﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;

namespace CapaVista.Procedimientos
{
    public partial class OrdenesdeCompra : Form
    {
        private Controlador controller;
        public OrdenesdeCompra(string id, string nombre, string domicilio, string telefono)
        {
            InitializeComponent();
            controller = new Controlador();
            llenarse();
            controller.CargarOpciones2(cmb_orden);
            txt_idProv.Text = id;
            txt_nombreProv.Text = nombre;
            txt_domicilioProv.Text = domicilio;
            txt_telefonoProv.Text = telefono;
        }

        private void cmb_orden_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccion = cmb_orden.SelectedItem.ToString();

            // Si se selecciona "Directa", deshabilitar botones para buscar proveedor
            if (seleccion == "Directa")
            {
                btn_buscarProveedor.Enabled = false;
                txt_idProv.Enabled = true;
                btn_buscarProveedor.Enabled = false;
                txt_nombreProv.Enabled = true;
                txt_domicilioProv.Enabled = true;
                txt_telefonoProv.Enabled = true;
                txt_departamentos.Enabled = true;
                dateTimePickerEntrega.Enabled = true;
                dateTimePickerPedido.Enabled = true;
                txt_entregara.Enabled = true;
            }

            // Si se selecciona "Relacionada", deshabilitar TextBox para ingresar directamente
            if (seleccion == "Relacionada")
            {
                btn_buscarProveedor.Enabled = true;
                txt_idProv.Enabled = false;
                txt_nombreProv.Enabled = false;
                txt_telefonoProv.Enabled = false;
                txt_domicilioProv.Enabled = false;
                txt_departamentos.Enabled = true;
                dateTimePickerEntrega.Enabled = true;
                dateTimePickerPedido.Enabled = true;
                txt_entregara.Enabled = true;
            }
        }

        private void btn_buscarProveedor_Click(object sender, EventArgs e)
        {
            //instrucciones para mostrar un formulario que esta dentro de la misma carpeta que este form
            BuscarProveedor BuscarProveedor = new BuscarProveedor(this);
            BuscarProveedor.Show();
        }

        public void RecibirDatosDesdeBuscarProveedor(string id, string nombre, string domicilio, string telefono)
        {
            // Actualiza los textbox en del formulario con los datos recibidos
            txt_idProv.Text = id;
            txt_nombreProv.Text = nombre;
            txt_domicilioProv.Text = domicilio;
            txt_telefonoProv.Text = telefono;
        }

        private void OrdenesdeCompra_Load(object sender, EventArgs e)
        {
            string tabla = "tbl_ordenescompra";
            string campoid = "ord_id";
            txt_numeroorden.Enabled = false;
            txt_idProv.Enabled = false;
            btn_buscarProveedor.Enabled = false;
            txt_nombreProv.Enabled = false;
            txt_domicilioProv.Enabled = false;
            txt_telefonoProv.Enabled = false;
            txt_departamentos.Enabled = false;
            dateTimePickerEntrega.Enabled = false;
            dateTimePickerPedido.Enabled = false;
            txt_entregara.Enabled = false;
            int ultimoNumeroOrden = controller.ObtenerUltimoNumeroOrden(campoid, tabla);
            txt_numeroorden.Text = ultimoNumeroOrden.ToString();
        }

        public void llenarse()
        {
            cmb_productos.ValueMember = "numero";
            cmb_productos.DisplayMember = "nombre";

            string[] items = controller.items();

            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] != null)
                {
                    if (items[i] != "")
                    {
                        cmb_productos.Items.Add(items[i]);
                    }
                }

            }
            //Funciona para buscar en el combobox
            var dt2 = controller.enviar();
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (DataRow row in dt2.Rows)
            {

                coleccion.Add(Convert.ToString(row["id_producto"]) + "-" + Convert.ToString(row["pro_nombre"]));
                coleccion.Add(Convert.ToString(row["pro_nombre"]) + "-" + Convert.ToString(row["id_producto"]));
            }
            cmb_productos.AutoCompleteCustomSource = coleccion;
            cmb_productos.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmb_productos.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void cmb_productos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el ID del producto que seleccionó el usuario
            string selectedValue = cmb_productos.SelectedItem.ToString();

            // Divide la cadena para tener ambos campos
            string[] parts = selectedValue.Split('-');
            string selectedProductId = parts[0].Trim();

            // Llamar a la capa controlador a su método ObtenerDescripción y ObtenerPrecioUnitario
            string descripcion = controller.ObtenerDescripcion(selectedProductId);
            decimal precioUnitario = controller.ObtenerPrecioUnitario(selectedProductId);

            // Llena los TextBox con la descripción y el precio unitario
            txt_descripcion.Text = descripcion;
            txt_preciou.Text = precioUnitario.ToString();

            //Pasa lo que está dentro de los text box a double para poder sacar el total de la fila
            double precioU = double.TryParse(txt_preciou.Text, out double precio) ? precio : 0.0;
            int cantidad = int.TryParse(txt_cantidad.Text, out int cant) ? cant : 0;
            double totalprod = precioU * cantidad;
            txt_totalfila.Text = totalprod.ToString();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            double precioU = 0;
            double cantidad = 0;
            double totalprod = 0;

            // Obtener el precio unitario desde el textbox
            if (double.TryParse(txt_preciou.Text, out precioU))
            {
                // Obtener la cantidad desde el textbox
                if (double.TryParse(txt_cantidad.Text, out cantidad))
                {
                    // Calcular el total del producto
                    totalprod = precioU * cantidad;

                    // Obtener el ID del producto seleccionado en el ComboBox
                    string productoSeleccionado = cmb_productos.SelectedItem.ToString();
                    string[] parts = productoSeleccionado.Split('-');
                    string idProducto = parts[0].Trim();
                    //Obtener el nombre del producto
                    string nomProducto = parts[1].Trim();
                    //Obtener la descripcion del producto
                    string descripcion = txt_descripcion.Text;
                    // Agregar una fila al DataGridView con los detalles
                    dgv_detalle.Rows.Add(cantidad, idProducto, nomProducto, descripcion, precioU, totalprod);
                    //Limpiar los textbox para poder ingresar uno nuevo
                    txt_cantidad.Text = "";
                    cmb_productos.Text = "";
                    txt_descripcion.Text = "";
                    txt_preciou.Text = "";
                    txt_totalfila.Text = "";
                }
                else
                {
                    MessageBox.Show("Ingrese una cantidad válida.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un precio unitario válido.");
            }
        }
    }
}