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
    public partial class frm_CxC_CxP_NuevaFactura : Form
    {
        //DECLARACION DE INSTANCIAS DE LAS CLASES
        UsuariosSistema objUsuariosSistema = new UsuariosSistema();
        clientesUsuarioFinal objClientes = new clientesUsuarioFinal();
        empresasClientes objEmpresas = new empresasClientes();
        Ticket objTicket = new Ticket();
        OrdenCompras objOrdenCompras = new OrdenCompras();
        facturas objFacturas = new facturas();

        //VARIABLES GLOBALES
        private string usuarioSistema = string.Empty;
        private string fechaDesde= string.Empty;
        private string fechaHasta = string.Empty;
        private int rolUsuario = 0;
        private int idCliente = 0;
        private int idEmpresa = 0;

        //VARIABLES GLOBALES PRECIOS
        //PRECIOS SERVICIOS
        private double precioSolicitud = 1000;
        private double precioIncidente = 2000;
        //PRECIOS PRIORIDAD
        private double precioBaja = 1000;
        private double precioMedia = 2000;
        private double precioAlta = 3000;
        private double precioUrgente = 4000;
        private double precioCritico = 5000;
        //PRECIOS PUNTUALIDAD
        private double precioAtiempo = 1000;
        //CALCULO IMPUESTO
        private double impuesto = 0.13;

        //TOTALES
        private double totalServicios;
        private double totalPrioridad;
        private double totalPuntualidad;
        private double totalOrdenesCompra;
        private double montoTicket;
        private double subTotal = 0;
        private double montoImpuesto = 0;
        private double totalFactura = 0;

        public frm_CxC_CxP_NuevaFactura()
        {
            InitializeComponent();
        }

        public frm_CxC_CxP_NuevaFactura(string usuario) :this()
        {
            this.usuarioSistema = usuario;
        }

        private void frm_CxC_CxP_NuevaFactura_Load(object sender, EventArgs e)
        {
            this.cargaRolUsuario();
            this.cargarComboBoxClientes();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Desea salir sin generar factura", "Volver al Menu Principal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
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

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            if (dtg_facturas.RowCount <= 0)
            {
                MessageBox.Show("No hay un solo ticket para esta factura", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                objFacturas.idClienteUsuarioFinal = idCliente;
                objFacturas.telefono = txt_telefono.Text;
                objFacturas.direccion = txt_Direccion.Text;
                objFacturas.fechaDesde = dtp_desde.Value.ToShortDateString();
                objFacturas.fechahasta = dtp_hasta.Value.ToShortDateString();
                objFacturas.cantidadTickets = Convert.ToInt32(txt_cantidadTickets.Text);
                objFacturas.cantidadOrdenes = Convert.ToInt32(txt_cantidadOrdenes.Text);
                objFacturas.cargoPorTipoServicio = Convert.ToDouble(txt_valorTipoServicio.Text);
                objFacturas.cargoPorPrioridad = Convert.ToDouble(txt_validarPrioridad.Text);
                objFacturas.cargoPorPuntualidad = Convert.ToDouble(txt_valorPuntualidad.Text);
                objFacturas.montoTickets = Convert.ToDouble(txt_totalTickets.Text);
                objFacturas.montoOrdenesCompra = Convert.ToDouble(txt_totalOrdenCompra.Text);
                objFacturas.subTotal = Convert.ToDouble(txt_SubTotal.Text);
                objFacturas.impuesto = Convert.ToDouble(txt_impuestos.Text);
                objFacturas.total = Convert.ToDouble(txt_total.Text);

                string accion = String.Empty;
                accion = "Insertar";

                if (objFacturas.insertar_factura(accion))
                {
                    MessageBox.Show("Exito al guardar datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frm_CxC_CxP_ControlFacturas ventana = new frm_CxC_CxP_ControlFacturas(usuarioSistema);
                    this.Hide();
                    ventana.Show();
                }
                else
                {
                    MessageBox.Show("Error al guardar datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void frm_CxC_CxP_NuevaFactura_FormClosing(object sender, FormClosingEventArgs e)
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
                this.cargarInfoClienteFactura();
                this.cargaDataGridFacturasPorCliente();
                this.cargaDataGridOrdenComprasParaFacturas();

                if (dtg_facturas.RowCount > 0)
                {
                    this.calcularDatosFactura();
                }
            }
        }

        private void btn_mostrarPorFechas_Click(object sender, EventArgs e)
        {
            fechaDesde = dtp_desde.Value.ToString();
            fechaHasta = dtp_hasta.Value.ToString();

            if (this.validarFechas() == true)
            {
                MessageBox.Show("La fecha desde no puede ser mayor a la fecha hasta", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                this.cargaDataGridFacturasPorClientePorFecha();
                this.cargaDataGridOrdenComprasParaFacturasPorFecha();
            }
        }

        //METODO
        //RAFAEL ANGEL SEQUEIRA VARGAS
        private void cargarInfoClienteFactura()
        {
            idCliente = Convert.ToInt32(cmb_cliente.SelectedValue);
            objClientes.cargaInfoCliente(idCliente);
            txt_cliente.Text = objClientes.nombre;
            txt_fechaFactura.Text = DateTime.Now.ToShortDateString();
            txt_telefono.Text = objClientes.telefonoEmpresa;
            idEmpresa = objClientes.idEmpresaCliente;

            objEmpresas.cargaInfoEmpresaCliente(idEmpresa);
            txt_Empresa.Text = objEmpresas.nombre;
            txt_Direccion.Text = objEmpresas.Direccion;
        }

        //METODO
        //RAFAEL ANGEL SEQUEIRA VARGAS
        public void cargaDataGridOrdenComprasParaFacturas()
        {
            try
            {
                dtg_OrdenesDeCompra.AutoGenerateColumns = false;
                dtg_OrdenesDeCompra.DataSource = objOrdenCompras.cargarDataGridOrdenesDeCompraParaFacturas(idCliente).Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexion a la base de datos", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //METODO
        //RAFAEL ANGEL SEQUEIRA VARGAS
        public void cargaDataGridOrdenComprasParaFacturasPorFecha()
        {
            try
            {
                dtg_OrdenesDeCompra.AutoGenerateColumns = false;
                dtg_OrdenesDeCompra.DataSource = objOrdenCompras.cargarDataGridOrdenesDeCompraParaFacturasPorFecha(idCliente, fechaDesde, fechaHasta).Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexion a la base de datos", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //METODO
        //RAFAEL ANGEL SEQUEIRA VARGAS
        public void cargaDataGridFacturasPorCliente()
        {
            try
            {
                dtg_facturas.AutoGenerateColumns = false;
                dtg_facturas.DataSource = objTicket.cargaDataGridTicketsParaFacturas(idCliente).Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexion a la base de datos", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //METODO
        //RAFAEL ANGEL SEQUEIRA VARGAS
        public void cargaDataGridFacturasPorClientePorFecha()
        {
            fechaDesde = dtp_desde.Value.ToString();
            fechaHasta = dtp_hasta.Value.ToString();

            try
            {
                dtg_facturas.AutoGenerateColumns = false;
                dtg_facturas.DataSource = objTicket.cargaDataGridTicketsParaFacturasPorFecha(idCliente, fechaDesde, fechaHasta).Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexion a la base de datos", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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

        //METODO PARA MANEJAR EL ACCESO POR ROLES
        //RAFAEL ANGEL SEQUEIRA VARGAS
        public void cargaRolUsuario()
        {
            objUsuariosSistema.cargaRolUsuario(usuarioSistema);
            rolUsuario = objUsuariosSistema.idRol;
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
        private void calcularDatosFactura()
        {
            txt_cantidadTickets.Text = dtg_facturas.RowCount.ToString();
            txt_cantidadOrdenes.Text = dtg_OrdenesDeCompra.RowCount.ToString();

            int solicitudes = 0;
            int incidentes = 0;
            int quejas = 0;

            for (int i = 0; i < Convert.ToInt32(txt_cantidadTickets.Text); i++)
            {
                if (dtg_facturas.Rows[i].Cells["idTipoServicio"].Value.ToString() == "Solicitud")
                {
                    solicitudes++;
                }
                else if(dtg_facturas.Rows[i].Cells["idTipoServicio"].Value.ToString() == "Incidente")
                {
                    incidentes++;
                }
                else if(dtg_facturas.Rows[i].Cells["idTipoServicio"].Value.ToString() == "Queja")
                {
                    quejas++;
                }
                else{}
            }

            totalServicios = (solicitudes * precioSolicitud) + (incidentes * precioIncidente);
            txt_valorTipoServicio.Text = totalServicios.ToString();

            int baja = 0;
            int media = 0;
            int alta = 0;
            int urgente = 0;
            int critico = 0;

            for (int i = 0; i < Convert.ToInt32(txt_cantidadTickets.Text); i++)
            {
                if (dtg_facturas.Rows[i].Cells["idPrioridad"].Value.ToString() == "Baja")
                {
                    baja++;
                }
                else if(dtg_facturas.Rows[i].Cells["idPrioridad"].Value.ToString() == "Media")
                {
                    media++;
                }
                else if(dtg_facturas.Rows[i].Cells["idPrioridad"].Value.ToString() == "Alta")
                {
                    alta++;
                }
                else if(dtg_facturas.Rows[i].Cells["idPrioridad"].Value.ToString() == "Urgente")
                {
                    urgente++;
                }
                else if(dtg_facturas.Rows[i].Cells["idPrioridad"].Value.ToString() == "Critico")
                {
                    critico++;
                }
                else{}
            }
            
            totalPrioridad = (baja * precioBaja) + (media * precioMedia) + (alta * precioAlta) + (urgente * precioUrgente) + (critico * precioCritico);
            txt_validarPrioridad.Text = totalPrioridad.ToString();

            int TicketATiempo = 0;
            TimeSpan ts;
            int diferenciaDias = 0;

            for (int i = 0; i < Convert.ToInt32(txt_cantidadTickets.Text); i++)
            {
                ts = Convert.ToDateTime(dtg_facturas.Rows[i].Cells["fechaEntrega"].Value) - Convert.ToDateTime(dtg_facturas.Rows[i].Cells["fechaRegistro"].Value);
                diferenciaDias = ts.Days;
                if (diferenciaDias < 5)
                {
                    TicketATiempo++;
                }
            }

            totalPuntualidad = TicketATiempo * precioAtiempo;
            txt_valorPuntualidad.Text = totalPuntualidad.ToString();

            for (int i = 0; i < Convert.ToInt32(txt_cantidadOrdenes.Text); i++)
            {
                totalOrdenesCompra += Convert.ToInt32(dtg_OrdenesDeCompra.Rows[i].Cells["monto"].Value);
            }

            txt_totalOrdenCompra.Text = totalOrdenesCompra.ToString();

            montoTicket = totalServicios + totalPrioridad + totalPuntualidad;
            txt_totalTickets.Text = montoTicket.ToString();

            subTotal = montoTicket + totalOrdenesCompra;
            txt_SubTotal.Text = subTotal.ToString();

            montoImpuesto = subTotal * impuesto;
            txt_impuestos.Text = montoImpuesto.ToString();

            totalFactura = subTotal + montoImpuesto;
            txt_total.Text = totalFactura.ToString();
        }
    }
}
