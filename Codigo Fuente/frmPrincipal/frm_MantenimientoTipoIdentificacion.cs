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
    public partial class frm_MantenimientoTipoIdentificacion : Form
    {
        public frm_MantenimientoTipoIdentificacion()
        {
            InitializeComponent();
        }

        TipoIdentificacion objTipoIdentificacion = new TipoIdentificacion();

        private void frm_MantenimientoTipoIdentificacion_Load(object sender, EventArgs e)
        {
            this.cargar_lista_tipos_identificacion();
            this.limpia();
        }

        private void cargar_lista_tipos_identificacion()
        {
            try
            {
                dtg_TipoIdentificaciones.AutoGenerateColumns = false;
                dtg_TipoIdentificaciones.DataSource = objTipoIdentificacion.cargarTipoIdenticacion().Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txt_idTipoIdentifiacion.Text = "0";
        }

        private void limpia()
        {
            txt_idTipoIdentifiacion.Text = "0";
            txt_descrpcionIdentificacion.Clear();
        }

        private void dtg_TipoIdentificaciones_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.limpia();
            DataGridView thisGrid = (DataGridView)sender;
            DataTable table = (DataTable)thisGrid.DataSource;
            DataRow currenRow = table.Rows[thisGrid.CurrentCell.RowIndex];
            txt_idTipoIdentifiacion.Text = currenRow["idTipoIdentificacion"].ToString();
            txt_descrpcionIdentificacion.Text = currenRow["descripcion"].ToString();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (!Validaciones.esentero(txt_idTipoIdentifiacion))
            {
                MessageBox.Show("El ID debe ser de tipo entero", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_idTipoIdentifiacion.Focus();
                return;
            }

            if (!Validaciones.validar(txt_descrpcionIdentificacion))
            {
                MessageBox.Show("Por favor ingrese una descripcion", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_descrpcionIdentificacion.Focus();
                return;
            }
            objTipoIdentificacion.Id = Convert.ToInt32(txt_idTipoIdentifiacion.Text);
            objTipoIdentificacion.Descripcion = txt_descrpcionIdentificacion.Text;

            if ((Convert.ToInt32(txt_idTipoIdentifiacion.Text)) != 0)
            {
                if (objTipoIdentificacion.agregarActualiazarTipoIdentificacion("Actualizar"))
                {
                    MessageBox.Show("El tipo de identificacion se actualizó con exito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (objTipoIdentificacion.agregarActualiazarTipoIdentificacion("Insertar"))
                {
                    MessageBox.Show("El tipo de identificacion se agrego con exito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            this.cargar_lista_tipos_identificacion();
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

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (!Validaciones.esentero(txt_idTipoIdentifiacion))
            {
                MessageBox.Show("El ID debe ser de tipo entero", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_idTipoIdentifiacion.Focus();
                return;
            }

            if (!Validaciones.validar(txt_descrpcionIdentificacion))
            {
                MessageBox.Show("Por favor ingrese una descripcion", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_descrpcionIdentificacion.Focus();
                return;
                
            }
            objTipoIdentificacion.Id = Convert.ToInt32(txt_idTipoIdentifiacion.Text);
            objTipoIdentificacion.Descripcion = txt_descrpcionIdentificacion.Text;

            objTipoIdentificacion.eliminarTipoIdentificacion();
            MessageBox.Show("El Tipo de Identificacion se eliminó con exito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.cargar_lista_tipos_identificacion();
            this.limpia();
        }
    }
}
