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
    public partial class frm_CxC_CxP_NuevaOrdenCompra : Form
    {
        public frm_CxC_CxP_NuevaOrdenCompra()
        {
            InitializeComponent();
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            frm_CxC_CxP_CatalogoOrdenesDeCompra ventana = new frm_CxC_CxP_CatalogoOrdenesDeCompra();

            if ((MessageBox.Show("Desea regresar al Catalogo", "Volver al Catalogo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
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
