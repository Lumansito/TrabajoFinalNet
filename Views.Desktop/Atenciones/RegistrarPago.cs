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
    public partial class RegistrarPago : Form
    {
        public bool banderaDeConfirmacion = false;
        public RegistrarPago()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click_1(object sender, EventArgs e)
        {
            banderaDeConfirmacion = true;
            this.Close();
        }
    }
}
