
namespace Vista_PrototipoMenu
{
    partial class Mantenimiento_Agregar_Bancos
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
            this.label3 = new System.Windows.Forms.Label();
            this.txt_estadoban = new System.Windows.Forms.TextBox();
            this.txt_numbanco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dg_agregarbancos = new System.Windows.Forms.DataGridView();
            this.txt_nombrebanco = new System.Windows.Forms.TextBox();
            this.navegador1 = new NavegadorVista.Navegador();
            ((System.ComponentModel.ISupportInitialize)(this.dg_agregarbancos)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(136, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 100;
            this.label3.Text = "Número de Banco:";
            // 
            // txt_estadoban
            // 
            this.txt_estadoban.Enabled = false;
            this.txt_estadoban.Location = new System.Drawing.Point(655, 272);
            this.txt_estadoban.Name = "txt_estadoban";
            this.txt_estadoban.Size = new System.Drawing.Size(19, 22);
            this.txt_estadoban.TabIndex = 99;
            this.txt_estadoban.Tag = "manag_status";
            this.txt_estadoban.Text = "1";
            this.txt_estadoban.Visible = false;
            // 
            // txt_numbanco
            // 
            this.txt_numbanco.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_numbanco.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numbanco.Location = new System.Drawing.Point(315, 227);
            this.txt_numbanco.Name = "txt_numbanco";
            this.txt_numbanco.Size = new System.Drawing.Size(204, 26);
            this.txt_numbanco.TabIndex = 97;
            this.txt_numbanco.Tag = "manag_id_bancoag";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(158, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 95;
            this.label2.Text = "Nombre banco:";
            // 
            // dg_agregarbancos
            // 
            this.dg_agregarbancos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_agregarbancos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_agregarbancos.Location = new System.Drawing.Point(98, 311);
            this.dg_agregarbancos.Name = "dg_agregarbancos";
            this.dg_agregarbancos.RowHeadersWidth = 51;
            this.dg_agregarbancos.RowTemplate.Height = 24;
            this.dg_agregarbancos.Size = new System.Drawing.Size(576, 178);
            this.dg_agregarbancos.TabIndex = 96;
            this.dg_agregarbancos.Tag = "tbl_mantenimientos_agregar_bancos";
            // 
            // txt_nombrebanco
            // 
            this.txt_nombrebanco.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_nombrebanco.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombrebanco.Location = new System.Drawing.Point(315, 268);
            this.txt_nombrebanco.Name = "txt_nombrebanco";
            this.txt_nombrebanco.Size = new System.Drawing.Size(204, 26);
            this.txt_nombrebanco.TabIndex = 98;
            this.txt_nombrebanco.Tag = "manag_nombre_banco";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(23, 13);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(765, 187);
            this.navegador1.TabIndex = 101;
            // 
            // Mantenimiento_Agregar_Bancos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 501);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_estadoban);
            this.Controls.Add(this.txt_numbanco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dg_agregarbancos);
            this.Controls.Add(this.txt_nombrebanco);
            this.Name = "Mantenimiento_Agregar_Bancos";
            this.Text = "Mantenimiento_Agregar_Bancos";
            this.Load += new System.EventHandler(this.Mantenimiento_Agregar_Bancos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_agregarbancos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_estadoban;
        private System.Windows.Forms.TextBox txt_numbanco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dg_agregarbancos;
        private System.Windows.Forms.TextBox txt_nombrebanco;
        private NavegadorVista.Navegador navegador1;
    }
}