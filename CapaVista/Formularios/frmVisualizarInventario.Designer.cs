namespace CapaVista.Formularios
{
    partial class frmVisualizarInventario
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Cod_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Entrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod_Producto,
            this.Nombre_Producto,
            this.Nombre_Proveedor,
            this.Unidades,
            this.Fecha_Entrega});
            this.dataGridView1.Location = new System.Drawing.Point(155, 220);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(678, 282);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Cod_Producto
            // 
            this.Cod_Producto.HeaderText = "Cod_Producto";
            this.Cod_Producto.MinimumWidth = 6;
            this.Cod_Producto.Name = "Cod_Producto";
            this.Cod_Producto.Width = 125;
            // 
            // Nombre_Producto
            // 
            this.Nombre_Producto.HeaderText = "Nombre_Producto";
            this.Nombre_Producto.MinimumWidth = 6;
            this.Nombre_Producto.Name = "Nombre_Producto";
            this.Nombre_Producto.Width = 125;
            // 
            // Nombre_Proveedor
            // 
            this.Nombre_Proveedor.HeaderText = "Nombre_Proveedor";
            this.Nombre_Proveedor.MinimumWidth = 6;
            this.Nombre_Proveedor.Name = "Nombre_Proveedor";
            this.Nombre_Proveedor.Width = 125;
            // 
            // Unidades
            // 
            this.Unidades.HeaderText = "Unidades";
            this.Unidades.MinimumWidth = 6;
            this.Unidades.Name = "Unidades";
            this.Unidades.Width = 125;
            // 
            // Fecha_Entrega
            // 
            this.Fecha_Entrega.HeaderText = "Fecha_Entrega";
            this.Fecha_Entrega.MinimumWidth = 6;
            this.Fecha_Entrega.Name = "Fecha_Entrega";
            this.Fecha_Entrega.Width = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(424, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Inventario";
            // 
            // frmVisualizarInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(161)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(976, 548);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmVisualizarInventario";
            this.Text = "frmVisualizarInventario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Entrega;
        private System.Windows.Forms.Label label3;
    }
}