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
    public partial class frm_Ticket_BitacoraTicket : Form
    {
        //DECLARACION DE INSTANCIAS DE LAS CLASES
        UsuariosSistema objUsuariosSistema = new UsuariosSistema();
        ClienteProveedor objClienteProveedor = new ClienteProveedor();
        Bitacora objBitacora = new Bitacora();

        //VARIABLES GLOBALES
        private string usuarioSistema = string.Empty;
        private string pantalla = string.Empty;
        private int Ticket = 0;

        public frm_Ticket_BitacoraTicket()
        {
            InitializeComponent();
        }

        public frm_Ticket_BitacoraTicket(string usuario, string pantalla, int Ticket) : this()
        {
            this.usuarioSistema = usuario;
            this.pantalla = pantalla;
            this.Ticket = Ticket;
        }

        private void frm_Ticket_BitacoraTicket_Load(object sender, EventArgs e)
        {
            this.inhabilitarControlBox();

            if (pantalla == "AtencionTicketEspecifico")
            {
                this.cargarDataGridBitacoraTicketEspecifico();
            }
            else if (pantalla == "AtencionTicketGeneral")
            {
                this.cargaDataGridBitacora();
            }
            else
            {
                this.cargaDataGridBitacora();
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            if (pantalla == "MenuPrincipal")
            {
                if ((MessageBox.Show("Desea volver al Menu Principal", "Volver al Menu Principal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
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
            else if (pantalla == "AtencionTicketEspecifico")
            {
                this.Hide();
            }
            else if (pantalla == "AtencionTicketGeneral")
            {
                this.Hide();
            }
            else 
            {
                if ((MessageBox.Show("Desea volver al Menu Principal", "Volver al Menu Principal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
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
        }

        private void cargaDataGridBitacora()
        {
            try
            {
                dgv_Bitacora.AutoGenerateColumns = false;
                dgv_Bitacora.DataSource = objBitacora.cargarDataGridBitacora().Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexion a la base de datos", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void cargarDataGridBitacoraTicketEspecifico()
        {
            try
            {
                dgv_Bitacora.AutoGenerateColumns = false;
                dgv_Bitacora.DataSource = objBitacora.cargarDataGridBitacoraTicketEspecifico(Ticket).Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexion a la base de datos", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void inhabilitarControlBox()
        {
            if (pantalla == "MenuPrincipal")
            {
                ControlBox = false;
            }
            else { }
        }

        private void dgv_Bitacora_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idBitacora;

            if (e.ColumnIndex == Consultar.Index && e.RowIndex >= 0)
            {
                idBitacora = Convert.ToInt32(dgv_Bitacora.Rows[e.RowIndex].Cells[0].Value.ToString());

                frm_Ticket_BitacoraDetalle ventana = new frm_Ticket_BitacoraDetalle(usuarioSistema, idBitacora, pantalla, Ticket);
                ventana.ShowDialog();
            }
            else
            { }
        }

        private void frm_Ticket_BitacoraTicket_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = e.CloseReason == CloseReason.UserClosing;
        }
    }
}
