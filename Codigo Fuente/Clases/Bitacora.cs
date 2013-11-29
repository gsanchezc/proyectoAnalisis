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
    public class Bitacora
    {
        #region propiedades

        private int _idBitacora;

        public int idBitacora
        {
            get { return _idBitacora; }
            set { _idBitacora = value; }
        }

        private int _idTicket;

        public int idTicket
        {
            get { return _idTicket; }
            set { _idTicket = value; }
        }

        private int _tiempoLaborado;

        public int tiempoLaborado
        {
            get { return _tiempoLaborado; }
            set { _tiempoLaborado = value; }
        }

        private string _descripcion;

        public string descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        private int? _idArchivoAdjunto;

        public int? idArchivoAdjunto
        {
            get { return _idArchivoAdjunto; }
            set { _idArchivoAdjunto = value; }
        }

        private string _fecha;

        public string fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        private int _idEmpleado;

        public int idEmpleado
        {
            get { return _idEmpleado; }
            set { _idEmpleado = value; }
        }

        private string _Empleado;

        public string Empleado
        {
            get { return _Empleado; }
            set { _Empleado = value; }
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

        public DataSet cargarDataGridBitacora()
        {
            conexion = cls_DAL.trae_conexion("Soportic", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {

                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                sql = "spu_cargaDataBitacora";
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

        public DataSet cargarDataGridBitacoraTicketEspecifico(int Ticket)
        {
            conexion = cls_DAL.trae_conexion("Soportic", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                sql = "spu_cargaDataBitacoraTicketEspecifico";

                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@idTicket", SqlDbType.Int, Ticket);
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

        public bool insertar_Bitacora(string accion)
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
                    sql = "stu_insertBitacora";
                }

                ParamStruct[] parametros = new ParamStruct[7];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@idTicket", SqlDbType.Int, _idTicket);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@tiempoLaborado", SqlDbType.Int, _tiempoLaborado);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@descripcion", SqlDbType.VarChar, _descripcion);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@idArchivoAdjunto", SqlDbType.Int, _idArchivoAdjunto);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 4, "@fecha", SqlDbType.Date, _fecha);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 5, "@idEmpleado", SqlDbType.Int, _idEmpleado);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 6, "@isDeleted", SqlDbType.Bit, _isDeleted);

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

        public bool insertar_BitacoraSinArchivoAdjunto(string accion)
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
                    sql = "stu_insertBitacoraSinArchivoAdjunto";
                }

                ParamStruct[] parametros = new ParamStruct[6];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@idTicket", SqlDbType.Int, _idTicket);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@tiempoLaborado", SqlDbType.Int, _tiempoLaborado);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@descripcion", SqlDbType.VarChar, _descripcion);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@fecha", SqlDbType.Date, _fecha);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 4, "@idEmpleado", SqlDbType.Int, _idEmpleado);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 5, "@isDeleted", SqlDbType.Bit, _isDeleted);

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

        public void validarBitacora(int ticket)
        {
            conexion = cls_DAL.trae_conexion("Soportic", ref mensaje_error, ref numero_error);

            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _mensaje = mensaje_error;
            }
            else
            {
                sql = "spu_validarBitacoraTicket";

                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@idTicket", SqlDbType.Int, ticket);

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

        public void cargarDatosBitacoraEspecifico(int IdBitacora)
        {
            conexion = cls_DAL.trae_conexion("Soportic", ref mensaje_error, ref numero_error);

            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _mensaje = mensaje_error;
            }
            else
            {
                sql = "spu_cargaDataBitacoraEspecifico";

                ParamStruct[] parametros = new ParamStruct[1];  
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@idBitacora", SqlDbType.Int, IdBitacora);

                ds = cls_DAL.ejecuta_dataset(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);

                if (ds == null)
                {
                    MessageBox.Show(mensaje_error, "Error al cargar Bitacora", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _mensaje = mensaje_error;
                }
                else
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        _idTicket = Convert.ToInt32(ds.Tables[0].Rows[0]["idTicket"]);
                        _tiempoLaborado = Convert.ToInt32(ds.Tables[0].Rows[0]["tiempoLaborado"]);
                        _descripcion = ds.Tables[0].Rows[0]["descripcion"].ToString();

                        if (ds.Tables[0].Rows[0]["idArchivoAdjunto"] != System.DBNull.Value)
                        {
                            _idArchivoAdjunto = Convert.ToInt32(ds.Tables[0].Rows[0]["idArchivoAdjunto"]);
                        }
                        else
                        {
                            _idArchivoAdjunto = 0;
                        }

                        _fecha = ds.Tables[0].Rows[0]["fecha"].ToString();
                        _Empleado = ds.Tables[0].Rows[0]["idEmpleado"].ToString();
                    }
                    else
                    {
                        MessageBox.Show(mensaje_error, "Error al cargar Bitacora", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        #endregion
    }
}
