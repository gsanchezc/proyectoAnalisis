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
    public partial class frm_Ticket_CatalogoAsignacionTicket : Form
    {
        public frm_Ticket_CatalogoAsignacionTicket()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
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
