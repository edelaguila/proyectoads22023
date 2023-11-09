
namespace CapaVistaBancos
{
    partial class Mantenimiento_OrdenesdeCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mantenimiento_OrdenesdeCompra));
            this.btn_salir_dispo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tipo_moneda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tipocompra = new System.Windows.Forms.TextBox();
            this.txt_idauto = new System.Windows.Forms.TextBox();
            this.txt_nombrecompra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_nombrepro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_Man_ordenesCompra = new System.Windows.Forms.DataGridView();
            this.txt_monto = new System.Windows.Forms.TextBox();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.navegador1 = new NavegadorVista.Navegador();
            this.txt_id_ordenCom = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Ayuda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Man_ordenesCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_salir_dispo
            // 
            this.btn_salir_dispo.AutoSize = true;
            this.btn_salir_dispo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btn_salir_dispo.FlatAppearance.BorderSize = 0;
            this.btn_salir_dispo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir_dispo.Image = global::CapaVistaBancos.Properties.Resources.signin_login_in_log_icon_255971;
            this.btn_salir_dispo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_salir_dispo.Location = new System.Drawing.Point(984, -1);
            this.btn_salir_dispo.Name = "btn_salir_dispo";
            this.btn_salir_dispo.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_salir_dispo.Size = new System.Drawing.Size(84, 39);
            this.btn_salir_dispo.TabIndex = 85;
            this.btn_salir_dispo.Text = "Salir";
            this.btn_salir_dispo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_salir_dispo.UseVisualStyleBackColor = false;
            this.btn_salir_dispo.Click += new System.EventHandler(this.btn_salir_dispo_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 88;
            this.label1.Text = "Id Autorización:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 89;
            this.label2.Text = "Nombre de compra:";
            // 
            // txt_tipo_moneda
            // 
            this.txt_tipo_moneda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_tipo_moneda.Location = new System.Drawing.Point(654, 384);
            this.txt_tipo_moneda.Name = "txt_tipo_moneda";
            this.txt_tipo_moneda.Size = new System.Drawing.Size(176, 22);
            this.txt_tipo_moneda.TabIndex = 102;
            this.txt_tipo_moneda.Tag = "fk_manoc_tipo_moneda";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 20);
            this.label3.TabIndex = 90;
            this.label3.Text = "Nombre de proveedor:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(521, 384);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 20);
            this.label7.TabIndex = 101;
            this.label7.Text = "Tipo de moneda:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(78, 437);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 91;
            this.label4.Text = "Monto:";
            // 
            // txt_tipocompra
            // 
            this.txt_tipocompra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_tipocompra.Location = new System.Drawing.Point(656, 336);
            this.txt_tipocompra.Name = "txt_tipocompra";
            this.txt_tipocompra.Size = new System.Drawing.Size(176, 22);
            this.txt_tipocompra.TabIndex = 100;
            this.txt_tipocompra.Tag = "manoc_tipo_compra";
            // 
            // txt_idauto
            // 
            this.txt_idauto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_idauto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idauto.Location = new System.Drawing.Point(264, 295);
            this.txt_idauto.Name = "txt_idauto";
            this.txt_idauto.Size = new System.Drawing.Size(177, 26);
            this.txt_idauto.TabIndex = 92;
            this.txt_idauto.Tag = "manoc_id_autorización";
            // 
            // txt_nombrecompra
            // 
            this.txt_nombrecompra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_nombrecompra.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombrecompra.Location = new System.Drawing.Point(264, 336);
            this.txt_nombrecompra.Name = "txt_nombrecompra";
            this.txt_nombrecompra.Size = new System.Drawing.Size(177, 26);
            this.txt_nombrecompra.TabIndex = 93;
            this.txt_nombrecompra.Tag = "manoc_nombre_compra";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(522, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 98;
            this.label6.Text = "Tipo de compra:";
            // 
            // txt_nombrepro
            // 
            this.txt_nombrepro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_nombrepro.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombrepro.Location = new System.Drawing.Point(264, 384);
            this.txt_nombrepro.Name = "txt_nombrepro";
            this.txt_nombrepro.Size = new System.Drawing.Size(177, 26);
            this.txt_nombrepro.TabIndex = 94;
            this.txt_nombrepro.Tag = "manoc_nombre_proveedor";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(522, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 97;
            this.label5.Text = "Descripción:";
            // 
            // dgv_Man_ordenesCompra
            // 
            this.dgv_Man_ordenesCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Man_ordenesCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Man_ordenesCompra.Location = new System.Drawing.Point(69, 472);
            this.dgv_Man_ordenesCompra.Name = "dgv_Man_ordenesCompra";
            this.dgv_Man_ordenesCompra.RowHeadersWidth = 51;
            this.dgv_Man_ordenesCompra.RowTemplate.Height = 24;
            this.dgv_Man_ordenesCompra.Size = new System.Drawing.Size(938, 189);
            this.dgv_Man_ordenesCompra.TabIndex = 95;
            this.dgv_Man_ordenesCompra.Tag = "tbl_mantenimientos_ordenes_compra";
            // 
            // txt_monto
            // 
            this.txt_monto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_monto.Location = new System.Drawing.Point(264, 434);
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.Size = new System.Drawing.Size(177, 22);
            this.txt_monto.TabIndex = 96;
            this.txt_monto.Tag = "manoc_monto";
            // 
            // txt_estado
            // 
            this.txt_estado.Enabled = false;
            this.txt_estado.Location = new System.Drawing.Point(654, 434);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.ReadOnly = true;
            this.txt_estado.Size = new System.Drawing.Size(42, 22);
            this.txt_estado.TabIndex = 103;
            this.txt_estado.Tag = "manoc_status";
            this.txt_estado.Text = "1";
            this.txt_estado.Visible = false;
            this.txt_estado.TextChanged += new System.EventHandler(this.txt_estado_TextChanged);
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(656, 254);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(175, 53);
            this.txt_descripcion.TabIndex = 104;
            this.txt_descripcion.Tag = "manoc_descripcion";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(127, 49);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(765, 187);
            this.navegador1.TabIndex = 105;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // txt_id_ordenCom
            // 
            this.txt_id_ordenCom.Enabled = false;
            this.txt_id_ordenCom.Location = new System.Drawing.Point(264, 255);
            this.txt_id_ordenCom.Name = "txt_id_ordenCom";
            this.txt_id_ordenCom.Size = new System.Drawing.Size(177, 22);
            this.txt_id_ordenCom.TabIndex = 106;
            this.txt_id_ordenCom.Tag = "pk_manoc_id_ordenc";
            this.txt_id_ordenCom.Text = "1";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(78, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 20);
            this.label8.TabIndex = 107;
            this.label8.Text = "Id Orden de compra:";
            // 
            // btn_Ayuda
            // 
            this.btn_Ayuda.FlatAppearance.BorderSize = 0;
            this.btn_Ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ayuda.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ayuda.Image")));
            this.btn_Ayuda.Location = new System.Drawing.Point(784, 141);
            this.btn_Ayuda.Name = "btn_Ayuda";
            this.btn_Ayuda.Size = new System.Drawing.Size(93, 85);
            this.btn_Ayuda.TabIndex = 108;
            this.btn_Ayuda.Text = "Ayuda";
            this.btn_Ayuda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Ayuda.UseVisualStyleBackColor = false;
            this.btn_Ayuda.Click += new System.EventHandler(this.btn_Ayuda_Click);
            // 
            // Mantenimiento_OrdenesdeCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(161)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(1069, 803);
            this.Controls.Add(this.btn_Ayuda);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_id_ordenCom);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.txt_estado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_tipo_moneda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_tipocompra);
            this.Controls.Add(this.txt_idauto);
            this.Controls.Add(this.txt_nombrecompra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_nombrepro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgv_Man_ordenesCompra);
            this.Controls.Add(this.txt_monto);
            this.Controls.Add(this.btn_salir_dispo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1069, 803);
            this.MinimumSize = new System.Drawing.Size(888, 659);
            this.Name = "Mantenimiento_OrdenesdeCompra";
            this.Text = "Mantenimiento Ordenes de Compra";
            this.Load += new System.EventHandler(this.Mantenimiento_OrdenesdeCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Man_ordenesCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_salir_dispo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tipo_moneda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tipocompra;
        private System.Windows.Forms.TextBox txt_idauto;
        private System.Windows.Forms.TextBox txt_nombrecompra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_nombrepro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_Man_ordenesCompra;
        private System.Windows.Forms.TextBox txt_monto;
        private System.Windows.Forms.TextBox txt_estado;
        private System.Windows.Forms.TextBox txt_descripcion;
        private NavegadorVista.Navegador navegador1;
        private System.Windows.Forms.TextBox txt_id_ordenCom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Ayuda;
    }
}