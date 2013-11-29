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
    public class ArchivosAdjuntos
    {
        #region propiedades

        private int _idArchivoAdjunto;

        public int idArchivoAdjunto
        {
            get { return _idArchivoAdjunto; }
            set { _idArchivoAdjunto = value; }
        }

        private string _nombre;

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private byte[] _archivo;

        public byte[] archivo
        {
            get { return _archivo; }
            set { _archivo = value; }
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

        #endregion

        #region variables privadas

        SqlConnection conexion;
        string mensaje_error;
        int numero_error;
        string sql;
        DataSet ds;

        #endregion

        #region metodos

        public bool insertar_ArchivoAdjunto(string accion)
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
                    sql = "stp_insertarArchivoAdjunto";
                }

                ParamStruct[] parametros = new ParamStruct[3];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@nombre", SqlDbType.VarChar, _nombre);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@archivo", SqlDbType.VarBinary, _archivo);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@isDeleted,", SqlDbType.Bit, _isDeleted);

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

        public void cargaArchivoAdjunto(int idArchivoAdjunto)
        {
            conexion = cls_DAL.trae_conexion("Soportic", ref mensaje_error, ref numero_error);

            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _mensaje = mensaje_error;
            }
            else
            {
                sql = "stp_cargaArchivoAdjunto";

                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@idArchivoAdjunto", SqlDbType.Int, idArchivoAdjunto);

                ds = cls_DAL.ejecuta_dataset(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);

                if (ds == null)
                {
                    MessageBox.Show(mensaje_error, "Error al cargar Archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _mensaje = mensaje_error;
                }
                else
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        _archivo = (byte[])ds.Tables[0].Rows[0]["archivo"];
                    }
                    else
                    {
                        _mensaje = mensaje_error;
                    }
                }
            }
        }

        public void cargaIDArchivoAdjuntoRecienGuardado()
        {
            conexion = cls_DAL.trae_conexion("Soportic", ref mensaje_error, ref numero_error);

            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _mensaje = mensaje_error;
            }
            else
            {
                sql = "stp_cargaIdArchivoAdjuntoRecienGuardado";

                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, ref mensaje_error, ref numero_error);

                if (ds == null)
                {
                    MessageBox.Show(mensaje_error, "Error al cargar Archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _mensaje = mensaje_error;
                }
                else
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        _idArchivoAdjunto = Convert.ToInt32(ds.Tables[0].Rows[0]["ID"]);
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
