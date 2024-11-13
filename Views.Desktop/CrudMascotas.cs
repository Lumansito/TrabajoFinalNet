using Logic;
using Models.Entity.Models;

namespace Views.Desktop
{
    public partial class CrudMascotas : Form
    {
        private int dniCliente;
        private int nroMascota;

        public CrudMascotas(int dniCliente, int nroMascota)
        {
            this.dniCliente = dniCliente;
            this.nroMascota = nroMascota;
            InitializeComponent();
            CargarDatos(dniCliente, nroMascota);
        }

        private async void CargarDatos(int dniCliente, int nroMascota)
        {
            var mascota = await MascotasLogic.GetOne(dniCliente);

            textBoxNombre.Text = mascota.Nombre;

            dateTimePickerFechaNacimiento.Value = mascota.FechaNac;

            comboBoxRazas.Items.Clear();
            //var raza = await RazasLogic.GetOne(mascota.CodRaza.Value);
            //comboBoxRazas.Text = raza.NombreRaza;
            var razas = await RazasLogic.GetAll();
            foreach (var r in razas)
            {
                comboBoxRazas.Items.Add(r.Nombre);
            }
            comboBoxRazas.Refresh();

            comboBoxEspecies.Items.Clear();
            var especie = await EspeciesLogic.GetOne(mascota.EspecieId);
            comboBoxEspecies.Text = especie.Nombre;
            var especies = await EspeciesLogic.GetAll();
            foreach (var e in especies)
            {
                comboBoxEspecies.Items.Add(e.Nombre);
            }
            comboBoxEspecies.Refresh();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var mascota = await MascotasLogic.GetOne(dniCliente);
            mascota.Nombre = textBoxNombre.Text;
            mascota.FechaNac = dateTimePickerFechaNacimiento.Value;
            
            if (comboBoxEspecies.SelectedIndex == -1)
            {
                mascota.EspecieId = comboBoxEspecies.SelectedIndex + 2;
            }
            else mascota.EspecieId = comboBoxEspecies.SelectedIndex + 1;

            if (comboBoxRazas.SelectedIndex == -1)
            {
                mascota.EspecieId = comboBoxRazas.SelectedIndex + 2;
            }
            else mascota.EspecieId = comboBoxRazas.SelectedIndex + 1;

            await MascotasLogic.Update(mascota);
            Dispose();
        }
    }
}
