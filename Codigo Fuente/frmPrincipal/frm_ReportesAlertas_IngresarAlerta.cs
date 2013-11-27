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
    public partial class frm_ReportesAlertas_IngresarAlerta : Form
    {
        //DECLARACION DE INSTANCIAS DE LAS CLASES
        UsuariosSistema objUsuariosSistema = new UsuariosSistema();
        Alertas objAlertas = new Alertas();

        //VARIABLES GLOBALES
        private string usuarioSistema = string.Empty;

        public frm_ReportesAlertas_IngresarAlerta()
        {
            InitializeComponent();
        }

        public frm_ReportesAlertas_IngresarAlerta(string usuario) : this()
        {
            this.usuarioSistema = usuario;
        }

        private void frm_ReportesAlertas_IngresarAlerta_Load(object sender, EventArgs e)
        {
            this.limiteCampos();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            frm_ReportesAlertas_MantenimientoComunicacion ventana = new frm_ReportesAlertas_MantenimientoComunicacion(usuarioSistema);
            this.Hide();
            ventana.Show();
        }

        //METODO LIMITE CAMPOS
        //RAFAEL ANGEL SEQUEIRA VARGAS
        public void limiteCampos()
        {
            txt_DetalleAlerta.MaxLength = 250;
        }
    }
}
