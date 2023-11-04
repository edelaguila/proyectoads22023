
namespace CapaVistaBancos
{
    partial class vertransaccion
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet11 = new CapaVistaBancos.DataSet11();
            this.tblmantenimientostipomovimientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_mantenimientos_tipo_movimientoTableAdapter = new CapaVistaBancos.DataSet11TableAdapters.tbl_mantenimientos_tipo_movimientoTableAdapter();
            this.pkmovtmidtransaccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movtmtransaccionesexistentesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movtmstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmantenimientostipomovimientoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pkmovtmidtransaccionDataGridViewTextBoxColumn,
            this.movtmtransaccionesexistentesDataGridViewTextBoxColumn,
            this.movtmstatusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblmantenimientostipomovimientoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(803, 448);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet11";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblmantenimientostipomovimientoBindingSource
            // 
            this.tblmantenimientostipomovimientoBindingSource.DataMember = "tbl_mantenimientos_tipo_movimiento";
            this.tblmantenimientostipomovimientoBindingSource.DataSource = this.dataSet11;
            // 
            // tbl_mantenimientos_tipo_movimientoTableAdapter
            // 
            this.tbl_mantenimientos_tipo_movimientoTableAdapter.ClearBeforeFill = true;
            // 
            // pkmovtmidtransaccionDataGridViewTextBoxColumn
            // 
            this.pkmovtmidtransaccionDataGridViewTextBoxColumn.DataPropertyName = "pk_movtm_id_transaccion";
            this.pkmovtmidtransaccionDataGridViewTextBoxColumn.HeaderText = "pk_movtm_id_transaccion";
            this.pkmovtmidtransaccionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pkmovtmidtransaccionDataGridViewTextBoxColumn.Name = "pkmovtmidtransaccionDataGridViewTextBoxColumn";
            this.pkmovtmidtransaccionDataGridViewTextBoxColumn.Width = 125;
            // 
            // movtmtransaccionesexistentesDataGridViewTextBoxColumn
            // 
            this.movtmtransaccionesexistentesDataGridViewTextBoxColumn.DataPropertyName = "movtm_transacciones_existentes";
            this.movtmtransaccionesexistentesDataGridViewTextBoxColumn.HeaderText = "movtm_transacciones_existentes";
            this.movtmtransaccionesexistentesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.movtmtransaccionesexistentesDataGridViewTextBoxColumn.Name = "movtmtransaccionesexistentesDataGridViewTextBoxColumn";
            this.movtmtransaccionesexistentesDataGridViewTextBoxColumn.Width = 125;
            // 
            // movtmstatusDataGridViewTextBoxColumn
            // 
            this.movtmstatusDataGridViewTextBoxColumn.DataPropertyName = "movtm_status";
            this.movtmstatusDataGridViewTextBoxColumn.HeaderText = "movtm_status";
            this.movtmstatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.movtmstatusDataGridViewTextBoxColumn.Name = "movtmstatusDataGridViewTextBoxColumn";
            this.movtmstatusDataGridViewTextBoxColumn.Width = 125;
            // 
            // vertransaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "vertransaccion";
            this.Text = "vertransaccion";
            this.Load += new System.EventHandler(this.vertransaccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmantenimientostipomovimientoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet11 dataSet11;
        private System.Windows.Forms.BindingSource tblmantenimientostipomovimientoBindingSource;
        private DataSet11TableAdapters.tbl_mantenimientos_tipo_movimientoTableAdapter tbl_mantenimientos_tipo_movimientoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkmovtmidtransaccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn movtmtransaccionesexistentesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn movtmstatusDataGridViewTextBoxColumn;
    }
}