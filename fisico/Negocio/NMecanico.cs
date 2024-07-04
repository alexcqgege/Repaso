using Datos;
using System.Collections.Generic;

namespace Negocio
{
    public class NMecanico
    {
        private DMecanico dMecanico = new DMecanico();

        public List<Mecanico> ListarTodo()
        {
            return dMecanico.ListarTodo();
        }
    }
}
