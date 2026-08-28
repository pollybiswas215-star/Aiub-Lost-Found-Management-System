namespace Aiub_Lost___Found_Management_System
{
    partial class addfounditem
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
            label5 = new Label();
            label6 = new Label();
            Submitfound = new Button();
            clearfound = new Button();
            itemname = new TextBox();
            email = new TextBox();
            description = new TextBox();
            label7 = new Label();
            category = new ComboBox();
            location = new TextBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            button1 = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 1, true);
            label1.Location = new Point(293, 9);
            label1.Name = "label1";
            label1.Size = new Size(251, 37);
            label1.TabIndex = 0;
            label1.Text = "Report Found Item";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.Location = new Point(71, 72);
            label2.Name = "label2";
            label2.Size = new Size(119, 25);
            label2.TabIndex = 1;
            label2.Text = "Item Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.Location = new Point(86, 119);
            label3.Name = "label3";
            label3.Size = new Size(104, 25);
            label3.TabIndex = 2;
            label3.Text = "Category :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.Location = new Point(79, 204);
            label4.Name = "label4";
            label4.Size = new Size(111, 25);
            label4.TabIndex = 3;
            label4.Text = "Condition :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.Location = new Point(91, 156);
            label5.Name = "label5";
            label5.Size = new Size(99, 25);
            label5.TabIndex = 4;
            label5.Text = "Location :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(121, 263);
            label6.Name = "label6";
            label6.Size = new Size(69, 25);
            label6.TabIndex = 5;
            label6.Text = "Email :";
            // 
            // Submitfound
            // 
            Submitfound.BackColor = Color.RoyalBlue;
            Submitfound.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Submitfound.ForeColor = Color.White;
            Submitfound.Location = new Point(370, 390);
            Submitfound.Name = "Submitfound";
            Submitfound.Size = new Size(94, 48);
            Submitfound.TabIndex = 8;
            Submitfound.Text = "Submit";
            Submitfound.UseVisualStyleBackColor = false;
            Submitfound.Click += button1_Click;
            // 
            // clearfound
            // 
            clearfound.BackColor = Color.Azure;
            clearfound.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            clearfound.Location = new Point(241, 390);
            clearfound.Name = "clearfound";
            clearfound.Size = new Size(94, 48);
            clearfound.TabIndex = 9;
            clearfound.Text = "Clear";
            clearfound.UseVisualStyleBackColor = false;
            // 
            // itemname
            // 
            itemname.BorderStyle = BorderStyle.FixedSingle;
            itemname.Location = new Point(207, 73);
            itemname.Name = "itemname";
            itemname.Size = new Size(470, 27);
            itemname.TabIndex = 10;
            // 
            // email
            // 
            email.BorderStyle = BorderStyle.FixedSingle;
            email.Location = new Point(207, 265);
            email.Name = "email";
            email.Size = new Size(470, 27);
            email.TabIndex = 11;
            // 
            // description
            // 
            description.BorderStyle = BorderStyle.FixedSingle;
            description.Location = new Point(207, 318);
            description.Multiline = true;
            description.Name = "description";
            description.Size = new Size(470, 66);
            description.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label7.Location = new Point(66, 327);
            label7.Name = "label7";
            label7.Size = new Size(124, 25);
            label7.TabIndex = 13;
            label7.Text = "Description :";
            // 
            // category
            // 
            category.FormattingEnabled = true;
            category.Location = new Point(207, 119);
            category.Name = "category";
            category.Size = new Size(470, 28);
            category.TabIndex = 14;
            // 
            // location
            // 
            location.BorderStyle = BorderStyle.FixedSingle;
            location.Location = new Point(207, 158);
            location.Name = "location";
            location.Size = new Size(470, 27);
            location.TabIndex = 15;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            checkBox1.Location = new Point(207, 207);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(69, 24);
            checkBox1.TabIndex = 17;
            checkBox1.Text = "Good";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            checkBox2.Location = new Point(293, 207);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(98, 24);
            checkBox2.TabIndex = 18;
            checkBox2.Text = "Damaged";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            checkBox3.Location = new Point(397, 207);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(145, 24);
            checkBox3.TabIndex = 19;
            checkBox3.Text = "Slightly Damage";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            checkBox4.Location = new Point(548, 207);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(96, 24);
            checkBox4.TabIndex = 20;
            checkBox4.Text = "Unusable";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.AliceBlue;
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button1.Location = new Point(498, 390);
            button1.Name = "button1";
            button1.Size = new Size(94, 48);
            button1.TabIndex = 21;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 13);
            panel1.TabIndex = 22;
            // 
            // addfounditem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(location);
            Controls.Add(category);
            Controls.Add(label7);
            Controls.Add(description);
            Controls.Add(email);
            Controls.Add(itemname);
            Controls.Add(clearfound);
            Controls.Add(Submitfound);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "addfounditem";
            Text = "addfounditem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button Submitfound;
        private Button clearfound;
        private TextBox itemname;
        private TextBox email;
        private TextBox description;
        private Label label7;
        private ComboBox category;
        private TextBox location;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private Button button1;
        private Panel panel1;
    }
}