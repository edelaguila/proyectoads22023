
namespace CapaVistaComprasCXP.Procedimientos
{
    partial class Compras
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compras));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.txt_notas = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.txt_iva = new System.Windows.Forms.TextBox();
            this.txt_subtotal = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.cmb_productos = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.dgv_detalle = new System.Windows.Forms.DataGridView();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_totalfila = new System.Windows.Forms.TextBox();
            this.txt_preciou = new System.Windows.Forms.TextBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_numcompra = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btn_numorden = new System.Windows.Forms.Button();
            this.cmb_orden = new System.Windows.Forms.ComboBox();
            this.txt_numorden = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_nombreprov = new System.Windows.Forms.TextBox();
            this.txt_entregara = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Idprov = new System.Windows.Forms.TextBox();
            this.dateTimePickerEntrega = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_domicilio = new System.Windows.Forms.TextBox();
            this.dateTimePickerPedido = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_telefonoprov = new System.Windows.Forms.TextBox();
            this.txt_departamentos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalle)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_enviar);
            this.groupBox3.Controls.Add(this.txt_notas);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.txt_total);
            this.groupBox3.Controls.Add(this.txt_iva);
            this.groupBox3.Controls.Add(this.txt_subtotal);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 599);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(803, 125);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Totales";
            // 
            // btn_enviar
            // 
            this.btn_enviar.Location = new System.Drawing.Point(711, 35);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(64, 43);
            this.btn_enviar.TabIndex = 29;
            this.btn_enviar.Text = "Enviar Compra";
            this.btn_enviar.UseVisualStyleBackColor = true;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // txt_notas
            // 
            this.txt_notas.Location = new System.Drawing.Point(55, 71);
            this.txt_notas.Name = "txt_notas";
            this.txt_notas.Size = new System.Drawing.Size(395, 21);
            this.txt_notas.TabIndex = 28;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(52, 40);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(144, 17);
            this.label18.TabIndex = 27;
            this.label18.Text = "Notas / Observaciones";
            // 
            // txt_total
            // 
            this.txt_total.Enabled = false;
            this.txt_total.Location = new System.Drawing.Point(576, 88);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(100, 21);
            this.txt_total.TabIndex = 26;
            // 
            // txt_iva
            // 
            this.txt_iva.Enabled = false;
            this.txt_iva.Location = new System.Drawing.Point(576, 57);
            this.txt_iva.Name = "txt_iva";
            this.txt_iva.Size = new System.Drawing.Size(100, 21);
            this.txt_iva.TabIndex = 25;
            // 
            // txt_subtotal
            // 
            this.txt_subtotal.Enabled = false;
            this.txt_subtotal.Location = new System.Drawing.Point(576, 25);
            this.txt_subtotal.Name = "txt_subtotal";
            this.txt_subtotal.Size = new System.Drawing.Size(100, 21);
            this.txt_subtotal.TabIndex = 24;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(492, 90);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 17);
            this.label16.TabIndex = 3;
            this.label16.Text = "Total";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(492, 57);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 17);
            this.label15.TabIndex = 2;
            this.label15.Text = "IVA";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(492, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 17);
            this.label14.TabIndex = 1;
            this.label14.Text = "Sub-Total";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_confirmar);
            this.groupBox2.Controls.Add(this.cmb_productos);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.btn_eliminar);
            this.groupBox2.Controls.Add(this.btn_agregar);
            this.groupBox2.Controls.Add(this.dgv_detalle);
            this.groupBox2.Controls.Add(this.txt_totalfila);
            this.groupBox2.Controls.Add(this.txt_preciou);
            this.groupBox2.Controls.Add(this.txt_descripcion);
            this.groupBox2.Controls.Add(this.txt_cantidad);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 320);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(803, 273);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Descripción de la compra";
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Location = new System.Drawing.Point(701, 209);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(74, 32);
            this.btn_confirmar.TabIndex = 13;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // cmb_productos
            // 
            this.cmb_productos.FormattingEnabled = true;
            this.cmb_productos.Location = new System.Drawing.Point(77, 64);
            this.cmb_productos.Name = "cmb_productos";
            this.cmb_productos.Size = new System.Drawing.Size(121, 24);
            this.cmb_productos.TabIndex = 12;
            this.cmb_productos.SelectedIndexChanged += new System.EventHandler(this.cmb_productos_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(105, 39);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(56, 17);
            this.label19.TabIndex = 11;
            this.label19.Text = "Nombre";
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(701, 162);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(74, 32);
            this.btn_eliminar.TabIndex = 10;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(701, 115);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(74, 32);
            this.btn_agregar.TabIndex = 9;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // dgv_detalle
            // 
            this.dgv_detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_detalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cantidad,
            this.ID_Producto,
            this.Nombre,
            this.Descripcion,
            this.Precio_unitario,
            this.Total});
            this.dgv_detalle.Location = new System.Drawing.Point(27, 103);
            this.dgv_detalle.Name = "dgv_detalle";
            this.dgv_detalle.Size = new System.Drawing.Size(649, 150);
            this.dgv_detalle.TabIndex = 8;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // ID_Producto
            // 
            this.ID_Producto.HeaderText = "ID_Producto";
            this.ID_Producto.Name = "ID_Producto";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // Precio_unitario
            // 
            this.Precio_unitario.HeaderText = "Precio_unitario";
            this.Precio_unitario.Name = "Precio_unitario";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // txt_totalfila
            // 
            this.txt_totalfila.Location = new System.Drawing.Point(491, 65);
            this.txt_totalfila.Name = "txt_totalfila";
            this.txt_totalfila.Size = new System.Drawing.Size(100, 21);
            this.txt_totalfila.TabIndex = 7;
            // 
            // txt_preciou
            // 
            this.txt_preciou.Location = new System.Drawing.Point(402, 65);
            this.txt_preciou.Name = "txt_preciou";
            this.txt_preciou.Size = new System.Drawing.Size(73, 21);
            this.txt_preciou.TabIndex = 6;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(204, 65);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(186, 21);
            this.txt_descripcion.TabIndex = 5;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(27, 65);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(43, 21);
            this.txt_cantidad.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(525, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 17);
            this.label13.TabIndex = 3;
            this.label13.Text = "Total";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(422, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 17);
            this.label12.TabIndex = 2;
            this.label12.Text = "P/U";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(246, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "Descripción";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(24, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Cant.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_numcompra);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.btn_numorden);
            this.groupBox1.Controls.Add(this.cmb_orden);
            this.groupBox1.Controls.Add(this.txt_numorden);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_nombreprov);
            this.groupBox1.Controls.Add(this.txt_entregara);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_Idprov);
            this.groupBox1.Controls.Add(this.dateTimePickerEntrega);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_domicilio);
            this.groupBox1.Controls.Add(this.dateTimePickerPedido);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_telefonoprov);
            this.groupBox1.Controls.Add(this.txt_departamentos);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(803, 302);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la compra";
            // 
            // txt_numcompra
            // 
            this.txt_numcompra.Location = new System.Drawing.Point(545, 31);
            this.txt_numcompra.Name = "txt_numcompra";
            this.txt_numcompra.Size = new System.Drawing.Size(100, 21);
            this.txt_numcompra.TabIndex = 31;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(415, 31);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(124, 17);
            this.label20.TabIndex = 30;
            this.label20.Text = "Numero de compra";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(105, 33);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 17);
            this.label17.TabIndex = 29;
            this.label17.Text = "Órden";
            // 
            // btn_numorden
            // 
            this.btn_numorden.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_numorden.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_numorden.BackgroundImage")));
            this.btn_numorden.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_numorden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_numorden.Location = new System.Drawing.Point(378, 68);
            this.btn_numorden.Name = "btn_numorden";
            this.btn_numorden.Size = new System.Drawing.Size(25, 20);
            this.btn_numorden.TabIndex = 21;
            this.btn_numorden.UseVisualStyleBackColor = false;
            this.btn_numorden.Click += new System.EventHandler(this.btn_numorden_Click);
            // 
            // cmb_orden
            // 
            this.cmb_orden.FormattingEnabled = true;
            this.cmb_orden.Location = new System.Drawing.Point(223, 29);
            this.cmb_orden.Name = "cmb_orden";
            this.cmb_orden.Size = new System.Drawing.Size(180, 24);
            this.cmb_orden.TabIndex = 28;
            this.cmb_orden.SelectedIndexChanged += new System.EventHandler(this.cmb_orden_SelectedIndexChanged);
            // 
            // txt_numorden
            // 
            this.txt_numorden.Location = new System.Drawing.Point(224, 68);
            this.txt_numorden.Name = "txt_numorden";
            this.txt_numorden.Size = new System.Drawing.Size(179, 21);
            this.txt_numorden.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de órden";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(345, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(176, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Fecha de entrega requerida";
            // 
            // txt_nombreprov
            // 
            this.txt_nombreprov.Location = new System.Drawing.Point(223, 107);
            this.txt_nombreprov.Name = "txt_nombreprov";
            this.txt_nombreprov.Size = new System.Drawing.Size(425, 21);
            this.txt_nombreprov.TabIndex = 10;
            // 
            // txt_entregara
            // 
            this.txt_entregara.Location = new System.Drawing.Point(223, 256);
            this.txt_entregara.Name = "txt_entregara";
            this.txt_entregara.Size = new System.Drawing.Size(425, 21);
            this.txt_entregara.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(345, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Depto. Solicitante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(415, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Proveedor";
            // 
            // txt_Idprov
            // 
            this.txt_Idprov.Location = new System.Drawing.Point(545, 70);
            this.txt_Idprov.Name = "txt_Idprov";
            this.txt_Idprov.Size = new System.Drawing.Size(103, 21);
            this.txt_Idprov.TabIndex = 11;
            // 
            // dateTimePickerEntrega
            // 
            this.dateTimePickerEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEntrega.Location = new System.Drawing.Point(527, 215);
            this.dateTimePickerEntrega.Name = "dateTimePickerEntrega";
            this.dateTimePickerEntrega.Size = new System.Drawing.Size(121, 21);
            this.dateTimePickerEntrega.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(105, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Recibido por: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // txt_domicilio
            // 
            this.txt_domicilio.Location = new System.Drawing.Point(223, 146);
            this.txt_domicilio.Name = "txt_domicilio";
            this.txt_domicilio.Size = new System.Drawing.Size(425, 21);
            this.txt_domicilio.TabIndex = 12;
            // 
            // dateTimePickerPedido
            // 
            this.dateTimePickerPedido.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerPedido.Location = new System.Drawing.Point(224, 216);
            this.dateTimePickerPedido.Name = "dateTimePickerPedido";
            this.dateTimePickerPedido.Size = new System.Drawing.Size(104, 21);
            this.dateTimePickerPedido.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(105, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha del pedido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(105, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Domicilio";
            // 
            // txt_telefonoprov
            // 
            this.txt_telefonoprov.Location = new System.Drawing.Point(223, 180);
            this.txt_telefonoprov.Name = "txt_telefonoprov";
            this.txt_telefonoprov.Size = new System.Drawing.Size(100, 21);
            this.txt_telefonoprov.TabIndex = 13;
            // 
            // txt_departamentos
            // 
            this.txt_departamentos.Location = new System.Drawing.Point(468, 180);
            this.txt_departamentos.Name = "txt_departamentos";
            this.txt_departamentos.Size = new System.Drawing.Size(180, 21);
            this.txt_departamentos.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(105, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Teléfono";
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 749);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Compras";
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.Compras_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalle)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.TextBox txt_notas;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.TextBox txt_iva;
        private System.Windows.Forms.TextBox txt_subtotal;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.ComboBox cmb_productos;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.DataGridView dgv_detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.TextBox txt_totalfila;
        private System.Windows.Forms.TextBox txt_preciou;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_numcompra;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btn_numorden;
        private System.Windows.Forms.ComboBox cmb_orden;
        private System.Windows.Forms.TextBox txt_numorden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_nombreprov;
        private System.Windows.Forms.TextBox txt_entregara;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Idprov;
        private System.Windows.Forms.DateTimePicker dateTimePickerEntrega;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_domicilio;
        private System.Windows.Forms.DateTimePicker dateTimePickerPedido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_telefonoprov;
        private System.Windows.Forms.TextBox txt_departamentos;
        private System.Windows.Forms.Label label5;
    }
}