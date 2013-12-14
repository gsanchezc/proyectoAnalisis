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
    public partial class frm_MantenimientoDescripcionRoles : Form
    {
        //DECLARACION DE INSTANCIAS DE LAS CLASES
        UsuariosSistema objUsuariosSistema = new UsuariosSistema();
        descripcionRol objDescripcionRol = new descripcionRol();

        //VARIABLES GLOBALES
        private string usuarioSistema = string.Empty;
  
        public frm_MantenimientoDescripcionRoles()
        {
            InitializeComponent();
        }

        public frm_MantenimientoDescripcionRoles(string usuario) : this()
        {
            this.usuarioSistema = usuario;
        }

        private void frm_MantenimientoDescripcionRoles1_Load(object sender, EventArgs e)
        {
            this.carga_lista_EstatusFacturas();
        }

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

        private void btn_cerrar_Click(object sender, EventArgs e)
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

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            this.carga_lista_EstatusFacturas();
        }

        private void b_editar_Click(object sender, EventArgs e)
        {

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {

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

        private void dtg_ClienteProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
