namespace LOGIN____REGISTER
{
    partial class LOGIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGIN));
            BotonIniciarSesion = new Button();
            textLogin = new TextBox();
            textPassword = new TextBox();
            panel1 = new Panel();
            BotonRegister = new Button();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BotonIniciarSesion
            // 
            BotonIniciarSesion.Anchor = AnchorStyles.Bottom;
            BotonIniciarSesion.BackColor = Color.Orange;
            BotonIniciarSesion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BotonIniciarSesion.ForeColor = Color.White;
            BotonIniciarSesion.Location = new Point(203, 260);
            BotonIniciarSesion.Name = "BotonIniciarSesion";
            BotonIniciarSesion.Size = new Size(133, 37);
            BotonIniciarSesion.TabIndex = 0;
            BotonIniciarSesion.Text = "Iniciar Sesion";
            BotonIniciarSesion.UseVisualStyleBackColor = false;
            BotonIniciarSesion.Click += BotonIniciarSesion_Click;
            // 
            // textLogin
            // 
            textLogin.Anchor = AnchorStyles.Top;
            textLogin.BorderStyle = BorderStyle.FixedSingle;
            textLogin.Location = new Point(123, 153);
            textLogin.Name = "textLogin";
            textLogin.RightToLeft = RightToLeft.No;
            textLogin.Size = new Size(154, 23);
            textLogin.TabIndex = 2;
            textLogin.TextChanged += textLogin_TextChanged;
            // 
            // textPassword
            // 
            textPassword.Anchor = AnchorStyles.Top;
            textPassword.BorderStyle = BorderStyle.FixedSingle;
            textPassword.Location = new Point(123, 197);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(154, 23);
            textPassword.TabIndex = 3;
            textPassword.TextChanged += textPassword_TextChanged;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(BotonRegister);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(textPassword);
            panel1.Controls.Add(textLogin);
            panel1.Controls.Add(BotonIniciarSesion);
            panel1.Location = new Point(91, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(370, 323);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // BotonRegister
            // 
            BotonRegister.Anchor = AnchorStyles.Bottom;
            BotonRegister.BackColor = Color.Orange;
            BotonRegister.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BotonRegister.ForeColor = Color.White;
            BotonRegister.Location = new Point(54, 260);
            BotonRegister.Name = "BotonRegister";
            BotonRegister.Size = new Size(102, 37);
            BotonRegister.TabIndex = 7;
            BotonRegister.Text = "Registrarse";
            BotonRegister.UseVisualStyleBackColor = false;
            BotonRegister.Click += BotonRegister_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(135, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(120, 123);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(100, 197);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(23, 23);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(100, 153);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(23, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // LOGIN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(571, 354);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "LOGIN";
            Text = "LOGIN ";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BotonIniciarSesion;
        private TextBox textLogin;
        private TextBox textPassword;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button BotonRegister;
    }
}
