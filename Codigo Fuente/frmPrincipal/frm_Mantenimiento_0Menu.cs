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
    public partial class frm_Mantenimiento_0Menu : Form
    {
        //DECLARACION DE INSTANCIAS DE LAS CLASES
        UsuariosSistema objUsuariosSistema = new UsuariosSistema();

        //VARIABLES GLOBALES
        private string usuarioSistema = string.Empty;

        public frm_Mantenimiento_0Menu()
        {
            InitializeComponent();
        }

        public frm_Mantenimiento_0Menu(string usuario) : this()
        {
            this.usuarioSistema = usuario;
        }

        private void frm_Mantenimiento_0Menu_Load(object sender, EventArgs e)
        {

        }

        private void btn_estatusFactura_Click(object sender, EventArgs e)
        {
            frm_Mantenimiento_estatusFacturas ventanaMantenimientoEstadoFacturas = new frm_Mantenimiento_estatusFacturas(usuarioSistema);
            this.Hide();
            ventanaMantenimientoEstadoFacturas.Show();

        }

        private void btn_descripcionRoles_Click(object sender, EventArgs e)
        {
            frm_MantenimientoDescripcionRoles ventanaDescripcionRoles = new frm_MantenimientoDescripcionRoles(usuarioSistema);
            this.Hide();
            ventanaDescripcionRoles.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_MantenimientoTipoPuestos ventanaTipoPuesto = new frm_MantenimientoTipoPuestos(usuarioSistema);
            this.Hide();
            ventanaTipoPuesto.Show();
        }

        private void btn_MantenimientoClienteProveedor_Click(object sender, EventArgs e)
        {
            frm_MantenimientoClienteProveedor ventana = new frm_MantenimientoClienteProveedor(usuarioSistema);
            this.Hide();
            ventana.Show();
        }

        private void btn_ManteniminetoTipoIdentificacion_Click(object sender, EventArgs e)
        {
            frm_MantenimientoTipoIdentificacion ventana = new frm_MantenimientoTipoIdentificacion(usuarioSistema);
            this.Hide();
            ventana.Show();
        }

        private void btn_MantenimientoDescripcionDepartamento_Click(object sender, EventArgs e)
        {
            frm_MantenimientoDescripcionDepartamento ventana = new frm_MantenimientoDescripcionDepartamento(usuarioSistema);
            this.Hide();
            ventana.Show();
        }

        private void btn_MantenimientoEstatusTickets_Click(object sender, EventArgs e)
        {
            frm_MantenimientoEstatusTickets ventanaEstatusTickets = new frm_MantenimientoEstatusTickets(usuarioSistema);
            this.Hide();
            ventanaEstatusTickets.Show();
        }

        private void btn_MantenimientoTipoPrioridades_Click(object sender, EventArgs e)
        {
            frm_MantenimientoTipoPrioridad ventana = new frm_MantenimientoTipoPrioridad(usuarioSistema);
            this.Hide();
            ventana.Show();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            frm_0MenuPrincipal ventana = new frm_0MenuPrincipal(usuarioSistema);

            if ((MessageBox.Show("Desea regresar al menu principal", "Volver al Menu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                this.Hide();
                ventana.Show();
            }
            else
            {
                return;
            }
        }
    }
}
