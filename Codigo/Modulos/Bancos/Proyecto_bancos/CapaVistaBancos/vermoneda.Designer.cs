
namespace CapaVistaBancos
{
    partial class vermoneda
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
            this.dgv_moneda = new System.Windows.Forms.DataGridView();
            this.dataSet8 = new CapaVistaBancos.DataSet8();
            this.tblmonedabancoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_monedabancoTableAdapter = new CapaVistaBancos.DataSet8TableAdapters.tbl_monedabancoTableAdapter();
            this.pkmonidmonedaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monnomMonedaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_moneda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmonedabancoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_moneda
            // 
            this.dgv_moneda.AutoGenerateColumns = false;
            this.dgv_moneda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_moneda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pkmonidmonedaDataGridViewTextBoxColumn,
            this.monnomMonedaDataGridViewTextBoxColumn,
            this.monstatusDataGridViewTextBoxColumn});
            this.dgv_moneda.DataSource = this.tblmonedabancoBindingSource;
            this.dgv_moneda.Location = new System.Drawing.Point(-1, -2);
            this.dgv_moneda.Name = "dgv_moneda";
            this.dgv_moneda.RowHeadersWidth = 51;
            this.dgv_moneda.RowTemplate.Height = 24;
            this.dgv_moneda.Size = new System.Drawing.Size(802, 448);
            this.dgv_moneda.TabIndex = 0;
            // 
            // dataSet8
            // 
            this.dataSet8.DataSetName = "DataSet8";
            this.dataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblmonedabancoBindingSource
            // 
            this.tblmonedabancoBindingSource.DataMember = "tbl_monedabanco";
            this.tblmonedabancoBindingSource.DataSource = this.dataSet8;
            // 
            // tbl_monedabancoTableAdapter
            // 
            this.tbl_monedabancoTableAdapter.ClearBeforeFill = true;
            // 
            // pkmonidmonedaDataGridViewTextBoxColumn
            // 
            this.pkmonidmonedaDataGridViewTextBoxColumn.DataPropertyName = "pk_mon_id_moneda";
            this.pkmonidmonedaDataGridViewTextBoxColumn.HeaderText = "pk_mon_id_moneda";
            this.pkmonidmonedaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pkmonidmonedaDataGridViewTextBoxColumn.Name = "pkmonidmonedaDataGridViewTextBoxColumn";
            this.pkmonidmonedaDataGridViewTextBoxColumn.Width = 125;
            // 
            // monnomMonedaDataGridViewTextBoxColumn
            // 
            this.monnomMonedaDataGridViewTextBoxColumn.DataPropertyName = "mon_nomMoneda";
            this.monnomMonedaDataGridViewTextBoxColumn.HeaderText = "mon_nomMoneda";
            this.monnomMonedaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.monnomMonedaDataGridViewTextBoxColumn.Name = "monnomMonedaDataGridViewTextBoxColumn";
            this.monnomMonedaDataGridViewTextBoxColumn.Width = 125;
            // 
            // monstatusDataGridViewTextBoxColumn
            // 
            this.monstatusDataGridViewTextBoxColumn.DataPropertyName = "mon_status";
            this.monstatusDataGridViewTextBoxColumn.HeaderText = "mon_status";
            this.monstatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.monstatusDataGridViewTextBoxColumn.Name = "monstatusDataGridViewTextBoxColumn";
            this.monstatusDataGridViewTextBoxColumn.Width = 125;
            // 
            // vermoneda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_moneda);
            this.Name = "vermoneda";
            this.Text = "Monedas";
            this.Load += new System.EventHandler(this.vermoneda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_moneda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmonedabancoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_moneda;
        private DataSet8 dataSet8;
        private System.Windows.Forms.BindingSource tblmonedabancoBindingSource;
        private DataSet8TableAdapters.tbl_monedabancoTableAdapter tbl_monedabancoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkmonidmonedaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monnomMonedaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monstatusDataGridViewTextBoxColumn;
    }
}