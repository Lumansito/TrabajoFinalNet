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


    public partial class ActualizarPrecioServicio : Form
    {
        private Form hermano;
        private Servicio servicio;
        public ActualizarPrecioServicio(Servicio _servicio, Form _hermano)
        {
            InitializeComponent();
            hermano = _hermano;
            servicio = _servicio;
            cargarDatos();
        }
        private async void ActualizarPrecioServicio_Load(object sender, EventArgs e)
        {
            

        }
        private async void cargarDatos()
        {
            // Obtiene el servicio completo desde la API y asigna el resultado a `servicio`
            var servicioActualizado = await Logic.ServiciosLogic.GetOne(servicio.ServicioId);

            if (servicioActualizado != null)
            {
                servicio = servicioActualizado; // Asigna el servicio obtenido

                // Busca el precio actual
                decimal? precioActual = servicio.Precios
                                       .Where(p => p.FechaDesde <= DateTime.Now)
                                       .OrderByDescending(p => p.FechaDesde)
                                       .FirstOrDefault()?.Precio;

                // Actualiza las etiquetas con los datos obtenidos
                txtPrecioActual.Text = precioActual?.ToString() ?? "No disponible";
                lblServicio.Text = servicio.Nombre;
            }
            else
            {
                lblPrecioActual.Text = "Error al cargar el servicio";
                lblServicio.Text = "Servicio no encontrado";
            }
        }


        private void ActualizarPrecioServicio_FormClosed(object sender, FormClosedEventArgs e)
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
                await Logic.ServiciosLogic.AsignarPrecio(servicio.ServicioId, Convert.ToDecimal(txtPrecioNuevo.Text));
                MessageBox.Show("Precio actualizado exitosamente");
                this.Close();
                hermano.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al actualizar el precio: {ex.Message}");
            }   
        }
            
        }
    
}
