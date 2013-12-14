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
    public partial class frm_ReportesAlertas_MantenimientoComunicacion : Form
    {
        //DECLARACION DE INSTANCIAS DE LAS CLASES
        UsuariosSistema objUsuariosSistema = new UsuariosSistema();
        Alertas objAlertas = new Alertas();

        //VARIABLES GLOBALES
        private string usuarioSistema = string.Empty;
        private int rolUsuario;

        public frm_ReportesAlertas_MantenimientoComunicacion()
        {
            InitializeComponent();
        }

        public frm_ReportesAlertas_MantenimientoComunicacion(string usuario) : this()
        {
            this.usuarioSistema = usuario;
        }

        private void frm_ReporteAlertas_MantenimientoComunicacion_Load(object sender, EventArgs e)
        {
            this.cargaRolUsuario();
            this.rolesUsuario();
            this.cargaAlertasActivas();
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

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            frm_0MenuPrincipal ventana = new frm_0MenuPrincipal(usuarioSistema);
            this.Hide();
            ventana.Show();
        }

        private void btn_NuevaAlerta_Click(object sender, EventArgs e)
        {

        }

        private void cargaAlertasActivas()
        {
            try
            {
                dtg_Alertas.AutoGenerateColumns = false;
                dtg_Alertas.DataSource = objAlertas.cargaDataGridAlertasActivas().Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexion a la base de datos", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void frm_ReportesAlertas_MantenimientoComunicacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = e.CloseReason == CloseReason.UserClosing;
        }
    }
}
