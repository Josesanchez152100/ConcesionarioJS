using Modelo.TipoVehiculo;
using System.Data;

namespace Controlador.TipoVehiculo
{
    public class logicaControladorTipoVehiculo
    {
        //Negociar INSERT
        public int NegociarInsertTipoVehiculo(int id, string name)
        {
            AccesoMetodosCRUDtipoVehiculo negociarAcceso = new AccesoMetodosCRUDtipoVehiculo();

            return negociarAcceso.InsertTipoVehiculo(id, name);
        }

        //Negociar SELECT
        public static DataTable NegociarSelectTipoVehiculo()
        {
            return AccesoMetodosCRUDtipoVehiculo.ListTipoVehiculo();
        }
    }
}
