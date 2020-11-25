using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.TipoVehiculo
{
    public class AccesoMetodosCRUDtipoVehiculo
    {
        //Crear la operación INSERT
        public int InsertTipoVehiculo(int id, string nombre)
        {
            SqlCommand _comando = MetodosCRUDtipoVehiculo.CrearComandoProcAlmacInsert_tv();

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@nombre", nombre);

            return MetodosCRUDtipoVehiculo.EjecutarComandoProcAlmacInsert_tv(_comando);
        }

        //Operacion SELECT
        public static DataTable ListTipoVehiculo() 
        {
            SqlCommand _comando = MetodosCRUDtipoVehiculo.CrearComandoSelect_tv();

            _comando.CommandText = "select * from Tipo_Vehiculo";

            return MetodosCRUDtipoVehiculo.EjecutarComandoSelect_tv(_comando);
        }
    }
}
