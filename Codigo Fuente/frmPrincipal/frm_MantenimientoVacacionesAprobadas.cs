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
    public partial class frm_MantenimientoVacacionesAprobadas : Form
    {
        //DECLARACION DE INSTANCIAS DE LAS CLASES
        UsuariosSistema objUsuariosSistema = new UsuariosSistema();

        //VARIABLES GLOBALES
        private string usuarioSistema = string.Empty;
        private int Id = 0;

        public frm_MantenimientoVacacionesAprobadas()
        {
            InitializeComponent();
        }

        public frm_MantenimientoVacacionesAprobadas(string usuario)
            : this()
        {
            this.usuarioSistema = usuario;
        }

        private void frm_MantenimientoVacacionesAprobadas_Load(object sender, EventArgs e)
        {
            
        }

        private void frm_MantenimientoVacacionesAprobadas_FormClosing(object sender, FormClosingEventArgs e)
        {

            e.Cancel = e.CloseReason == CloseReason.UserClosing;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {

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

        private void dtg_VacacionesAprobadas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
