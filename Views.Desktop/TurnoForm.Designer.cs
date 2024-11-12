namespace Views.Desktop
{
    partial class TurnoForm
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
            txtNombre = new Label();
            txtApellido = new Label();
            txtDni = new Label();
            txtFecha = new Label();
            txtBoxDni = new TextBox();
            dgvMascotas = new DataGridView();
            btnBuscar = new Button();
            txtDescripcion = new TextBox();
            btnConfirmar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMascotas).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.AutoSize = true;
            txtNombre.Location = new Point(64, 110);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(71, 20);
            txtNombre.TabIndex = 0;
            txtNombre.Text = "Nombre: ";
            // 
            // txtApellido
            // 
            txtApellido.AutoSize = true;
            txtApellido.Location = new Point(64, 154);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(73, 20);
            txtApellido.TabIndex = 1;
            txtApellido.Text = "Apellido: ";
            // 
            // txtDni
            // 
            txtDni.AutoSize = true;
            txtDni.Location = new Point(64, 201);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(39, 20);
            txtDni.TabIndex = 2;
            txtDni.Text = "Dni: ";
            // 
            // txtFecha
            // 
            txtFecha.AutoSize = true;
            txtFecha.Location = new Point(324, 80);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(54, 20);
            txtFecha.TabIndex = 3;
            txtFecha.Text = "Fecha: ";
            // 
            // txtBoxDni
            // 
            txtBoxDni.Location = new Point(291, 128);
            txtBoxDni.Name = "txtBoxDni";
            txtBoxDni.Size = new Size(241, 27);
            txtBoxDni.TabIndex = 4;
            txtBoxDni.Text = "Ingrese dni cliente";
            // 
            // dgvMascotas
            // 
            dgvMascotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMascotas.Location = new Point(291, 192);
            dgvMascotas.Name = "dgvMascotas";
            dgvMascotas.RowHeadersWidth = 51;
            dgvMascotas.Size = new Size(416, 124);
            dgvMascotas.TabIndex = 5;
            dgvMascotas.SelectionChanged += dgvMascotas_SelectionChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(595, 128);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(45, 303);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.ScrollBars = ScrollBars.Vertical;
            txtDescripcion.Size = new Size(195, 105);
            txtDescripcion.TabIndex = 7;
            txtDescripcion.Visible = false;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(438, 347);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(156, 61);
            btnConfirmar.TabIndex = 8;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Visible = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // TurnoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConfirmar);
            Controls.Add(txtDescripcion);
            Controls.Add(btnBuscar);
            Controls.Add(dgvMascotas);
            Controls.Add(txtBoxDni);
            Controls.Add(txtFecha);
            Controls.Add(txtDni);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Name = "TurnoForm";
            Text = "TurnoForm";
            FormClosed += TurnoForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dgvMascotas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtNombre;
        private Label txtApellido;
        private Label txtDni;
        private Label txtFecha;
        private TextBox txtBoxDni;
        private DataGridView dgvMascotas;
        private Button btnBuscar;
        private TextBox txtDescripcion;
        private Button btnConfirmar;
    }
}