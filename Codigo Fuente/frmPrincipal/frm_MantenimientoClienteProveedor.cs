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
    public partial class frm_MantenimientoClienteProveedor : Form
    {
        public frm_MantenimientoClienteProveedor()
        {
            InitializeComponent();
        }

        ClienteProveedor objClienteProveedor = new ClienteProveedor();

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {

            frm_0MenuPrincipal ventana = new frm_0MenuPrincipal();

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

        private void frm_MantenimientoClienteProveedor_Load(object sender, EventArgs e)
        {
            this.cargar_lista_cliente_proveedores();
        }

        private void cargar_lista_cliente_proveedores()
        {
            try
            {
                dtg_ClienteProveedor.AutoGenerateColumns = false;
                dtg_ClienteProveedor.DataSource = objClienteProveedor.cargarClienteProveedor().Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txt_idClienteProveedor.Text = "0";
        }

        private void dtg_ClienteProveedor_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.limpia();
            DataGridView thisGrid = (DataGridView)sender;
            DataTable table = (DataTable)thisGrid.DataSource;
            DataRow currenRow = table.Rows[thisGrid.CurrentCell.RowIndex];
            txt_idClienteProveedor.Text = currenRow["idTipoClienteProveedor"].ToString();
            txt_nombreClienteProveedor.Text = currenRow["descripcion"].ToString();


        }

        public void limpia()
        {
            txt_idClienteProveedor.Text = "0";
            txt_nombreClienteProveedor.Clear();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            this.limpia();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {

            if (!Validaciones.esentero(txt_idClienteProveedor))
            {
                MessageBox.Show("El ID debe ser de tipo entero", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_idClienteProveedor.Focus();
                return;
            }

            if (!Validaciones.validar(txt_nombreClienteProveedor))
            {
                MessageBox.Show("Por favor ingrese una descripcion", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nombreClienteProveedor.Focus();
                return;
            }
            objClienteProveedor.Id = Convert.ToInt32(txt_idClienteProveedor.Text);
            objClienteProveedor.Descripcion = txt_nombreClienteProveedor.Text;

            if ((Convert.ToInt32(txt_idClienteProveedor.Text)) != 0)
            {
                if (objClienteProveedor.agregarActualiazarClienteProveedor("Actualizar"))
                {
                    MessageBox.Show("El cliente Proveedor se actualizó con exito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (objClienteProveedor.agregarActualiazarClienteProveedor("Insertar"))
                {
                    MessageBox.Show("El cliente Proveedor se agrego con exito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            this.cargar_lista_cliente_proveedores();
            this.limpia();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (!Validaciones.esentero(txt_idClienteProveedor))
            {
                MessageBox.Show("El ID debe ser de tipo entero", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_idClienteProveedor.Focus();
                return;
            }

            if (!Validaciones.validar(txt_nombreClienteProveedor))
            {
                MessageBox.Show("Por favor ingrese una descripcion", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nombreClienteProveedor.Focus();
                return;
            }
            objClienteProveedor.Id = Convert.ToInt32(txt_idClienteProveedor.Text);
            objClienteProveedor.Descripcion = txt_nombreClienteProveedor.Text;

            objClienteProveedor.eliminarClienteProveedor();
            MessageBox.Show("El cliente Proveedor se eliminó con exito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.cargar_lista_cliente_proveedores();
            this.limpia();
        }

    }

}

