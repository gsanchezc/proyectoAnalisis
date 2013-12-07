using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clases;
using System.IO;
using System.Diagnostics;

namespace frmPrincipal
{
    public partial class frm_Ticket_AtencionTicket : Form
    {
        //DECLARACION DE INSTANCIAS DE LAS CLASES
        UsuariosSistema objUsuariosSistema = new UsuariosSistema();
        ClienteProveedor objClienteProveedor = new ClienteProveedor();
        Ticket objTicket = new Ticket();
        EstatusTicket objEstatusTicket = new EstatusTicket();
        TipoPrioridad objTipoPrioridad = new TipoPrioridad();
        empleados objEmpleados = new empleados();
        ArchivosAdjuntos objArchivosAdjuntos = new ArchivosAdjuntos();
        Bitacora objBitacora = new Bitacora();
        Alertas objAlertas = new Alertas();

        //CONECCION
        SqlConnection sqlcon = new SqlConnection(@"Data Source=(local);Initial Catalog=db_soportic;Integrated Security=True");
        SqlCommand sqlcmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        //VARIABLES GLOBALES
        private string usuarioSistema = string.Empty;
        private int ticketID = 0;
        private int rolUsuario;
        private string filefullpath = string.Empty;
        private string filetype = string.Empty;
        private string filename = string.Empty;
        private byte[] FileBytes = null;
        private bool isDeleted = false;
        private int contadorseg = 0;

        public frm_Ticket_AtencionTicket()
        {
            InitializeComponent();
        }

        public frm_Ticket_AtencionTicket(string usuario, int ticket) : this()
        {
            this.usuarioSistema = usuario;
            this.ticketID = ticket;
        }

