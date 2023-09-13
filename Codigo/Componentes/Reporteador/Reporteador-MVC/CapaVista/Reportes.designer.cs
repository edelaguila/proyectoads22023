
namespace Reporteador
{
    partial class Reportes
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
            this.dgv_reportes = new System.Windows.Forms.DataGridView();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_ver = new System.Windows.Forms.Button();
            this.btn_ruta = new System.Windows.Forms.Button();
            this.txt_ruta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reportes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_reportes
            // 
            this.dgv_reportes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_reportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_reportes.Location = new System.Drawing.Point(43, 276);
            this.dgv_reportes.Name = "dgv_reportes";
            this.dgv_reportes.ReadOnly = true;
            this.dgv_reportes.RowHeadersWidth = 51;
            this.dgv_reportes.RowTemplate.Height = 24;
            this.dgv_reportes.Size = new System.Drawing.Size(708, 162);
            this.dgv_reportes.TabIndex = 0;
            this.dgv_reportes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_reportes_CellContentClick);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.Black;
            this.btn_eliminar.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_eliminar.Location = new System.Drawing.Point(297, 214);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(205, 37);
            this.btn_eliminar.TabIndex = 1;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackColor = System.Drawing.Color.Black;
            this.btn_modificar.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.ForeColor = System.Drawing.Color.White;
            this.btn_modificar.Location = new System.Drawing.Point(546, 216);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(205, 36);
            this.btn_modificar.TabIndex = 2;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = false;
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.Black;
            this.btn_guardar.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.White;
            this.btn_guardar.Location = new System.Drawing.Point(43, 214);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(205, 36);
            this.btn_guardar.TabIndex = 3;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_ver
            // 
            this.btn_ver.BackColor = System.Drawing.Color.Black;
            this.btn_ver.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ver.ForeColor = System.Drawing.Color.White;
            this.btn_ver.Location = new System.Drawing.Point(546, 157);
            this.btn_ver.Name = "btn_ver";
            this.btn_ver.Size = new System.Drawing.Size(205, 36);
            this.btn_ver.TabIndex = 4;
            this.btn_ver.Text = "Ver Reporte";
            this.btn_ver.UseVisualStyleBackColor = false;
            this.btn_ver.Click += new System.EventHandler(this.btn_ver_Click);
            // 
            // btn_ruta
            // 
            this.btn_ruta.BackColor = System.Drawing.Color.Black;
            this.btn_ruta.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ruta.ForeColor = System.Drawing.Color.White;
            this.btn_ruta.Location = new System.Drawing.Point(546, 96);
            this.btn_ruta.Name = "btn_ruta";
            this.btn_ruta.Size = new System.Drawing.Size(205, 36);
            this.btn_ruta.TabIndex = 5;
            this.btn_ruta.Text = "Ruta";
            this.btn_ruta.UseVisualStyleBackColor = false;
            this.btn_ruta.Click += new System.EventHandler(this.btn_ruta_Click);
            // 
            // txt_ruta
            // 
            this.txt_ruta.Location = new System.Drawing.Point(43, 96);
            this.txt_ruta.Name = "txt_ruta";
            this.txt_ruta.Size = new System.Drawing.Size(459, 22);
            this.txt_ruta.TabIndex = 6;
            this.txt_ruta.TextChanged += new System.EventHandler(this.txt_ruta_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(339, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "Reportes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(235)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ruta);
            this.Controls.Add(this.btn_ruta);
            this.Controls.Add(this.btn_ver);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.dgv_reportes);
            this.Name = "Reportes";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.Reportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reportes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_reportes;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_ver;
        private System.Windows.Forms.Button btn_ruta;
        private System.Windows.Forms.TextBox txt_ruta;
        private System.Windows.Forms.Label label1;
    }
}