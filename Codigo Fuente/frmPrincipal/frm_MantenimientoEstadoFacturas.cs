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
        //DECLARACION DE INSTANCIAS DE LAS CLASES
        UsuariosSistema objUsuariosSistema = new UsuariosSistema();

        //VARIABLES GLOBALES
        private string usuarioSistema = string.Empty;

        estatusFactura objEstatusFactura = new estatusFactura();

        public frm_Mantenimiento_estatusFacturas()
        {
            InitializeComponent();
        }

        public frm_Mantenimiento_estatusFacturas(string usuario) : this()
        {
            this.usuarioSistema = usuario;
        }

        private void frm_Mantenimiento_estatusFacturas_Load(object sender, EventArgs e)
        {
            this.carga_lista_EstatusFacturas();
        }

        //Metodo que carga en el data grib view los campos que vienen desde la clase objEstatusFactura
        private void carga_lista_EstatusFacturas()
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

        private void btn_cerrar_Click(object sender, EventArgs e)
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

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            this.carga_lista_EstatusFacturas();
        }

        private void b_editar_Click(object sender, EventArgs e)
        {

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
