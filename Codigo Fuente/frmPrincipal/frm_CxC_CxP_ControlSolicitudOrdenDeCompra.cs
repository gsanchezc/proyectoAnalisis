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
    public partial class frm_CxC_CxP_ControlSolicitudOrdenDeCompra : Form
    {
        //DECLARACION DE INSTANCIAS DE LAS CLASES
        UsuariosSistema objUsuariosSistema = new UsuariosSistema();
        SolicitudOrdenesCompra objSolicitudCompra = new SolicitudOrdenesCompra();

        //VARIABLES GLOBALES
        private string usuarioSistema = string.Empty;
        private string pantalla = string.Empty;
        private int rolUsuario = 0;
        private int idSolicitudCompra = 0;
        private int IDTicket = 0;

        public frm_CxC_CxP_ControlSolicitudOrdenDeCompra()
        {
            InitializeComponent();
        }

        public frm_CxC_CxP_ControlSolicitudOrdenDeCompra(string usuario, string pantalla, int Ticket) : this()
        {
            this.usuarioSistema = usuario;
            this.pantalla = pantalla;
            this.IDTicket = Ticket;
        }

        private void frm_CxC_CxP_ControlSolicitudOrdenDeCompra_Load(object sender, EventArgs e)
        {
            this.cargaRolUsuario();

            if (pantalla == "TicketAtencion")
            {
                this.cargaDataGridSolicitudesDeCompraTicketEspecifico();
            }
            else if (pantalla == "MenuPrincipal")
            {
                this.cargaDataGridSolicitudesDeCompra();
            }
            else if (pantalla == "CatalogoSolicitudes")
            {
                this.cargaDataGridSolicitudesDeCompra();
            }
            else{}
        }

        private void frm_CxC_CxP_ControlSolicitudOrdenDeCompra_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = e.CloseReason == CloseReason.UserClosing;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            if (pantalla == "TicketAtencion")
            {
                frm_Ticket_AtencionTicket ventana = new frm_Ticket_AtencionTicket(usuarioSistema, IDTicket);
                this.Hide();
                ventana.Show();
            }
            else if (pantalla == "MenuPrincipal")
            {
                frm_0MenuPrincipal ventana = new frm_0MenuPrincipal(usuarioSistema);
                this.Hide();
                ventana.Show();
            }
            else if (pantalla == "CatalogoSolicitudes")
            {
                frm_0MenuPrincipal ventana = new frm_0MenuPrincipal(usuarioSistema);
                this.Hide();
                ventana.Show();
            }
            else
            { }
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

        //METODO 
        //RAFAEL ANGEL SEQUEIRA VARGAS
        private void cargaDataGridSolicitudesDeCompra()
        {
            try
            {
                dtg_CatalogoSolicitudesCompra.AutoGenerateColumns = false;
                dtg_CatalogoSolicitudesCompra.DataSource = objSolicitudCompra.cargarDataGridSolicitudesDeCompra().Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexion a la base de datos", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //METODO 
        //RAFAEL ANGEL SEQUEIRA VARGAS
        private void cargaDataGridSolicitudesDeCompraTicketEspecifico()
        {
            try
            {
                dtg_CatalogoSolicitudesCompra.AutoGenerateColumns = false;
                dtg_CatalogoSolicitudesCompra.DataSource = objSolicitudCompra.cargarDataGridSolicitudesDeCompraTicketEspecifico(IDTicket).Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexion a la base de datos", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void dtg_CatalogoSolicitudesCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Atender.Index && e.RowIndex >= 0)
            {
                if (pantalla == "TicketAtencion")
                {
                    MessageBox.Show("Usted no posee privilegios para atender Ordenes de Compra", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (pantalla == "MenuPrincipal")
                {
                    idSolicitudCompra = Convert.ToInt32(dtg_CatalogoSolicitudesCompra.Rows[e.RowIndex].Cells[0].Value.ToString());
                    pantalla = "CatalogoSolicitudes";
                    frm_CxC_CxP_NuevaOrdenCompra ventana = new frm_CxC_CxP_NuevaOrdenCompra(usuarioSistema, idSolicitudCompra, pantalla);
                    this.Hide();
                    ventana.Show();
                }
                else
                { }
            }
            else
            { }
        }
    }
}
