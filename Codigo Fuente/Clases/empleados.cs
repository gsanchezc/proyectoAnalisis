﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DAL;
using System.Windows.Forms;
using System.Linq;

namespace Clases
{
    public class empleados
    {
        #region propiedades

        private int _idEmpleado;

        public int idEmpleado
        {
            get { return _idEmpleado; }
            set { _idEmpleado = value; }
        }

        private int _idUsuarioSistema;

        public int idUsuarioSistema
        {
            get { return _idUsuarioSistema; }
            set { _idUsuarioSistema = value; }
        }

        private string _nombre;

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private string _apellido;

        public string apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        private int _idTipoIdentificacion;

        public int idTipoIdentificacion
        {
            get { return _idTipoIdentificacion; }
            set { _idTipoIdentificacion = value; }
        }

        private string _identificacion;

        public string identificacion
        {
            get { return _identificacion; }
            set { _identificacion = value; }
        }

        private string _fechaNacimiento;

        public string fechaNacimiento
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }

        private string _correo;

        public string correo
        {
            get { return _correo; }
            set { _correo = value; }
        }

        private string _direccion;

        public string direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        private int _idDepartamento;

        public int idDepartamento
        {
            get { return _idDepartamento; }
            set { _idDepartamento = value; }
        }

        private int _idPuesto;

        public int idPuesto
        {
            get { return _idPuesto; }
            set { _idPuesto = value; }
        }

        private string _telefono;

        public string telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        private string _celular;

        public string celular
        {
            get { return _celular; }
            set { _celular = value; }
        }

        private string _fechaIngreso;

        public string fechaIngreso
        {
            get { return _fechaIngreso; }
            set { _fechaIngreso = value; }
        }

        private int _idSalario;

        public int idSalario
        {
            get { return _idSalario; }
            set { _idSalario = value; }
        }

        private int _vacacionesDisponibles;

        public int vacacionesDisponibles
        {
            get { return _vacacionesDisponibles; }
            set { _vacacionesDisponibles = value; }
        }

        private bool _isdeleted;

        public bool isdeleted
        {
            get { return _isdeleted; }
            set { _isdeleted = value; }
        }

        private string _mensaje;

        public string mensaje
        {
            get { return _mensaje; }
            set { _mensaje = value; }
        }

        private int _num_error;

        public int num_error
        {
            get { return _num_error; }
            set { _num_error = value; }
        }

        #endregion

        #region variables privadas

        SqlConnection conexion;
        string mensaje_error;
        int numero_error;
        string sql;
        DataSet ds;

        #endregion

        #region metodos

        public void cargaInfoEmpleado(int idEmpleado)
        {
            conexion = cls_DAL.trae_conexion("Soportic", ref mensaje_error, ref numero_error);

            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _mensaje = mensaje_error;
            }
            else
            {
                sql = "spu_cargaInfoEmpleado";

                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@idEmpleado", SqlDbType.Int, idEmpleado);

                ds = cls_DAL.ejecuta_dataset(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);

                if (ds == null)
                {
                    MessageBox.Show(mensaje_error, "Error al cargar Rol", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _mensaje = mensaje_error;
                }
                else
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        _nombre = ds.Tables[0].Rows[0]["nombre"].ToString();
                        _apellido = ds.Tables[0].Rows[0]["apellido"].ToString();
                        _idTipoIdentificacion = Convert.ToInt32(ds.Tables[0].Rows[0]["idTipoIdentificacion"]);
                        _identificacion = ds.Tables[0].Rows[0]["identificacion"].ToString();
                        _isdeleted = Convert.ToBoolean(ds.Tables[0].Rows[0]["isDeleted"]);
                    }
                    else
                    {
                        _mensaje = mensaje_error;
                    }
                }
            }
        }

        public void cargaIdEmpleado(int idEmpleado)
        {
            conexion = cls_DAL.trae_conexion("Soportic", ref mensaje_error, ref numero_error);

            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _mensaje = mensaje_error;
            }
            else
            {
                sql = "spu_traeIdUsuarioSistemaEmpleado";

                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@idEmpleado", SqlDbType.Int, idEmpleado);

                ds = cls_DAL.ejecuta_dataset(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);

                if (ds == null)
                {
                    MessageBox.Show(mensaje_error, "Error al cargar Rol", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _mensaje = mensaje_error;
                }
                else
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        _idUsuarioSistema = Convert.ToInt32(ds.Tables[0].Rows[0]["idUsuarioSistema"]);
                    }
                    else
                    {
                        _mensaje = mensaje_error;
                    }
                }
            }
        }

        public bool actualizarIdUsuarioSistemaEmpleado(string accion)
        {
            conexion = cls_DAL.trae_conexion("Soportic", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if (accion.Equals("Editar"))
                {
                    sql = "spu_actualizaIdUsuarioSistemaEmpleado";
                }

                ParamStruct[] parametros = new ParamStruct[2];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@idEmpleado", SqlDbType.VarChar, _idEmpleado);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@idUsuarioSistema", SqlDbType.VarChar, _idUsuarioSistema);

                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.ejecuta_sqlcommand(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);

                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
