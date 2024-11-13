namespace Views.Desktop.Atenciones
{
    partial class CancelarTurno
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
            btnVolver = new Button();
            lblConfirmacion = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(254, 191);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(124, 29);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar Turno";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(97, 191);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(94, 29);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblConfirmacion
            // 
            lblConfirmacion.AutoSize = true;
            lblConfirmacion.Location = new Point(81, 67);
            lblConfirmacion.Name = "lblConfirmacion";
            lblConfirmacion.Size = new Size(306, 20);
            lblConfirmacion.TabIndex = 2;
            lblConfirmacion.Text = "¿Está seguro de que desea cancelar el turno?";
            // 
            // CancelarTurno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 291);
            Controls.Add(btnCancelar);
            Controls.Add(btnVolver);
            Controls.Add(lblConfirmacion);
            Name = "CancelarTurno";
            Text = "CancelarTurno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnVolver;
        private Label lblConfirmacion;
    }
}