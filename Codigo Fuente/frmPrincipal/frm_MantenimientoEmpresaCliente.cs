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
    public partial class frm_MantenimientoEmpresaCliente : Form
    {
        //DECLARACION DE INSTANCIAS DE LAS CLASES
        UsuariosSistema objUsuariosSistema = new UsuariosSistema();
        empresasClientes objEmpresas = new empresasClientes();
        TipoIdentificacion objTipoId = new TipoIdentificacion();

        //VARIABLES GLOBALES
        private string usuarioSistema = string.Empty;
        private int idCliente = 0;

        public frm_MantenimientoEmpresaCliente()
        {
            InitializeComponent();
        }

        public frm_MantenimientoEmpresaCliente(string usuario) : this()
        {
            this.usuarioSistema = usuario;
        }

        private void frm_MantenimientoEmpresaCliente_Load(object sender, EventArgs e)
        {
            this.cargarComboBoxTipoID();
            this.limiteCampos();
            this.cargarListaEmpresaCliente();
        }

        private void frm_MantenimientoEmpresaCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = e.CloseReason == CloseReason.UserClosing;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (this.validacionDeCampos() == true)
            {
                this.insertarEmpresaCliente();
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

        private void dtg_empresasClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Editar.Index && e.RowIndex >= 0)
            {
                idCliente = Convert.ToInt32(dtg_empresasClientes.Rows[e.RowIndex].Cells[0].Value.ToString());

                if ((MessageBox.Show("Desea editar este cliente?", "Edicion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (this.validacionDeCampos() == true)
                    {
                        this.updateEmpresaCliente();
                    }
                }
                else
                {
                    return;
                }
            }
            else if (e.ColumnIndex == Eliminar.Index && e.RowIndex >= 0)
            {
                idCliente = Convert.ToInt32(dtg_empresasClientes.Rows[e.RowIndex].Cells[0].Value.ToString());

                if ((MessageBox.Show("Desea eliminar este cliente?", "Edicion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    this.eliminarEmpresaCliente();
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
            Limpieza.limpiar(txt_identificacion);
            Limpieza.limpiar(txt_direccion);
            Limpieza.limpiar(txt_nombre);
            Limpieza.limpiar(txt_telefono);
        }

        //METODO
        //RAFAEL ANGEL SEQUEIRA VARGAS
        public void limiteCampos()
        {
            txt_identificacion.MaxLength = 15;
            txt_nombre.MaxLength = 50;
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
        public void insertarEmpresaCliente()
        {
            if (validarSoloNumeros(txt_telefono) == false)
            {
                MessageBox.Show("Ingrese Unicamente Numeros para el campo de telefono", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_telefono.Focus();
                return;
            }

            objEmpresas.idEmpresaCliente = idCliente;
            objEmpresas.nombre = txt_nombre.Text;
            objEmpresas.idTipoIdentificacion = Convert.ToInt32(cmb_TipoId.SelectedValue);
            objEmpresas.identificacion = txt_identificacion.Text;
            objEmpresas.telefonoEmpresa = txt_telefono.Text;
            objEmpresas.isDeleted = false;
            objEmpresas.Direccion = txt_direccion.Text;

            string accion = String.Empty;
            accion = "Insertar";

            if (objEmpresas.insertarEmpresaCliente(accion))
            {
                MessageBox.Show("Exito al guardar datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cargarListaEmpresaCliente();
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
        public void updateEmpresaCliente()
        {
            if (validarSoloNumeros(txt_telefono) == false)
            {
                MessageBox.Show("Ingrese Unicamente Numeros para el campo de telefono", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_telefono.Focus();
                return;
            }

            objEmpresas.idEmpresaCliente = idCliente;
            objEmpresas.nombre = txt_nombre.Text;
            objEmpresas.idTipoIdentificacion = Convert.ToInt32(cmb_TipoId.SelectedValue);
            objEmpresas.identificacion = txt_identificacion.Text;
            objEmpresas.telefonoEmpresa = txt_telefono.Text;
            objEmpresas.isDeleted = false;
            objEmpresas.Direccion = txt_direccion.Text;

            string accion = String.Empty;
            accion = "Editar";

            if (objEmpresas.insertarEmpresaCliente(accion))
            {
                MessageBox.Show("Exito al guardar datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cargarListaEmpresaCliente();
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
        public void eliminarEmpresaCliente()
        {
            objEmpresas.idEmpresaCliente = idCliente;
            if (objEmpresas.eliminarEmpresaCliente())
            {
                MessageBox.Show("Exito al eliminar datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cargarListaEmpresaCliente();
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
            if (!Validaciones.validar(txt_nombre))
            {
                MessageBox.Show("No ingreso nombre", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nombre.Focus();
                return false;
            }
            if (!Validaciones.validar(txt_identificacion))
            {
                MessageBox.Show("No ingreso identificacion", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_identificacion.Focus();
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
        private void cargarListaEmpresaCliente()
        {
            try
            {
                dtg_empresasClientes.AutoGenerateColumns = false;
                dtg_empresasClientes.DataSource = objEmpresas.cargarDataGridEmpresasClientes().Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
