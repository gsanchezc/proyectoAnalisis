using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clases;

namespace frmPrincipal
{
    public partial class frm_CxC_CxP_NuevaSolicitudOrdenCompra : Form
    {
        //DECLARACION DE INSTANCIAS DE LAS CLASES
        UsuariosSistema objUsuariosSistema = new UsuariosSistema();
        SolicitudOrdenesCompra objSolicitud = new SolicitudOrdenesCompra();

        //VARIABLES GLOBALES
        private string usuarioSistema = string.Empty;
        private string pantalla = string.Empty;
        private int ticketID = 0;

        public frm_CxC_CxP_NuevaSolicitudOrdenCompra()
        {
            InitializeComponent();
        }

        public frm_CxC_CxP_NuevaSolicitudOrdenCompra(string usuario, int ticket, string pantalla) : this()
        {
            this.usuarioSistema = usuario;
            this.ticketID = ticket;
            this.pantalla = pantalla;
        }

        private void frm_CxC_CxP_NuevaSolicitudOrdenCompra_Load(object sender, EventArgs e)
        {
            txt_numeroTicket.Text = ticketID.ToString();
            txt_fechaSolicitud.Text = DateTime.Now.ToShortDateString().Substring(0, 10);
            this.limiteCampos();
        }

        private void frm_CxC_CxP_NuevaSolicitudOrdenCompra_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = e.CloseReason == CloseReason.UserClosing;
        }

        private void btn_CrearOrden_Click(object sender, EventArgs e)
        {
            if (validacionDeCampos() == true)
            {
                this.insertarSolicitud();
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            frm_Ticket_AtencionTicket ventana = new frm_Ticket_AtencionTicket(usuarioSistema, ticketID);
            this.Hide();
            ventana.Show();
        }

        public void limiteCampos()
        {
            txt_detalleSolicitud.MaxLength = 250;
        }

        //METODO VALIDACION DE DATOS
        //RAFAEL ANGEL SEQUEIRA VARGAS
        public bool validacionDeCampos()
        {
            if (!Validaciones.validar(txt_numeroTicket))
            {
                MessageBox.Show("No se cargo ningun Ticket", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_numeroTicket.Focus();
                return false;
            }
            if (!Validaciones.validar(txt_fechaSolicitud))
            {
                MessageBox.Show("No se cargo numero usuario", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_fechaSolicitud.Focus();
                return false;
            }
            if (!Validaciones.validar(txt_detalleSolicitud))
            {
                MessageBox.Show("No ingreso tema del Ticket", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_detalleSolicitud.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        //METODO VALIDACION DE DATOS
        //RAFAEL ANGEL SEQUEIRA VARGAS
        public void insertarSolicitud()
        {
            objSolicitud.idTicket = ticketID;
            objSolicitud.detalleOrden = txt_detalleSolicitud.Text;
            objSolicitud.fechaSolicitud = DateTime.Now.ToShortDateString();
            objSolicitud.isAproved = false;
            objSolicitud.isDeleted = false;

            string accion = String.Empty;
            accion = "Insertar";

            if (objSolicitud.insertar_SolicitudOrden(accion))
            {
                MessageBox.Show("Exito al guardar datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm_Ticket_AtencionTicket ventana = new frm_Ticket_AtencionTicket(usuarioSistema, ticketID);
                this.Hide();
                ventana.Show();
            }
            else
            {
                MessageBox.Show("Error al guardar datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
