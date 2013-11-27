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
using System.Text.RegularExpressions;

namespace frmPrincipal
{
    public partial class frm_CxC_CxP_NuevaOrdenCompra : Form
    {
        //DECLARACION DE INSTANCIAS DE LAS CLASES
        UsuariosSistema objUsuariosSistema = new UsuariosSistema();
        SolicitudOrdenesCompra objSolicitud = new SolicitudOrdenesCompra();
        ClienteProveedor objProveedores = new ClienteProveedor();
        ArchivosAdjuntos objArchivosAdjuntos = new ArchivosAdjuntos();
        Ticket objTicket = new Ticket();
        OrdenCompras objOrdenCompra = new OrdenCompras();

        //VARIABLES GLOBALES
        private string usuarioSistema = string.Empty;
        private string pantalla = string.Empty;
        private int IdSolicitudCompras = 0;
        //PDF
        private string filefullpath = string.Empty;
        private string filetype = string.Empty;
        private string filename = string.Empty;
        private byte[] FileBytes = null;
        private bool isDeleted = false;

        //CONECCION
        SqlConnection sqlcon = new SqlConnection(@"Data Source=(local);Initial Catalog=db_soportic;Integrated Security=True");
        SqlCommand sqlcmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        public frm_CxC_CxP_NuevaOrdenCompra()
        {
            InitializeComponent();
        }

        public frm_CxC_CxP_NuevaOrdenCompra(string usuario, int IdSolicitud, string pantalla) : this()
        {
            this.usuarioSistema = usuario;
            this.IdSolicitudCompras = IdSolicitud;
            this.pantalla = pantalla;
        }

        private void frm_CxC_CxP_NuevaOrdenCompra_Load(object sender, EventArgs e)
        {
            pb_ArchivoAdjunto.Visible = false;
            this.cargarComboBoxProveedores();
            this.limiteCampos();

            if (pantalla == "CatalogoOrdenes")
            {
                txt_numeroTicket.ReadOnly = false;
            }
            else if (pantalla == "CatalogoSolicitudes")
            {
                this.cargaIdTicket();
            }
            else if (pantalla == "MenuPrincipal")
            {
                txt_numeroTicket.ReadOnly = false;
            }
            else{}
        }

        private void btn_cargarArchivoPDF_Click(object sender, EventArgs e)
        {
            this.cargaArchivoAdjunto();
        }

        private void btn_guardarArchivo_Click(object sender, EventArgs e)
        {
            this.guardarArchivoAdjunto();
        }

