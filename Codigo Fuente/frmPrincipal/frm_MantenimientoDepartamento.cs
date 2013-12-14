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
    public partial class frm_MantenimientoDepartamento : Form
    {
        //DECLARACION DE INSTANCIAS DE LAS CLASES
        UsuariosSistema objUsuariosSistema = new UsuariosSistema();
        DescripcionDepartamento objDescripcionDepartamentos = new DescripcionDepartamento();

        //VARIABLES GLOBALES
        private string usuarioSistema = string.Empty;
        private int Id = 0;

        public frm_MantenimientoDepartamento()
        {
            InitializeComponent();
        }

        public frm_MantenimientoDepartamento(string usuario) : this()
        {
            this.usuarioSistema = usuario;
        }

        private void frm_MantenimientoDescripcionDepartamento_Load(object sender, EventArgs e)
        {
            this.cargar_Lista_Descripcion_Departamentos();
            this.limiteCampos();
        }

        private void frm_MantenimientoDepartamento_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = e.CloseReason == CloseReason.UserClosing;
        }

        private void btn_limpiar_Click_1(object sender, EventArgs e)
        {
            this.limpia();
        }

        private void btn_Guardar_Click_1(object sender, EventArgs e)
        {
            if (this.validacionDeCampos() == true)
            {
                this.insertarDepartamento();
            }
        }

        private void btn_Cancelar_Click_1(object sender, EventArgs e)
        {
            frm_Mantenimiento_0Menu ventana = new frm_Mantenimiento_0Menu(usuarioSistema);

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

        //METODO
        //RAFAEL ANGEL SEQUEIRA VARGAS
        public void insertarDepartamento()
        {
            if (validarSoloLetras(txt_descripcion) == false)
            {
                MessageBox.Show("Ingrese Unicamente Letras para el campo de descripcion", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_descripcion.Focus();
                return;
            }

            objDescripcionDepartamentos.Descripcion = txt_descripcion.Text;
            objDescripcionDepartamentos.isDeleted = false;

            string accion = String.Empty;
            accion = "Insertar";

            if (objDescripcionDepartamentos.agregarActualiazarDescripcionDepartamentos(accion))
            {
                MessageBox.Show("Exito al guardar datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cargar_Lista_Descripcion_Departamentos();
                this.limpia();
            }
            else
            {
                MessageBox.Show("Error al guardar datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //METODO
        //RAFAEL ANGEL SEQUEIRA VARGAS
        public void updateDepartamento()
        {
            if (validarSoloLetras(txt_descripcion) == false)
            {
                MessageBox.Show("Ingrese Unicamente Letras para el campo de descripcion", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_descripcion.Focus();
                return;
            }

            objDescripcionDepartamentos.idDepartamento = Id;
            objDescripcionDepartamentos.Descripcion = txt_descripcion.Text;
            objDescripcionDepartamentos.isDeleted = false;

            string accion = String.Empty;
            accion = "Editar";

            if (objDescripcionDepartamentos.agregarActualiazarDescripcionDepartamentos(accion))
            {
                MessageBox.Show("Exito al actualizar datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cargar_Lista_Descripcion_Departamentos();
                this.limpia();
            }
            else
            {
                MessageBox.Show("Error al guardar datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //METODO
        //RAFAEL ANGEL SEQUEIRA VARGAS
        public void eliminarDepartamento()
        {
            objDescripcionDepartamentos.idDepartamento = Id;
            if (objDescripcionDepartamentos.eliminarDescripcionDepartamento())
            {
                MessageBox.Show("Exito al eliminar datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cargar_Lista_Descripcion_Departamentos();
            }
            else
            {
                MessageBox.Show("Error al eliminar datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //METODO
        //RAFAEL ANGEL SEQUEIRA VARGAS
        private void cargar_Lista_Descripcion_Departamentos()
        {
            try
            {
                dtg_Departamentos.AutoGenerateColumns = false;
                dtg_Departamentos.DataSource = objDescripcionDepartamentos.cargarDescripcionDepartamentos().Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //METODO
        //RAFAEL ANGEL SEQUEIRA VARGAS
        private void limpia()
        {
            Limpieza.limpiar(txt_descripcion);
        }

        //METODO
        //RAFAEL ANGEL SEQUEIRA VARGAS
        public void limiteCampos()
        {
            txt_descripcion.MaxLength = 50;
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
        public bool validacionDeCampos()
        {
            if (!Validaciones.validar(txt_descripcion))
            {
                MessageBox.Show("No ingreso descripcion", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_descripcion.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void dtg_Departamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Editar.Index && e.RowIndex >= 0)
            {
                Id = Convert.ToInt32(dtg_Departamentos.Rows[e.RowIndex].Cells[0].Value.ToString());

                if ((MessageBox.Show("Desea editar este cliente?", "Edicion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (this.validacionDeCampos() == true)
                    {
                        this.updateDepartamento();
                    }
                }
                else
                {
                    return;
                }
            }
            else if (e.ColumnIndex == Eliminar.Index && e.RowIndex >= 0)
            {
                Id = Convert.ToInt32(dtg_Departamentos.Rows[e.RowIndex].Cells[0].Value.ToString());

                if ((MessageBox.Show("Desea eliminar este cliente?", "Edicion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    this.eliminarDepartamento();
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

