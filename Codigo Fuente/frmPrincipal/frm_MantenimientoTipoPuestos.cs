﻿using System;
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
    public partial class frm_MantenimientoTipoPuestos : Form
    {
        tipoPuestos objTipoPuesto = new tipoPuestos();

        //Metodo que carga en el data grib view los campos que vienen desde la clase tipoPuesto
        private void carga_lista_EstatusFacturas()
        {
            try
            {

                dtg_ListaTipoPuesto.AutoGenerateColumns = false;
                dtg_ListaTipoPuesto.DataSource = objTipoPuesto.cargaListaTipoPuesto().Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public frm_MantenimientoTipoPuestos()
        {
            InitializeComponent();
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

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            this.carga_lista_EstatusFacturas();
        }

        private void frm_MantenimientoTipoPuestos_Load(object sender, EventArgs e)
        {
            this.carga_lista_EstatusFacturas();
        }

        private void b_editar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(dtg_ListaTipoPuesto.RowCount) == 0)
            {
                MessageBox.Show("No hay ningun estado de Factura en la lista", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frm_MantenimientoTipoPuestoNuevoEditar ventanaNuevoEditarTipoPuesto = new frm_MantenimientoTipoPuestoNuevoEditar();
            //ingresa en el campo id de la ventana ventanaNuevoEditarEstatusFactura el campo id que viene desde el data grid view
            ventanaNuevoEditarTipoPuesto.id = Convert.ToInt32(dtg_ListaTipoPuesto.CurrentRow.Cells[0].Value.ToString());
            ventanaNuevoEditarTipoPuesto.ShowDialog();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            frm_MantenimientoTipoPuestoNuevoEditar ventanaNuevoEditarTipoPuesto = new frm_MantenimientoTipoPuestoNuevoEditar();
            //cuenta la cantidad de estatus que hay en el data grid view y le suma 1 
            ventanaNuevoEditarTipoPuesto.num = Convert.ToInt32(dtg_ListaTipoPuesto.RowCount + 1);
            ventanaNuevoEditarTipoPuesto.ShowDialog();
        }
    }
}