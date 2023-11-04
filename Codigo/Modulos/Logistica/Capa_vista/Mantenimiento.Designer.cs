
namespace Vista_PrototipoMenu
{
    partial class Mantenimiento
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
            this.Dgv_tablas = new System.Windows.Forms.DataGridView();
            this.Txt_relacion = new System.Windows.Forms.TextBox();
            this.Txt_estatus = new System.Windows.Forms.TextBox();
            this.Txt_tipo = new System.Windows.Forms.TextBox();
            this.txt_IdCuenta = new System.Windows.Forms.TextBox();
            this.lbl_id_cuenta = new System.Windows.Forms.Label();
            this.Txt_almacen = new System.Windows.Forms.TextBox();
            this.Txt_fecha = new System.Windows.Forms.TextBox();
            this.Txt_cuenta = new System.Windows.Forms.TextBox();
            this.Txt_nombre = new System.Windows.Forms.TextBox();
            this.Txt_codigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.navegador2 = new NavegadorVista.Navegador();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_tablas)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_tablas
            // 
            this.Dgv_tablas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_tablas.Location = new System.Drawing.Point(71, 460);
            this.Dgv_tablas.Name = "Dgv_tablas";
            this.Dgv_tablas.Size = new System.Drawing.Size(663, 150);
            this.Dgv_tablas.TabIndex = 4;
            this.Dgv_tablas.Tag = "tbl_mantenimientos";
            this.Dgv_tablas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Txt_relacion
            // 
            this.Txt_relacion.Location = new System.Drawing.Point(535, 377);
            this.Txt_relacion.Name = "Txt_relacion";
            this.Txt_relacion.Size = new System.Drawing.Size(186, 20);
            this.Txt_relacion.TabIndex = 62;
            this.Txt_relacion.Tag = "Man_relacion";
            // 
            // Txt_estatus
            // 
            this.Txt_estatus.Location = new System.Drawing.Point(294, 377);
            this.Txt_estatus.Name = "Txt_estatus";
            this.Txt_estatus.Size = new System.Drawing.Size(186, 20);
            this.Txt_estatus.TabIndex = 61;
            this.Txt_estatus.Tag = "Man_Estatus";
            // 
            // Txt_tipo
            // 
            this.Txt_tipo.Location = new System.Drawing.Point(53, 377);
            this.Txt_tipo.Name = "Txt_tipo";
            this.Txt_tipo.Size = new System.Drawing.Size(186, 20);
            this.Txt_tipo.TabIndex = 60;
            this.Txt_tipo.Tag = "Man_Tipo";
            // 
            // txt_IdCuenta
            // 
            this.txt_IdCuenta.Location = new System.Drawing.Point(152, 231);
            this.txt_IdCuenta.Name = "txt_IdCuenta";
            this.txt_IdCuenta.Size = new System.Drawing.Size(194, 20);
            this.txt_IdCuenta.TabIndex = 59;
            this.txt_IdCuenta.Tag = "pk_Man_id";
            // 
            // lbl_id_cuenta
            // 
            this.lbl_id_cuenta.AutoSize = true;
            this.lbl_id_cuenta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id_cuenta.Location = new System.Drawing.Point(57, 228);
            this.lbl_id_cuenta.Name = "lbl_id_cuenta";
            this.lbl_id_cuenta.Size = new System.Drawing.Size(89, 21);
            this.lbl_id_cuenta.TabIndex = 58;
            this.lbl_id_cuenta.Text = "ID cuenta";
            // 
            // Txt_almacen
            // 
            this.Txt_almacen.Location = new System.Drawing.Point(535, 300);
            this.Txt_almacen.Name = "Txt_almacen";
            this.Txt_almacen.Size = new System.Drawing.Size(216, 20);
            this.Txt_almacen.TabIndex = 57;
            this.Txt_almacen.Tag = "Man_almacen";
            // 
            // Txt_fecha
            // 
            this.Txt_fecha.Location = new System.Drawing.Point(535, 261);
            this.Txt_fecha.Name = "Txt_fecha";
            this.Txt_fecha.Size = new System.Drawing.Size(216, 20);
            this.Txt_fecha.TabIndex = 56;
            this.Txt_fecha.Tag = "Man_fecha";
            // 
            // Txt_cuenta
            // 
            this.Txt_cuenta.Location = new System.Drawing.Point(535, 227);
            this.Txt_cuenta.Name = "Txt_cuenta";
            this.Txt_cuenta.Size = new System.Drawing.Size(216, 20);
            this.Txt_cuenta.TabIndex = 55;
            this.Txt_cuenta.Tag = "Man_cuenta";
            // 
            // Txt_nombre
            // 
            this.Txt_nombre.Location = new System.Drawing.Point(130, 295);
            this.Txt_nombre.Name = "Txt_nombre";
            this.Txt_nombre.Size = new System.Drawing.Size(216, 20);
            this.Txt_nombre.TabIndex = 54;
            this.Txt_nombre.Tag = "Man_nombre";
            // 
            // Txt_codigo
            // 
            this.Txt_codigo.Location = new System.Drawing.Point(130, 261);
            this.Txt_codigo.Name = "Txt_codigo";
            this.Txt_codigo.Size = new System.Drawing.Size(216, 20);
            this.Txt_codigo.TabIndex = 53;
            this.Txt_codigo.Tag = "Man_codigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(449, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 52;
            this.label3.Text = "Almacen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(449, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 51;
            this.label2.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(528, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 21);
            this.label1.TabIndex = 50;
            this.label1.Text = "En relación a:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(290, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 21);
            this.label6.TabIndex = 49;
            this.label6.Text = "Estatus";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(49, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 21);
            this.label7.TabIndex = 48;
            this.label7.Text = "Tipo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(449, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 21);
            this.label8.TabIndex = 47;
            this.label8.Text = "Cuenta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(56, 292);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 21);
            this.label9.TabIndex = 46;
            this.label9.Text = "Nombre";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(56, 258);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 21);
            this.label10.TabIndex = 45;
            this.label10.Text = "Codigo";
            // 
            // navegador2
            // 
            this.navegador2.Location = new System.Drawing.Point(130, 12);
            this.navegador2.Name = "navegador2";
            this.navegador2.Size = new System.Drawing.Size(574, 152);
            this.navegador2.TabIndex = 63;
            this.navegador2.Load += new System.EventHandler(this.navegador2_Load);
            // 
            // Mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(235)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(800, 620);
            this.Controls.Add(this.navegador2);
            this.Controls.Add(this.Txt_relacion);
            this.Controls.Add(this.Txt_estatus);
            this.Controls.Add(this.Txt_tipo);
            this.Controls.Add(this.txt_IdCuenta);
            this.Controls.Add(this.lbl_id_cuenta);
            this.Controls.Add(this.Txt_almacen);
            this.Controls.Add(this.Txt_fecha);
            this.Controls.Add(this.Txt_cuenta);
            this.Controls.Add(this.Txt_nombre);
            this.Controls.Add(this.Txt_codigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Dgv_tablas);
            this.Name = "Mantenimiento";
            this.Text = "4400 - Mantenimiento";
            this.Load += new System.EventHandler(this.Mantenimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_tablas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private NavegadorVista.Navegador navegador1;
        private System.Windows.Forms.DataGridView Dgv_tablas;
        private System.Windows.Forms.TextBox Txt_relacion;
        private System.Windows.Forms.TextBox Txt_estatus;
        private System.Windows.Forms.TextBox Txt_tipo;
        private System.Windows.Forms.TextBox txt_IdCuenta;
        private System.Windows.Forms.Label lbl_id_cuenta;
        private System.Windows.Forms.TextBox Txt_almacen;
        private System.Windows.Forms.TextBox Txt_fecha;
        private System.Windows.Forms.TextBox Txt_cuenta;
        private System.Windows.Forms.TextBox Txt_nombre;
        private System.Windows.Forms.TextBox Txt_codigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private NavegadorVista.Navegador navegador2;
    }
}