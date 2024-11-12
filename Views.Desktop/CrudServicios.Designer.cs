namespace Views.Desktop
{
    partial class CrudServicios
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
            label1 = new Label();
            label2 = new Label();
            textBoxNombre = new TextBox();
            textBoxDescripcion = new TextBox();
            buttonGuardar = new Button();
            buttonEliminar = new Button();
            buttonCancelar = new Button();
            dataGridViewServicios = new DataGridView();
            label3 = new Label();
            textBoxCodigo = new TextBox();
            buttonEspecialidades = new Button();
            ServicioId = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewServicios).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 123);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 162);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 1;
            label2.Text = "Descripcion";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(165, 120);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(120, 23);
            textBoxNombre.TabIndex = 2;
            // 
            // textBoxDescripcion
            // 
            textBoxDescripcion.Location = new Point(165, 159);
            textBoxDescripcion.Name = "textBoxDescripcion";
            textBoxDescripcion.Size = new Size(120, 23);
            textBoxDescripcion.TabIndex = 3;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(165, 304);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(120, 40);
            buttonGuardar.TabIndex = 7;
            buttonGuardar.Text = "Registrar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(165, 350);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(120, 40);
            buttonEliminar.TabIndex = 8;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(165, 396);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(120, 40);
            buttonCancelar.TabIndex = 9;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewServicios
            // 
            dataGridViewServicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewServicios.Columns.AddRange(new DataGridViewColumn[] { ServicioId, Nombre, Descripcion });
            dataGridViewServicios.Location = new Point(445, 12);
            dataGridViewServicios.Name = "dataGridViewServicios";
            dataGridViewServicios.Size = new Size(343, 426);
            dataGridViewServicios.TabIndex = 11;
            dataGridViewServicios.DoubleClick += dataGridViewServicios_DoubleClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(113, 87);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 12;
            label3.Text = "Codigo";
            // 
            // textBoxCodigo
            // 
            textBoxCodigo.Enabled = false;
            textBoxCodigo.Location = new Point(165, 84);
            textBoxCodigo.Name = "textBoxCodigo";
            textBoxCodigo.Size = new Size(120, 23);
            textBoxCodigo.TabIndex = 13;
            // 
            // buttonEspecialidades
            // 
            buttonEspecialidades.Location = new Point(165, 198);
            buttonEspecialidades.Name = "buttonEspecialidades";
            buttonEspecialidades.Size = new Size(120, 30);
            buttonEspecialidades.TabIndex = 14;
            buttonEspecialidades.Text = "Especialidades";
            buttonEspecialidades.UseVisualStyleBackColor = true;
            buttonEspecialidades.Click += buttonEspecialidades_Click;
            // 
            // ServicioId
            // 
            ServicioId.DataPropertyName = "ServicioId";
            ServicioId.HeaderText = "ID";
            ServicioId.Name = "ServicioId";
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Descripcion
            // 
            Descripcion.DataPropertyName = "Descripcion";
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            // 
            // CrudServicios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonEspecialidades);
            Controls.Add(textBoxCodigo);
            Controls.Add(label3);
            Controls.Add(dataGridViewServicios);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonGuardar);
            Controls.Add(textBoxDescripcion);
            Controls.Add(textBoxNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CrudServicios";
            Text = "CrudServicios";
            Load += CrudServicios_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewServicios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxCodigo;
        private TextBox textBoxNombre;
        private TextBox textBoxDescripcion;
        private Button buttonGuardar;
        private Button buttonEliminar;
        private Button buttonCancelar;
        private DataGridView dataGridViewServicios;
        private Button buttonEspecialidades;
        private DataGridViewTextBoxColumn ServicioId;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
    }
}