namespace Views.Desktop
{
    partial class AsignarJornadasUsuario
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
            listBoxJornadas = new ListBox();
            listBoxAsignadas = new ListBox();
            label1 = new Label();
            label2 = new Label();
            btnAsignar = new Button();
            btnDesasignar = new Button();
            btnGuardar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // listBoxJornadas
            // 
            listBoxJornadas.FormattingEnabled = true;
            listBoxJornadas.Location = new Point(81, 80);
            listBoxJornadas.Name = "listBoxJornadas";
            listBoxJornadas.Size = new Size(247, 164);
            listBoxJornadas.TabIndex = 0;
            // 
            // listBoxAsignadas
            // 
            listBoxAsignadas.FormattingEnabled = true;
            listBoxAsignadas.Location = new Point(401, 80);
            listBoxAsignadas.Name = "listBoxAsignadas";
            listBoxAsignadas.Size = new Size(247, 164);
            listBoxAsignadas.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(474, 36);
            label1.Name = "label1";
            label1.Size = new Size(174, 20);
            label1.TabIndex = 2;
            label1.Text = "Jornadas del profesional:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 36);
            label2.Name = "label2";
            label2.Size = new Size(150, 20);
            label2.TabIndex = 3;
            label2.Text = "Jornadas disponibles:";
            // 
            // btnAsignar
            // 
            btnAsignar.Location = new Point(81, 250);
            btnAsignar.Name = "btnAsignar";
            btnAsignar.Size = new Size(152, 66);
            btnAsignar.TabIndex = 4;
            btnAsignar.Text = "Asignar";
            btnAsignar.UseVisualStyleBackColor = true;
            btnAsignar.Click += btnAsignar_Click;
            // 
            // btnDesasignar
            // 
            btnDesasignar.Location = new Point(401, 250);
            btnDesasignar.Name = "btnDesasignar";
            btnDesasignar.Size = new Size(152, 66);
            btnDesasignar.TabIndex = 5;
            btnDesasignar.Text = "Desasignar";
            btnDesasignar.UseVisualStyleBackColor = true;
            btnDesasignar.Click += btnDesasignar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(673, 293);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(99, 70);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar Cambios";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(673, 369);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(99, 70);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // AsignarJornadasUsuario
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
            Controls.Add(listBoxJornadas);
            Name = "AsignarJornadasUsuario";
            Text = "AsignarJornadasUsuario";
            FormClosing += AsignarJornadasUsuario_FormClosing;
            FormClosed += AsignarJornadasUsuario_FormClosed;
            Load += AsignarJornadasUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxJornadas;
        private ListBox listBoxAsignadas;
        private Label label1;
        private Label label2;
        private Button btnAsignar;
        private Button btnDesasignar;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}