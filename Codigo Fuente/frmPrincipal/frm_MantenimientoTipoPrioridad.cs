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
    public partial class frm_MantenimientoTipoPrioridad : Form
    {
        //DECLARACION DE INSTANCIAS DE LAS CLASES
        UsuariosSistema objUsuariosSistema = new UsuariosSistema();
        TipoPrioridad objTipoPrioridad = new TipoPrioridad();

        //VARIABLES GLOBALES
        private string usuarioSistema = string.Empty;

        public frm_MantenimientoTipoPrioridad()
        {
            InitializeComponent();
        }

        public frm_MantenimientoTipoPrioridad(string usuario) : this()
        {
            this.usuarioSistema = usuario;
        }

        private void frm_MantenimientoTipoPrioridad_Load(object sender, EventArgs e)
        {
            this.cargar_Tipo_prioridad();
            this.limpia();
        }

        private void cargar_Tipo_prioridad()
        {
            try
            {

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void limpia()
        {

        }

        private void dtg_TipoPrioridad_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

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
                this.Close();
                ventana.Show();
            }
            else
            {
                return;
            }
        }
    }
}
