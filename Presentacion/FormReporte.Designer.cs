
namespace Presentacion
{
    partial class FormReporte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaHoraFin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTipoServicio = new System.Windows.Forms.ComboBox();
            this.btnObtenerServiciosEnRangoDeFechasPorTipoDeServicio = new System.Windows.Forms.Button();
            this.btnObtenerCantidadServiciosAtendidosPorMecanico = new System.Windows.Forms.Button();
            this.dgReporteServicios = new System.Windows.Forms.DataGridView();
            this.dgReporteCantidad = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgReporteServicios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgReporteCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fecha y Hora Inicio:";
            // 
            // dtpFechaHoraInicio
            // 
            this.dtpFechaHoraInicio.CustomFormat = "dd/MM/yyyy hh:mm:ss tt";
            this.dtpFechaHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaHoraInicio.Location = new System.Drawing.Point(122, 12);
            this.dtpFechaHoraInicio.Name = "dtpFechaHoraInicio";
            this.dtpFechaHoraInicio.Size = new System.Drawing.Size(178, 20);
            this.dtpFechaHoraInicio.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Fecha y Hora Fin:";
            // 
            // dtpFechaHoraFin
            // 
            this.dtpFechaHoraFin.CustomFormat = "dd/MM/yyyy hh:mm:ss tt";
            this.dtpFechaHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaHoraFin.Location = new System.Drawing.Point(122, 38);
            this.dtpFechaHoraFin.Name = "dtpFechaHoraFin";
            this.dtpFechaHoraFin.Size = new System.Drawing.Size(178, 20);
            this.dtpFechaHoraFin.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tipo Servicio:";
            // 
            // cbTipoServicio
            // 
            this.cbTipoServicio.FormattingEnabled = true;
            this.cbTipoServicio.Items.AddRange(new object[] {
            "Cambio de Aceite",
            "Cambio de Suspensión",
            "Revisión llantas",
            "Revisión Freno",
            "Cambio Amortiguadores"});
            this.cbTipoServicio.Location = new System.Drawing.Point(122, 64);
            this.cbTipoServicio.Name = "cbTipoServicio";
            this.cbTipoServicio.Size = new System.Drawing.Size(178, 21);
            this.cbTipoServicio.TabIndex = 12;
            // 
            // btnObtenerServiciosEnRangoDeFechasPorTipoDeServicio
            // 
            this.btnObtenerServiciosEnRangoDeFechasPorTipoDeServicio.Location = new System.Drawing.Point(17, 102);
            this.btnObtenerServiciosEnRangoDeFechasPorTipoDeServicio.Name = "btnObtenerServiciosEnRangoDeFechasPorTipoDeServicio";
            this.btnObtenerServiciosEnRangoDeFechasPorTipoDeServicio.Size = new System.Drawing.Size(283, 42);
            this.btnObtenerServiciosEnRangoDeFechasPorTipoDeServicio.TabIndex = 14;
            this.btnObtenerServiciosEnRangoDeFechasPorTipoDeServicio.Text = "Obtener Servicios en Rango de Fechas por Tipo de Servicio";
            this.btnObtenerServiciosEnRangoDeFechasPorTipoDeServicio.UseVisualStyleBackColor = true;
            this.btnObtenerServiciosEnRangoDeFechasPorTipoDeServicio.Click += new System.EventHandler(this.btnObtenerServiciosEnRangoDeFechasPorTipoDeServicio_Click);
            // 
            // btnObtenerCantidadServiciosAtendidosPorMecanico
            // 
            this.btnObtenerCantidadServiciosAtendidosPorMecanico.Location = new System.Drawing.Point(17, 228);
            this.btnObtenerCantidadServiciosAtendidosPorMecanico.Name = "btnObtenerCantidadServiciosAtendidosPorMecanico";
            this.btnObtenerCantidadServiciosAtendidosPorMecanico.Size = new System.Drawing.Size(283, 42);
            this.btnObtenerCantidadServiciosAtendidosPorMecanico.TabIndex = 15;
            this.btnObtenerCantidadServiciosAtendidosPorMecanico.Text = "Obtener Cantidad de Servicios Atendidos por Mecánico";
            this.btnObtenerCantidadServiciosAtendidosPorMecanico.UseVisualStyleBackColor = true;
            this.btnObtenerCantidadServiciosAtendidosPorMecanico.Click += new System.EventHandler(this.btnObtenerCantidadServiciosAtendidosPorMecanico_Click);
            // 
            // dgReporteServicios
            // 
            this.dgReporteServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReporteServicios.Location = new System.Drawing.Point(319, 12);
            this.dgReporteServicios.Name = "dgReporteServicios";
            this.dgReporteServicios.Size = new System.Drawing.Size(469, 199);
            this.dgReporteServicios.TabIndex = 16;
            // 
            // dgReporteCantidad
            // 
            this.dgReporteCantidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReporteCantidad.Location = new System.Drawing.Point(319, 228);
            this.dgReporteCantidad.Name = "dgReporteCantidad";
            this.dgReporteCantidad.Size = new System.Drawing.Size(469, 199);
            this.dgReporteCantidad.TabIndex = 17;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(102, 402);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(123, 25);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgReporteCantidad);
            this.Controls.Add(this.dgReporteServicios);
            this.Controls.Add(this.btnObtenerCantidadServiciosAtendidosPorMecanico);
            this.Controls.Add(this.btnObtenerServiciosEnRangoDeFechasPorTipoDeServicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbTipoServicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFechaHoraFin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpFechaHoraInicio);
            this.Name = "FormReporte";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.FormReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgReporteServicios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgReporteCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechaHoraInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaHoraFin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTipoServicio;
        private System.Windows.Forms.Button btnObtenerServiciosEnRangoDeFechasPorTipoDeServicio;
        private System.Windows.Forms.Button btnObtenerCantidadServiciosAtendidosPorMecanico;
        private System.Windows.Forms.DataGridView dgReporteServicios;
        private System.Windows.Forms.DataGridView dgReporteCantidad;
        private System.Windows.Forms.Button btnSalir;
    }
}