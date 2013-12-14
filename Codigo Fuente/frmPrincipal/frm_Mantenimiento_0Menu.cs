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
            frm_MantenimientoDepartamento ventana = new frm_MantenimientoDepartamento(usuarioSistema);
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

        private void btn_clienteUsuarioFinal_Click(object sender, EventArgs e)
        {
            frm_MantenimientoClienteUsuarioFinal ventana = new frm_MantenimientoClienteUsuarioFinal(usuarioSistema);
            this.Hide();
            ventana.Show();
        }

        private void btn_EmpresasCliente_Click(object sender, EventArgs e)
        {
            frm_MantenimientoEmpresaCliente ventana = new frm_MantenimientoEmpresaCliente(usuarioSistema);
            this.Hide();
            ventana.Show();
        }

        private void btn_StatusAlertas_Click(object sender, EventArgs e)
        {
            frm_MantenimientoEstatusAlertas ventana = new frm_MantenimientoEstatusAlertas(usuarioSistema);
            this.Hide();
            ventana.Show();
        }

        private void btn_Empleados_Click(object sender, EventArgs e)
        {
            frm_MantenimientoEmpleados ventana = new frm_MantenimientoEmpleados(usuarioSistema);
            this.Hide();
            ventana.Show();
        }

        private void btn_Facturas_Click(object sender, EventArgs e)
        {
            frm_MantenimientoFactura ventana = new frm_MantenimientoFactura(usuarioSistema);
            this.Hide();
            ventana.Show();
        }

        private void btn_Incapacidades_Click(object sender, EventArgs e)
        {
            frm_MantenimientoIncapacidades ventana = new frm_MantenimientoIncapacidades(usuarioSistema);
            this.Hide();
            ventana.Show();
        }

        private void btn_Nomina_Click(object sender, EventArgs e)
        {
            frm_MantenimientoNomina ventana = new frm_MantenimientoNomina(usuarioSistema);
            this.Hide();
            ventana.Show();
        }

        private void btn_ordenesCompra_Click(object sender, EventArgs e)
        {
            frm_MantenimientoOrdenCompra ventana = new frm_MantenimientoOrdenCompra(usuarioSistema);
            this.Hide();
            ventana.Show();
        }

        private void btn_Salarios_Click(object sender, EventArgs e)
        {
            frm_MantenimientoSalario ventana = new frm_MantenimientoSalario(usuarioSistema);
            this.Hide();
            ventana.Show();
        }

        private void btn_solicitudOrdenes_Click(object sender, EventArgs e)
        {
            frm_MantenimientoSolicitudOrdenCompra ventana = new frm_MantenimientoSolicitudOrdenCompra(usuarioSistema);
            this.Hide();
            ventana.Show();
        }

        private void btn_tickets_Click(object sender, EventArgs e)
        {
            frm_MantenimientoTickets ventana = new frm_MantenimientoTickets(usuarioSistema);
            this.Hide();
            ventana.Show();
        }

        private void btn_tipoAlertas_Click(object sender, EventArgs e)
        {
            frm_MantenimientoTipoAlerta ventana = new frm_MantenimientoTipoAlerta(usuarioSistema);
            this.Hide();
            ventana.Show();
        }

        private void btn_usuariosSistema_Click(object sender, EventArgs e)
        {
            frm_MantenimientoUsuariosSistema ventana = new frm_MantenimientoUsuariosSistema(usuarioSistema);
            this.Hide();
            ventana.Show();
        }

        private void btn_vacaciones_Click(object sender, EventArgs e)
        {
            frm_MantenimientoVacaciones ventana = new frm_MantenimientoVacaciones(usuarioSistema);
            this.Hide();
            ventana.Show();
        }

        private void btn_vacacionesAprobadas_Click(object sender, EventArgs e)
        {
            frm_MantenimientoVacacionesAprobadas ventana = new frm_MantenimientoVacacionesAprobadas(usuarioSistema);
            this.Hide();
            ventana.Show();
        }

        private void btn_tipoServicios_Click(object sender, EventArgs e)
        {
            frm_MantenimientoTipoServicio ventana = new frm_MantenimientoTipoServicio(usuarioSistema);
            this.Hide();
            ventana.Show();
        }
    }
}
