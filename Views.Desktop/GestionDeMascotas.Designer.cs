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
            button1 = new Button();
            label1 = new Label();
            textBoxDni = new TextBox();
            dgvGestionDeMascotas = new DataGridView();
            nombreMascota = new DataGridViewTextBoxColumn();
            edad = new DataGridViewTextBoxColumn();
            nombreRaza = new DataGridViewTextBoxColumn();
            nombreEspecie = new DataGridViewTextBoxColumn();
            fechaDefuncion = new DataGridViewTextBoxColumn();
            editar = new DataGridViewButtonColumn();
            eliminar = new DataGridViewButtonColumn();
            label2 = new Label();
            labelNombreDueño = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvGestionDeMascotas).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(357, 125);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(179, 31);
            button1.TabIndex = 0;
            button1.Text = "Buscar sus mascotas";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            dgvGestionDeMascotas.Columns.AddRange(new DataGridViewColumn[] { nombreMascota, edad, nombreRaza, nombreEspecie, fechaDefuncion, editar, eliminar });
            dgvGestionDeMascotas.Location = new Point(30, 236);
            dgvGestionDeMascotas.Margin = new Padding(3, 4, 3, 4);
            dgvGestionDeMascotas.Name = "dgvGestionDeMascotas";
            dgvGestionDeMascotas.RowHeadersWidth = 51;
            dgvGestionDeMascotas.Size = new Size(849, 200);
            dgvGestionDeMascotas.TabIndex = 3;
            dgvGestionDeMascotas.CellContentClick += dgvGestionDeMascotas_CellContentClick;
            // 
            // nombreMascota
            // 
            nombreMascota.DataPropertyName = "nombreMascota";
            nombreMascota.HeaderText = "Nombre";
            nombreMascota.MinimumWidth = 6;
            nombreMascota.Name = "nombreMascota";
            nombreMascota.Width = 125;
            // 
            // edad
            // 
            edad.DataPropertyName = "edad";
            edad.HeaderText = "Edad";
            edad.MinimumWidth = 6;
            edad.Name = "edad";
            edad.Width = 125;
            // 
            // nombreRaza
            // 
            nombreRaza.DataPropertyName = "nombreRaza";
            nombreRaza.HeaderText = "Raza";
            nombreRaza.MinimumWidth = 6;
            nombreRaza.Name = "nombreRaza";
            nombreRaza.Width = 125;
            // 
            // nombreEspecie
            // 
            nombreEspecie.DataPropertyName = "nombreEspecie";
            nombreEspecie.HeaderText = "Especie";
            nombreEspecie.MinimumWidth = 6;
            nombreEspecie.Name = "nombreEspecie";
            nombreEspecie.Width = 125;
            // 
            // fechaDefuncion
            // 
            fechaDefuncion.DataPropertyName = "fechaDefuncion";
            fechaDefuncion.HeaderText = "Fecha de defuncion";
            fechaDefuncion.MinimumWidth = 6;
            fechaDefuncion.Name = "fechaDefuncion";
            fechaDefuncion.Width = 125;
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
            // GestionDeMascotas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(labelNombreDueño);
            Controls.Add(label2);
            Controls.Add(dgvGestionDeMascotas);
            Controls.Add(textBoxDni);
            Controls.Add(label1);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "GestionDeMascotas";
            Text = "GestionDeMascotas";
            ((System.ComponentModel.ISupportInitialize)dgvGestionDeMascotas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBoxDni;
        private DataGridView dgvGestionDeMascotas;
        private Label label2;
        private Label labelNombreDueño;
        private DataGridViewTextBoxColumn nombreMascota;
        private DataGridViewTextBoxColumn edad;
        private DataGridViewTextBoxColumn nombreRaza;
        private DataGridViewTextBoxColumn nombreEspecie;
        private DataGridViewTextBoxColumn fechaDefuncion;
        private DataGridViewButtonColumn editar;
        private DataGridViewButtonColumn eliminar;
    }
}