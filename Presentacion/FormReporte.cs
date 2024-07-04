using Datos.util;
using Negocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormReporte : Form
    {
        private NReporte nReporte = new NReporte();

        public FormReporte()
        {
            InitializeComponent();
        }

        private void MostrarReporteServicio(List<ReporteServicio> reporteServicio)
        {
            dgReporteServicios.DataSource = null;
            if(reporteServicio.Count == 0 ) 
            {
                return;
            }
            else
            {
                dgReporteServicios.DataSource= reporteServicio;
            }
        }
        private void MostrarReporteCantidad(List<ReporteCantidad> reporteCantidad)
        {
            dgReporteServicios.DataSource = null;
            if (reporteCantidad.Count == 0)
            {
                return;
            }
            else
            {
                dgReporteServicios.DataSource = reporteCantidad;
            }
        }

        private void btnObtenerServiciosEnRangoDeFechasPorTipoDeServicio_Click(object sender, EventArgs e)
        {
            // Validación de campos vacíos
            if (dtpFechaHoraInicio.Text == "" || dtpFechaHoraFin.Text == "" || cbTipoServicio.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Validación de fecha
            if (dtpFechaHoraInicio.Value > dtpFechaHoraFin.Value)
            {
                MessageBox.Show("La Fecha Inicio no puede ser mayor a la Fecha Fin");
                return;
            }

            MostrarReporteServicio(nReporte.ObtenerServiciosEnRangoDeFechasPorTipoDeServicio(dtpFechaHoraInicio.Value, dtpFechaHoraFin.Value
               ,cbTipoServicio.Text));
        }

        private void btnObtenerCantidadServiciosAtendidosPorMecanico_Click(object sender, EventArgs e)
        {
            // TO DO
            MostrarReporteCantidad(nReporte.ObtenerCantidadServiciosAtendidosPorMecanico());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormReporte_Load(object sender, EventArgs e)
        {

        }
    }
}
