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
    public partial class frm_Ticket_AtencionTicket : Form
    {
        //DECLARACION DE INSTANCIAS DE LAS CLASES
        UsuariosSistema objUsuariosSistema = new UsuariosSistema();
        ClienteProveedor objClienteProveedor = new ClienteProveedor();

        //VARIABLES GLOBALES
        private string usuarioSistema = string.Empty;
        private int rolUsuario;

        public frm_Ticket_AtencionTicket()
        {
            InitializeComponent();
        }

        public frm_Ticket_AtencionTicket(string usuario) : this()
        {
            this.usuarioSistema = usuario;
        }

        private void frm_AtencioTicket_Load(object sender, EventArgs e)
        {
            this.cargaRolUsuario();
            this.rolesUsuario();
        }

        //METODO PARA MANEJAR EL ACCESO POR ROLES
        //RAFAEL ANGEL SEQUEIRA VARGAS
        public void cargaRolUsuario()
        {
            objUsuariosSistema.cargaRolUsuario(usuarioSistema);
            rolUsuario = objUsuariosSistema.idRol;
        }

        //METODO PARA MANEJAR EL ACCESO POR ROLES
        //RAFAEL ANGEL SEQUEIRA VARGAS
        public void rolesUsuario()
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
            frm_Ticket_BitacoraTicket ventana = new frm_Ticket_BitacoraTicket(usuarioSistema);

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
