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
        //DECLARACION DE INSTANCIAS DE LAS CLASES
        UsuariosSistema objUsuariosSistema = new UsuariosSistema();
        DescripcionDepartamento objDescripcionDepartamentos = new DescripcionDepartamento();

        //VARIABLES GLOBALES
        private string usuarioSistema = string.Empty;

        public frm_MantenimientoDescripcionDepartamento()
        {
            InitializeComponent();
        }

        public frm_MantenimientoDescripcionDepartamento(string usuario) : this()
        {
            this.usuarioSistema = usuario;
        }

        private void frm_MantenimientoDescripcionDepartamento_Load(object sender, EventArgs e)
        {
            this.cargar_Lista_Descripcion_Departamentos();
            this.limpia();
        }

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

            objDescripcionDepartamentos.eliminarDescripcionDepartamento();
            MessageBox.Show("La Descripcion del Departamento se eliminó con exito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.cargar_Lista_Descripcion_Departamentos();
            this.limpia();
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
                    MessageBox.Show("La descripcion del Departamento se actualizó con exito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (objDescripcionDepartamentos.agregarActualiazarDescripcionDepartamentos("Insertar"))
                {
                    MessageBox.Show("La descripcion del departamento se agrego con exito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            this.cargar_Lista_Descripcion_Departamentos();
            this.limpia();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            frm_Mantenimiento_0Menu ventana = new frm_Mantenimiento_0Menu(usuarioSistema);

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
    }
}

