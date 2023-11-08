using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista_PrototipoMenu;
using Controlador_PrototipoMenu;

namespace Vista_PrototipoMenu
{
    public partial class Auditoria : Form
    {
        Controlador_PrototipoMenu.ControladorInventario crud = new Controlador_PrototipoMenu.ControladorInventario();
        int currentRow = 0;
        int no_Doc = 0;
        string op = "";
        
        public Auditoria()
        {
            InitializeComponent();
            cargarBodega();
            cargarDataAudit();


        }

        private void CargarDatosDoc(int mode)
        {
            string no = "";

            if (mode == 1)
            {
                currentRow = Dgv_Doc_Muestra.CurrentCell.RowIndex;

                foreach (DataGridViewRow row in Dgv_Doc_Muestra.Rows)
                {
                    if (row.Index == currentRow)
                    {
                        no = row.Cells[0].Value.ToString();

                        if (!string.IsNullOrEmpty(no))
                        {
                            txt_Nomuestreo.Text = row.Cells[0].Value.ToString();
                            Cbo_Bodega.SelectedIndex = crud.getIndexBodega(Convert.ToInt32(row.Cells[1].Value.ToString()));
                            Dtp_fecha_muestreo.Text = row.Cells[2].Value.ToString();
                            Txt_descripcion_muestreo.Text = row.Cells[3].Value.ToString();
                        }


                    }


                }
            }
        }

        void cargarDataAudit()
        {
            Dgv_Doc_Muestra.DataSource = crud.getDatosAudit();
        }

        void cargarBodega()
        {
            Cbo_Bodega.DisplayMember = "name";
            Cbo_Bodega.ValueMember = "name";
            Cbo_Bodega.DataSource = crud.getBodegas();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            op = "nuevo";

            Txt_descripcion_muestreo.Text = "";
            txt_Nomuestreo.Text = "";

            txt_Nomuestreo.Text = Convert.ToString(crud.getNoDoc());
            Dtp_fecha_muestreo.Value = DateTime.Now.Date;

            Btn_Nuevo.Enabled = false;
            Btn_Cancelar.Enabled = true;
            Btn_Editar.Enabled = false;
            Btn_Guardar.Enabled = true;
            Txt_descripcion_muestreo.Enabled = true;
            Dtp_fecha_muestreo.Enabled = true;
            Cbo_Bodega.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            op = "editar";
            Btn_Cancelar.Enabled = true;
            Btn_Editar.Enabled = false;
            Btn_Guardar.Enabled = true;
            Txt_descripcion_muestreo.Enabled = true;
            Dtp_fecha_muestreo.Enabled = false;
            Cbo_Bodega.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Btn_Cancelar.Enabled = true;
            Btn_Editar.Enabled = true;
            Btn_Guardar.Enabled = false;
            Txt_descripcion_muestreo.Enabled = false;
            Dtp_fecha_muestreo.Enabled = false;
            Cbo_Bodega.Enabled = false;

            string descripcion = Txt_descripcion_muestreo.Text.ToString();
            string fecha = Dtp_fecha_muestreo.Value.ToString("yyyy-MM-dd");
            int codBodega = crud.getCodBodega(Cbo_Bodega.Text.ToString());
            int No = Convert.ToInt32(txt_Nomuestreo.Text.ToString());

            if (op == "editar")
            {
                if (crud.actualizarDocAuditoria(No, codBodega, fecha, descripcion))
                {
                    MessageBox.Show("Documento editado correctamente");
                    Dgv_Doc_Muestra.DataSource = crud.getDatosAudit();
                    Btn_Cancelar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Error al editar documento de auditoria!");
                }
            }

            if (op == "nuevo")
            {
                if (crud.getCodigoEncabezado(codBodega) == 0)
                {
                    MessageBox.Show("Error, No existe un inventario en la bodega seleccionada");

                    Txt_descripcion_muestreo.Text = "";
                    txt_Nomuestreo.Text = "";
                    Cbo_Bodega.SelectedIndex = -1;

                    Txt_descripcion_muestreo.Enabled = false;
                    txt_Nomuestreo.Enabled = false;
                    Cbo_Bodega.Enabled = false;

                    Btn_Nuevo.Enabled = true;
                    Btn_Cancelar.Enabled = false;
                    Btn_Editar.Enabled = true;
                    Btn_Guardar.Enabled = false;
                }
                else
                {
                    if (crud.crearDocAuditoria(No, codBodega, fecha, descripcion))
                    {
                        MessageBox.Show(codBodega.ToString());
                        Btn_Cancelar.Enabled = false;

                        if (crud.generarCopiaInventario(No))
                        {
                            MessageBox.Show("Documento creado Exitosamente");
                            Dgv_Doc_Muestra.DataSource = crud.getDatosAudit();
                        }
                        else
                        {
                            MessageBox.Show("Error en copia de auditoria");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar documento de auditoria!");
                    }
                }
            }
        }
        private void Dgv_Doc_Muestra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            new Muestreo(Dgv_Doc_Muestra).Show();
            this.Hide();
        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {

        }
    }
}
