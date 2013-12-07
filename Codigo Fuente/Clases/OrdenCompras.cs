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
    public class OrdenCompras
    {
        #region propiedades

        private int _idOrdenCompra;

        public int idOrdenCompra
        {
            get { return _idOrdenCompra; }
            set { _idOrdenCompra = value; }
        }

        private int _idTicket;

        public int idTicket
        {
            get { return _idTicket; }
            set { _idTicket = value; }
        }

        private int _idProveedor;

        public int idProveedor
        {
            get { return _idProveedor; }
            set { _idProveedor = value; }
        }

        private int _numeroCotizacion;

        public int numeroCotizacion
        {
            get { return _numeroCotizacion; }
            set { _numeroCotizacion = value; }
        }

        private string _detalle;

        public string detalle
        {
            get { return _detalle; }
            set { _detalle = value; }
        }

        private int _monto;

        public int monto
        {
            get { return _monto; }
            set { _monto = value; }
        }

        private int _idArchivoAdjunto;

        public int idArchivoAdjunto
        {
            get { return _idArchivoAdjunto; }
            set { _idArchivoAdjunto = value; }
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

        public bool insertar_OrdenDeCompra(string accion)
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
                    sql = "spu_insertaOrdenDeCompra";
                }

                ParamStruct[] parametros = new ParamStruct[7];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@idTicket", SqlDbType.Int, _idTicket);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@idProveedor", SqlDbType.Int, _idProveedor);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@numeroCotizacion", SqlDbType.Int, _numeroCotizacion);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@detalle", SqlDbType.VarChar, _detalle);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 4, "@monto", SqlDbType.Int, _monto);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 5, "@idArchivoAdjunto", SqlDbType.Int, _idArchivoAdjunto);
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

        public DataSet cargarDataGridOrdenesDeCompra()
        {
            conexion = cls_DAL.trae_conexion("Soportic", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                sql = "spu_cargaDataGridOrdenesDeCompra";

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

        public DataSet cargarDataGridOrdenesDeCompraParaFacturas(int idClienteUsuarioFinal)
        {
            conexion = cls_DAL.trae_conexion("Soportic", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                sql = "spu_cargaDataGridOrdenesDeCompraPorFactura";

                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@idClienteUsuarioFinal", SqlDbType.Int, idClienteUsuarioFinal);

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

        public DataSet cargarDataGridOrdenesDeCompraParaFacturasPorFecha(int idClienteUsuarioFinal, string fechaDesde, string fechaHasta)
        {
            conexion = cls_DAL.trae_conexion("Soportic", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                sql = "spu_cargaDataGridOrdenesDeCompraPorFacturaPorFecha";

                ParamStruct[] parametros = new ParamStruct[3];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@idClienteUsuarioFinal", SqlDbType.Int, idClienteUsuarioFinal);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@fechaDesde", SqlDbType.Date, fechaDesde);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@fechahasta", SqlDbType.Date, fechaHasta);

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

        public DataSet cargarDataGridOrdenesDeCompraParaFacturasConIdFactura(int idFactura)
        {
            conexion = cls_DAL.trae_conexion("Soportic", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                sql = "spu_cargaDataGridOrdenesDeCompraPorFacturaPorIdFactura";

                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@idFactura", SqlDbType.Int, idFactura);

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

        #endregion
    }
}
