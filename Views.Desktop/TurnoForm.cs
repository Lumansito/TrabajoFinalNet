using Logic;
using Microsoft.IdentityModel.Tokens;
using Models.Entity.Clases;
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

namespace Views.Desktop
{
    public partial class TurnoForm : Form
    {
        private int dniProf;
        private DateTime fechaHora;
        private int MascotaId;
        private string descripcion;
        private int dniCliente;
        private Form paraCerrar;
        private int ProfesionalId;

        public TurnoForm(int dniProf, int ProfesionalId, DateTime fechaHora, string nombreProf, string apellidoProf, Form paraCerrar)
        {
            InitializeComponent();

            this.ProfesionalId = ProfesionalId;
            this.dniProf = dniProf;
            this.fechaHora = fechaHora;
            this.paraCerrar = paraCerrar;
            txtNombre.Text = "Profesional: " + nombreProf;
            txtApellido.Text = apellidoProf;
            txtDni.Text = "Dni: " + dniProf.ToString();
            txtFecha.Text = "Fecha y Hora: " + fechaHora.ToString();


        }


        private async void dgvLoad()
        {
            //dgvMascotas.AutoGenerateColumns = true; //deberia ser false

            int dniCliente = Convert.ToInt32(txtBoxDni.Text);
            var mascotas = await MascotasLogic.GetAllByDni2(dniCliente);
            if (mascotas.IsNullOrEmpty()) MessageBox.Show("No hay mascotas para el cliente seleccionado");
            
            dgvMascotas.DataSource = mascotas;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvLoad();
        }

        private void dgvMascotas_SelectionChanged(object sender, EventArgs e)
        {
            
            if (dgvMascotas.SelectedRows.Count > 0)
            {
                btnConfirmar.Visible = true;
                txtDescripcion.Visible = true;
            }
            else
            {
                btnConfirmar.Visible = false;
                txtDescripcion.Visible = false;

            }
            if (dgvMascotas.CurrentRow.Index != -1)
            {
                MascotaId = Convert.ToInt32(this.dgvMascotas.CurrentRow.Cells["MascotaId"].Value);
                

            }

        }

        private async void btnConfirmar_Click(object sender, EventArgs e)
        {
            //MetodosAltaTurno metodosAltaTurno = new MetodosAltaTurno();

            descripcion = txtDescripcion.Text;
            /*
            Mascota mascota = await MascotasLogic.GetOne(MascotaId, 1); //este parametro esta mal, el "1", es para que no rompa el codigo en los otros lados
            Usuario prof = await UsuariosLogic.GetById(ProfesionalId);

            Atencion atencion = new Atencion()
            {
                
                Mascota = mascota,
                Usuario = prof,
                FechaHora = fechaHora,
                Motivo = descripcion
            };
            */
            AtencionDTO atencionDTO = new AtencionDTO()
            {
                MascotaId = MascotaId,
                UsuarioId = ProfesionalId,
                FechaHora = fechaHora,
                Motivo = descripcion
            };


            var result = await AtencionLogic.PostAtencionDTO(atencionDTO);
            if (!result)
            {
                MessageBox.Show("Error al crear el turno");

            }
            else
            {
                MessageBox.Show("Turno creado con éxito");
            }


            this.Close();
        }



        private void TurnoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            paraCerrar.Visible = true;
            ((CreateTurno)paraCerrar).LoadDataGridViewPublic();
        }
    }
}
