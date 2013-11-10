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
    public partial class frm_RRHH_NuevoEmpleado : Form
    {
        //DECLARACION DE INSTANCIAS DE LAS CLASES
        UsuariosSistema objUsuariosSistema = new UsuariosSistema();

        //VARIABLES GLOBALES
        private string usuarioSistema = string.Empty;
        private int rolUsuario;

        public frm_RRHH_NuevoEmpleado()
        {
            InitializeComponent();
        }

        public frm_RRHH_NuevoEmpleado(string usuario) : this()
        {
            this.usuarioSistema = usuario;
        }

        private void frm_RRHH_NuevoEmpleado_Load(object sender, EventArgs e)
        {
            this.cargaRolUsuario();
            this.rolesUsuario();
            this.limpia();
            this.cargarComboBox();
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

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Desea salir sin generar nuevo Usuario", "Volver al Menu Principal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                frm_0MenuPrincipal ventanaMenuPrincipal = new frm_0MenuPrincipal(usuarioSistema);
                this.Close();
                ventanaMenuPrincipal.Show();
            }
            else
            {
                return;
            }
        }

        private void cargarComboBox()
        {
            this.cargarTipoIdentificacion();
            this.cargarDepartamentos();
            this.cargarPuestos();
            this.cargarSalarios();
        }

        private void cargarTipoIdentificacion()
        {
            try
            {
                DataSet ds;
                ds = objTipoIdentificacion.cargarTipoIdenticacion();
                cmb_TipoIdentificacion.DataSource = ds.Tables[0];
                cmb_TipoIdentificacion.DisplayMember=ds.Tables[0].Columns["descripcion"].ColumnName.ToString();
                cmb_TipoIdentificacion.ValueMember = ds.Tables[0].Columns["idTipoIdentificacion"].ColumnName.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void cargarDepartamentos()
        {
            try
            {
                DataSet ds;
                ds = objDepartamentos.cargarDescripcionDepartamentos();
                cmb_Departamento.DataSource = ds.Tables[0];
                cmb_Departamento.DisplayMember = ds.Tables[0].Columns["descripcion"].ColumnName.ToString();
                cmb_Departamento.ValueMember = ds.Tables[0].Columns["idDepartamento"].ColumnName.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } 
        }

        private void cargarPuestos()
        {
            try
            {
                DataSet ds;
                ds = objTipoPuesto.cargaListaTipoPuesto();
                cmb_Puesto.DataSource = ds.Tables[0];
                cmb_Puesto.DisplayMember = ds.Tables[0].Columns["descripcion"].ColumnName.ToString();
                cmb_Puesto.ValueMember = ds.Tables[0].Columns["idPuesto"].ColumnName.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void cargarSalarios()
        {
            try
            {
                DataSet ds;
                ds = objNuevoEmpleado.cargarSalarios();

                cmb_Salarios.DataSource = ds.Tables[0];
                cmb_Salarios.DisplayMember = ds.Tables[0].Columns["monto"].ColumnName.ToString();
                cmb_Salarios.ValueMember = ds.Tables[0].Columns["idSalario"].ColumnName.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
           if (!Validaciones.validar(txt_Nombre))
            {
                MessageBox.Show("Por favor ingrese un Nombre", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Nombre.Focus();
                return;
            } 
            if (!Validaciones.validar(txt_Apellido))
            {
                MessageBox.Show("Por favor ingrese los apellidos", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Apellido.Focus();
                return;
            }
            if (!Validaciones.validar(txt_identificacion))
            {
                MessageBox.Show("Por favor ingrese la identificacion", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_identificacion.Focus();
                return;
            }
            if (!Validaciones.validar(txt_Correo))
            {
                MessageBox.Show("Por favor ingrese un correo electronico", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Correo.Focus();
                return;
            } 
            if (!Validaciones.validar(txt_Direccion))
            {
                MessageBox.Show("Por favor ingrese la direccion", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Direccion.Focus();
                return;
            } 
            if (!Validaciones.validar(msk_FechaNacimiento))
            {
                MessageBox.Show("Por favor ingrese la fecha de nacimiento", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                msk_FechaNacimiento.Focus();
                return;
            }
            if (!Validaciones.validar(msk_FechaIngreso))
            {
                MessageBox.Show("Por favor ingrese la fecha de ingreso", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                msk_FechaIngreso.Focus();
                return;
            }
            else
            {
                objNuevoEmpleado.Nombre = txt_Nombre.Text;
                objNuevoEmpleado.Apellidos = txt_Apellido.Text;
                objNuevoEmpleado.TipoIdentificacion = Convert.ToInt32(cmb_TipoIdentificacion.SelectedValue.ToString());
                objNuevoEmpleado.Identificacion = txt_identificacion.Text;
                objNuevoEmpleado.FechaNacimiento = Convert.ToDateTime(msk_FechaNacimiento.Text);
                objNuevoEmpleado.Correo = txt_Correo.Text;
                objNuevoEmpleado.Direccion = txt_Direccion.Text;
                objNuevoEmpleado.Departamento = Convert.ToInt32(cmb_Departamento.SelectedValue.ToString());
                objNuevoEmpleado.Puesto = Convert.ToInt32(cmb_Puesto.SelectedValue.ToString());
                objNuevoEmpleado.Telefono = msk_Telefono.Text;
                objNuevoEmpleado.Celular = msk_Celular.Text;
                objNuevoEmpleado.FechaIngreso = Convert.ToDateTime(msk_FechaIngreso.Text);
                objNuevoEmpleado.Salario = Convert.ToInt32(cmb_Salarios.SelectedValue.ToString());
                bool estado = objNuevoEmpleado.insertarUsuarioNuevo();
                if (estado)
                {
                    MessageBox.Show("El usuario " + objNuevoEmpleado.Nombre + " " + objNuevoEmpleado.Apellidos + " se ha guardado en la base de datos", "Guardado Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.limpia();
                }
            }

        }

        private void limpia()
        {
            txt_Nombre.Clear();
            txt_Apellido.Clear();
            txt_Correo.Clear();
            txt_Direccion.Clear();
            txt_identificacion.Clear();
            msk_Celular.Clear();
            msk_FechaIngreso.Clear();
            msk_FechaNacimiento.Clear();
            msk_Telefono.Clear();
        }
    }
}
