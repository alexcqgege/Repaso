using Datos.util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Datos
{
    public class DReporte
    {

        public List<ReporteServicio> ObtenerServiciosEnRangoDeFechasPorTipoDeServicio(
            DateTime fechaInicio, DateTime fechaFin, String tipoServicio)
        {
            List<ReporteServicio> reporte = new List<ReporteServicio>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    reporte = context.Servicio
                        .Where(s =>
                            s.FechaHoraServicio >= fechaInicio &&
                            s.FechaHoraServicio <= fechaFin &&
                            s.TipoServicio.Equals(tipoServicio)

                        )
                        .Select(r => new ReporteServicio()
                        {
                            FechaHoraServicio = r.FechaHoraServicio,
                            PlacaVehiculo = r.Vehiculo.Placa,
                            NombreCompletoMecanico = r.Mecanico.NombreCompleto

                        }
                        )
                        .ToList();
                    return reporte;
                }

            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                return reporte;
            }
        }

        public List<ReporteCantidad> ObtenerCantidadServiciosAtendidosPorMecanico(
            )
        {
            List<ReporteCantidad> reporte = new List<ReporteCantidad>();
            try
            {
                using (var context = new BDEFEntities())

                {

                    reporte = context.Servicio
                        .Where(
                        s => s.Atendido == true)
                        .GroupBy(s => s.Mecanico.NombreCompleto)
                        .Select(r => new ReporteCantidad
                        {   // key es las propiedad por la cual se esta haciendo el group by osea ahora lo estoy agrupando por mecanico nombre

                            NombreCompletoMecanico = r.Key,
                            Cantidad = r.Count(),
                            //si es promedio : Cantidad= r.Average(r => r."y aca va la propiedad igual en sum"),
                            // si es sumatoria : Cantidad = r.Sum(),
                        }

                        )
                        .ToList();


                    return reporte;
                }


            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                return reporte;
            }

        }
    }
}