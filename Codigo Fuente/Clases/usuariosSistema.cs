using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DAL;
using System.Windows.Forms;
using System.Linq;
using System.Security.Cryptography;

namespace Clases
{
    public class UsuariosSistema
    {
        #region propiedades

        private int _idUsuarioSistema;

        public int idUsuarioSistema
        {
            get { return _idUsuarioSistema; }
            set { _idUsuarioSistema = value; }
        }

        private int _idRol;

        public int idRol
        {
            get { return _idRol; }
            set { _idRol = value; }
        }

        private string _contrasenna;

        public string contrasenna
        {
            get { return _contrasenna; }
            set { _contrasenna = value; }
        }

        private bool _isblock;

        public bool isblock
        {
            get { return _isblock; }
            set { _isblock = value; }
        }

        private int _idEmpleado;

        public int idEmpleado
        {
            get { return _idEmpleado; }
            set { _idEmpleado = value; }
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

        private bool _validacion;

        public bool validacion
        {
            get { return _validacion; }
            set { _validacion = value; }
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

        public bool insertar_usuariosSistema(string accion)
        {
            conexion = cls_DAL.trae_conexion("Soportic", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if (accion.Equals("Insertar"))
                {
                    sql = "spu_insertaUsuarioSistema";
                }

                ParamStruct[] parametros = new ParamStruct[5];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@idRol", SqlDbType.Int, _idRol);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@contrasenna", SqlDbType.VarChar, _contrasenna);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@isblock", SqlDbType.Bit, _isblock);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@idEmpleado", SqlDbType.Int, _idEmpleado);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 4, "@isdeleted", SqlDbType.Bit, _isdeleted);

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

        public void login_usuariosSistema(int idUsuarioSistema, string contrasenna)
        {
            conexion = cls_DAL.trae_conexion("Soportic", ref mensaje_error, ref numero_error);

            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _mensaje = "Error";
            }
            else
            {
                sql = "spu_login";

                ParamStruct[] parametros = new ParamStruct[2];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@idUsuarioSistema", SqlDbType.Int, idUsuarioSistema);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@contrasenna", SqlDbType.VarChar, contrasenna);

                ds = cls_DAL.ejecuta_dataset(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);

                if (ds == null)
                {
                    MessageBox.Show(mensaje_error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        _validacion = Convert.ToBoolean(ds.Tables[0].Rows[0]["validacion"]);
                    }
                    else
                    {
                        MessageBox.Show(mensaje_error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public DataSet cargalistaUsuariosSistema()
        {
            conexion = cls_DAL.trae_conexion("Soportic", ref mensaje_error, ref numero_error);

            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                sql = "spu_carhaListaUsuariosSistema";
                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al cargar la lista", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


