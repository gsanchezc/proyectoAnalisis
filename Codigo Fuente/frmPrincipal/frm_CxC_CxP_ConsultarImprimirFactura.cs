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
    public partial class frm_CxC_CxP_ConsultarImprimirFactura : Form
    {
        //DECLARACION DE INSTANCIAS DE LAS CLASES
        facturas objFacturas = new facturas();
        Ticket objTicket = new Ticket();
        OrdenCompras objOrden = new OrdenCompras();

        //IMPRESION
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern long BitBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);
        private Bitmap memoryImage;

        //VARIABLES GLOBALES
        private string usuarioSistema = string.Empty;
        private int idFactura = 0;

        public frm_CxC_CxP_ConsultarImprimirFactura()
        {
            InitializeComponent();
        }

        public frm_CxC_CxP_ConsultarImprimirFactura(string usuario, int idFactura) : this()
        {
            this.usuarioSistema = usuario;
            this.idFactura = idFactura;
        }

        private void frm_CxC_CxP_ConsultarImprimirFactura_Load(object sender, EventArgs e)
        {
            this.cargarDatosFactura();
            this.cargaDataGridFacturasPorCliente();
            this.cargaDataGridOrdenComprasParaFacturas();
        }

        private void btn_imprimirFactura_Click_1(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Desea imprimir esta factura?", "Impresion de Factura", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                this.CaptureScreen();
                this.printDocument1.Print();
            }
            else
            {
                return;
            }         
        }

        private void btn_pagoFactura_Click_1(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Desea cambiar el estatus de esta Factura a Pagada?", "Pago de Factura", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                objFacturas.idFactura = idFactura;
                objFacturas.actualizarEstadoPagoFactura();

                frm_CxC_CxP_ControlFacturas ventana = new frm_CxC_CxP_ControlFacturas(usuarioSistema);
                this.Hide();
                ventana.Show();
            }
            else
            {
                return;
            }
        }

        private void btn_Salir_Click_1(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Desea salir sin generar factura", "Volver al Menu Facturas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                frm_CxC_CxP_ControlFacturas ventana = new frm_CxC_CxP_ControlFacturas(usuarioSistema);
                this.Hide();
                ventana.Show();
            }
            else
            {
                return;
            }
        }

        private void frm_CxC_CxP_ConsultarImprimirFactura_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = e.CloseReason == CloseReason.UserClosing;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        //METODO
        //RAFAEL ANGEL SEQUEIRA VARGAS
        public void cargaDataGridFacturasPorCliente()
        {
            try
            {
                dtg_facturas.AutoGenerateColumns = false;
                dtg_facturas.DataSource = objTicket.cargaDataGridTicketsParaFacturasConIdFactura(idFactura).Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexion a la base de datos", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //METODO
        //RAFAEL ANGEL SEQUEIRA VARGAS
        public void cargaDataGridOrdenComprasParaFacturas()
        {
            try
            {
                dtg_OrdenesDeCompra.AutoGenerateColumns = false;
                dtg_OrdenesDeCompra.DataSource = objOrden.cargarDataGridOrdenesDeCompraParaFacturasConIdFactura(idFactura).Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexion a la base de datos", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //METODO 
        //RAFAEL ANGEL SEQUEIRA VARGAS
        public void cargarDatosFactura()
        {
            txt_idFactura.Text = idFactura.ToString();
            objFacturas.cargaInfoFactura(idFactura);

            txt_nombreCliente.Text = objFacturas.nombreCliente;
            txt_telefono.Text = objFacturas.telefono;
            txt_Direccion.Text = objFacturas.direccion;
            txt_fechaFactura.Text = objFacturas.fechaFactura;
            txt_fechaDesde.Text = objFacturas.fechaDesde;
            txt_hastaFecha.Text = objFacturas.fechahasta;
            txt_cantidadTickets.Text = objFacturas.cantidadTickets.ToString();
            txt_cantidadOrdenes.Text = objFacturas.cantidadOrdenes.ToString();
            txt_valorTipoServicio.Text = objFacturas.cargoPorTipoServicio.ToString();
            txt_validarPrioridad.Text = objFacturas.cargoPorPrioridad.ToString();
            txt_valorPuntualidad.Text = objFacturas.cargoPorPuntualidad.ToString();
            txt_totalTickets.Text = objFacturas.montoTickets.ToString();
            txt_totalOrdenCompra.Text = objFacturas.montoOrdenesCompra.ToString();
            txt_SubTotal.Text = objFacturas.subTotal.ToString();
            txt_impuestos.Text = objFacturas.impuesto.ToString();
            txt_total.Text = objFacturas.total.ToString();
            txt_Empresa.Text = objFacturas.nombreEmpresa;

            if (objFacturas.isCanceled == true)
            {
                btn_pagoFactura.Enabled = false;
            }
            else 
            {
                btn_pagoFactura.Enabled = true;
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
    }
}
