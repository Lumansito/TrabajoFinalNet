namespace Views.Desktop.Atenciones
{
    partial class RegistrarPago
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
            lblConfirmacion = new Label();
            btnCancelar = new Button();
            btnConfirmar = new Button();
            SuspendLayout();
            // 
            // lblConfirmacion
            // 
            lblConfirmacion.AutoSize = true;
            lblConfirmacion.Location = new Point(103, 92);
            lblConfirmacion.Name = "lblConfirmacion";
            lblConfirmacion.Size = new Size(315, 20);
            lblConfirmacion.TabIndex = 0;
            lblConfirmacion.Text = "¿Está seguro de que desea confirmar el pago?";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(119, 216);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(303, 216);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(94, 29);
            btnConfirmar.TabIndex = 1;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // RegistrarPago
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 324);
            Controls.Add(btnConfirmar);
            Controls.Add(btnCancelar);
            Controls.Add(lblConfirmacion);
            Name = "RegistrarPago";
            Text = "RegistrarPago";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblConfirmacion;
        private Button btnCancelar;
        private Button btnConfirmar;
    }
}