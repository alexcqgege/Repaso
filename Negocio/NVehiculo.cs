using Datos;
using System.Collections.Generic;

namespace Negocio
{
    public class NVehiculo
    {
        private DVehiculo dVehiculo = new DVehiculo();

        public List<Vehiculo> ListarTodo()
        {
            return dVehiculo.ListarTodo();
        }
    }
}