        private void frm_AtencioTicket_Load(object sender, EventArgs e)
        {
            txt_IdTicket.Text = ticketID.ToString();
            pictureBox1.Visible = false;

            this.cargarComboBoxEstatusTicket();
            this.cargarComboBoxPrioridad();
            this.cargarComboBoxTecnicoAsignado();
            this.limiteCampos();

            this.cargaRolUsuario();
            this.rolesUsuario();

            this.cargarInfoTicket();
            this.actualizarFechaInicio();
            this.inciaTimer();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            if (rolUsuario == 1)
            {
                if ((MessageBox.Show("Desea volver al Catalogo", "Volver al Catalogo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    frm_Ticket_CatalogoAsignacionTicket ventanaMenuPrincipal = new frm_Ticket_CatalogoAsignacionTicket(usuarioSistema);
                    this.Hide();
                    ventanaMenuPrincipal.Show();
                }
                else
                {
                    return;
                }
            }
            else if (rolUsuario == 2)
            {
                if ((MessageBox.Show("Desea volver al Catalogo", "Volver al Catalogo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    frm_Ticket_CatalogoAsignacionTicket ventanaMenuPrincipal = new frm_Ticket_CatalogoAsignacionTicket(usuarioSistema);
                    this.Hide();
                    ventanaMenuPrincipal.Show();
                }
                else
                {
                    return;
                }
            }
            else if (rolUsuario == 3)
            {
                if ((MessageBox.Show("Desea volver al Catalogo", "Volver al Catalogo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    frm_Ticket_CatalogoSeleccionTicket ventanaMenuPrincipal = new frm_Ticket_CatalogoSeleccionTicket(usuarioSistema);
                    this.Hide();
                    ventanaMenuPrincipal.Show();
                }
                else
                {
                    return;
                }
            }
            else
            { }
        }

        private void btn_ver_Click(object sender, EventArgs e)
        {
            string pantalla = "AtencionTicketGeneral";
            frm_Ticket_BitacoraTicket ventana = new frm_Ticket_BitacoraTicket(usuarioSistema, pantalla, ticketID);
            ventana.Show();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (rolUsuario == 1)
            {
                if(Convert.ToInt32(cmb_prioridad.SelectedValue.ToString()) ==  1)
                {
                    MessageBox.Show("No se ha establecido prioridad para este Ticket", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if(Convert.ToInt32(cmb_tecnico.SelectedValue.ToString()) == 0)
                {
                    MessageBox.Show("No se ha establecido prioridad para este Ticket", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    this.actualizarTicketSupervisor();
                }
            }
            else if (rolUsuario == 2)
            {
                if (Convert.ToInt32(cmb_prioridad.SelectedValue.ToString()) == 1)
                {
                    MessageBox.Show("No se ha establecido prioridad para este Ticket", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (cmb_tecnico.SelectedItem == null)
                {
                    MessageBox.Show("No se ha establecido Empleado para este Ticket", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (Convert.ToInt32(cmb_status.SelectedValue.ToString()) == 1)
                    {
                        MessageBox.Show("No has cambiado el estatus del Ticket", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (Convert.ToInt32(cmb_status.SelectedValue.ToString()) == 5 && Convert.ToInt32(cmb_prioridad.SelectedValue.ToString()) == 5)
                        {
                            this.actualizarTicketSupervisor();
                            objAlertas.actualizaAlertasPorPrioridad(ticketID);
                        }
                        else
                        {
                            this.actualizarTicketSupervisor();
                            if (Convert.ToInt32(cmb_prioridad.SelectedValue.ToString()) == 5 || Convert.ToInt32(cmb_prioridad.SelectedValue.ToString()) == 6)
                            {
                                objAlertas.idTipoAlerta = 1;
                                objAlertas.detalle = "Alerta de Ticket Prioridad Critica o Urgente";
                                objAlertas.idEmpleado = Convert.ToInt32(cmb_tecnico.SelectedValue);
                                objAlertas.fechaFinalizacion = txt_FechaEntrega.Text;
                                objAlertas.idPrioridad = Convert.ToInt32(cmb_prioridad.SelectedValue);
                                objAlertas.idEstatusAlertas = 1;
                                objAlertas.isDeleted = false;
                                objAlertas.Referencia = Convert.ToInt32(txt_IdTicket.Text);

                                string accion = String.Empty;
                                accion = "Insertar";

                                if (objAlertas.insertar_Alerta(accion))
                                {
                                    MessageBox.Show("Se ha enviado una alerta por este Ticket", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Error al enviar Alerta", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                        }  
                    }
                }
            }
            else if (rolUsuario == 3)
            {
                objBitacora.validarBitacora(Convert.ToInt32(txt_IdTicket.Text));
                if (objBitacora.validacion == false)
                {
                    MessageBox.Show("Ticket debe tener al menos una Bitacora para enviarse a aprobacion", "Ticket no tiene Bitacoras de Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    this.actualizarTicketTecnico();
                }  
            }
            else { }
        }

        private void btn_agregarBitacora_Click(object sender, EventArgs e)
        {
            if (validacionDeCampos() == true)
            {
                this.guardarBitacora();
            }
        }

        private void btn_VerArchivoAdjuntoCliente_Click(object sender, EventArgs e)
        {
            this.abrirArchivoAdjunto();
        }

        private void btn_AdjuntarArchivoTecnico_Click(object sender, EventArgs e)
        {
            this.cargaArchivoAdjunto();
        }

        private void btn_GuardarArchivoTecnico_Click(object sender, EventArgs e)
        {
            this.guardarArchivoAdjunto();
        }

        private void btn_VerBitacoraTicket_Click(object sender, EventArgs e)
        {
            string pantalla = "AtencionTicketEspecifico";
            frm_Ticket_BitacoraTicket ventana = new frm_Ticket_BitacoraTicket(usuarioSistema, pantalla, ticketID);
            ventana.Show();
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
                txt_detalleBitacora.Enabled = false;
                btn_agregarBitacora.Enabled = false;
                btn_AdjuntarArchivoTecnico.Enabled = false;
                btn_GuardarArchivoTecnico.Enabled = false;
                btn_verHistorial.Enabled = false;
                btn_NuevaSolicitud.Enabled = false;
            }
            else if (rolUsuario == 3)//TECNICO
            {
                cmb_prioridad.Enabled = false;
                cmb_tecnico.Enabled = false;
                btn_GuardarArchivoTecnico.Enabled = false;
            }
            else//NINGUNO DE LOS ANTERIORES
            {}
        }

        //METODO PARA CARGAR INFORMACION DE UN TICKET
        //RAFAEL ANGEL SEQUEIRA VARGAS
        private void cargarInfoTicket()
        {
            objTicket.cargaInfoTicket(ticketID);

            txt_nombreUsuario.Text = objTicket.nombreUsuario;
            txt_Departamento.Text = objTicket.Departamento;
            txt_TipoServicio.Text = objTicket.TipoServicio;
            txt_temaTicket.Text = objTicket.titulo;
            txt_FechaIngreso.Text = objTicket.fechaRegistro;
            txt_decripcion.Text = objTicket.descripcion;
            txt_archivoAdjuntoCliente.Text = objTicket.idArchivoAdjunto.ToString();
            txt_FechaAsignacion.Text = objTicket.fechaAsignacion;
            txt_FechaInicio.Text = objTicket.fechaInicio;
            txt_FechaEntrega.Text = objTicket.fechaEntrega;

            if (Convert.ToInt32(objTicket.idArchivoAdjunto) == 0)
            {
                btn_VerArchivoAdjuntoCliente.Enabled = false;
                pb_ArchivoAdjunto.Visible = false;
            }

            cmb_status.SelectedValue = objTicket.idEstatusTickets;
            cmb_prioridad.SelectedValue = objTicket.idPrioridad;
            cmb_tecnico.SelectedValue = objTicket.idEmpleado;
        }

        //METODO ABRE ARCHIVO ADJUNTO
        //RAFAEL ANGEL SEQUEIRA VARGAS
        public void abrirArchivoAdjunto()
        {
            string id;
            FileStream FS = null;
            byte[] dbbyte;

            id = txt_archivoAdjuntoCliente.Text;

            sqlcon.Open();
            sqlcmd = new SqlCommand("select * from tbl_datosAdjuntos where idArchivoAdjunto='" + id + "'", sqlcon);
            da = new SqlDataAdapter(sqlcmd);
            dt = new DataTable();
            da.Fill(dt);
            sqlcon.Close();

            if (dt.Rows.Count > 0)
            {
                dbbyte = (byte[])dt.Rows[0]["archivo"];
                string filepath = "D:\\temp.pdf";

                FS = new FileStream(filepath, System.IO.FileMode.Create);
                FS.Write(dbbyte, 0, dbbyte.Length);
                FS.Close();

                Process Proc = new Process();
                Proc.StartInfo.FileName = filepath;
                Proc.Start();
            }
            sqlcon.Close();
        }

        //METODO CARGA COMBO BOX STATUS TICKET
        //RAFAEL ANGEL SEQUEIRA VARGAS
        private void cargarComboBoxEstatusTicket()
        {
            try
            {
                DataSet ds;
                ds = objEstatusTicket.cargarEstatusTicket();
                cmb_status.DataSource = ds.Tables[0];
                cmb_status.DisplayMember = ds.Tables[0].Columns["descripcion"].ColumnName.ToString();
                cmb_status.ValueMember = ds.Tables[0].Columns["idEstatusTickets"].ColumnName.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexion a la base de datos", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //METODO CARGA COMBO BOX PRIORIDAD
        //RAFAEL ANGEL SEQUEIRA VARGAS
        private void cargarComboBoxPrioridad()
        {
            try
            {
                DataSet ds;
                ds = objTipoPrioridad.cargarTipoPrioridad();
                cmb_prioridad.DataSource = ds.Tables[0];
                cmb_prioridad.DisplayMember = ds.Tables[0].Columns["descripcion"].ColumnName.ToString();
                cmb_prioridad.ValueMember = ds.Tables[0].Columns["idPrioridad"].ColumnName.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexion a la base de datos", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //METODO CARGA COMBO BOX TECNICO ASIGNADO
        //RAFAEL ANGEL SEQUEIRA VARGAS
        private void cargarComboBoxTecnicoAsignado()
        {
            try
            {
                DataSet ds;
                ds = objEmpleados.cargarEmpleadosTecnicos();
                cmb_tecnico.DataSource = ds.Tables[0];
                cmb_tecnico.DisplayMember = ds.Tables[0].Columns["Empleado"].ColumnName.ToString();
                cmb_tecnico.ValueMember = ds.Tables[0].Columns["idEmpleado"].ColumnName.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexion a la base de datos", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void actualizarTicketSupervisor()
        {
            objTicket.idTicket = Convert.ToInt32(txt_IdTicket.Text);
            objTicket.idEstatusTickets = Convert.ToInt32(cmb_status.SelectedValue);
            objTicket.idPrioridad = Convert.ToInt32(cmb_prioridad.SelectedValue);
            objTicket.idEmpleado = Convert.ToInt32(cmb_tecnico.SelectedValue);
            objTicket.fechaAsignacion = DateTime.Now.ToShortDateString();
            objTicket.fechaEntrega = txt_FechaEntrega.Text;

            string accion = String.Empty;
            accion = "Editar";

            if (objTicket.actualizar_TicketSupervisor(accion))
            {
                MessageBox.Show("Exito al actualizar datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm_Ticket_CatalogoAsignacionTicket ventana = new frm_Ticket_CatalogoAsignacionTicket(usuarioSistema);
                this.Hide();
                ventana.Show();
            }
            else
            {
                MessageBox.Show("Error al guardar datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void actualizarTicketTecnico()
        {
            objTicket.idTicket = Convert.ToInt32(txt_IdTicket.Text);
            objTicket.idEstatusTickets = Convert.ToInt32(cmb_status.SelectedValue);

            string accion = String.Empty;
            accion = "Editar";

            if (objTicket.actualizar_TicketTecnico(accion))
            {
                MessageBox.Show("Exito al actualizar datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm_Ticket_CatalogoSeleccionTicket ventana = new frm_Ticket_CatalogoSeleccionTicket(usuarioSistema);
                this.Hide();
                ventana.Show();
            }
            else
            {
                MessageBox.Show("Error al guardar datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void cmb_prioridad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rolUsuario == 2)
            {
                if (cmb_prioridad.SelectedIndex == 0)
                {
                    txt_FechaEntrega.Text = "Fecha Entrega No Definida";
                }
                else if (cmb_prioridad.SelectedIndex == 1)
                {
                    txt_FechaEntrega.Text = DateTime.Now.AddDays(7).ToShortDateString();
                }
                else if (cmb_prioridad.SelectedIndex == 2)
                {
                    txt_FechaEntrega.Text = DateTime.Now.AddDays(5).ToShortDateString();
                }
                else if (cmb_prioridad.SelectedIndex == 3)
                {
                    txt_FechaEntrega.Text = DateTime.Now.AddDays(3).ToShortDateString();
                }
                else if (cmb_prioridad.SelectedIndex == 4)
                {
                    txt_FechaEntrega.Text = DateTime.Now.AddDays(1).ToShortDateString();
                }
                else if (cmb_prioridad.SelectedIndex == 5)
                {
                    txt_FechaEntrega.Text = DateTime.Now.ToShortDateString();
                }
                else { }
            }
            else
            { }
        }

        private void actualizarFechaInicio()
        {
            if (rolUsuario == 3)
            {
                if (txt_FechaInicio.Text == "No iniciado aun")
                {
                    objTicket.idTicket = Convert.ToInt32(txt_IdTicket.Text);
                    objTicket.fechaInicio = DateTime.Now.ToShortDateString();

                    string accion = String.Empty;
                    accion = "Editar";

                    if (objTicket.actualizar_TicketFechaInicio(accion))
                    {
                        MessageBox.Show("La fecha de inicio de este Ticket es " + DateTime.Now.ToShortDateString(), "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        objTicket.cargaInfoTicket(ticketID);
                        txt_FechaInicio.Text = objTicket.fechaInicio;
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else { }
            }
            else { }
        }

        //METODO CARGA ARCHIVO ADJUNTO
        //RAFAEL ANGEL SEQUEIRA VARGAS
        public void cargaArchivoAdjunto()
        {
            OpenFileDialog fDialog = new OpenFileDialog();
            fDialog.Title = "Select file to be upload";
            fDialog.Filter = "PDF Files|*.pdf";

            if (fDialog.ShowDialog() == DialogResult.OK)
            {
                filefullpath = fDialog.FileName.ToString();
            }

            filename = filefullpath.Substring(Convert.ToInt32(filefullpath.LastIndexOf("\\")) + 1, filefullpath.Length - (Convert.ToInt32(filefullpath.LastIndexOf("\\")) + 1));
            filetype = filefullpath.Substring(Convert.ToInt32(filefullpath.LastIndexOf(".")) + 1, filefullpath.Length - (Convert.ToInt32(filefullpath.LastIndexOf(".")) + 1));

            if (filetype.ToUpper() != "PDF")
            {
                MessageBox.Show("Upload Only PDF Files");
                return;
            }

            txt_FileName.Text = filename;
            txt_FileExtension.Text = filetype;

            try
            {
                FileStream FS = new FileStream(filefullpath, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                BinaryReader BR = new BinaryReader(FS);
                long allbytes = new FileInfo(filefullpath).Length;
                FileBytes = BR.ReadBytes((Int32)allbytes);

                FS.Close();
                FS.Dispose();
                BR.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during File Read " + ex.ToString());
            }
        }

        //METODO GUARDA ARCHIVO ADJUNTO
        //RAFAEL ANGEL SEQUEIRA VARGAS
        public void guardarArchivoAdjunto()
        {
            try
            {
                sqlcon.Open();
                SqlCommand sqlcmd = new SqlCommand("insert into tbl_datosAdjuntos(nombre,archivo,isDeleted) values (@nombre, @archivo, @isDeleted)", sqlcon);
                sqlcmd.Parameters.AddWithValue("@nombre", filename);
                sqlcmd.Parameters.AddWithValue("@archivo", FileBytes);
                sqlcmd.Parameters.AddWithValue("@isDeleted", isDeleted);
                sqlcmd.ExecuteNonQuery();
                sqlcon.Close();

                MessageBox.Show("Archivo almacenado", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox1.Visible = true;

                objArchivosAdjuntos.cargaIDArchivoAdjuntoRecienGuardado();
                txt_IdArchivoAdjuntoTecnico.Text = objArchivosAdjuntos.idArchivoAdjunto.ToString(); ;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo almacenar archivo " + ex.ToString(), "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //METODO TIMERTICK
        //RAFAEL ANGEL SEQUEIRA VARGAS
        private void timer1_Tick(object sender, EventArgs e)
        {
            contadorseg++;
            txt_tiempoLaborado.Text = contadorseg.ToString();
        }

        //METODO INICIAR TIMER
        //RAFAEL ANGEL SEQUEIRA VARGAS
        public void inciaTimer()
        {
            if (rolUsuario == 3)
            {
                timer1.Start();
                txt_tiempoLaborado.Text = "0";
            }
            else { }
        }

        //METODO VALIDACION DE DATOS
        //RAFAEL ANGEL SEQUEIRA VARGAS
        public bool validacionDeCampos()
        {
            if (!Validaciones.validar(txt_detalleBitacora))
            {
                MessageBox.Show("No ingreso detalle de la Bitacora", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_detalleBitacora.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        //METODO VALIDACION DE DATOS
        //RAFAEL ANGEL SEQUEIRA VARGAS
        public void guardarBitacora()
        {
            objBitacora.idTicket = Convert.ToInt32(txt_IdTicket.Text) ;
            objBitacora.tiempoLaborado = Convert.ToInt32(txt_tiempoLaborado.Text);
            objBitacora.descripcion = txt_detalleBitacora.Text;
            objBitacora.fecha = DateTime.Now.ToShortDateString();
            objBitacora.idEmpleado = Convert.ToInt32(cmb_tecnico.SelectedValue);
            objBitacora.isDeleted = false;

            string accion = String.Empty;
            accion = "Insertar";

            if (pictureBox1.Visible == false)
            {
                if (objBitacora.insertar_BitacoraSinArchivoAdjunto(accion))
                {
                    MessageBox.Show("Exito al guardar Bitacora", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.limpiezaDeCampos();
                    txt_tiempoLaborado.Text = "0";
                }
                else
                {
                    MessageBox.Show("Error al guardar datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (pictureBox1.Visible == true)
            {
                objBitacora.idArchivoAdjunto = Convert.ToInt32(txt_IdArchivoAdjuntoTecnico.Text);

                if (objBitacora.insertar_Bitacora(accion))
                {
                    MessageBox.Show("Exito al guardar Bitacora", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.limpiezaDeCampos();
                    pictureBox1.Visible = false;
                    txt_tiempoLaborado.Text = "0";
                }
                else
                {
                    MessageBox.Show("Error al guardar datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            } 
        }

        //METODO VALIDACION DE CAMPOS
        //RAFAEL SEQUEIRA VARGAS
        public void limpiezaDeCampos()
        {
            Limpieza.limpiar(txt_detalleBitacora);
            Limpieza.limpiar(txt_FileName);
            Limpieza.limpiar(txt_FileExtension);
            Limpieza.limpiar(txt_IdArchivoAdjuntoTecnico);
        }

        private void txt_FileName_TextChanged(object sender, EventArgs e)
        {
            if (txt_FileName.Text == string.Empty)
            {
                btn_GuardarArchivoTecnico.Enabled = false;
            }
            else
            {
                btn_GuardarArchivoTecnico.Enabled = true;
            }
        }

        //METODO LIMITE CAMPOS
        //RAFAEL SEQUEIRA VARGAS
        public void limiteCampos()
        {
            txt_detalleBitacora.MaxLength = 600;
        }

        private void cmb_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rolUsuario == 1)//ADMINISTRADOR
            {

            }
            else if (rolUsuario == 2)//SUPERVISOR
            {
                if (Convert.ToInt32(cmb_status.SelectedValue) == 1 || Convert.ToInt32(cmb_status.SelectedValue) == 3)
                {
                    btn_aceptar.Enabled = false;
                }
                if (Convert.ToInt32(cmb_status.SelectedValue) == 4 || Convert.ToInt32(cmb_status.SelectedValue) == 5)
                {
                    if (txt_FechaAsignacion.Text == "No asignado aun")
                    {
                        btn_aceptar.Enabled = false;
                    }
                    else 
                    {
                        btn_aceptar.Enabled = true;
                    }
                }
                else if (Convert.ToInt32(cmb_status.SelectedValue) == 2)
                {
                    if (txt_FechaAsignacion.Text != "No asignado aun")
                    {
                        btn_aceptar.Enabled = false;
                    }
                    else
                    {
                        btn_aceptar.Enabled = true;
                    } 
                }
            }
            else if (rolUsuario == 3)//TECNICO
            {
                if (Convert.ToInt32(cmb_status.SelectedValue) == 1 || Convert.ToInt32(cmb_status.SelectedValue) == 2 || Convert.ToInt32(cmb_status.SelectedValue) == 4 || Convert.ToInt32(cmb_status.SelectedValue) == 5)
                {
                    btn_aceptar.Enabled = false;
                }
                else
                {
                    btn_aceptar.Enabled = true;
                }
            }
            else//NINGUNO DE LOS ANTERIORES
            { }
        }

        private void frm_Ticket_AtencionTicket_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = e.CloseReason == CloseReason.UserClosing;
        }

        private void btn_NuevaSolicitud_Click(object sender, EventArgs e)
        {
            string pantalla = "TicketAtencion";
            frm_CxC_CxP_NuevaSolicitudOrdenCompra ventana = new frm_CxC_CxP_NuevaSolicitudOrdenCompra(usuarioSistema, ticketID, pantalla);
            this.Hide();
            ventana.Show();
        }

        private void btn_VerSolicitudes_Click(object sender, EventArgs e)
        {
            string pantalla = "TicketAtencion";
            frm_CxC_CxP_ControlSolicitudOrdenDeCompra ventana = new frm_CxC_CxP_ControlSolicitudOrdenDeCompra(usuarioSistema, pantalla, ticketID);
            this.Hide();
            ventana.Show();
        }
    }
}