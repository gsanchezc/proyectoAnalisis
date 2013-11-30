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
    public partial class frm_CxC_CxP_ControlFacturas : Form
    {
        //DECLARACION DE INSTANCIAS DE LAS CLASES
        

        //VARIABLES GLOBALES
        private string usuarioSistema = string.Empty;

        public frm_CxC_CxP_ControlFacturas()
        {
            InitializeComponent();
        }

        public frm_CxC_CxP_ControlFacturas(string usuario) : this()
        {
            this.usuarioSistema = usuario;
        }

        private void frm_CxC_CxP_ControlFacturas_Load(object sender, EventArgs e)
        {

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            frm_CxC_CxP_NuevaFactura ventanaNuevaFactura = new frm_CxC_CxP_NuevaFactura(usuarioSistema);
            this.Hide();
            ventanaNuevaFactura.Show();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Desea volver al Menu", "Volver al Menu Principal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                frm_0MenuPrincipal ventanaMenuPrincipal = new frm_0MenuPrincipal(usuarioSistema);
                this.Hide();
                ventanaMenuPrincipal.Show();
            }
            else
            {
                return;
            }
        }

        private void frm_CxC_CxP_ControlFacturas_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = e.CloseReason == CloseReason.UserClosing;
        }
    }
}
