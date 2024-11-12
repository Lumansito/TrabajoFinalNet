using Models.Entity.Models;
using Logic;
using System.Runtime.CompilerServices;
using Models.Models;
namespace Views.Desktop
{
    public partial class CrudUsuarios : Form
    {
        public CrudUsuarios(Form padre)
        {
            InitializeComponent();
            this.MdiParent = padre;
        }
        Usuario usuario = new Usuario();

        private void Clear()
        {
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtDni.Text = "";
            txtMail.Text = "";
            txtTelefono.Text = "";
            btnGuardar.Text = "Guardar";
            btnBorrar.Enabled = false;
            usuario = new Usuario();
            btnJornadas.Enabled = false;
            btnEspecialidades.Enabled = false;
            btnEspecialidades.Visible = false;
            btnJornadas.Visible = false;

        }
        private async void LoadData()
        {
            //dgvClientes.AutoGenerateColumns = true; //momentaneamente, deberian estar establecidas las columnas
            List<Usuario> usuarios;
            usuarios = await UsuariosLogic.GetAll();
            dgvUsuarios.DataSource = usuarios;

            cboxRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxRol.Items.Clear();
            cboxRol.Items.Add(new { Text = "Secretario", Value = "Secretario" });
            cboxRol.Items.Add(new { Text = "Profesional", Value = "Profesional" });
            cboxRol.DisplayMember = "Text";
            cboxRol.ValueMember = "Value";

        }



        private void CrudUsuarios_Load(object sender, EventArgs e)
        {
            Clear();
            this.ActiveControl = txtNombre;
            LoadData();
        }

        private async void dgvUsuariuos_DoubleClick(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow.Index != -1)
            {

                int id = Convert.ToInt32(this.dgvUsuarios.CurrentRow.Cells["UsuarioId"].Value);

                usuario = await UsuariosLogic.GetById(id);

                txtApellido.Text = usuario.Apellido;
                txtNombre.Text = usuario.Nombre;
                txtDni.Text = Convert.ToString(usuario.Dni);
                txtMail.Text = usuario.Mail;
                txtTelefono.Text = usuario.Telefono;
                if (usuario.FechaNacimiento > timePicker.MinDate)
                {
                    timePicker.Value = usuario.FechaNacimiento;
                }
                else
                {
                    timePicker.Value = DateTime.Today;
                }
                cbIsAdmin.Checked = usuario.IsAdmin;
                cboxRol.Text = usuario.Rol;

                btnGuardar.Text = "Editar";
                btnBorrar.Enabled = true;

                if (usuario.Rol == "Profesional")
                {
                    btnJornadas.Enabled = true;
                    btnEspecialidades.Enabled = true;
                    btnEspecialidades.Visible = true;
                    btnJornadas.Visible = true;
                }
                else
                {
                    btnJornadas.Enabled = false;
                    btnEspecialidades.Enabled = false;
                    btnEspecialidades.Visible = false;
                    btnJornadas.Visible = false;
                }

            }


        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text == "" || txtNombre.Text == "" || txtDni.Text == "" || txtTelefono.Text == "" || timePicker.Value == DateTime.Today)
            {
                MessageBox.Show("Error, algun parametro esta incompleto", "Error");
            }
            else
            {
                usuario.Nombre = txtNombre.Text.Trim();
                usuario.Apellido = txtApellido.Text.Trim();
                usuario.Mail = txtMail.Text.Trim();
                usuario.Telefono = txtTelefono.Text.Trim();
                usuario.FechaAlta = DateTime.Now;
                usuario.FechaNacimiento = timePicker.Value;
                usuario.Dni = Convert.ToInt32(txtDni.Text.Trim());
                usuario.Rol = cboxRol.Text;
                usuario.Activo = true;
                usuario.IsAdmin = cbIsAdmin.Checked;



                bool success;
                if (btnGuardar.Text == "Guardar")
                {
                    success = await UsuariosLogic.Crear(usuario);
                }
                else
                {
                    success = await UsuariosLogic.Editar(usuario);
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

        private async void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(text: "Estas seguro que queres borrar?", caption: "Confirmación", buttons: MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                int id = Convert.ToInt32(this.dgvUsuarios.CurrentRow.Cells["UsuarioId"].Value);
                await UsuariosLogic.Eliminar(id);
                LoadData();
                Clear();
                MessageBox.Show("Se elimino correctamente", "Mensaje");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Clear();
            btnGuardar.Text = "Guardar";
        }

        private void btnJornadas_Click(object sender, EventArgs e)
        {

            AsignarJornadasUsuario asignarJ = new(usuario, this);
            asignarJ.MdiParent = this.MdiParent;
            this.Visible = false;
            asignarJ.Show();
        }

        private void CrudUsuarios_VisibleChanged(object sender, EventArgs e)
        {
            Clear();
            LoadData();
        }

        private void btnEspecialidades_Click(object sender, EventArgs e)
        {
            AsignarEspecialidadesUsuario asignarE = new(usuario, this);
            asignarE.MdiParent = this.MdiParent;
            this.Visible = false;
            asignarE.Show();
        }
    }
}
