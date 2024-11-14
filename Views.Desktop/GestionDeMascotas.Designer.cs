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
            buttonBuscarMascotas.Location = new Point(312, 94);
            buttonBuscarMascotas.Name = "buttonBuscarMascotas";
            buttonBuscarMascotas.Size = new Size(157, 23);
            buttonBuscarMascotas.TabIndex = 0;
            buttonBuscarMascotas.Text = "Buscar sus mascotas";
            buttonBuscarMascotas.UseVisualStyleBackColor = true;
            buttonBuscarMascotas.Click += buttonBuscarMascotas_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 97);
            label1.Name = "label1";
            label1.Size = new Size(131, 15);
            label1.TabIndex = 1;
            label1.Text = "Ingresar DNI del dueño:";
            // 
            // textBoxDni
            // 
            textBoxDni.Location = new Point(163, 94);
            textBoxDni.Name = "textBoxDni";
            textBoxDni.Size = new Size(143, 23);
            textBoxDni.TabIndex = 2;
            // 
            // dgvGestionDeMascotas
            // 
            dgvGestionDeMascotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGestionDeMascotas.Columns.AddRange(new DataGridViewColumn[] { MascotaId, NombreMascota, Edad, NombreRaza, NombreEspecie, FechaDefuncion, editar, eliminar });
            dgvGestionDeMascotas.Location = new Point(12, 169);
            dgvGestionDeMascotas.Name = "dgvGestionDeMascotas";
            dgvGestionDeMascotas.RowHeadersWidth = 51;
            dgvGestionDeMascotas.Size = new Size(776, 150);
            dgvGestionDeMascotas.TabIndex = 3;
            dgvGestionDeMascotas.CellContentClick += dgvGestionDeMascotas_CellContentClick;
            // 
            // MascotaId
            // 
            MascotaId.DataPropertyName = "MascotaId";
            MascotaId.HeaderText = "ID";
            MascotaId.Name = "MascotaId";
            // 
            // NombreMascota
            // 
            NombreMascota.DataPropertyName = "NombreMascota";
            NombreMascota.HeaderText = "Nombre";
            NombreMascota.Name = "NombreMascota";
            // 
            // Edad
            // 
            Edad.DataPropertyName = "Edad";
            Edad.HeaderText = "Edad";
            Edad.Name = "Edad";
            // 
            // NombreRaza
            // 
            NombreRaza.DataPropertyName = "NombreRaza";
            NombreRaza.HeaderText = "Raza";
            NombreRaza.Name = "NombreRaza";
            // 
            // NombreEspecie
            // 
            NombreEspecie.DataPropertyName = "NombreEspecie";
            NombreEspecie.HeaderText = "Especie";
            NombreEspecie.Name = "NombreEspecie";
            // 
            // FechaDefuncion
            // 
            FechaDefuncion.DataPropertyName = "FechaDefuncion";
            FechaDefuncion.HeaderText = "FechaDefuncion";
            FechaDefuncion.Name = "FechaDefuncion";
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
            label2.Location = new Point(26, 141);
            label2.Name = "label2";
            label2.Size = new Size(164, 15);
            label2.TabIndex = 4;
            label2.Text = "Nombre y apellido del dueño:";
            // 
            // labelNombreDueño
            // 
            labelNombreDueño.AutoSize = true;
            labelNombreDueño.Location = new Point(196, 141);
            labelNombreDueño.Name = "labelNombreDueño";
            labelNombreDueño.Size = new Size(12, 15);
            labelNombreDueño.TabIndex = 5;
            labelNombreDueño.Text = "-";
            // 
            // buttonAgregar
            // 
            buttonAgregar.Location = new Point(12, 336);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(75, 23);
            buttonAgregar.TabIndex = 6;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // GestionDeMascotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonAgregar);
            Controls.Add(labelNombreDueño);
            Controls.Add(label2);
            Controls.Add(dgvGestionDeMascotas);
            Controls.Add(textBoxDni);
            Controls.Add(label1);
            Controls.Add(buttonBuscarMascotas);
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