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
    public partial class frm_Seguridad_Login : Form
    {
        Seguridad objSeguridad = new Seguridad();
        UsuariosSistema objUsuariosSistema = new UsuariosSistema();

        public frm_Seguridad_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Validaciones.validar(txt_Usuario))
            {
                MessageBox.Show("No ingresaste Usuario", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Usuario.Focus();
                return;
            }
            if (!Validaciones.validar(txt_Contraseña))
            {
                MessageBox.Show("No ingresaste contrasena", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Contraseña.Focus();
                return;
            }

            int id = Convert.ToInt32(txt_Usuario.Text);
            string contrasenna = objSeguridad.MD5Hash(txt_Contraseña.Text);
            objUsuariosSistema.login_usuariosSistema(id, contrasenna);

            if (objUsuariosSistema.validacion == false)
            {
                MessageBox.Show("Intento de login fallido", "CUIDADO!");
                return;
            }
            if (objUsuariosSistema.validacion == true)
            {
                MessageBox.Show("BIENVENIDO", "LOGIN EXITOSO");
                frm_0MenuPrincipal ventana = new frm_0MenuPrincipal();
                frm_ReportesAlertas_MantenimientoAlertasNotificaciones ventanaReportes = new frm_ReportesAlertas_MantenimientoAlertasNotificaciones();
                this.Hide();
                ventana.Show();
                ventanaReportes.Show();
            }
            else
            {
                MessageBox.Show("CONTACTE ADMINISTRADOR DE SISTEMA", "ERROR");
                return;
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Desea salir del Sistema", "Cierre del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }
    }
}
