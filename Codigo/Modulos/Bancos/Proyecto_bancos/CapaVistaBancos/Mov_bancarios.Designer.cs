
namespace CapaVistaBancos
{
    partial class Mov_bancarios
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_valorTransferencia = new System.Windows.Forms.TextBox();
            this.txt_numeroCuenta = new System.Windows.Forms.TextBox();
            this.txt_descripcionTransferencia = new System.Windows.Forms.RichTextBox();
            this.btn_rtrans = new System.Windows.Forms.Button();
            this.dgv_vistaTransacciones = new System.Windows.Forms.DataGridView();
            this.btn_cancelarTransaccion = new System.Windows.Forms.Button();
            this.btn_salir_dispo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_stCon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_valorTrans = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_tipoTrans = new System.Windows.Forms.ComboBox();
            this.cb_nCuenta = new System.Windows.Forms.ComboBox();
            this.txt_ttransaccion = new System.Windows.Forms.TextBox();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataSet1 = new CapaVistaBancos.DataSet1();
            this.tblmantenimientostipomovimientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_mantenimientos_tipo_movimientoTableAdapter = new CapaVistaBancos.DataSet1TableAdapters.tbl_mantenimientos_tipo_movimientoTableAdapter();
            this.dataSet2 = new CapaVistaBancos.DataSet2();
            this.tblmantenimientostipomovimientoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_mantenimientos_tipo_movimientoTableAdapter1 = new CapaVistaBancos.DataSet2TableAdapters.tbl_mantenimientos_tipo_movimientoTableAdapter();
            this.dataSet3 = new CapaVistaBancos.DataSet3();
            this.tblmantenimientostipomovimientoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_mantenimientos_tipo_movimientoTableAdapter2 = new CapaVistaBancos.DataSet3TableAdapters.tbl_mantenimientos_tipo_movimientoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vistaTransacciones)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmantenimientostipomovimientoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmantenimientostipomovimientoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmantenimientostipomovimientoBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero de cuenta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de transacción:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Descripción: ";
            // 
            // txt_valorTransferencia
            // 
            this.txt_valorTransferencia.Location = new System.Drawing.Point(349, 116);
            this.txt_valorTransferencia.Name = "txt_valorTransferencia";
            this.txt_valorTransferencia.Size = new System.Drawing.Size(203, 22);
            this.txt_valorTransferencia.TabIndex = 6;
            // 
            // txt_numeroCuenta
            // 
            this.txt_numeroCuenta.Location = new System.Drawing.Point(585, 35);
            this.txt_numeroCuenta.Name = "txt_numeroCuenta";
            this.txt_numeroCuenta.Size = new System.Drawing.Size(214, 22);
            this.txt_numeroCuenta.TabIndex = 7;
            this.txt_numeroCuenta.Visible = false;
            // 
            // txt_descripcionTransferencia
            // 
            this.txt_descripcionTransferencia.Location = new System.Drawing.Point(349, 150);
            this.txt_descripcionTransferencia.Name = "txt_descripcionTransferencia";
            this.txt_descripcionTransferencia.Size = new System.Drawing.Size(203, 84);
            this.txt_descripcionTransferencia.TabIndex = 9;
            this.txt_descripcionTransferencia.Text = "";
            // 
            // btn_rtrans
            // 
            this.btn_rtrans.Location = new System.Drawing.Point(191, 258);
            this.btn_rtrans.Name = "btn_rtrans";
            this.btn_rtrans.Size = new System.Drawing.Size(372, 33);
            this.btn_rtrans.TabIndex = 10;
            this.btn_rtrans.Text = "Realizar transacción";
            this.btn_rtrans.UseVisualStyleBackColor = true;
            this.btn_rtrans.Click += new System.EventHandler(this.btn_rtrans_Click);
            // 
            // dgv_vistaTransacciones
            // 
            this.dgv_vistaTransacciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vistaTransacciones.Location = new System.Drawing.Point(43, 36);
            this.dgv_vistaTransacciones.Name = "dgv_vistaTransacciones";
            this.dgv_vistaTransacciones.RowHeadersWidth = 51;
            this.dgv_vistaTransacciones.RowTemplate.Height = 24;
            this.dgv_vistaTransacciones.Size = new System.Drawing.Size(887, 256);
            this.dgv_vistaTransacciones.TabIndex = 11;
            this.dgv_vistaTransacciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_vistaTransacciones_CellContentClick);
            // 
            // btn_cancelarTransaccion
            // 
            this.btn_cancelarTransaccion.Location = new System.Drawing.Point(191, 297);
            this.btn_cancelarTransaccion.Name = "btn_cancelarTransaccion";
            this.btn_cancelarTransaccion.Size = new System.Drawing.Size(372, 33);
            this.btn_cancelarTransaccion.TabIndex = 13;
            this.btn_cancelarTransaccion.Text = "Cancelar transacción";
            this.btn_cancelarTransaccion.UseVisualStyleBackColor = true;
            this.btn_cancelarTransaccion.Click += new System.EventHandler(this.btn_cancelarTransaccion_Click);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_stCon);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_valorTrans);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cb_tipoTrans);
            this.groupBox1.Controls.Add(this.cb_nCuenta);
            this.groupBox1.Controls.Add(this.txt_ttransaccion);
            this.groupBox1.Controls.Add(this.txt_estado);
            this.groupBox1.Controls.Add(this.txt_descripcionTransferencia);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_cancelarTransaccion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btn_rtrans);
            this.groupBox1.Controls.Add(this.txt_valorTransferencia);
            this.groupBox1.Controls.Add(this.txt_numeroCuenta);
            this.groupBox1.Location = new System.Drawing.Point(56, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(955, 344);
            this.groupBox1.TabIndex = 86;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar transacciones";
            // 
            // txt_stCon
            // 
            this.txt_stCon.Enabled = false;
            this.txt_stCon.Location = new System.Drawing.Point(690, 119);
            this.txt_stCon.Name = "txt_stCon";
            this.txt_stCon.ReadOnly = true;
            this.txt_stCon.Size = new System.Drawing.Size(41, 22);
            this.txt_stCon.TabIndex = 90;
            this.txt_stCon.Text = "0";
            this.txt_stCon.Visible = false;
            this.txt_stCon.TextChanged += new System.EventHandler(this.txt_stCon_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(713, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 17);
            this.label6.TabIndex = 88;
            this.label6.Text = "--";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txt_valorTrans
            // 
            this.txt_valorTrans.Enabled = false;
            this.txt_valorTrans.Location = new System.Drawing.Point(641, 119);
            this.txt_valorTrans.Name = "txt_valorTrans";
            this.txt_valorTrans.ReadOnly = true;
            this.txt_valorTrans.Size = new System.Drawing.Size(41, 22);
            this.txt_valorTrans.TabIndex = 89;
            this.txt_valorTrans.Visible = false;
            this.txt_valorTrans.TextChanged += new System.EventHandler(this.txt_valorTrans_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(713, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 88;
            this.label1.Text = "Saldo:";
            // 
            // cb_tipoTrans
            // 
            this.cb_tipoTrans.FormattingEnabled = true;
            this.cb_tipoTrans.Location = new System.Drawing.Point(349, 75);
            this.cb_tipoTrans.Name = "cb_tipoTrans";
            this.cb_tipoTrans.Size = new System.Drawing.Size(203, 24);
            this.cb_tipoTrans.TabIndex = 18;
            this.cb_tipoTrans.SelectedIndexChanged += new System.EventHandler(this.cb_tipoTrans_SelectedIndexChanged);
            // 
            // cb_nCuenta
            // 
            this.cb_nCuenta.FormattingEnabled = true;
            this.cb_nCuenta.Location = new System.Drawing.Point(349, 35);
            this.cb_nCuenta.Name = "cb_nCuenta";
            this.cb_nCuenta.Size = new System.Drawing.Size(203, 24);
            this.cb_nCuenta.TabIndex = 17;
            this.cb_nCuenta.SelectedIndexChanged += new System.EventHandler(this.cb_nCuenta_SelectedIndexChanged);
            // 
            // txt_ttransaccion
            // 
            this.txt_ttransaccion.Location = new System.Drawing.Point(585, 77);
            this.txt_ttransaccion.Name = "txt_ttransaccion";
            this.txt_ttransaccion.Size = new System.Drawing.Size(214, 22);
            this.txt_ttransaccion.TabIndex = 16;
            this.txt_ttransaccion.Visible = false;
            // 
            // txt_estado
            // 
            this.txt_estado.Enabled = false;
            this.txt_estado.Location = new System.Drawing.Point(585, 119);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.ReadOnly = true;
            this.txt_estado.Size = new System.Drawing.Size(41, 22);
            this.txt_estado.TabIndex = 14;
            this.txt_estado.Text = "1";
            this.txt_estado.Visible = false;
            this.txt_estado.TextChanged += new System.EventHandler(this.txt_estado_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_vistaTransacciones);
            this.groupBox2.Location = new System.Drawing.Point(56, 413);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(955, 316);
            this.groupBox2.TabIndex = 87;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vista de transacciones";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblmantenimientostipomovimientoBindingSource
            // 
            this.tblmantenimientostipomovimientoBindingSource.DataMember = "tbl_mantenimientos_tipo_movimiento";
            this.tblmantenimientostipomovimientoBindingSource.DataSource = this.dataSet1;
            // 
            // tbl_mantenimientos_tipo_movimientoTableAdapter
            // 
            this.tbl_mantenimientos_tipo_movimientoTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblmantenimientostipomovimientoBindingSource1
            // 
            this.tblmantenimientostipomovimientoBindingSource1.DataMember = "tbl_mantenimientos_tipo_movimiento";
            this.tblmantenimientostipomovimientoBindingSource1.DataSource = this.dataSet2;
            // 
            // tbl_mantenimientos_tipo_movimientoTableAdapter1
            // 
            this.tbl_mantenimientos_tipo_movimientoTableAdapter1.ClearBeforeFill = true;
            // 
            // dataSet3
            // 
            this.dataSet3.DataSetName = "DataSet3";
            this.dataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblmantenimientostipomovimientoBindingSource2
            // 
            this.tblmantenimientostipomovimientoBindingSource2.DataMember = "tbl_mantenimientos_tipo_movimiento";
            this.tblmantenimientostipomovimientoBindingSource2.DataSource = this.dataSet3;
            // 
            // tbl_mantenimientos_tipo_movimientoTableAdapter2
            // 
            this.tbl_mantenimientos_tipo_movimientoTableAdapter2.ClearBeforeFill = true;
            // 
            // Mov_bancarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(161)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(1069, 756);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_salir_dispo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1069, 803);
            this.MinimumSize = new System.Drawing.Size(888, 659);
            this.Name = "Mov_bancarios";
            this.Text = "Movimientos Bancarios";
            this.Load += new System.EventHandler(this.Mov_bancarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vistaTransacciones)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmantenimientostipomovimientoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmantenimientostipomovimientoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmantenimientostipomovimientoBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_valorTransferencia;
        private System.Windows.Forms.TextBox txt_numeroCuenta;
        private System.Windows.Forms.RichTextBox txt_descripcionTransferencia;
        private System.Windows.Forms.Button btn_rtrans;
        private System.Windows.Forms.DataGridView dgv_vistaTransacciones;
        private System.Windows.Forms.Button btn_cancelarTransaccion;
        private System.Windows.Forms.Button btn_salir_dispo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource tblmantenimientostipomovimientoBindingSource;
        private DataSet1TableAdapters.tbl_mantenimientos_tipo_movimientoTableAdapter tbl_mantenimientos_tipo_movimientoTableAdapter;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource tblmantenimientostipomovimientoBindingSource1;
        private DataSet2TableAdapters.tbl_mantenimientos_tipo_movimientoTableAdapter tbl_mantenimientos_tipo_movimientoTableAdapter1;
        private DataSet3 dataSet3;
        private System.Windows.Forms.BindingSource tblmantenimientostipomovimientoBindingSource2;
        private DataSet3TableAdapters.tbl_mantenimientos_tipo_movimientoTableAdapter tbl_mantenimientos_tipo_movimientoTableAdapter2;
        private System.Windows.Forms.TextBox txt_estado;
        private System.Windows.Forms.TextBox txt_ttransaccion;
        private System.Windows.Forms.ComboBox cb_tipoTrans;
        private System.Windows.Forms.ComboBox cb_nCuenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_valorTrans;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_stCon;
    }
}