using Logic;
using Models.Entity.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views.Desktop
{
    public partial class AsignarEspecialidadesUsuario : Form
    {
        private Form hermano;
        private Usuario usuario;
        private List<Especialidad> todasLasEpecialidades;
        private bool cargar = false;
        public AsignarEspecialidadesUsuario(Usuario _usuario, Form _hermano)
        {
            InitializeComponent();
            hermano = _hermano;
            usuario = _usuario;

        }

        private void AsignarEspecialidadesUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            hermano.Visible = true;
        }

        private void CargarListas()
        {
            // Jornadas asignadas al usuario
            listBoxAsignadas.DataSource = null;
            listBoxAsignadas.DataSource = usuario.Especialidades;


            // Jornadas disponibles (excluye las que ya están asignadas)
            var especialidadesNoAsignadas = todasLasEpecialidades
                .Where(j => !usuario.Especialidades.Any(ue => ue.EspecialidadId == j.EspecialidadId))
                .ToList();
            listBoxEspecialidades.DataSource = null;
            listBoxEspecialidades.DataSource = especialidadesNoAsignadas;
        }

        private async void AsignarEspecialidadesUsuario_Load(object sender, EventArgs e)
        {
            todasLasEpecialidades = await EspecialidadesLogic.GetAll();
            todasLasEpecialidades = todasLasEpecialidades.Where(j => j.Activo == true).ToList();
            CargarListas();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            var especialidadSeleccionada = (Especialidad)listBoxEspecialidades.SelectedItem;
            if (especialidadSeleccionada != null && !usuario.Especialidades.Contains(especialidadSeleccionada))
            {
                usuario.Especialidades.Add(especialidadSeleccionada);
                CargarListas();
            }
            cargar = true;
        }

        private void btnDesasignar_Click(object sender, EventArgs e)
        {
            var especialidadSeleccionada = (Especialidad)listBoxAsignadas.SelectedItem;
            if (especialidadSeleccionada != null && usuario.Especialidades.Contains(especialidadSeleccionada))
            {
                usuario.Especialidades.Remove(especialidadSeleccionada);
                CargarListas();
            }
            cargar = true;
        }

        private void AsignarEspecialidadesUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cargar)
            {
                MessageBox.Show("Debe guardar los cambios antes de salir");
                e.Cancel = true;
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            var result = await UsuariosLogic.Editar(usuario);
            if (result)
            {
                cargar = false;
                MessageBox.Show("Especialidades asignadas correctamente");
            }
            else
            {
                MessageBox.Show("Error al asignar jornadas");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cargar = false;
            this.Close();
        }
    }
}
