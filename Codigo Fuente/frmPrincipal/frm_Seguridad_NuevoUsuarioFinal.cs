using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace frmPrincipal
{
    public partial class frm_Seguridad_NuevoUsuarioFinal : Form
    {
        public frm_Seguridad_NuevoUsuarioFinal()
        {
            InitializeComponent();
        }

        private void frm_Seguridad_NuevoUsuarioFinal_Load(object sender, EventArgs e)
        {

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Desea salir sin generar nuevo Usuario", "Volver al Menu Principal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                frm_0MenuPrincipal ventanaMenuPrincipal = new frm_0MenuPrincipal();
                this.Close();
                ventanaMenuPrincipal.Show();
            }
            else
            {
                return;
            }
        }
    }
}
