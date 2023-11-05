
namespace Vista_PrototipoMenu
{
    partial class frmTipoHabitacion
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
            this._navegador = new NavegadorVista.Navegador();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.txt_capacidad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // _navegador
            // 
            this._navegador.Location = new System.Drawing.Point(109, 12);
            this._navegador.Name = "_navegador";
            this._navegador.Size = new System.Drawing.Size(572, 152);
            this._navegador.TabIndex = 0;
            this._navegador.Load += new System.EventHandler(this._navegador_Load);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(53, 295);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(703, 132);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.Tag = "tbl_tipohabitacion";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(53, 183);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 20);
            this.txt_id.TabIndex = 2;
            this.txt_id.Tag = "thab_id";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(186, 183);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre.TabIndex = 3;
            this.txt_nombre.Tag = "thab_nombre";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(325, 183);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(100, 20);
            this.txt_descripcion.TabIndex = 4;
            this.txt_descripcion.Tag = "thab_descripcion";
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(456, 183);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(100, 20);
            this.txt_precio.TabIndex = 5;
            this.txt_precio.Tag = "thab_precio";
            // 
            // txt_capacidad
            // 
            this.txt_capacidad.Location = new System.Drawing.Point(581, 183);
            this.txt_capacidad.Name = "txt_capacidad";
            this.txt_capacidad.Size = new System.Drawing.Size(100, 20);
            this.txt_capacidad.TabIndex = 6;
            this.txt_capacidad.Tag = "thab_capacidad";
            // 
            // frmTipoHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_capacidad);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this._navegador);
            this.Name = "frmTipoHabitacion";
            this.Text = "frmTipoHabitacion";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NavegadorVista.Navegador _navegador;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.TextBox txt_capacidad;
    }
}