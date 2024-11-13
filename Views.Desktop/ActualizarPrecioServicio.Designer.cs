namespace Views.Desktop
{
    partial class ActualizarPrecioServicio
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
            lblServicio = new Label();
            lblPrecioActual = new Label();
            lblPrecioNuevo = new Label();
            label4 = new Label();
            label5 = new Label();
            txtPrecioActual = new TextBox();
            txtPrecioNuevo = new TextBox();
            btnCancelar = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblServicio
            // 
            lblServicio.AutoSize = true;
            lblServicio.Location = new Point(141, 50);
            lblServicio.Name = "lblServicio";
            lblServicio.Size = new Size(0, 20);
            lblServicio.TabIndex = 0;
            // 
            // lblPrecioActual
            // 
            lblPrecioActual.AutoSize = true;
            lblPrecioActual.Location = new Point(35, 107);
            lblPrecioActual.Name = "lblPrecioActual";
            lblPrecioActual.Size = new Size(99, 20);
            lblPrecioActual.TabIndex = 0;
            lblPrecioActual.Text = "Precio Actual:";
            // 
            // lblPrecioNuevo
            // 
            lblPrecioNuevo.AutoSize = true;
            lblPrecioNuevo.Location = new Point(35, 196);
            lblPrecioNuevo.Name = "lblPrecioNuevo";
            lblPrecioNuevo.Size = new Size(122, 20);
            lblPrecioNuevo.TabIndex = 0;
            lblPrecioNuevo.Text = "Modificar precio:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(163, 196);
            label4.Name = "label4";
            label4.Size = new Size(17, 20);
            label4.TabIndex = 0;
            label4.Text = "$";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(163, 104);
            label5.Name = "label5";
            label5.Size = new Size(17, 20);
            label5.TabIndex = 0;
            label5.Text = "$";
            // 
            // txtPrecioActual
            // 
            txtPrecioActual.Enabled = false;
            txtPrecioActual.Location = new Point(181, 104);
            txtPrecioActual.Name = "txtPrecioActual";
            txtPrecioActual.Size = new Size(125, 27);
            txtPrecioActual.TabIndex = 1;
            // 
            // txtPrecioNuevo
            // 
            txtPrecioNuevo.Location = new Point(181, 193);
            txtPrecioNuevo.Name = "txtPrecioNuevo";
            txtPrecioNuevo.Size = new Size(125, 27);
            txtPrecioNuevo.TabIndex = 1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(47, 256);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(212, 256);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ActualizarPrecioServicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 325);
            Controls.Add(button1);
            Controls.Add(btnCancelar);
            Controls.Add(txtPrecioNuevo);
            Controls.Add(txtPrecioActual);
            Controls.Add(lblPrecioNuevo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblPrecioActual);
            Controls.Add(lblServicio);
            Name = "ActualizarPrecioServicio";
            Text = "ActualizarPrecioServicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblServicio;
        private Label lblPrecioActual;
        private Label lblPrecioNuevo;
        private Label label4;
        private Label label5;
        private TextBox txtPrecioActual;
        private TextBox txtPrecioNuevo;
        private Button btnCancelar;
        private Button button1;
    }
}