namespace Views.Desktop
{
    partial class AsignarEspecialidadesUsuario
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
            btnGuardar = new Button();
            btnDesasignar = new Button();
            btnAsignar = new Button();
            label2 = new Label();
            label1 = new Label();
            listBoxAsignadas = new ListBox();
            listBoxEspecialidades = new ListBox();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(688, 367);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(99, 70);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(688, 291);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(99, 70);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar Cambios";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnDesasignar
            // 
            btnDesasignar.Location = new Point(416, 248);
            btnDesasignar.Name = "btnDesasignar";
            btnDesasignar.Size = new Size(152, 66);
            btnDesasignar.TabIndex = 13;
            btnDesasignar.Text = "Desasignar";
            btnDesasignar.UseVisualStyleBackColor = true;
            btnDesasignar.Click += btnDesasignar_Click;
            // 
            // btnAsignar
            // 
            btnAsignar.Location = new Point(96, 248);
            btnAsignar.Name = "btnAsignar";
            btnAsignar.Size = new Size(152, 66);
            btnAsignar.TabIndex = 12;
            btnAsignar.Text = "Asignar";
            btnAsignar.UseVisualStyleBackColor = true;
            btnAsignar.Click += btnAsignar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 34);
            label2.Name = "label2";
            label2.Size = new Size(190, 20);
            label2.TabIndex = 11;
            label2.Text = "Especialidades disponibles:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(489, 34);
            label1.Name = "label1";
            label1.Size = new Size(214, 20);
            label1.TabIndex = 10;
            label1.Text = "Especialidades del profesional:";
            // 
            // listBoxAsignadas
            // 
            listBoxAsignadas.FormattingEnabled = true;
            listBoxAsignadas.Location = new Point(416, 78);
            listBoxAsignadas.Name = "listBoxAsignadas";
            listBoxAsignadas.Size = new Size(247, 164);
            listBoxAsignadas.TabIndex = 9;
            // 
            // listBoxEspecialidades
            // 
            listBoxEspecialidades.FormattingEnabled = true;
            listBoxEspecialidades.Location = new Point(96, 78);
            listBoxEspecialidades.Name = "listBoxEspecialidades";
            listBoxEspecialidades.Size = new Size(247, 164);
            listBoxEspecialidades.TabIndex = 8;
            // 
            // AsignarEspecialidadesUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(btnDesasignar);
            Controls.Add(btnAsignar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBoxAsignadas);
            Controls.Add(listBoxEspecialidades);
            Name = "AsignarEspecialidadesUsuario";
            Text = "AsignarEspecialidadesUsuario";
            FormClosing += AsignarEspecialidadesUsuario_FormClosing;
            FormClosed += AsignarEspecialidadesUsuario_FormClosed;
            Load += AsignarEspecialidadesUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnGuardar;
        private Button btnDesasignar;
        private Button btnAsignar;
        private Label label2;
        private Label label1;
        private ListBox listBoxAsignadas;
        private ListBox listBoxEspecialidades;
    }
}