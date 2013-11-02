using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clases;

namespace frmPrincipal
{
    public partial class frm_MantenimientoDescripcionDepartamento : Form
    {
        public frm_MantenimientoDescripcionDepartamento()
        {
            InitializeComponent();
        }
        DescripcionDepartamento objDescripcionDepartamentos = new DescripcionDepartamento();

        private void cargar_Lista_Descripcion_Departamentos()
        {
            try
            {
                dtg_DescripcionDepartamento.AutoGenerateColumns = false;
                dtg_DescripcionDepartamento.DataSource = objDescripcionDepartamentos.cargarDescripcionDepartamentos().Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txt_idDepartamento.Text = "0";
        }
        private void limpia()
        {
            txt_idDepartamento.Text = "0";
            txt_descripcion.Clear();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            this.limpia();
        }

        private void dtg_DescripcionDepartamento_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.limpia();
            DataGridView thisGrid = (DataGridView)sender;
            DataTable table = (DataTable)thisGrid.DataSource;
            DataRow currenRow = table.Rows[thisGrid.CurrentCell.RowIndex];
            txt_idDepartamento.Text = currenRow["idDepartamento"].ToString();
            txt_descripcion.Text = currenRow["descripcion"].ToString();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (!Validaciones.esentero(txt_idDepartamento))
            {
                MessageBox.Show("El ID debe ser de tipo entero", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_idDepartamento.Focus();
                return;
            }

            if (!Validaciones.validar(txt_descripcion))
            {
                MessageBox.Show("Por favor ingrese una descripcion", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_descripcion.Focus();
                return;
            }
            objDescripcionDepartamentos.Id = Convert.ToInt32(txt_idDepartamento.Text);
            objDescripcionDepartamentos.Descripcion = txt_descripcion.Text;

            if ((Convert.ToInt32(txt_idDepartamento.Text)) != 0)
            {
                if (objDescripcionDepartamentos.agregarActualiazarDescripcionDepartamentos("Actualizar"))
                {
                    MessageBox.Show("La descripcion del rol se agrego con exito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (objDescripcionDepartamentos.agregarActualiazarDescripcionDepartamentos("Insertar"))
                {
                    MessageBox.Show("La descripcion del rol se agrego con exito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            this.cargar_Lista_Descripcion_Departamentos();
            this.limpia();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            frm_0MenuPrincipal ventana = new frm_0MenuPrincipal();

            if ((MessageBox.Show("Desea regresar al menu principal", "Volver al Menu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                this.Close();
                ventana.Show();
            }
            else
            {
                return;
            }
        }

        private void frm_MantenimientoDescripcionDepartamento_Load(object sender, EventArgs e)
        {
            this.cargar_Lista_Descripcion_Departamentos();
            this.limpia();
        }
    }
}

