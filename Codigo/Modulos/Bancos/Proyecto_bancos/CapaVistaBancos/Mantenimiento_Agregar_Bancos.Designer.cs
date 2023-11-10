
namespace CapaVistaBancos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mantenimiento_Agregar_Bancos));
            this.btn_salir_dispo = new System.Windows.Forms.Button();
            this.txt_numbanco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_agBancos = new System.Windows.Forms.DataGridView();
            this.txt_nombrebanco = new System.Windows.Forms.TextBox();
            this.txt_estadoban = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.navegador1 = new NavegadorVista.Navegador();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_id_banco = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Ayuda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_agBancos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_salir_dispo
            // 
            this.btn_salir_dispo.AutoSize = true;
            this.btn_salir_dispo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btn_salir_dispo.FlatAppearance.BorderSize = 0;
            this.btn_salir_dispo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir_dispo.Image = global::CapaVistaBancos.Properties.Resources.signin_login_in_log_icon_255971;
            this.btn_salir_dispo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_salir_dispo.Location = new System.Drawing.Point(984, -1);
            this.btn_salir_dispo.Name = "btn_salir_dispo";
            this.btn_salir_dispo.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_salir_dispo.Size = new System.Drawing.Size(84, 39);
            this.btn_salir_dispo.TabIndex = 85;
            this.btn_salir_dispo.Text = "Salir";
            this.btn_salir_dispo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_salir_dispo.UseVisualStyleBackColor = false;
            this.btn_salir_dispo.Click += new System.EventHandler(this.btn_salir_dispo_Click);
            // 
            // txt_numbanco
            // 
            this.txt_numbanco.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_numbanco.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numbanco.Location = new System.Drawing.Point(443, 262);
            this.txt_numbanco.Name = "txt_numbanco";
            this.txt_numbanco.Size = new System.Drawing.Size(204, 26);
            this.txt_numbanco.TabIndex = 89;
            this.txt_numbanco.Tag = "manag_id_bancoag";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(264, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 87;
            this.label2.Text = "Nombre banco:";
            // 
            // dgv_agBancos
            // 
            this.dgv_agBancos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_agBancos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_agBancos.Location = new System.Drawing.Point(268, 346);
            this.dgv_agBancos.Name = "dgv_agBancos";
            this.dgv_agBancos.RowHeadersWidth = 51;
            this.dgv_agBancos.RowTemplate.Height = 24;
            this.dgv_agBancos.Size = new System.Drawing.Size(593, 212);
            this.dgv_agBancos.TabIndex = 88;
            this.dgv_agBancos.Tag = "tbl_mantenimientos_agregar_bancos";
            // 
            // txt_nombrebanco
            // 
            this.txt_nombrebanco.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_nombrebanco.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombrebanco.Location = new System.Drawing.Point(443, 303);
            this.txt_nombrebanco.Name = "txt_nombrebanco";
            this.txt_nombrebanco.Size = new System.Drawing.Size(204, 26);
            this.txt_nombrebanco.TabIndex = 90;
            this.txt_nombrebanco.Tag = "manag_nombre_banco";
            // 
            // txt_estadoban
            // 
            this.txt_estadoban.Enabled = false;
            this.txt_estadoban.Location = new System.Drawing.Point(725, 301);
            this.txt_estadoban.Name = "txt_estadoban";
            this.txt_estadoban.ReadOnly = true;
            this.txt_estadoban.Size = new System.Drawing.Size(43, 22);
            this.txt_estadoban.TabIndex = 92;
            this.txt_estadoban.Tag = "manag_status";
            this.txt_estadoban.Text = "1";
            this.txt_estadoban.Visible = false;
            this.txt_estadoban.TextChanged += new System.EventHandler(this.txt_estadoban_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(264, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 94;
            this.label3.Text = "Número de Banco:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(176, 54);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(765, 187);
            this.navegador1.TabIndex = 95;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(721, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 20);
            this.label4.TabIndex = 98;
            this.label4.Text = "Id:";
            // 
            // txt_id_banco
            // 
            this.txt_id_banco.Enabled = false;
            this.txt_id_banco.Location = new System.Drawing.Point(815, 260);
            this.txt_id_banco.Name = "txt_id_banco";
            this.txt_id_banco.Size = new System.Drawing.Size(43, 22);
            this.txt_id_banco.TabIndex = 97;
            this.txt_id_banco.Tag = "pk_manag_id_ban";
            this.txt_id_banco.Text = "1";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(799, 301);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(43, 22);
            this.textBox1.TabIndex = 99;
            this.textBox1.Tag = "manag_status_conciliacion";
            this.textBox1.Text = "0";
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_Ayuda
            // 
            this.btn_Ayuda.FlatAppearance.BorderSize = 0;
            this.btn_Ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ayuda.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ayuda.Image")));
            this.btn_Ayuda.Location = new System.Drawing.Point(833, 146);
            this.btn_Ayuda.Name = "btn_Ayuda";
            this.btn_Ayuda.Size = new System.Drawing.Size(93, 85);
            this.btn_Ayuda.TabIndex = 106;
            this.btn_Ayuda.Text = "Ayuda";
            this.btn_Ayuda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Ayuda.UseVisualStyleBackColor = false;
            this.btn_Ayuda.Click += new System.EventHandler(this.btn_Ayuda_Click);
            // 
            // Mantenimiento_Agregar_Bancos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(161)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(1069, 659);
            this.Controls.Add(this.btn_Ayuda);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_id_banco);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_estadoban);
            this.Controls.Add(this.txt_numbanco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_agBancos);
            this.Controls.Add(this.txt_nombrebanco);
            this.Controls.Add(this.btn_salir_dispo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1069, 803);
            this.MinimumSize = new System.Drawing.Size(888, 659);
            this.Name = "Mantenimiento_Agregar_Bancos";
            this.Text = "Mantenimiento Agregar Bancos";
            this.Load += new System.EventHandler(this.Mantenimiento_Agregar_Bancos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_agBancos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_salir_dispo;
        private System.Windows.Forms.TextBox txt_numbanco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_agBancos;
        private System.Windows.Forms.TextBox txt_nombrebanco;
        private System.Windows.Forms.TextBox txt_estadoban;
        private System.Windows.Forms.Label label3;
        private NavegadorVista.Navegador navegador1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_id_banco;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Ayuda;
    }
}