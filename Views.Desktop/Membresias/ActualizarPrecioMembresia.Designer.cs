namespace Views.Desktop.Membresias
{
    partial class ActualizarPrecioMembresia
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
            btnCancelar = new Button();
            txtPrecioNuevo = new TextBox();
            txtPrecioActual = new TextBox();
            lblPrecioNuevo = new Label();
            label5 = new Label();
            label4 = new Label();
            lblPrecioActual = new Label();
            lblServicio = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(280, 289);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(115, 289);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtPrecioNuevo
            // 
            txtPrecioNuevo.Location = new Point(249, 226);
            txtPrecioNuevo.Name = "txtPrecioNuevo";
            txtPrecioNuevo.Size = new Size(125, 27);
            txtPrecioNuevo.TabIndex = 8;
            // 
            // txtPrecioActual
            // 
            txtPrecioActual.Enabled = false;
            txtPrecioActual.Location = new Point(249, 137);
            txtPrecioActual.Name = "txtPrecioActual";
            txtPrecioActual.Size = new Size(125, 27);
            txtPrecioActual.TabIndex = 9;
            // 
            // lblPrecioNuevo
            // 
            lblPrecioNuevo.AutoSize = true;
            lblPrecioNuevo.Location = new Point(103, 229);
            lblPrecioNuevo.Name = "lblPrecioNuevo";
            lblPrecioNuevo.Size = new Size(122, 20);
            lblPrecioNuevo.TabIndex = 3;
            lblPrecioNuevo.Text = "Modificar precio:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(231, 137);
            label5.Name = "label5";
            label5.Size = new Size(17, 20);
            label5.TabIndex = 4;
            label5.Text = "$";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(231, 229);
            label4.Name = "label4";
            label4.Size = new Size(17, 20);
            label4.TabIndex = 5;
            label4.Text = "$";
            // 
            // lblPrecioActual
            // 
            lblPrecioActual.AutoSize = true;
            lblPrecioActual.Location = new Point(103, 140);
            lblPrecioActual.Name = "lblPrecioActual";
            lblPrecioActual.Size = new Size(99, 20);
            lblPrecioActual.TabIndex = 6;
            lblPrecioActual.Text = "Precio Actual:";
            // 
            // lblServicio
            // 
            lblServicio.AutoSize = true;
            lblServicio.Location = new Point(209, 83);
            lblServicio.Name = "lblServicio";
            lblServicio.Size = new Size(0, 20);
            lblServicio.TabIndex = 7;
            // 
            // ActualizarPrecioMembresia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 401);
            Controls.Add(button1);
            Controls.Add(btnCancelar);
            Controls.Add(txtPrecioNuevo);
            Controls.Add(txtPrecioActual);
            Controls.Add(lblPrecioNuevo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblPrecioActual);
            Controls.Add(lblServicio);
            Name = "ActualizarPrecioMembresia";
            Text = "ActualizarPrecioMembresia";
            Load += ActualizarPrecioMembresia_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btnCancelar;
        private TextBox txtPrecioNuevo;
        private TextBox txtPrecioActual;
        private Label lblPrecioNuevo;
        private Label label5;
        private Label label4;
        private Label lblPrecioActual;
        private Label lblServicio;
    }
}