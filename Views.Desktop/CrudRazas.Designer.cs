namespace Views.Desktop
{
    partial class CrudRazas
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
            txtNombre = new TextBox();
            label1 = new Label();
            dgvRazas = new DataGridView();
            RazaId = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvRazas).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(283, 393);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 30;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(156, 393);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(94, 29);
            btnBorrar.TabIndex = 29;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(40, 393);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 28;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(70, 158);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 89);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 16;
            label1.Text = "Nombre";
            // 
            // dgvRazas
            // 
            dgvRazas.AllowUserToDeleteRows = false;
            dgvRazas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRazas.Columns.AddRange(new DataGridViewColumn[] { RazaId, Nombre });
            dgvRazas.Location = new Point(295, 65);
            dgvRazas.Name = "dgvRazas";
            dgvRazas.ReadOnly = true;
            dgvRazas.RowHeadersWidth = 51;
            dgvRazas.Size = new Size(441, 274);
            dgvRazas.TabIndex = 31;
            dgvRazas.DoubleClick += dgvRazas_DoubleClick;
            // 
            // RazaId
            // 
            RazaId.DataPropertyName = "RazaId";
            RazaId.HeaderText = "Column1";
            RazaId.MinimumWidth = 6;
            RazaId.Name = "RazaId";
            RazaId.ReadOnly = true;
            RazaId.Visible = false;
            RazaId.Width = 125;
            // 
            // Nombre
            // 
            Nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // CrudRazas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvRazas);
            Controls.Add(btnCancelar);
            Controls.Add(btnBorrar);
            Controls.Add(btnGuardar);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "CrudRazas";
            Text = "CrudRazas";
            Load += CrudRazas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRazas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCancelar;
        private Button btnBorrar;
        private Button btnGuardar;
        private TextBox txtNombre;
        private Label label1;
        private DataGridView dgvRazas;
        private DataGridViewTextBoxColumn RazaId;
        private DataGridViewTextBoxColumn Nombre;
    }
}