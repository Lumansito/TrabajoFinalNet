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
using Logic;

namespace Views.Desktop
{
    public partial class LogIn : Form
    {
        
        public bool estaAutenticado { get; private set; } = false;
        public Usuario usuarioLogueado { get; private set; } = null;
        public LogIn()
        {
            InitializeComponent();
            
        }

        private  async void btnIngreso_Click(object sender, EventArgs e)
        {
            int dniIngresado = int.Parse(txtBoxDni.Text);
            string contraseñaIngresada = txtBoxPassword.Text;

            usuarioLogueado = await UsuariosLogic.LogInEscritorio(dniIngresado, contraseñaIngresada);

       
            if (usuarioLogueado != null)
            {
                estaAutenticado = true;

                if (usuarioLogueado.IsAdmin == true)
                {
                    MessageBox.Show("Bienvenido SR ADMIN, SU ROL ES: " + usuarioLogueado.Rol);
                }
                else
                {

                    MessageBox.Show("Bienvenido su rol es: " + usuarioLogueado.Rol);
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("No existe un usuario con esos datos.");
            }
        }
    }
}
