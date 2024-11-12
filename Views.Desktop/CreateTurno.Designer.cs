namespace Views.Desktop
{
    partial class CreateTurno
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
            boxEspecialidades = new ComboBox();
            btnBuscar = new Button();
            dgvTurnos = new DataGridView();
            calendar = new MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)dgvTurnos).BeginInit();
            SuspendLayout();
            // 
            // boxEspecialidades
            // 
            boxEspecialidades.FormattingEnabled = true;
            boxEspecialidades.Location = new Point(54, 56);
            boxEspecialidades.Name = "boxEspecialidades";
            boxEspecialidades.Size = new Size(151, 28);
            boxEspecialidades.TabIndex = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(239, 56);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgvTurnos
            // 
            dgvTurnos.AllowUserToDeleteRows = false;
            dgvTurnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTurnos.Location = new Point(381, 134);
            dgvTurnos.Name = "dgvTurnos";
            dgvTurnos.ReadOnly = true;
            dgvTurnos.RowHeadersWidth = 51;
            dgvTurnos.Size = new Size(347, 207);
            dgvTurnos.TabIndex = 2;
            dgvTurnos.DoubleClick += dgvTurnos_DoubleClick;
            // 
            // calendar
            // 
            calendar.Location = new Point(54, 134);
            calendar.Name = "calendar";
            calendar.TabIndex = 3;
            // 
            // CreateTurno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(calendar);
            Controls.Add(dgvTurnos);
            Controls.Add(btnBuscar);
            Controls.Add(boxEspecialidades);
            Name = "CreateTurno";
            Text = "CreateTurno";
            Load += CreateTurno_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTurnos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox boxEspecialidades;
        private Button btnBuscar;
        private DataGridView dgvTurnos;
        private MonthCalendar calendar;
    }
}