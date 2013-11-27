using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clases;
using System.Text.RegularExpressions;

namespace frmPrincipal
{
    public partial class frm_CxC_CxP_NuevoProveedor : Form
    {
        //DECLARACION DE INSTANCIAS DE LAS CLASES
        UsuariosSistema objUsuariosSistema = new UsuariosSistema();
        TipoIdentificacion objTipoIdentificacion = new TipoIdentificacion();
        ClienteProveedor objProveedores = new ClienteProveedor();

        //VARIABLES GLOBALES
        private string usuarioSistema = string.Empty;
        private int rolUsuario;

        public frm_CxC_CxP_NuevoProveedor()
        {
            InitializeComponent();
        }

        public frm_CxC_CxP_NuevoProveedor(string usuario) : this()
        {
            this.usuarioSistema = usuario;
        }

        private void frm_CxC_CxP_NuevoProveedor_Load(object sender, EventArgs e)
        {
            this.cargaRolUsuario();
            this.rolesUsuario();
            this.limiteCampos();
            this.cargarComboBoxTipoID();
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

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (this.validacionDeCampos() == true)
            {
                this.insertarProveedorNuevo();
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            frm_CxC_CxP_CatalogoProveedores ventana = new frm_CxC_CxP_CatalogoProveedores(usuarioSistema);

            if ((MessageBox.Show("Desea regresar al catalogo", "Volver al Catalogo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                this.Hide();
                ventana.Show();
            }
            else
            {
                return;
            }
        }

        //METODO LIMITE CAMPOS
        //RAFAEL ANGEL SEQUEIRA VARGAS
        public void limiteCampos()
        {
            txt_DireccionProveedor.MaxLength = 250;
            txt_Identificacion.MaxLength = 15;
            txt_nombreProveedor.MaxLength = 50;
            txt_telefono.MaxLength = 15;
        }

        //METODO CARGA COMBO BOX TIPO ID
        //RAFAEL ANGEL SEQUEIRA VARGAS
        private void cargarComboBoxTipoID()
        {
            try
            {
                DataSet ds;
                ds = objTipoIdentificacion.cargarTipoIdenticacion();
                cmb_TipoIdentificacion.DataSource = ds.Tables[0];
                cmb_TipoIdentificacion.DisplayMember = ds.Tables[0].Columns["descripcion"].ColumnName.ToString();
                cmb_TipoIdentificacion.ValueMember = ds.Tables[0].Columns["idTipoIdentificacion"].ColumnName.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexion a la base de datos", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //METODO CARGA COMBO BOX TIPO ID
        //RAFAEL ANGEL SEQUEIRA VARGAS
        private void insertarProveedorNuevo()
        {
            objProveedores.idTipoIdentificacion = Convert.ToInt32(cmb_TipoIdentificacion.SelectedValue);
            objProveedores.identificacion = txt_Identificacion.Text;
            objProveedores.nombre = txt_telefono.Text;
            objProveedores.direccion = txt_DireccionProveedor.Text;
            objProveedores.telefono = txt_telefono.Text;

            string accion = String.Empty;
            accion = "Insertar";

            if (objProveedores.insertarClienteProveedor(accion))
            {
                MessageBox.Show("Exito al guardar datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frm_CxC_CxP_CatalogoProveedores ventanaCatalogoProveedores = new frm_CxC_CxP_CatalogoProveedores(usuarioSistema);
                this.Hide();
                ventanaCatalogoProveedores.Show();
            }
            else
            {
                MessageBox.Show("Error al guardar datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public bool validacionDeCampos()
        {
            if (!Validaciones.validar(txt_nombreProveedor))
            {
                MessageBox.Show("No ingreso nombre de Proveedor", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nombreProveedor.Focus();
                return false;
            }
            if (!Validaciones.validar(txt_Identificacion))
            {
                MessageBox.Show("No ingreso numero de identificacion", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Identificacion.Focus();
                return false;
            }
            if (!Validaciones.validar(txt_telefono))
            {
                MessageBox.Show("No ingreso telefono proveedor", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_telefono.Focus();
                return false;
            }
            if (!Validaciones.validar(txt_DireccionProveedor))
            {
                MessageBox.Show("No ingreso Direccion del proveedor", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_DireccionProveedor.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void frm_CxC_CxP_NuevoProveedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = e.CloseReason == CloseReason.UserClosing;
        }
    }
}
