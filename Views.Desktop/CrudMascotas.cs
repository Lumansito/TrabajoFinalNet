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
            CargarDatos();
            CargarMascota();
        }

        public CrudMascotas(int clienteDni)
        {
            this.clienteDni = clienteDni;
            InitializeComponent();
            CargarDatos();
        }
        private async void CargarMascota()
        {
            var mascota = await MascotasLogic.GetOne(mascotaId);

            // Setear nombre y fecha de nacimiento
            textBoxNombre.Text = mascota.Nombre;
            dateTimePickerFechaNacimiento.Value = mascota.FechaNac > dateTimePickerFechaNacimiento.MinDate
                ? mascota.FechaNac
                : DateTime.Today;

            comboBoxRazas.SelectedValue = mascota.RazaId;
            comboBoxEspecies.SelectedValue = mascota.EspecieId;
        }


        private async void CargarDatos()
        {
            
                
                // Cargar ComboBox de Razas
                comboBoxRazas.Items.Clear();
                var razas = await RazasLogic.GetAll();
                comboBoxRazas.DisplayMember = "Nombre";
                comboBoxRazas.ValueMember = "RazaId";
                comboBoxRazas.DataSource = razas;
                

                // Cargar ComboBox de Especies
                comboBoxEspecies.Items.Clear();
                var especies = await EspeciesLogic.GetAll();
                comboBoxEspecies.DisplayMember = "Nombre";
                comboBoxEspecies.ValueMember = "EspecieId";
                comboBoxEspecies.DataSource = especies;
                
            
        }

       

        private async void button1_Click(object sender, EventArgs e)
        {
            {
                var mascota = await MascotasLogic.GetOne(mascotaId);

                // Actualizar datos de la mascota
                mascota.Nombre = textBoxNombre.Text;
                mascota.FechaNac = dateTimePickerFechaNacimiento.Value;

                // Asignar IDs seleccionados en los ComboBox
                if (comboBoxEspecies.SelectedValue != null)
                {
                    mascota.EspecieId = (int)comboBoxEspecies.SelectedValue;
                }

                if (comboBoxRazas.SelectedValue != null)
                {
                    mascota.RazaId = (int)comboBoxRazas.SelectedValue;
                }

                // Actualizar la mascota
                await MascotasLogic.Update(mascota);
                Dispose();
            }
        }

        private async void buttonAgregar_Click(object sender, EventArgs e)
        {
            Mascota mascota = new();

            // Obtener cliente por DNI
            Cliente cliente = await ClientesLogic.GetByDni(clienteDni);
            mascota.ClienteId = cliente.ClienteId;

            // Asignar datos de la mascota
            mascota.Nombre = textBoxNombre.Text;

            // Asignar RazaId y EspecieId usando SelectedValue
            if (comboBoxRazas.SelectedValue != null)
            {
                mascota.RazaId = (int)comboBoxRazas.SelectedValue;
            }

            if (comboBoxEspecies.SelectedValue != null)
            {
                mascota.EspecieId = (int)comboBoxEspecies.SelectedValue;
            }

            mascota.FechaNac = dateTimePickerFechaNacimiento.Value;
            mascota.FechaDefuncion = DateTime.MaxValue;

            // Crear mascota en la base de datos
            var result = await MascotasLogic.Create(mascota);
            if (!result)
            {
                MessageBox.Show("Error al intentar crear la mascota.");
                return;
            }
            MessageBox.Show("Mascota registrada con éxito!");
        }
    }
}
