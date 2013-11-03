using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DAL;
using System.Windows.Forms;

namespace Clases
{
   public class estatusFactura
    {
        #region propiedades
        private int id;

        public int _id
        {
            get { return id; }
            set { id = value; }
        }

        private string descripcion;

        public string _descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        
        
        #endregion

        #region variables privadas
        SqlConnection conexion;
        string sql;
        string mensaje_error;
        int numero_error;
        DataSet ds;
        #endregion

        #region metodos
        
       //Metodo que trae la lista de estados de factura de la base de datos
        public DataSet cargaListaEstadosFactura()
        {
            conexion = cls_DAL.trae_conexion("Soportic", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
               
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                sql = "stp_traeListaEstadosFactura";
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

       //Metodo que trae la informacion de un unico estado de factura
        public void cargaInfoEstadoFactura(int idEstatus)
        {
            conexion = cls_DAL.trae_conexion("Soportic", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            {
                sql = "stp_traeInfoEstadosFactura";
                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@id", SqlDbType.Int, idEstatus);
                ds = cls_DAL.ejecuta_dataset(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al Traer la info del estado Factura", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                else
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        _descripcion = ds.Tables[0].Rows[0]["descripcion"].ToString();
                        
                    }
                    else
                    {
                        _descripcion = "Error";
                    }
                }
            }
        }

       //Metodo que agregar o actualiza un estado factura
        public bool agregarActualizarEstadoFactura(string accion)
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
                    sql = "stp_insertaEstadoFactura";
                }
                else
                {
                    sql = "stp_modificarEstadosFactura";
                }
                ParamStruct[] parametros = new ParamStruct[2];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@id", SqlDbType.Int, _id);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@descripcion", SqlDbType.VarChar, _descripcion);
                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.ejecuta_sqlcommand(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al guardar o actualizar el estado factura", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

       //Metodo que elimina un estatus de factura
        public bool eliminarEstatusFactura(int id)
        {
            conexion = cls_DAL.trae_conexion("Soportic", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {

                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                sql = "stp_eliminarEstadoFactura";
                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@id", SqlDbType.Int, id);
                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.ejecuta_sqlcommand(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }


        #endregion
    }
}
