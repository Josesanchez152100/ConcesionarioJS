using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.TipoVehiculo
{
    public class MetodosCRUDtipoVehiculo
    {
        //Crear tipo comando INSERT
        public static SqlCommand CrearComandoProcAlmacInsert_tv()
        {
            string _cadenaConexion = Configuracion.CadenaConexion;

            SqlConnection _conexion = new SqlConnection(_cadenaConexion);

            SqlCommand _comando = new SqlCommand("addTipoVehiculo", _conexion);

            _comando.CommandType = CommandType.StoredProcedure;

            return _comando;
        }

        //Ejecutar el tipo de comando INSERT
        public static int EjecutarComandoProcAlmacInsert_tv(SqlCommand comando)
        {
            try
            {
                comando.Connection.Open();
                return comando.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally 
            {
                comando.Connection.Dispose();
                comando.Connection.Close();
            }
        }

        //Crear tipo comando SELECT
        public static SqlCommand CrearComandoSelect_tv()
        {
            //Usar la conexion
            string _cadenaConexion = Configuracion.CadenaConexion;

            SqlConnection _conexion = new SqlConnection();
            _conexion.ConnectionString = _cadenaConexion;

            //Crear la instruccion select
            SqlCommand _comando = new SqlCommand();
            _comando = _conexion.CreateCommand();
            _comando.CommandType = CommandType.Text;

            return _comando;
        }

        //Ejecutar el tipo de comando SELECT
        public static DataTable EjecutarComandoSelect_tv(SqlCommand comando)
        {
            DataTable _table = new DataTable();
            try
            {
                comando.Connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = comando;
                adapter.Fill(_table);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                comando.Connection.Close();
            }

            return _table;

        }
    }
}
