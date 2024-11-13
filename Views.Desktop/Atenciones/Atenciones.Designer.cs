namespace Views.Desktop.Atenciones
{
    partial class Atenciones
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
            dgvAtenciones = new DataGridView();
            btnBuscar = new Button();
            BtnBorrarFiltro = new Button();
            txtDniCliente = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvAtenciones).BeginInit();
            SuspendLayout();
            // 
            // dgvAtenciones
            // 
            dgvAtenciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAtenciones.Location = new Point(79, 82);
            dgvAtenciones.Name = "dgvAtenciones";
            dgvAtenciones.RowHeadersWidth = 51;
            dgvAtenciones.Size = new Size(1036, 272);
            dgvAtenciones.TabIndex = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(328, 43);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click_1;
            // 
            // BtnBorrarFiltro
            // 
            BtnBorrarFiltro.Location = new Point(437, 43);
            BtnBorrarFiltro.Name = "BtnBorrarFiltro";
            BtnBorrarFiltro.Size = new Size(94, 29);
            BtnBorrarFiltro.TabIndex = 2;
            BtnBorrarFiltro.Text = "Borrar filtro";
            BtnBorrarFiltro.UseVisualStyleBackColor = true;
            BtnBorrarFiltro.Click += BtnBorrarFiltro_Click_1;
            // 
            // txtDniCliente
            // 
            txtDniCliente.Location = new Point(79, 43);
            txtDniCliente.Name = "txtDniCliente";
            txtDniCliente.Size = new Size(243, 27);
            txtDniCliente.TabIndex = 3;
            txtDniCliente.Text = "Ingrese el DNI del cliente:";
            // 
            // Atenciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtDniCliente);
            Controls.Add(BtnBorrarFiltro);
            Controls.Add(btnBuscar);
            Controls.Add(dgvAtenciones);
            Name = "Atenciones";
            Text = "Atenciones";
            ((System.ComponentModel.ISupportInitialize)dgvAtenciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAtenciones;
        private Button btnBuscar;
        private Button BtnBorrarFiltro;
        private TextBox txtDniCliente;
    }
}