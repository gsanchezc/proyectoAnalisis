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
    public partial class frm_MantenimientoClienteProveedor : Form
    {
        //DECLARACION DE INSTANCIAS DE LAS CLASES
        UsuariosSistema objUsuariosSistema = new UsuariosSistema();
        ClienteProveedor objClienteProveedor = new ClienteProveedor();
        TipoIdentificacion objTipoId = new TipoIdentificacion();

        //VARIABLES GLOBALES
        private string usuarioSistema = string.Empty;
        private int idCliente = 0;

        public frm_MantenimientoClienteProveedor()
        {
            InitializeComponent();
        }

        public frm_MantenimientoClienteProveedor(string usuario) : this()
        {
            this.usuarioSistema = usuario;
        }

        private void frm_MantenimientoClienteProveedor_Load(object sender, EventArgs e)
        {
            this.cargarComboBoxTipoID();
            this.limiteCampos();
            this.cargarListaClienteProveedor();
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

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            this.limpiarDatos();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (this.validacionDeCampos() == true)
            {
                this.insertarClienteProveedor();
            }
        }

        private void frm_MantenimientoClienteProveedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = e.CloseReason == CloseReason.UserClosing;
        }

        //METODO
        //RAFAEL ANGEL SEQUEIRA VARGAS
        public void insertarClienteProveedor()
        {
            if (validarSoloNumeros(txt_telefono) == false)
            {
                MessageBox.Show("Ingrese Unicamente Numeros para el campo de telefono", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_telefono.Focus();
                return;
            }

            objClienteProveedor.idTipoIdentificacion = Convert.ToInt32(cmb_TipoId.SelectedValue);
            objClienteProveedor.identificacion = txt_identificacion.Text;
            objClienteProveedor.nombre = txt_NombreProveedor.Text;
            objClienteProveedor.direccion = txt_direccion.Text;
            objClienteProveedor.telefono = txt_telefono.Text;
            objClienteProveedor.isDeleted = false;

            string accion = String.Empty;
            accion = "Insertar";

            if (objClienteProveedor.insertarClienteProveedor(accion))
            {
                MessageBox.Show("Exito al guardar datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cargarListaClienteProveedor();
                this.limpiarDatos();
            }
            else
            {
                MessageBox.Show("Error al guardar datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //METODO
        //RAFAEL ANGEL SEQUEIRA VARGAS
        public void updateClienteProveedor()
        {
            if (validarSoloNumeros(txt_telefono) == false)
            {
                MessageBox.Show("Ingrese Unicamente Numeros para el campo de telefono", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_telefono.Focus();
                return;
            }

            objClienteProveedor.idProveedor = idCliente;
            objClienteProveedor.idTipoIdentificacion = Convert.ToInt32(cmb_TipoId.SelectedValue);
            objClienteProveedor.identificacion = txt_identificacion.Text;
            objClienteProveedor.nombre = txt_NombreProveedor.Text;
            objClienteProveedor.direccion = txt_direccion.Text;
            objClienteProveedor.telefono = txt_telefono.Text;
            objClienteProveedor.isDeleted = false;

            string accion = String.Empty;
            accion = "Editar";

            if (objClienteProveedor.editarClienteProveedor(accion))
            {
                MessageBox.Show("Exito al guardar datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cargarListaClienteProveedor();
                this.limpiarDatos();
            }
            else
            {
                MessageBox.Show("Error al guardar datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //METODO
        //RAFAEL ANGEL SEQUEIRA VARGAS
        public void eliminarClienteProveedor()
        {
            objClienteProveedor.idProveedor = idCliente;
            if (objClienteProveedor.eliminarClienteProveedor())
            {
                MessageBox.Show("Exito al eliminar datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cargarListaClienteProveedor();
            }
            else
            {
                MessageBox.Show("Error al eliminar datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //METODO
        //RAFAEL ANGEL SEQUEIRA VARGAS
        public bool validacionDeCampos()
        {
            if (!Validaciones.validar(txt_identificacion))
            {
                MessageBox.Show("No ingreso identificacion", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_identificacion.Focus();
                return false;
            }
            if (!Validaciones.validar(txt_NombreProveedor))
            {
                MessageBox.Show("No ingreso nombre proveedor", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_NombreProveedor.Focus();
                return false;
            }
            if (!Validaciones.validar(txt_direccion))
            {
                MessageBox.Show("No ingreso direccion", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_direccion.Focus();
                return false;
            }
            if (!Validaciones.validar(txt_telefono))
            {
                MessageBox.Show("No ingreso telefono", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public void limpiarDatos()
        {
            Limpieza.limpiar(txt_identificacion);
            Limpieza.limpiar(txt_direccion);
            Limpieza.limpiar(txt_NombreProveedor);
            Limpieza.limpiar(txt_telefono);
        }

        //METODO
        //RAFAEL ANGEL SEQUEIRA VARGAS
        public void limiteCampos()
        {
            txt_identificacion.MaxLength = 15;
            txt_NombreProveedor.MaxLength = 50;
            txt_direccion.MaxLength = 250;
            txt_telefono.MaxLength = 15;
        }

        //METODO CARGA COMBO BOX TIPO ID
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

        //METODO
        //RAFAEL ANGEL SEQUEIRA VARGAS
        private void cargarListaClienteProveedor()
        {
            try
            {
                dtg_ClienteProveedor.AutoGenerateColumns = false;
                dtg_ClienteProveedor.DataSource = objClienteProveedor.cargarDataGridProveedores().Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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

        private void dtg_ClienteProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Editar.Index && e.RowIndex >= 0)
            {
                idCliente = Convert.ToInt32(dtg_ClienteProveedor.Rows[e.RowIndex].Cells[0].Value.ToString());

                if ((MessageBox.Show("Desea editar este cliente?", "Edicion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (this.validacionDeCampos() == true)
                    {
                        this.updateClienteProveedor();
                    }
                }
                else
                {
                    return;
                }
            }
            else if (e.ColumnIndex == Eliminar.Index && e.RowIndex >= 0)
            {
                idCliente = Convert.ToInt32(dtg_ClienteProveedor.Rows[e.RowIndex].Cells[0].Value.ToString());

                if ((MessageBox.Show("Desea eliminar este cliente?", "Edicion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    this.eliminarClienteProveedor();    
                }
                else
                {
                    return;
                }                
            }
            else { }
        }
    }
}

