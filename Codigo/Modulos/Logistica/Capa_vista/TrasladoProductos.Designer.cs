
namespace Vista_PrototipoMenu
{
    partial class TrasladoProductos
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgv_traslaProd = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_nombreProc = new System.Windows.Forms.TextBox();
            this.txt_idProc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_precioUnit = new System.Windows.Forms.TextBox();
            this.txt_costoTotal = new System.Windows.Forms.TextBox();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nombreDoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_destino = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_idDoc = new System.Windows.Forms.TextBox();
            this.navegador1 = new NavegadorVista.Navegador();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_traslaProd)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgv_traslaProd);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(31, 434);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(1005, 353);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Detalle de Traslados";
            // 
            // dgv_traslaProd
            // 
            this.dgv_traslaProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_traslaProd.Location = new System.Drawing.Point(32, 30);
            this.dgv_traslaProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_traslaProd.Name = "dgv_traslaProd";
            this.dgv_traslaProd.RowHeadersWidth = 51;
            this.dgv_traslaProd.RowTemplate.Height = 24;
            this.dgv_traslaProd.Size = new System.Drawing.Size(951, 304);
            this.dgv_traslaProd.TabIndex = 0;
            this.dgv_traslaProd.Tag = "tbl_detallesmovimiento";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_nombreProc);
            this.groupBox2.Controls.Add(this.txt_idProc);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(31, 307);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(496, 108);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Productos";
            // 
            // txt_nombreProc
            // 
            this.txt_nombreProc.Location = new System.Drawing.Point(253, 59);
            this.txt_nombreProc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nombreProc.Name = "txt_nombreProc";
            this.txt_nombreProc.Size = new System.Drawing.Size(221, 23);
            this.txt_nombreProc.TabIndex = 5;
            this.txt_nombreProc.Tag = "Prod_Nombre";
            // 
            // txt_idProc
            // 
            this.txt_idProc.Location = new System.Drawing.Point(253, 29);
            this.txt_idProc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_idProc.Name = "txt_idProc";
            this.txt_idProc.Size = new System.Drawing.Size(221, 23);
            this.txt_idProc.TabIndex = 4;
            this.txt_idProc.Tag = "Pk_ProductoID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nombre del Producto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "ID Producto:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_precioUnit);
            this.groupBox3.Controls.Add(this.txt_costoTotal);
            this.groupBox3.Controls.Add(this.txt_cantidad);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(556, 307);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(480, 123);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contabilidad";
            // 
            // txt_precioUnit
            // 
            this.txt_precioUnit.Location = new System.Drawing.Point(188, 58);
            this.txt_precioUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_precioUnit.Name = "txt_precioUnit";
            this.txt_precioUnit.Size = new System.Drawing.Size(269, 22);
            this.txt_precioUnit.TabIndex = 7;
            this.txt_precioUnit.Tag = "Prod_PrecioUnitario";
            // 
            // txt_costoTotal
            // 
            this.txt_costoTotal.Location = new System.Drawing.Point(189, 86);
            this.txt_costoTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_costoTotal.Name = "txt_costoTotal";
            this.txt_costoTotal.ReadOnly = true;
            this.txt_costoTotal.Size = new System.Drawing.Size(269, 22);
            this.txt_costoTotal.TabIndex = 5;
            this.txt_costoTotal.Tag = "Det_MovCostoTotal";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(188, 28);
            this.txt_cantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(269, 22);
            this.txt_cantidad.TabIndex = 4;
            this.txt_cantidad.Tag = "DetMov_Cantidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Precio Unitario:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "Costo Total";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Cantidad:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_fecha);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_nombreDoc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_destino);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_idDoc);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(151, 206);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(841, 90);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Documentación";
            // 
            // txt_fecha
            // 
            this.txt_fecha.Location = new System.Drawing.Point(590, 53);
            this.txt_fecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(175, 23);
            this.txt_fecha.TabIndex = 13;
            this.txt_fecha.Tag = "Doc_Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(443, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Fecha:";
            // 
            // txt_nombreDoc
            // 
            this.txt_nombreDoc.Location = new System.Drawing.Point(590, 23);
            this.txt_nombreDoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nombreDoc.Name = "txt_nombreDoc";
            this.txt_nombreDoc.Size = new System.Drawing.Size(175, 23);
            this.txt_nombreDoc.TabIndex = 11;
            this.txt_nombreDoc.Tag = "Doc_Numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(443, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Documento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID Documento:";
            // 
            // txt_destino
            // 
            this.txt_destino.Location = new System.Drawing.Point(195, 53);
            this.txt_destino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_destino.Name = "txt_destino";
            this.txt_destino.Size = new System.Drawing.Size(241, 23);
            this.txt_destino.TabIndex = 8;
            this.txt_destino.Tag = "Pk_AlmacenID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Destino:";
            // 
            // txt_idDoc
            // 
            this.txt_idDoc.Location = new System.Drawing.Point(195, 25);
            this.txt_idDoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_idDoc.Name = "txt_idDoc";
            this.txt_idDoc.Size = new System.Drawing.Size(241, 23);
            this.txt_idDoc.TabIndex = 6;
            this.txt_idDoc.Tag = "Pk_DocumentoID";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(151, 13);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(765, 187);
            this.navegador1.TabIndex = 23;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // TrasladoProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(235)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(1064, 800);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Name = "TrasladoProductos";
            this.Text = "TrasladoProductos";
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_traslaProd)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgv_traslaProd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_nombreProc;
        private System.Windows.Forms.TextBox txt_idProc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_precioUnit;
        private System.Windows.Forms.TextBox txt_costoTotal;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_fecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nombreDoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_destino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_idDoc;
        private NavegadorVista.Navegador navegador1;
    }
}