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
    public partial class frm_CxC_CxP_NuevoProveedor : Form
    {
        public frm_CxC_CxP_NuevoProveedor()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {

        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            frm_CxC_CxP_CatalogoProveedores ventana = new frm_CxC_CxP_CatalogoProveedores();

            if ((MessageBox.Show("Desea regresar al catalogo", "Volver al Catalogo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
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
