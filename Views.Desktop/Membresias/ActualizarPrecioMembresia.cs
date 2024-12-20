﻿using Models.Entity.Models;
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
    public partial class ActualizarPrecioMembresia : Form
    {
        private Form hermano;
        private Membresia membresia;
        public ActualizarPrecioMembresia(Membresia _membresia, Form _hermano)
        {
            InitializeComponent();
            hermano = _hermano;
            membresia = _membresia;
            cargarDatos();
        }

        private async void cargarDatos()
        {
            // Obtiene el membresia completo desde la API y asigna el resultado a `membresia`
            var membresiaActualizada = await Logic.MembresiasLogic.GetOne(membresia.MembresiaId);

            if (membresiaActualizada != null)
            {
                membresia = membresiaActualizada; // Asigna el membresia obtenido

                // Busca el precio actual
                decimal? precioActual = membresia.Precios
                                       .Where(p => p.FechaVigencia <= DateTime.Now)
                                       .OrderByDescending(p => p.FechaVigencia)
                                       .FirstOrDefault()?.Precio;

                // Actualiza las etiquetas con los datos obtenidos
                txtPrecioActual.Text = precioActual?.ToString() ?? "No disponible";
                lblServicio.Text = membresia.Descripcion;
            }
            else
            {
                lblPrecioActual.Text = "Error al cargar el membresia";
                lblServicio.Text = "Servicio no encontrado";
            }
        }

        private void ActualizarPrecioMembresia_Load(object sender, EventArgs e)
        {

        }

        private void ActualizarPrecioMembresia_FormClosed(object sender, FormClosedEventArgs e)
        {
            hermano.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            hermano.Visible = true;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string precioTexto = txtPrecioNuevo.Text.Trim();

            if (string.IsNullOrWhiteSpace(precioTexto))
            {
                MessageBox.Show("Por favor, ingrese un precio.");
                return;
            }

            if (!decimal.TryParse(precioTexto, out decimal precio))
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido para el precio.");
                return;
            }

            if (precio <= 0)
            {
                MessageBox.Show("El precio debe ser mayor a 0.");
                return;
            }

            try
            {
                await Logic.MembresiasLogic.AsignarPrecio(membresia.MembresiaId, Convert.ToDecimal(txtPrecioNuevo.Text));
                MessageBox.Show("Precio actualizado exitosamente");
                this.Close();
                hermano.Visible = true;

            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al actualizar el precio: {ex.Message}");
            }
        }
    }
}
