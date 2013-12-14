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
    public partial class frm_MantenimientoEmpleados : Form
    {
        //DECLARACION DE INSTANCIAS DE LAS CLASES
        UsuariosSistema objUsuariosSistema = new UsuariosSistema();
        TipoIdentificacion objTipoId = new TipoIdentificacion();
        empleados objEmpleados = new empleados();
        DescripcionDepartamento objDepartamento = new DescripcionDepartamento();
        Salarios objSalarios = new Salarios();
        tipoPuestos objPuestos = new tipoPuestos();

        //VARIABLES GLOBALES
        private string usuarioSistema = string.Empty;
        private int id = 0;

        public frm_MantenimientoEmpleados()
        {
            InitializeComponent();
        }

        public frm_MantenimientoEmpleados(string usuario) : this()
        {
            this.usuarioSistema = usuario;
        }   

        private void frm_MantenimientoEmpleados_Load(object sender, EventArgs e)
        {
            this.limiteCampos();
            this.cargarComboBoxTipoID();
            this.cargarComboBoxUsuarioSistema();
            this.cargarComboBoxDepartamentos();
            this.cargarComboBoxPuestos();
            this.cargarComboBoxSalarios();
            this.cargarListaEmpleados();
        }

        private void frm_MantenimientoEmpleados_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = e.CloseReason == CloseReason.UserClosing;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (this.validacionDeCampos() == true)
            {
                this.insertarEmpleado();
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

        private void dtg_Empleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Editar.Index && e.RowIndex >= 0)
            {
                id = Convert.ToInt32(dtg_Empleados.Rows[e.RowIndex].Cells[0].Value.ToString());

                if ((MessageBox.Show("Desea editar este cliente?", "Edicion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (this.validacionDeCampos() == true)
                    {
                        this.updateEmpleado();
                    }
                }
                else
                {
                    return;
                }
            }
            else if (e.ColumnIndex == Eliminar.Index && e.RowIndex >= 0)
            {
                id = Convert.ToInt32(dtg_Empleados.Rows[e.RowIndex].Cells[0].Value.ToString());

                if ((MessageBox.Show("Desea eliminar este cliente?", "Edicion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    this.eliminarEmpleado();
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
        private void insertarEmpleado()
        {
            if (validarSoloLetras(txt_nombre) == false)
            {
                MessageBox.Show("Ingrese Unicamente Letras para el campo de Nombre", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nombre.Focus();
                return;
            }
            if (validarSoloLetrasConEspacios(txt_apellido) == false)
            {
                MessageBox.Show("Ingrese Unicamente Letras para el campo de Apellidos", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_apellido.Focus();
                return;
            }
            if (validarSoloLetrasYNumeros(txt_id) == false)
            {
                MessageBox.Show("Ingrese Unicamente Letras para el campo de Identificacion", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_id.Focus();
                return;
            }
            if (validarSoloNumeros(txt_telefono) == false)
            {
                MessageBox.Show("Ingrese Unicamente Numeros para el campo de telefono", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_telefono.Focus();
                return;
            }
            if (validarSoloNumeros(txt_celular) == false)
            {
                MessageBox.Show("Ingrese Unicamente Numeros para el campo de celular", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_celular.Focus();
                return;
            }
            if (validarSoloNumeros(txt_vac_disp) == false)
            {
                MessageBox.Show("Ingrese Unicamente Numeros para el campo de vacaciones", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_vac_disp.Focus();
                return;
            }        

            objEmpleados.idEmpleado = id;
            objEmpleados.idUsuarioSistema = Convert.ToInt32(cmb_usuario_sist.SelectedValue);
            objEmpleados.nombre = txt_nombre.Text;
            objEmpleados.apellido = txt_apellido.Text;
            objEmpleados.idTipoIdentificacion = Convert.ToInt32(cmb_tipo_id.SelectedValue);
            objEmpleados.identificacion = txt_id.Text;
            objEmpleados.fechaNacimiento = txt_fecha_nac.Text;
            objEmpleados.correo = txt_correo.Text;
            objEmpleados.direccion = txt_direccion.Text;
            objEmpleados.idDepartamento = Convert.ToInt32(cmb_depart.SelectedValue);
            objEmpleados.idPuesto = Convert.ToInt32(cmb_puesto.SelectedValue);
            objEmpleados.telefono = txt_telefono.Text;
            objEmpleados.celular = txt_celular.Text;
            objEmpleados.fechaIngreso = txt_fecha_ingreso.Text;
            objEmpleados.vacacionesDisponibles = Convert.ToInt32(txt_vac_disp.Text);
            objEmpleados.idSalario = Convert.ToInt32(cmb_salario.SelectedValue);
            objEmpleados.isdeleted = false;

            string accion = String.Empty;
            accion = "Insertar";

            if (objEmpleados.insertar_EmpleadosMantenimientos(accion))
            {
                MessageBox.Show("Exito al guardar datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.limpiarDatos();
                this.cargarListaEmpleados();
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
            if (!Validaciones.validar(txt_nombre))
            {
                MessageBox.Show("No ingreso nombre", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nombre.Focus();
                return false;
            }
            if (!Validaciones.validar(txt_apellido))
            {
                MessageBox.Show("No ingreso apellidos", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_apellido.Focus();
                return false;
            }
            if (!Validaciones.validar(txt_id))
            {
                MessageBox.Show("No ingreso identificacion", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_id.Focus();
                return false;
            }
            if (!Validaciones.validar(txt_telefono))
            {
                MessageBox.Show("No ingreso telefono", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_telefono.Focus();
                return false;
            }
            if (!Validaciones.validar(txt_celular))
            {
                MessageBox.Show("No ingreso celular", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_celular.Focus();
                return false;
            }
            if (!Validaciones.validar(txt_correo))
            {
                MessageBox.Show("No ingreso correo", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_correo.Focus();
                return false;
            }
            if (!Validaciones.validar(txt_direccion))
            {
                MessageBox.Show("No ingreso direccion", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_direccion.Focus();
                return false;
            }
            if (!Validaciones.validar(txt_fecha_ingreso))
            {
                MessageBox.Show("No ingreso fecha de ingreso", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_fecha_ingreso.Focus();
                return false;
            }
            if (!Validaciones.validar(txt_fecha_nac))
            {
                MessageBox.Show("No ingreso fecha de nacimiento", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_fecha_nac.Focus();
                return false;
            }
            if (!Validaciones.validar(txt_vac_disp))
            {
                MessageBox.Show("No ingreso vacaciones disponibles", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_vac_disp.Focus();
                return false;
            }
            if (this.validarFechaIngreso() == false)
            {
                MessageBox.Show("Formato de fecha invalido", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_fecha_ingreso.Focus();
                return false;
            }
            if (this.validarFechaNacimiento() == false)
            {
                MessageBox.Show("Formato de fecha invalido", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_fecha_nac.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        //METODO
        //RAFAEL ANGEL SEQUEIRA VARGAS
        private void cargarListaEmpleados()
        {
            try
            {
                dtg_Empleados.AutoGenerateColumns = false;
                dtg_Empleados.DataSource = objEmpleados.cargarListaEmpleadosCompleto().Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //METODO
        //RAFAEL ANGEL SEQUEIRA VARGAS
        private void updateEmpleado()
        {
            if (validarSoloLetras(txt_nombre) == false)
            {
                MessageBox.Show("Ingrese Unicamente Letras para el campo de Nombre", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nombre.Focus();
                return;
            }
            if (validarSoloLetrasConEspacios(txt_apellido) == false)
            {
                MessageBox.Show("Ingrese Unicamente Letras para el campo de Apellidos", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_apellido.Focus();
                return;
            }
            if (validarSoloLetrasYNumeros(txt_id) == false)
            {
                MessageBox.Show("Ingrese Unicamente Letras para el campo de Identificacion", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_id.Focus();
                return;
            }
            if (validarSoloNumeros(txt_telefono) == false)
            {
                MessageBox.Show("Ingrese Unicamente Numeros para el campo de telefono", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_telefono.Focus();
                return;
            }
            if (validarSoloNumeros(txt_celular) == false)
            {
                MessageBox.Show("Ingrese Unicamente Numeros para el campo de celular", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_celular.Focus();
                return;
            }
            if (validarSoloNumeros(txt_vac_disp) == false)
            {
                MessageBox.Show("Ingrese Unicamente Numeros para el campo de vacaciones", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_vac_disp.Focus();
                return;
            }

            objEmpleados.idEmpleado = id;
            objEmpleados.idUsuarioSistema = Convert.ToInt32(cmb_usuario_sist.SelectedValue);
            objEmpleados.nombre = txt_nombre.Text;
            objEmpleados.apellido = txt_apellido.Text;
            objEmpleados.idTipoIdentificacion = Convert.ToInt32(cmb_tipo_id.SelectedValue);
            objEmpleados.identificacion = txt_id.Text;
            objEmpleados.fechaNacimiento = txt_fecha_nac.Text;
            objEmpleados.correo = txt_correo.Text;
            objEmpleados.direccion = txt_direccion.Text;
            objEmpleados.idDepartamento = Convert.ToInt32(cmb_depart.SelectedValue);
            objEmpleados.idPuesto = Convert.ToInt32(cmb_puesto.SelectedValue);
            objEmpleados.telefono = txt_telefono.Text;
            objEmpleados.celular = txt_celular.Text;
            objEmpleados.fechaIngreso = txt_fecha_ingreso.Text;
            objEmpleados.vacacionesDisponibles = Convert.ToInt32(txt_vac_disp.Text);
            objEmpleados.idSalario = Convert.ToInt32(cmb_salario.SelectedValue);
            objEmpleados.isdeleted = false;

            string accion = String.Empty;
            accion = "Editar";

            if (objEmpleados.insertar_EmpleadosMantenimientos(accion))
            {
                MessageBox.Show("Exito al guardar datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.limpiarDatos();
                this.cargarListaEmpleados();
            }
            else
            {
                MessageBox.Show("Error al guardar datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //METODO
        //RAFAEL ANGEL SEQUEIRA VARGAS
        private void eliminarEmpleado()
        {
            objEmpleados.idEmpleado = id;
            if (objEmpleados.eliminarEmpleado())
            {
                MessageBox.Show("Exito al eliminar datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cargarListaEmpleados();
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

        private bool validarFechaIngreso()
        {
            DateTime dt;
            if (DateTime.TryParse(txt_fecha_ingreso.Text, out dt))
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        private bool validarFechaNacimiento()
        {
            DateTime dt;
            if (DateTime.TryParse(txt_fecha_nac.Text, out dt))
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
        public void limpiarDatos()
        {
            Limpieza.limpiar(txt_apellido);
            Limpieza.limpiar(txt_celular);
            Limpieza.limpiar(txt_correo);
            Limpieza.limpiar(txt_direccion);
            Limpieza.limpiar(txt_fecha_ingreso);
            Limpieza.limpiar(txt_fecha_nac);
            Limpieza.limpiar(txt_id);
            Limpieza.limpiar(txt_nombre);
            Limpieza.limpiar(txt_telefono);
            Limpieza.limpiar(txt_vac_disp);
        }

        //METODO
        //RAFAEL ANGEL SEQUEIRA VARGAS
        public void limiteCampos()
        {
            txt_apellido.MaxLength = 50;
            txt_celular.MaxLength = 15;
            txt_correo.MaxLength = 50;
            txt_direccion.MaxLength = 250;
            txt_fecha_ingreso.MaxLength = 10;
            txt_fecha_nac.MaxLength = 10;
            txt_id.MaxLength = 15;
            txt_nombre.MaxLength = 50;
            txt_telefono.MaxLength = 15;
            txt_vac_disp.MaxLength = 2;
        }

        //METODO CARGA COMBO BOX
        //RAFAEL ANGEL SEQUEIRA VARGAS
        private void cargarComboBoxTipoID()
        {
            try
            {
                DataSet ds;
                ds = objTipoId.cargarTipoIdenticacion();
                cmb_tipo_id.DataSource = ds.Tables[0];
                cmb_tipo_id.DisplayMember = ds.Tables[0].Columns["descripcion"].ColumnName.ToString();
                cmb_tipo_id.ValueMember = ds.Tables[0].Columns["idTipoIdentificacion"].ColumnName.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexion a la base de datos", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //METODO CARGA COMBO BOX DEPARTAMENTOS
        //RAFAEL ANGEL SEQUEIRA VARGAS
        private void cargarComboBoxDepartamentos()
        {
            try
            {
                DataSet ds;
                ds = objDepartamento.cargarDescripcionDepartamentos();
                cmb_depart.DataSource = ds.Tables[0];
                cmb_depart.DisplayMember = ds.Tables[0].Columns["descripcion"].ColumnName.ToString();
                cmb_depart.ValueMember = ds.Tables[0].Columns["idDepartamento"].ColumnName.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexion a la base de datos", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //METODO CARGA COMBO BOX PUESTOS
        //RAFAEL ANGEL SEQUEIRA VARGAS
        private void cargarComboBoxPuestos()
        {
            try
            {
                DataSet ds;
                ds = objPuestos.cargaListaTipoPuesto();
                cmb_puesto.DataSource = ds.Tables[0];
                cmb_puesto.DisplayMember = ds.Tables[0].Columns["descripcion"].ColumnName.ToString();
                cmb_puesto.ValueMember = ds.Tables[0].Columns["idPuesto"].ColumnName.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexion a la base de datos", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //METODO CARGA COMBO BOX PUESTOS
        //RAFAEL ANGEL SEQUEIRA VARGAS
        private void cargarComboBoxSalarios()
        {
            try
            {
                DataSet ds;
                ds = objSalarios.cargaListaSalarios();
                cmb_salario.DataSource = ds.Tables[0];
                cmb_salario.DisplayMember = ds.Tables[0].Columns["monto"].ColumnName.ToString();
                cmb_salario.ValueMember = ds.Tables[0].Columns["idSalario"].ColumnName.ToString();
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
                cmb_usuario_sist.DataSource = ds.Tables[0];
                cmb_usuario_sist.DisplayMember = ds.Tables[0].Columns["nombreUsuarioSistema"].ColumnName.ToString();
                cmb_usuario_sist.ValueMember = ds.Tables[0].Columns["idUsuarioSistema"].ColumnName.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexion a la base de datos", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
