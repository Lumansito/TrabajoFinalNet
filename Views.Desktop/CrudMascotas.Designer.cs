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
            buttonAgregar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(315, 143);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(384, 139);
            textBoxNombre.Margin = new Padding(3, 4, 3, 4);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(244, 27);
            textBoxNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(240, 208);
            label2.Name = "label2";
            label2.Size = new Size(149, 20);
            label2.TabIndex = 2;
            label2.Text = "Fecha de nacimiento:";
            // 
            // dateTimePickerFechaNacimiento
            // 
            dateTimePickerFechaNacimiento.CustomFormat = "yyyy-MM-dd";
            dateTimePickerFechaNacimiento.Location = new Point(384, 200);
            dateTimePickerFechaNacimiento.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerFechaNacimiento.Name = "dateTimePickerFechaNacimiento";
            dateTimePickerFechaNacimiento.Size = new Size(244, 27);
            dateTimePickerFechaNacimiento.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(338, 276);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 4;
            label3.Text = "Raza:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(321, 361);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 6;
            label4.Text = "Especie:";
            // 
            // comboBoxRazas
            // 
            comboBoxRazas.FormattingEnabled = true;
            comboBoxRazas.Location = new Point(384, 272);
            comboBoxRazas.Margin = new Padding(3, 4, 3, 4);
            comboBoxRazas.Name = "comboBoxRazas";
            comboBoxRazas.Size = new Size(244, 28);
            comboBoxRazas.TabIndex = 8;
            // 
            // comboBoxEspecies
            // 
            comboBoxEspecies.FormattingEnabled = true;
            comboBoxEspecies.Location = new Point(384, 357);
            comboBoxEspecies.Margin = new Padding(3, 4, 3, 4);
            comboBoxEspecies.Name = "comboBoxEspecies";
            comboBoxEspecies.Size = new Size(244, 28);
            comboBoxEspecies.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(384, 423);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(245, 52);
            button1.TabIndex = 10;
            button1.Text = "Actualizar información";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonAgregar
            // 
            buttonAgregar.Location = new Point(384, 517);
            buttonAgregar.Margin = new Padding(3, 4, 3, 4);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(245, 57);
            buttonAgregar.TabIndex = 11;
            buttonAgregar.Text = "Agregar nueva mascota";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // CrudMascotas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(buttonAgregar);
            Controls.Add(button1);
            Controls.Add(comboBoxEspecies);
            Controls.Add(comboBoxRazas);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dateTimePickerFechaNacimiento);
            Controls.Add(label2);
            Controls.Add(textBoxNombre);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CrudMascotas";
            Text = "CrudMascotas";
            FormClosing += CrudMascotas_FormClosing;
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
        private Button buttonAgregar;
    }
}