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
    public partial class frm_Ticket_NuevoTicket : Form
    {
        //DECLARACION DE INSTANCIAS DE LAS CLASES
        UsuariosSistema objUsuariosSistema = new UsuariosSistema();
        ClienteProveedor objClienteProveedor = new ClienteProveedor();
        DescripcionDepartamento objDepartamento = new DescripcionDepartamento();
        tipoServicio objTipoServicio = new tipoServicio();
        ArchivosAdjuntos objArchivosAdjuntos = new ArchivosAdjuntos();
        Ticket objTicket = new Ticket();
        clientesUsuarioFinal objClientesUsuarioFinal = new clientesUsuarioFinal();

        //VARIABLES GLOBALES
        private string usuarioSistema = string.Empty;
        private string filefullpath = string.Empty;
        private string filetype = string.Empty;
        private string filename = string.Empty;
        private byte[] FileBytes = null;
        private bool isDeleted = false;
        private int idClienteUsuarioFinal = 0;

        //CONECCION
        SqlConnection sqlcon = new SqlConnection(@"Data Source=(local);Initial Catalog=db_soportic;Integrated Security=True");
        SqlCommand sqlcmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        public frm_Ticket_NuevoTicket()
        {
            InitializeComponent();
        }

        public frm_Ticket_NuevoTicket(string usuario) : this()
        {
            this.usuarioSistema = usuario;
        }

        private void frm_Ticket_NuevoTicket_Load(object sender, EventArgs e)
        {
            txt_nombreUsuario.Text = usuarioSistema;
            this.cargarComboBoxDepartamentos();
            this.cargarComboBoxTipoServicio();
            pb_ArchivoAdjunto.Visible = false;
            this.limiteCampos();

            objClientesUsuarioFinal.cargaIdUsuarioSistemaPorNombreDeUsuario(usuarioSistema);
            idClienteUsuarioFinal = objClientesUsuarioFinal.idClienteUsuarioFinal;
            txt_NumeroUsuario.Text = idClienteUsuarioFinal.ToString();
            btn_guardarArchivo.Enabled = false;
        }

        private void frm_Ticket_NuevoTicket_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = e.CloseReason == CloseReason.UserClosing;
        }

        private void btn_cargarArchivoPDF_Click(object sender, EventArgs e)
        {
            this.cargaArchivoAdjunto();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (validacionDeCampos() == true)
            {
                this.guardarTicket();
            }
        }

        private void btn_guardarArchivo_Click(object sender, EventArgs e)
        {
            this.guardarArchivoAdjunto();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Desea salir sin generar nuevo Ticket", "Volver al Menu Principal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
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

        //METODO CARGA ARCHIVO ADJUNTO
        //RAFAEL ANGEL SEQUEIRA VARGAS
        public void guardarTicket()
        {
            objTicket.idClienteUsuarioFinal = Convert.ToInt32(txt_NumeroUsuario.Text);
            objTicket.idDepartamento = Convert.ToInt32(cmb_TipoTicket.SelectedValue);
            objTicket.titulo = txt_tema.Text;
            objTicket.idTipoServicio = Convert.ToInt32(cmb_tipoServicio.SelectedValue);
            objTicket.descripcion = txt_Descripcion.Text;
            
            objTicket.fechaRegistro = DateTime.Now.Date.ToString();
            objTicket.idEstatusTickets = 1;
            objTicket.idPrioridad = 1;
            objTicket.isDeleted = false;

            string accion = String.Empty;
            accion = "Insertar";

            if (txt_FileName.Text == string.Empty && txt_FileExtension.Text == string.Empty)
            {
                if (objTicket.insertar_ticketSinArchivoAdjunto(accion))
                {
                    MessageBox.Show("Exito al guardar datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    frm_0MenuPrincipal ventanaMenuPrincipal = new frm_0MenuPrincipal(usuarioSistema);
                    this.Hide();
                    ventanaMenuPrincipal.Show();
                }
                else
                {
                    MessageBox.Show("Error al guardar datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                objTicket.idArchivoAdjunto = Convert.ToInt32(txt_IdArchivoAdjunto.Text);

                if (objTicket.insertar_ticket(accion))
                {
                    MessageBox.Show("Exito al guardar datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    frm_0MenuPrincipal ventanaMenuPrincipal = new frm_0MenuPrincipal(usuarioSistema);
                    this.Hide();
                    ventanaMenuPrincipal.Show();
                }
                else
                {
                    MessageBox.Show("Error al guardar datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
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

                MessageBox.Show("Archivo almacenado","Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pb_ArchivoAdjunto.Visible = true;

                objArchivosAdjuntos.cargaIDArchivoAdjuntoRecienGuardado();
                txt_IdArchivoAdjunto.Text = objArchivosAdjuntos.idArchivoAdjunto.ToString(); ;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo almacenar archivo " + ex.ToString(), "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //METODO VALIDACION DE DATOS
        //RAFAEL ANGEL SEQUEIRA VARGAS
        public bool validacionDeCampos()
        {
            if (!Validaciones.validar(txt_nombreUsuario))
            {
                MessageBox.Show("No se cargo ningun nombre de usuario", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nombreUsuario.Focus();
                return false;
            }
            if (!Validaciones.validar(txt_NumeroUsuario))
            {
                MessageBox.Show("No se cargo numero usuario", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_NumeroUsuario.Focus();
                return false;
            }
            if (!Validaciones.validar(txt_tema))
            {
                MessageBox.Show("No ingreso tema del Ticket", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_tema.Focus();
                return false;
            }
            if (!Validaciones.validar(txt_Descripcion))
            {
                MessageBox.Show("No ingreso detalle del Ticket", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Descripcion.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        //METODO CARGA COMBO BOX DEPARTAMENTOS
        //RAFAEL ANGEL SEQUEIRA VARGAS
        private void cargarComboBoxDepartamentos()
        {
            try
            {
                DataSet ds;
                ds = objDepartamento.cargarDescripcionDepartamentos();
                cmb_TipoTicket.DataSource = ds.Tables[0];
                cmb_TipoTicket.DisplayMember = ds.Tables[0].Columns["descripcion"].ColumnName.ToString();
                cmb_TipoTicket.ValueMember = ds.Tables[0].Columns["idDepartamento"].ColumnName.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexion a la base de datos", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //METODO CARGA COMBO BOX TIPO SERVICIO
        //RAFAEL ANGEL SEQUEIRA VARGAS
        private void cargarComboBoxTipoServicio()
        {
            try
            {
                DataSet ds;
                ds = objTipoServicio.cargaListaTipoPuesto();
                cmb_tipoServicio.DataSource = ds.Tables[0];
                cmb_tipoServicio.DisplayMember = ds.Tables[0].Columns["descripcion"].ColumnName.ToString();
                cmb_tipoServicio.ValueMember = ds.Tables[0].Columns["idtipoServicio"].ColumnName.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexion a la base de datos", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //METODO LIMITE CAMPOS
        //RAFAEL ANGEL SEQUEIRA VARGAS
        public void limiteCampos()
        {
            txt_tema.MaxLength = 200;
            txt_Descripcion.MaxLength = 600;
        }

        private void txt_FileName_TextChanged(object sender, EventArgs e)
        {
            if (txt_FileName.Text == string.Empty)
            {
                btn_guardarArchivo.Enabled = false;
            }
            else
            {
                btn_guardarArchivo.Enabled = true;
            }
        }
    }
}
