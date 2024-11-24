namespace Views.Desktop
{
    partial class LogIn
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
            btnLogIn = new Button();
            label1 = new Label();
            label2 = new Label();
            txtBoxDni = new TextBox();
            txtBoxPassword = new TextBox();
            SuspendLayout();
            // 
            // btnLogIn
            // 
            btnLogIn.Location = new Point(175, 269);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(394, 99);
            btnLogIn.TabIndex = 0;
            btnLogIn.Text = "Ingresar";
            btnLogIn.UseVisualStyleBackColor = true;
            btnLogIn.Click += btnIngreso_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(140, 86);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 1;
            label1.Text = "Dni:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(140, 146);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 2;
            label2.Text = "Contraseña:";
            // 
            // txtBoxDni
            // 
            txtBoxDni.Location = new Point(343, 83);
            txtBoxDni.Name = "txtBoxDni";
            txtBoxDni.Size = new Size(226, 27);
            txtBoxDni.TabIndex = 3;
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.Location = new Point(343, 146);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.Size = new Size(226, 27);
            txtBoxPassword.TabIndex = 4;
            txtBoxPassword.UseSystemPasswordChar = true;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtBoxPassword);
            Controls.Add(txtBoxDni);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogIn);
            Name = "LogIn";
            Text = "LogIn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogIn;
        private Label label1;
        private Label label2;
        private TextBox txtBoxDni;
        private TextBox txtBoxPassword;
    }
}