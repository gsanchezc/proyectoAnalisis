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
    public partial class frm_RRHH_NuevaIncapacidad : Form
    {
        public frm_RRHH_NuevaIncapacidad()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Desea salir sin generar factura", "Volver al Menu Principal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                frm_0MenuPrincipal ventana = new frm_0MenuPrincipal();
                this.Close();
                ventana.Show();
            }
            else
            {
                return;
            }
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {

        }
    }
}
