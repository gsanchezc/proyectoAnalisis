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
    public class Ticket
    {
        #region propiedades

        private int _idTicket;

        public int idTicket
        {
            get { return _idTicket; }
            set { _idTicket = value; }
        }

        private int _idClienteUsuarioFinal;

        public int idClienteUsuarioFinal
        {
            get { return _idClienteUsuarioFinal; }
            set { _idClienteUsuarioFinal = value; }
        }

        private int _idDepartamento;

        public int idDepartamento
        {
            get { return _idDepartamento; }
            set { _idDepartamento = value; }
        }

        private string _titulo;

        public string titulo
        {
            get { return _titulo; }
            set { _titulo = value; }
        }

        private int _idTipoServicio;

        public int idTipoServicio
        {
            get { return _idTipoServicio; }
            set { _idTipoServicio = value; }
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

        private string _fechaRegistro;

        public string fechaRegistro
        {
            get { return _fechaRegistro; }
            set { _fechaRegistro = value; }
        }

        private int? _idEstatusTickets;

        public int? idEstatusTickets
        {
            get { return _idEstatusTickets; }
            set { _idEstatusTickets = value; }
        }

        private int? _idPrioridad;

        public int? idPrioridad
        {
            get { return _idPrioridad; }
            set { _idPrioridad = value; }
        }

        private int? _idEmpleado;

        public int? idEmpleado
        {
            get { return _idEmpleado; }
            set { _idEmpleado = value; }
        }

        private string _fechaAsignacion;

        public string fechaAsignacion
        {
            get { return _fechaAsignacion; }
            set { _fechaAsignacion = value; }
        }

        private string _fechaInicio;

        public string fechaInicio
        {
            get { return _fechaInicio; }
            set { _fechaInicio = value; }
        }

        private string _fechaEntrega;

        public string fechaEntrega
        {
            get { return _fechaEntrega; }
            set { _fechaEntrega = value; }
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

        private string _nombreUsuario;

        public string nombreUsuario
        {
            get { return _nombreUsuario; }
            set { _nombreUsuario = value; }
        }

        private string _Departamento;

        public string Departamento
        {
            get { return _Departamento; }
            set { _Departamento = value; }
        }

        private string _TipoServicio;

        public string TipoServicio
        {
            get { return _TipoServicio; }
            set { _TipoServicio = value; }
        }

        private string _EstatusTicket;

        public string EstatusTicket
        {
            get { return _EstatusTicket; }
            set { _EstatusTicket = value; }
        }

        private string _Prioridad;

        public string Prioridad
        {
            get { return _Prioridad; }
            set { _Prioridad = value; }
        }

        private string _Empleado;

        public string Empleado
        {
            get { return _Empleado; }
            set { _Empleado = value; }
        }

        private int _idFactura;

        public int idFactura
        {
            get { return _idFactura; }
            set { _idFactura = value; }
        }

        private bool _isCanceled;

        public bool isCanceled
        {
            get { return _isCanceled; }
            set { _isCanceled = value; }
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

        public bool insertar_ticket(string accion)
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
                    sql = "spu_insertarTicket";
                }

                ParamStruct[] parametros = new ParamStruct[10];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@idClienteUsuarioFinal", SqlDbType.Int, _idClienteUsuarioFinal);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@idDepartamento", SqlDbType.Int, _idDepartamento);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@titulo", SqlDbType.VarChar, _titulo);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@idTipoServicio", SqlDbType.Int, _idTipoServicio);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 4, "@descripcion", SqlDbType.VarChar, _descripcion);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 5, "@idArchivoAdjunto", SqlDbType.Int, _idArchivoAdjunto);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 6, "@fechaRegistro", SqlDbType.Date, _fechaRegistro);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 7, "@idEstatusTickets", SqlDbType.Int, _idEstatusTickets);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 8, "@idPrioridad", SqlDbType.Int, _idPrioridad);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 9, "@isDeleted", SqlDbType.Bit, _isDeleted);

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

        public bool insertar_ticketSinArchivoAdjunto(string accion)
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
                    sql = "spu_insertarTicketSinArchivoAdjunto";
                }

                ParamStruct[] parametros = new ParamStruct[9];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@idClienteUsuarioFinal", SqlDbType.Int, _idClienteUsuarioFinal);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@idDepartamento", SqlDbType.Int, _idDepartamento);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@titulo", SqlDbType.VarChar, _titulo);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@idTipoServicio", SqlDbType.Int, _idTipoServicio);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 4, "@descripcion", SqlDbType.VarChar, _descripcion);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 5, "@fechaRegistro", SqlDbType.Date, _fechaRegistro);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 6, "@idEstatusTickets", SqlDbType.Int, _idEstatusTickets);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 7, "@idPrioridad", SqlDbType.Int, _idPrioridad);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 8, "@isDeleted", SqlDbType.Bit, _isDeleted);

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

        public DataSet cargarDataGridTicketParaSupervisor()
        {
            conexion = cls_DAL.trae_conexion("Soportic", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            else
            {
                sql = "spu_cargaDataTicketsSinAsignarYPendientesAprobacion";
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

        public DataSet cargarDataGridTicketParaTecnico(int IdEmpleado)
        {
            conexion = cls_DAL.trae_conexion("Soportic", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {

                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            else
            {
                sql = "spu_cargaDataTicketsAsignadosATecnico";

                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@idEmpleado", SqlDbType.Int, IdEmpleado);
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

        public DataSet cargarDataGridMisTicketsPendienteVistaCliente(int IdClienteUsuarioFinal)
        {
            conexion = cls_DAL.trae_conexion("Soportic", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {

                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            else
            {
                sql = "spu_cargaDataMisTicketPendientesVistaCliente";

                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@idClienteUsuarioFinal", SqlDbType.Int, IdClienteUsuarioFinal);
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

        public DataSet cargarDataGridMisTicketsCerradosVistaCliente(int IdClienteUsuarioFinal)
        {
            conexion = cls_DAL.trae_conexion("Soportic", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {

                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            else
            {
                sql = "spu_cargaDataMisTicketCerradosVistaCliente";

                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@idClienteUsuarioFinal", SqlDbType.Int, IdClienteUsuarioFinal);
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

        public void cargaInfoTicket(int idTicket)
        {
            conexion = cls_DAL.trae_conexion("Soportic", ref mensaje_error, ref numero_error);

            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _mensaje = mensaje_error;
            }
            else
            {
                sql = "spu_cargaDataTicket";

                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@idTicket", SqlDbType.Int, idTicket);

                ds = cls_DAL.ejecuta_dataset(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);

                if (ds == null)
                {
                    MessageBox.Show(mensaje_error, "Error al cargar Ticket", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _mensaje = mensaje_error;
                }
                else
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        _idTicket = Convert.ToInt32(ds.Tables[0].Rows[0]["idTicket"]);
                        _nombreUsuario = ds.Tables[0].Rows[0]["nombreUsuario"].ToString();
                        _Departamento = ds.Tables[0].Rows[0]["Departamento"].ToString();
                        _titulo = ds.Tables[0].Rows[0]["titulo"].ToString();
                        _TipoServicio = ds.Tables[0].Rows[0]["TipoServicio"].ToString();
                        _descripcion = ds.Tables[0].Rows[0]["descripcion"].ToString();

                        if (ds.Tables[0].Rows[0]["idArchivoAdjunto"] != System.DBNull.Value)
                        {
                            _idArchivoAdjunto = Convert.ToInt32(ds.Tables[0].Rows[0]["idArchivoAdjunto"]);
                        }
                        else
                        {
                            _idArchivoAdjunto = 0;
                        }

                        _fechaRegistro = ds.Tables[0].Rows[0]["fechaRegistro"].ToString();
                        _EstatusTicket = ds.Tables[0].Rows[0]["EstatusTicket"].ToString();
                        _Prioridad = ds.Tables[0].Rows[0]["Prioridad"].ToString();

                        if (ds.Tables[0].Rows[0]["Empleado"] != System.DBNull.Value)
                        {
                            _Empleado = ds.Tables[0].Rows[0]["Empleado"].ToString();
                        }
                        else
                        {
                            _Empleado = "No Asignado";
                        }

                        if (ds.Tables[0].Rows[0]["fechaAsignacion"] != System.DBNull.Value)
                        {
                            _fechaAsignacion = ds.Tables[0].Rows[0]["fechaAsignacion"].ToString().Substring(0, 10);
                        }
                        else
                        {
                            _fechaAsignacion = "No asignado aun";
                        }

                        if (ds.Tables[0].Rows[0]["fechaInicio"] != System.DBNull.Value)
                        {
                            _fechaInicio = ds.Tables[0].Rows[0]["fechaInicio"].ToString().Substring(0, 10);
                        }
                        else
                        {
                            _fechaInicio = "No iniciado aun";
                        }

                        if (ds.Tables[0].Rows[0]["fechaEntrega"] != System.DBNull.Value)
                        {
                            _fechaEntrega = ds.Tables[0].Rows[0]["fechaEntrega"].ToString().Substring(0, 10);
                        }
                        else
                        {
                            _fechaEntrega = "Fecha Entrega No Definida";
                        }

                        _isDeleted = Convert.ToBoolean(ds.Tables[0].Rows[0]["isDeleted"]);
                        _idEstatusTickets = Convert.ToInt32(ds.Tables[0].Rows[0]["idEstatusTickets"]);
                        _idPrioridad = Convert.ToInt32(ds.Tables[0].Rows[0]["idPrioridad"]);

                        if (ds.Tables[0].Rows[0]["idEmpleado"] != System.DBNull.Value)
                        {
                            _idEmpleado = Convert.ToInt32(ds.Tables[0].Rows[0]["idEmpleado"]);
                        }
                        else
                        {
                            _idEmpleado = 0;
                        } 
                    }
                    else
                    {
                        _mensaje = mensaje_error;
                    }
                }
            }
        }

        public bool actualizar_TicketSupervisor(string accion)
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
                    sql = "stu_asignacionTicket";
                }

                ParamStruct[] parametros = new ParamStruct[6];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@idTicket", SqlDbType.VarChar, _idTicket);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@idEstatusTickets", SqlDbType.VarChar, _idEstatusTickets);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@idPrioridad", SqlDbType.VarChar, _idPrioridad);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@idEmpleado", SqlDbType.VarChar, _idEmpleado);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 4, "@fechaAsignacion", SqlDbType.VarChar, _fechaAsignacion);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 5, "@fechaEntrega", SqlDbType.VarChar, _fechaEntrega);

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

        public bool actualizar_TicketTecnico(string accion)
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
                    sql = "stu_atencionTicket";
                }

                ParamStruct[] parametros = new ParamStruct[2];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@idTicket", SqlDbType.VarChar, _idTicket);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@idEstatusTickets", SqlDbType.VarChar, _idEstatusTickets);

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

        public bool actualizar_TicketFechaInicio(string accion)
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
                    sql = "stu_actualizarFechaInicio";
                }

                ParamStruct[] parametros = new ParamStruct[2];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@idTicket", SqlDbType.VarChar, _idTicket);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@fechaInicio", SqlDbType.VarChar, _fechaInicio);

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

        public DataSet cargarUltimoRegistroTicket()
        {
            conexion = cls_DAL.trae_conexion("Soportic", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {

                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                sql = "stu_ultimoRegistroTicket";
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

        public void existeTicketParaOrdenCompra(int IDTicket)
        {
            conexion = cls_DAL.trae_conexion("Soportic", ref mensaje_error, ref numero_error);

            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _mensaje = mensaje_error;
            }
            else
            {
                sql = "spu_existeTicketParaOrdenCompra";

                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@idTicket", SqlDbType.Int, IDTicket);

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

        public DataSet cargaDataGridTicketsParaFacturas(int idClienteUsuarioFinal)
        {
            conexion = cls_DAL.trae_conexion("Soportic", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {

                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                sql = "spu_cargaDataGridTicketsParaFacturas";

                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@idClienteUsuarioFinal", SqlDbType.Int, idClienteUsuarioFinal);

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

        public DataSet cargaDataGridTicketsParaFacturasPorFecha(int idClienteUsuarioFinal, string fechaDesde, string fechaHasta)
        {
            conexion = cls_DAL.trae_conexion("Soportic", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {

                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                sql = "spu_cargaDataGridTicketsParaFacturasPorFechas";

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

        #endregion
    }
}
