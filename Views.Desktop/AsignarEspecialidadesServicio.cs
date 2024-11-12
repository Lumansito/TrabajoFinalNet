using Logic;
using Models.Entity.Models;

namespace Views.Desktop
{
    public partial class AsignarEspecialidadesServicio : Form
    {
        private Form hermano;
        private Servicio servicio;
        private bool cargar = false;

        public AsignarEspecialidadesServicio(Servicio _servicio, Form _hermano)
        {
            InitializeComponent();
            hermano = _hermano;
            servicio = _servicio;
        }

        private void AsignarEspecialidadesServicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            hermano.Visible = true;
        }

        private void Clear()
        {
            lbAsignadas.DataSource = null;
            lbNoAsignadas.DataSource = null;
        }

        private async void CargarListas()
        {
            var especialidadesServicio = servicio.Especialidades;
            lbAsignadas.DataSource = especialidadesServicio;

            var todasLasEspecialidades = (await EspecialidadesLogic.GetAll())?
                .Where(e => e.Activo == true)
                .ToList();
            lbNoAsignadas.DataSource = todasLasEspecialidades?
                .Where(e => !especialidadesServicio.Any(se => se.EspecialidadId == e.EspecialidadId))
                .ToList();
        }

        private void AsignarEspecialidadesServicio_Load(object sender, EventArgs e)
        {
            Clear();
            CargarListas();
        }

        private void buttonAsignar_Click(object sender, EventArgs e)
        {
            var especialidad = (Especialidad?)lbNoAsignadas.SelectedItem;
            if (especialidad != null && !servicio.Especialidades.Contains(especialidad))
            {
                servicio.Especialidades.Add(especialidad);
                Clear();
                CargarListas();
            }
            cargar = true;
        }

        private void buttonQuitar_Click(object sender, EventArgs e)
        {
            var especialidad = (Especialidad?)lbAsignadas.SelectedItem;
            if (especialidad != null && servicio.Especialidades.Contains(especialidad))
            {
                servicio.Especialidades.Remove(especialidad);
                Clear();
                CargarListas();
            }
            cargar = true;
        }

        private void AsignarEspecialidadesServicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cargar)
            {
                MessageBox.Show("Debe guardar los cambios antes de salir.");
                e.Cancel = true;
            }
        }

        private async void buttonGuardar_Click(object sender, EventArgs e)
        {
            var response = await ServiciosLogic.Update(servicio);
            if (response)
            {
                cargar = false;
                MessageBox.Show("Especialidades asignadas correctamente.");
            }
            else
            {
                MessageBox.Show("Error al asignar especialidades.");
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            cargar = false;
            this.Close();
        }
    }
}
