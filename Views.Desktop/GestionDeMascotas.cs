using Logic;
using Models.Entity.Clases;
using Models.Entity.Models;
using Models.Models;
using System.Net;

namespace Views.Desktop
{
    public partial class GestionDeMascotas : Form
    {
        public GestionDeMascotas(Form padre)
        {
            InitializeComponent();
            this.MdiParent = padre;
        }

        private async void buttonBuscarMascotas_Click(object sender, EventArgs e)
        {
            int dni = int.Parse(textBoxDni.Text);
            List<Mascota>? mascotas = await MascotasLogic.GetAllByDni(dni);
            if (mascotas == null)
            {
                MessageBox.Show("No se han encontrado mascotas con el dni proporcionado.");
            }
            else
            {
                List<ListadoMascotas> listado = [];
                foreach (Mascota mascota in mascotas)
                {
                    ListadoMascotas lm = new()
                    {
                        MascotaId = mascota.MascotaId,
                        NombreMascota = mascota.Nombre,
                        Edad = ((DateTime.Now - mascota.FechaNac).Days) / 365,
                        NombreRaza = mascota.Raza.Nombre,
                        NombreEspecie = mascota.Especie.Nombre,
                        FechaDefuncion = mascota.FechaDefuncion,
                    };
                    listado.Add(lm);
                }
                dgvGestionDeMascotas.DataSource = listado;
                var cliente = await ClientesLogic.GetByDni(dni);
                labelNombreDueño.Text = cliente.Nombre + " " + cliente.Apellido;
            }
        }

        private async void dgvGestionDeMascotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dni = int.Parse(textBoxDni.Text);
            int mascotaId = Convert.ToInt32(dgvGestionDeMascotas.Rows[e.RowIndex].Cells["MascotaId"].Value);
            if (e.RowIndex >= 0 && dgvGestionDeMascotas.Columns[e.ColumnIndex].Name == "editar")
            {
                CrudMascotas crudMascotas = new CrudMascotas(mascotaId, dni);
                crudMascotas.MdiParent = this.MdiParent;
                crudMascotas.Show();
            }
            if (dgvGestionDeMascotas.Columns[e.ColumnIndex].Name == "eliminar")
            {
                Mascota? mascota = await MascotasLogic.GetOne(mascotaId);
                if (mascota != null)
                {
                    await MascotasLogic.Delete(mascota);
                    MessageBox.Show("Mascota eliminada con exito!");
                }
                else
                {
                    MessageBox.Show("Error al intentar eliminar la mascota.");
                }
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            string dni = textBoxDni.Text;
            CrudMascotas crudMascotas = new CrudMascotas(Convert.ToInt32(dni));
            crudMascotas.MdiParent = this.MdiParent;
            crudMascotas.Show();
        }
    }
}
