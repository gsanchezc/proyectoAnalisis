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
    public partial class frm_RRHH_ControlVacaciones : Form
    {
        public frm_RRHH_ControlVacaciones()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Desea volver al Menu Principal", "Volver al Menu Principal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
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
