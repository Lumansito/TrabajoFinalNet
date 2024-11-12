using Logic;
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
    public partial class MembresiasCliente : Form
    {
        private Form _padre;
        public MembresiasCliente(Form padre)
        {
            InitializeComponent();
            this.MdiParent = padre;
            _padre = padre;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            int dni = int.Parse(textBoxMembresiasCliente.Text);
            var membresias = await ClientesLogic.GetAllByDni(dni);
            if (membresias == null)
            {
                MessageBox.Show("Por favor, introduce un número de DNI válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                dgvMembresiasCliente.DataSource = membresias.ToList();
                var clienteMembresia = await ClientesMembresiasLogic.GetUltimoClienteMembresia(dni);
                DateTime fechaActual = DateTime.Now;
                TimeSpan diferencia = clienteMembresia.FechaDesde.AddDays(30) - fechaActual;

                if (diferencia.TotalDays > 0) // Verifica que queden días restantes
                {
                    var membresia = await MembresiasLogic.GetOne(0);  //se rompio
                    labelNombreMembresia.Text = membresia.Descripcion;
                    labelTiempoRestante.Text = $"{diferencia.Days} días restantes";
                }
                else labelTiempoRestante.Text = "No tiene una membresia vigente";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistrarPagoMembresia registrarPagoMembresia = new RegistrarPagoMembresia();
            registrarPagoMembresia.MdiParent = this.MdiParent;
            registrarPagoMembresia.Show();
        }
    }
}
