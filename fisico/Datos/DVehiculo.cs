using System;
using System.Collections.Generic;
using System.Linq;

namespace Datos
{
    public class DVehiculo
    {
        public List<Vehiculo> ListarTodo()
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    vehiculos = context.Vehiculo.Where(m => m.Eliminado == false).ToList();
                }
                return vehiculos;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return vehiculos;
            }
        }
    }
}
