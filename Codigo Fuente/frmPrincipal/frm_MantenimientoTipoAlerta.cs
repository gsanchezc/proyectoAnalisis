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
    public partial class frm_MantenimientoTipoAlerta : Form
    {
        //DECLARACION DE INSTANCIAS DE LAS CLASES
        UsuariosSistema objUsuariosSistema = new UsuariosSistema();
        TipoAlertas objTipoAlerta = new TipoAlertas();

        //VARIABLES GLOBALES
        private string usuarioSistema = string.Empty;
        private int Id = 0;

        public frm_MantenimientoTipoAlerta()
        {
            InitializeComponent();
        }

        public frm_MantenimientoTipoAlerta(string usuario)
            : this()
        {
            this.usuarioSistema = usuario;
        }

        private void frm_MantenimientoTipoAlerta_Load(object sender, EventArgs e)
        {
            this.cargar_ListaTipoAlerta();
            this.limiteCampos();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (this.validacionDeCampos() == true)
            {
                this.insertarTipoAlerta();
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

        private void dtg_TipoAlertas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Editar.Index && e.RowIndex >= 0)
            {
                Id = Convert.ToInt32(dtg_TipoAlertas.Rows[e.RowIndex].Cells[0].Value.ToString());

                if ((MessageBox.Show("Desea editar este cliente?", "Edicion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (this.validacionDeCampos() == true)
                    {
                        this.updateTipoAlerta();
                    }
                }
                else
                {
                    return;
                }
            }
            else if (e.ColumnIndex == Eliminar.Index && e.RowIndex >= 0)
            {
                Id = Convert.ToInt32(dtg_TipoAlertas.Rows[e.RowIndex].Cells[0].Value.ToString());

                if ((MessageBox.Show("Desea eliminar este cliente?", "Edicion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    this.eliminarTipoAlerta();
                }
                else
                {
                    return;
                }
            }
            else { }
        }

        private void frm_MantenimientoTipoAlerta_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = e.CloseReason == CloseReason.UserClosing;
        }

        //METODO
        //RAFAEL ANGEL SEQUEIRA VARGAS
        public void insertarTipoAlerta()
        {
            if (validarSoloLetras(txt_descripcion) == false)
            {
                MessageBox.Show("Ingrese Unicamente Letras para el campo de descripcion", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_descripcion.Focus();
                return;
            }

            objTipoAlerta.descripcion = txt_descripcion.Text;
            objTipoAlerta.isDeleted = false;

            string accion = String.Empty;
            accion = "Insertar";

            if (objTipoAlerta.agregarActualizarTipoAlerta(accion))
            {
                MessageBox.Show("Exito al guardar datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cargar_ListaTipoAlerta();
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
        public void updateTipoAlerta()
        {
            if (validarSoloLetras(txt_descripcion) == false)
            {
                MessageBox.Show("Ingrese Unicamente Letras para el campo de descripcion", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_descripcion.Focus();
                return;
            }

            objTipoAlerta.idTipoAlerta = Id;
            objTipoAlerta.descripcion = txt_descripcion.Text;
            objTipoAlerta.isDeleted = false;

            string accion = String.Empty;
            accion = "Editar";

            if (objTipoAlerta.agregarActualizarTipoAlerta(accion))
            {
                MessageBox.Show("Exito al actualizar datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cargar_ListaTipoAlerta();
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
        public void eliminarTipoAlerta()
        {
            objTipoAlerta.idTipoAlerta = Id;
            if (objTipoAlerta.eliminarTipoAlerta())
            {
                MessageBox.Show("Exito al eliminar datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cargar_ListaTipoAlerta();
            }
            else
            {
                MessageBox.Show("Error al eliminar datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //METODO
        //RAFAEL ANGEL SEQUEIRA VARGAS
        private void cargar_ListaTipoAlerta()
        {
            try
            {
                dtg_TipoAlertas.AutoGenerateColumns = false;
                dtg_TipoAlertas.DataSource = objTipoAlerta.cargarTipoAlerta().Tables[0];
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
    }
}
