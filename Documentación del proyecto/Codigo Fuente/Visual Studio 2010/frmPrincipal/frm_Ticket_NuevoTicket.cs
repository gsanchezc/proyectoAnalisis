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
    public partial class frm_Ticket_NuevoTicket : Form
    {
        public frm_Ticket_NuevoTicket()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Desea salir sin generar nuevo Ticket", "Volver al Menu Principal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                frm_0MenuPrincipal ventanaMenuPrincipal = new frm_0MenuPrincipal();
                ventanaMenuPrincipal.ShowDialog();
            }
            else
            {
                return;
            }
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {

        }

    }
}
