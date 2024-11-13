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
            ServicioId = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            label3 = new Label();
            textBoxCodigo = new TextBox();
            buttonEspecialidades = new Button();
            BtnPrecio = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewServicios).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 164);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(103, 216);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 1;
            label2.Text = "Descripcion";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(189, 160);
            textBoxNombre.Margin = new Padding(3, 4, 3, 4);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(137, 27);
            textBoxNombre.TabIndex = 2;
            // 
            // textBoxDescripcion
            // 
            textBoxDescripcion.Location = new Point(189, 212);
            textBoxDescripcion.Margin = new Padding(3, 4, 3, 4);
            textBoxDescripcion.Name = "textBoxDescripcion";
            textBoxDescripcion.Size = new Size(137, 27);
            textBoxDescripcion.TabIndex = 3;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(189, 405);
            buttonGuardar.Margin = new Padding(3, 4, 3, 4);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(137, 53);
            buttonGuardar.TabIndex = 7;
            buttonGuardar.Text = "Registrar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(189, 467);
            buttonEliminar.Margin = new Padding(3, 4, 3, 4);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(137, 53);
            buttonEliminar.TabIndex = 8;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(189, 528);
            buttonCancelar.Margin = new Padding(3, 4, 3, 4);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(137, 53);
            buttonCancelar.TabIndex = 9;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewServicios
            // 
            dataGridViewServicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewServicios.Columns.AddRange(new DataGridViewColumn[] { ServicioId, Nombre, Descripcion });
            dataGridViewServicios.Location = new Point(509, 16);
            dataGridViewServicios.Margin = new Padding(3, 4, 3, 4);
            dataGridViewServicios.Name = "dataGridViewServicios";
            dataGridViewServicios.RowHeadersWidth = 51;
            dataGridViewServicios.Size = new Size(392, 568);
            dataGridViewServicios.TabIndex = 11;
            dataGridViewServicios.DoubleClick += dataGridViewServicios_DoubleClick;
            // 
            // ServicioId
            // 
            ServicioId.DataPropertyName = "ServicioId";
            ServicioId.HeaderText = "ID";
            ServicioId.MinimumWidth = 6;
            ServicioId.Name = "ServicioId";
            ServicioId.Width = 125;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 125;
            // 
            // Descripcion
            // 
            Descripcion.DataPropertyName = "Descripcion";
            Descripcion.HeaderText = "Descripcion";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            Descripcion.Width = 125;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(129, 116);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 12;
            label3.Text = "Codigo";
            // 
            // textBoxCodigo
            // 
            textBoxCodigo.Enabled = false;
            textBoxCodigo.Location = new Point(189, 112);
            textBoxCodigo.Margin = new Padding(3, 4, 3, 4);
            textBoxCodigo.Name = "textBoxCodigo";
            textBoxCodigo.Size = new Size(137, 27);
            textBoxCodigo.TabIndex = 13;
            // 
            // buttonEspecialidades
            // 
            buttonEspecialidades.Location = new Point(65, 297);
            buttonEspecialidades.Margin = new Padding(3, 4, 3, 4);
            buttonEspecialidades.Name = "buttonEspecialidades";
            buttonEspecialidades.Size = new Size(137, 40);
            buttonEspecialidades.TabIndex = 14;
            buttonEspecialidades.Text = "Especialidades";
            buttonEspecialidades.UseVisualStyleBackColor = true;
            buttonEspecialidades.Click += buttonEspecialidades_Click;
            // 
            // BtnPrecio
            // 
            BtnPrecio.Location = new Point(265, 298);
            BtnPrecio.Name = "BtnPrecio";
            BtnPrecio.Size = new Size(138, 39);
            BtnPrecio.TabIndex = 15;
            BtnPrecio.Text = "Actualizar Precio";
            BtnPrecio.UseVisualStyleBackColor = true;
            BtnPrecio.Click += BtnPrecio_Click;
            // 
            // CrudServicios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1127, 706);
            Controls.Add(BtnPrecio);
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
            Margin = new Padding(3, 4, 3, 4);
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
        private Button BtnPrecio;
    }
}