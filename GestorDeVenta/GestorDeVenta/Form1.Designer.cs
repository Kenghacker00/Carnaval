namespace GestorDeVenta
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelLogin = new Panel();
            txtEmail = new TextBox();
            btnRegistrar = new Button();
            btnIniciar = new Button();
            txtContra = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelLogin
            // 
            panelLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelLogin.BackgroundImage = (Image)resources.GetObject("panelLogin.BackgroundImage");
            panelLogin.BorderStyle = BorderStyle.FixedSingle;
            panelLogin.Controls.Add(pictureBox1);
            panelLogin.Controls.Add(txtEmail);
            panelLogin.Controls.Add(btnRegistrar);
            panelLogin.Controls.Add(btnIniciar);
            panelLogin.Controls.Add(txtContra);
            panelLogin.Controls.Add(label3);
            panelLogin.Controls.Add(label2);
            panelLogin.Controls.Add(label1);
            panelLogin.Location = new Point(26, 25);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(906, 570);
            panelLogin.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.AccessibleName = "";
            txtEmail.Location = new Point(354, 268);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "E-mail";
            txtEmail.Size = new Size(189, 27);
            txtEmail.TabIndex = 7;
            txtEmail.Tag = "";
            txtEmail.Leave += txtEmail_Leave;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Bahnschrift", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrar.Location = new Point(451, 383);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(146, 39);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "Registrarse";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnIniciar
            // 
            btnIniciar.Font = new Font("Bahnschrift", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIniciar.Location = new Point(293, 383);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(127, 39);
            btnIniciar.TabIndex = 5;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // txtContra
            // 
            txtContra.Location = new Point(354, 316);
            txtContra.Name = "txtContra";
            txtContra.PlaceholderText = "Contraseña";
            txtContra.Size = new Size(189, 27);
            txtContra.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Bahnschrift SemiBold Condensed", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(365, 58);
            label3.Name = "label3";
            label3.Size = new Size(157, 41);
            label3.TabIndex = 2;
            label3.Text = "BIENVENIDO !";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Bahnschrift SemiBold Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(365, 40);
            label2.Name = "label2";
            label2.Size = new Size(139, 36);
            label2.TabIndex = 1;
            label2.Text = "BIENVENIDO !";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bahnschrift SemiBold Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(365, 76);
            label1.Name = "label1";
            label1.Size = new Size(139, 36);
            label1.TabIndex = 0;
            label1.Text = "BIENVENIDO !";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(354, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(184, 146);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Teal;
            ClientSize = new Size(961, 626);
            Controls.Add(panelLogin);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "INICIO";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLogin;
        private Label label1;
        private Label label3;
        private Label label2;
        private Button btnRegistrar;
        private Button btnIniciar;
        private TextBox txtContra;
        private TextBox txtEmail;
        private PictureBox pictureBox1;
    }
}
