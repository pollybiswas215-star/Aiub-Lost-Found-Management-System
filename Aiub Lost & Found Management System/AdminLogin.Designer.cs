namespace Aiub_Lost___Found_Management_System
{
    partial class adminlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminlogin));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            adminuser = new TextBox();
            adminpass = new TextBox();
            adminlog = new Button();
            adminlogout = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(267, 17);
            label1.Name = "label1";
            label1.Size = new Size(313, 37);
            label1.TabIndex = 0;
            label1.Text = "Authority admin access";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label2.Location = new Point(198, 108);
            label2.Name = "label2";
            label2.Size = new Size(129, 30);
            label2.TabIndex = 1;
            label2.Text = "Username :";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label3.Location = new Point(198, 179);
            label3.Name = "label3";
            label3.Size = new Size(124, 30);
            label3.TabIndex = 2;
            label3.Text = "Password :";
            // 
            // adminuser
            // 
            adminuser.BorderStyle = BorderStyle.FixedSingle;
            adminuser.Location = new Point(346, 113);
            adminuser.Name = "adminuser";
            adminuser.Size = new Size(316, 27);
            adminuser.TabIndex = 3;
            // 
            // adminpass
            // 
            adminpass.BorderStyle = BorderStyle.FixedSingle;
            adminpass.Location = new Point(346, 179);
            adminpass.Name = "adminpass";
            adminpass.Size = new Size(316, 27);
            adminpass.TabIndex = 4;
            // 
            // adminlog
            // 
            adminlog.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            adminlog.Location = new Point(376, 285);
            adminlog.Name = "adminlog";
            adminlog.Size = new Size(94, 57);
            adminlog.TabIndex = 5;
            adminlog.Text = "Login";
            adminlog.UseVisualStyleBackColor = true;
            adminlog.Click += button1_Click;
            // 
            // adminlogout
            // 
            adminlogout.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            adminlogout.Location = new Point(471, 250);
            adminlogout.Name = "adminlogout";
            adminlogout.Size = new Size(94, 57);
            adminlogout.TabIndex = 6;
            adminlogout.Text = "Logout";
            adminlogout.UseVisualStyleBackColor = true;
            adminlogout.Click += adminlogout_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(682, 356);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(adminlogout);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox4);
            panel1.Location = new Point(46, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(682, 356);
            panel1.TabIndex = 8;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(-44, -37);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(774, 440);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(-320, -83);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1025, 390);
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(-44, -37);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(800, 453);
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // adminlogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(adminlog);
            Controls.Add(adminpass);
            Controls.Add(adminuser);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            ImeMode = ImeMode.On;
            Name = "adminlogin";
            Text = "adminlogin";
            Load += adminlogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox adminuser;
        private TextBox adminpass;
        private Button adminlog;
        private Button adminlogout;
        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}