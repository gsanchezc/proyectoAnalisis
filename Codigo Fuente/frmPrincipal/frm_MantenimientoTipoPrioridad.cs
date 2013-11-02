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
    public partial class frm_MantenimientoTipoPrioridad : Form
    {
        public frm_MantenimientoTipoPrioridad()
        {
            InitializeComponent();
        }

        TipoPrioridad objTipoPrioridad = new TipoPrioridad();

        private void cargar_Tipo_prioridad()
        {
            try
            {
                dtg_TipoPrioridad.AutoGenerateColumns = false;
                dtg_TipoPrioridad.DataSource = objTipoPrioridad.cargarTipoPrioridad().Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txt_idTipoPrioridad.Text = "0";
        }

        public void limpia()
        {
            txt_idTipoPrioridad.Text = "0";
            txt_descripcion.Clear();
        }

        private void dtg_TipoPrioridad_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.limpia();
            DataGridView thisGrid = (DataGridView)sender;
            DataTable table = (DataTable)thisGrid.DataSource;
            DataRow currenRow = table.Rows[thisGrid.CurrentCell.RowIndex];
            txt_idTipoPrioridad.Text = currenRow["idPrioridad"].ToString();
            txt_descripcion.Text = currenRow["descripcion"].ToString();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (!Validaciones.esentero(txt_idTipoPrioridad))
            {
                MessageBox.Show("El ID debe ser de tipo entero", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_idTipoPrioridad.Focus();
                return;
            }

            if (!Validaciones.validar(txt_descripcion))
            {
                MessageBox.Show("Por favor ingrese una descripcion", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_descripcion.Focus();
                return;
            }
            objTipoPrioridad.Id = Convert.ToInt32(txt_idTipoPrioridad.Text);
            objTipoPrioridad.Descripcion = txt_descripcion.Text;

            if ((Convert.ToInt32(txt_idTipoPrioridad.Text)) != 0)
            {
                if (objTipoPrioridad.agregarActualiazarTipoPrioridad("Actualizar"))
                {
                    MessageBox.Show("El Tipo de prioridad se actualizó con exito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (objTipoPrioridad.agregarActualiazarTipoPrioridad("Insertar"))
                {
                    MessageBox.Show("El Tipo de prioridad  se agrego con exito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            this.cargar_Tipo_prioridad();
            this.limpia();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (!Validaciones.esentero(txt_idTipoPrioridad))
            {
                MessageBox.Show("El ID debe ser de tipo entero", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_idTipoPrioridad.Focus();
                return;
            }

            if (!Validaciones.validar(txt_descripcion))
            {
                MessageBox.Show("Por favor ingrese una descripcion", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_descripcion.Focus();
                return;

            }
            objTipoPrioridad.Id = Convert.ToInt32(txt_idTipoPrioridad.Text);
            objTipoPrioridad.Descripcion = txt_descripcion.Text;

            objTipoPrioridad.eliminarTipoPrioridad();
            MessageBox.Show("El Tipo de prioridad  se eliminó con exito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.cargar_Tipo_prioridad();
            this.limpia();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
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

        private void frm_MantenimientoTipoPrioridad_Load(object sender, EventArgs e)
        {
            this.cargar_Tipo_prioridad();
            this.limpia();
        }

    }
}
