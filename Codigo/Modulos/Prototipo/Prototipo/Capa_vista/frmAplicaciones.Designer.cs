
namespace Vista_PrototipoMenu
{
    partial class frmAplicaciones
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
            this.navegador1 = new NavegadorVista.Navegador();
            this.txtIdAplicacion = new System.Windows.Forms.TextBox();
            this.txtNombreAplicacion = new System.Windows.Forms.TextBox();
            this.txtDescripcionAplicacion = new System.Windows.Forms.TextBox();
            this.txtEstadoAplicacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(-3, -1);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(765, 193);
            this.navegador1.TabIndex = 0;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // txtIdAplicacion
            // 
            this.txtIdAplicacion.Location = new System.Drawing.Point(285, 202);
            this.txtIdAplicacion.Name = "txtIdAplicacion";
            this.txtIdAplicacion.Size = new System.Drawing.Size(250, 22);
            this.txtIdAplicacion.TabIndex = 1;
            this.txtIdAplicacion.Tag = "pk_id_aplicacion";
            // 
            // txtNombreAplicacion
            // 
            this.txtNombreAplicacion.Location = new System.Drawing.Point(285, 230);
            this.txtNombreAplicacion.Name = "txtNombreAplicacion";
            this.txtNombreAplicacion.Size = new System.Drawing.Size(250, 22);
            this.txtNombreAplicacion.TabIndex = 2;
            this.txtNombreAplicacion.Tag = "nombre_aplicacion";
            // 
            // txtDescripcionAplicacion
            // 
            this.txtDescripcionAplicacion.Location = new System.Drawing.Point(285, 258);
            this.txtDescripcionAplicacion.Name = "txtDescripcionAplicacion";
            this.txtDescripcionAplicacion.Size = new System.Drawing.Size(250, 22);
            this.txtDescripcionAplicacion.TabIndex = 3;
            this.txtDescripcionAplicacion.Tag = "descripcion_aplicacion";
            // 
            // txtEstadoAplicacion
            // 
            this.txtEstadoAplicacion.Location = new System.Drawing.Point(285, 286);
            this.txtEstadoAplicacion.Name = "txtEstadoAplicacion";
            this.txtEstadoAplicacion.Size = new System.Drawing.Size(250, 22);
            this.txtEstadoAplicacion.TabIndex = 4;
            this.txtEstadoAplicacion.Tag = "estado_aplicacion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Identificacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Descripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Estado";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 331);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(733, 166);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.Tag = "tbl_aplicaciones";
            // 
            // frmAplicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 503);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEstadoAplicacion);
            this.Controls.Add(this.txtDescripcionAplicacion);
            this.Controls.Add(this.txtNombreAplicacion);
            this.Controls.Add(this.txtIdAplicacion);
            this.Controls.Add(this.navegador1);
            this.Name = "frmAplicaciones";
            this.Text = "frmAplicaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NavegadorVista.Navegador navegador1;
        private System.Windows.Forms.TextBox txtIdAplicacion;
        private System.Windows.Forms.TextBox txtNombreAplicacion;
        private System.Windows.Forms.TextBox txtDescripcionAplicacion;
        private System.Windows.Forms.TextBox txtEstadoAplicacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}