using Logic;
using Models.Entity.Models;
using System.Net;

namespace Views.Desktop
{
    public partial class CrudMascotas : Form
    {
        private int mascotaId;
        private int clienteDni;

        public CrudMascotas(int mascotaId, int clienteDni)
        {
            this.mascotaId = mascotaId;
            InitializeComponent();
            CargarDatos(mascotaId);
        }

        public CrudMascotas(int clienteDni)
        {
            this.clienteDni = clienteDni;
            InitializeComponent();
            CargarDatos();
        }

        private async void CargarDatos(int mascotaId)
        {
            Mascota? mascota = await MascotasLogic.GetOne(mascotaId);
            if (mascota != null)
            {
                textBoxNombre.Text = mascota.Nombre;
                dateTimePickerFechaNacimiento.Value = mascota.FechaNac;

                comboBoxRazas.Items.Clear();
                comboBoxRazas.Text = mascota.Raza.Nombre;
                List<Raza>? razas = await RazasLogic.GetAll();
                foreach (Raza raza in razas)
                {
                    comboBoxRazas.Items.Add(raza.Nombre);
                }
                comboBoxRazas.Refresh();

                comboBoxEspecies.Items.Clear();
                comboBoxEspecies.Text = mascota.Especie.Nombre;
                List<Especie>? especies = await EspeciesLogic.GetAll();
                foreach (Especie especie in especies)
                {
                    comboBoxEspecies.Items.Add(especie.Nombre);
                }
                comboBoxEspecies.Refresh();
            }
        }

        private async void CargarDatos()
        {
            comboBoxRazas.Items.Clear();
            var razas = await RazasLogic.GetAll();
            foreach (var raza in razas)
            {
                comboBoxRazas.Items.Add(raza.Nombre);
            }
            comboBoxRazas.Refresh();

            comboBoxEspecies.Items.Clear();
            var especies = await EspeciesLogic.GetAll();
            foreach (var especie in especies)
            {
                comboBoxEspecies.Items.Add(especie.Nombre);
            }
            comboBoxEspecies.Refresh();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Mascota? mascota = await MascotasLogic.GetOne(mascotaId);
            if (mascota != null)
            {
                mascota.Nombre = textBoxNombre.Text;
                mascota.FechaNac = dateTimePickerFechaNacimiento.Value;
                if (comboBoxRazas.SelectedIndex != -1)
                {
                    mascota.RazaId = comboBoxRazas.SelectedIndex + 1;
                }
                if (comboBoxEspecies.SelectedIndex != -1)
                {
                    mascota.EspecieId = comboBoxEspecies.SelectedIndex + 1;
                }
                await MascotasLogic.Update(mascota);
                Dispose();
            }
        }

        private async void buttonAgregar_Click(object sender, EventArgs e)
        {
            Mascota mascota = new();
            Cliente cliente = await ClientesLogic.GetByDni(clienteDni);
            mascota.ClienteId = cliente.ClienteId;
            mascota.Nombre = textBoxNombre.Text;
            if (comboBoxRazas.SelectedIndex != -1)
            {
                mascota.RazaId = comboBoxRazas.SelectedIndex + 1;
            }
            if (comboBoxEspecies.SelectedIndex != -1)
            {
                mascota.EspecieId = comboBoxEspecies.SelectedIndex + 1;
            }
            mascota.FechaNac = dateTimePickerFechaNacimiento.Value;
            mascota.FechaDefuncion = DateTime.MaxValue;
            await MascotasLogic.Create(mascota);
            MessageBox.Show("Mascota registrada con exito!");
        }
    }
}
