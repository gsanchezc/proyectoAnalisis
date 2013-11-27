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
    public class SolicitudOrdenesCompra
    {
        #region propiedades

        private int _idSolicitud;

        public int idSolicitud
        {
            get { return _idSolicitud; }
            set { _idSolicitud = value; }
        }

        private int _idTicket;

        public int idTicket
        {
            get { return _idTicket; }
            set { _idTicket = value; }
        }

        private string _detalleOrden;

        public string detalleOrden
        {
            get { return _detalleOrden; }
            set { _detalleOrden = value; }
        }

        private string _fechaSolicitud;

        public string fechaSolicitud
        {
            get { return _fechaSolicitud; }
            set { _fechaSolicitud = value; }
        }

        private bool _isAproved;

        public bool isAproved
        {
            get { return _isAproved; }
            set { _isAproved = value; }
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

        public bool insertar_SolicitudOrden(string accion)
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
                    sql = "spu_insertaSolicitudOrden";
                }

                ParamStruct[] parametros = new ParamStruct[5];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@idTicket", SqlDbType.Int, _idTicket);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@detalleOrden", SqlDbType.VarChar, _detalleOrden);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@fechaSolicitud", SqlDbType.VarChar, _fechaSolicitud);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@isAproved", SqlDbType.Bit, _isAproved);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 4, "@isDeleted", SqlDbType.Bit, _isDeleted);

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

        public DataSet cargarDataGridSolicitudesDeCompra()
        {
            conexion = cls_DAL.trae_conexion("Soportic", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                sql = "spu_cargaDataGridSolicitudesDeCompra";

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

        public DataSet cargarDataGridSolicitudesDeCompraTicketEspecifico(int idTicket)
        {
            conexion = cls_DAL.trae_conexion("Soportic", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                sql = "spu_cargaDataGridSolicitudesDeCompraDeTicketEspecifico";

                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@idTicket", SqlDbType.Int, idTicket);

                ds = cls_DAL.ejecuta_dataset(conexion, sql, true,parametros, ref mensaje_error, ref numero_error);
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

        public void cargaIdTicketConIdSolicitud(int idSolicitud)
        {
            conexion = cls_DAL.trae_conexion("Soportic", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _mensaje = mensaje_error;
            }
            else
            {
                sql = "spu_cargaIdTicketConIdSolicitud";

                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@idSolicitud", SqlDbType.Int, idSolicitud);

                ds = cls_DAL.ejecuta_dataset(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _mensaje = mensaje_error;
                }
                else
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        _idTicket = Convert.ToInt32(ds.Tables[0].Rows[0]["idTicket"]);
                    }
                    else
                    {
                        MessageBox.Show(mensaje_error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        #endregion 
    }
}
