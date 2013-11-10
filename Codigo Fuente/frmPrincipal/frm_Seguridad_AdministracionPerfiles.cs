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
    public partial class frm_Seguridad_AdministracionPerfiles : Form
    {
        //DECLARACION DE INSTANCIAS DE LAS CLASES
        UsuariosSistema objUsuariosSistema = new UsuariosSistema();
        empleados objEmpleados = new empleados();
        clientesUsuarioFinal objClienteUsuarioFinal = new clientesUsuarioFinal();

        //VARIABLES GLOBALES
        private string usuarioSistema = string.Empty;
        private int rol = 0;

        public frm_Seguridad_AdministracionPerfiles()
        {
            InitializeComponent();
        }

        public frm_Seguridad_AdministracionPerfiles(string usuario) : this()
        {
            this.usuarioSistema = usuario;
        }

        private void frm_Seguridad_AdministracionPerfiles_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            frm_0MenuPrincipal ventana = new frm_0MenuPrincipal(usuarioSistema);

            if ((MessageBox.Show("Desea regresar al menu principal", "Volver al Menu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                this.Close();
                ventana.Show();
            }
            else
            {
                return;
            }
        }

        private void btn_actualizarRoles_Click(object sender, EventArgs e)
        {
            if (this.validacionDeCampos() == true)
            {
                if (this.validacionRadioButton() == true)
                {
                    this.actualizaRol();
                    this.cargaRolUsuario();
                }
            }
        }

        private void rb_clientes_CheckedChanged(object sender, EventArgs e)
        {
            lst_ListaUsuario.Items.Clear();
            this.cargaListaUsuariosSistema();

            rb_Administrador.Enabled = false;
            rb_Supervisor.Enabled = false;
            rb_tecnico.Enabled = false;
            rb_RRHH.Enabled = false;
            rb_Contabilidad.Enabled = false;
            rb_clientes.Enabled = true;
        }

        private void rb_empleados_CheckedChanged(object sender, EventArgs e)
        {
            lst_ListaUsuario.Items.Clear();
            this.cargaListaUsuariosSistema();

            rb_Administrador.Enabled = true;
            rb_Supervisor.Enabled = true;
            rb_tecnico.Enabled = true;
            rb_RRHH.Enabled = true;
            rb_Contabilidad.Enabled = true;
            rb_UsuarioFinal.Enabled = false;
        }


        private void lst_ListaUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cargaInfo();
            this.cargaRolUsuario();
        }

        //METODO PARA MANEJAR EL ACCESO POR ROLES
        //RAFAEL ANGEL SEQUEIRA VARGAS
        public void cargaRolUsuario()
        {
            objUsuariosSistema.cargaRolUsuarioConIDSistema(Convert.ToInt32(txt_idUsuarioSistema.Text));
            txt_RolActual.Text = objUsuariosSistema.idRol.ToString();
        }

        //METODO
        //RAFAEL SEQUEIRA VARGAS
        private void actualizaRol()
        {
            objUsuariosSistema.idUsuarioSistema = Convert.ToInt32(txt_idUsuarioSistema.Text);
            objUsuariosSistema.idRol = rol;

            string accion = String.Empty;
            accion = "Editar";

            if (objUsuariosSistema.actualizarRol(accion))
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
                objEmpleados.cargaIdEmpleado(idEmpleadoSeleccionado);

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
            else
            {
                return true;
            }
        }

        public bool validacionRadioButton()
        {
            if (rb_Administrador.Checked == true)
            {
                rol = 1;
                return true;
            }
            else if (rb_Supervisor.Checked == true)
            {
                rol = 2;
                return true;
            }
            else if (rb_tecnico.Checked == true)
            {
                rol = 3;
                return true;
            }
            else if (rb_RRHH.Checked == true)
            {
                rol = 4;
                return true;
            }
            else if (rb_Contabilidad.Checked == true)
            {
                rol = 5;
                return true;
            }
            else if (rb_UsuarioFinal.Checked == true)
            {
                rol = 6;
                return true;
            }
            else
            {
                MessageBox.Show("No ha marcado ninguna opcion de rol", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
