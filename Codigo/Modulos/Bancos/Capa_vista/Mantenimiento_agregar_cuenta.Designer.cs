
namespace Vista_PrototipoMenu
{
    partial class Mantenimiento_agregar_cuenta
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
            this.txt_numcuenta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cb_tipomoneda = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_alias = new System.Windows.Forms.TextBox();
            this.cb_tipocuenta = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_selectbanco = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.navegador1 = new NavegadorVista.Navegador();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_numcuenta
            // 
            this.txt_numcuenta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numcuenta.Location = new System.Drawing.Point(196, 251);
            this.txt_numcuenta.Name = "txt_numcuenta";
            this.txt_numcuenta.Size = new System.Drawing.Size(169, 26);
            this.txt_numcuenta.TabIndex = 102;
            this.txt_numcuenta.Tag = "manac_numero_de_cuenta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 98;
            this.label1.Text = "Tipo de moneda: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 372);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(794, 174);
            this.dataGridView1.TabIndex = 108;
            // 
            // cb_tipomoneda
            // 
            this.cb_tipomoneda.DisplayMember = "mon_nomMoneda";
            this.cb_tipomoneda.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tipomoneda.FormattingEnabled = true;
            this.cb_tipomoneda.Location = new System.Drawing.Point(196, 293);
            this.cb_tipomoneda.Name = "cb_tipomoneda";
            this.cb_tipomoneda.Size = new System.Drawing.Size(169, 28);
            this.cb_tipomoneda.TabIndex = 99;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 100;
            this.label2.Text = "Número de cuenta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(454, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 20);
            this.label6.TabIndex = 107;
            this.label6.Text = "Seleccione un banco:";
            // 
            // txt_alias
            // 
            this.txt_alias.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_alias.Location = new System.Drawing.Point(638, 286);
            this.txt_alias.Name = "txt_alias";
            this.txt_alias.Size = new System.Drawing.Size(169, 26);
            this.txt_alias.TabIndex = 101;
            // 
            // cb_tipocuenta
            // 
            this.cb_tipocuenta.DisplayMember = "manac_tipo_de_cuenta";
            this.cb_tipocuenta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tipocuenta.FormattingEnabled = true;
            this.cb_tipocuenta.Location = new System.Drawing.Point(196, 329);
            this.cb_tipocuenta.Name = "cb_tipocuenta";
            this.cb_tipocuenta.Size = new System.Drawing.Size(169, 28);
            this.cb_tipocuenta.TabIndex = 106;
            this.cb_tipocuenta.ValueMember = "manac_tipo_de_cuenta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(454, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 103;
            this.label3.Text = "Alias:";
            // 
            // cb_selectbanco
            // 
            this.cb_selectbanco.DisplayMember = "manag_nombre_banco";
            this.cb_selectbanco.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_selectbanco.FormattingEnabled = true;
            this.cb_selectbanco.Location = new System.Drawing.Point(638, 251);
            this.cb_selectbanco.Name = "cb_selectbanco";
            this.cb_selectbanco.Size = new System.Drawing.Size(169, 28);
            this.cb_selectbanco.TabIndex = 105;
            this.cb_selectbanco.ValueMember = "manag_nombre_banco";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 104;
            this.label5.Text = "Tipo de cuenta:";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(29, 26);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(765, 187);
            this.navegador1.TabIndex = 109;
            // 
            // Mantenimiento_agregar_cuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 571);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.txt_numcuenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cb_tipomoneda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_alias);
            this.Controls.Add(this.cb_tipocuenta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_selectbanco);
            this.Controls.Add(this.label5);
            this.Name = "Mantenimiento_agregar_cuenta";
            this.Text = "Mantenimiento_agregar_cuenta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_numcuenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cb_tipomoneda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_alias;
        private System.Windows.Forms.ComboBox cb_tipocuenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_selectbanco;
        private System.Windows.Forms.Label label5;
        private NavegadorVista.Navegador navegador1;
    }
}