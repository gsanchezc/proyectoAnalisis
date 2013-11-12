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
    public partial class frm_0MenuPrincipal : Form
    {
        //DECLARACION DE INSTANCIAS DE LAS CLASES
        UsuariosSistema objUsuariosSistema = new UsuariosSistema();

        //VARIABLES GLOBALES
        private string usuarioSistema = string.Empty;
        private int rolUsuario;

        public frm_0MenuPrincipal()
        {
            InitializeComponent();
        }

        public frm_0MenuPrincipal(string usuario) : this()
        {
            this.usuarioSistema = usuario;
        }

        private void frm_0MenuPrincipal_Load(object sender, EventArgs e)
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
            if (rolUsuario == 1)//ADMINISTRADOR
            { 
            
            }
            else if (rolUsuario == 2)//SUPERVISOR
            {
                //GROUP BOX ENABLED FALSE
                foreach (Control controlSeguridad in gb_seguridad.Controls)
                {
                    controlSeguridad.Enabled = false;
                }
                foreach (Control controlCxC in gb_CxC.Controls)
                {
                    controlCxC.Enabled = false;
                }

                //BOTONES ENABLED FALSE
                btn_NuevoTicket.Enabled = false;
                btn_AtencionTicket.Enabled = false;
                btn_ControlNomina.Enabled = false;
                btn_ConfiguracionSistema.Enabled = false;

                //TOOL STRIP MENU ENABLED FALSE
                NuevoTicketToolStripMenuItem.Visible = false;
                CatalogoAtencionDeTicketToolStripMenuItem.Visible = false;
                controlNominaToolStripMenuItem.Visible = false;
                nuevoEmpleadoToolStripMenuItem1.Visible = false;
                solicitudDeVacacionesToolStripMenuItem.Visible = false;
                ingresoDeIncapacidadToolStripMenuItem.Visible = false;

                seguridadToolStripMenuItem.Enabled = false;
                contabilidadToolStripMenuItem.Enabled = false;
                mantenimientoToolStripMenuItem.Enabled = false;
            }
            else if (rolUsuario == 3)//TECNICO
            {
                //GROUP BOX ENABLED FALSE
                foreach (Control controlSeguridad in gb_seguridad.Controls)
                {
                    controlSeguridad.Enabled = false;
                }
                foreach (Control controlReportes in gb_reportes.Controls)
                {
                    controlReportes.Enabled = false;
                }
                foreach (Control controlCxC in gb_CxC.Controls)
                {
                    controlCxC.Enabled = false;
                }
                foreach (Control controlRRHH in gb_rrhh.Controls)
                {
                    controlRRHH.Enabled = false;
                }

                //BOTONES ENABLED FALSE
                btn_AsignarTicket.Enabled = false;
                btn_ConfiguracionSistema.Enabled = false;

                //TOOL STRIP MENU ENABLED FALSE
                CatalogoAsignacionDeTicketToolStripMenuItem.Visible = false;
                nuevaFacturaToolStripMenuItem.Visible = false;
                envioEstadoDeCuentasToolStripMenuItem.Visible = false;
                solicitudOrdenesCompraToolStripMenuItem.Visible = false;
                catalgoProveedoresToolStripMenuItem.Visible = false;
                nuevoProveedorToolStripMenuItem.Visible = false;
                controlNominaToolStripMenuItem.Visible = false;
                nuevoEmpleadoToolStripMenuItem1.Visible = false;
                controlVacacionesToolStripMenuItem.Visible = false;
                controlIncapacidadesToolStripMenuItem.Visible = false;

                reportesYAlertasToolStripMenuItem.Enabled = false;
                seguridadToolStripMenuItem.Enabled = false;
                mantenimientoToolStripMenuItem.Enabled = false;
            }
            else if(rolUsuario == 4)//RRHH
            {
                //GROUP BOX ENABLED FALSE
                foreach (Control cont in gb_tickets.Controls)
                {
                    cont.Enabled = false;
                }
                foreach (Control controlSeguridad in gb_seguridad.Controls)
                {
                    controlSeguridad.Enabled = false;
                }
                foreach (Control controlReportes in gb_reportes.Controls)
                {
                    controlReportes.Enabled = false;
                }
                foreach (Control controlCxC in gb_CxC.Controls)
                {
                    controlCxC.Enabled = false;
                }

                //BOTONES ENABLED FALSE
                btn_ConfiguracionSistema.Enabled = false;

                //TOOL STRIP MENU ENABLED FALSE
                ticketToolStripMenuItem.Enabled = false;
                seguridadToolStripMenuItem.Enabled = false;
                reportesYAlertasToolStripMenuItem.Enabled = false;
                contabilidadToolStripMenuItem.Enabled = false;
                mantenimientoToolStripMenuItem.Enabled = false;
            }
            else if (rolUsuario == 5)//CONTABILIDAD
            {
                //GROUP BOX ENABLED FALSE
                foreach (Control cont in gb_tickets.Controls)
                {
                    cont.Enabled = false;
                }
                foreach (Control controlSeguridad in gb_seguridad.Controls)
                {
                    controlSeguridad.Enabled = false;
                }
                foreach (Control controlReportes in gb_reportes.Controls)
                {
                    controlReportes.Enabled = false;
                }
                foreach (Control controlRRHH in gb_rrhh.Controls)
                {
                    controlRRHH.Enabled = false;
                }

                //BOTONES ENABLED FALSE
                btn_ConfiguracionSistema.Enabled = false;

                //TOOL STRIP MENU ENABLED FALSE
                ticketToolStripMenuItem.Enabled = false;
                seguridadToolStripMenuItem.Enabled = false;
                reportesYAlertasToolStripMenuItem.Enabled = false;
                rRHHToolStripMenuItem.Enabled = false;
                mantenimientoToolStripMenuItem.Enabled = false;
            }
            else if (rolUsuario == 6)//CLIENTE
            {
                //GROUP BOX ENABLED FALSE
                foreach (Control controlSeguridad in gb_seguridad.Controls)
                {
                    controlSeguridad.Enabled = false;
                }
                foreach (Control controlReportes in gb_reportes.Controls)
                {
                    controlReportes.Enabled = false;
                }
                foreach (Control controlCxC in gb_CxC.Controls)
                {
                    controlCxC.Enabled = false;
                }
                foreach (Control controlRRHH in gb_rrhh.Controls)
                {
                    controlRRHH.Enabled = false;
                }

                //BOTONES ENABLED FALSE
                btn_AsignarTicket.Enabled = false;
                btn_AtencionTicket.Enabled = false;
                btn_BitacoraTicket.Enabled = false;
                btn_ConfiguracionSistema.Enabled = false;

                //TOOL STRIP MENU ENABLED FALSE
                CatalogoAsignacionDeTicketToolStripMenuItem.Visible = false;
                CatalogoAtencionDeTicketToolStripMenuItem.Visible = false;
                BitacoraTicketToolStripMenuItem.Visible = false;

                contabilidadToolStripMenuItem.Enabled = false;
                rRHHToolStripMenuItem.Enabled = false;
                reportesYAlertasToolStripMenuItem.Enabled = false;
                seguridadToolStripMenuItem.Enabled = false;
                mantenimientoToolStripMenuItem.Enabled = false;
            }
            else//NINGUNO DE LOS ANTERIORES
            {
                //GROUP BOX ENABLED FALSE
                foreach (Control controlTicket in gb_tickets.Controls)
                {
                    controlTicket.Enabled = false;
                }
                foreach (Control controlSeguridad in gb_seguridad.Controls)
                {
                    controlSeguridad.Enabled = false;
                }
                foreach (Control controlReportes in gb_reportes.Controls)
                {
                    controlReportes.Enabled = false;
                }
                foreach (Control controlCxC in gb_CxC.Controls)
                {
                    controlCxC.Enabled = false;
                }
                foreach (Control controlRRHH in gb_rrhh.Controls)
                {
                    controlRRHH.Enabled = false;
                }

                //BOTONES ENABLED FALSE
                btn_ConfiguracionSistema.Enabled = false;

                //TOOL STRIP MENU ENABLED FALSE
                ticketToolStripMenuItem.Enabled = false;
                seguridadToolStripMenuItem.Enabled = false;
                reportesYAlertasToolStripMenuItem.Enabled = false;
                contabilidadToolStripMenuItem.Enabled = false;
                rRHHToolStripMenuItem.Enabled = false;
                mantenimientoToolStripMenuItem.Enabled = false;
            }
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Desea salir del Sistema", "Cierre del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Desea cerrar Sesion?", "Cerrar Sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                Application.Restart();
            }
            else
            {
                return;
            }         
        }

        private void NuevoTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Ticket_NuevoTicket ventanaNuevoTicket = new frm_Ticket_NuevoTicket(usuarioSistema);
            this.Hide();
            ventanaNuevoTicket.ShowDialog();
        }

        private void btn_NuevoTicket_Click(object sender, EventArgs e)
        {
            frm_Ticket_NuevoTicket ventanaNuevoTicket = new frm_Ticket_NuevoTicket(usuarioSistema);
            this.Hide();
            ventanaNuevoTicket.ShowDialog();
        }

        private void CatalogoAsignacionDeTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Ticket_CatalogoAsignacionTicket ventanaCatalogoTicket = new frm_Ticket_CatalogoAsignacionTicket(usuarioSistema);
            this.Hide();
            ventanaCatalogoTicket.ShowDialog();
        }

        private void btn_AsignarTicket_Click(object sender, EventArgs e)
        {
            frm_Ticket_CatalogoAsignacionTicket ventanaCatalogoTicket = new frm_Ticket_CatalogoAsignacionTicket(usuarioSistema);
            this.Hide();
            ventanaCatalogoTicket.ShowDialog();
        }

        private void CatalogoAtencionDeTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Ticket_CatalogoSeleccionTicket ventanaCatalogoTicket = new frm_Ticket_CatalogoSeleccionTicket(usuarioSistema);
            this.Hide();
            ventanaCatalogoTicket.ShowDialog();
        }

        private void btn_AtencionTicket_Click(object sender, EventArgs e)
        {
            frm_Ticket_CatalogoSeleccionTicket ventanaCatalogoTicket = new frm_Ticket_CatalogoSeleccionTicket(usuarioSistema);
            this.Hide();
            ventanaCatalogoTicket.ShowDialog();
        }

        private void BitacoraTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Ticket_BitacoraTicket ventanaBitacoraTicket = new frm_Ticket_BitacoraTicket(usuarioSistema);
            this.Hide();
            ventanaBitacoraTicket.ShowDialog();
        }

        private void btn_BitacoraTicket_Click(object sender, EventArgs e)
        {
            frm_Ticket_BitacoraTicket ventanaBitacoraTicket = new frm_Ticket_BitacoraTicket(usuarioSistema);
            this.Hide();
            ventanaBitacoraTicket.ShowDialog();
        }

        private void administracionPerfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Seguridad_AdministracionPerfiles ventanaAdministracionPerfiles = new frm_Seguridad_AdministracionPerfiles(usuarioSistema);
            this.Hide();
            ventanaAdministracionPerfiles.ShowDialog();
        }

        private void btn_AdministracionPerfiles_Click(object sender, EventArgs e)
        {
            frm_Seguridad_AdministracionPerfiles ventanaAdministracionPerfiles = new frm_Seguridad_AdministracionPerfiles(usuarioSistema);
            this.Hide();
            ventanaAdministracionPerfiles.ShowDialog();
        }

        private void administracionCuentasUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Seguridad_AdministracionCuentasUsuario ventanaAdministracionCuentas = new frm_Seguridad_AdministracionCuentasUsuario(usuarioSistema);
            this.Hide();
            ventanaAdministracionCuentas.ShowDialog();
        }

        private void btn_AdministracionCuentasUsuario_Click(object sender, EventArgs e)
        {
            frm_Seguridad_AdministracionCuentasUsuario ventanaAdministracionCuentas = new frm_Seguridad_AdministracionCuentasUsuario(usuarioSistema);
            this.Hide();
            ventanaAdministracionCuentas.ShowDialog();
        }

        private void nuevoUsuarioFinalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Seguridad_NuevoUsuarioFinal ventanaNuevoUsuario = new frm_Seguridad_NuevoUsuarioFinal(usuarioSistema);
            this.Hide();
            ventanaNuevoUsuario.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_Seguridad_NuevoUsuarioFinal ventanaNuevoUsuario = new frm_Seguridad_NuevoUsuarioFinal(usuarioSistema);
            this.Hide();
            ventanaNuevoUsuario.ShowDialog();
        }

        private void nuevaFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_CxC_CxP_NuevaFactura ventanaNuevaFactura = new frm_CxC_CxP_NuevaFactura(usuarioSistema);
            this.Hide();
            ventanaNuevaFactura.ShowDialog();
        }

        private void btn_NuevaFactura_Click(object sender, EventArgs e)
        {
            frm_CxC_CxP_NuevaFactura ventanaNuevaFactura = new frm_CxC_CxP_NuevaFactura(usuarioSistema);
            this.Hide();
            ventanaNuevaFactura.ShowDialog();
        }

        private void envioEstadoDeCuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_CxC_CxP_EnvioEstadosCuenta ventanaEnvioEstadosCuenta = new frm_CxC_CxP_EnvioEstadosCuenta(usuarioSistema);
            this.Hide();
            ventanaEnvioEstadosCuenta.ShowDialog();
        }

        private void btn_EnvioEstadosCuenta_Click(object sender, EventArgs e)
        {
            frm_CxC_CxP_EnvioEstadosCuenta ventanaEnvioEstadosCuenta = new frm_CxC_CxP_EnvioEstadosCuenta(usuarioSistema);
            this.Hide();
            ventanaEnvioEstadosCuenta.ShowDialog();
        }

        private void solicitudOrdenesCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_CxC_CxP_CatalogoOrdenesDeCompra ventanaCatalogoOrdenesCompra = new frm_CxC_CxP_CatalogoOrdenesDeCompra(usuarioSistema);
            this.Hide();
            ventanaCatalogoOrdenesCompra.ShowDialog();
        }

        private void btn_SolictudOrdenesCompra_Click(object sender, EventArgs e)
        {
            frm_CxC_CxP_CatalogoOrdenesDeCompra ventanaCatalogoOrdenesCompra = new frm_CxC_CxP_CatalogoOrdenesDeCompra(usuarioSistema);
            this.Hide();
            ventanaCatalogoOrdenesCompra.ShowDialog();
        }

        private void nuevaOrdenDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_CxC_CxP_NuevaOrdenCompra ventanaNuevaOrdenCompra = new frm_CxC_CxP_NuevaOrdenCompra(usuarioSistema);
            this.Hide();
            ventanaNuevaOrdenCompra.ShowDialog();
        }

        private void btn_nuevaOrdenCompra_Click(object sender, EventArgs e)
        {
            frm_CxC_CxP_NuevaOrdenCompra ventanaNuevaOrdenCompra = new frm_CxC_CxP_NuevaOrdenCompra(usuarioSistema);
            this.Hide();
            ventanaNuevaOrdenCompra.ShowDialog();
        }

        private void catalgoProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_CxC_CxP_CatalogoProveedores ventanaCatalogoProveedores = new frm_CxC_CxP_CatalogoProveedores(usuarioSistema);
            this.Hide();
            ventanaCatalogoProveedores.ShowDialog();
        }

        private void btn_CatalogoProveedores_Click(object sender, EventArgs e)
        {
            frm_CxC_CxP_CatalogoProveedores ventanaCatalogoProveedores = new frm_CxC_CxP_CatalogoProveedores(usuarioSistema);
            this.Hide();
            ventanaCatalogoProveedores.ShowDialog();
        }

        private void nuevoProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_CxC_CxP_NuevoProveedor ventanaNuevoProveedor = new frm_CxC_CxP_NuevoProveedor(usuarioSistema);
            this.Hide();
            ventanaNuevoProveedor.ShowDialog();
        }

        private void btn_NuevoProveedor_Click(object sender, EventArgs e)
        {
            frm_CxC_CxP_NuevoProveedor ventanaNuevoProveedor = new frm_CxC_CxP_NuevoProveedor(usuarioSistema);
            this.Hide();
            ventanaNuevoProveedor.ShowDialog();
        }

        private void controlNominaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_RRHH_ControlNomina ventanaControlNomina = new frm_RRHH_ControlNomina(usuarioSistema);
            this.Hide();
            ventanaControlNomina.ShowDialog();
        }

        private void btn_ControlNomina_Click(object sender, EventArgs e)
        {
            frm_RRHH_ControlNomina ventanaControlNomina = new frm_RRHH_ControlNomina(usuarioSistema);
            this.Hide();
            ventanaControlNomina.ShowDialog();
        }

        private void btn_NuevoEmpleado_Click(object sender, EventArgs e)
        {
            frm_RRHH_NuevoEmpleado ventanaNuevoEmpleado = new frm_RRHH_NuevoEmpleado(usuarioSistema);
            this.Hide();
            ventanaNuevoEmpleado.ShowDialog();
        }

        private void nuevoEmpleadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_RRHH_NuevoEmpleado ventanaNuevoEmpleado = new frm_RRHH_NuevoEmpleado(usuarioSistema);
            this.Hide();
            ventanaNuevoEmpleado.ShowDialog();
        }

        private void controlVacacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_RRHH_ControlVacaciones ventanaControlVacaciones = new frm_RRHH_ControlVacaciones(usuarioSistema);
            this.Hide();
            ventanaControlVacaciones.ShowDialog();
        }

        private void btn_ControlVacaciones_Click(object sender, EventArgs e)
        {
            frm_RRHH_ControlVacaciones ventanaControlVacaciones = new frm_RRHH_ControlVacaciones(usuarioSistema);
            this.Hide();
            ventanaControlVacaciones.ShowDialog();
        }

        private void solicitudDeVacacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_RRHH_NuevaSolicitudVacaciones ventanaSolicitudVacaciones = new frm_RRHH_NuevaSolicitudVacaciones(usuarioSistema);
            this.Hide();
            ventanaSolicitudVacaciones.ShowDialog();
        }

        private void btn_SolicitudVacaciones_Click(object sender, EventArgs e)
        {
            frm_RRHH_NuevaSolicitudVacaciones ventanaSolicitudVacaciones = new frm_RRHH_NuevaSolicitudVacaciones(usuarioSistema);
            this.Hide();
            ventanaSolicitudVacaciones.ShowDialog();
        }

        private void controlIncapacidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_RRHH_ControlIncapacidades ventanaControlIncapacidades = new frm_RRHH_ControlIncapacidades(usuarioSistema);
            this.Hide();
            ventanaControlIncapacidades.ShowDialog();
        }

        private void btn_ControlIncapacidades_Click(object sender, EventArgs e)
        {
            frm_RRHH_ControlIncapacidades ventanaControlIncapacidades = new frm_RRHH_ControlIncapacidades(usuarioSistema);
            this.Hide();
            ventanaControlIncapacidades.ShowDialog();
        }

        private void ingresoDeIncapacidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_RRHH_NuevaIncapacidad ventanaIngresoIncapacidad = new frm_RRHH_NuevaIncapacidad(usuarioSistema);
            this.Hide();
            ventanaIngresoIncapacidad.ShowDialog();
        }

        private void btn_IngresoIncapacidad_Click(object sender, EventArgs e)
        {
            frm_RRHH_NuevaIncapacidad ventanaIngresoIncapacidad = new frm_RRHH_NuevaIncapacidad(usuarioSistema);
            this.Hide();
            ventanaIngresoIncapacidad.ShowDialog();
        }

        private void btn_CerrarSesion_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Desea cerrar Sesion?", "Cerrar Sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                Application.Restart();
            }
            else
            {
                return;
            } 
        }

        private void btn_SalirSistema_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Desea salir del Sistema", "Cierre del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void btn_ConfiguracionSistema_Click(object sender, EventArgs e)
        {
            frm_Mantenimiento_0Menu ventanaMenuMantenimiento = new frm_Mantenimiento_0Menu(usuarioSistema);
            this.Hide();
            ventanaMenuMantenimiento.ShowDialog();
        }

        private void generarGraficoReporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ReportesAlertas_GenerarGrafico ventana = new frm_ReportesAlertas_GenerarGrafico(usuarioSistema);
            this.Hide();
            ventana.Show();
        }

        private void mantenimientoAlertasNotificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ReportesAlertas_MantenimientoAlertasNotificaciones ventana = new frm_ReportesAlertas_MantenimientoAlertasNotificaciones(usuarioSistema);
            ventana.Show();
        }

        private void mantenimientoComunicacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Mantenimiento_0Menu ventanaMenuMantenimiento = new frm_Mantenimiento_0Menu(usuarioSistema);
            this.Hide();
            ventanaMenuMantenimiento.ShowDialog();
        }

        private void configuracionDeSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Mantenimiento_0Menu ventana = new frm_Mantenimiento_0Menu(usuarioSistema);
            this.Hide();
            ventana.Show();
        }

        private void btn_GenerarGrafico_Click(object sender, EventArgs e)
        {
            frm_ReportesAlertas_GenerarGrafico ventana = new frm_ReportesAlertas_GenerarGrafico(usuarioSistema);
            this.Hide();
            ventana.Show();
        }

        private void btn_MantenimientoAlertasNotificaciones_Click(object sender, EventArgs e)
        {
            frm_ReportesAlertas_MantenimientoAlertasNotificaciones ventana = new frm_ReportesAlertas_MantenimientoAlertasNotificaciones(usuarioSistema);
            ventana.Show();
        }

        private void btn_MantenimientoComunicacion_Click(object sender, EventArgs e)
        {
            frm_ReporteAlertas_MantenimientoComunicacion ventana = new frm_ReporteAlertas_MantenimientoComunicacion(usuarioSistema);
            this.Hide();
            ventana.Show();
        }

        private void frm_0MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = e.CloseReason == CloseReason.UserClosing;
        }
    }
}
