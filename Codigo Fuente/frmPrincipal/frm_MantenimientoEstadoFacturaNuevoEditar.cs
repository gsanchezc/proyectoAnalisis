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
    public partial class frm_MantenimientoEstadoFacturaNuevoEditar : Form
    {
        //DECLARACION DE INSTANCIAS DE LAS CLASES
        UsuariosSistema objUsuariosSistema = new UsuariosSistema();
        estatusFactura objEstatusFactura = new estatusFactura();

        //VARIABLES GLOBALES
        private string usuarioSistema = string.Empty;     

        private int _id;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        private int _num;

        public int num
        {
            get { return _num; }
            set { _num = value; }
        }

        public frm_MantenimientoEstadoFacturaNuevoEditar()
        {
            InitializeComponent();
        }

        public frm_MantenimientoEstadoFacturaNuevoEditar(string usuario) : this()
        {
            this.usuarioSistema = usuario;
        }

        private void frm_MantenimientoEstadoFacturaNuevoEditar_Load(object sender, EventArgs e)
        {
            if (_id != 0)
            {

                this.carga_info();
            }
            else
            {
                txt_Id.Text = num.ToString();
            }
        }

        //Metodo que carga la informacion que viene del data grid view en la ventana frm_MantenimientoEstadoFacturaNuevoEditar
        private void carga_info()
        {
            objEstatusFactura.cargaInfoEstadoFactura(_id);

            txt_Id.Text = _id.ToString();
            txt_Descripcion.Text = objEstatusFactura._descripcion;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if(!Validaciones.esentero(txt_Id))
            {
                MessageBox.Show("El ID debe ser de tipo entero", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Id.Focus();
                return;
            }

            if (!Validaciones.validar(txt_Descripcion))
            {
                MessageBox.Show("Por favor ingrese una descripcion", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Descripcion.Focus();
                return;
            }
            objEstatusFactura._id = Convert.ToInt32(txt_Id.Text);
            objEstatusFactura._descripcion = txt_Descripcion.Text;

            if (_id != 0)
            {
                if (objEstatusFactura.agregarActualizarEstadoFactura("Actualizar"))
                {
                    MessageBox.Show("El estatus se agrego con exito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                if (objEstatusFactura.agregarActualizarEstadoFactura("Insertar"))
                {
                    MessageBox.Show("El estatus se agrego con exito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            frm_Mantenimiento_estatusFacturas ventana = new frm_Mantenimiento_estatusFacturas();
            this.Close();
            ventana.Show();
        }
    }
}
