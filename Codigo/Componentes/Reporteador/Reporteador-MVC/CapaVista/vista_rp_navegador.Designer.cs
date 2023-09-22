
namespace CapaVista
{
    partial class vista_rp_navegador
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label Reporte;
            this.CrystalReport31 = new CapaVista.CrystalReport3();
            this.CrystalReport21 = new CapaVista.CrystalReport2();
            this.CrystalReport51 = new CapaVista.CrystalReport5();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tblreportesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new CapaVista.DataSet1();
            this.tbl_reportesTableAdapter = new CapaVista.DataSet1TableAdapters.tbl_reportesTableAdapter();
            this.CrystalReport61 = new CapaVista.CrystalReport6();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cachedCrystalReport2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cachedCrystalReport5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            Reporte = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblreportesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cachedCrystalReport2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cachedCrystalReport5BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Reporte
            // 
            Reporte.AutoSize = true;
            Reporte.Location = new System.Drawing.Point(320, 36);
            Reporte.Name = "Reporte";
            Reporte.Size = new System.Drawing.Size(45, 13);
            Reporte.TabIndex = 0;
            Reporte.Text = "Reporte";
            Reporte.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 76);
            this.button1.TabIndex = 1;
            this.button1.Text = "Sueldo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione el tipo de archivo";
            // 
            // tblreportesBindingSource
            // 
            this.tblreportesBindingSource.DataMember = "tbl_reportes";
            this.tblreportesBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_reportesTableAdapter
            // 
            this.tbl_reportesTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // cachedCrystalReport2BindingSource
            // 
            this.cachedCrystalReport2BindingSource.DataSource = typeof(CapaVista.CachedCrystalReport2);
            // 
            // cachedCrystalReport5BindingSource
            // 
            this.cachedCrystalReport5BindingSource.DataSource = typeof(CapaVista.CachedCrystalReport5);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(338, 163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(478, 163);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(623, 163);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // vista_rp_navegador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(Reporte);
            this.Name = "vista_rp_navegador";
            this.Text = "vista_rp_navegador";
            this.Load += new System.EventHandler(this.vista_rp_navegador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblreportesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cachedCrystalReport2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cachedCrystalReport5BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CrystalReport5 CrystalReport51;
        private CrystalReport3 CrystalReport31;
        private CrystalReport2 CrystalReport21;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource tblreportesBindingSource;
        private DataSet1TableAdapters.tbl_reportesTableAdapter tbl_reportesTableAdapter;
        private CrystalReport6 CrystalReport61;
        private System.Windows.Forms.BindingSource cachedCrystalReport2BindingSource;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private System.Windows.Forms.BindingSource cachedCrystalReport5BindingSource;
        public System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}