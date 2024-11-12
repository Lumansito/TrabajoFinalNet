namespace Views.Desktop
{
    partial class CrudMascotas
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
            textBoxNombre = new TextBox();
            label2 = new Label();
            dateTimePickerFechaNacimiento = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            comboBoxRazas = new ComboBox();
            comboBoxEspecies = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(276, 107);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(336, 104);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(214, 23);
            textBoxNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(210, 156);
            label2.Name = "label2";
            label2.Size = new Size(120, 15);
            label2.TabIndex = 2;
            label2.Text = "Fecha de nacimiento:";
            // 
            // dateTimePickerFechaNacimiento
            // 
            dateTimePickerFechaNacimiento.CustomFormat = "yyyy-MM-dd";
            dateTimePickerFechaNacimiento.Location = new Point(336, 150);
            dateTimePickerFechaNacimiento.Name = "dateTimePickerFechaNacimiento";
            dateTimePickerFechaNacimiento.Size = new Size(214, 23);
            dateTimePickerFechaNacimiento.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(296, 207);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 4;
            label3.Text = "Raza:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(281, 271);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 6;
            label4.Text = "Especie:";
            // 
            // comboBoxRazas
            // 
            comboBoxRazas.FormattingEnabled = true;
            comboBoxRazas.Location = new Point(336, 204);
            comboBoxRazas.Name = "comboBoxRazas";
            comboBoxRazas.Size = new Size(214, 23);
            comboBoxRazas.TabIndex = 8;
            // 
            // comboBoxEspecies
            // 
            comboBoxEspecies.FormattingEnabled = true;
            comboBoxEspecies.Location = new Point(336, 268);
            comboBoxEspecies.Name = "comboBoxEspecies";
            comboBoxEspecies.Size = new Size(214, 23);
            comboBoxEspecies.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(336, 317);
            button1.Name = "button1";
            button1.Size = new Size(214, 39);
            button1.TabIndex = 10;
            button1.Text = "Actualizar información";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CrudMascotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(comboBoxEspecies);
            Controls.Add(comboBoxRazas);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dateTimePickerFechaNacimiento);
            Controls.Add(label2);
            Controls.Add(textBoxNombre);
            Controls.Add(label1);
            Name = "CrudMascotas";
            Text = "CrudMascotas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxNombre;
        private Label label2;
        private DateTimePicker dateTimePickerFechaNacimiento;
        private Label label3;
        private Label label4;
        private ComboBox comboBoxRazas;
        private ComboBox comboBoxEspecies;
        private Button button1;
    }
}