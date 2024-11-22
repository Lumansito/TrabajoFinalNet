namespace Views.Desktop.Membresias
{
    partial class CrudMembresias
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
            BtnPrecio = new Button();
            textBoxCodigo = new TextBox();
            dataGridViewMembresias = new DataGridView();
            buttonCancelar = new Button();
            buttonEliminar = new Button();
            buttonGuardar = new Button();
            lblAntiguedad = new Label();
            lblCodigo = new Label();
            lblDescripcion = new Label();
            txtAntiguedad = new TextBox();
            txtDescripcion = new RichTextBox();
            lblAnios = new Label();
            lblDescuento = new Label();
            txtDescuento = new TextBox();
            lblPorcentaje = new Label();
            MembresiaId = new DataGridViewTextBoxColumn();
            Descuento = new DataGridViewTextBoxColumn();
            Antiguedad = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMembresias).BeginInit();
            SuspendLayout();
            // 
            // BtnPrecio
            // 
            BtnPrecio.Location = new Point(79, 413);
            BtnPrecio.Name = "BtnPrecio";
            BtnPrecio.Size = new Size(138, 39);
            BtnPrecio.TabIndex = 27;
            BtnPrecio.Text = "Actualizar Precio";
            BtnPrecio.UseVisualStyleBackColor = true;
            BtnPrecio.Click += BtnPrecio_Click;
            // 
            // textBoxCodigo
            // 
            textBoxCodigo.Enabled = false;
            textBoxCodigo.Location = new Point(282, 135);
            textBoxCodigo.Margin = new Padding(3, 4, 3, 4);
            textBoxCodigo.Name = "textBoxCodigo";
            textBoxCodigo.Size = new Size(115, 27);
            textBoxCodigo.TabIndex = 25;
            // 
            // dataGridViewMembresias
            // 
            dataGridViewMembresias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMembresias.Columns.AddRange(new DataGridViewColumn[] { MembresiaId, Descuento, Antiguedad, Descripcion });
            dataGridViewMembresias.Location = new Point(580, 69);
            dataGridViewMembresias.Margin = new Padding(3, 4, 3, 4);
            dataGridViewMembresias.Name = "dataGridViewMembresias";
            dataGridViewMembresias.RowHeadersWidth = 51;
            dataGridViewMembresias.Size = new Size(552, 515);
            dataGridViewMembresias.TabIndex = 23;
            dataGridViewMembresias.DoubleClick += dataGridViewMembresias_DoubleClick_1;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(79, 481);
            buttonCancelar.Margin = new Padding(3, 4, 3, 4);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(137, 53);
            buttonCancelar.TabIndex = 22;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(417, 481);
            buttonEliminar.Margin = new Padding(3, 4, 3, 4);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(137, 53);
            buttonEliminar.TabIndex = 21;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(251, 481);
            buttonGuardar.Margin = new Padding(3, 4, 3, 4);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(137, 53);
            buttonGuardar.TabIndex = 20;
            buttonGuardar.Text = "Registrar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // lblAntiguedad
            // 
            lblAntiguedad.AutoSize = true;
            lblAntiguedad.Location = new Point(121, 191);
            lblAntiguedad.Name = "lblAntiguedad";
            lblAntiguedad.Size = new Size(144, 20);
            lblAntiguedad.TabIndex = 16;
            lblAntiguedad.Text = "Antiguedad Minima:";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(121, 135);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(58, 20);
            lblCodigo.TabIndex = 29;
            lblCodigo.Text = "Codigo";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(121, 250);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(90, 20);
            lblDescripcion.TabIndex = 16;
            lblDescripcion.Text = "Descripcion:";
            // 
            // txtAntiguedad
            // 
            txtAntiguedad.Location = new Point(282, 188);
            txtAntiguedad.Name = "txtAntiguedad";
            txtAntiguedad.Size = new Size(45, 27);
            txtAntiguedad.TabIndex = 30;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(282, 247);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(212, 83);
            txtDescripcion.TabIndex = 31;
            txtDescripcion.Text = "";
            // 
            // lblAnios
            // 
            lblAnios.AutoSize = true;
            lblAnios.Location = new Point(333, 195);
            lblAnios.Name = "lblAnios";
            lblAnios.Size = new Size(40, 20);
            lblAnios.TabIndex = 29;
            lblAnios.Text = "años";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(121, 348);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(82, 20);
            lblDescuento.TabIndex = 16;
            lblDescuento.Text = "Descuento:";
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(282, 341);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(45, 27);
            txtDescuento.TabIndex = 30;
            // 
            // lblPorcentaje
            // 
            lblPorcentaje.AutoSize = true;
            lblPorcentaje.Location = new Point(260, 348);
            lblPorcentaje.Name = "lblPorcentaje";
            lblPorcentaje.Size = new Size(21, 20);
            lblPorcentaje.TabIndex = 29;
            lblPorcentaje.Text = "%";
            // 
            // MembresiaId
            // 
            MembresiaId.DataPropertyName = "MembresiaId";
            MembresiaId.HeaderText = "ID";
            MembresiaId.MinimumWidth = 6;
            MembresiaId.Name = "MembresiaId";
            MembresiaId.Width = 125;
            // 
            // Descuento
            // 
            Descuento.DataPropertyName = "PorcentajeDescuento";
            Descuento.HeaderText = "Porcentaje Descuento";
            Descuento.MinimumWidth = 6;
            Descuento.Name = "Descuento";
            Descuento.ReadOnly = true;
            Descuento.Width = 125;
            // 
            // Antiguedad
            // 
            Antiguedad.DataPropertyName = "AntiguedadMInimaCliente";
            Antiguedad.HeaderText = "Antiguedad Minima";
            Antiguedad.MinimumWidth = 6;
            Antiguedad.Name = "Antiguedad";
            Antiguedad.Width = 125;
            // 
            // Descripcion
            // 
            Descripcion.DataPropertyName = "Descripcion";
            Descripcion.HeaderText = "Descripcion";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            Descripcion.Width = 125;
            // 
            // CrudMembresias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1246, 707);
            Controls.Add(txtDescripcion);
            Controls.Add(txtDescuento);
            Controls.Add(txtAntiguedad);
            Controls.Add(lblPorcentaje);
            Controls.Add(lblAnios);
            Controls.Add(lblCodigo);
            Controls.Add(BtnPrecio);
            Controls.Add(textBoxCodigo);
            Controls.Add(dataGridViewMembresias);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonGuardar);
            Controls.Add(lblDescuento);
            Controls.Add(lblDescripcion);
            Controls.Add(lblAntiguedad);
            Name = "CrudMembresias";
            Text = "CrudMembresias";
            Load += CrudMembresias_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMembresias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnPrecio;
        private Button buttonEspecialidades;
        private TextBox textBoxCodigo;
        private Label label3;
        private DataGridView dataGridViewMembresias;
        private Button buttonCancelar;
        private Button buttonEliminar;
        private Button buttonGuardar;
        private Label label2;
        private Label lblAntiguedad;
        private Label lblCodigo;
        private Label lblDescripcion;
        private TextBox txtAntiguedad;
        private RichTextBox txtDescripcion;
        private Label lblAnios;
        private Label lblDescuento;
        private TextBox txtDescuento;
        private Label lblPorcentaje;
        private DataGridViewTextBoxColumn MembresiaId;
        private DataGridViewTextBoxColumn Descuento;
        private DataGridViewTextBoxColumn Antiguedad;
        private DataGridViewTextBoxColumn Descripcion;
    }
}