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
    public partial class frm_Ticket_Clientes : Form
    {
        //DECLARACION DE INSTANCIAS DE LAS CLASES
        UsuariosSistema objUsuariosSistema = new UsuariosSistema();
        clientesUsuarioFinal objCliente = new clientesUsuarioFinal();
        Ticket objTicket = new Ticket();

        //VARIABLES GLOBALES
        private string usuarioSistema = string.Empty;
        private int IdClienteUsuarioFinal = 0;

        public frm_Ticket_Clientes()
        {
            InitializeComponent();
        }

        public frm_Ticket_Clientes(string usuario) : this()
        {
            this.usuarioSistema = usuario;          
        }

        private void frm_Ticket_Clientes_Load(object sender, EventArgs e)
        {
            this.cargarNumeroClienteUsuarioFinal();
            this.cargaDataGridMisTicketPendientesVistaCliente();
        }

        private void btn_regresarMenu_Click(object sender, EventArgs e)
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

        private void frm_Ticket_Clientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = e.CloseReason == CloseReason.UserClosing;
        }

        //METODO 
        //RAFAEL ANGEL SEQUEIRA VARGAS
        public void cargarNumeroClienteUsuarioFinal()
        {
            objCliente.cargaIdUsuarioSistemaPorNombreDeUsuario(usuarioSistema);
            IdClienteUsuarioFinal = objCliente.idClienteUsuarioFinal;
        }

        //METODO 
        //RAFAEL ANGEL SEQUEIRA VARGAS
        private void cargaDataGridMisTicketPendientesVistaCliente()
        {
            try
            {
                dtg_misTickets.AutoGenerateColumns = false;
                dtg_misTickets.DataSource = objTicket.cargarDataGridMisTicketsPendienteVistaCliente(IdClienteUsuarioFinal).Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexion a la base de datos", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //METODO 
        //RAFAEL ANGEL SEQUEIRA VARGAS
        private void cargaDataGridMisTicketCerradosVistaCliente()
        {
            try
            {
                dtg_misTickets.AutoGenerateColumns = false;
                dtg_misTickets.DataSource = objTicket.cargarDataGridMisTicketsCerradosVistaCliente(IdClienteUsuarioFinal).Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexion a la base de datos", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void rb_pendientes_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_pendientes.Checked == true)
            {
                this.cargaDataGridMisTicketPendientesVistaCliente();
            }
        }

        private void rb_Cerrados_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Cerrados.Checked == true)
            {
                this.cargaDataGridMisTicketCerradosVistaCliente();
            }
        }
    }
}
