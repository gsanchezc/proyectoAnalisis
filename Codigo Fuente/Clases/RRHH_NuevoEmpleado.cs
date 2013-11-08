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
    public class RRHH_NuevoEmpleado
    {
        #region Propiedades
        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private string _apellidos;

        public string Apellidos
        {
            get { return _apellidos; }
            set { _apellidos = value; }
        }

        private int _TipoIdentificacion;

        public int TipoIdentificacion
        {
            get { return _TipoIdentificacion; }
            set { _TipoIdentificacion = value; }
        }

        private string _identificacion;

        public string Identificacion
        {
            get { return _identificacion; }
            set { _identificacion = value; }
        }

        private DateTime _fechaNacimiento;

        public DateTime FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }

        private string _correo;

        public string Correo
        {
            get { return _correo; }
            set { _correo = value; }
        }

        private string _direccion;

        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        private int _departamento;

        public int Departamento
        {
            get { return _departamento; }
            set { _departamento = value; }
        }

        private int _puesto;

        public int Puesto
        {
            get { return _puesto; }
            set { _puesto = value; }
        }

        private string _telefono;

        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        private string _celular;

        public string Celular
        {
            get { return _celular; }
            set { _celular = value; }
        }

        private DateTime _fechaIngreso;

        public DateTime FechaIngreso
        {
            get { return _fechaIngreso; }
            set { _fechaIngreso = value; }
        }

        private int _salario;

        public int Salario
        {
            get { return _salario; }
            set { _salario = value; }
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
        public bool insertarUsuarioNuevo()
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
                ParamStruct[] parametros = new ParamStruct[13];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@nombre", SqlDbType.VarChar, _nombre);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@apellido", SqlDbType.VarChar, _apellidos);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@idTipoIdentificacion", SqlDbType.Int, _TipoIdentificacion);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@identificacion", SqlDbType.VarChar, _identificacion);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 4, "@fechaNacimiento", SqlDbType.DateTime, _fechaNacimiento);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 5, "@correo", SqlDbType.VarChar, _correo);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 6, "@direccion", SqlDbType.VarChar, _direccion);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 7, "@idDepartamento", SqlDbType.Int, _departamento);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 8, "@idPuesto", SqlDbType.Int, _puesto);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 9, "@telefono", SqlDbType.VarChar, _telefono);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 10, "@celular", SqlDbType.VarChar, _celular);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 11, "@fechaIngreso", SqlDbType.DateTime, _fechaIngreso);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 12, "@idsalario", SqlDbType.Int, _salario);
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

        public DataSet cargarSalarios()
        {
            conexion = cls_DAL.trae_conexion("Soportic", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {

                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            else
            {
                sql = "stp_traeSalarios";
                ds = cls_DAL.ejecuta_dataset(conexion, sql, true, ref mensaje_error, ref numero_error);
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
        #endregion
    }
}
