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

            if (txtApellido.Text == "" || txtNombre.Text == "" || txtDni.Text == "" || txtTelefono.Text == "")
            {
                MessageBox.Show("Error, algun parametro es cadena vacia", "Error");
            }
            else
            {
                cliente.Nombre = txtNombre.Text.Trim();
                cliente.Apellido = txtApellido.Text.Trim();
                cliente.Mail = txtMail.Text.Trim();
                cliente.Telefono = txtTelefono.Text.Trim();
                cliente.FechaAlta = DateTime.Now;
                cliente.FechaNacimiento = timePicker.Value;
                cliente.Dni = Convert.ToInt32(txtDni.Text.Trim());

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
