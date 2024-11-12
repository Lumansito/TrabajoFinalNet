namespace Views.Desktop
{
    partial class CrudJornadas
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
            label4 = new Label();
            textBoxId = new TextBox();
            cbNombreDia = new ComboBox();
            dtpHoraInicio = new DateTimePicker();
            dtpHoraFin = new DateTimePicker();
            dataGridViewJornadas = new DataGridView();
            JornadaId = new DataGridViewTextBoxColumn();
            NombreDia = new DataGridViewTextBoxColumn();
            HoraInicio = new DataGridViewTextBoxColumn();
            HoraFin = new DataGridViewTextBoxColumn();
            buttonRG = new Button();
            buttonEliminar = new Button();
            buttonRestablecer = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewJornadas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 121);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(98, 162);
            label2.Name = "label2";
            label2.Size = new Size(24, 15);
            label2.TabIndex = 1;
            label2.Text = "Dia";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 202);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 2;
            label3.Text = "Hora inicio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(72, 242);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 3;
            label4.Text = "Hora fin";
            // 
            // textBoxId
            // 
            textBoxId.Enabled = false;
            textBoxId.Location = new Point(128, 118);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(121, 23);
            textBoxId.TabIndex = 4;
            // 
            // cbNombreDia
            // 
            cbNombreDia.FormattingEnabled = true;
            cbNombreDia.Items.AddRange(new object[] { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" });
            cbNombreDia.Location = new Point(128, 159);
            cbNombreDia.Name = "cbNombreDia";
            cbNombreDia.Size = new Size(121, 23);
            cbNombreDia.TabIndex = 5;
            // 
            // dtpHoraInicio
            // 
            dtpHoraInicio.CustomFormat = "HH:mm";
            dtpHoraInicio.Format = DateTimePickerFormat.Custom;
            dtpHoraInicio.Location = new Point(128, 196);
            dtpHoraInicio.Name = "dtpHoraInicio";
            dtpHoraInicio.ShowUpDown = true;
            dtpHoraInicio.Size = new Size(121, 23);
            dtpHoraInicio.TabIndex = 6;
            // 
            // dtpHoraFin
            // 
            dtpHoraFin.CustomFormat = "HH:mm";
            dtpHoraFin.Format = DateTimePickerFormat.Custom;
            dtpHoraFin.Location = new Point(128, 236);
            dtpHoraFin.Name = "dtpHoraFin";
            dtpHoraFin.ShowUpDown = true;
            dtpHoraFin.Size = new Size(121, 23);
            dtpHoraFin.TabIndex = 7;
            // 
            // dataGridViewJornadas
            // 
            dataGridViewJornadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewJornadas.Columns.AddRange(new DataGridViewColumn[] { JornadaId, NombreDia, HoraInicio, HoraFin });
            dataGridViewJornadas.Location = new Point(348, 39);
            dataGridViewJornadas.Name = "dataGridViewJornadas";
            dataGridViewJornadas.Size = new Size(443, 399);
            dataGridViewJornadas.TabIndex = 8;
            dataGridViewJornadas.DoubleClick += dataGridViewJornadas_DoubleClick;
            // 
            // JornadaId
            // 
            JornadaId.DataPropertyName = "JornadaId";
            JornadaId.HeaderText = "ID";
            JornadaId.Name = "JornadaId";
            // 
            // NombreDia
            // 
            NombreDia.DataPropertyName = "NombreDia";
            NombreDia.HeaderText = "Dia";
            NombreDia.Name = "NombreDia";
            // 
            // HoraInicio
            // 
            HoraInicio.DataPropertyName = "HoraInicio";
            HoraInicio.HeaderText = "Hora Inicio";
            HoraInicio.Name = "HoraInicio";
            // 
            // HoraFin
            // 
            HoraFin.DataPropertyName = "HoraFin";
            HoraFin.HeaderText = "Hora Fin";
            HoraFin.Name = "HoraFin";
            // 
            // buttonRG
            // 
            buttonRG.Location = new Point(63, 284);
            buttonRG.Name = "buttonRG";
            buttonRG.Size = new Size(90, 30);
            buttonRG.TabIndex = 9;
            buttonRG.Text = "Registrar";
            buttonRG.UseVisualStyleBackColor = true;
            buttonRG.Click += buttonRG_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(159, 284);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(90, 30);
            buttonEliminar.TabIndex = 10;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonRestablecer
            // 
            buttonRestablecer.Location = new Point(63, 320);
            buttonRestablecer.Name = "buttonRestablecer";
            buttonRestablecer.Size = new Size(186, 30);
            buttonRestablecer.TabIndex = 11;
            buttonRestablecer.Text = "Restablecer valores";
            buttonRestablecer.UseVisualStyleBackColor = true;
            buttonRestablecer.Click += buttonRestablecer_Click;
            // 
            // CrudJornadas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonRestablecer);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonRG);
            Controls.Add(dataGridViewJornadas);
            Controls.Add(dtpHoraFin);
            Controls.Add(dtpHoraInicio);
            Controls.Add(cbNombreDia);
            Controls.Add(textBoxId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CrudJornadas";
            Text = "CrudJornadas";
            Load += CrudJornadas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewJornadas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxId;
        private ComboBox cbNombreDia;
        private DateTimePicker dtpHoraInicio;
        private DateTimePicker dtpHoraFin;
        private DataGridView dataGridViewJornadas;
        private Button buttonRG;
        private Button buttonEliminar;
        private DataGridViewTextBoxColumn JornadaId;
        private DataGridViewTextBoxColumn NombreDia;
        private DataGridViewTextBoxColumn HoraInicio;
        private DataGridViewTextBoxColumn HoraFin;
        private Button buttonRestablecer;
    }
}