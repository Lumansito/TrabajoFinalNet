using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models.Entity.Models;
using Views.Desktop.Menu;

namespace Views.Desktop
{
    public partial class Mdi : Form
    {
        Usuario user = new();
        MenuStrip menuStrip = new();
        MenuStrip menuStripAdmin = new();
        public Mdi()
        {
            this.IsMdiContainer = true;
            InitializeComponent();

        }

        private void MDI_Load(object sender, EventArgs e)
        {

            LogIn logIn = new();
            logIn.ShowDialog();

            if (logIn.estaAutenticado)
            {
                user = logIn.usuarioLogueado;
                CargaMenu();
            }
            else
            {
                MessageBox.Show("No se pudo autenticar el usuario.");
                this.Close();
            }
        }

        private void CargaMenu()
        {
            if (user.Rol == "Secretario")
            {
                MenuSecretario menu = new();
                menuStrip = menu.CreateMenu(this);

            }
            else if (user.Rol == "Profesional")
            {

            }

            if (user.IsAdmin)
            {
                

                MenuAdmin menu = new();
                 menuStripAdmin = menu.CreateMenu(this);

            }
            this.MainMenuStrip = menuStrip;
            this.Controls.Add(menuStrip);
            this.Controls.Add(menuStripAdmin);
        }
    }
}
