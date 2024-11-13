using Logic;
using Microsoft.Data.SqlClient;
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
    public partial class RegistrarPagoMembresia : Form
    {
        private int dni;
        public RegistrarPagoMembresia(int dni)
        {
            InitializeComponent();
            CargarMembresias();
            this.dni = dni;
        }

        private async void CargarMembresias()
        {
            comboBoxMembresias.Items.Clear();
            var membresias = await MembresiasLogic.GetAll();
            foreach (var m in membresias)
            {
                comboBoxMembresias.Items.Add(m.Descripcion);
            }
            comboBoxMembresias.Refresh();
        }

        private async void comboBoxMembresias_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBoxMembresias.SelectedIndex;
            var membresias = await MembresiasLogic.GetAll();
            if (selectedIndex >= 0 && selectedIndex < membresias.Count() + 1)
            {
                var membresiaSeleccionada = await MembresiasLogic.GetOne(selectedIndex + 1);
                var ultimoPrecio = await MembresiasLogic.GetUltimoPrecioByCod(membresiaSeleccionada.MembresiaId);
                textBoxPrecio.Text = Convert.ToString(ultimoPrecio.Precio);
                textBoxPorcentaje.Text = Convert.ToString(membresiaSeleccionada.PorcentajeDescuento);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            ClienteMembresia cm = new ClienteMembresia();

            
            Membresia membresiaSeleccionada = await MembresiasLogic.GetOne(comboBoxMembresias.SelectedIndex + 1);
            Cliente cliente = await ClientesLogic.GetByDni(dni);

            cm.MembresiaId = membresiaSeleccionada.MembresiaId;
            cm.ClienteId = cliente.ClienteId;
            cm.FechaDesde = DateTime.Today;

            await ClientesMembresiasLogic.Add(cm);
            Dispose();
        }
    }
}
