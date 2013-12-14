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
    public partial class frm_RRHH_NuevaNomina : Form
    {

        UsuariosSistema objUsuariosSistema = new UsuariosSistema();
        RRHH_SolicitudVacaciones objVacaciones = new RRHH_SolicitudVacaciones();
        RRHH_Nomina objNomina = new RRHH_Nomina();
        private string usuarioSistema = string.Empty;
        private int rolUsuario;
        public frm_RRHH_NuevaNomina()
        {
            InitializeComponent();
        }

           private void cargarListaEmpleados()
        {
            try
            {
                DataSet ds;
                ds = objVacaciones.cargarListaEmpleados();
                cmb_empleado.DataSource = ds.Tables[0];
                cmb_empleado.DisplayMember = ds.Tables[0].Columns["identificacion"].ColumnName.ToString();
                cmb_empleado.ValueMember = ds.Tables[0].Columns["idEmpleado"].ColumnName.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void frm_RRHH_NuevaNomina_Load(object sender, EventArgs e)
        {
            this.cargarListaEmpleados();
            this.rolesUsuarios();
        }

        private void rolesUsuarios()
        {
            txt_horasLaborada.Enabled = true;
            txt_hrsExtra.Enabled = true;
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            this.calcular();
        }

        private void calcular()
        {

            if (!Validaciones.validar(cmb_anio))
            {
                MessageBox.Show("Por favor seleccione el año", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmb_anio.Focus();
                return;
            }
            if (!Validaciones.validar(cmb_mes))
            {
                MessageBox.Show("Por favor seleccione un mes", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmb_mes.Focus();
                return;
            }
            else
            {
                try
                {

                    //Calculo del salario del empleado
                    objNomina.IdEmpleado = Convert.ToInt32(cmb_empleado.SelectedValue.ToString());
                    DataSet ds;
                    ds = objNomina.cargarSalario();
                    txt_salarioBase.Text = ds.Tables[0].Rows[0][0].ToString();
                    if (Convert.ToInt32(txt_hrsExtra.Text) > 0)
                    {
                        decimal extras = ((Convert.ToDecimal(txt_salarioBase.Text)) / (Convert.ToDecimal(txt_horasLaborada.Text)));
                        extras = (extras * (Convert.ToDecimal(txt_hrsExtra.Text)));
                        txt_SalarioBruto.Text = (Convert.ToDecimal(txt_salarioBase.Text) + extras).ToString();
                    }
                    else
                    {
                        txt_SalarioBruto.Text = txt_salarioBase.Text;
                    }
                    txt_fondoPensiones.Text = ((Convert.ToDecimal(txt_SalarioBruto.Text)) * ((Convert.ToDecimal(0.01)))).ToString();
                    txt_ccss.Text = (Convert.ToDecimal(txt_SalarioBruto.Text) * (Convert.ToDecimal(0.09))).ToString();
                    txt_totaldeducciones.Text = (((Convert.ToDecimal(txt_fondoPensiones.Text)) + (Convert.ToDecimal(txt_ccss.Text)))).ToString();
                    txt_salarioNeto.Text = ((Convert.ToDecimal(txt_SalarioBruto.Text) - (Convert.ToDecimal(txt_totaldeducciones.Text)))).ToString();

                    //Busca registro de nomina repetida en BD
                    objNomina.IdEmpleado = Convert.ToInt32(cmb_empleado.SelectedValue.ToString());
                    objNomina.Mes = Convert.ToString(cmb_mes.SelectedItem.ToString());
                    objNomina.Anio = Convert.ToInt32(cmb_anio.SelectedItem.ToString());
                    ds = objNomina.buscarNomina();
                    int numeroLineas = 0;
                    foreach(DataRow dr in ds.Tables[0].Rows)
                    {
                        numeroLineas++;
                    }
                    
                    if (numeroLineas == 0)
                    {
                        //Ingresa el registro en BD
                        objNomina.IdEmpleado = Convert.ToInt32(cmb_empleado.SelectedValue.ToString());
                        objNomina.Mes = Convert.ToString(cmb_mes.SelectedItem.ToString());
                        objNomina.Anio = Convert.ToInt32(cmb_anio.SelectedItem.ToString());
                        objNomina.HrsLaboradas = Convert.ToInt32(txt_horasLaborada.Text);
                        objNomina.HrsExtra = Convert.ToInt32(txt_hrsExtra.Text);
                        objNomina.Salario = Convert.ToDecimal(txt_salarioBase.Text);
                        objNomina.SalarioBruto = Convert.ToDecimal(txt_SalarioBruto.Text);
                        objNomina.SalarioNeto = Convert.ToDecimal(txt_salarioNeto.Text);
                        bool estado = objNomina.IngresarNuevoRegistroNomina();
                        if (estado)
                        {
                            MessageBox.Show("Se ingreso la nomina del empleado", "Actualizacion de Nomina", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("La nomina de ese empleado en este mes y año ya fue ingresada", "Error al ingresar Nomina", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
                catch (Exception)
                {
                    MessageBox.Show("Error al calcular el salario del empleado", "Calculo de Salario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Desea salir sin generar nueva nomina", "Volver al Menu Nomina", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                frm_RRHH_ControlNomina ventanaNomina = new frm_RRHH_ControlNomina(usuarioSistema);
                this.Close();
                ventanaNomina.Show();
            }
            else
            {
                return;
            }
        }
    }
}
