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
    public class facturas
    {
        #region propiedades

        private int _idFactura;

        public int idFactura
        {
            get { return _idFactura; }
            set { _idFactura = value; }
        }

        private int _idClienteUsuarioFinal;

        public int idClienteUsuarioFinal
        {
            get { return _idClienteUsuarioFinal; }
            set { _idClienteUsuarioFinal = value; }
        }

        private string _telefono;

        public string telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        private string _direccion;

        public string direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        private string _fechaFactura;

        public string fechaFactura
        {
            get { return _fechaFactura; }
            set { _fechaFactura = value; }
        }

        private string _fechaDesde;

        public string fechaDesde
        {
            get { return _fechaDesde; }
            set { _fechaDesde = value; }
        }

        private string _fechahasta;

        public string fechahasta
        {
            get { return _fechahasta; }
            set { _fechahasta = value; }
        }

        private double _subTotal;

        public double subTotal
        {
            get { return _subTotal; }
            set { _subTotal = value; }
        }

        private double _impuesto;

        public double impuesto
        {
            get { return _impuesto; }
            set { _impuesto = value; }
        }

        private double _total;

        public double total
        {
            get { return _total; }
            set { _total = value; }
        }

        private bool _isDeleted;

        public bool isDeleted
        {
            get { return _isDeleted; }
            set { _isDeleted = value; }
        }

        private bool _isCanceled;

        public bool isCanceled
        {
            get { return _isCanceled; }
            set { _isCanceled = value; }
        }

        private int _cantidadTickets;

        public int cantidadTickets
        {
            get { return _cantidadTickets; }
            set { _cantidadTickets = value; }
        }

        private int _cantidadOrdenes;

        public int cantidadOrdenes
        {
            get { return _cantidadOrdenes; }
            set { _cantidadOrdenes = value; }
        }

        private double _cargoPorTipoServicio;

        public double cargoPorTipoServicio
        {
            get { return _cargoPorTipoServicio; }
            set { _cargoPorTipoServicio = value; }
        }

        private double _cargoPorPrioridad;

        public double cargoPorPrioridad
        {
            get { return _cargoPorPrioridad; }
            set { _cargoPorPrioridad = value; }
        }

        private double _cargoPorPuntualidad;

        public double cargoPorPuntualidad
        {
            get { return _cargoPorPuntualidad; }
            set { _cargoPorPuntualidad = value; }
        }

        private double _montoTickets;

        public double montoTickets
        {
            get { return _montoTickets; }
            set { _montoTickets = value; }
        }

        private double _montoOrdenesCompra;

        public double montoOrdenesCompra
        {
            get { return _montoOrdenesCompra; }
            set { _montoOrdenesCompra = value; }
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

        public bool insertar_factura(string accion)
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
                    sql = "spu_insertaFactura";
                }

                ParamStruct[] parametros = new ParamStruct[15];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@idClienteUsuarioFinal", SqlDbType.Int, _idClienteUsuarioFinal);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@telefono", SqlDbType.VarChar, _telefono);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@direccion", SqlDbType.VarChar, _direccion);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@fechaDesde", SqlDbType.Date, _fechaDesde);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 4, "@fechahasta", SqlDbType.Date, _fechahasta);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 5, "@cantidadTickets", SqlDbType.Int, _cantidadTickets);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 6, "@cantidadOrdenes", SqlDbType.Int, _cantidadOrdenes);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 7, "@cargoPorTipoServicio", SqlDbType.Float, _cargoPorTipoServicio);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 8, "@cargoPorPrioridad", SqlDbType.Float, _cargoPorPrioridad);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 9, "@cargoPorPuntualidad", SqlDbType.Float, _cargoPorPuntualidad);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 10, "@montoTickets", SqlDbType.Float, _montoTickets);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 11, "@montoOrdenesCompra", SqlDbType.Float, _montoOrdenesCompra);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 12, "@subTotal", SqlDbType.Float, _subTotal);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 13, "@impuesto", SqlDbType.Float, _impuesto);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 14, "@total", SqlDbType.Float, _total);

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

        public DataSet cargarDataGridFacturasTodas()
        {
            conexion = cls_DAL.trae_conexion("Soportic", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {

                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                sql = "spu_cargarDataGridFacturasTodas";
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

        public DataSet cargarDataGridFacturasPendientesPago()
        {
            conexion = cls_DAL.trae_conexion("Soportic", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {

                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                sql = "spu_cargarDataGridFacturasPendientesPago";
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

        public DataSet cargarDataGridFacturasCanceladas()
        {
            conexion = cls_DAL.trae_conexion("Soportic", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {

                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                sql = "spu_cargarDataGridFacturasCanceladas";
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
