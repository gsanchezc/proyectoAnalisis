﻿using System;
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

        private void frm_ReportesAlertas_MantenimientoAlertasNotificaciones_Load(object sender, EventArgs e)
        {
            this.cargaRolUsuario();
            this.TicketsPendientes();
            this.TicketsVencidos();
            this.cargarCantidadAlertasEmpleado();
            this.cargarAlertas();
            this.iniciaTimer();
            this.AlertasTicketsVencidos();
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
                dgv_AlertasEmpleados.Visible = false;
                gb_AlertasTicket.Visible = false;
                lb_numeroEmpleado.Visible = false;
                lb_Numero.Visible = false;
            }
            else 
            {
                dgv_AlertasEmpleados.Visible = true;
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
            int ticketVencidos = 0;

            if (rolUsuario == 2)
            {
                try
                {
                    DataSet ds;
                    ds = objAlertas.cantidadTicketsVencidos();
                    ticketVencidos = Convert.ToInt32(ds.Tables[0].Rows[0]["vencidos"]);
                    lb_TicketVencidos.Text = ticketVencidos.ToString();
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

        //METODO 
        //RAFAEL ANGEL SEQUEIRA VARGAS
        private void cargarAlertas()
        {
            if (rolUsuario != 6)
            {
                try
                {
                    dgv_AlertasEmpleados.AutoGenerateColumns = false;
                    dgv_AlertasEmpleados.DataSource = objAlertas.cargaAlertasPorEmpleado(IdEmpleado).Tables[0];
                }
                catch (Exception)
                {
                    MessageBox.Show("Hubo un problema con la conexion a la base de datos", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else { }
        }

        //METODO 
        //RAFAEL ANGEL SEQUEIRA VARGAS
        private void cargarCantidadAlertasEmpleado()
        {
            if (rolUsuario != 6)
            {
                objAlertas.cargaCantidadAlertasPorEmpleado(IdEmpleado);
                lb_CantidadAlertas.Text = objAlertas.cantidad.ToString();
            }
            else { }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            contadorseg++;
            this.TicketsPendientes();
            this.TicketsVencidos();
            this.cargarCantidadAlertasEmpleado();
            this.cargarAlertas();
            this.AlertasTicketsVencidos();

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
        private void AlertasTicketsVencidos()
        {
            int cantidad = 0;
            int Referencia = 0;
            int empleado = 0;
            try
            {
                DataSet ds;
                ds = objAlertas.TicketsVencidosParaAlertas();
                cantidad = ds.Tables[0].Rows.Count;

                for (int i = 0; i < cantidad; i++)
                {
                    Referencia = Convert.ToInt32(ds.Tables[0].Rows[i]["idTicket"]);
                    empleado = Convert.ToInt32(ds.Tables[0].Rows[i]["idEmpleado"]);
                    objAlertas.existeAlertaSobreReferencia(Referencia);

                    if (objAlertas.validacion == false)
                    {
                        objAlertas.idTipoAlerta = 1;
                        objAlertas.detalle = "Alerta de Ticket Por Ticket Vencido";
                        objAlertas.idEmpleado = empleado;
                        objAlertas.fechaFinalizacion = DateTime.Now.ToShortDateString();
                        objAlertas.idPrioridad = 5;
                        objAlertas.idEstatusAlertas = 1;
                        objAlertas.isDeleted = false;
                        objAlertas.Referencia = Referencia;

                        string accion = String.Empty;
                        accion = "Insertar";

                        if (objAlertas.insertar_Alerta(accion))
                        {
                            MessageBox.Show("Se ha enviado una alerta por este Ticket "+Referencia, "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error al enviar Alerta", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexion a la base de datos", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
