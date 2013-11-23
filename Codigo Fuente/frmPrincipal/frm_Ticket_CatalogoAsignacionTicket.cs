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
    public partial class frm_Ticket_CatalogoAsignacionTicket : Form
    {
        //DECLARACION DE INSTANCIAS DE LAS CLASES
        UsuariosSistema objUsuariosSistema = new UsuariosSistema();
        ClienteProveedor objClienteProveedor = new ClienteProveedor();
        Ticket objTicket = new Ticket();

        //VARIABLES GLOBALES
        private string usuarioSistema = string.Empty;

        public frm_Ticket_CatalogoAsignacionTicket()
        {
            InitializeComponent();
        }

        public frm_Ticket_CatalogoAsignacionTicket(string usuario) : this()
        {
            this.usuarioSistema = usuario;
        }

        private void frm_Ticket_CatalogoAsignacionTicket_Load(object sender, EventArgs e)
        {
            this.cargaDataGridTicketParaSupervisor();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Desea volver al Menu Principal", "Volver al Menu Principal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                frm_0MenuPrincipal ventanaMenuPrincipal = new frm_0MenuPrincipal(usuarioSistema);
                this.Close();
                ventanaMenuPrincipal.Show();
            }
            else
            {
                return;
            }
        }

        private void cargaDataGridTicketParaSupervisor()
        {
            try
            {
                dtg_asignacionTicket.AutoGenerateColumns = false;
                dtg_asignacionTicket.DataSource = objTicket.cargarDataGridTicketParaSupervisor().Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexion a la base de datos", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void dtg_asignacionTicket_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int IdTicket;

            if (e.ColumnIndex == Atender.Index && e.RowIndex >= 0)
            {
                IdTicket = Convert.ToInt32(dtg_asignacionTicket.Rows[e.RowIndex].Cells[0].Value.ToString());

                frm_Ticket_AtencionTicket ventana = new frm_Ticket_AtencionTicket(usuarioSistema, IdTicket);
                this.Hide();
                ventana.Show();   
            }
            else
            { }
        }

        private void frm_Ticket_CatalogoAsignacionTicket_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = e.CloseReason == CloseReason.UserClosing;
        }
    }
}
