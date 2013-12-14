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
    public partial class frm_MantenimientoClienteUsuarioFinal : Form
    {
        //DECLARACION DE INSTANCIAS DE LAS CLASES
        UsuariosSistema objUsuariosSistema = new UsuariosSistema();
        TipoIdentificacion objTipoId = new TipoIdentificacion();
        clientesUsuarioFinal objClientes = new clientesUsuarioFinal();
        empresasClientes objEmpresas = new empresasClientes();

        //VARIABLES GLOBALES
        private string usuarioSistema = string.Empty;
        private int idCliente = 0;

        public frm_MantenimientoClienteUsuarioFinal()
        {
            InitializeComponent();
        }

        public frm_MantenimientoClienteUsuarioFinal(string usuario) : this()
        {
            this.usuarioSistema = usuario;
        }

        private void frm_MantenimientoClienteUsuarioFinal_Load(object sender, EventArgs e)
        {
            this.limiteCampos();
            this.cargarComboBoxEmpresasClientes();
            this.cargarComboBoxTipoID();
            this.cargarComboBoxUsuarioSistema();
            this.cargarListaClientes();
        }

        private void frm_MantenimientoClienteUsuarioFinal_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = e.CloseReason == CloseReason.UserClosing;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (this.validacionDeCampos() == true)
            {
                this.insertarClienteUsuarioFinal();
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            this.limpiarDatos();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            frm_Mantenimiento_0Menu ventana = new frm_Mantenimiento_0Menu(usuarioSistema);
            if ((MessageBox.Show("Desea regresar al menu principal", "Volver al Menu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                this.Hide();
                ventana.Show();
            }
            else
            {
                return;
            }
        }

        private void dtg_ClienteUsuarioFinal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Editar.Index && e.RowIndex >= 0)
            {
                idCliente = Convert.ToInt32(dtg_ClienteUsuarioFinal.Rows[e.RowIndex].Cells[0].Value.ToString());

                if ((MessageBox.Show("Desea editar este cliente?", "Edicion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (this.validacionDeCampos() == true)
                    {
                        this.updateClienteUsuarioFinal();
                    }
                }
                else
                {
                    return;
                }
            }
            else if (e.ColumnIndex == Eliminar.Index && e.RowIndex >= 0)
            {
                idCliente = Convert.ToInt32(dtg_ClienteUsuarioFinal.Rows[e.RowIndex].Cells[0].Value.ToString());

                if ((MessageBox.Show("Desea eliminar este cliente?", "Edicion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    this.eliminarClienteUsuarioFinal();
                }
                else
                {
                    return;
                }
            }
            else { }
        }

        //METODO
        //RAFAEL ANGEL SEQUEIRA VARGAS
        private void insertarClienteUsuarioFinal()
        {
            if (validarSoloLetras(txt_Nombre_Cliente) == false)
            {
                MessageBox.Show("Ingrese Unicamente Letras para el campo de Nombre", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Nombre_Cliente.Focus();
                return;
            }
            if (validarSoloLetrasConEspacios(txt_apellido) == false)
            {
                MessageBox.Show("Ingrese Unicamente Letras para el campo de Apellidos", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_apellido.Focus();
                return;
            }
            if (validarSoloLetrasYNumeros(txt_identificacion) == false)
            {
                MessageBox.Show("Ingrese Unicamente Letras para el campo de Identificacion", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_identificacion.Focus();
                return;
            }
            if (validarSoloNumeros(txt_telefono) == false)
            {
                MessageBox.Show("Ingrese Unicamente Numeros para el campo de telefono", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_telefono.Focus();
                return;
            }

            objClientes.idClienteUsuarioFinal = idCliente;
            objClientes.idUsuarioSistema = Convert.ToInt32(cmb_idUsuarioSistema.SelectedValue);
            objClientes.nombre = txt_Nombre_Cliente.Text;
            objClientes.apellidos = txt_apellido.Text;
            objClientes.idTipoIdentificacion = Convert.ToInt32(cmb_TipoId.SelectedValue);
            objClientes.identificacion = txt_identificacion.Text;
            objClientes.telefonoEmpresa = txt_telefono.Text;
            objClientes.idEmpresaCliente = Convert.ToInt32(cmb_nombreEmpresa.SelectedValue);
            objClientes.isdeleted = false;

            string accion = String.Empty;
            accion = "Insertar";

            if (objClientes.insertar_usuariosSistemaMantenimientos(accion))
            {
                MessageBox.Show("Exito al guardar datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.limpiarDatos();
                this.cargarListaClientes();
            }
            else
            {
                MessageBox.Show("Error al guardar datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //METODO
        //RAFAEL ANGEL SEQUEIRA VARGAS
        private bool validacionDeCampos()
        {
            if (!Validaciones.validar(txt_Nombre_Cliente))
            {
                MessageBox.Show("No ingreso nombre", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Nombre_Cliente.Focus();
                return false;
            }
            if (!Validaciones.validar(txt_apellido))
            {
                MessageBox.Show("No ingreso apellidos", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_apellido.Focus();
                return false;
            }
            if (!Validaciones.validar(txt_identificacion))
            {
                MessageBox.Show("No ingreso identificacion", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_identificacion.Focus();
                return false;
            }
            if (!Validaciones.validar(txt_telefono))
            {
                MessageBox.Show("No ingreso telefono empresa", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_telefono.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        //METODO
        //RAFAEL ANGEL SEQUEIRA VARGAS
        private void cargarListaClientes()
        {
            try
            {
                dtg_ClienteUsuarioFinal.AutoGenerateColumns = false;
                dtg_ClienteUsuarioFinal.DataSource = objClientes.cargarListaClientesUsuarioFinalCompleto().Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //METODO
        //RAFAEL ANGEL SEQUEIRA VARGAS
        private void updateClienteUsuarioFinal()
        {
            if (validarSoloLetras(txt_Nombre_Cliente) == false)
            {
                MessageBox.Show("Ingrese Unicamente Letras para el campo de Nombre", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Nombre_Cliente.Focus();
                return;
            }
            if (validarSoloLetrasConEspacios(txt_apellido) == false)
            {
                MessageBox.Show("Ingrese Unicamente Letras para el campo de Apellidos", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_apellido.Focus();
                return;
            }
            if (validarSoloLetrasYNumeros(txt_identificacion) == false)
            {
                MessageBox.Show("Ingrese Unicamente Letras para el campo de Identificacion", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_identificacion.Focus();
                return;
            }
            if (validarSoloNumeros(txt_telefono) == false)
            {
                MessageBox.Show("Ingrese Unicamente Numeros para el campo de telefono", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_telefono.Focus();
                return;
            }

            objClientes.idClienteUsuarioFinal = idCliente;
            objClientes.idUsuarioSistema = Convert.ToInt32(cmb_idUsuarioSistema.SelectedValue);
            objClientes.nombre = txt_Nombre_Cliente.Text;
            objClientes.apellidos = txt_apellido.Text;
            objClientes.idTipoIdentificacion = Convert.ToInt32(cmb_TipoId.SelectedValue);
            objClientes.identificacion = txt_identificacion.Text;
            objClientes.telefonoEmpresa = txt_telefono.Text;
            objClientes.idEmpresaCliente = Convert.ToInt32(cmb_nombreEmpresa.SelectedValue);
            objClientes.isdeleted = false;

            string accion = String.Empty;
            accion = "Editar";

            if (objClientes.insertar_usuariosSistemaMantenimientos(accion))
            {
                MessageBox.Show("Exito al guardar datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.limpiarDatos();
                this.cargarListaClientes();
            }
            else
            {
                MessageBox.Show("Error al guardar datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //METODO
        //RAFAEL ANGEL SEQUEIRA VARGAS
        private void eliminarClienteUsuarioFinal()
        {
            objClientes.idClienteUsuarioFinal = idCliente;
            if (objClientes.eliminarClienteUsuarioFinal())
            {
                MessageBox.Show("Exito al eliminar datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cargarListaClientes();
            }
            else
            {
                MessageBox.Show("Error al eliminar datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //METODO
        //RAFAEL ANGEL SEQUEIRA VARGAS
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

        //METODO
        //RAFAEL ANGEL SEQUEIRA VARGAS
        public void limpiarDatos()
        {
            Limpieza.limpiar(txt_apellido);
            Limpieza.limpiar(txt_identificacion);
            Limpieza.limpiar(txt_Nombre_Cliente);
            Limpieza.limpiar(txt_telefono);
        }

        //METODO
        //RAFAEL ANGEL SEQUEIRA VARGAS
        public void limiteCampos()
        {
            txt_identificacion.MaxLength = 15;
            txt_Nombre_Cliente.MaxLength = 50;
            txt_apellido.MaxLength = 50;
            txt_telefono.MaxLength = 15;
        }

        //METODO CARGA COMBO BOX
        //RAFAEL ANGEL SEQUEIRA VARGAS
        private void cargarComboBoxTipoID()
        {
            try
            {
                DataSet ds;
                ds = objTipoId.cargarTipoIdenticacion();
                cmb_TipoId.DataSource = ds.Tables[0];
                cmb_TipoId.DisplayMember = ds.Tables[0].Columns["descripcion"].ColumnName.ToString();
                cmb_TipoId.ValueMember = ds.Tables[0].Columns["idTipoIdentificacion"].ColumnName.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexion a la base de datos", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //METODO CARGA COMBO BOX
        //RAFAEL ANGEL SEQUEIRA VARGAS
        private void cargarComboBoxEmpresasClientes()
        {
            try
            {
                DataSet ds;
                ds = objEmpresas.cargarComboBoxEmpresasClientes();
                cmb_nombreEmpresa.DataSource = ds.Tables[0];
                cmb_nombreEmpresa.DisplayMember = ds.Tables[0].Columns["nombre"].ColumnName.ToString();
                cmb_nombreEmpresa.ValueMember = ds.Tables[0].Columns["idEmpresaCliente"].ColumnName.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexion a la base de datos", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //METODO CARGA COMBO BOX
        //RAFAEL ANGEL SEQUEIRA VARGAS
        private void cargarComboBoxUsuarioSistema()
        {
            try
            {
                DataSet ds;
                ds = objUsuariosSistema.cargalistaUsuariosSistema();
                cmb_idUsuarioSistema.DataSource = ds.Tables[0];
                cmb_idUsuarioSistema.DisplayMember = ds.Tables[0].Columns["nombreUsuarioSistema"].ColumnName.ToString();
                cmb_idUsuarioSistema.ValueMember = ds.Tables[0].Columns["idUsuarioSistema"].ColumnName.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexion a la base de datos", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
