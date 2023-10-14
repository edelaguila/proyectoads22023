
namespace CapaVista_TraslaProd
{
    partial class Form_TraslaProd
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nombreDoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_destino = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_idDoc = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_reporte = new System.Windows.Forms.Button();
            this.btn_fin = new System.Windows.Forms.Button();
            this.btn_inicio = new System.Windows.Forms.Button();
            this.btn_ayuda = new System.Windows.Forms.Button();
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.btn_anterior = new System.Windows.Forms.Button();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_remover = new System.Windows.Forms.Button();
            this.dgv_traslaProd = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_idProc = new System.Windows.Forms.TextBox();
            this.txt_nombreProc = new System.Windows.Forms.TextBox();
            this.txt_almacen = new System.Windows.Forms.TextBox();
            this.txt_bodega = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_precioUnit = new System.Windows.Forms.TextBox();
            this.txt_precioTotal = new System.Windows.Forms.TextBox();
            this.txt_costoTotal = new System.Windows.Forms.TextBox();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbl_costoTotal = new System.Windows.Forms.Label();
            this.lbl_precioTotal = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_traslaProd)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(161)))), ((int)(((byte)(116)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(12, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1041, 284);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(219)))), ((int)(((byte)(200)))));
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1035, 277);
            this.panel3.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_bodega);
            this.groupBox2.Controls.Add(this.txt_almacen);
            this.groupBox2.Controls.Add(this.txt_nombreProc);
            this.groupBox2.Controls.Add(this.txt_idProc);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(17, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 154);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Productos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nombre del Producto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "ID Producto:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_aceptar);
            this.groupBox1.Controls.Add(this.txt_fecha);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_nombreDoc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_destino);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_idDoc);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(17, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1006, 90);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Documentación";
            // 
            // txt_fecha
            // 
            this.txt_fecha.Location = new System.Drawing.Point(532, 51);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(174, 22);
            this.txt_fecha.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(442, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Fecha:";
            // 
            // txt_nombreDoc
            // 
            this.txt_nombreDoc.Location = new System.Drawing.Point(532, 23);
            this.txt_nombreDoc.Name = "txt_nombreDoc";
            this.txt_nombreDoc.Size = new System.Drawing.Size(174, 22);
            this.txt_nombreDoc.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(442, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Documento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID Documento:";
            // 
            // txt_destino
            // 
            this.txt_destino.Location = new System.Drawing.Point(140, 52);
            this.txt_destino.Name = "txt_destino";
            this.txt_destino.Size = new System.Drawing.Size(289, 22);
            this.txt_destino.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Destino:";
            // 
            // txt_idDoc
            // 
            this.txt_idDoc.Location = new System.Drawing.Point(140, 24);
            this.txt_idDoc.Name = "txt_idDoc";
            this.txt_idDoc.Size = new System.Drawing.Size(289, 22);
            this.txt_idDoc.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(161)))), ((int)(((byte)(116)))));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1041, 85);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(219)))), ((int)(((byte)(200)))));
            this.panel4.Controls.Add(this.btn_cancelar);
            this.panel4.Controls.Add(this.btn_reporte);
            this.panel4.Controls.Add(this.btn_fin);
            this.panel4.Controls.Add(this.btn_inicio);
            this.panel4.Controls.Add(this.btn_ayuda);
            this.panel4.Controls.Add(this.btn_siguiente);
            this.panel4.Controls.Add(this.btn_anterior);
            this.panel4.Controls.Add(this.btn_consultar);
            this.panel4.Controls.Add(this.btn_guardar);
            this.panel4.Controls.Add(this.btn_actualizar);
            this.panel4.Controls.Add(this.btn_eliminar);
            this.panel4.Controls.Add(this.btn_modificar);
            this.panel4.Controls.Add(this.btn_agregar);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1035, 79);
            this.panel4.TabIndex = 1;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btn_cancelar.Image = global::CapaVista_TraslaProd.Properties.Resources.cancelar;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cancelar.Location = new System.Drawing.Point(469, 4);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(87, 72);
            this.btn_cancelar.TabIndex = 13;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            // 
            // btn_reporte
            // 
            this.btn_reporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btn_reporte.Image = global::CapaVista_TraslaProd.Properties.Resources.modificar1;
            this.btn_reporte.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_reporte.Location = new System.Drawing.Point(852, 3);
            this.btn_reporte.Name = "btn_reporte";
            this.btn_reporte.Size = new System.Drawing.Size(87, 72);
            this.btn_reporte.TabIndex = 7;
            this.btn_reporte.Text = "Reporte";
            this.btn_reporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_reporte.UseVisualStyleBackColor = false;
            // 
            // btn_fin
            // 
            this.btn_fin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btn_fin.Image = global::CapaVista_TraslaProd.Properties.Resources.fin;
            this.btn_fin.Location = new System.Drawing.Point(754, 41);
            this.btn_fin.Name = "btn_fin";
            this.btn_fin.Size = new System.Drawing.Size(87, 35);
            this.btn_fin.TabIndex = 12;
            this.btn_fin.UseVisualStyleBackColor = false;
            // 
            // btn_inicio
            // 
            this.btn_inicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btn_inicio.Image = global::CapaVista_TraslaProd.Properties.Resources.inicio;
            this.btn_inicio.Location = new System.Drawing.Point(661, 41);
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Size = new System.Drawing.Size(87, 35);
            this.btn_inicio.TabIndex = 11;
            this.btn_inicio.UseVisualStyleBackColor = false;
            // 
            // btn_ayuda
            // 
            this.btn_ayuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btn_ayuda.Image = global::CapaVista_TraslaProd.Properties.Resources.ayuda;
            this.btn_ayuda.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ayuda.Location = new System.Drawing.Point(945, 3);
            this.btn_ayuda.Name = "btn_ayuda";
            this.btn_ayuda.Size = new System.Drawing.Size(87, 72);
            this.btn_ayuda.TabIndex = 10;
            this.btn_ayuda.Text = "Ayuda";
            this.btn_ayuda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_ayuda.UseVisualStyleBackColor = false;
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btn_siguiente.Image = global::CapaVista_TraslaProd.Properties.Resources.siguiente;
            this.btn_siguiente.Location = new System.Drawing.Point(754, 4);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(87, 36);
            this.btn_siguiente.TabIndex = 9;
            this.btn_siguiente.UseVisualStyleBackColor = false;
            // 
            // btn_anterior
            // 
            this.btn_anterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btn_anterior.Image = global::CapaVista_TraslaProd.Properties.Resources.anterior;
            this.btn_anterior.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_anterior.Location = new System.Drawing.Point(661, 5);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(87, 35);
            this.btn_anterior.TabIndex = 8;
            this.btn_anterior.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_anterior.UseVisualStyleBackColor = false;
            // 
            // btn_consultar
            // 
            this.btn_consultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btn_consultar.Image = global::CapaVista_TraslaProd.Properties.Resources.buscar;
            this.btn_consultar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_consultar.Location = new System.Drawing.Point(562, 4);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(87, 72);
            this.btn_consultar.TabIndex = 6;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_consultar.UseVisualStyleBackColor = false;
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btn_guardar.Image = global::CapaVista_TraslaProd.Properties.Resources.guardar;
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_guardar.Location = new System.Drawing.Point(376, 4);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(87, 72);
            this.btn_guardar.TabIndex = 5;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_guardar.UseVisualStyleBackColor = false;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btn_actualizar.Image = global::CapaVista_TraslaProd.Properties.Resources.refrescar;
            this.btn_actualizar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_actualizar.Location = new System.Drawing.Point(283, 4);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(87, 72);
            this.btn_actualizar.TabIndex = 4;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_actualizar.UseVisualStyleBackColor = false;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btn_eliminar.Image = global::CapaVista_TraslaProd.Properties.Resources.eliminar;
            this.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_eliminar.Location = new System.Drawing.Point(190, 4);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(87, 72);
            this.btn_eliminar.TabIndex = 3;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_eliminar.UseVisualStyleBackColor = false;
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btn_modificar.Image = global::CapaVista_TraslaProd.Properties.Resources.modificar;
            this.btn_modificar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_modificar.Location = new System.Drawing.Point(97, 4);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(87, 72);
            this.btn_modificar.TabIndex = 2;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_modificar.UseVisualStyleBackColor = false;
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btn_agregar.Image = global::CapaVista_TraslaProd.Properties.Resources.ingresar;
            this.btn_agregar.Location = new System.Drawing.Point(4, 4);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(87, 72);
            this.btn_agregar.TabIndex = 1;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_agregar.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(161)))), ((int)(((byte)(116)))));
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(12, 393);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1041, 486);
            this.panel5.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(219)))), ((int)(((byte)(200)))));
            this.panel6.Controls.Add(this.groupBox4);
            this.panel6.Controls.Add(this.lbl_precioTotal);
            this.panel6.Controls.Add(this.lbl_costoTotal);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1035, 479);
            this.panel6.TabIndex = 0;
            // 
            // btn_remover
            // 
            this.btn_remover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btn_remover.Image = global::CapaVista_TraslaProd.Properties.Resources.eliminar;
            this.btn_remover.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_remover.Location = new System.Drawing.Point(896, 30);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(87, 72);
            this.btn_remover.TabIndex = 14;
            this.btn_remover.Text = "Remover";
            this.btn_remover.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_remover.UseVisualStyleBackColor = false;
            // 
            // dgv_traslaProd
            // 
            this.dgv_traslaProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_traslaProd.Location = new System.Drawing.Point(32, 30);
            this.dgv_traslaProd.Name = "dgv_traslaProd";
            this.dgv_traslaProd.RowHeadersWidth = 51;
            this.dgv_traslaProd.RowTemplate.Height = 24;
            this.dgv_traslaProd.Size = new System.Drawing.Size(854, 304);
            this.dgv_traslaProd.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Almacen:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Bodega:";
            // 
            // txt_idProc
            // 
            this.txt_idProc.Location = new System.Drawing.Point(188, 28);
            this.txt_idProc.Name = "txt_idProc";
            this.txt_idProc.Size = new System.Drawing.Size(269, 22);
            this.txt_idProc.TabIndex = 4;
            // 
            // txt_nombreProc
            // 
            this.txt_nombreProc.Location = new System.Drawing.Point(188, 56);
            this.txt_nombreProc.Name = "txt_nombreProc";
            this.txt_nombreProc.Size = new System.Drawing.Size(269, 22);
            this.txt_nombreProc.TabIndex = 5;
            // 
            // txt_almacen
            // 
            this.txt_almacen.Location = new System.Drawing.Point(188, 84);
            this.txt_almacen.Name = "txt_almacen";
            this.txt_almacen.Size = new System.Drawing.Size(269, 22);
            this.txt_almacen.TabIndex = 6;
            // 
            // txt_bodega
            // 
            this.txt_bodega.Location = new System.Drawing.Point(188, 112);
            this.txt_bodega.Name = "txt_bodega";
            this.txt_bodega.Size = new System.Drawing.Size(269, 22);
            this.txt_bodega.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_precioUnit);
            this.groupBox3.Controls.Add(this.txt_precioTotal);
            this.groupBox3.Controls.Add(this.txt_costoTotal);
            this.groupBox3.Controls.Add(this.txt_cantidad);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(543, 110);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(480, 154);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contabilidad";
            // 
            // txt_precioUnit
            // 
            this.txt_precioUnit.Location = new System.Drawing.Point(188, 112);
            this.txt_precioUnit.Name = "txt_precioUnit";
            this.txt_precioUnit.Size = new System.Drawing.Size(269, 22);
            this.txt_precioUnit.TabIndex = 7;
            // 
            // txt_precioTotal
            // 
            this.txt_precioTotal.Location = new System.Drawing.Point(188, 84);
            this.txt_precioTotal.Name = "txt_precioTotal";
            this.txt_precioTotal.Size = new System.Drawing.Size(269, 22);
            this.txt_precioTotal.TabIndex = 6;
            // 
            // txt_costoTotal
            // 
            this.txt_costoTotal.Location = new System.Drawing.Point(188, 56);
            this.txt_costoTotal.Name = "txt_costoTotal";
            this.txt_costoTotal.Size = new System.Drawing.Size(269, 22);
            this.txt_costoTotal.TabIndex = 5;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(188, 28);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(269, 22);
            this.txt_cantidad.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Precio Unitario:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Precio Total";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "Costo Total";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Cantidad:";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btn_aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_aceptar.Image = global::CapaVista_TraslaProd.Properties.Resources.modificar;
            this.btn_aceptar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_aceptar.Location = new System.Drawing.Point(791, 21);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(192, 55);
            this.btn_aceptar.TabIndex = 3;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_aceptar.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(78, 382);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 17);
            this.label13.TabIndex = 15;
            this.label13.Text = "COSTO TOTAL:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(430, 382);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 17);
            this.label14.TabIndex = 16;
            this.label14.Text = "PRECIO TOTAL:";
            // 
            // lbl_costoTotal
            // 
            this.lbl_costoTotal.AutoSize = true;
            this.lbl_costoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_costoTotal.Location = new System.Drawing.Point(103, 409);
            this.lbl_costoTotal.Name = "lbl_costoTotal";
            this.lbl_costoTotal.Size = new System.Drawing.Size(47, 39);
            this.lbl_costoTotal.TabIndex = 17;
            this.lbl_costoTotal.Text = "...";
            // 
            // lbl_precioTotal
            // 
            this.lbl_precioTotal.AutoSize = true;
            this.lbl_precioTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precioTotal.Location = new System.Drawing.Point(452, 409);
            this.lbl_precioTotal.Name = "lbl_precioTotal";
            this.lbl_precioTotal.Size = new System.Drawing.Size(47, 39);
            this.lbl_precioTotal.TabIndex = 18;
            this.lbl_precioTotal.Text = "...";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgv_traslaProd);
            this.groupBox4.Controls.Add(this.btn_remover);
            this.groupBox4.Location = new System.Drawing.Point(17, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1006, 353);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Detalle de Traslados";
            // 
            // Form_TraslaProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(235)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(1065, 888);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form_TraslaProd";
            this.Text = "Traslado de Productos";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_traslaProd)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dgv_traslaProd;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_reporte;
        private System.Windows.Forms.Button btn_fin;
        private System.Windows.Forms.Button btn_inicio;
        private System.Windows.Forms.Button btn_ayuda;
        private System.Windows.Forms.Button btn_siguiente;
        private System.Windows.Forms.Button btn_anterior;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_idDoc;
        private System.Windows.Forms.TextBox txt_destino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nombreDoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_fecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_precioUnit;
        private System.Windows.Forms.TextBox txt_precioTotal;
        private System.Windows.Forms.TextBox txt_costoTotal;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_bodega;
        private System.Windows.Forms.TextBox txt_almacen;
        private System.Windows.Forms.TextBox txt_nombreProc;
        private System.Windows.Forms.TextBox txt_idProc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbl_precioTotal;
        private System.Windows.Forms.Label lbl_costoTotal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
    }
}