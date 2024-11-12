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
using Logic;

namespace Views.Desktop
{
    public partial class CrudRazas : Form
    {
        public CrudRazas(Form padre)
        {
            this.MdiParent = padre;
            InitializeComponent();
        }
        Raza raza = new();

        private void Clear()
        {
            txtNombre.Text = "";
        }
        private async void LoadData()
        {
            dgvRazas.AutoGenerateColumns = false; //momentaneamente, deberian estar establecidas las columnas
            List<Raza> list = await RazasLogic.GetAll();
            dgvRazas.DataSource = list;
        }

        private void CrudRazas_Load(object sender, EventArgs e)
        {
            Clear();
            this.ActiveControl = txtNombre;
            LoadData();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Error, algun parametro es cadena vacia", "Error");
            }
            else
            {
                raza.Nombre = txtNombre.Text.Trim();

                bool success;
                if (btnGuardar.Text == "Guardar")
                {
                    success = await RazasLogic.Crear(raza);
                }
                else
                {
                    success = await RazasLogic.Editar(raza);
                }
                
                if (success)
                {
                    MessageBox.Show("Guardado correctamente", "Mensaje");
                }
                else
                {
                    MessageBox.Show("Error al guardar", "Error");
                }
                Clear();
                LoadData();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Clear();
            btnGuardar.Text = "Guardar";

        }

        private async void btnBorrar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show(text: "Estas seguro que queres borrar?", caption: "Confirmación", buttons: MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                int Id = Convert.ToInt32(this.dgvRazas.CurrentRow.Cells["RazaId"].Value);
                var estado = await RazasLogic.Eliminar(Id);
                LoadData();
                Clear();
                if (estado)
                {
                    MessageBox.Show("Se elimino correctamente", "Mensaje");

                }
                else
                {
                    MessageBox.Show("Error al eliminar", "Error");

                }
            }
        }

        private async void dgvRazas_DoubleClick(object sender, EventArgs e)
        {
            if (dgvRazas.CurrentRow.Index != -1)
            {

                int id = Convert.ToInt32(this.dgvRazas.CurrentRow.Cells["RazaId"].Value);


                raza = await RazasLogic.GetOne(id);

                
                txtNombre.Text = raza.Nombre;
               
                btnGuardar.Text = "Editar";
                btnBorrar.Enabled = true;
                
            }
        }
    }
}

