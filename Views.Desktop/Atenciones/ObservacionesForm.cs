using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views.Desktop.Atenciones
{
    public partial class ObservacionesForm : Form
    {
        public ObservacionesForm(string observaciones, string motivo, decimal descuentoAplicado, string descripcionMembresia, string serviciosRealizados)
        {
            InitializeComponent();
            txtMotivo.Text = motivo;
            txtObservaciones.Text = observaciones;
            txtServicios.Text = serviciosRealizados;
            if (descuentoAplicado == 0)
            {
                txtDescuentos.Text = "No se aplicaron descuentos. El cliente no tiene una membresía activa";
            }
            else
            {
                txtDescuentos.Text = $"Se aplicó un {descuentoAplicado * 100}% de descuento. Cobertura de la membresía: {descripcionMembresia}";
            }
        }

        private void BtnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}