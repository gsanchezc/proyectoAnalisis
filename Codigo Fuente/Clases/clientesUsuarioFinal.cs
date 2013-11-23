using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DAL;
using System.Windows.Forms;
using System.Linq;

namespace Clases
{
    public class clientesUsuarioFinal
    {
        #region propiedades

        private int _idClienteUsuarioFinal;

        public int idClienteUsuarioFinal
        {
            get { return _idClienteUsuarioFinal; }
            set { _idClienteUsuarioFinal = value; }
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

        private string _apellidos;

        public string apellidos
        {
            get { return _apellidos; }
            set { _apellidos = value; }
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

        private string _telefonoEmpresa;

        public string telefonoEmpresa
        {
            get { return _telefonoEmpresa; }
            set { _telefonoEmpresa = value; }
        }

        private int _idEmpresaCliente;

        public int idEmpresaCliente
        {
            get { return _idEmpresaCliente; }
            set { _idEmpresaCliente = value; }
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

        public bool actualizarIdUsuarioSistemaCliente(string accion)
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
                    sql = "spu_actualizaIdUsuarioSistemaCliente";
                }

                ParamStruct[] parametros = new ParamStruct[2];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@idClienteUsuarioFinal", SqlDbType.VarChar, _idClienteUsuarioFinal);
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
                    sql = "spu_insertarNuevoClienteUsuarioFinal";
                }

                ParamStruct[] parametros = new ParamStruct[7];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@nombre", SqlDbType.VarChar, _nombre);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@apellidos", SqlDbType.VarChar, _apellidos);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@idTipoIdentificacion", SqlDbType.Int, _idTipoIdentificacion);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@identificacion", SqlDbType.VarChar, _identificacion);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 4, "@telefonoEmpresa", SqlDbType.VarChar, _telefonoEmpresa);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 5, "@idEmpresaCliente", SqlDbType.Int, _idEmpresaCliente);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 6, "@isDeleted", SqlDbType.Bit, _isdeleted);

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

        public void cargaInfoCliente(int idClienteUsuarioFinal)
        {
            conexion = cls_DAL.trae_conexion("Soportic", ref mensaje_error, ref numero_error);

            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _mensaje = mensaje_error;
            }
            else
            {
                sql = "spu_cargaInfoCliente";

                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@idClienteUsuarioFinal", SqlDbType.Int, idClienteUsuarioFinal);

                ds = cls_DAL.ejecuta_dataset(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);

                if (ds == null)
                {
                    MessageBox.Show(mensaje_error, "Error al cargar Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _mensaje = mensaje_error;
                }
                else
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        _nombre = ds.Tables[0].Rows[0]["nombre"].ToString();
                        _apellidos = ds.Tables[0].Rows[0]["apellidos"].ToString();
                        _idTipoIdentificacion = Convert.ToInt32(ds.Tables[0].Rows[0]["idTipoIdentificacion"]);
                        _identificacion = ds.Tables[0].Rows[0]["identificacion"].ToString();
                        _telefonoEmpresa = ds.Tables[0].Rows[0]["telefonoEmpresa"].ToString();
                        _idEmpresaCliente = Convert.ToInt32(ds.Tables[0].Rows[0]["idEmpresaCliente"]);
                        _isdeleted = Convert.ToBoolean(ds.Tables[0].Rows[0]["isDeleted"]);
                    }
                    else
                    {
                        _mensaje = mensaje_error;
                    }
                }
            }
        }

        public void cargaIdUsuarioSistema(int idClienteUsuarioFinal)
        {
            conexion = cls_DAL.trae_conexion("Soportic", ref mensaje_error, ref numero_error);

            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _mensaje = mensaje_error;
            }
            else
            {
                sql = "spu_traeIdUsuarioSistema";

                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@idClienteUsuarioFinal", SqlDbType.Int, idClienteUsuarioFinal);

                ds = cls_DAL.ejecuta_dataset(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);

                if (ds == null)
                {
                    MessageBox.Show(mensaje_error, "Error al cargar Id Usuario Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public void cargaIdUsuarioSistemaPorNombreDeUsuario(string nombreUsuarioSistema)
        {
            conexion = cls_DAL.trae_conexion("Soportic", ref mensaje_error, ref numero_error);

            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _mensaje = mensaje_error;
            }
            else
            {
                sql = "spu_cargaIdClienteUsuarioFinal";

                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@nombreUsuarioSistema", SqlDbType.VarChar, nombreUsuarioSistema);

                ds = cls_DAL.ejecuta_dataset(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);

                if (ds == null)
                {
                    MessageBox.Show(mensaje_error, "Error al cargar usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _mensaje = mensaje_error;
                }
                else
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        _idClienteUsuarioFinal = Convert.ToInt32(ds.Tables[0].Rows[0]["idClienteUsuarioFinal"]);
                    }
                    else
                    {
                        _mensaje = mensaje_error;
                    }
                }
            }
        }

        #endregion
    }
}
