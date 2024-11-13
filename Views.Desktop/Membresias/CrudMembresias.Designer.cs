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
            MembresiaId = new DataGridViewTextBoxColumn();
            Antiguedad = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMembresias).BeginInit();
            SuspendLayout();
            // 
            // BtnPrecio
            // 
            BtnPrecio.Location = new Point(79, 387);
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
            textBoxCodigo.Location = new Point(285, 176);
            textBoxCodigo.Margin = new Padding(3, 4, 3, 4);
            textBoxCodigo.Name = "textBoxCodigo";
            textBoxCodigo.Size = new Size(169, 27);
            textBoxCodigo.TabIndex = 25;
            // 
            // dataGridViewMembresias
            // 
            dataGridViewMembresias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMembresias.Columns.AddRange(new DataGridViewColumn[] { MembresiaId, Antiguedad, Descripcion });
            dataGridViewMembresias.Location = new Point(580, 69);
            dataGridViewMembresias.Margin = new Padding(3, 4, 3, 4);
            dataGridViewMembresias.Name = "dataGridViewMembresias";
            dataGridViewMembresias.RowHeadersWidth = 51;
            dataGridViewMembresias.Size = new Size(427, 515);
            dataGridViewMembresias.TabIndex = 23;
            dataGridViewMembresias.DoubleClick += dataGridViewMembresias_DoubleClick_1;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(79, 459);
            buttonCancelar.Margin = new Padding(3, 4, 3, 4);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(137, 53);
            buttonCancelar.TabIndex = 22;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(419, 459);
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
            buttonGuardar.Location = new Point(260, 459);
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
            lblAntiguedad.Location = new Point(110, 242);
            lblAntiguedad.Name = "lblAntiguedad";
            lblAntiguedad.Size = new Size(199, 20);
            lblAntiguedad.TabIndex = 16;
            lblAntiguedad.Text = "Antiguedad Minima en años:";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(110, 179);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(58, 20);
            lblCodigo.TabIndex = 29;
            lblCodigo.Text = "Codigo";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(110, 303);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(90, 20);
            lblDescripcion.TabIndex = 16;
            lblDescripcion.Text = "Descripcion:";
            // 
            // txtAntiguedad
            // 
            txtAntiguedad.Location = new Point(326, 240);
            txtAntiguedad.Name = "txtAntiguedad";
            txtAntiguedad.Size = new Size(125, 27);
            txtAntiguedad.TabIndex = 30;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(285, 300);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(212, 83);
            txtDescripcion.TabIndex = 31;
            txtDescripcion.Text = "";
            // 
            // MembresiaId
            // 
            MembresiaId.DataPropertyName = "MembresiaId";
            MembresiaId.HeaderText = "ID";
            MembresiaId.MinimumWidth = 6;
            MembresiaId.Name = "MembresiaId";
            MembresiaId.Width = 125;
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
            ClientSize = new Size(1108, 707);
            Controls.Add(txtDescripcion);
            Controls.Add(txtAntiguedad);
            Controls.Add(lblCodigo);
            Controls.Add(BtnPrecio);
            Controls.Add(textBoxCodigo);
            Controls.Add(dataGridViewMembresias);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonGuardar);
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
        private DataGridViewTextBoxColumn MembresiaId;
        private DataGridViewTextBoxColumn Antiguedad;
        private DataGridViewTextBoxColumn Descripcion;
    }
}