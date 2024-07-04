using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormServicio : Form
    {
        private NVehiculo nVehiculo = new NVehiculo();
        private NMecanico nMecanico = new NMecanico();
        private NServicio nServicio = new NServicio();

        public FormServicio()
        {
            InitializeComponent();
            MostrarVehiculos(nVehiculo.ListarTodo());
            MostrarMecanicos(nMecanico.ListarTodo());
            MostrarServicios(nServicio.ListarTodo());
        }

        private void MostrarVehiculos(List<Vehiculo> vehiculos)
        {
            cbVehiculo.DataSource = null;
            if (vehiculos.Count == 0)
            {
                return;
            }
            else
            {
                cbVehiculo.DataSource = vehiculos;
                cbVehiculo.ValueMember = "VehiculoId";
                cbVehiculo.DisplayMember = "Placa";
            }
        }

        private void MostrarMecanicos(List<Mecanico> mecanicos)
        {
            cbMecanico.DataSource = null;
            if (mecanicos.Count == 0)
            {
                return;
            }
            else
            {
                cbMecanico.DataSource = mecanicos;
                cbMecanico.ValueMember = "MecanicoId";
                cbMecanico.DisplayMember = "NombreCompleto";
            }
        }

        private void MostrarServicios(List<Servicio> servicios)
        {
            dgServicios.DataSource = null;
            if (servicios.Count == 0)
            {
                return;
            }
            else
            {
                dgServicios.DataSource = servicios;
                dgServicios.Columns["Vehiculo"].Visible = false;
                dgServicios.Columns["Mecanico"].Visible = false;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validación de campos vacíos
            if (cbVehiculo.Text == "" || cbMecanico.Text == "" || cbTipoServicio.Text == "" || dtpFechaHoraServicio.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Validación de fecha
            if (dtpFechaHoraServicio.Value < DateTime.Now)
            {
                MessageBox.Show("Ingrese una fecha y hora mayor a la actual");
                return;
            }

            int vehiculoId = int.Parse(cbVehiculo.SelectedValue.ToString());
            int mecanicoId = int.Parse(cbMecanico.SelectedValue.ToString());
            Servicio servicio = new Servicio()
            {
                VehiculoId = vehiculoId,
                MecanicoId = mecanicoId,
                TipoServicio = cbTipoServicio.Text,
                FechaHoraServicio = dtpFechaHoraServicio.Value
            };

            String mensaje = nServicio.Registrar(servicio);
            MessageBox.Show(mensaje);

            MostrarServicios(nServicio.ListarTodo());
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Validación de campos vacíos
            if (cbVehiculo.Text == "" || cbMecanico.Text == "" || dtpFechaHoraServicio.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Validación de fecha
            if (dtpFechaHoraServicio.Value < DateTime.Now)
            {
                MessageBox.Show("Ingrese una fecha y hora mayor a la actual");
                return;
            }

            // Validacion de selección
            if (dgServicios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione registro a modificar");
                return;
            }

            int vehiculoId = int.Parse(cbVehiculo.SelectedValue.ToString());
            int mecanicoId = int.Parse(cbMecanico.SelectedValue.ToString());

            //int servicioId = int.Parse(dgServicios.SelectedRows[0].Cells[0].Value.ToString());
            int servicioId = int.Parse(dgServicios.SelectedRows[0].Cells["ServicioId"].Value.ToString());

            Servicio servicio = new Servicio()
            {
                // Obligatorio
                ServicioId = servicioId,
                VehiculoId = vehiculoId,
                MecanicoId = mecanicoId,
                FechaHoraServicio = dtpFechaHoraServicio.Value
            };

            String mensaje = nServicio.Modificar(servicio);
            MessageBox.Show(mensaje);

            MostrarServicios(nServicio.ListarTodo());
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            // Validacion de selección
            if (dgServicios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione registro a modificar");
                return;
            }

            //int servicioId = int.Parse(dgServicios.SelectedRows[0].Cells[0].Value.ToString());
            int servicioId = int.Parse(dgServicios.SelectedRows[0].Cells["ServicioId"].Value.ToString());

            Servicio servicio = new Servicio()
            {
                // Obligatorio
                ServicioId = servicioId
            };

            String mensaje = nServicio.Atender(servicio);
            MessageBox.Show(mensaje);

            MostrarServicios(nServicio.ListarTodo());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Validacion de selección
            if (dgServicios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione registro a eliminar");
                return;
            }

            //int servicioId = int.Parse(dgServicios.SelectedRows[0].Cells[0].Value.ToString());
            int servicioId = int.Parse(dgServicios.SelectedRows[0].Cells["ServicioId"].Value.ToString());

            // Diálogo de confirmación
            DialogResult dialog = MessageBox.Show("¿Está seguro de eliminar el servicio con ServicioId: " + servicioId, "", MessageBoxButtons.YesNo);

            if (dialog.Equals(DialogResult.Yes))
            {
                String mensaje = nServicio.Eliminar(servicioId);
                MessageBox.Show(mensaje);

                MostrarServicios(nServicio.ListarTodo());
            }
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FormReporte form = new FormReporte();
            form.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgServicios_SelectionChanged(object sender, EventArgs e)
        {
            // Validación de selección
            if (dgServicios.SelectedRows.Count == 0)
            {
                return;
            }

            cbVehiculo.SelectedValue = dgServicios.SelectedRows[0].Cells["VehiculoId"].Value;
            cbMecanico.SelectedValue = dgServicios.SelectedRows[0].Cells["MecanicoId"].Value;
            cbTipoServicio.Text = dgServicios.SelectedRows[0].Cells["TipoServicio"].Value.ToString();
            dtpFechaHoraServicio.Value = (DateTime)dgServicios.SelectedRows[0].Cells["FechaHoraServicio"].Value;
        }

        private void s(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
