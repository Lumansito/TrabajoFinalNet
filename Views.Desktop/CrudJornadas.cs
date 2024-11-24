using Logic;
using Models.Entity.Models;
using System.Diagnostics;

namespace Views.Desktop
{
    public partial class CrudJornadas : Form
    {
        public CrudJornadas(Form padre)
        {
            this.MdiParent = padre;
            InitializeComponent();
        }

        private Jornada jornada = new();

        private void Clear()
        {
            textBoxId.Text = "";
            cbNombreDia.SelectedIndex = 0;
            dtpHoraInicio.Text = "00:00";
            dtpHoraFin.Text = "00:00";
        }

        private async void LoadData()
        {
            dataGridViewJornadas.AutoGenerateColumns = false;
            List<Jornada>? jornadas = await JornadasLogic.GetAll();
            if (jornadas == null)
            {
                MessageBox.Show("No se ha cargado ninguna jornada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                dataGridViewJornadas.DataSource = jornadas;
            }
        }

        private async void buttonRG_Click(object sender, EventArgs e)
        {
            {
                MessageBox.Show("Por favor, ingrese las horas de inicio y fin.", "Error");
                return;
            }

            if (dtpHoraInicio.Value.TimeOfDay >= dtpHoraFin.Value.TimeOfDay)
            {
                MessageBox.Show("La hora de inicio debe ser menor que la hora de fin.", "Error");
                return;
            }



            try
            {
                if (buttonRG.Text == "Registrar")
                {
                    jornada.NombreDia = cbNombreDia.Text;
                    jornada.HoraInicio = dtpHoraInicio.Value.TimeOfDay;
                    jornada.HoraFin = dtpHoraFin.Value.TimeOfDay;
                    jornada.Activo = true;

                    Boolean result = await JornadasLogic.Create(jornada);

                    if (result)
                    {
                        MessageBox.Show("Jornada registrada con exito!");
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error al registrar la jornada.");
                    }
                }
                else
                {

                    jornada.JornadaId = int.Parse(textBoxId.Text);
                    jornada.NombreDia = cbNombreDia.Text;
                    jornada.HoraInicio = dtpHoraInicio.Value.TimeOfDay;
                    jornada.HoraFin = dtpHoraFin.Value.TimeOfDay;
                    jornada.Activo = true;

                    Boolean result = await JornadasLogic.Update(jornada);

                    if (result)
                    {
                        MessageBox.Show("Se han guardado todos los cambios.");
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error.");
                    }
                }
                Clear();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error");
            }
        }

        private async void dataGridViewJornadas_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewJornadas.CurrentRow.Index != -1)
            {
                int JornadaId = Convert.ToInt32(this.dataGridViewJornadas.CurrentRow.Cells["JornadaId"].Value);
                Jornada jornada = await JornadasLogic.GetOne(JornadaId);
                textBoxId.Text = Convert.ToString(jornada.JornadaId);
                cbNombreDia.Text = jornada.NombreDia;
                dtpHoraInicio.Text = jornada.HoraInicio.ToString();
                dtpHoraFin.Text = jornada.HoraFin.ToString();
                buttonRG.Text = "Guardar cambios";
                buttonEliminar.Enabled = true;
            }
        }

        private async void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(text: "¿Está seguro que desea eliminar?", caption: "Confirmación", buttons: MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int JornadaId = Convert.ToInt32(this.dataGridViewJornadas.CurrentRow.Cells["JornadaId"].Value);
                await JornadasLogic.Delete(JornadaId);
                Clear();
                LoadData();
                MessageBox.Show("Se ha eliminado correctamente.", "Mensaje");
            }
        }

        private void CrudJornadas_Load(object sender, EventArgs e)
        {
            Clear();
            LoadData();
        }

        private void buttonRestablecer_Click(object sender, EventArgs e)
        {
            Clear();
            LoadData();
        }
    }
}
