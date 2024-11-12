namespace Views.Desktop
{
    partial class MembresiasCliente
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
            textBoxMembresiasCliente = new TextBox();
            dgvMembresiasCliente = new DataGridView();
            descripcion = new DataGridViewTextBoxColumn();
            fechaDesde = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            porcentajeDescuento = new DataGridViewTextBoxColumn();
            button2 = new Button();
            label2 = new Label();
            labelTiempoRestante = new Label();
            label3 = new Label();
            labelNombreMembresia = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMembresiasCliente).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(338, 41);
            button1.Name = "button1";
            button1.Size = new Size(137, 23);
            button1.TabIndex = 0;
            button1.Text = "Buscar membresias";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 44);
            label1.Name = "label1";
            label1.Size = new Size(132, 15);
            label1.TabIndex = 1;
            label1.Text = "Ingresar DNI del cliente:";
            // 
            // textBoxMembresiasCliente
            // 
            textBoxMembresiasCliente.Location = new Point(169, 41);
            textBoxMembresiasCliente.Name = "textBoxMembresiasCliente";
            textBoxMembresiasCliente.Size = new Size(163, 23);
            textBoxMembresiasCliente.TabIndex = 2;
            // 
            // dgvMembresiasCliente
            // 
            dgvMembresiasCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMembresiasCliente.Columns.AddRange(new DataGridViewColumn[] { descripcion, fechaDesde, precio, porcentajeDescuento });
            dgvMembresiasCliente.Location = new Point(31, 92);
            dgvMembresiasCliente.Name = "dgvMembresiasCliente";
            dgvMembresiasCliente.RowHeadersWidth = 51;
            dgvMembresiasCliente.Size = new Size(553, 227);
            dgvMembresiasCliente.TabIndex = 3;
            // 
            // descripcion
            // 
            descripcion.DataPropertyName = "descripcion";
            descripcion.HeaderText = "Nombre";
            descripcion.MinimumWidth = 6;
            descripcion.Name = "descripcion";
            descripcion.Width = 125;
            // 
            // fechaDesde
            // 
            fechaDesde.DataPropertyName = "fechaDesde";
            fechaDesde.HeaderText = "Fecha de pago";
            fechaDesde.MinimumWidth = 6;
            fechaDesde.Name = "fechaDesde";
            fechaDesde.Width = 125;
            // 
            // precio
            // 
            precio.DataPropertyName = "precio";
            precio.HeaderText = "Precio";
            precio.MinimumWidth = 6;
            precio.Name = "precio";
            precio.Width = 125;
            // 
            // porcentajeDescuento
            // 
            porcentajeDescuento.DataPropertyName = "porcentajeDescuento";
            porcentajeDescuento.HeaderText = "Porcentaje de descuento";
            porcentajeDescuento.MinimumWidth = 6;
            porcentajeDescuento.Name = "porcentajeDescuento";
            porcentajeDescuento.Width = 125;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 255, 128);
            button2.Location = new Point(471, 325);
            button2.Name = "button2";
            button2.Size = new Size(113, 23);
            button2.TabIndex = 4;
            button2.Text = "Registrar pago";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 353);
            label2.Name = "label2";
            label2.Size = new Size(158, 15);
            label2.TabIndex = 5;
            label2.Text = "Tiempo restante de vigencia:";
            // 
            // labelTiempoRestante
            // 
            labelTiempoRestante.AutoSize = true;
            labelTiempoRestante.Location = new Point(195, 353);
            labelTiempoRestante.Name = "labelTiempoRestante";
            labelTiempoRestante.Size = new Size(12, 15);
            labelTiempoRestante.TabIndex = 6;
            labelTiempoRestante.Text = "-";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 329);
            label3.Name = "label3";
            label3.Size = new Size(132, 15);
            label3.TabIndex = 7;
            label3.Text = "Nombre de membresia:";
            // 
            // labelNombreMembresia
            // 
            labelNombreMembresia.AutoSize = true;
            labelNombreMembresia.Location = new Point(195, 329);
            labelNombreMembresia.Name = "labelNombreMembresia";
            labelNombreMembresia.Size = new Size(12, 15);
            labelNombreMembresia.TabIndex = 8;
            labelNombreMembresia.Text = "-";
            // 
            // MembresiasCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelNombreMembresia);
            Controls.Add(label3);
            Controls.Add(labelTiempoRestante);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(dgvMembresiasCliente);
            Controls.Add(textBoxMembresiasCliente);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "MembresiasCliente";
            Text = "MembresiasCliente";
            ((System.ComponentModel.ISupportInitialize)dgvMembresiasCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBoxMembresiasCliente;
        private DataGridView dgvMembresiasCliente;
        private DataGridViewTextBoxColumn descripcion;
        private DataGridViewTextBoxColumn fechaDesde;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn porcentajeDescuento;
        private Button button2;
        private Label label2;
        private Label labelTiempoRestante;
        private Label label3;
        private Label labelNombreMembresia;
    }
}