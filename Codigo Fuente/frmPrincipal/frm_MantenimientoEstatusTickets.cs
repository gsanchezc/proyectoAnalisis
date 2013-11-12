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
                dtg_EstatusTicket.AutoGenerateColumns = false;
                dtg_EstatusTicket.DataSource = objEstatusTicket.cargarEstatusTicket().Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txt_idEstatusTicket.Text = "0";
        }

        private void limpia()
        {
            txt_idEstatusTicket.Text = "0";
            txt_descripcion.Clear();
        }

        private void dtg_EstatusTicket_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.limpia();
            DataGridView thisGrid = (DataGridView)sender;
            DataTable table = (DataTable)thisGrid.DataSource;
            DataRow currenRow = table.Rows[thisGrid.CurrentCell.RowIndex];
            txt_idEstatusTicket.Text = currenRow["idEstatusTickets"].ToString();
            txt_descripcion.Text = currenRow["descripcion"].ToString();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (!Validaciones.esentero(txt_idEstatusTicket))
            {
                MessageBox.Show("El ID debe ser de tipo entero", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_idEstatusTicket.Focus();
                return;
            }

            if (!Validaciones.validar(txt_descripcion))
            {
                MessageBox.Show("Por favor ingrese una descripcion", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_descripcion.Focus();
                return;
            }
            objEstatusTicket.Id = Convert.ToInt32(txt_idEstatusTicket.Text);
            objEstatusTicket.Descripcion = txt_descripcion.Text;

            if ((Convert.ToInt32(txt_idEstatusTicket.Text)) != 0)
            {
                if (objEstatusTicket.agregarActualiazarEstatusTickets("Actualizar"))
                {
                    MessageBox.Show("El Estatus del Ticket se actualizó con exito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (objEstatusTicket.agregarActualiazarEstatusTickets("Insertar"))
                {
                    MessageBox.Show("El Estatus del Ticket se agrego con exito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            this.cargar_Estatus_Tickets();
            this.limpia();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            this.limpia();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (!Validaciones.esentero(txt_idEstatusTicket))
            {
                MessageBox.Show("El ID debe ser de tipo entero", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_idEstatusTicket.Focus();
                return;
            }

            if (!Validaciones.validar(txt_descripcion))
            {
                MessageBox.Show("Por favor ingrese una descripcion", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_descripcion.Focus();
                return;

            }
            objEstatusTicket.Id = Convert.ToInt32(txt_idEstatusTicket.Text);
            objEstatusTicket.Descripcion = txt_descripcion.Text;

            objEstatusTicket.eliminarEstatusTickets();
            MessageBox.Show("El Estatus del Ticket se eliminó con exito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.cargar_Estatus_Tickets();
            this.limpia();
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
