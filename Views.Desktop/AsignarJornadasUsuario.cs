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
    public partial class AsignarJornadasUsuario : Form
    {
        private Form hermano;
        private Usuario usuario;
        private List<Jornada> todasLasJornadas;
        private bool cargar = false;
        public AsignarJornadasUsuario(Usuario _usuario, Form _hermano)
        {
            InitializeComponent();
            hermano = _hermano;
            usuario = _usuario;
        }

        private void AsignarJornadasUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            hermano.Visible = true;
        }

        private void CargarListas()
        {
            // Jornadas asignadas al usuario
            listBoxAsignadas.DataSource = null;
            listBoxAsignadas.DataSource = usuario.Jornadas;


            // Jornadas disponibles (excluye las que ya están asignadas)
            var jornadasNoAsignadas = todasLasJornadas
                .Where(j => !usuario.Jornadas.Any(uj => uj.JornadaId == j.JornadaId))
                .ToList();
            listBoxJornadas.DataSource = null;
            listBoxJornadas.DataSource = jornadasNoAsignadas;
        }

        private async void AsignarJornadasUsuario_Load(object sender, EventArgs e)
        {
            todasLasJornadas = await JornadasLogic.GetAll();
            todasLasJornadas = todasLasJornadas.Where(j => j.Activo == true).ToList();
            CargarListas();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            var jornadaSeleccionada = (Jornada)listBoxJornadas.SelectedItem;
            if (jornadaSeleccionada != null && !usuario.Jornadas.Contains(jornadaSeleccionada))
            {
                usuario.Jornadas.Add(jornadaSeleccionada);
                CargarListas();
            }
            cargar = true;

        }

        private void btnDesasignar_Click(object sender, EventArgs e)
        {
            var jornadaSeleccionada = (Jornada)listBoxAsignadas.SelectedItem;
            if (jornadaSeleccionada != null && usuario.Jornadas.Contains(jornadaSeleccionada))
            {
                usuario.Jornadas.Remove(jornadaSeleccionada);
                CargarListas();
            }
            cargar = true;
        }

        private void AsignarJornadasUsuario_FormClosing(object sender, FormClosingEventArgs e)
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
                MessageBox.Show("Jornadas asignadas correctamente");
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
