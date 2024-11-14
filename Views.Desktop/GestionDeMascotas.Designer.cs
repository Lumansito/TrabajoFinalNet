namespace Views.Desktop
{
    partial class GestionDeMascotas
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
            buttonBuscarMascotas = new Button();
            label1 = new Label();
            textBoxDni = new TextBox();
            dgvGestionDeMascotas = new DataGridView();
            MascotaId = new DataGridViewTextBoxColumn();
            NombreMascota = new DataGridViewTextBoxColumn();
            Edad = new DataGridViewTextBoxColumn();
            NombreRaza = new DataGridViewTextBoxColumn();
            NombreEspecie = new DataGridViewTextBoxColumn();
            FechaDefuncion = new DataGridViewTextBoxColumn();
            editar = new DataGridViewButtonColumn();
            eliminar = new DataGridViewButtonColumn();
            label2 = new Label();
            labelNombreDueño = new Label();
            buttonAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvGestionDeMascotas).BeginInit();
            SuspendLayout();
            // 
            // buttonBuscarMascotas
            // 
            buttonBuscarMascotas.Location = new Point(357, 125);
            buttonBuscarMascotas.Margin = new Padding(3, 4, 3, 4);
            buttonBuscarMascotas.Name = "buttonBuscarMascotas";
            buttonBuscarMascotas.Size = new Size(179, 31);
            buttonBuscarMascotas.TabIndex = 0;
            buttonBuscarMascotas.Text = "Buscar sus mascotas";
            buttonBuscarMascotas.UseVisualStyleBackColor = true;
            buttonBuscarMascotas.Click += buttonBuscarMascotas_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 129);
            label1.Name = "label1";
            label1.Size = new Size(166, 20);
            label1.TabIndex = 1;
            label1.Text = "Ingresar DNI del dueño:";
            // 
            // textBoxDni
            // 
            textBoxDni.Location = new Point(186, 125);
            textBoxDni.Margin = new Padding(3, 4, 3, 4);
            textBoxDni.Name = "textBoxDni";
            textBoxDni.Size = new Size(163, 27);
            textBoxDni.TabIndex = 2;
            // 
            // dgvGestionDeMascotas
            // 
            dgvGestionDeMascotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGestionDeMascotas.Columns.AddRange(new DataGridViewColumn[] { MascotaId, NombreMascota, Edad, NombreRaza, NombreEspecie, FechaDefuncion, editar, eliminar });
            dgvGestionDeMascotas.Location = new Point(14, 225);
            dgvGestionDeMascotas.Margin = new Padding(3, 4, 3, 4);
            dgvGestionDeMascotas.Name = "dgvGestionDeMascotas";
            dgvGestionDeMascotas.RowHeadersWidth = 51;
            dgvGestionDeMascotas.Size = new Size(887, 200);
            dgvGestionDeMascotas.TabIndex = 3;
            dgvGestionDeMascotas.CellContentClick += dgvGestionDeMascotas_CellContentClick;
            dgvGestionDeMascotas.VisibleChanged += dgvGestionDeMascotas_VisibleChanged;
            // 
            // MascotaId
            // 
            MascotaId.DataPropertyName = "MascotaId";
            MascotaId.HeaderText = "ID";
            MascotaId.MinimumWidth = 6;
            MascotaId.Name = "MascotaId";
            MascotaId.Width = 125;
            // 
            // NombreMascota
            // 
            NombreMascota.DataPropertyName = "NombreMascota";
            NombreMascota.HeaderText = "Nombre";
            NombreMascota.MinimumWidth = 6;
            NombreMascota.Name = "NombreMascota";
            NombreMascota.Width = 125;
            // 
            // Edad
            // 
            Edad.DataPropertyName = "Edad";
            Edad.HeaderText = "Edad";
            Edad.MinimumWidth = 6;
            Edad.Name = "Edad";
            Edad.Width = 125;
            // 
            // NombreRaza
            // 
            NombreRaza.DataPropertyName = "NombreRaza";
            NombreRaza.HeaderText = "Raza";
            NombreRaza.MinimumWidth = 6;
            NombreRaza.Name = "NombreRaza";
            NombreRaza.Width = 125;
            // 
            // NombreEspecie
            // 
            NombreEspecie.DataPropertyName = "NombreEspecie";
            NombreEspecie.HeaderText = "Especie";
            NombreEspecie.MinimumWidth = 6;
            NombreEspecie.Name = "NombreEspecie";
            NombreEspecie.Width = 125;
            // 
            // FechaDefuncion
            // 
            FechaDefuncion.DataPropertyName = "FechaDefuncion";
            FechaDefuncion.HeaderText = "FechaDefuncion";
            FechaDefuncion.MinimumWidth = 6;
            FechaDefuncion.Name = "FechaDefuncion";
            FechaDefuncion.Width = 125;
            // 
            // editar
            // 
            editar.HeaderText = "";
            editar.MinimumWidth = 6;
            editar.Name = "editar";
            editar.Text = "Editar";
            editar.UseColumnTextForButtonValue = true;
            editar.Width = 125;
            // 
            // eliminar
            // 
            eliminar.HeaderText = "";
            eliminar.MinimumWidth = 6;
            eliminar.Name = "eliminar";
            eliminar.Text = "Eliminar";
            eliminar.UseColumnTextForButtonValue = true;
            eliminar.Width = 125;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 188);
            label2.Name = "label2";
            label2.Size = new Size(208, 20);
            label2.TabIndex = 4;
            label2.Text = "Nombre y apellido del dueño:";
            // 
            // labelNombreDueño
            // 
            labelNombreDueño.AutoSize = true;
            labelNombreDueño.Location = new Point(224, 188);
            labelNombreDueño.Name = "labelNombreDueño";
            labelNombreDueño.Size = new Size(15, 20);
            labelNombreDueño.TabIndex = 5;
            labelNombreDueño.Text = "-";
            // 
            // buttonAgregar
            // 
            buttonAgregar.Location = new Point(14, 448);
            buttonAgregar.Margin = new Padding(3, 4, 3, 4);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(86, 31);
            buttonAgregar.TabIndex = 6;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // GestionDeMascotas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(buttonAgregar);
            Controls.Add(labelNombreDueño);
            Controls.Add(label2);
            Controls.Add(dgvGestionDeMascotas);
            Controls.Add(textBoxDni);
            Controls.Add(label1);
            Controls.Add(buttonBuscarMascotas);
            Margin = new Padding(3, 4, 3, 4);
            Name = "GestionDeMascotas";
            Text = "GestionDeMascotas";
            ((System.ComponentModel.ISupportInitialize)dgvGestionDeMascotas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBuscarMascotas;
        private Label label1;
        private TextBox textBoxDni;
        private DataGridView dgvGestionDeMascotas;
        private Label label2;
        private Label labelNombreDueño;
        private DataGridViewTextBoxColumn MascotaId;
        private DataGridViewTextBoxColumn NombreMascota;
        private DataGridViewTextBoxColumn Edad;
        private DataGridViewTextBoxColumn NombreRaza;
        private DataGridViewTextBoxColumn NombreEspecie;
        private DataGridViewTextBoxColumn FechaDefuncion;
        private DataGridViewButtonColumn editar;
        private DataGridViewButtonColumn eliminar;
        private Button buttonAgregar;
    }
}