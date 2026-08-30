namespace Aiub_Lost___Found_Management_System
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            label2 = new Label();
            username = new TextBox();
            label3 = new Label();
            password = new TextBox();
            label4 = new Label();
            label5 = new Label();
            lnkforgotpass = new LinkLabel();
            lnkcreateaccount = new LinkLabel();
            btnLogin = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Lavender;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(144, 21);
            label1.Name = "label1";
            label1.Size = new Size(557, 35);
            label1.TabIndex = 0;
            label1.Text = "AIUB LOST && FOUND MANAGEMENT SYSTEM";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.Location = new Point(7, 79);
            label2.Name = "label2";
            label2.Size = new Size(111, 25);
            label2.TabIndex = 1;
            label2.Text = "Username :";
            label2.Click += label2_Click;
            // 
            // username
            // 
            username.BackColor = SystemColors.Info;
            username.BorderStyle = BorderStyle.FixedSingle;
            username.Location = new Point(120, 79);
            username.Name = "username";
            username.Size = new Size(191, 27);
            username.TabIndex = 2;
            username.TextChanged += username_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.Location = new Point(11, 136);
            label3.Name = "label3";
            label3.Size = new Size(107, 25);
            label3.TabIndex = 3;
            label3.Text = "Password :";
            // 
            // password
            // 
            password.BackColor = SystemColors.Info;
            password.BorderStyle = BorderStyle.FixedSingle;
            password.Location = new Point(120, 138);
            password.Name = "password";
            password.Size = new Size(191, 27);
            password.TabIndex = 4;
            password.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(86, 8);
            label4.Name = "label4";
            label4.Size = new Size(170, 30);
            label4.TabIndex = 5;
            label4.Text = "Welcome Back!";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label5.Location = new Point(75, 38);
            label5.Name = "label5";
            label5.Size = new Size(190, 20);
            label5.TabIndex = 6;
            label5.Text = "Please login to your account";
            label5.Click += label5_Click;
            // 
            // lnkforgotpass
            // 
            lnkforgotpass.AutoSize = true;
            lnkforgotpass.LinkColor = Color.Red;
            lnkforgotpass.Location = new Point(186, 181);
            lnkforgotpass.Name = "lnkforgotpass";
            lnkforgotpass.Size = new Size(125, 20);
            lnkforgotpass.TabIndex = 8;
            lnkforgotpass.TabStop = true;
            lnkforgotpass.Text = "Forgot Password?";
            lnkforgotpass.LinkClicked += lnkforgotpass_LinkClicked;
            // 
            // lnkcreateaccount
            // 
            lnkcreateaccount.AutoSize = true;
            lnkcreateaccount.Font = new Font("Segoe UI", 9F);
            lnkcreateaccount.Location = new Point(32, 224);
            lnkcreateaccount.Name = "lnkcreateaccount";
            lnkcreateaccount.Size = new Size(266, 20);
            lnkcreateaccount.TabIndex = 9;
            lnkcreateaccount.TabStop = true;
            lnkcreateaccount.Text = "Don't have an account? Create account";
            lnkcreateaccount.LinkClicked += lnkcreateaccount_LinkClicked;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ButtonFace;
            btnLogin.BackgroundImageLayout = ImageLayout.Center;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLogin.Location = new Point(86, 271);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(129, 52);
            btnLogin.TabIndex = 10;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.GradientInactiveCaption;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(779, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Menu;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lnkcreateaccount);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(lnkforgotpass);
            panel1.Controls.Add(username);
            panel1.Controls.Add(password);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(403, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(365, 341);
            panel1.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(780, 450);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 9F);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox username;
        private Label label3;
        private TextBox password;
        private Label label4;
        private Label label5;
        private LinkLabel lnkforgotpass;
        private LinkLabel lnkcreateaccount;
        private Button btnLogin;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}
