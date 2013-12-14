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
    public partial class frm_MantenimientoEstatusTickets : Form
    {
        //DECLARACION DE INSTANCIAS DE LAS CLASES
        UsuariosSistema objUsuariosSistema = new UsuariosSistema();
        EstatusTicket objEstatusTicket = new EstatusTicket();

        //VARIABLES GLOBALES
        private string usuarioSistema = string.Empty;

        public frm_MantenimientoEstatusTickets()
        {
            InitializeComponent();
        }

        public frm_MantenimientoEstatusTickets(string usuario) : this()
        {
            this.usuarioSistema = usuario;
        }

        private void frm_MantenimientoEstatusTickets_Load(object sender, EventArgs e)
        {
            this.cargar_Estatus_Tickets();
            this.limpia();
        }

        private void cargar_Estatus_Tickets()
        {
            try
            {

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void limpia()
        {

        }

        private void dtg_EstatusTicket_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            this.limpia();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            frm_Mantenimiento_0Menu ventana = new frm_Mantenimiento_0Menu(usuarioSistema);

            if ((MessageBox.Show("Desea regresar al menu principal", "Volver al Menu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
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
