
namespace CapaVistaBancos
{
    partial class verbanco
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
            this.dataSet9 = new CapaVistaBancos.DataSet9();
            this.tblmantenimientosagregarbancosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_mantenimientos_agregar_bancosTableAdapter = new CapaVistaBancos.DataSet9TableAdapters.tbl_mantenimientos_agregar_bancosTableAdapter();
            this.dataSet10 = new CapaVistaBancos.DataSet10();
            this.tblbancoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_bancoTableAdapter = new CapaVistaBancos.DataSet10TableAdapters.tbl_bancoTableAdapter();
            this.pkmanagidbanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managidbancoagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managnombrebancoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmantenimientosagregarbancosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblbancoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pkmanagidbanDataGridViewTextBoxColumn,
            this.managidbancoagDataGridViewTextBoxColumn,
            this.managnombrebancoDataGridViewTextBoxColumn,
            this.managstatusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblmantenimientosagregarbancosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(802, 454);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataSet9
            // 
            this.dataSet9.DataSetName = "DataSet9";
            this.dataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblmantenimientosagregarbancosBindingSource
            // 
            this.tblmantenimientosagregarbancosBindingSource.DataMember = "tbl_mantenimientos_agregar_bancos";
            this.tblmantenimientosagregarbancosBindingSource.DataSource = this.dataSet9;
            // 
            // tbl_mantenimientos_agregar_bancosTableAdapter
            // 
            this.tbl_mantenimientos_agregar_bancosTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet10
            // 
            this.dataSet10.DataSetName = "DataSet10";
            this.dataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblbancoBindingSource
            // 
            this.tblbancoBindingSource.DataMember = "tbl_banco";
            this.tblbancoBindingSource.DataSource = this.dataSet10;
            // 
            // tbl_bancoTableAdapter
            // 
            this.tbl_bancoTableAdapter.ClearBeforeFill = true;
            // 
            // pkmanagidbanDataGridViewTextBoxColumn
            // 
            this.pkmanagidbanDataGridViewTextBoxColumn.DataPropertyName = "pk_manag_id_ban";
            this.pkmanagidbanDataGridViewTextBoxColumn.HeaderText = "pk_manag_id_ban";
            this.pkmanagidbanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pkmanagidbanDataGridViewTextBoxColumn.Name = "pkmanagidbanDataGridViewTextBoxColumn";
            this.pkmanagidbanDataGridViewTextBoxColumn.Width = 125;
            // 
            // managidbancoagDataGridViewTextBoxColumn
            // 
            this.managidbancoagDataGridViewTextBoxColumn.DataPropertyName = "manag_id_bancoag";
            this.managidbancoagDataGridViewTextBoxColumn.HeaderText = "manag_id_bancoag";
            this.managidbancoagDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.managidbancoagDataGridViewTextBoxColumn.Name = "managidbancoagDataGridViewTextBoxColumn";
            this.managidbancoagDataGridViewTextBoxColumn.Width = 125;
            // 
            // managnombrebancoDataGridViewTextBoxColumn
            // 
            this.managnombrebancoDataGridViewTextBoxColumn.DataPropertyName = "manag_nombre_banco";
            this.managnombrebancoDataGridViewTextBoxColumn.HeaderText = "manag_nombre_banco";
            this.managnombrebancoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.managnombrebancoDataGridViewTextBoxColumn.Name = "managnombrebancoDataGridViewTextBoxColumn";
            this.managnombrebancoDataGridViewTextBoxColumn.Width = 125;
            // 
            // managstatusDataGridViewTextBoxColumn
            // 
            this.managstatusDataGridViewTextBoxColumn.DataPropertyName = "manag_status";
            this.managstatusDataGridViewTextBoxColumn.HeaderText = "manag_status";
            this.managstatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.managstatusDataGridViewTextBoxColumn.Name = "managstatusDataGridViewTextBoxColumn";
            this.managstatusDataGridViewTextBoxColumn.Width = 125;
            // 
            // verbanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "verbanco";
            this.Text = "Datos de Bancos";
            this.Load += new System.EventHandler(this.verbanco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmantenimientosagregarbancosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblbancoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet9 dataSet9;
        private System.Windows.Forms.BindingSource tblmantenimientosagregarbancosBindingSource;
        private DataSet9TableAdapters.tbl_mantenimientos_agregar_bancosTableAdapter tbl_mantenimientos_agregar_bancosTableAdapter;
        private DataSet10 dataSet10;
        private System.Windows.Forms.BindingSource tblbancoBindingSource;
        private DataSet10TableAdapters.tbl_bancoTableAdapter tbl_bancoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkmanagidbanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn managidbancoagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn managnombrebancoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn managstatusDataGridViewTextBoxColumn;
    }
}