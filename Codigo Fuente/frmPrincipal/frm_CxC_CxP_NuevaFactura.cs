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

        //VARIABLES GLOBALES
        private string usuarioSistema = string.Empty;
        private int rolUsuario = 0;
        private int idCliente = 0;
        private int idEmpresa = 0;

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
            this.rolesUsuario();
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

        //METODO PARA MANEJAR EL ACCESO POR ROLES
        //RAFAEL ANGEL SEQUEIRA VARGAS
        public void rolesUsuario()
        {

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
            }
        }
    }
}
