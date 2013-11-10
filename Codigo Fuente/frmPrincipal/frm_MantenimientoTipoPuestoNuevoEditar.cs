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
    public partial class frm_MantenimientoTipoPuestoNuevoEditar : Form
    {
        //DECLARACION DE INSTANCIAS DE LAS CLASES
        UsuariosSistema objUsuariosSistema = new UsuariosSistema();
        tipoPuestos objTipoPuesto = new tipoPuestos();

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

        public frm_MantenimientoTipoPuestoNuevoEditar()
        {
            InitializeComponent();
        }

        public frm_MantenimientoTipoPuestoNuevoEditar(string usuario) : this()
        {
            this.usuarioSistema = usuario;
        }

        private void frm_MantenimientoTipoPuestoNuevoEditar_Load(object sender, EventArgs e)
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

        //Metodo que carga la informacion que viene del data grid view en la ventana frm_MantenimientoTipoPuestoNuevoEditar
        private void carga_info()
        {
            objTipoPuesto.cargaInfoTipoPuesto(_id);

            txt_Id.Text = _id.ToString();
            txt_Descripcion.Text = objTipoPuesto._descripcion;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (!Validaciones.esentero(txt_Id))
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
            objTipoPuesto._id = Convert.ToInt32(txt_Id.Text);
            objTipoPuesto._descripcion = txt_Descripcion.Text;

            if (_id != 0)
            {
                if (objTipoPuesto.agregarActualizarTipoPuesto("Actualizar"))
                {
                    MessageBox.Show("La descripcion tipo Puesto se agrego con exito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                if (objTipoPuesto.agregarActualizarTipoPuesto("Insertar"))
                {
                    MessageBox.Show("La descripcion tipo Puesto se agrego con exito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            frm_MantenimientoTipoPuestos ventana = new frm_MantenimientoTipoPuestos();
            this.Close();
            ventana.Show();
        }
    }
}
