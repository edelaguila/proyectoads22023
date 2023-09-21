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
            this.dt_inv = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dt_inv)).BeginInit();
            this.SuspendLayout();
            // 
            // dt_inv
            // 
            this.dt_inv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_inv.Location = new System.Drawing.Point(76, 228);
            this.dt_inv.Name = "dt_inv";
            this.dt_inv.RowHeadersWidth = 51;
            this.dt_inv.RowTemplate.Height = 24;
            this.dt_inv.Size = new System.Drawing.Size(853, 282);
            this.dt_inv.TabIndex = 0;
            this.dt_inv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.Controls.Add(this.dt_inv);
            this.Name = "frmVisualizarInventario";
            this.Text = "frmVisualizarInventario";
            ((System.ComponentModel.ISupportInitialize)(this.dt_inv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dt_inv;
        private System.Windows.Forms.Label label3;
    }
}