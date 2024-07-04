using System;
using System.Collections.Generic;
using System.Linq;

namespace Datos
{
    public class DMecanico
    {
        public List<Mecanico> ListarTodo()
        {
            List<Mecanico> mecanicos = new List<Mecanico>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    mecanicos = context.Mecanico.Where(m => m.Eliminado == false).ToList();
                }
                return mecanicos;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return mecanicos;
            }
        }
    }
}
