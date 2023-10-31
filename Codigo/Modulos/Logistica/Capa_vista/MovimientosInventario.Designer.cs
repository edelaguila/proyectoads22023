
namespace Vista_PrototipoMenu
{
    partial class MovimientosInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovimientosInventario));
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.txt_costo = new System.Windows.Forms.TextBox();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.txt_doc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_quitar = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgv_inventario = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.navegador1 = new NavegadorVista.Navegador();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_almacen = new System.Windows.Forms.TextBox();
            this.txt_movimiento = new System.Windows.Forms.TextBox();
            this.txt_codigos = new System.Windows.Forms.TextBox();
            this.txt_medida = new System.Windows.Forms.TextBox();
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inventario)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(657, 74);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(117, 23);
            this.txt_precio.TabIndex = 31;
            this.txt_precio.Tag = "mov_precio_unitario";
            // 
            // txt_costo
            // 
            this.txt_costo.Location = new System.Drawing.Point(510, 74);
            this.txt_costo.Name = "txt_costo";
            this.txt_costo.Size = new System.Drawing.Size(97, 23);
            this.txt_costo.TabIndex = 30;
            this.txt_costo.Tag = "mov_costo_total";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(382, 73);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(90, 23);
            this.txt_cantidad.TabIndex = 29;
            this.txt_cantidad.Tag = "mov_cantidad";
            // 
            // txt_doc
            // 
            this.txt_doc.Location = new System.Drawing.Point(180, 74);
            this.txt_doc.Name = "txt_doc";
            this.txt_doc.Size = new System.Drawing.Size(136, 20);
            this.txt_doc.TabIndex = 33;
            this.txt_doc.Tag = "mov_tipo_documento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(461, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 21);
            this.label4.TabIndex = 22;
            this.label4.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tipo de Documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(363, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tipo de Movimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 21);
            this.label6.TabIndex = 18;
            this.label6.Text = "Almacen";
            // 
            // btn_quitar
            // 
            this.btn_quitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btn_quitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_quitar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quitar.Image = ((System.Drawing.Image)(resources.GetObject("btn_quitar.Image")));
            this.btn_quitar.Location = new System.Drawing.Point(804, 61);
            this.btn_quitar.Name = "btn_quitar";
            this.btn_quitar.Size = new System.Drawing.Size(68, 65);
            this.btn_quitar.TabIndex = 34;
            this.btn_quitar.Text = "Quitar";
            this.btn_quitar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_quitar.UseVisualStyleBackColor = false;
            this.btn_quitar.Click += new System.EventHandler(this.btn_quitar_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btn_aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_aceptar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptar.Image = ((System.Drawing.Image)(resources.GetObject("btn_aceptar.Image")));
            this.btn_aceptar.Location = new System.Drawing.Point(804, 43);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(68, 65);
            this.btn_aceptar.TabIndex = 32;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_aceptar.UseVisualStyleBackColor = false;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(663, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 17);
            this.label12.TabIndex = 39;
            this.label12.Text = "Precio Unitario";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(516, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 17);
            this.label11.TabIndex = 38;
            this.label11.Text = "Costo Total";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(392, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 17);
            this.label10.TabIndex = 37;
            this.label10.Text = "Cantidad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(202, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 17);
            this.label8.TabIndex = 36;
            this.label8.Text = "Medida de Producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 35;
            this.label5.Text = "Codigos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_fecha);
            this.groupBox1.Controls.Add(this.txt_movimiento);
            this.groupBox1.Controls.Add(this.txt_almacen);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_doc);
            this.groupBox1.Location = new System.Drawing.Point(90, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(763, 111);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 21);
            this.label1.TabIndex = 34;
            this.label1.Text = "Id";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_medida);
            this.groupBox2.Controls.Add(this.txt_codigos);
            this.groupBox2.Controls.Add(this.txt_costo);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txt_cantidad);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txt_precio);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btn_aceptar);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(30, 310);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(883, 133);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Productos";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.dgv_inventario);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.btn_quitar);
            this.groupBox3.Location = new System.Drawing.Point(30, 449);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(893, 322);
            this.groupBox3.TabIndex = 44;
            this.groupBox3.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(690, 267);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(25, 21);
            this.label16.TabIndex = 39;
            this.label16.Text = "---";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(232, 267);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 21);
            this.label15.TabIndex = 38;
            this.label15.Text = "---";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(124, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 21);
            this.label9.TabIndex = 36;
            this.label9.Text = "Total Costo";
            // 
            // dgv_inventario
            // 
            this.dgv_inventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_inventario.Location = new System.Drawing.Point(29, 19);
            this.dgv_inventario.Name = "dgv_inventario";
            this.dgv_inventario.Size = new System.Drawing.Size(756, 227);
            this.dgv_inventario.TabIndex = 35;
            this.dgv_inventario.Tag = "tbl_movimientos_inventario";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(584, 267);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 21);
            this.label13.TabIndex = 37;
            this.label13.Text = "Total Precio";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(178, 35);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(574, 152);
            this.navegador1.TabIndex = 45;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(145, 20);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(136, 20);
            this.txt_id.TabIndex = 35;
            this.txt_id.Tag = "pk_id";
            // 
            // txt_almacen
            // 
            this.txt_almacen.Location = new System.Drawing.Point(145, 47);
            this.txt_almacen.Name = "txt_almacen";
            this.txt_almacen.Size = new System.Drawing.Size(136, 20);
            this.txt_almacen.TabIndex = 36;
            this.txt_almacen.Tag = "mov_almacen";
            // 
            // txt_movimiento
            // 
            this.txt_movimiento.Location = new System.Drawing.Point(526, 45);
            this.txt_movimiento.Name = "txt_movimiento";
            this.txt_movimiento.Size = new System.Drawing.Size(136, 20);
            this.txt_movimiento.TabIndex = 37;
            this.txt_movimiento.Tag = "mov_tipo_movimiento";
            // 
            // txt_codigos
            // 
            this.txt_codigos.Location = new System.Drawing.Point(46, 74);
            this.txt_codigos.Name = "txt_codigos";
            this.txt_codigos.Size = new System.Drawing.Size(90, 23);
            this.txt_codigos.TabIndex = 40;
            this.txt_codigos.Tag = "mov_codigo_producto";
            // 
            // txt_medida
            // 
            this.txt_medida.Location = new System.Drawing.Point(205, 74);
            this.txt_medida.Name = "txt_medida";
            this.txt_medida.Size = new System.Drawing.Size(139, 23);
            this.txt_medida.TabIndex = 41;
            this.txt_medida.Tag = "mov_medida_producto";
            // 
            // txt_fecha
            // 
            this.txt_fecha.Location = new System.Drawing.Point(526, 77);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(136, 20);
            this.txt_fecha.TabIndex = 38;
            this.txt_fecha.Tag = "mov_fecha";
            // 
            // MovimientosInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(235)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(962, 778);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MovimientosInventario";
            this.Text = " 4100 - Movimientos Inventario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inventario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_quitar;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.TextBox txt_costo;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.TextBox txt_doc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgv_inventario;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private NavegadorVista.Navegador navegador1;
        private System.Windows.Forms.TextBox txt_movimiento;
        private System.Windows.Forms.TextBox txt_almacen;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_medida;
        private System.Windows.Forms.TextBox txt_codigos;
        private System.Windows.Forms.TextBox txt_fecha;
    }
}