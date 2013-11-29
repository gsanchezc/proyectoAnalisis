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
    public partial class frm_Seguridad_AdministracionCuentasUsuario : Form
    {
        //DECLARACION DE INSTANCIAS DE LAS CLASES
        UsuariosSistema objUsuariosSistema = new UsuariosSistema();
        Seguridad objSeguridad = new Seguridad();
        clientesUsuarioFinal objClienteUsuarioFinal = new clientesUsuarioFinal();
        empleados objEmpleados = new empleados();

        //VARIABLES GLOBALES
        private string usuarioSistema = string.Empty;

        public frm_Seguridad_AdministracionCuentasUsuario()
        {
            InitializeComponent();
        }

        public frm_Seguridad_AdministracionCuentasUsuario(string usuario) : this()
        {
            this.usuarioSistema = usuario;
        }

        private void frm_Seguridad_AdministracionCuentasUsuario_Load(object sender, EventArgs e)
        {
            this.limiteCampos();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            frm_0MenuPrincipal ventana = new frm_0MenuPrincipal(usuarioSistema);

            if ((MessageBox.Show("Desea regresar al menu principal", "Volver al Menu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                this.Hide(); ;
                ventana.Show();
            }
            else
            {
                return;
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            this.limpiezaDeCampos();
        }

        private void rb_clientes_CheckedChanged(object sender, EventArgs e)
        {
            lst_ListaUsuario.Items.Clear();
            this.cargaListaUsuariosSistema();
        }

        private void rb_empleados_CheckedChanged(object sender, EventArgs e)
        {
            lst_ListaUsuario.Items.Clear();
            this.cargaListaUsuariosSistema();
        }

        private void lst_ListaUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cargaInfo();
        }

        private void txt_idUsuarioSistema_TextChanged(object sender, EventArgs e)
        {
            int usuarioSistemaCargado = Convert.ToInt32(txt_idUsuarioSistema.Text);
            if (usuarioSistemaCargado == 0)
            {
                btn_actualizarUsuario.Enabled = false;
                btn_crearUsuario.Enabled = true;
            }
            else
            {
                btn_actualizarUsuario.Enabled = true;
                btn_crearUsuario.Enabled = false;
            }
        }

        private void btn_crearUsuario_Click(object sender, EventArgs e)
        {
            if (this.validacionDeCampos() == true)
            {
                if (this.validacionRadioButtonActivoInactivo() == true)
                {
                    objUsuariosSistema.existeUsuarioSistemaLogin(txt_Usuario.Text);
                    if (objUsuariosSistema.validacion == true)
                    {
                        MessageBox.Show("Usuario Ya existe en Sistema", "Intento de login fallido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        this.crearCuenta();
                        this.actualizarIdUsuarioSistema();
                    }

                    if (rb_clientes.Checked == true)
                    {
                        this.actualizarIdUsuarioSistemaCliente();
                    }
                    else if (rb_empleados.Checked == true)
                    {
                        this.actualizarIdUsuarioSistemaEmpleado();
                    }
                    else
                    {}
                }
            }
        }

        private void btn_actualizarUsuario_Click(object sender, EventArgs e)
        {
            if (rb_actualizarUsuarioContrasena.Checked == true)
            {
                if (!Validaciones.validar(txt_idUsuarioSistema))
                {
                    MessageBox.Show("No hay dato cargado en campo ID Usuario Sistema", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_idUsuarioSistema.Focus();
                    return;
                }
                else
                {
                    objUsuariosSistema.existeUsuarioSistemaLogin(txt_Usuario.Text);
                    if (objUsuariosSistema.validacion == true)
                    {
                        MessageBox.Show("Usuario Ya existe en Sistema", "Lo sentimos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        this.actualizarUsuarioContrasena();
                    }
                }
            }
            else if (rb_bloquearDesbloquearCuenta.Checked == true)
            {
                if (this.validacionRadioButtonActivoInactivo() == true)
                {
                    if (!Validaciones.validar(txt_idUsuarioSistema))
                    {
                        MessageBox.Show("No hay dato cargado en campo ID Usuario Sistema", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_idUsuarioSistema.Focus();
                        return;
                    }
                    else
                    {
                        this.bloquearDesbloquearCuenta();
                    }
                }
            }
            else
            {
                MessageBox.Show("No ha marcado ninguna opcion de actualizacion", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //METODO PARA ACTUALIZAR
        //RAFAEL SEQUEIRA VARGAS
        private void actualizarUsuarioContrasena()
        {
            if (!Validaciones.validar(txt_Usuario))
            {
                MessageBox.Show("No ingreso Usuario", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Usuario.Focus();
                return;
            }
            if (!Validaciones.validar(txt_Contraseña))
            {
                MessageBox.Show("No ingreso Contraseña", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Contraseña.Focus();
                return;
            }
            if (validarSoloLetrasYNumeros(txt_Usuario) == false)
            {
                MessageBox.Show("Ingrese Unicamente Letras o numeros para nombre de usuario", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Usuario.Focus();
                return;
            }
            if (validarSoloLetrasYNumeros(txt_Contraseña) == false)
            {
                MessageBox.Show("Ingrese Unicamente Letras o numeros para contrasena", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Contraseña.Focus();
                return;
            }

            objUsuariosSistema.idUsuarioSistema = Convert.ToInt32(txt_idUsuarioSistema.Text);
            objUsuariosSistema.nombreUsuarioSistema = txt_Usuario.Text;
            objUsuariosSistema.contrasenna = objSeguridad.MD5Hash(txt_Contraseña.Text);

            string accion = String.Empty;
            accion = "Editar";

            if (objUsuariosSistema.actualizar_usuariosSistema(accion))
            {
                MessageBox.Show("Exito al actualizar datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("Error al guardar datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //METODO PARA ACTUALIZAR
        //RAFAEL SEQUEIRA VARGAS
        private void bloquearDesbloquearCuenta()
        {
            objUsuariosSistema.idUsuarioSistema = Convert.ToInt32(txt_idUsuarioSistema.Text);
            this.validacionRadioButtonActivoInactivo();

            string accion = String.Empty;
            accion = "Editar";

            if (objUsuariosSistema.actualizarEstatusCuenta(accion))
            {
                MessageBox.Show("Exito al actualizar datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("Error al guardar datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //METODO PARA ACTUALIZAR EL CAMPO ID USUARIO SISTEMA
        //RAFAEL SEQUEIRA VARGAS
        private void actualizarIdUsuarioSistema()
        {
            objUsuariosSistema.cargaIdUsuarioSistema(txt_Usuario.Text);
            txt_idUsuarioSistema.Text = objUsuariosSistema.idUsuarioSistema.ToString();
        }

        //METODO PARA ACTUALIZAR ID USUARIO SISTEMA CLIENTE EN LA BASE
        //RAFAEL SEQUEIRA VARGAS
        public void actualizarIdUsuarioSistemaCliente()
        {
            objClienteUsuarioFinal.idClienteUsuarioFinal = Convert.ToInt32(lst_ListaUsuario.SelectedItem.ToString());
            objClienteUsuarioFinal.idUsuarioSistema = Convert.ToInt32(txt_idUsuarioSistema.Text);

            string accion = String.Empty;
            accion = "Editar";

            if (objClienteUsuarioFinal.actualizarIdUsuarioSistemaCliente(accion))
            {
                MessageBox.Show("Exito al actualizar datos","Validacion",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("Error al guardar datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //METODO PARA ACTUALIZAR ID USUARIO SISTEMA EMPLEADO EN LA BASE
        //RAFAEL SEQUEIRA VARGAS
        public void actualizarIdUsuarioSistemaEmpleado()
        {
            objEmpleados.idEmpleado = Convert.ToInt32(lst_ListaUsuario.SelectedItem.ToString());
            objEmpleados.idUsuarioSistema = Convert.ToInt32(txt_idUsuarioSistema.Text);

            string accion = String.Empty;
            accion = "Editar";

            if (objEmpleados.actualizarIdUsuarioSistemaEmpleado(accion))
            {
                MessageBox.Show("Exito al actualizar datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("Error al guardar datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //METODO PARA CREAR CUENTA
        //RAFAEL SEQUEIRA VARGAS
        public bool validacionRadioButtonActivoInactivo()
        {
            if (rbt_activo.Checked == true)
            {
                objUsuariosSistema.isblock = false;
                return true;
            }
            else if (rbt_inactivo.Checked == true)
            {
                objUsuariosSistema.isblock = true;
                return true;
            }
            else
            {
                MessageBox.Show("No ha marcado opcion de activo o inactivo", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //METODO PARA CREAR CUENTA
        //RAFAEL SEQUEIRA VARGAS
        public void crearCuenta()
        {
            objUsuariosSistema.nombreUsuarioSistema = txt_Usuario.Text;
            objUsuariosSistema.contrasenna = objSeguridad.MD5Hash(txt_Contraseña.Text);
            objUsuariosSistema.idRol = 6;
            objUsuariosSistema.isdeleted = false;

            string accion = String.Empty;
            accion = "Insertar";

            if (objUsuariosSistema.insertar_usuariosSistema(accion))
            {
                MessageBox.Show("Exito al guardar datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("Error al guardar datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }       
        }

        //METODO CARGA LISTA USUARIOS SISTEMAS
        //RAFAEL SEQUEIRA VARGAS
        private void cargaInfo()
        {
            if (rb_clientes.Checked == true)
            {
                int idClienteUsuarioFinalSeleccionado = Convert.ToInt32(lst_ListaUsuario.SelectedItem.ToString());
                objClienteUsuarioFinal.cargaInfoCliente(idClienteUsuarioFinalSeleccionado);
                objClienteUsuarioFinal.cargaIdUsuarioSistema(idClienteUsuarioFinalSeleccionado);

                txt_idUsuarioSistema.Text = objClienteUsuarioFinal.idUsuarioSistema.ToString();
                txt_nombre.Text = objClienteUsuarioFinal.nombre;
                txt_apellidos.Text = objClienteUsuarioFinal.apellidos;
                txt_identificacion.Text = objClienteUsuarioFinal.identificacion;
            }
            else if (rb_empleados.Checked == true)
            {
                int idEmpleadoSeleccionado = Convert.ToInt32(lst_ListaUsuario.SelectedItem.ToString());
                objEmpleados.cargaInfoEmpleado(idEmpleadoSeleccionado);
                objEmpleados.cargaIdUsuarioSistema(idEmpleadoSeleccionado);

                txt_idUsuarioSistema.Text = objEmpleados.idUsuarioSistema.ToString();
                txt_nombre.Text = objEmpleados.nombre;
                txt_apellidos.Text = objEmpleados.apellido;
                txt_identificacion.Text = objEmpleados.identificacion;
            }
            else
            {
                MessageBox.Show("Error al cargar Informacion", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //METODO CARGA LISTA USUARIOS SISTEMAS
        //RAFAEL SEQUEIRA VARGAS
        private void cargaListaUsuariosSistema()
        {
            if (rb_clientes.Checked == true)
            {
                try
                {
                    DataSet ds;
                    ds = objUsuariosSistema.cargalistaIDClientes();
                    int tamano = ds.Tables[0].Rows.Count;
                    txt_clientes.Text = tamano.ToString();

                    for (int i = 0; i < tamano; i++)
                    {
                        lst_ListaUsuario.Items.Add(ds.Tables[0].Rows[i]["idClienteUsuarioFinal"].ToString());
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Hubo un problema con la conexion a la base de datos", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (rb_empleados.Checked == true)
            {
                try
                {
                    DataSet ds;
                    ds = objUsuariosSistema.cargalistaIDEmpleados();
                    int tamano = ds.Tables[0].Rows.Count;
                    txt_empleados.Text = tamano.ToString();

                    for (int i = 0; i < tamano; i++)
                    {
                        lst_ListaUsuario.Items.Add(ds.Tables[0].Rows[i]["idEmpleado"].ToString());
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Hubo un problema con la conexion a la base de datos", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Error al cargar lista", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //METODO VALIDACION DE CAMPOS
        //RAFAEL SEQUEIRA VARGAS
        public bool validacionDeCampos()
        {
            if (!Validaciones.validar(txt_Usuario))
            {
                MessageBox.Show("No ingreso Usuario", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Usuario.Focus();
                return false;
            }
            if (!Validaciones.validar(txt_Contraseña))
            {
                MessageBox.Show("No ingreso Contraseña", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Contraseña.Focus();
                return false;
            }
            if (!Validaciones.validar(txt_confirmaContraseña))
            {
                MessageBox.Show("No ingreso Confirmar Contrasena", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_confirmaContraseña.Focus();
                return false;
            }
            if (!Validaciones.validar(txt_idUsuarioSistema))
            {
                MessageBox.Show("No hay dato cargado en campo ID Usuario Sistema", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_idUsuarioSistema.Focus();
                return false;
            }
            if (!Validaciones.validar(txt_nombre))
            {
                MessageBox.Show("No hay dato cargado en campo nombre", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nombre.Focus();
                return false;
            }
            if (!Validaciones.validar(txt_apellidos))
            {
                MessageBox.Show("No hay dato cargado en campo apellidos", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_apellidos.Focus();
                return false;
            }
            if (!Validaciones.validar(txt_identificacion))
            {
                MessageBox.Show("No hay dato cargado en campo Identificacion", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_identificacion.Focus();
                return false;
            }

            if (txt_Contraseña.Text != txt_confirmaContraseña.Text)
            {
                MessageBox.Show("La confirmacion de la contrasena es erronea", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpieza.limpiar(txt_Contraseña);
                Limpieza.limpiar(txt_confirmaContraseña);
                txt_Contraseña.Focus();
                return false;
            }
            if (validarSoloLetrasYNumeros(txt_Usuario) == false)
            {
                MessageBox.Show("Ingrese Unicamente Letras o numeros para nombre de usuario", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Usuario.Focus();
                return false;
            }
            if (validarSoloLetrasYNumeros(txt_Contraseña) == false)
            {
                MessageBox.Show("Ingrese Unicamente Letras o numeros para contrasena", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Contraseña.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        //METODO VALIDACION DE CAMPOS
        //RAFAEL SEQUEIRA VARGAS
        public void limpiezaDeCampos()
        {
            txt_idUsuarioSistema.Text = "0";
            Limpieza.limpiar(txt_nombre);
            Limpieza.limpiar(txt_apellidos);
            Limpieza.limpiar(txt_identificacion);
            Limpieza.limpiar(txt_Usuario);
            Limpieza.limpiar(txt_Contraseña);
            Limpieza.limpiar(txt_confirmaContraseña);
        }

        private void frm_Seguridad_AdministracionCuentasUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = e.CloseReason == CloseReason.UserClosing;
        }

        public void limiteCampos()
        {
            txt_Usuario.MaxLength = 10;
            txt_Contraseña.MaxLength = 200;
        }

        private static bool validarSoloLetrasYNumeros(Control mitextbox)
        {
            Regex regex = new Regex("^[a-zA-Z0-9]+$");
            return regex.IsMatch(mitextbox.Text);
        }
    }
}

