
namespace CapaVistaBancos
{
    partial class Dispo_diaria
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
            this.btn_salir_dispo = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_banco = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this._navegador = new NavegadorVista.Navegador();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_idbancoag = new System.Windows.Forms.TextBox();
            this.txt_nombrebanco = new System.Windows.Forms.TextBox();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.txt_statusc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(141, 346);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(545, 220);
            this.dataGridView1.TabIndex = 80;
            this.dataGridView1.Tag = "tbl_mantenimientos_agregar_bancos";
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_salir_dispo
            // 
            this.btn_salir_dispo.AutoSize = true;
            this.btn_salir_dispo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btn_salir_dispo.FlatAppearance.BorderSize = 0;
            this.btn_salir_dispo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir_dispo.Image = global::CapaVistaBancos.Properties.Resources.signin_login_in_log_icon_255971;
            this.btn_salir_dispo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_salir_dispo.Location = new System.Drawing.Point(738, -1);
            this.btn_salir_dispo.Margin = new System.Windows.Forms.Padding(2);
            this.btn_salir_dispo.Name = "btn_salir_dispo";
            this.btn_salir_dispo.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btn_salir_dispo.Size = new System.Drawing.Size(63, 38);
            this.btn_salir_dispo.TabIndex = 84;
            this.btn_salir_dispo.Text = "Salir";
            this.btn_salir_dispo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_salir_dispo.UseVisualStyleBackColor = false;
            this.btn_salir_dispo.Click += new System.EventHandler(this.btn_salir_dispo_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(354, 209);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(224, 21);
            this.comboBox1.TabIndex = 87;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 86;
            this.label1.Text = "Tipo de moneda:";
            // 
            // combo_banco
            // 
            this.combo_banco.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.combo_banco.FormattingEnabled = true;
            this.combo_banco.Location = new System.Drawing.Point(354, 255);
            this.combo_banco.Name = "combo_banco";
            this.combo_banco.Size = new System.Drawing.Size(224, 21);
            this.combo_banco.TabIndex = 89;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(234, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 90;
            this.label8.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 88;
            this.label2.Text = "Banco a Consultar:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker2.Location = new System.Drawing.Point(354, 295);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(224, 20);
            this.dateTimePicker2.TabIndex = 91;
            this.dateTimePicker2.Value = new System.DateTime(2023, 10, 12, 0, 0, 0, 0);
            // 
            // _navegador
            // 
            this._navegador.Location = new System.Drawing.Point(130, 30);
            this._navegador.Name = "_navegador";
            this._navegador.Size = new System.Drawing.Size(574, 152);
            this._navegador.TabIndex = 92;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(604, 209);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 20);
            this.txt_id.TabIndex = 93;
            this.txt_id.Tag = "pk_manag_id_ban";
            // 
            // txt_idbancoag
            // 
            this.txt_idbancoag.Location = new System.Drawing.Point(604, 250);
            this.txt_idbancoag.Name = "txt_idbancoag";
            this.txt_idbancoag.Size = new System.Drawing.Size(100, 20);
            this.txt_idbancoag.TabIndex = 94;
            this.txt_idbancoag.Tag = "manag_id_bancoag";
            // 
            // txt_nombrebanco
            // 
            this.txt_nombrebanco.Location = new System.Drawing.Point(604, 276);
            this.txt_nombrebanco.Name = "txt_nombrebanco";
            this.txt_nombrebanco.Size = new System.Drawing.Size(100, 20);
            this.txt_nombrebanco.TabIndex = 95;
            this.txt_nombrebanco.Tag = "manag_nombre_banco";
            // 
            // txt_status
            // 
            this.txt_status.Location = new System.Drawing.Point(604, 302);
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(100, 20);
            this.txt_status.TabIndex = 96;
            this.txt_status.Tag = "manag_status";
            // 
            // txt_statusc
            // 
            this.txt_statusc.Location = new System.Drawing.Point(96, 276);
            this.txt_statusc.Name = "txt_statusc";
            this.txt_statusc.Size = new System.Drawing.Size(100, 20);
            this.txt_statusc.TabIndex = 97;
            this.txt_statusc.Tag = "manag_status_conciliacion";
            // 
            // Dispo_diaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(161)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(802, 614);
            this.Controls.Add(this.txt_statusc);
            this.Controls.Add(this.txt_status);
            this.Controls.Add(this.txt_nombrebanco);
            this.Controls.Add(this.txt_idbancoag);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this._navegador);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_banco);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.btn_salir_dispo);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(802, 652);
            this.MinimumSize = new System.Drawing.Size(666, 535);
            this.Name = "Dispo_diaria";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "DISPONIBILIDAD DIARIA";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_salir_dispo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_banco;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private NavegadorVista.Navegador _navegador;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_idbancoag;
        private System.Windows.Forms.TextBox txt_nombrebanco;
        private System.Windows.Forms.TextBox txt_status;
        private System.Windows.Forms.TextBox txt_statusc;
    }
}