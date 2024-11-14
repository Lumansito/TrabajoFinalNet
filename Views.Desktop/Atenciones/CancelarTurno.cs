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

namespace Views.Desktop.Atenciones
{
    public partial class CancelarTurno : Form
    {
        private int _idAtencion;
        public bool seCancelo;
        public CancelarTurno(int idAtencion)
        {
            InitializeComponent();
            _idAtencion = idAtencion;
        }

        private async void btnCancelar_Click(object sender, EventArgs e)
        {
            var resultado = await AtencionLogic.Delete(_idAtencion);
            if (resultado == true)
            {
                MessageBox.Show("Turno cancelado con éxito");
                seCancelo = true;
            }
            else
            {
                MessageBox.Show("Hubo un error al cancelar el turno");
            }

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
