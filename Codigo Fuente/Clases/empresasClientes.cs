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
    public class empresasClientes
    {
        #region propiedades

        private int _idEmpresaCliente;

        public int idEmpresaCliente
        {
            get { return _idEmpresaCliente; }
            set { _idEmpresaCliente = value; }
        }

        private string _nombre;

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
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

        private bool _isDeleted;

        public bool isDeleted
        {
            get { return _isDeleted; }
            set { _isDeleted = value; }
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

        private string _Direccion;

        public string Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }
        
        #endregion

        #region variables

        SqlConnection conexion;
        string sql;
        string mensaje_error;
        int numero_error;
        DataSet ds;

        #endregion

        #region Metodos

        public DataSet cargarComboBoxEmpresasClientes()
        {
            conexion = cls_DAL.trae_conexion("Soportic", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            else
            {
                sql = "spu_cargaComboBoxEmpresaCliente";
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

        public void cargaInfoEmpresaCliente(int idEmpresaCliente)
        {
            conexion = cls_DAL.trae_conexion("Soportic", ref mensaje_error, ref numero_error);

            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _mensaje = mensaje_error;
            }
            else
            {
                sql = "spu_cargaInfoEmpresasClientes";

                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@idEmpresaCliente", SqlDbType.Int, idEmpresaCliente);

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
                        _Direccion = ds.Tables[0].Rows[0]["Direccion"].ToString();
                    }
                    else
                    {
                        _mensaje = mensaje_error;
                    }
                }
            }
        }

        public DataSet cargarDataGridEmpresasClientes()
        {
            conexion = cls_DAL.trae_conexion("Soportic", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                sql = "spu_cargaListaEmpresasClientes";

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

        public bool insertarEmpresaCliente(string accion)
        {
            conexion = cls_DAL.trae_conexion("Soportic", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if (accion.Equals("Insertar"))
                {
                    sql = "spu_insertaEmpresaCliente";
                }
                else
                {
                    sql = "spu_updateEmpresaCliente";
                }

                ParamStruct[] parametros = new ParamStruct[7];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@idEmpresaCliente", SqlDbType.Int, _idEmpresaCliente);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@nombre", SqlDbType.VarChar, _nombre);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@idTipoIdentificacion", SqlDbType.Int, _idTipoIdentificacion);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@identificacion", SqlDbType.VarChar, _identificacion);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 4, "@telefonoEmpresa", SqlDbType.VarChar, _telefonoEmpresa);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 5, "@isDeleted", SqlDbType.Bit, _isDeleted);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 6, "@Direccion", SqlDbType.VarChar, _Direccion);

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

        public bool eliminarEmpresaCliente()
        {
            conexion = cls_DAL.trae_conexion("Soportic", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                sql = "spu_eliminarEmpresaCliente";

                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@idEmpresaCliente", SqlDbType.Int, _idEmpresaCliente);

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
