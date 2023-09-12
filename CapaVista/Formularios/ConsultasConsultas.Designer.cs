
namespace CapaVista.Formularios
{
    partial class ConsultasConsultas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_cadenagenerada = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_query = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_datosconsulta = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datosconsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_cadenagenerada);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cb_query);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(773, 147);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado";
            // 
            // txt_cadenagenerada
            // 
            this.txt_cadenagenerada.Enabled = false;
            this.txt_cadenagenerada.Location = new System.Drawing.Point(197, 79);
            this.txt_cadenagenerada.Name = "txt_cadenagenerada";
            this.txt_cadenagenerada.Size = new System.Drawing.Size(519, 23);
            this.txt_cadenagenerada.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cadena Generada";
            // 
            // cb_query
            // 
            this.cb_query.FormattingEnabled = true;
            this.cb_query.Location = new System.Drawing.Point(37, 75);
            this.cb_query.Name = "cb_query";
            this.cb_query.Size = new System.Drawing.Size(121, 25);
            this.cb_query.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Query";
            // 
            // dgv_datosconsulta
            // 
            this.dgv_datosconsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_datosconsulta.Location = new System.Drawing.Point(23, 201);
            this.dgv_datosconsulta.Name = "dgv_datosconsulta";
            this.dgv_datosconsulta.Size = new System.Drawing.Size(773, 209);
            this.dgv_datosconsulta.TabIndex = 1;
            // 
            // ConsultasConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 459);
            this.Controls.Add(this.dgv_datosconsulta);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultasConsultas";
            this.Text = "ConsultasConsultas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datosconsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_cadenagenerada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_query;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_datosconsulta;
    }
}