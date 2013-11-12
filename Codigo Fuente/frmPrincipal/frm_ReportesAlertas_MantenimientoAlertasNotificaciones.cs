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
    public partial class frm_ReportesAlertas_MantenimientoAlertasNotificaciones : Form
    {
        //DECLARACION DE INSTANCIAS DE LAS CLASES
        UsuariosSistema objUsuariosSistema = new UsuariosSistema();

        //VARIABLES GLOBALES
        private string usuarioSistema = string.Empty;
        private int rolUsuario;

        public frm_ReportesAlertas_MantenimientoAlertasNotificaciones()
        {
            InitializeComponent();
        }

        public frm_ReportesAlertas_MantenimientoAlertasNotificaciones(string usuario) : this()
        {
            this.usuarioSistema = usuario;  
        }

        private void frm_ReportesAlertas_MantenimientoAlertasNotificaciones_Load(object sender, EventArgs e)
        {
            this.cargaRolUsuario();
            labelUsuario.Text = usuarioSistema;
        }

        //METODO PARA MANEJAR EL ACCESO POR ROLES
        //RAFAEL ANGEL SEQUEIRA VARGAS
        public void cargaRolUsuario()
        {
            objUsuariosSistema.cargaRolUsuario(usuarioSistema);
            rolUsuario = objUsuariosSistema.idRol;

            if (rolUsuario == 1)
            {
                labelDepartamento.Text = "Administrador";
            }
            else if (rolUsuario == 2)
            {
                labelDepartamento.Text = "Supervisor";
            }
            else if (rolUsuario == 3)
            {
                labelDepartamento.Text = "Tecnico";
            }
            else if (rolUsuario == 4)
            {
                labelDepartamento.Text = "RRHH";
            }
            else if (rolUsuario == 5)
            {
                labelDepartamento.Text = "Contabilidad";
            }
            else 
            {
                labelDepartamento.Text = "No Autorizado";
            }
        }

        private void frm_ReportesAlertas_MantenimientoAlertasNotificaciones_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = e.CloseReason == CloseReason.UserClosing;
        }
    }
}
