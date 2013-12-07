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
    public partial class frm_CxC_CxP_EnvioEstadosCuenta : Form
    {
        //DECLARACION DE INSTANCIAS DE LAS CLASES
        UsuariosSistema objUsuariosSistema = new UsuariosSistema();
        clientesUsuarioFinal objClientes = new clientesUsuarioFinal();
        empresasClientes objEmpresas = new empresasClientes();
        facturas objFacturas = new facturas();

        //IMPRESION
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern long BitBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);
        private Bitmap memoryImage;

        //VARIABLES GLOBALES
        private string usuarioSistema = string.Empty;
        private int idCliente = 0;
        private string fechaDesde = string.Empty;
        private string fechaHasta = string.Empty;

        public frm_CxC_CxP_EnvioEstadosCuenta()
        {
            InitializeComponent();
        }

        public frm_CxC_CxP_EnvioEstadosCuenta(string usuario) : this()
        {
            this.usuarioSistema = usuario;
        }

        private void frm_CxC_CxP_EnvioEstadosCuenta_Load(object sender, EventArgs e)
        {
            btn_mostrarPorFechas.Enabled = false;
            this.cargarComboBoxClientes();
        }

        private void frm_CxC_CxP_EnvioEstadosCuenta_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = e.CloseReason == CloseReason.UserClosing;
        }

        private void cmb_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (!cb.Focused)
            {
                return;
            }
            else
            {
                this.cargarInfoClienteEstadoDeCuenta();
                btn_mostrarPorFechas.Enabled = true;
            }           
        }

        private void dtp_desde_ValueChanged(object sender, EventArgs e)
        {
            fechaDesde = dtp_desde.Value.ToString();
            txt_fechaDesde.Text = fechaDesde;
        }

        private void dtp_hasta_ValueChanged(object sender, EventArgs e)
        {
            fechaHasta = dtp_hasta.Value.ToString();
            txt_hastaFecha.Text = fechaHasta;
        }

        private void btn_mostrarPorFechas_Click(object sender, EventArgs e)
        {
            if (this.validacionDeCampos() == false)
            {

            }
            else 
            {
                if (this.validarFechas() == true)
                {
                    MessageBox.Show("La fecha desde no puede ser mayor a la fecha hasta", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    this.cargaDataGridEstadoDeCuenta();

                    if (dtg_EstadoCuenta.RowCount > 0)
                    {
                        this.cargaMontoEstadoDeCuenta();
                    }
                }
            }
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Desea imprimir el estado de cuenta?", "Impresion de Factura", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                this.CaptureScreen();
                this.printDocument1.Print();
            }
            else
            {
                return;
            }  
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Desea volver al Menu", "Volver al Menu Principal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
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

        //METODO VALIDACION DE DATOS
        //RAFAEL ANGEL SEQUEIRA VARGAS
        public bool validacionDeCampos()
        {
            if (!Validaciones.validar(txt_nombreCliente))
            {
                MessageBox.Show("Debe seleccionar un cliente del comboBox", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nombreCliente.Focus();
                return false;
            }
            if (!Validaciones.validar(txt_fechaDesde))
            {
                MessageBox.Show("Debe elegir un rango de fechas", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_fechaDesde.Focus();
                return false;
            }
            if (!Validaciones.validar(txt_hastaFecha))
            {
                MessageBox.Show("Debe elegir un rango de fechas", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_hastaFecha.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        //METODO
        //RAFAEL ANGEL SEQUEIRA VARGAS
        public void cargaMontoEstadoDeCuenta()
        {
            try
            {
                DataSet ds;
                ds = objFacturas.cargaMontoEstadoDeCuenta(idCliente, fechaDesde, fechaHasta);
                txt_montoEstadoDeCuenta.Text = ds.Tables[0].Rows[0]["MontoTotal"].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexion a la base de datos", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //METODO
        //RAFAEL ANGEL SEQUEIRA VARGAS
        public void cargaDataGridEstadoDeCuenta()
        {
            try
            {
                dtg_EstadoCuenta.AutoGenerateColumns = false;
                dtg_EstadoCuenta.DataSource = objFacturas.cargaFacturasParaEstadosDeCuenta(idCliente, fechaDesde, fechaHasta).Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexion a la base de datos", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //METODO
        //RAFAEL ANGEL SEQUEIRA VARGAS
        private bool validarFechas()
        {
            int resultado = 0;
            resultado = DateTime.Compare(dtp_desde.Value.Date, dtp_hasta.Value.Date);
            if (resultado > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //METODO
        //RAFAEL ANGEL SEQUEIRA VARGAS
        private void cargarInfoClienteEstadoDeCuenta()
        {
            idCliente = Convert.ToInt32(cmb_cliente.SelectedValue);
            objClientes.cargaInfoCliente(idCliente);
            txt_nombreCliente.Text = objClientes.nombre;
            txt_telefono.Text = objClientes.telefonoEmpresa;
            int idEmpresa = objClientes.idEmpresaCliente;

            objEmpresas.cargaInfoEmpresaCliente(idEmpresa);
            txt_Empresa.Text = objEmpresas.nombre;
            txt_Direccion.Text = objEmpresas.Direccion;

            txt_fechaEstadoCuenta.Text = DateTime.Now.ToShortDateString();
        }

        //METODO CARGA COMBO BOX CLIENTES
        //RAFAEL ANGEL SEQUEIRA VARGAS
        private void cargarComboBoxClientes()
        {
            try
            {
                DataSet ds;
                ds = objClientes.cargarListaClientesUsuarioFinal();
                cmb_cliente.DataSource = ds.Tables[0];
                cmb_cliente.DisplayMember = ds.Tables[0].Columns["nombre"].ColumnName.ToString();
                cmb_cliente.ValueMember = ds.Tables[0].Columns["idClienteUsuarioFinal"].ColumnName.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexion a la base de datos", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //METODO 
        //RAFAEL ANGEL SEQUEIRA VARGAS
        private void CaptureScreen()
        {
            Graphics mygraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, mygraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            IntPtr dc1 = mygraphics.GetHdc();
            IntPtr dc2 = memoryGraphics.GetHdc();
            BitBlt(dc2, 0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height, dc1, 0, 0, 13369376);
            mygraphics.ReleaseHdc(dc1);
            memoryGraphics.ReleaseHdc(dc2);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }
    }
}
