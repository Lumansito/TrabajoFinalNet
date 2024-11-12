namespace Views.Desktop
{
    partial class AsignarEspecialidadesServicio
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
            lbNoAsignadas = new ListBox();
            lbAsignadas = new ListBox();
            buttonAsignar = new Button();
            buttonQuitar = new Button();
            label1 = new Label();
            label2 = new Label();
            buttonGuardar = new Button();
            buttonCancelar = new Button();
            SuspendLayout();
            // 
            // lbNoAsignadas
            // 
            lbNoAsignadas.FormattingEnabled = true;
            lbNoAsignadas.ItemHeight = 15;
            lbNoAsignadas.Location = new Point(108, 60);
            lbNoAsignadas.Name = "lbNoAsignadas";
            lbNoAsignadas.Size = new Size(218, 199);
            lbNoAsignadas.TabIndex = 0;
            // 
            // lbAsignadas
            // 
            lbAsignadas.FormattingEnabled = true;
            lbAsignadas.ItemHeight = 15;
            lbAsignadas.Location = new Point(470, 60);
            lbAsignadas.Name = "lbAsignadas";
            lbAsignadas.Size = new Size(218, 199);
            lbAsignadas.TabIndex = 1;
            // 
            // buttonAsignar
            // 
            buttonAsignar.Location = new Point(108, 265);
            buttonAsignar.Name = "buttonAsignar";
            buttonAsignar.Size = new Size(75, 30);
            buttonAsignar.TabIndex = 2;
            buttonAsignar.Text = "Asignar";
            buttonAsignar.UseVisualStyleBackColor = true;
            buttonAsignar.Click += buttonAsignar_Click;
            // 
            // buttonQuitar
            // 
            buttonQuitar.Location = new Point(613, 265);
            buttonQuitar.Name = "buttonQuitar";
            buttonQuitar.Size = new Size(75, 30);
            buttonQuitar.TabIndex = 3;
            buttonQuitar.Text = "Quitar";
            buttonQuitar.UseVisualStyleBackColor = true;
            buttonQuitar.Click += buttonQuitar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 42);
            label1.Name = "label1";
            label1.Size = new Size(146, 15);
            label1.TabIndex = 4;
            label1.Text = "Especialidades disponibles";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(446, 42);
            label2.Name = "label2";
            label2.Size = new Size(145, 15);
            label2.TabIndex = 5;
            label2.Text = "Especialidades del servicio";
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(332, 340);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(132, 30);
            buttonGuardar.TabIndex = 6;
            buttonGuardar.Text = "Guardar cambios";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(332, 376);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(132, 30);
            buttonCancelar.TabIndex = 7;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // AsignarEspecialidadesServicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonGuardar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonQuitar);
            Controls.Add(buttonAsignar);
            Controls.Add(lbAsignadas);
            Controls.Add(lbNoAsignadas);
            Name = "AsignarEspecialidadesServicio";
            Text = "AsignarEspecialidadesServicio";
            FormClosing += AsignarEspecialidadesServicio_FormClosing;
            FormClosed += AsignarEspecialidadesServicio_FormClosed;
            Load += AsignarEspecialidadesServicio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbNoAsignadas;
        private ListBox lbAsignadas;
        private Button buttonAsignar;
        private Button buttonQuitar;
        private Label label1;
        private Label label2;
        private Button buttonGuardar;
        private Button buttonCancelar;
    }
}