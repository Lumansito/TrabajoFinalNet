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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBoxMembresias = new ComboBox();
            textBoxPrecio = new TextBox();
            textBoxPorcentaje = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(184, 181);
            label2.Name = "label2";
            label2.Size = new Size(182, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre de la membresia:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(197, 233);
            label3.Name = "label3";
            label3.Size = new Size(168, 20);
            label3.TabIndex = 2;
            label3.Text = "Precio de la membresia:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(189, 287);
            label4.Name = "label4";
            label4.Size = new Size(174, 20);
            label4.TabIndex = 4;
            label4.Text = "Porcentaje de descuento:";
            // 
            // comboBoxMembresias
            // 
            comboBoxMembresias.FormattingEnabled = true;
            comboBoxMembresias.Location = new Point(355, 177);
            comboBoxMembresias.Margin = new Padding(3, 4, 3, 4);
            comboBoxMembresias.Name = "comboBoxMembresias";
            comboBoxMembresias.Size = new Size(188, 28);
            comboBoxMembresias.TabIndex = 5;
            comboBoxMembresias.Text = "Seleccionar membresia ...";
            comboBoxMembresias.SelectedIndexChanged += comboBoxMembresias_SelectedIndexChanged;
            // 
            // textBoxPrecio
            // 
            textBoxPrecio.Enabled = false;
            textBoxPrecio.Location = new Point(355, 229);
            textBoxPrecio.Margin = new Padding(3, 4, 3, 4);
            textBoxPrecio.Name = "textBoxPrecio";
            textBoxPrecio.Size = new Size(188, 27);
            textBoxPrecio.TabIndex = 6;
            // 
            // textBoxPorcentaje
            // 
            textBoxPorcentaje.Enabled = false;
            textBoxPorcentaje.Location = new Point(355, 283);
            textBoxPorcentaje.Margin = new Padding(3, 4, 3, 4);
            textBoxPorcentaje.Name = "textBoxPorcentaje";
            textBoxPorcentaje.Size = new Size(188, 27);
            textBoxPorcentaje.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(355, 339);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(189, 31);
            button1.TabIndex = 8;
            button1.Text = "Registrar pago";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // RegistrarPagoMembresia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(button1);
            Controls.Add(textBoxPorcentaje);
            Controls.Add(textBoxPrecio);
            Controls.Add(comboBoxMembresias);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RegistrarPagoMembresia";
            Text = "RegistrarPagoMembresia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBoxMembresias;
        private TextBox textBoxPrecio;
        private TextBox textBoxPorcentaje;
        private Button button1;
    }
}