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
        //DECLARACION DE INSTANCIAS DE LAS CLASES
        UsuariosSistema objUsuariosSistema = new UsuariosSistema();
        RRHH_SolicitudVacaciones objVacaciones = new RRHH_SolicitudVacaciones();

        //VARIABLES GLOBALES
        private string usuarioSistema = string.Empty;
        private int rolUsuario;
        private int VacacionesID = 0;

        public frm_RRHH_NuevaSolicitudVacaciones()
        {
            InitializeComponent();
        }

        public frm_RRHH_NuevaSolicitudVacaciones(String usuario, int vacaciones):this()
        {
            this.usuarioSistema = usuario;
            this.VacacionesID = vacaciones;
        }

        public frm_RRHH_NuevaSolicitudVacaciones(string usuario) : this()
        {
            this.usuarioSistema = usuario;
        }

        private void frm_RRHH_NuevaSolicitudVacaciones_Load(object sender, EventArgs e)
        {
            this.cargaRolUsuario();
            this.rolesUsuario();
            this.cargarListaEmpleados();
        }

        //METODO PARA MANEJAR EL ACCESO POR ROLES
        //RAFAEL ANGEL SEQUEIRA VARGAS
        public void cargaRolUsuario()
        {
            this.cargarListaEmpleados();
            objUsuariosSistema.cargaRolUsuario(usuarioSistema);
            rolUsuario = objUsuariosSistema.idRol;
        }

        //METODO PARA MANEJAR EL ACCESO POR ROLES
        //RAFAEL ANGEL SEQUEIRA VARGAS
        public void rolesUsuario()
        {

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Desea salir sin generar factura", "Volver al Menu Principal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                frm_0MenuPrincipal ventana = new frm_0MenuPrincipal(usuarioSistema);
                this.Close();
                ventana.Show();
            }
            else
            {
                return;
            }
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
            decimal diasSolitados;
            decimal diasDisponibles;
            //dias solicitados
            DateTime oldDate = Convert.ToDateTime(dtp_FechaSalida.Value.Date);
            DateTime newDate = Convert.ToDateTime(dtp_FechaRegreso.Value.Date);
            TimeSpan ts = newDate - oldDate;
            diasSolitados = Convert.ToDecimal(ts.TotalDays.ToString());
            txt_DiasSolicitados.Text = ts.TotalDays.ToString();
            if (diasSolitados < 0)
            {
                txt_DiasSolicitados.Text = "0";
                MessageBox.Show("La fecha de salida debe de ser menor a la fecha de entrada", "Validación de Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtp_FechaRegreso.ResetText();
                dtp_FechaSalida.ResetText();
                dtp_FechaSalida.Focus();
            }



            //Calculo de dias disponibles
            objVacaciones.IdEmpleado = Convert.ToInt32(cmb_Identificacion.SelectedValue.ToString());
            DataSet ds;
            ds = objVacaciones.CargarVacacionesDisponibles();
            txt_DiasDisponibles.Text = Convert.ToString(ds.Tables[0].Rows[0][0]);

            //dias 
            diasSolitados = Convert.ToDecimal(txt_DiasSolicitados.Text);
            diasDisponibles = Convert.ToDecimal(txt_DiasDisponibles.Text);
            txt_SaldoDias.Text = (diasDisponibles - diasSolitados).ToString();
            if ((diasDisponibles - diasSolitados) < 0)
            {
                txt_SaldoDias.Text = "0";
                MessageBox.Show("No puede solicitar " + diasSolitados + " de Vacaciones \n Solo cuenta con " + diasDisponibles + " días disponibles", "Validación de Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtp_FechaRegreso.ResetText();
                dtp_FechaSalida.ResetText();
                dtp_FechaSalida.Focus();
                this.calculos();
            }
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            if (!Validaciones.validar(txt_DiasDisponibles))
            {
                MessageBox.Show("Por favor ingrese una fecha", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtp_FechaSalida.Focus();
                return;
            }
            if (!Validaciones.validar(txt_DiasSolicitados))
            {
                MessageBox.Show("Por favor ingrese una fecha", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtp_FechaSalida.Focus();
                return;
            }
            if (!Validaciones.validar(txt_SaldoDias))
            {
                MessageBox.Show("Por favor ingrese una fecha", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtp_FechaSalida.Focus();
                return;
            }
            else
            {
                objVacaciones.IdEmpleado = Convert.ToInt32(cmb_Identificacion.SelectedValue.ToString());
                objVacaciones.FechaInicio = Convert.ToDateTime(dtp_FechaSalida.Text);
                objVacaciones.FechaFin = Convert.ToDateTime(dtp_FechaRegreso.Text);
                objVacaciones.DiasSolicitados = Convert.ToInt32(txt_DiasSolicitados.Text);
                bool estado = objVacaciones.IngresarSolicitudVacaciones();
                if (estado)
                {
                    MessageBox.Show("Sus vacaciones han sido ingresadas correctamente", "Guardado Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.limpia();
                }
            }
        }

        private void frm_RRHH_NuevaSolicitudVacaciones_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = e.CloseReason == CloseReason.UserClosing;
        }

        private void btn_Validar_Click(object sender, EventArgs e)
        {
            this.calculos();
        }

        private void limpia()
        {
            dtp_FechaRegreso.ResetText();
            dtp_FechaSalida.ResetText();
            txt_DiasDisponibles.Clear();
            txt_DiasSolicitados.Clear();
            txt_SaldoDias.Clear();
        }
      }
}
