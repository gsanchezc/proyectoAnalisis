using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clases;
using System.Text.RegularExpressions;

namespace frmPrincipal
{
    public partial class frm_Seguridad_Login : Form
    {
        Seguridad objSeguridad = new Seguridad();
        UsuariosSistema objUsuariosSistema = new UsuariosSistema();

        int intentosFallidos = 0;

        public frm_Seguridad_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //VALIDACIONES LOGIN
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

            this.login();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.salirSistema();
        }

        //METODO PARA SALIR DEL SISTEMA
        //RAFAEL ANGEL SEQUEIRA VARGAS
        public void salirSistema()
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

        //METODO LOGIN DEL SISTEMA
        //RAFAEL ANGEL SEQUEIRA VARGAS
        public void login()
        {
            string usuario = txt_Usuario.Text;
            string contrasenna = objSeguridad.MD5Hash(txt_Contraseña.Text);
            objUsuariosSistema.login_usuariosSistema(usuario, contrasenna);

            if (objUsuariosSistema.validacion == false)
            {
                intentosFallidos++;
                MessageBox.Show("Intento de login fallido, Cantidad de Intentos: "+intentosFallidos, "CUIDADO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Limpieza.limpiar(txt_Usuario);
                Limpieza.limpiar(txt_Contraseña);
                return;
            }
            if (objUsuariosSistema.validacion == true)
            {
                MessageBox.Show("BIENVENIDO AL SISTEMA", "DATOS CORRECTOS",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                frm_0MenuPrincipal ventana = new frm_0MenuPrincipal();
                frm_ReportesAlertas_MantenimientoAlertasNotificaciones ventanaReportes = new frm_ReportesAlertas_MantenimientoAlertasNotificaciones(usuario);
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
    }
}
