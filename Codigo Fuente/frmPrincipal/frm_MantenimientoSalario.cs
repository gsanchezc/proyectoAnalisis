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
    public partial class frm_MantenimientoSalario : Form
    {
        //DECLARACION DE INSTANCIAS DE LAS CLASES
        UsuariosSistema objUsuariosSistema = new UsuariosSistema();
        Salarios objSalario = new Salarios();

        //VARIABLES GLOBALES
        private string usuarioSistema = string.Empty;
        private int Id = 0;

        public frm_MantenimientoSalario()
        {
            InitializeComponent();
        }

        public frm_MantenimientoSalario(string usuario)
            : this()
        {
            this.usuarioSistema = usuario;
        }

        private void frm_MantenimientoSalario_Load(object sender, EventArgs e)
        {
            this.cargar_ListaSalarios();
            this.limiteCampos();
        }

        private void frm_MantenimientoSalario_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = e.CloseReason == CloseReason.UserClosing;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (this.validacionDeCampos() == true)
            {
                this.insertarSalario();
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            this.limpia();
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

        private void dtg_Salarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Editar.Index && e.RowIndex >= 0)
            {
                Id = Convert.ToInt32(dtg_Salarios.Rows[e.RowIndex].Cells[0].Value.ToString());

                if ((MessageBox.Show("Desea editar este cliente?", "Edicion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (this.validacionDeCampos() == true)
                    {
                        this.updateSalario();
                    }
                }
                else
                {
                    return;
                }
            }
            else if (e.ColumnIndex == Eliminar.Index && e.RowIndex >= 0)
            {
                Id = Convert.ToInt32(dtg_Salarios.Rows[e.RowIndex].Cells[0].Value.ToString());

                if ((MessageBox.Show("Desea eliminar este cliente?", "Edicion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    this.eliminarSalario();
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
        public void insertarSalario()
        {
            if (validarSoloNumeros(txt_monto) == false)
            {
                MessageBox.Show("Ingrese Unicamente numeros", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_monto.Focus();
                return;
            }

            objSalario.monto = Convert.ToDecimal(txt_monto.Text);
            objSalario.isDeleted = false;

            string accion = String.Empty;
            accion = "Insertar";

            if (objSalario.agregarActualizarSalario(accion))
            {
                MessageBox.Show("Exito al guardar datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cargar_ListaSalarios();
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
        public void updateSalario()
        {
            if (validarSoloNumeros(txt_monto) == false)
            {
                MessageBox.Show("Ingrese Unicamente numeros", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_monto.Focus();
                return;
            }

            objSalario.idSalario = Id;
            objSalario.monto = Convert.ToDecimal(txt_monto.Text);
            objSalario.isDeleted = false;

            string accion = String.Empty;
            accion = "Editar";

            if (objSalario.agregarActualizarSalario(accion))
            {
                MessageBox.Show("Exito al actualizar datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cargar_ListaSalarios();
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
        public void eliminarSalario()
        {
            objSalario.idSalario = Id;
            if (objSalario.eliminarSalario())
            {
                MessageBox.Show("Exito al eliminar datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cargar_ListaSalarios();
            }
            else
            {
                MessageBox.Show("Error al eliminar datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //METODO
        //RAFAEL ANGEL SEQUEIRA VARGAS
        private void cargar_ListaSalarios()
        {
            try
            {
                dtg_Salarios.AutoGenerateColumns = false;
                dtg_Salarios.DataSource = objSalario.cargaListaSalarios().Tables[0];
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
            Limpieza.limpiar(txt_monto);
        }

        //METODO
        //RAFAEL ANGEL SEQUEIRA VARGAS
        public void limiteCampos()
        {
            txt_monto.MaxLength = 10;
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
            if (!Validaciones.validar(txt_monto))
            {
                MessageBox.Show("No ingreso monto", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_monto.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
