using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace frmPrincipal
{
    public partial class frm_Mantenimiento_0Menu : Form
    {
        public frm_Mantenimiento_0Menu()
        {
            InitializeComponent();
        }

        private void btn_estatusFactura_Click(object sender, EventArgs e)
        {
            frm_Mantenimiento_estatusFacturas ventanaMantenimientoEstadoFacturas = new frm_Mantenimiento_estatusFacturas();
            this.Hide();
            ventanaMantenimientoEstadoFacturas.ShowDialog();

        }

        private void btn_descripcionRoles_Click(object sender, EventArgs e)
        {
            frm_MantenimientoDescripcionRoles1 ventanaDescripcionRoles = new frm_MantenimientoDescripcionRoles1();
            this.Hide();
            ventanaDescripcionRoles.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_MantenimientoTipoPuestos ventanaTipoPuesto = new frm_MantenimientoTipoPuestos();
            this.Hide();
            ventanaTipoPuesto.ShowDialog();
        }

        private void btn_MantenimientoClienteProveedor_Click(object sender, EventArgs e)
        {
            frm_MantenimientoClienteProveedor ventana = new frm_MantenimientoClienteProveedor();
            this.Hide();
            ventana.ShowDialog();
        }

        private void btn_ManteniminetoTipoIdentificacion_Click(object sender, EventArgs e)
        {
            frm_MantenimientoTipoIdentificacion ventana = new frm_MantenimientoTipoIdentificacion();
            this.Hide();
            ventana.ShowDialog();
        }

        private void btn_MantenimientoDescripcionDepartamento_Click(object sender, EventArgs e)
        {
            frm_MantenimientoDescripcionDepartamento ventana = new frm_MantenimientoDescripcionDepartamento();
            this.Hide();
            ventana.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


    }
}