        private void btn_CrearOrden_Click(object sender, EventArgs e)
        {
            if (validacionDeCampos() == true)
            {
                this.guardarOrdenDeCompra();
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            if(pantalla == "CatalogoOrdenes")
            {
                frm_CxC_CxP_CatalogoOrdenesDeCompra ventana = new frm_CxC_CxP_CatalogoOrdenesDeCompra(usuarioSistema, pantalla);
                this.Hide();
                ventana.Show();
            }
            else if (pantalla == "CatalogoSolicitudes")
            {
                pantalla = "CatalogoSolicitudes";
                frm_CxC_CxP_ControlSolicitudOrdenDeCompra ventana = new frm_CxC_CxP_ControlSolicitudOrdenDeCompra(usuarioSistema, pantalla, IdSolicitudCompras);
                this.Hide();
                ventana.Show();      
            }
            else if (pantalla == "MenuPrincipal")
            {
                if ((MessageBox.Show("Desea regresar al Menu Principal", "Menu Principal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    frm_0MenuPrincipal ventana = new frm_0MenuPrincipal(usuarioSistema);
                    this.Hide();
                    ventana.Show();
                }
                else
                {
                    return;
                }
            }
            else { } 
        }

        private void cargaIdTicket()
        {
            objSolicitud.cargaIdTicketConIdSolicitud(IdSolicitudCompras);
            txt_numeroTicket.Text = objSolicitud.idTicket.ToString();
        }

        //METODO 
        //RAFAEL ANGEL SEQUEIRA VARGAS
        private void guardarOrdenDeCompra()
        {
            objTicket.existeTicketParaOrdenCompra(Convert.ToInt32(txt_numeroTicket.Text));
            if (objTicket.validacion == true)
            {
                objOrdenCompra.idTicket = Convert.ToInt32(txt_numeroTicket.Text);
                objOrdenCompra.idProveedor = Convert.ToInt32(cmb_proveedor.SelectedValue);
                objOrdenCompra.numeroCotizacion = Convert.ToInt32(txt_Monto.Text);
                objOrdenCompra.detalle = txt_DetalleOrdenDeCompra.Text;
                objOrdenCompra.monto = Convert.ToInt32(txt_Monto.Text);
                objOrdenCompra.idArchivoAdjunto = Convert.ToInt32(txt_IdArchivoAdjunto.Text);
                objOrdenCompra.isDeleted = false;

                string accion = String.Empty;
                accion = "Insertar";

                if (objOrdenCompra.insertar_OrdenDeCompra(accion))
                {
                    MessageBox.Show("Exito al guardar datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (pantalla == "CatalogoOrdenes")
                    {
                        frm_CxC_CxP_CatalogoOrdenesDeCompra ventana = new frm_CxC_CxP_CatalogoOrdenesDeCompra(usuarioSistema, pantalla);
                        this.Hide();
                        ventana.Show();
                    }
                    else if (pantalla == "CatalogoSolicitudes")
                    {
                        pantalla = "CatalogoSolicitudes";
                        frm_CxC_CxP_ControlSolicitudOrdenDeCompra ventana = new frm_CxC_CxP_ControlSolicitudOrdenDeCompra(usuarioSistema, pantalla, IdSolicitudCompras);
                        this.Hide();
                        ventana.Show();
                    }
                    else if (pantalla == "MenuPrincipal")
                    {
                        if ((MessageBox.Show("Desea regresar al Menu Principal", "Menu Principal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                        {
                            frm_0MenuPrincipal ventana = new frm_0MenuPrincipal(usuarioSistema);
                            this.Hide();
                            ventana.Show();
                        }
                        else
                        {
                            return;
                        }
                    }
                    else { } 
                }
                else
                {
                    MessageBox.Show("Error al guardar datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("El numero de Ticket ingresado no existe", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //METODO CARGA COMBO BOX TIPO ID
        //RAFAEL ANGEL SEQUEIRA VARGAS
        private void cargarComboBoxProveedores()
        {
            try
            {
                DataSet ds;
                ds = objProveedores.cargarDataGridProveedores();
                cmb_proveedor.DataSource = ds.Tables[0];
                cmb_proveedor.DisplayMember = ds.Tables[0].Columns["nombre"].ColumnName.ToString();
                cmb_proveedor.ValueMember = ds.Tables[0].Columns["idProveedor"].ColumnName.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexion a la base de datos", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //METODO ABRE ARCHIVO ADJUNTO
        //RAFAEL ANGEL SEQUEIRA VARGAS
        public void cargaArchivoAdjunto()
        {
            OpenFileDialog fDialog = new OpenFileDialog();
            fDialog.Title = "Seleccione un archivo para subir";
            fDialog.Filter = "PDF Files|*.pdf";

            if (fDialog.ShowDialog() == DialogResult.OK)
            {
                filefullpath = fDialog.FileName.ToString();
            }

            filename = filefullpath.Substring(Convert.ToInt32(filefullpath.LastIndexOf("\\")) + 1, filefullpath.Length - (Convert.ToInt32(filefullpath.LastIndexOf("\\")) + 1));
            filetype = filefullpath.Substring(Convert.ToInt32(filefullpath.LastIndexOf(".")) + 1, filefullpath.Length - (Convert.ToInt32(filefullpath.LastIndexOf(".")) + 1));

            if (filetype.ToUpper() != "PDF")
            {
                MessageBox.Show("Cargue solo archivos PDF");
                return;
            }

            txt_NombreArchivo.Text = filename;

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
                MessageBox.Show("Error al leer archivo " + ex.ToString());
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
            if (!Validaciones.validar(txt_numeroTicket))
            {
                MessageBox.Show("Falta Numero de Ticket", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_numeroTicket.Focus();
                return false;
            }
            if (validarSoloNumeros(txt_numeroTicket) == false)
            {
                MessageBox.Show("Ingrese Unicamente Numeros para el campo Ticket", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_numeroTicket.Focus();
                return false;
            }
            if (!Validaciones.validar(txt_numeroCotizacion))
            {
                MessageBox.Show("Falta Numero de Cotizacion", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_numeroCotizacion.Focus();
                return false;
            }
            if (validarSoloNumeros(txt_numeroCotizacion) == false)
            {
                MessageBox.Show("Ingrese Unicamente Numeros para el campo Cotizacion", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_numeroCotizacion.Focus();
                return false;
            }
            if (!Validaciones.validar(txt_Monto))
            {
                MessageBox.Show("No ha introducido monto de la Orden", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Monto.Focus();
                return false;
            }
            if (validarSoloNumeros(txt_Monto) == false)
            {
                MessageBox.Show("Ingrese Unicamente Numeros para el campo Monto", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Monto.Focus();
                return false;
            }
            if (!Validaciones.validar(txt_DetalleOrdenDeCompra))
            {
                MessageBox.Show("No ha introducido detalle de la orden", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_DetalleOrdenDeCompra.Focus();
                return false;
            }
            if (!Validaciones.validar(txt_NombreArchivo))
            {
                MessageBox.Show("No ha cargado Archivo PDF de la Cotizacion", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_NombreArchivo.Focus();
                return false;
            }
            if (!Validaciones.validar(txt_IdArchivoAdjunto))
            {
                MessageBox.Show("Debe guardar copia de la cotizacion antes de Crear la Orden de Compra", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_IdArchivoAdjunto.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        //METODO LIMITE CAMPOS
        //RAFAEL ANGEL SEQUEIRA VARGAS
        public void limiteCampos()
        {
            txt_numeroTicket.MaxLength = 10;
            txt_numeroCotizacion.MaxLength = 10;
            txt_DetalleOrdenDeCompra.MaxLength = 250;
            txt_Monto.MaxLength = 10;
        }

        private void frm_CxC_CxP_NuevaOrdenCompra_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = e.CloseReason == CloseReason.UserClosing;
        }

        private static bool validarSoloNumeros(Control mitextbox)
        {
            Regex regex = new Regex("^[0-9]*$");
            return regex.IsMatch(mitextbox.Text);
        }
    }
}
