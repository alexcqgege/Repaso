using Datos;
using System;
using System.Collections.Generic;

namespace Negocio
{
    public class NServicio
    {
        private DServicio dServicio = new DServicio();

        public String Registrar(Servicio servicio)
        {
            servicio.Atendido = false;
            servicio.FechaCreacion = DateTime.Now;
            return dServicio.Registrar(servicio);
        }

        public String Modificar(Servicio servicio)
        {
            return dServicio.Modificar(servicio);
        }

        public String Atender(Servicio servicio)
        {
            servicio.Atendido = true;
            return dServicio.Atender(servicio);
        }

        // Eliminado Lógico
        public String Eliminar(int servicioId)
        {
            return dServicio.Eliminar(servicioId);
        }

        public List<Servicio> ListarTodo()
        {
            return dServicio.ListarTodo();
        }

    }
}
