using Datos;
using Datos.util;
using System;
using System.Collections.Generic;

namespace Negocio
{
    public class NReporte
    {

        private DReporte dReporte = new DReporte();
        public List<ReporteServicio> ObtenerServiciosEnRangoDeFechasPorTipoDeServicio(
           DateTime fechaInicio, DateTime fechaFin, String tipoServicio)
        {
            return dReporte.ObtenerServiciosEnRangoDeFechasPorTipoDeServicio(fechaInicio, fechaFin, tipoServicio);
        }

        public List<ReporteCantidad> ObtenerCantidadServiciosAtendidosPorMecanico()
        {
            return dReporte.ObtenerCantidadServiciosAtendidosPorMecanico();

        }
    }
}
