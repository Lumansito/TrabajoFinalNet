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
        public CancelarTurno(int idAtencion)
        {
            InitializeComponent();
            _idAtencion = idAtencion;
        }

        private async void btnCancelar_Click(object sender, EventArgs e)
        {
            await AtencionLogic.Delete(_idAtencion);
            MessageBox.Show("Turno cancelado con éxito");
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
