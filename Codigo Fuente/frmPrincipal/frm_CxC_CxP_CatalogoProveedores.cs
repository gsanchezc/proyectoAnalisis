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
    public partial class frm_CxC_CxP_CatalogoProveedores : Form
    {
        //DECLARACION DE INSTANCIAS DE LAS CLASES
        UsuariosSistema objUsuariosSistema = new UsuariosSistema();
        ClienteProveedor objProveedores = new ClienteProveedor();

        //VARIABLES GLOBALES
        private string usuarioSistema = string.Empty;
        private int rolUsuario;

        public frm_CxC_CxP_CatalogoProveedores()
        {
            InitializeComponent();
        }

        public frm_CxC_CxP_CatalogoProveedores(string usuario) : this()
        {
            this.usuarioSistema = usuario;
        }

        private void frm_CxC_CxP_CatalogoProveedores_Load(object sender, EventArgs e)
        {
            this.cargaRolUsuario();
            this.rolesUsuario();
            this.cargaDataGridProveedores();
        }

        //METODO PARA MANEJAR EL ACCESO POR ROLES
        //RAFAEL ANGEL SEQUEIRA VARGAS
        public void cargaRolUsuario()
        {
            objUsuariosSistema.cargaRolUsuario(usuarioSistema);
            rolUsuario = objUsuariosSistema.idRol;
        }

        //METODO PARA MANEJAR EL ACCESO POR ROLES
        //RAFAEL ANGEL SEQUEIRA VARGAS
        public void rolesUsuario()
        {

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            frm_CxC_CxP_NuevoProveedor ventana = new frm_CxC_CxP_NuevoProveedor(usuarioSistema);
            this.Hide();
            ventana.Show();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            frm_0MenuPrincipal ventana = new frm_0MenuPrincipal(usuarioSistema);

            if ((MessageBox.Show("Desea regresar al menu principal", "Volver al Menu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                this.Hide();
                ventana.Show();
            }
            else
            {
                return;
            }
        }

        private void frm_CxC_CxP_CatalogoProveedores_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = e.CloseReason == CloseReason.UserClosing;
        }

        //METODO 
        //RAFAEL ANGEL SEQUEIRA VARGAS
        private void cargaDataGridProveedores()
        {
            try
            {
                dtg_CatalogoProveedor.AutoGenerateColumns = false;
                dtg_CatalogoProveedor.DataSource = objProveedores.cargarDataGridProveedores().Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexion a la base de datos", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
