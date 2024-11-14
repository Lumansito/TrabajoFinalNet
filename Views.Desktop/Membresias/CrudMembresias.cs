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

namespace Views.Desktop.Membresias
{
    public partial class CrudMembresias : Form
    {
        public CrudMembresias(Form padre)
        {
            InitializeComponent();
            this.MdiParent = padre;
        }

        Membresia membresia = new();

        private void Clear()
        {
            textBoxCodigo.Text = "";
            txtDescripcion.Text = "";
            txtAntiguedad.Text = "";
            buttonGuardar.Text = "Registrar";

        }

        private async void LoadData()
        {
            dataGridViewMembresias.AutoGenerateColumns = false;
            List<Membresia>? membresias = (await MembresiasLogic.GetAll())?.ToList();

            if (membresias == null)
            {
                MessageBox.Show("No se ha cargado ninguna membresia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                dataGridViewMembresias.DataSource = membresias;
            }
        }

        private void CrudMembresias_Load(object sender, EventArgs e)
        {
            Clear();
            LoadData();
        }

        private async void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(text: "¿Está seguro que desea eliminar?", caption: "Confirmación", buttons: MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int membresiaId = Convert.ToInt32(this.dataGridViewMembresias.CurrentRow.Cells["MembresiaId"].Value);
                await MembresiasLogic.Delete(membresiaId);
                Clear();
                LoadData();
                MessageBox.Show("Se ha eliminado correctamente.", "Mensaje");
            }
        }

     

        private async void buttonGuardar_Click(object sender, EventArgs e)
        {
            
            if (this.txtAntiguedad.Text == "" || this.txtDescripcion.Text == "")
            {
                MessageBox.Show("Por favor, rellene todos los campos.", "Error");
            }
            else if (buttonGuardar.Text == "Registrar")
            {
                membresia.AntiguedadMinimaCliente = Convert.ToInt32(txtAntiguedad.Text);
                membresia.Descripcion = txtDescripcion.Text.Trim();
                membresia.Activo = true;
                await MembresiasLogic.Create(membresia);
                MessageBox.Show("Membresia registrada con exito.", "Mensaje");
            }
            else if (buttonGuardar.Text == "Guardar cambios")
            {
                membresia.MembresiaId = Convert.ToInt32(textBoxCodigo.Text.Trim());
                membresia.AntiguedadMinimaCliente = Convert.ToInt32(txtAntiguedad.Text);
                membresia.Descripcion = txtDescripcion.Text.Trim();
                membresia.Activo = true;
                await MembresiasLogic.Update(membresia);
                MessageBox.Show("Se han guardado todos los cambios.", "Mensaje");
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error.", "Error");
            }
            Clear();
            LoadData();
        }

        private async void BtnPrecio_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(textBoxCodigo.Text.Trim());
            membresia = await MembresiasLogic.GetOne(id);
            ActualizarPrecioMembresia precioForm = new(membresia, this);
            precioForm.MdiParent = this.MdiParent;
            this.Visible = false;
            precioForm.Show();
        }

        private async void dataGridViewMembresias_DoubleClick_1(object sender, EventArgs e)
        {
            if (dataGridViewMembresias.CurrentRow.Index != -1)
            {
                int membresiaId = Convert.ToInt32(this.dataGridViewMembresias.CurrentRow.Cells["MembresiaId"].Value);
                Membresia membresia = await MembresiasLogic.GetOne(membresiaId);
                textBoxCodigo.Text = Convert.ToString(membresia.MembresiaId);
                txtAntiguedad.Text = membresia.AntiguedadMinimaCliente.ToString();
                txtDescripcion.Text = membresia.Descripcion;
                buttonGuardar.Text = "Guardar cambios";
                buttonEliminar.Enabled = true;
            }
        }
    }
}
