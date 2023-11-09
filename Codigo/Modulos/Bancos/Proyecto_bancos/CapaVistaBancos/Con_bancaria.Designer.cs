
namespace CapaVistaBancos
{
    partial class Con_bancaria
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
            this.dgv_conciliado = new System.Windows.Forms.DataGridView();
            this.dgv_movimientos_conciliacion = new System.Windows.Forms.DataGridView();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_salir_dispo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_tipo_pago = new System.Windows.Forms.TextBox();
            this.txt_cuenta = new System.Windows.Forms.TextBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_asignar = new System.Windows.Forms.Button();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.lbl_notransaccion = new System.Windows.Forms.Label();
            this.txt_saldoinicial = new System.Windows.Forms.TextBox();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.lbl_saldoinicial = new System.Windows.Forms.Label();
            this.lbl_cuenta = new System.Windows.Forms.Label();
            this.txt_transaccion = new System.Windows.Forms.TextBox();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.lbl_tipopago = new System.Windows.Forms.Label();
            this.btn_conciliar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_diferencia = new System.Windows.Forms.Label();
            this.lbl_titulo_diferencia = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_vallibro = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_valbanco = new System.Windows.Forms.Label();
            this.lbl_titulobanco = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_conciliado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_movimientos_conciliacion)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_conciliado
            // 
            this.dgv_conciliado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_conciliado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_conciliado.Location = new System.Drawing.Point(12, 369);
            this.dgv_conciliado.Name = "dgv_conciliado";
            this.dgv_conciliado.RowHeadersWidth = 51;
            this.dgv_conciliado.Size = new System.Drawing.Size(716, 181);
            this.dgv_conciliado.TabIndex = 52;
            // 
            // dgv_movimientos_conciliacion
            // 
            this.dgv_movimientos_conciliacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_movimientos_conciliacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_movimientos_conciliacion.Location = new System.Drawing.Point(10, 191);
            this.dgv_movimientos_conciliacion.Name = "dgv_movimientos_conciliacion";
            this.dgv_movimientos_conciliacion.RowHeadersWidth = 51;
            this.dgv_movimientos_conciliacion.Size = new System.Drawing.Size(718, 172);
            this.dgv_movimientos_conciliacion.TabIndex = 51;
            this.dgv_movimientos_conciliacion.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_movimientos_conciliacion_CellDoubleClick_1);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_titulo.Location = new System.Drawing.Point(-2, -2);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(746, 36);
            this.lbl_titulo.TabIndex = 37;
            this.lbl_titulo.Text = "Conciliacion Bancaria";
            this.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_salir_dispo
            // 
            this.btn_salir_dispo.AutoSize = true;
            this.btn_salir_dispo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btn_salir_dispo.FlatAppearance.BorderSize = 0;
            this.btn_salir_dispo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir_dispo.Image = global::CapaVistaBancos.Properties.Resources.signin_login_in_log_icon_255971;
            this.btn_salir_dispo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_salir_dispo.Location = new System.Drawing.Point(741, -1);
            this.btn_salir_dispo.Margin = new System.Windows.Forms.Padding(2);
            this.btn_salir_dispo.Name = "btn_salir_dispo";
            this.btn_salir_dispo.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btn_salir_dispo.Size = new System.Drawing.Size(63, 38);
            this.btn_salir_dispo.TabIndex = 85;
            this.btn_salir_dispo.Text = "Salir";
            this.btn_salir_dispo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_salir_dispo.UseVisualStyleBackColor = false;
            this.btn_salir_dispo.Click += new System.EventHandler(this.btn_salir_dispo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_tipo_pago);
            this.groupBox1.Controls.Add(this.txt_cuenta);
            this.groupBox1.Controls.Add(this.btn_cancelar);
            this.groupBox1.Controls.Add(this.btn_asignar);
            this.groupBox1.Controls.Add(this.txt_valor);
            this.groupBox1.Controls.Add(this.lbl_notransaccion);
            this.groupBox1.Controls.Add(this.txt_saldoinicial);
            this.groupBox1.Controls.Add(this.lbl_valor);
            this.groupBox1.Controls.Add(this.lbl_saldoinicial);
            this.groupBox1.Controls.Add(this.lbl_cuenta);
            this.groupBox1.Controls.Add(this.txt_transaccion);
            this.groupBox1.Controls.Add(this.lbl_fecha);
            this.groupBox1.Controls.Add(this.txt_fecha);
            this.groupBox1.Controls.Add(this.lbl_tipopago);
            this.groupBox1.Controls.Add(this.btn_conciliar);
            this.groupBox1.Location = new System.Drawing.Point(10, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(718, 154);
            this.groupBox1.TabIndex = 86;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conciliación";
            // 
            // txt_tipo_pago
            // 
            this.txt_tipo_pago.Enabled = false;
            this.txt_tipo_pago.Location = new System.Drawing.Point(503, 23);
            this.txt_tipo_pago.Name = "txt_tipo_pago";
            this.txt_tipo_pago.Size = new System.Drawing.Size(198, 20);
            this.txt_tipo_pago.TabIndex = 82;
            // 
            // txt_cuenta
            // 
            this.txt_cuenta.Enabled = false;
            this.txt_cuenta.Location = new System.Drawing.Point(108, 102);
            this.txt_cuenta.Name = "txt_cuenta";
            this.txt_cuenta.Size = new System.Drawing.Size(201, 20);
            this.txt_cuenta.TabIndex = 81;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Enabled = false;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(367, 20);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(25, 21);
            this.btn_cancelar.TabIndex = 79;
            this.btn_cancelar.Text = "X";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click_1);
            // 
            // btn_asignar
            // 
            this.btn_asignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_asignar.Location = new System.Drawing.Point(315, 20);
            this.btn_asignar.Name = "btn_asignar";
            this.btn_asignar.Size = new System.Drawing.Size(46, 20);
            this.btn_asignar.TabIndex = 78;
            this.btn_asignar.Text = "Asignar";
            this.btn_asignar.UseVisualStyleBackColor = true;
            this.btn_asignar.Click += new System.EventHandler(this.btn_asignar_Click);
            // 
            // txt_valor
            // 
            this.txt_valor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_valor.Enabled = false;
            this.txt_valor.Location = new System.Drawing.Point(108, 73);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(201, 20);
            this.txt_valor.TabIndex = 67;
            // 
            // lbl_notransaccion
            // 
            this.lbl_notransaccion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_notransaccion.AutoSize = true;
            this.lbl_notransaccion.Location = new System.Drawing.Point(22, 49);
            this.lbl_notransaccion.Name = "lbl_notransaccion";
            this.lbl_notransaccion.Size = new System.Drawing.Size(80, 13);
            this.lbl_notransaccion.TabIndex = 63;
            this.lbl_notransaccion.Text = "NoTransaccion";
            // 
            // txt_saldoinicial
            // 
            this.txt_saldoinicial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_saldoinicial.Location = new System.Drawing.Point(108, 20);
            this.txt_saldoinicial.Name = "txt_saldoinicial";
            this.txt_saldoinicial.Size = new System.Drawing.Size(201, 20);
            this.txt_saldoinicial.TabIndex = 77;
            // 
            // lbl_valor
            // 
            this.lbl_valor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Location = new System.Drawing.Point(22, 76);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(31, 13);
            this.lbl_valor.TabIndex = 64;
            this.lbl_valor.Text = "Valor";
            // 
            // lbl_saldoinicial
            // 
            this.lbl_saldoinicial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_saldoinicial.AutoSize = true;
            this.lbl_saldoinicial.Location = new System.Drawing.Point(18, 23);
            this.lbl_saldoinicial.Name = "lbl_saldoinicial";
            this.lbl_saldoinicial.Size = new System.Drawing.Size(84, 13);
            this.lbl_saldoinicial.TabIndex = 76;
            this.lbl_saldoinicial.Text = "Saldo Inicial (Q.)";
            // 
            // lbl_cuenta
            // 
            this.lbl_cuenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_cuenta.AutoSize = true;
            this.lbl_cuenta.Location = new System.Drawing.Point(22, 102);
            this.lbl_cuenta.Name = "lbl_cuenta";
            this.lbl_cuenta.Size = new System.Drawing.Size(41, 13);
            this.lbl_cuenta.TabIndex = 65;
            this.lbl_cuenta.Text = "Cuenta";
            // 
            // txt_transaccion
            // 
            this.txt_transaccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_transaccion.Enabled = false;
            this.txt_transaccion.Location = new System.Drawing.Point(108, 46);
            this.txt_transaccion.Name = "txt_transaccion";
            this.txt_transaccion.Size = new System.Drawing.Size(201, 20);
            this.txt_transaccion.TabIndex = 66;
            this.txt_transaccion.Tag = "noTransaccion";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Location = new System.Drawing.Point(22, 129);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(37, 13);
            this.lbl_fecha.TabIndex = 69;
            this.lbl_fecha.Text = "Fecha";
            // 
            // txt_fecha
            // 
            this.txt_fecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_fecha.Enabled = false;
            this.txt_fecha.Location = new System.Drawing.Point(108, 129);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(201, 20);
            this.txt_fecha.TabIndex = 70;
            // 
            // lbl_tipopago
            // 
            this.lbl_tipopago.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_tipopago.AutoSize = true;
            this.lbl_tipopago.Location = new System.Drawing.Point(442, 26);
            this.lbl_tipopago.Name = "lbl_tipopago";
            this.lbl_tipopago.Size = new System.Drawing.Size(55, 13);
            this.lbl_tipopago.TabIndex = 72;
            this.lbl_tipopago.Text = "Tipo pago";
            // 
            // btn_conciliar
            // 
            this.btn_conciliar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_conciliar.Enabled = false;
            this.btn_conciliar.Location = new System.Drawing.Point(445, 84);
            this.btn_conciliar.Name = "btn_conciliar";
            this.btn_conciliar.Size = new System.Drawing.Size(256, 35);
            this.btn_conciliar.TabIndex = 73;
            this.btn_conciliar.Text = "Conciliar";
            this.btn_conciliar.UseVisualStyleBackColor = true;
            this.btn_conciliar.Click += new System.EventHandler(this.btn_conciliar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(340, 585);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 92;
            this.label1.Text = "Q.";
            // 
            // lbl_diferencia
            // 
            this.lbl_diferencia.AutoSize = true;
            this.lbl_diferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_diferencia.Location = new System.Drawing.Point(370, 585);
            this.lbl_diferencia.Name = "lbl_diferencia";
            this.lbl_diferencia.Size = new System.Drawing.Size(44, 20);
            this.lbl_diferencia.TabIndex = 91;
            this.lbl_diferencia.Text = "0.00";
            // 
            // lbl_titulo_diferencia
            // 
            this.lbl_titulo_diferencia.AutoSize = true;
            this.lbl_titulo_diferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo_diferencia.Location = new System.Drawing.Point(245, 585);
            this.lbl_titulo_diferencia.Name = "lbl_titulo_diferencia";
            this.lbl_titulo_diferencia.Size = new System.Drawing.Size(101, 20);
            this.lbl_titulo_diferencia.TabIndex = 90;
            this.lbl_titulo_diferencia.Text = "Diferencia: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(608, 553);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 20);
            this.label4.TabIndex = 97;
            this.label4.Text = "Q.";
            // 
            // lbl_vallibro
            // 
            this.lbl_vallibro.AutoSize = true;
            this.lbl_vallibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vallibro.Location = new System.Drawing.Point(637, 553);
            this.lbl_vallibro.Name = "lbl_vallibro";
            this.lbl_vallibro.Size = new System.Drawing.Size(44, 20);
            this.lbl_vallibro.TabIndex = 96;
            this.lbl_vallibro.Text = "0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(393, 553);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 20);
            this.label5.TabIndex = 95;
            this.label5.Text = "Saldo Total(Libro bancos):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(186, 553);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 100;
            this.label2.Text = "Q.";
            // 
            // lbl_valbanco
            // 
            this.lbl_valbanco.AutoSize = true;
            this.lbl_valbanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valbanco.Location = new System.Drawing.Point(215, 553);
            this.lbl_valbanco.Name = "lbl_valbanco";
            this.lbl_valbanco.Size = new System.Drawing.Size(44, 20);
            this.lbl_valbanco.TabIndex = 99;
            this.lbl_valbanco.Text = "0.00";
            // 
            // lbl_titulobanco
            // 
            this.lbl_titulobanco.AutoSize = true;
            this.lbl_titulobanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulobanco.Location = new System.Drawing.Point(12, 553);
            this.lbl_titulobanco.Name = "lbl_titulobanco";
            this.lbl_titulobanco.Size = new System.Drawing.Size(168, 20);
            this.lbl_titulobanco.TabIndex = 98;
            this.lbl_titulobanco.Text = "Saldo Total(Banco):";
            // 
            // Con_bancaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(161)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(802, 614);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_valbanco);
            this.Controls.Add(this.lbl_titulobanco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_vallibro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_diferencia);
            this.Controls.Add(this.lbl_titulo_diferencia);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_salir_dispo);
            this.Controls.Add(this.dgv_conciliado);
            this.Controls.Add(this.dgv_movimientos_conciliacion);
            this.Controls.Add(this.lbl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(802, 652);
            this.MinimumSize = new System.Drawing.Size(666, 535);
            this.Name = "Con_bancaria";
            this.Text = "Con_bancaria";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_conciliado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_movimientos_conciliacion)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_conciliado;
        private System.Windows.Forms.DataGridView dgv_movimientos_conciliacion;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_salir_dispo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_asignar;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Label lbl_notransaccion;
        private System.Windows.Forms.TextBox txt_saldoinicial;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.Label lbl_saldoinicial;
        private System.Windows.Forms.Label lbl_cuenta;
        private System.Windows.Forms.TextBox txt_transaccion;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.TextBox txt_fecha;
        private System.Windows.Forms.Label lbl_tipopago;
        private System.Windows.Forms.Button btn_conciliar;
        private System.Windows.Forms.TextBox txt_tipo_pago;
        private System.Windows.Forms.TextBox txt_cuenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_diferencia;
        private System.Windows.Forms.Label lbl_titulo_diferencia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_vallibro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_valbanco;
        private System.Windows.Forms.Label lbl_titulobanco;
    }
}