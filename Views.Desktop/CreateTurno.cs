using Logic;
using Models.Clases;
using Models.Entity.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views.Desktop
{
    public partial class CreateTurno : Form
    {

        private Form _padre;
        public CreateTurno(Form padre)
        {

            InitializeComponent();
            this.MdiParent = padre;
            _padre = padre;

        }

        public void LoadDataGridViewPublic()
        {
            LoadDataGridView();
        }

        async void LoadDataGridView()
        {

            if (boxEspecialidades.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una especialidad para poder ver los turnos disponibles");
            }
            else
            {
                int especialidadId = ((Especialidad)boxEspecialidades.SelectedItem).EspecialidadId;
                DateTime selectedDate = calendar.SelectionStart;


                List<HorarioProfesional> profesionales = await AtencionUsuariosLogic.getHorarioProfesionalEspecialidadDia(selectedDate, especialidadId);


                if (profesionales == null) MessageBox.Show("No hay turnos disponibles para la fecha seleccionada y especialidad seleccionada");
                dgvTurnos.DataSource = profesionales;
            }


        }
       


        private void dgvTurnos_DoubleClick(object sender, EventArgs e)
        {
            if (dgvTurnos.CurrentRow.Index != -1)
            {

                int dniProf = Convert.ToInt32(this.dgvTurnos.CurrentRow.Cells["DniProf"].Value);
                int idProf = Convert.ToInt32(this.dgvTurnos.CurrentRow.Cells["ProfesionalId"].Value);
                string nombrePorf = dgvTurnos.CurrentRow.Cells["NombreProf"].Value.ToString() ?? string.Empty;
                string apellidoProf = dgvTurnos.CurrentRow.Cells["ApellidoProf"].Value.ToString() ?? string.Empty;


                DateTime dateTime = Convert.ToDateTime(this.dgvTurnos.CurrentRow.Cells["DiaHoraInicio"].Value);



                TurnoForm form = new TurnoForm(dniProf, idProf, dateTime, nombrePorf, apellidoProf, this);
                form.MdiParent = _padre;
                form.Show();
                this.Visible = false;

            }

        }

        private async void CreateTurno_Load(object sender, EventArgs e)
        {
            List<Especialidad> esp = await EspecialidadesLogic.GetAll();
            boxEspecialidades.DataSource = esp;
            boxEspecialidades.DisplayMember = "nombre";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
        }
    }
}
