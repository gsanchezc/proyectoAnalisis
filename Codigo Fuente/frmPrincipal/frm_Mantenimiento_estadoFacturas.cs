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
    public partial class frm_Mantenimiento_estatusFacturas : Form
    {
        estatusFactura objEstatusFactura = new estatusFactura();

        public frm_Mantenimiento_estatusFacturas()
        {
            InitializeComponent();
        }
        //Metodo que carga en el data grib view los campos que vienen desde la clase objEstatusFactura
        private void carga_lista_EstatusFacturas()
        {
            try
            {

                dtg_ListaEstadoFactura.AutoGenerateColumns = false;
                dtg_ListaEstadoFactura.DataSource = objEstatusFactura.cargaListaEstadosFactura().Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
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

        private void frm_Mantenimiento_estatusFacturas_Load(object sender, EventArgs e)
        {
            this.carga_lista_EstatusFacturas();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            this.carga_lista_EstatusFacturas();
        }

        private void b_editar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(dtg_ListaEstadoFactura.RowCount) == 0)
            {
                MessageBox.Show("No hay ningun estado de Factura en la lista", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frm_MantenimientoEstadoFacturaNuevoEditar ventanaNuevoEditarEstatusFactura = new frm_MantenimientoEstadoFacturaNuevoEditar();
            //ingresa en el campo id de la ventana ventanaNuevoEditarEstatusFactura el campo id que viene desde el data grid view
            ventanaNuevoEditarEstatusFactura.id = Convert.ToInt32(dtg_ListaEstadoFactura.CurrentRow.Cells[0].Value.ToString());
            ventanaNuevoEditarEstatusFactura.ShowDialog();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            frm_MantenimientoEstadoFacturaNuevoEditar ventanaNuevoEditarEstatusFactura = new frm_MantenimientoEstadoFacturaNuevoEditar();
            //cuenta la cantidad de estatus que hay en el data grid view y le suma 1 
            ventanaNuevoEditarEstatusFactura.num = Convert.ToInt32(dtg_ListaEstadoFactura.RowCount + 1);
            ventanaNuevoEditarEstatusFactura.ShowDialog();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            string idEstado = string.Empty;
            idEstado = dtg_ListaEstadoFactura.CurrentRow.Cells[0].Value.ToString();
            if (MessageBox.Show("Desea eliminar el estatus con el ID : " + idEstado, "Confirmacion de borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (objEstatusFactura.eliminarEstatusFactura(Convert.ToInt32(idEstado)))
                {
                    MessageBox.Show("El estatus de factura se eliminó con exito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.carga_lista_EstatusFacturas();

                }
            }
        }
    }
}
