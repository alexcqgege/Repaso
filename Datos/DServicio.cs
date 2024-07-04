using System;
using System.Collections.Generic;
using System.Linq;

namespace Datos
{
    public class DServicio
    {
        public String Registrar(Servicio servicio)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Servicio.Add(servicio);
                    context.SaveChanges();
                }
                return "Registrado correctamente";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return ex.Message;
            }
        }

        public String Modificar(Servicio servicio)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Servicio servicioTemp = context.Servicio.Find(servicio.ServicioId);
                    servicioTemp.FechaHoraServicio = servicio.FechaHoraServicio;
                    servicioTemp.MecanicoId = servicio.MecanicoId;
                    servicioTemp.VehiculoId = servicio.VehiculoId;
                    context.SaveChanges();
                }
                return "Modificado correctamente";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return ex.Message;
            }
        }

        public String Atender(Servicio servicio)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Servicio servicioTemp = context.Servicio.Find(servicio.ServicioId);
                    servicioTemp.Atendido = servicio.Atendido;
                    context.SaveChanges();
                }
                return "Atendido correctamente";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return ex.Message;
            }
        }

        // Eliminación Física
        public String Eliminar(int servicioId)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Servicio servicioTemp = context.Servicio.Find(servicioId);
                    context.Servicio.Remove(servicioTemp);
                    context.SaveChanges();
                }
                return "Eliminado correctamente";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return ex.Message;
            }
        }

        public List<Servicio> ListarTodo()
        {
            List<Servicio> servicios = new List<Servicio>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    servicios = context.Servicio.ToList();
                }
                return servicios;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return servicios;
            }
        }
    }
}
