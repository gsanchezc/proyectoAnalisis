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
    public partial class frm_RRHH_NuevaSolicitudVacaciones : Form
    {
        public frm_RRHH_NuevaSolicitudVacaciones()
        {
            InitializeComponent();
        }

        RRHH_SolicitudVacaciones objVacaciones = new RRHH_SolicitudVacaciones();
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Desea salir sin generar factura", "Volver al Menu Principal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                frm_0MenuPrincipal ventana = new frm_0MenuPrincipal();
                this.Close();
                ventana.Show();
            }
            else
            {
                return;
            }
        }

        private void frm_RRHH_NuevaSolicitudVacaciones_Load(object sender, EventArgs e)
        {
            this.cargarListaEmpleados();
        }

        private void cargarListaEmpleados()
        {
            try
            {
                DataSet ds;
                ds = objVacaciones.cargarListaEmpleados();
                cmb_Identificacion.DataSource = ds.Tables[0];
                cmb_Identificacion.DisplayMember = ds.Tables[0].Columns["identificacion"].ColumnName.ToString();
                cmb_Identificacion.ValueMember = ds.Tables[0].Columns["idEmpleado"].ColumnName.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void calculos()
        { 
            
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {

        }
    }
}
