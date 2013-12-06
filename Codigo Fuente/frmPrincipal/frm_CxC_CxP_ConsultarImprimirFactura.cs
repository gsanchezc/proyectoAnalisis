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
            this.cargarDatosBitacoraEspecifico();
        }

        private void btn_pagoFactura_Click(object sender, EventArgs e)
        {

        }

        private void btn_imprimirFactura_Click(object sender, EventArgs e)
        {

        }

        private void frm_CxC_CxP_ConsultarImprimirFactura_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = e.CloseReason == CloseReason.UserClosing;
        }

        private void btn_Salir_Click(object sender, EventArgs e)
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

        //METODO 
        //RAFAEL ANGEL SEQUEIRA VARGAS
        public void cargarDatosBitacoraEspecifico()
        {
            txt_idFactura.Text = idFactura.ToString();
            objFacturas.cargaInfoFactura(idFactura);

            txt_nombreCliente.Text = objFacturas.nombreCliente;
            txt_telefono.Text = objFacturas.telefono;
            txt_Direccion.Text = objFacturas.direccion;
            txt_fechaFactura.Text = objFacturas.fechaFactura.Substring(0,10);
            txt_fechaDesde.Text = objFacturas.fechaDesde.Substring(0, 10);
            txt_hastaFecha.Text = objFacturas.fechahasta.Substring(0, 10);
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
        }
    }
}
