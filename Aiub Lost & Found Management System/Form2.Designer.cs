namespace Aiub_Lost___Found_Management_System
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            label1 = new Label();
            createaccount = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            fullname = new TextBox();
            label2 = new Label();
            username = new TextBox();
            txtemail = new TextBox();
            txtpassword = new TextBox();
            conpass = new TextBox();
            btnregister = new Button();
            clr = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(363, 36);
            label1.Name = "label1";
            label1.Size = new Size(0, 37);
            label1.TabIndex = 0;
            // 
            // createaccount
            // 
            createaccount.AutoSize = true;
            createaccount.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            createaccount.ForeColor = Color.FromArgb(0, 0, 192);
            createaccount.Location = new Point(306, 9);
            createaccount.Name = "createaccount";
            createaccount.Size = new Size(213, 37);
            createaccount.TabIndex = 1;
            createaccount.Text = "Create Account";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.Location = new Point(22, 83);
            label3.Name = "label3";
            label3.Size = new Size(111, 25);
            label3.TabIndex = 2;
            label3.Text = "Full Name :";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(165, 176);
            label4.Name = "label4";
            label4.Size = new Size(0, 25);
            label4.TabIndex = 3;
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.Location = new Point(22, 148);
            label5.Name = "label5";
            label5.Size = new Size(111, 25);
            label5.TabIndex = 4;
            label5.Text = "Username :";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label6.Location = new Point(64, 198);
            label6.Name = "label6";
            label6.Size = new Size(69, 25);
            label6.TabIndex = 5;
            label6.Text = "Email :";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label7.ForeColor = Color.DodgerBlue;
            label7.Location = new Point(26, 257);
            label7.Name = "label7";
            label7.Size = new Size(107, 25);
            label7.TabIndex = 6;
            label7.Text = "Password :";
            // 
            // fullname
            // 
            fullname.BackColor = Color.White;
            fullname.BorderStyle = BorderStyle.FixedSingle;
            fullname.Location = new Point(185, 83);
            fullname.Name = "fullname";
            fullname.Size = new Size(384, 27);
            fullname.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.Location = new Point(2, 328);
            label2.Name = "label2";
            label2.Size = new Size(185, 25);
            label2.TabIndex = 8;
            label2.Text = "Confirm Password :";
            label2.Click += label2_Click;
            // 
            // username
            // 
            username.BackColor = SystemColors.Window;
            username.BorderStyle = BorderStyle.FixedSingle;
            username.Location = new Point(194, 150);
            username.Name = "username";
            username.Size = new Size(375, 27);
            username.TabIndex = 9;
            // 
            // txtemail
            // 
            txtemail.BackColor = Color.White;
            txtemail.BorderStyle = BorderStyle.FixedSingle;
            txtemail.Location = new Point(185, 200);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(384, 27);
            txtemail.TabIndex = 10;
            // 
            // txtpassword
            // 
            txtpassword.BorderStyle = BorderStyle.FixedSingle;
            txtpassword.Location = new Point(185, 258);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(384, 27);
            txtpassword.TabIndex = 11;
            txtpassword.UseSystemPasswordChar = true;
            // 
            // conpass
            // 
            conpass.BorderStyle = BorderStyle.FixedSingle;
            conpass.Location = new Point(185, 326);
            conpass.Name = "conpass";
            conpass.Size = new Size(384, 27);
            conpass.TabIndex = 12;
            conpass.UseSystemPasswordChar = true;
            conpass.TextChanged += textBox1_TextChanged;
            // 
            // btnregister
            // 
            btnregister.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnregister.ForeColor = Color.Red;
            btnregister.Location = new Point(238, 366);
            btnregister.Name = "btnregister";
            btnregister.Size = new Size(94, 57);
            btnregister.TabIndex = 13;
            btnregister.Text = "Register\r\n";
            btnregister.UseVisualStyleBackColor = true;
            btnregister.Click += button1_Click;
            // 
            // clr
            // 
            clr.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            clr.Location = new Point(349, 366);
            clr.Name = "clr";
            clr.Size = new Size(94, 57);
            clr.TabIndex = 14;
            clr.Text = "Clear";
            clr.UseVisualStyleBackColor = true;
            clr.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(794, 426);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button1.Location = new Point(449, 366);
            button1.Name = "button1";
            button1.Size = new Size(99, 58);
            button1.TabIndex = 16;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(clr);
            Controls.Add(btnregister);
            Controls.Add(conpass);
            Controls.Add(txtpassword);
            Controls.Add(txtemail);
            Controls.Add(username);
            Controls.Add(label2);
            Controls.Add(fullname);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(createaccount);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "RegisterForm";
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label createaccount;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox fullname;
        private Label label2;
        private TextBox username;
        private TextBox txtemail;
        private TextBox txtpassword;
        private TextBox conpass;
        private Button btnregister;
        private Button clr;
        private PictureBox pictureBox1;
        private Button button1;
    }
}