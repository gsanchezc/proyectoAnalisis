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
    public partial class frm_MantenimientoDescripcionRoles1 : Form
    {
        descripcionRol objDescripcionRol = new descripcionRol();

        //Metodo que carga en el data grib view los campos que vienen desde la clase descripcionRol
        private void carga_lista_EstatusFacturas()
        {
            try
            {

                dtg_ListaDescripcionRol.AutoGenerateColumns = false;
                dtg_ListaDescripcionRol.DataSource = objDescripcionRol.cargaListaDescripcionRol().Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public frm_MantenimientoDescripcionRoles1()
        {
            InitializeComponent();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
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

        private void frm_MantenimientoDescripcionRoles1_Load(object sender, EventArgs e)
        {
            this.carga_lista_EstatusFacturas();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            this.carga_lista_EstatusFacturas();
        }

        private void b_editar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(dtg_ListaDescripcionRol.RowCount) == 0)
            {
                MessageBox.Show("No hay ninguna descripcion en la lista", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frm_MantenimientoDescripcionRolesNuevoEditar ventanaNuevoEditarDescripcionRol = new frm_MantenimientoDescripcionRolesNuevoEditar();
            //ingresa en el campo id de la ventana frm_MantenimientoDescripcionRolesNuevoEditar el campo id que viene desde el data grid view de la ventana anterior
            ventanaNuevoEditarDescripcionRol.id = Convert.ToInt32(dtg_ListaDescripcionRol.CurrentRow.Cells[0].Value.ToString());
            ventanaNuevoEditarDescripcionRol.ShowDialog();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            frm_MantenimientoDescripcionRolesNuevoEditar ventanaNuevoEditarDescripcionRol = new frm_MantenimientoDescripcionRolesNuevoEditar();
            //cuenta la cantidad de descripciones que hay en el data grid view y le suma 1 
            ventanaNuevoEditarDescripcionRol.num = Convert.ToInt32(dtg_ListaDescripcionRol.RowCount + 1);
            ventanaNuevoEditarDescripcionRol.ShowDialog();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            string idDescripcion = string.Empty;
            idDescripcion = dtg_ListaDescripcionRol.CurrentRow.Cells[0].Value.ToString();
            if (MessageBox.Show("Desea eliminar la descripcion con el ID : " + idDescripcion, "Confirmacion de borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (objDescripcionRol.eliminarDescripcionRol(Convert.ToInt32(idDescripcion)))
                {
                    MessageBox.Show("La descripcion de rol se eliminó con exito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.carga_lista_EstatusFacturas();

                }
            }
        }
    }
}
