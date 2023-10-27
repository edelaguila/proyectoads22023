
namespace CapaVistaBancos
{
    partial class Mantenimiento_agregar_cuenta
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
            this.tblmonedabancoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet4 = new CapaVistaBancos.DataSet4();
            this.tblmantenimientosagregarbancosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet5 = new CapaVistaBancos.DataSet5();
            this.tblmantenimientosagregarcuentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet6 = new CapaVistaBancos.DataSet6();
            this.btn_salir_dispo = new System.Windows.Forms.Button();
            this.tbl_monedabancoTableAdapter = new CapaVistaBancos.DataSet4TableAdapters.tbl_monedabancoTableAdapter();
            this.tbl_mantenimientos_agregar_bancosTableAdapter = new CapaVistaBancos.DataSet5TableAdapters.tbl_mantenimientos_agregar_bancosTableAdapter();
            this.tbl_mantenimientos_agregar_cuentaTableAdapter = new CapaVistaBancos.DataSet6TableAdapters.tbl_mantenimientos_agregar_cuentaTableAdapter();
            this.txt_numcuenta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cb_tipomoneda = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_alias = new System.Windows.Forms.TextBox();
            this.cb_tipocuenta = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_selectbanco = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.navegador1 = new CapaVista.Navegador();
            ((System.ComponentModel.ISupportInitialize)(this.tblmonedabancoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmantenimientosagregarbancosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmantenimientosagregarcuentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tblmonedabancoBindingSource
            // 
            this.tblmonedabancoBindingSource.DataMember = "tbl_monedabanco";
            this.tblmonedabancoBindingSource.DataSource = this.dataSet4;
            // 
            // dataSet4
            // 
            this.dataSet4.DataSetName = "DataSet4";
            this.dataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblmantenimientosagregarbancosBindingSource
            // 
            this.tblmantenimientosagregarbancosBindingSource.DataMember = "tbl_mantenimientos_agregar_bancos";
            this.tblmantenimientosagregarbancosBindingSource.DataSource = this.dataSet5;
            // 
            // dataSet5
            // 
            this.dataSet5.DataSetName = "DataSet5";
            this.dataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblmantenimientosagregarcuentaBindingSource
            // 
            this.tblmantenimientosagregarcuentaBindingSource.DataMember = "tbl_mantenimientos_agregar_cuenta";
            this.tblmantenimientosagregarcuentaBindingSource.DataSource = this.dataSet6;
            // 
            // dataSet6
            // 
            this.dataSet6.DataSetName = "DataSet6";
            this.dataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.btn_salir_dispo.TabIndex = 86;
            this.btn_salir_dispo.Text = "Salir";
            this.btn_salir_dispo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_salir_dispo.UseVisualStyleBackColor = false;
            this.btn_salir_dispo.Click += new System.EventHandler(this.btn_salir_dispo_Click);
            // 
            // tbl_monedabancoTableAdapter
            // 
            this.tbl_monedabancoTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_mantenimientos_agregar_bancosTableAdapter
            // 
            this.tbl_mantenimientos_agregar_bancosTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_mantenimientos_agregar_cuentaTableAdapter
            // 
            this.tbl_mantenimientos_agregar_cuentaTableAdapter.ClearBeforeFill = true;
            // 
            // txt_numcuenta
            // 
            this.txt_numcuenta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numcuenta.Location = new System.Drawing.Point(242, 216);
            this.txt_numcuenta.Name = "txt_numcuenta";
            this.txt_numcuenta.Size = new System.Drawing.Size(169, 26);
            this.txt_numcuenta.TabIndex = 91;
            this.txt_numcuenta.Tag = "manac_numero_de_cuenta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 87;
            this.label1.Text = "Tipo de moneda: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(59, 337);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(951, 174);
            this.dataGridView1.TabIndex = 97;
            // 
            // cb_tipomoneda
            // 
            this.cb_tipomoneda.DataSource = this.tblmonedabancoBindingSource;
            this.cb_tipomoneda.DisplayMember = "mon_nomMoneda";
            this.cb_tipomoneda.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tipomoneda.FormattingEnabled = true;
            this.cb_tipomoneda.Location = new System.Drawing.Point(242, 258);
            this.cb_tipomoneda.Name = "cb_tipomoneda";
            this.cb_tipomoneda.Size = new System.Drawing.Size(169, 28);
            this.cb_tipomoneda.TabIndex = 88;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 89;
            this.label2.Text = "Número de cuenta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(500, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 20);
            this.label6.TabIndex = 96;
            this.label6.Text = "Seleccione un banco:";
            // 
            // txt_alias
            // 
            this.txt_alias.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_alias.Location = new System.Drawing.Point(684, 251);
            this.txt_alias.Name = "txt_alias";
            this.txt_alias.Size = new System.Drawing.Size(169, 26);
            this.txt_alias.TabIndex = 90;
            // 
            // cb_tipocuenta
            // 
            this.cb_tipocuenta.DataSource = this.tblmantenimientosagregarcuentaBindingSource;
            this.cb_tipocuenta.DisplayMember = "manac_tipo_de_cuenta";
            this.cb_tipocuenta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tipocuenta.FormattingEnabled = true;
            this.cb_tipocuenta.Location = new System.Drawing.Point(242, 294);
            this.cb_tipocuenta.Name = "cb_tipocuenta";
            this.cb_tipocuenta.Size = new System.Drawing.Size(169, 28);
            this.cb_tipocuenta.TabIndex = 95;
            this.cb_tipocuenta.ValueMember = "manac_tipo_de_cuenta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(500, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 92;
            this.label3.Text = "Alias:";
            // 
            // cb_selectbanco
            // 
            this.cb_selectbanco.DataSource = this.tblmantenimientosagregarbancosBindingSource;
            this.cb_selectbanco.DisplayMember = "manag_nombre_banco";
            this.cb_selectbanco.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_selectbanco.FormattingEnabled = true;
            this.cb_selectbanco.Location = new System.Drawing.Point(684, 216);
            this.cb_selectbanco.Name = "cb_selectbanco";
            this.cb_selectbanco.Size = new System.Drawing.Size(169, 28);
            this.cb_selectbanco.TabIndex = 94;
            this.cb_selectbanco.ValueMember = "manag_nombre_banco";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 93;
            this.label5.Text = "Tipo de cuenta:";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(31, 81);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1001, 96);
            this.navegador1.TabIndex = 98;
            // 
            // Mantenimiento_agregar_cuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(161)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(1069, 803);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.txt_numcuenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cb_tipomoneda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_alias);
            this.Controls.Add(this.cb_tipocuenta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_selectbanco);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_salir_dispo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1069, 803);
            this.MinimumSize = new System.Drawing.Size(888, 659);
            this.Name = "Mantenimiento_agregar_cuenta";
            this.Text = "Mantenimiento Agregar Cuenta";
            this.Load += new System.EventHandler(this.Mantenimiento_agregar_cuenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblmonedabancoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmantenimientosagregarbancosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmantenimientosagregarcuentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_salir_dispo;
        private DataSet4 dataSet4;
        private System.Windows.Forms.BindingSource tblmonedabancoBindingSource;
        private DataSet4TableAdapters.tbl_monedabancoTableAdapter tbl_monedabancoTableAdapter;
        private DataSet5 dataSet5;
        private System.Windows.Forms.BindingSource tblmantenimientosagregarbancosBindingSource;
        private DataSet5TableAdapters.tbl_mantenimientos_agregar_bancosTableAdapter tbl_mantenimientos_agregar_bancosTableAdapter;
        private DataSet6 dataSet6;
        private System.Windows.Forms.BindingSource tblmantenimientosagregarcuentaBindingSource;
        private DataSet6TableAdapters.tbl_mantenimientos_agregar_cuentaTableAdapter tbl_mantenimientos_agregar_cuentaTableAdapter;
        private System.Windows.Forms.TextBox txt_numcuenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cb_tipomoneda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_alias;
        private System.Windows.Forms.ComboBox cb_tipocuenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_selectbanco;
        private System.Windows.Forms.Label label5;
        private CapaVista.Navegador navegador1;
    }
}