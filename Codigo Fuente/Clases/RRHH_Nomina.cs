using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DAL;
using System.Windows.Forms;

namespace Clases
{
    public class RRHH_Nomina
    {

        #region Propiedades
        private int _idEmpleado;

        public int IdEmpleado
        {
            get { return _idEmpleado; }
            set { _idEmpleado = value; }
        }

        private string _mes;

        public string Mes
        {
            get { return _mes; }
            set { _mes = value; }
        }

        private int _anio;

        public int Anio
        {
            get { return _anio; }
            set { _anio = value; }
        }

        private int _hrsLaboradas;

        public int HrsLaboradas
        {
            get { return _hrsLaboradas; }
            set { _hrsLaboradas = value; }
        }

        private int _hrsExtra;

        public int HrsExtra
        {
            get { return _hrsExtra; }
            set { _hrsExtra = value; }
        }

        private decimal _salario;

        public decimal Salario
        {
            get { return _salario; }
            set { _salario = value; }
        }

        private decimal _salarioBruto;

        public decimal SalarioBruto
        {
            get { return _salarioBruto; }
            set { _salarioBruto = value; }
        }

        private decimal _rebajos;

        public decimal Rebajos
        {
            get { return _rebajos; }
            set { _rebajos = value; }
        }

        private decimal _salarioNeto;

        public decimal SalarioNeto
        {
            get { return _salarioNeto; }
            set { _salarioNeto = value; }
        }
        #endregion

        #region variables
        SqlConnection conexion;
        string sql;
        string mensaje_error;
        int numero_error;
        DataSet ds;
        #endregion

        #region metodos

        public DataSet cargarSalario()
        {
            conexion = cls_DAL.trae_conexion("Soportic", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {

                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            else
            {
                sql = "stp_salarioEmpleado";
                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@idEmpleado", SqlDbType.Int, _idEmpleado);
                ds = cls_DAL.ejecuta_dataset(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                {
                    return ds;
                }
            }
        }

        public DataSet buscarNomina()
        {
            conexion = cls_DAL.trae_conexion("Soportic", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {

                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            else
            {
                sql = "stp_salarioEmpleado";
                ParamStruct[] parametros = new ParamStruct[3];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@idEmpleado", SqlDbType.Int, _idEmpleado);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@mes", SqlDbType.VarChar, _mes);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@anio", SqlDbType.Int, _anio);
                ds = cls_DAL.ejecuta_dataset(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                {
                    return ds;
                }
            }
        }

        public bool IngresarNuevoRegistroNomina()
        {
            conexion = cls_DAL.trae_conexion("Soportic", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {

                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else
            {
                sql = "stp_insertarNuevoEmpleado";
                ParamStruct[] parametros = new ParamStruct[9];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@idEmpleado", SqlDbType.Int, _idEmpleado);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@mesNomina", SqlDbType.VarChar, _mes);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@anioNomina", SqlDbType.Int, _anio);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@horasLaboradas", SqlDbType.Int, _hrsLaboradas);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 4, "@horasExtra", SqlDbType.Int, _hrsExtra);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 5, "@salario", SqlDbType.Int, _salario);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 6, "@salarioBruto", SqlDbType.Float, _salarioBruto);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 7, "@rebajos", SqlDbType.Float, _rebajos);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 8, "@salarioNeto", SqlDbType.Float, _salarioNeto);
                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.ejecuta_sqlcommand(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al guardar o actualizar el cliente proveedor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                    return false;
                }
                else
                {
                    cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                    return true;
                }
            }
        }
        #endregion
  
    }   
}
