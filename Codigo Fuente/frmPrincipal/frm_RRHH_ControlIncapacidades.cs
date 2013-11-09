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
    public partial class frm_RRHH_ControlIncapacidades : Form
    {
        public frm_RRHH_ControlIncapacidades()
        {
            InitializeComponent();
        }

        RRHH_incapacidades objRRHHIcapacidades = new RRHH_incapacidades();
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Desea volver al Menu Principal", "Volver al Menu Principal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                frm_0MenuPrincipal ventanaMenuPrincipal = new frm_0MenuPrincipal();
                this.Close();
                ventanaMenuPrincipal.Show();
            }
            else
            {
                return;
            }
        }

        private void frm_RRHH_ControlIncapacidades_Load(object sender, EventArgs e)
        {
            this.cargar_lista_incapacidades();
        }

        public void cargar_lista_incapacidades()
        {
            try
            {
                dtg_Incapacidades.AutoGenerateColumns = false;
                dtg_Incapacidades.DataSource = objRRHHIcapacidades.cargarListaIncapacidades().Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
