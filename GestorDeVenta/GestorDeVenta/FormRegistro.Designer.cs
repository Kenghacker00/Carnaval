namespace GestorDeVenta
{
    partial class FormRegistro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistro));
            panelRegistro = new Panel();
            pictureBox1 = new PictureBox();
            txtEdad = new TextBox();
            txtEmail = new TextBox();
            label3 = new Label();
            btnRegistrar = new Button();
            txtConfirmarContra = new TextBox();
            txtContra = new TextBox();
            txtUsuario = new TextBox();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panelRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelRegistro
            // 
            panelRegistro.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelRegistro.BackColor = Color.MediumTurquoise;
            panelRegistro.BorderStyle = BorderStyle.FixedSingle;
            panelRegistro.Controls.Add(pictureBox1);
            panelRegistro.Controls.Add(txtEdad);
            panelRegistro.Controls.Add(txtEmail);
            panelRegistro.Controls.Add(label3);
            panelRegistro.Controls.Add(btnRegistrar);
            panelRegistro.Controls.Add(txtConfirmarContra);
            panelRegistro.Controls.Add(txtContra);
            panelRegistro.Controls.Add(txtUsuario);
            panelRegistro.Controls.Add(label1);
            panelRegistro.Location = new Point(32, 23);
            panelRegistro.Name = "panelRegistro";
            panelRegistro.Size = new Size(907, 573);
            panelRegistro.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(354, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(184, 146);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // txtEdad
            // 
            txtEdad.AccessibleName = "";
            txtEdad.Location = new Point(354, 238);
            txtEdad.Name = "txtEdad";
            txtEdad.PlaceholderText = "Edad";
            txtEdad.Size = new Size(189, 27);
            txtEdad.TabIndex = 9;
            txtEdad.Tag = "";
            // 
            // txtEmail
            // 
            txtEmail.AccessibleName = "";
            txtEmail.Location = new Point(354, 283);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(189, 27);
            txtEmail.TabIndex = 8;
            txtEmail.Tag = "";
            txtEmail.Leave += txtEmail_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Bahnschrift SemiBold Condensed", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(362, 103);
            label3.Name = "label3";
            label3.Size = new Size(157, 41);
            label3.TabIndex = 7;
            label3.Text = "BIENVENIDO !";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Bahnschrift", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrar.Location = new Point(373, 423);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(146, 39);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "Registrarse";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtConfirmarContra
            // 
            txtConfirmarContra.Location = new Point(354, 375);
            txtConfirmarContra.Name = "txtConfirmarContra";
            txtConfirmarContra.PlaceholderText = "Confirmar Contraseña";
            txtConfirmarContra.Size = new Size(189, 27);
            txtConfirmarContra.TabIndex = 5;
            txtConfirmarContra.UseSystemPasswordChar = true;
            // 
            // txtContra
            // 
            txtContra.Location = new Point(354, 330);
            txtContra.Name = "txtContra";
            txtContra.PlaceholderText = "Contraseña";
            txtContra.Size = new Size(189, 27);
            txtContra.TabIndex = 4;
            txtContra.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            txtUsuario.AccessibleName = "";
            txtUsuario.Location = new Point(354, 192);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Nombre";
            txtUsuario.Size = new Size(189, 27);
            txtUsuario.TabIndex = 3;
            txtUsuario.Tag = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bahnschrift SemiBold Condensed", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(382, 144);
            label1.Name = "label1";
            label1.Size = new Size(124, 41);
            label1.TabIndex = 2;
            label1.Text = "REGISTRO";
            // 
            // FormRegistro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Teal;
            ClientSize = new Size(961, 626);
            Controls.Add(panelRegistro);
            Name = "FormRegistro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "REGISTRO";
            WindowState = FormWindowState.Maximized;
            panelRegistro.ResumeLayout(false);
            panelRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelRegistro;
        private Label label1;
        private TextBox txtUsuario;
        private Button btnRegistrar;
        private TextBox txtContra;
        private TextBox txtConfirmarContra;
        private Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox txtEmail;
        private TextBox txtEdad;
        private PictureBox pictureBox1;
    }
}