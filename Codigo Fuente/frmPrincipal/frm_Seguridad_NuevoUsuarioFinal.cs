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
    public partial class frm_Seguridad_NuevoUsuarioFinal : Form
    {
        //DECLARACION DE INSTANCIAS DE LAS CLASES
        UsuariosSistema objUsuariosSistema = new UsuariosSistema();
        ClienteProveedor objClienteProveedor = new ClienteProveedor();
        TipoIdentificacion objTipoIdentificacion = new TipoIdentificacion();
        empresasClientes objEmpresasClientes = new empresasClientes();
        clientesUsuarioFinal objClienteUsuarioFinal = new clientesUsuarioFinal();

        //VARIABLES GLOBALES
        private string usuarioSistema = string.Empty;

        public frm_Seguridad_NuevoUsuarioFinal()
        {
            InitializeComponent();
        }

        public frm_Seguridad_NuevoUsuarioFinal(string usuario) : this()
        {
            this.usuarioSistema = usuario;
        }

        private void frm_Seguridad_NuevoUsuarioFinal_Load(object sender, EventArgs e)
        {
            this.limiteCampos();
            this.cargarComboBoxTipoID();
            this.cargarComboBoxEmpresasClientes();
        }

        //METODO CARGA COMBO BOX TIPO ID
        //RAFAEL ANGEL SEQUEIRA VARGAS
        private void cargarComboBoxTipoID()
        {
            try
            {
                DataSet ds;
                ds = objTipoIdentificacion.cargarTipoIdenticacion();
                cb_tipoIdentificacion.DataSource = ds.Tables[0];
                cb_tipoIdentificacion.DisplayMember = ds.Tables[0].Columns["descripcion"].ColumnName.ToString();
                cb_tipoIdentificacion.ValueMember = ds.Tables[0].Columns["idTipoIdentificacion"].ColumnName.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexion a la base de datos", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //METODO CARGA COMBO BOX EMPRESASCLIENTES
        //RAFAEL ANGEL SEQUEIRA VARGAS
        private void cargarComboBoxEmpresasClientes()
        {
            try
            {
                DataSet ds;
                ds = objEmpresasClientes.cargarComboBoxEmpresasClientes();
                cb_empresaCliente.DataSource = ds.Tables[0];
                cb_empresaCliente.DisplayMember = ds.Tables[0].Columns["nombre"].ColumnName.ToString();
                cb_empresaCliente.ValueMember = ds.Tables[0].Columns["idEmpresaCliente"].ColumnName.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexion a la base de datos", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Desea salir sin generar nuevo Usuario", "Volver al Menu Principal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
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

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (this.validacionDeCampos() == true)
            {
                this.insertarNuevoUsuarioFinal();  
            }  
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Limpieza.limpiar(txt_Nombre);
            Limpieza.limpiar(txt_Apellido);
            Limpieza.limpiar(txt_identificacion);
            Limpieza.limpiar(txt_telefonoEmpresa);
        }

        public bool validacionDeCampos()
        {
            if (!Validaciones.validar(txt_Nombre))
            {
                MessageBox.Show("No ingreso nombre", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Nombre.Focus();
                return false;
            }
            if (!Validaciones.validar(txt_Apellido))
            {
                MessageBox.Show("No ingreso apellidos", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Apellido.Focus();
                return false;
            }
            if (!Validaciones.validar(txt_identificacion))
            {
                MessageBox.Show("No ingreso identificacion", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_identificacion.Focus();
                return false;
            }
            if (!Validaciones.validar(txt_telefonoEmpresa))
            {
                MessageBox.Show("No ingreso telefono empresa", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_telefonoEmpresa.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        public void insertarNuevoUsuarioFinal()
        {
            if (validarSoloLetras(txt_Nombre) == false)
            {
                MessageBox.Show("Ingrese Unicamente Letras para el campo de Nombre", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Nombre.Focus();
                return;
            }
            if (validarSoloLetrasConEspacios(txt_Apellido) == false)
            {
                MessageBox.Show("Ingrese Unicamente Letras para el campo de Apellidos", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Apellido.Focus();
                return;
            }
            if (validarSoloLetrasYNumeros(txt_identificacion) == false)
            {
                MessageBox.Show("Ingrese Unicamente Letras para el campo de Identificacion", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Apellido.Focus();
                return;
            }
            if (validarSoloNumeros(txt_telefonoEmpresa) == false)
            {
                MessageBox.Show("Ingrese Unicamente Numeros para el campo de telefono", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_telefonoEmpresa.Focus();
                return;
            }

            objClienteUsuarioFinal.nombre = Convert.ToString(txt_Nombre.Text);
            objClienteUsuarioFinal.apellidos = Convert.ToString(txt_Apellido.Text);
            objClienteUsuarioFinal.idTipoIdentificacion = Convert.ToInt32(cb_tipoIdentificacion.SelectedValue);
            objClienteUsuarioFinal.identificacion = Convert.ToString(txt_identificacion.Text);
            objClienteUsuarioFinal.telefonoEmpresa = Convert.ToString(txt_telefonoEmpresa.Text);
            objClienteUsuarioFinal.idEmpresaCliente = Convert.ToInt32(cb_empresaCliente.SelectedValue);
            objClienteUsuarioFinal.isdeleted = false;

            string accion = String.Empty;
            accion = "Insertar";

            if (objClienteUsuarioFinal.insertar_usuariosSistema(accion))
            {
                MessageBox.Show("Exito al guardar datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.limpiarCajasDeTexto();
            }
            else
            {
                MessageBox.Show("Error al guardar datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void limpiarCajasDeTexto()
        {
            Limpieza.limpiar(txt_Nombre);
            Limpieza.limpiar(txt_Apellido);
            Limpieza.limpiar(txt_identificacion);
            Limpieza.limpiar(txt_telefonoEmpresa);
        }

        private static bool validarSoloNumeros(Control mitextbox)
        {
            Regex regex = new Regex("^[0-9]*$");
            return regex.IsMatch(mitextbox.Text);
        }

        private static bool validarSoloLetras(Control mitextbox)
        {
            Regex regex = new Regex("^[a-zA-Z]+$");
            return regex.IsMatch(mitextbox.Text);
        }

        private static bool validarSoloLetrasConEspacios(Control mitextbox)
        {
            Regex regex = new Regex("^[a-zA-Z ]+$");
            return regex.IsMatch(mitextbox.Text);
        }

        private static bool validarSoloLetrasYNumeros(Control mitextbox)
        {
            Regex regex = new Regex("^[a-zA-Z0-9]+$");
            return regex.IsMatch(mitextbox.Text);
        }

        private void frm_Seguridad_NuevoUsuarioFinal_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = e.CloseReason == CloseReason.UserClosing;
        }

        public void limiteCampos()
        {
            txt_Nombre.MaxLength = 50;
            txt_Apellido.MaxLength = 50;
            txt_identificacion.MaxLength = 15;
            txt_telefonoEmpresa.MaxLength = 8;
        }
    }
}
