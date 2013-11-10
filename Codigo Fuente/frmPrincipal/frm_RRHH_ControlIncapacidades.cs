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
    public partial class frm_RRHH_ControlIncapacidades : Form
    {
        //DECLARACION DE INSTANCIAS DE LAS CLASES
        UsuariosSistema objUsuariosSistema = new UsuariosSistema();
        RRHH_incapacidades objRRHHIcapacidades = new RRHH_incapacidades();
        //VARIABLES GLOBALES
        private string usuarioSistema = string.Empty;
        private int rolUsuario;

        public frm_RRHH_ControlIncapacidades()
        {
            InitializeComponent();
        }

        public frm_RRHH_ControlIncapacidades(string usuario) : this()
        {
            this.usuarioSistema = usuario;
        }

        private void frm_RRHH_ControlIncapacidades_Load(object sender, EventArgs e)
        {
            this.cargaRolUsuario();
            this.rolesUsuario();
            this.cargar_lista_incapacidades();
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

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Desea volver al Menu Principal", "Volver al Menu Principal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                frm_0MenuPrincipal ventanaMenuPrincipal = new frm_0MenuPrincipal(usuarioSistema);
                this.Close();
                ventanaMenuPrincipal.Show();
            }
            else
            {
                return;
            }
        }

        public void cargar_lista_incapacidades()
        {
            try
            {
                dtg_Incapacidades.AutoGenerateColumns = false;
                dtg_Incapacidades.DataSource = objRRHHIcapacidades.cargarListaIncapacidades().Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
