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
    public partial class frm_Seguridad_AdministracionCuentasUsuario : Form
    {
        UsuariosSistema objUsuariosSistema = new UsuariosSistema();
        Seguridad objSeguridad = new Seguridad();

        public frm_Seguridad_AdministracionCuentasUsuario()
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

        private void btn_establecer_Click(object sender, EventArgs e)
        {
            objUsuariosSistema.idRol = Convert.ToInt32(txt_Usuario.Text);
            objUsuariosSistema.contrasenna = objSeguridad.MD5Hash(txt_Contraseña.Text);
            objUsuariosSistema.isblock = false;
            objUsuariosSistema.idEmpleado = Convert.ToInt32(txt_Usuario.Text);
            objUsuariosSistema.isdeleted = false;

            string accion = String.Empty;
            accion = "Insertar";

            if (objUsuariosSistema.insertar_usuariosSistema(accion))
            {
                MessageBox.Show("Exito");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}

