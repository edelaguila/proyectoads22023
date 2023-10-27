
namespace CapaVistaBancos
{
    partial class Mantenimiento_tipoMov
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
            this.tblmantenimientostipomovimientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet7 = new CapaVistaBancos.DataSet7();
            this.btn_salir_dispo = new System.Windows.Forms.Button();
            this.tbl_mantenimientos_tipo_movimientoTableAdapter = new CapaVistaBancos.DataSet7TableAdapters.tbl_mantenimientos_tipo_movimientoTableAdapter();
            this.cb_transaexis = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_idtras = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tipotrans = new System.Windows.Forms.TextBox();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.navegador1 = new CapaVista.Navegador();
            ((System.ComponentModel.ISupportInitialize)(this.tblmantenimientostipomovimientoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tblmantenimientostipomovimientoBindingSource
            // 
            this.tblmantenimientostipomovimientoBindingSource.DataMember = "tbl_mantenimientos_tipo_movimiento";
            this.tblmantenimientostipomovimientoBindingSource.DataSource = this.dataSet7;
            // 
            // dataSet7
            // 
            this.dataSet7.DataSetName = "DataSet7";
            this.dataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tbl_mantenimientos_tipo_movimientoTableAdapter
            // 
            this.tbl_mantenimientos_tipo_movimientoTableAdapter.ClearBeforeFill = true;
            // 
            // cb_transaexis
            // 
            this.cb_transaexis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_transaexis.DataSource = this.tblmantenimientostipomovimientoBindingSource;
            this.cb_transaexis.DisplayMember = "movtm_transacciones_existentes";
            this.cb_transaexis.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_transaexis.FormattingEnabled = true;
            this.cb_transaexis.Location = new System.Drawing.Point(308, 223);
            this.cb_transaexis.Name = "cb_transaexis";
            this.cb_transaexis.Size = new System.Drawing.Size(199, 28);
            this.cb_transaexis.TabIndex = 91;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 88;
            this.label2.Text = "ID de transacción:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 89;
            this.label3.Text = "Tipo de transacción:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(71, 317);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(927, 231);
            this.dataGridView1.TabIndex = 94;
            // 
            // txt_idtras
            // 
            this.txt_idtras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_idtras.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idtras.Location = new System.Drawing.Point(308, 175);
            this.txt_idtras.Name = "txt_idtras";
            this.txt_idtras.Size = new System.Drawing.Size(199, 26);
            this.txt_idtras.TabIndex = 90;
            this.txt_idtras.Tag = "pk_movtm_id_transaccion";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 20);
            this.label4.TabIndex = 93;
            this.label4.Text = "Transacciones existentes:";
            // 
            // txt_tipotrans
            // 
            this.txt_tipotrans.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_tipotrans.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tipotrans.Location = new System.Drawing.Point(308, 265);
            this.txt_tipotrans.Name = "txt_tipotrans";
            this.txt_tipotrans.Size = new System.Drawing.Size(199, 26);
            this.txt_tipotrans.TabIndex = 92;
            this.txt_tipotrans.Tag = "movtm_transacciones_existentes";
            // 
            // txt_estado
            // 
            this.txt_estado.Enabled = false;
            this.txt_estado.Location = new System.Drawing.Point(840, 175);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(21, 22);
            this.txt_estado.TabIndex = 95;
            this.txt_estado.Tag = "movtm_status";
            this.txt_estado.Text = "1";
            this.txt_estado.Visible = false;
            this.txt_estado.TextChanged += new System.EventHandler(this.txt_estado_TextChanged);
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(13, 72);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1001, 96);
            this.navegador1.TabIndex = 96;
            // 
            // Mantenimiento_tipoMov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(161)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(1069, 756);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.txt_estado);
            this.Controls.Add(this.cb_transaexis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_idtras);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_tipotrans);
            this.Controls.Add(this.btn_salir_dispo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1069, 803);
            this.MinimumSize = new System.Drawing.Size(888, 659);
            this.Name = "Mantenimiento_tipoMov";
            this.Text = "Mantenimiento de Tipo de movimiento";
            this.Load += new System.EventHandler(this.Mantenimiento_tipoMov_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblmantenimientostipomovimientoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_salir_dispo;
        private DataSet7 dataSet7;
        private System.Windows.Forms.BindingSource tblmantenimientostipomovimientoBindingSource;
        private DataSet7TableAdapters.tbl_mantenimientos_tipo_movimientoTableAdapter tbl_mantenimientos_tipo_movimientoTableAdapter;
        private System.Windows.Forms.ComboBox cb_transaexis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_idtras;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tipotrans;
        private System.Windows.Forms.TextBox txt_estado;
        private CapaVista.Navegador navegador1;
    }
}