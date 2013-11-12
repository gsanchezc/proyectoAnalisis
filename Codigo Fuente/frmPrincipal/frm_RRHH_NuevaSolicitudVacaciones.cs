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
    public partial class frm_RRHH_NuevaSolicitudVacaciones : Form
    {
        //DECLARACION DE INSTANCIAS DE LAS CLASES
        UsuariosSistema objUsuariosSistema = new UsuariosSistema();
        RRHH_SolicitudVacaciones objVacaciones = new RRHH_SolicitudVacaciones();

        //VARIABLES GLOBALES
        private string usuarioSistema = string.Empty;
        private int rolUsuario;

        public frm_RRHH_NuevaSolicitudVacaciones()
        {
            InitializeComponent();
        }

        public frm_RRHH_NuevaSolicitudVacaciones(string usuario) : this()
        {
            this.usuarioSistema = usuario;
        }

        private void frm_RRHH_NuevaSolicitudVacaciones_Load(object sender, EventArgs e)
        {
            this.cargaRolUsuario();
            this.rolesUsuario();
            this.cargarListaEmpleados();
        }

        //METODO PARA MANEJAR EL ACCESO POR ROLES
        //RAFAEL ANGEL SEQUEIRA VARGAS
        public void cargaRolUsuario()
        {
            this.cargarListaEmpleados();
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
            if ((MessageBox.Show("Desea salir sin generar factura", "Volver al Menu Principal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                frm_0MenuPrincipal ventana = new frm_0MenuPrincipal(usuarioSistema);
                this.Close();
                ventana.Show();
            }
            else
            {
                return;
            }
        }

        private void cargarListaEmpleados()
        {
            try
            {
                DataSet ds;
                ds = objVacaciones.cargarListaEmpleados();
                cmb_Identificacion.DataSource = ds.Tables[0];
                cmb_Identificacion.DisplayMember = ds.Tables[0].Columns["identificacion"].ColumnName.ToString();
                cmb_Identificacion.ValueMember = ds.Tables[0].Columns["idEmpleado"].ColumnName.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void calculos()
        { 
            
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {

        }
    }
}
