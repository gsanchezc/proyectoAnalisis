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
    public partial class frm_Ticket_AtencionTicket : Form
    {
        public frm_Ticket_AtencionTicket()
        {
            InitializeComponent();
        }

        private void frm_AtencioTicket_Load(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Desea volver al Catalogo", "Volver al Catalogo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void btn_ver_Click(object sender, EventArgs e)
        {
            frm_Ticket_BitacoraTicket ventana = new frm_Ticket_BitacoraTicket();

            if ((MessageBox.Show("Desea ir al historial de Bitacora", "Historial de Bitacora", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                this.Close();
                ventana.Show();
            }
            else
            {
                return;
            }
        }
    }
}
