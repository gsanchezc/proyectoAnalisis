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
    public partial class frm_ReportesAlertas_MantenimientoAlertasNotificaciones : Form
    {
        //DECLARACION DE INSTANCIAS DE LAS CLASES
        UsuariosSistema objUsuariosSistema = new UsuariosSistema();
        Alertas objAlertas = new Alertas();
        empleados objEmpleados = new empleados();
        StringBuilder stComunicado = new StringBuilder("Bienvenido al Sistema");

        //VARIABLES GLOBALES
        private string usuarioSistema = string.Empty;
        private int rolUsuario = 0;
        private int contadorseg = 0;
        private int IdEmpleado = 0;

        public frm_ReportesAlertas_MantenimientoAlertasNotificaciones()
        {
            InitializeComponent();
        }

        public frm_ReportesAlertas_MantenimientoAlertasNotificaciones(string usuario) : this()
        {
            this.usuarioSistema = usuario;
            labelUsuario.Text = usuarioSistema;
        }

        private void frm_ReportesAlertas_MantenimientoAlertasNotificaciones_Load(object sender, EventArgs e)
        {
            this.cargaRolUsuario();
            this.TicketsPendientes();
            this.TicketsVencidos();
            this.cargarComunicados();
            this.iniciaTimer();
        }

        //METODO PARA MANEJAR EL ACCESO POR ROLES
        //RAFAEL ANGEL SEQUEIRA VARGAS
        public void cargaRolUsuario()
        {
            objUsuariosSistema.cargaRolUsuario(usuarioSistema);
            rolUsuario = objUsuariosSistema.idRol;

            if (rolUsuario == 1)
            {
                labelDepartamento.Text = "Administrador";
            }
            else if (rolUsuario == 2)
            {
                labelDepartamento.Text = "Supervisor";
            }
            else if (rolUsuario == 3)
            {
                labelDepartamento.Text = "Tecnico";
                gb_AlertasRRHH.Visible = false;
            }
            else if (rolUsuario == 4)
            {
                labelDepartamento.Text = "RRHH";
            }
            else if (rolUsuario == 5)
            {
                labelDepartamento.Text = "Contabilidad";
            }
            else if (rolUsuario == 6)
            {
                labelDepartamento.Text = "Cliente";

                gb_AlertasRRHH.Visible = false;
                gb_AlertasTicket.Visible = false;
                lb_numeroEmpleado.Visible = false;
                lb_Numero.Visible = false;
            }
            else 
            {
                gb_AlertasRRHH.Visible = true;
                gb_AlertasRRHH.Visible = true;
                gb_AlertasTicket.Visible = true;
                lb_numeroEmpleado.Visible = true;
                lb_Numero.Visible = true;
            }

            if (rolUsuario != 6)
            {
                this.cargarNumeroEmpleado();
            }
        }

        private void frm_ReportesAlertas_MantenimientoAlertasNotificaciones_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = e.CloseReason == CloseReason.UserClosing;
        }

        //METODO 
        //RAFAEL ANGEL SEQUEIRA VARGAS
        private void TicketsPendientes()
        {
            if (rolUsuario == 2)
            {
                try
                {
                    DataSet ds;
                    ds = objAlertas.cantidadTicketsPendientesSupervisor();
                    lb_TicketPendientes.Text = ds.Tables[0].Rows[0]["PendientesSupervisor"].ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Hubo un problema con la conexion a la base de datos", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (rolUsuario == 3)
            {
                objAlertas.cantidadTicketsPendientesTecnico(IdEmpleado);
                lb_TicketPendientes.Text = objAlertas.cantidad.ToString();
            }
            else { }
        }

        //METODO 
        //RAFAEL ANGEL SEQUEIRA VARGAS
        private void TicketsVencidos()
        {
            if (rolUsuario == 2)
            {
                try
                {
                    DataSet ds;
                    ds = objAlertas.cantidadTicketsVencidos();
                    lb_TicketVencidos.Text = ds.Tables[0].Rows[0]["vencidos"].ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Hubo un problema con la conexion a la base de datos", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (rolUsuario == 3)
            {
                objAlertas.cantidadTicketsVencidosPorTecnico(IdEmpleado);
                lb_TicketVencidos.Text = objAlertas.cantidad.ToString();
            }
            else { }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            contadorseg++;
            this.TicketsPendientes();
            this.TicketsVencidos();
            stComunicado.Clear();
            this.cargarComunicados();

            lb_MinutosTranscurridos.Text = contadorseg.ToString();
        }

        //METODO INICIAR TIMER
        //RAFAEL ANGEL SEQUEIRA VARGAS
        public void iniciaTimer()
        {
            timer1.Start();        
        }

        //METODO 
        //RAFAEL ANGEL SEQUEIRA VARGAS
        public void cargarNumeroEmpleado()
        {
            objEmpleados.cargaIdEmpleadoPorNombreUsuario(usuarioSistema);
            IdEmpleado = objEmpleados.idEmpleado;
            lb_Numero.Text = IdEmpleado.ToString();
        }

        //METODO 
        //RAFAEL ANGEL SEQUEIRA VARGAS
        public void cargarComunicados()
        {
            if (Convert.ToInt32(lb_TicketVencidos.Text) > 0)
            {
                stComunicado.Append(Environment.NewLine);
                stComunicado.Append("Tienes "+Convert.ToInt32(lb_TicketVencidos.Text)+" tickets vencidos");
            }

            txt_Comunicados.Text = stComunicado.ToString();
        }
    }
}
