using Logic;
using Models.Entity.Models;

namespace Views.Desktop
{
    public partial class CrudServicios : Form
    {
        public CrudServicios(Form padre)
        {
            this.MdiParent = padre;
            InitializeComponent();
        }

        Servicio servicio = new();

        private void Clear()
        {
            textBoxCodigo.Text = "";
            textBoxNombre.Text = "";
            textBoxDescripcion.Text = "";
        }

        private async void LoadData()
        {
            dataGridViewServicios.AutoGenerateColumns = false;
            List<Servicio>? servicios = await ServiciosLogic.GetAll();
            if (servicios == null)
            {
                MessageBox.Show("No se ha cargado ningun servicio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                dataGridViewServicios.DataSource = servicios;
            }
        }

        private void CrudServicios_Load(object sender, EventArgs e)
        {
            Clear();
            LoadData();
        }

        private async void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(text: "¿Está seguro que desea eliminar?", caption: "Confirmación", buttons: MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int servicioId = Convert.ToInt32(this.dataGridViewServicios.CurrentRow.Cells["ServicioId"].Value);
                await ServiciosLogic.Delete(servicioId);
                Clear();
                LoadData();
                MessageBox.Show("Se ha eliminado correctamente.", "Mensaje");
            }
        }

        private async void dataGridViewServicios_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewServicios.CurrentRow.Index != -1)
            {
                int servicioId = Convert.ToInt32(this.dataGridViewServicios.CurrentRow.Cells["ServicioId"].Value);
                Servicio servicio = await ServiciosLogic.GetOne(servicioId);
                textBoxCodigo.Text = Convert.ToString(servicio.ServicioId);
                textBoxNombre.Text = servicio.Nombre;
                textBoxDescripcion.Text = servicio.Descripcion;
                buttonGuardar.Text = "Guardar cambios";
                buttonEliminar.Enabled = true;
            }
        }

        private async void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (textBoxNombre.Text == "" || textBoxDescripcion.Text == "")
            {
                MessageBox.Show("Por favor, rellene todos los campos.", "Error");
            }
            else if (buttonGuardar.Text == "Registrar")
            {
                servicio.Nombre = textBoxNombre.Text.Trim();
                servicio.Descripcion = textBoxDescripcion.Text.Trim();
                servicio.Activo = true;
                await ServiciosLogic.Create(servicio);
                MessageBox.Show("Servicio registrado con exito.", "Mensaje");
            }
            else if (buttonGuardar.Text == "Guardar cambios")
            {
                servicio.ServicioId = Convert.ToInt32(textBoxCodigo.Text.Trim());
                servicio.Nombre = textBoxNombre.Text.Trim();
                servicio.Descripcion = textBoxDescripcion.Text.Trim();
                servicio.Activo = true;
                await ServiciosLogic.Update(servicio);
                MessageBox.Show("Se han guardado todos los cambios.", "Mensaje");
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error.", "Error");
            }
            Clear();
            LoadData();
        }

        private async void buttonEspecialidades_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(textBoxCodigo.Text.Trim());
            servicio = await ServiciosLogic.GetOne(id);
            AsignarEspecialidadesServicio asignarE = new(servicio, this);
            asignarE.MdiParent = this.MdiParent;
            this.Visible = false;
            asignarE.Show();
        }

        private async void BtnPrecio_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(textBoxCodigo.Text.Trim());
            servicio = await ServiciosLogic.GetOne(id);
            ActualizarPrecioServicio precioForm = new(servicio, this);
            precioForm.MdiParent = this.MdiParent;
            this.Visible = false;
            precioForm.Show();
        }
    }
}
