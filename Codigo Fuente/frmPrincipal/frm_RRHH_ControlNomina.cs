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
    public partial class frm_RRHH_ControlNomina : Form
    {
        //DECLARACION DE INSTANCIAS DE LAS CLASES
        UsuariosSistema objUsuariosSistema = new UsuariosSistema();
        RRHH_Nomina objNomina = new RRHH_Nomina();

        //VARIABLES GLOBALES
        private string usuarioSistema = string.Empty;
        private int rolUsuario;

        public frm_RRHH_ControlNomina()
        {
            InitializeComponent();
        }

        public frm_RRHH_ControlNomina(string usuario) : this()
        {
            this.usuarioSistema = usuario;
        }

        private void frm_RRHH_ControlNomina_Load(object sender, EventArgs e)
        {
            this.cargaRolUsuario();
            this.rolesUsuario();
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

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            frm_RRHH_NuevaNomina ventanaNuevaNomina = new frm_RRHH_NuevaNomina();
            this.Hide();
            ventanaNuevaNomina.Show();
        }

        private void btn_verResumen_Click(object sender, EventArgs e)
        {
            if (!Validaciones.validar(cmb_anioNomina))
            {
                MessageBox.Show("Por favor seleccione el año", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmb_anioNomina.Focus();
                return;
            }
            if (!Validaciones.validar(cmb_mesNomina))
            {
                MessageBox.Show("Por favor seleccione el mes", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmb_mesNomina.Focus();
                return;
            }
            else
            {
                objNomina.Mes = cmb_mesNomina.SelectedItem.ToString();
                objNomina.Anio = Convert.ToInt32(cmb_anioNomina.SelectedItem.ToString());
                DataSet ds;
                dtg_Planilla.DataSource = objNomina.buscarNominaCompleta().Tables[0];

            }
        }


    }
}
