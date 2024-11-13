using Logic;
using Models.Entity.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views.Desktop
{
    public partial class GestionDeMascotas : Form
    {
        private Form _padre;
        public GestionDeMascotas(Form padre)
        {
            InitializeComponent();
            this.MdiParent = padre;
            _padre = padre;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            int dni = int.Parse(textBoxDni.Text);
            var mascotas = await MascotasLogic.GetAllByDni(dni);
            dgvGestionDeMascotas.DataSource = mascotas.ToList();
            var dueno = await ClientesLogic.GetByDni(dni);
            labelNombreDueño.Text = dueno.Nombre + " " + dueno.Apellido;
        }

        private async void dgvGestionDeMascotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dniCliente = int.Parse(textBoxDni.Text);
            var nroMascota = e.RowIndex + 1;
            if (e.RowIndex >= 0 && dgvGestionDeMascotas.Columns[e.ColumnIndex].Name == "editar")
            {
                CrudMascotas crudMascotas = new CrudMascotas(dniCliente, nroMascota);
                crudMascotas.MdiParent = this.MdiParent;
                crudMascotas.Show();
            }
            if (dgvGestionDeMascotas.Columns[e.ColumnIndex].Name == "eliminar")
            {
                var mascota = await MascotasLogic.GetOne(dniCliente);
                await MascotasLogic.Delete(mascota);
            }
        }
    }
}
