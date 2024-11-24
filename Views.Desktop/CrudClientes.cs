using Logic;
using Models.Entity.Models;
using Models.Models;
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
    public partial class CrudClientes : Form
    {
        public CrudClientes(Form padre)
        {
            this.MdiParent = padre;
            InitializeComponent();
        }
        Cliente cliente = new Cliente();

        private void Clear()
        {
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtDni.Text = "";
            txtMail.Text = "";
            txtTelefono.Text = "";
            btnGuardar.Text = "Guardar";
            btnBorrar.Enabled = false;
            cliente.Dni = 0;
            txtDni.Enabled = true;
        }

        private void CrudClientes_Load(object sender, EventArgs e)
        {
            Clear();
            this.ActiveControl = txtNombre;
            LoadData();
        }


        private async void btnGuardar_Click(object sender, EventArgs e)
        {

            // Validación: Campos requeridos
            if (string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtDni.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Error, algún parámetro está vacío. Complete todos los campos obligatorios.", "Error");
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(txtDni.Text, "^[0-9]{8}$"))
            {
                MessageBox.Show("El DNI debe tener 8 dígitos.");
                return;
            }

            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!string.IsNullOrWhiteSpace(txtMail.Text) && !System.Text.RegularExpressions.Regex.IsMatch(txtMail.Text.Trim(), emailPattern))
            {
                MessageBox.Show("El correo ingresado no tiene un formato válido.", "Error");
                return;
            }


            cliente.Nombre = txtNombre.Text.Trim();
                cliente.Apellido = txtApellido.Text.Trim();
                cliente.Mail = txtMail.Text.Trim();
                cliente.Telefono = txtTelefono.Text.Trim();
                cliente.FechaAlta = DateTime.Now;
                cliente.FechaNacimiento = timePicker.Value;
                cliente.Dni = Convert.ToInt32(txtDni.Text.Trim());

            try
            {
                bool success;
                if (btnGuardar.Text == "Guardar")
                {   
                    success = await ClientesLogic.Crear(cliente);
                }
                else
                {
                    success = await ClientesLogic.Editar(cliente);
                }
                if (success)
                {
                    MessageBox.Show("Guardado correctamente", "Mensaje");
                }
                else
                {
                    MessageBox.Show("Error al guardar", "Error");
                }
                Clear();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error");
            }




        }


        private async void LoadData()
        {
            dgvClientes.AutoGenerateColumns = false; 
            List<Cliente> clientes = await ClientesLogic.GetAll();
            dgvClientes.DataSource = clientes;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Clear();
            btnGuardar.Text = "Guardar";
        }

        private async void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(text: "Estas seguro que queres borrar?", caption: "Confirmación", buttons: MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                
                int id = Convert.ToInt32(this.dgvClientes.CurrentRow.Cells["ClienteId"].Value);
                await ClientesLogic.Eliminar(id);
                LoadData();
                Clear();
                MessageBox.Show("Se elimino correctamente", "Mensaje");
            }
        }

        private async void dgvClientes_DoubleClick(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow.Index != -1)
            {

                int dni = Convert.ToInt32(this.dgvClientes.CurrentRow.Cells["Dni"].Value);

               
                cliente = await ClientesLogic.GetByDni(dni);

                txtApellido.Text = cliente.Apellido;
                txtNombre.Text = cliente.Nombre;
                txtDni.Text = Convert.ToString(cliente.Dni);
                txtMail.Text = cliente.Mail;
                txtTelefono.Text = cliente.Telefono;
                if (cliente.FechaNacimiento > timePicker.MinDate)
                {
                    timePicker.Value = cliente.FechaNacimiento;
                }
                else
                {
                    timePicker.Value = DateTime.Today;
                }

                

                btnGuardar.Text = "Editar";
                btnBorrar.Enabled = true;
                
            }
        }
    }
}
