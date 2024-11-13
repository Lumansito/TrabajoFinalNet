namespace Views.Desktop.Atenciones
{
    partial class ObservacionesForm
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
            lblMotivo = new Label();
            lblObservaciones = new Label();
            lblServicios = new Label();
            lblDescuentos = new Label();
            txtMotivo = new RichTextBox();
            txtObservaciones = new RichTextBox();
            txtServicios = new RichTextBox();
            txtDescuentos = new RichTextBox();
            BtnCerrar = new Button();
            SuspendLayout();
            // 
            // lblMotivo
            // 
            lblMotivo.AutoSize = true;
            lblMotivo.Location = new Point(82, 42);
            lblMotivo.Name = "lblMotivo";
            lblMotivo.Size = new Size(157, 20);
            lblMotivo.TabIndex = 0;
            lblMotivo.Text = "Motivo de la atención:";
            lblMotivo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblObservaciones
            // 
            lblObservaciones.AutoSize = true;
            lblObservaciones.Location = new Point(82, 171);
            lblObservaciones.Name = "lblObservaciones";
            lblObservaciones.Size = new Size(108, 20);
            lblObservaciones.TabIndex = 0;
            lblObservaciones.Text = "Observaciones:";
            // 
            // lblServicios
            // 
            lblServicios.AutoSize = true;
            lblServicios.Location = new Point(82, 299);
            lblServicios.Name = "lblServicios";
            lblServicios.Size = new Size(145, 20);
            lblServicios.TabIndex = 0;
            lblServicios.Text = "Servicios requeridos:";
            // 
            // lblDescuentos
            // 
            lblDescuentos.AutoSize = true;
            lblDescuentos.Location = new Point(82, 431);
            lblDescuentos.Name = "lblDescuentos";
            lblDescuentos.Size = new Size(156, 20);
            lblDescuentos.TabIndex = 0;
            lblDescuentos.Text = "Descuentos aplicados:";
            // 
            // txtMotivo
            // 
            txtMotivo.Location = new Point(277, 39);
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new Size(515, 104);
            txtMotivo.TabIndex = 1;
            txtMotivo.Text = "";
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(277, 168);
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(515, 104);
            txtObservaciones.TabIndex = 1;
            txtObservaciones.Text = "";
            // 
            // txtServicios
            // 
            txtServicios.Location = new Point(277, 299);
            txtServicios.Name = "txtServicios";
            txtServicios.Size = new Size(515, 104);
            txtServicios.TabIndex = 1;
            txtServicios.Text = "";
            // 
            // txtDescuentos
            // 
            txtDescuentos.Location = new Point(277, 428);
            txtDescuentos.Name = "txtDescuentos";
            txtDescuentos.Size = new Size(515, 104);
            txtDescuentos.TabIndex = 1;
            txtDescuentos.Text = "";
            // 
            // BtnCerrar
            // 
            BtnCerrar.Location = new Point(382, 567);
            BtnCerrar.Name = "BtnCerrar";
            BtnCerrar.Size = new Size(94, 29);
            BtnCerrar.TabIndex = 2;
            BtnCerrar.Text = "Cerrar";
            BtnCerrar.UseVisualStyleBackColor = true;
            // 
            // ObservacionesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 631);
            Controls.Add(BtnCerrar);
            Controls.Add(txtDescuentos);
            Controls.Add(txtObservaciones);
            Controls.Add(txtServicios);
            Controls.Add(txtMotivo);
            Controls.Add(lblDescuentos);
            Controls.Add(lblObservaciones);
            Controls.Add(lblServicios);
            Controls.Add(lblMotivo);
            Name = "ObservacionesForm";
            Text = "ObservacionesForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMotivo;
        private Label lblObservaciones;
        private Label lblServicios;
        private Label lblDescuentos;
        private RichTextBox txtMotivo;
        private RichTextBox txtObservaciones;
        private RichTextBox txtServicios;
        private RichTextBox txtDescuentos;
        private Button BtnCerrar;
    }
}