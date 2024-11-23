namespace Views.Desktop
{
    partial class CrudUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCancelar = new Button();
            btnBorrar = new Button();
            btnGuardar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            timePicker = new DateTimePicker();
            label6 = new Label();
            btnJornadas = new Button();
            btnEspecialidades = new Button();
            dgvUsuarios = new DataGridView();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDni = new TextBox();
            txtMail = new TextBox();
            txtTelefono = new TextBox();
            label7 = new Label();
            cboxRol = new ComboBox();
            cbIsAdmin = new CheckBox();
            UsuarioId = new DataGridViewTextBoxColumn();
            Dni = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Mail = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            FechaAlta = new DataGridViewTextBoxColumn();
            FechaNacimiento = new DataGridViewTextBoxColumn();
            Contraseña = new DataGridViewTextBoxColumn();
            Rol = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(258, 379);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(138, 379);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(94, 29);
            btnBorrar.TabIndex = 16;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(18, 379);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 15;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 27);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 18;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 63);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 19;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 102);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 20;
            label3.Text = "Dni";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 138);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 21;
            label4.Text = "Mail";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 183);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 22;
            label5.Text = "Telefono";
            // 
            // timePicker
            // 
            timePicker.Location = new Point(138, 279);
            timePicker.Name = "timePicker";
            timePicker.Size = new Size(125, 27);
            timePicker.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(4, 284);
            label6.Name = "label6";
            label6.Size = new Size(128, 20);
            label6.TabIndex = 23;
            label6.Text = "Fecha Nacimiento";
            // 
            // btnJornadas
            // 
            btnJornadas.Location = new Point(422, 355);
            btnJornadas.Name = "btnJornadas";
            btnJornadas.Size = new Size(123, 76);
            btnJornadas.TabIndex = 25;
            btnJornadas.Text = "Jornadas";
            btnJornadas.UseVisualStyleBackColor = true;
            btnJornadas.Click += btnJornadas_Click;
            // 
            // btnEspecialidades
            // 
            btnEspecialidades.Location = new Point(609, 355);
            btnEspecialidades.Name = "btnEspecialidades";
            btnEspecialidades.Size = new Size(123, 76);
            btnEspecialidades.TabIndex = 26;
            btnEspecialidades.Text = "Especialidades";
            btnEspecialidades.UseVisualStyleBackColor = true;
            btnEspecialidades.Click += btnEspecialidades_Click;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { UsuarioId, Dni, Nombre, Apellido, Mail, Telefono, FechaAlta, FechaNacimiento, Contraseña, Rol });
            dgvUsuarios.Location = new Point(300, 27);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.Size = new Size(472, 302);
            dgvUsuarios.TabIndex = 27;
            dgvUsuarios.DoubleClick += dgvUsuariuos_DoubleClick;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(138, 27);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 28;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(138, 63);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(125, 27);
            txtApellido.TabIndex = 29;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(138, 102);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(125, 27);
            txtDni.TabIndex = 30;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(138, 138);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(125, 27);
            txtMail.TabIndex = 31;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(138, 183);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(125, 27);
            txtTelefono.TabIndex = 32;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 226);
            label7.Name = "label7";
            label7.Size = new Size(31, 20);
            label7.TabIndex = 33;
            label7.Text = "Rol";
            // 
            // cboxRol
            // 
            cboxRol.FormattingEnabled = true;
            cboxRol.Location = new Point(138, 226);
            cboxRol.Name = "cboxRol";
            cboxRol.Size = new Size(125, 28);
            cboxRol.TabIndex = 34;
            // 
            // cbIsAdmin
            // 
            cbIsAdmin.AutoSize = true;
            cbIsAdmin.Location = new Point(47, 328);
            cbIsAdmin.Name = "cbIsAdmin";
            cbIsAdmin.Size = new Size(142, 24);
            cbIsAdmin.TabIndex = 35;
            cbIsAdmin.Text = "Es administrador";
            cbIsAdmin.UseVisualStyleBackColor = true;
            // 
            // UsuarioId
            // 
            UsuarioId.DataPropertyName = "UsuarioId";
            UsuarioId.HeaderText = "UsuarioId";
            UsuarioId.MinimumWidth = 6;
            UsuarioId.Name = "UsuarioId";
            UsuarioId.ReadOnly = true;
            UsuarioId.Width = 125;
            // 
            // Dni
            // 
            Dni.DataPropertyName = "Dni";
            Dni.HeaderText = "Dni";
            Dni.MinimumWidth = 6;
            Dni.Name = "Dni";
            Dni.ReadOnly = true;
            Dni.Width = 125;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 125;
            // 
            // Apellido
            // 
            Apellido.DataPropertyName = "Apellido";
            Apellido.HeaderText = "Apellido";
            Apellido.MinimumWidth = 6;
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            Apellido.Width = 125;
            // 
            // Mail
            // 
            Mail.DataPropertyName = "Mail";
            Mail.HeaderText = "Mail";
            Mail.MinimumWidth = 6;
            Mail.Name = "Mail";
            Mail.ReadOnly = true;
            Mail.Width = 125;
            // 
            // Telefono
            // 
            Telefono.DataPropertyName = "Telefono";
            Telefono.HeaderText = "Telefono";
            Telefono.MinimumWidth = 6;
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            Telefono.Width = 125;
            // 
            // FechaAlta
            // 
            FechaAlta.DataPropertyName = "FechaAlta";
            FechaAlta.HeaderText = "FechaAlta";
            FechaAlta.MinimumWidth = 6;
            FechaAlta.Name = "FechaAlta";
            FechaAlta.ReadOnly = true;
            FechaAlta.Width = 125;
            // 
            // FechaNacimiento
            // 
            FechaNacimiento.DataPropertyName = "FechaNacimiento";
            FechaNacimiento.HeaderText = "FechaNacimiento";
            FechaNacimiento.MinimumWidth = 6;
            FechaNacimiento.Name = "FechaNacimiento";
            FechaNacimiento.ReadOnly = true;
            FechaNacimiento.Width = 125;
            // 
            // Contraseña
            // 
            Contraseña.DataPropertyName = "Contraseña";
            Contraseña.HeaderText = "Contraseña";
            Contraseña.MinimumWidth = 6;
            Contraseña.Name = "Contraseña";
            Contraseña.ReadOnly = true;
            Contraseña.Width = 125;
            // 
            // Rol
            // 
            Rol.DataPropertyName = "Rol";
            Rol.HeaderText = "Rol";
            Rol.MinimumWidth = 6;
            Rol.Name = "Rol";
            Rol.ReadOnly = true;
            Rol.Width = 125;
            // 
            // CrudUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbIsAdmin);
            Controls.Add(cboxRol);
            Controls.Add(label7);
            Controls.Add(txtTelefono);
            Controls.Add(txtMail);
            Controls.Add(txtDni);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(dgvUsuarios);
            Controls.Add(btnEspecialidades);
            Controls.Add(btnJornadas);
            Controls.Add(timePicker);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnBorrar);
            Controls.Add(btnGuardar);
            Name = "CrudUsuarios";
            Text = "CrudUsuarios";
            Load += CrudUsuarios_Load;
            VisibleChanged += CrudUsuarios_VisibleChanged;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnBorrar;
        private Button btnGuardar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker timePicker;
        private Label label6;
        private Button btnJornadas;
        private Button btnEspecialidades;
        private DataGridView dgvUsuarios;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDni;
        private TextBox txtMail;
        private TextBox txtTelefono;
        private Label label7;
        private ComboBox cboxRol;
        private CheckBox cbIsAdmin;
        private DataGridViewTextBoxColumn UsuarioId;
        private DataGridViewTextBoxColumn Dni;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Mail;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn FechaAlta;
        private DataGridViewTextBoxColumn FechaNacimiento;
        private DataGridViewTextBoxColumn Contraseña;
        private DataGridViewTextBoxColumn Rol;
    }
}