namespace Views.Desktop
{
    partial class RegistrarPagoMembresia
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxDni = new TextBox();
            label4 = new Label();
            comboBoxMembresias = new ComboBox();
            textBoxPrecio = new TextBox();
            textBoxPorcentaje = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(218, 98);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 0;
            label1.Text = "DNI del cliente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(161, 136);
            label2.Name = "label2";
            label2.Size = new Size(144, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre de la membresia:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(172, 175);
            label3.Name = "label3";
            label3.Size = new Size(133, 15);
            label3.TabIndex = 2;
            label3.Text = "Precio de la membresia:";
            // 
            // textBoxDni
            // 
            textBoxDni.Location = new Point(311, 95);
            textBoxDni.Name = "textBoxDni";
            textBoxDni.Size = new Size(165, 23);
            textBoxDni.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(165, 215);
            label4.Name = "label4";
            label4.Size = new Size(140, 15);
            label4.TabIndex = 4;
            label4.Text = "Porcentaje de descuento:";
            // 
            // comboBoxMembresias
            // 
            comboBoxMembresias.FormattingEnabled = true;
            comboBoxMembresias.Location = new Point(311, 133);
            comboBoxMembresias.Name = "comboBoxMembresias";
            comboBoxMembresias.Size = new Size(165, 23);
            comboBoxMembresias.TabIndex = 5;
            comboBoxMembresias.Text = "Seleccionar membresia ...";
            comboBoxMembresias.SelectedIndexChanged += comboBoxMembresias_SelectedIndexChanged;
            // 
            // textBoxPrecio
            // 
            textBoxPrecio.Enabled = false;
            textBoxPrecio.Location = new Point(311, 172);
            textBoxPrecio.Name = "textBoxPrecio";
            textBoxPrecio.Size = new Size(165, 23);
            textBoxPrecio.TabIndex = 6;
            // 
            // textBoxPorcentaje
            // 
            textBoxPorcentaje.Enabled = false;
            textBoxPorcentaje.Location = new Point(311, 212);
            textBoxPorcentaje.Name = "textBoxPorcentaje";
            textBoxPorcentaje.Size = new Size(165, 23);
            textBoxPorcentaje.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(311, 254);
            button1.Name = "button1";
            button1.Size = new Size(165, 23);
            button1.TabIndex = 8;
            button1.Text = "Registrar pago";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // RegistrarPagoMembresia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBoxPorcentaje);
            Controls.Add(textBoxPrecio);
            Controls.Add(comboBoxMembresias);
            Controls.Add(label4);
            Controls.Add(textBoxDni);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegistrarPagoMembresia";
            Text = "RegistrarPagoMembresia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxDni;
        private Label label4;
        private ComboBox comboBoxMembresias;
        private TextBox textBoxPrecio;
        private TextBox textBoxPorcentaje;
        private Button button1;
    }
}