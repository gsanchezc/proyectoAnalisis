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
    public partial class frm_Seguridad_Login : Form
    {
        public frm_Seguridad_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_0MenuPrincipal ventana = new frm_0MenuPrincipal();
            ventana.ShowDialog();
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
