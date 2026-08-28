namespace Aiub_Lost___Found_Management_System
{
    partial class ADDLOSTITEMFORM
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
            ITEMNAME = new TextBox();
            CATEGORY = new ComboBox();
            LOCATION = new TextBox();
            LOSTDATE = new TextBox();
            DESCRIPTION = new TextBox();
            button1 = new Button();
            btndubmit = new Button();
            Btnlostclear = new Button();
            button2 = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Italic, GraphicsUnit.Point, 16, true);
            label1.Location = new Point(290, 9);
            label1.Name = "label1";
            label1.Size = new Size(207, 37);
            label1.TabIndex = 0;
            label1.Text = "Report Lost Item";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.Location = new Point(40, 72);
            label2.Name = "label2";
            label2.Size = new Size(116, 25);
            label2.TabIndex = 1;
            label2.Text = "Item name :";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.Location = new Point(52, 120);
            label3.Name = "label3";
            label3.Size = new Size(104, 25);
            label3.TabIndex = 2;
            label3.Text = "Category :";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.Location = new Point(57, 173);
            label4.Name = "label4";
            label4.Size = new Size(99, 25);
            label4.TabIndex = 3;
            label4.Text = "Location :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.Location = new Point(93, 320);
            label5.Name = "label5";
            label5.Size = new Size(63, 25);
            label5.TabIndex = 4;
            label5.Text = "Date :";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label6.Location = new Point(32, 226);
            label6.Name = "label6";
            label6.Size = new Size(124, 25);
            label6.TabIndex = 5;
            label6.Text = "Description :";
            // 
            // ITEMNAME
            // 
            ITEMNAME.BorderStyle = BorderStyle.FixedSingle;
            ITEMNAME.Location = new Point(174, 72);
            ITEMNAME.Name = "ITEMNAME";
            ITEMNAME.Size = new Size(479, 27);
            ITEMNAME.TabIndex = 7;
            ITEMNAME.TextChanged += txtitem_TextChanged;
            // 
            // CATEGORY
            // 
            CATEGORY.FormattingEnabled = true;
            CATEGORY.Items.AddRange(new object[] { "Electronics", "Documents", "Bag", "Clothing", "Books", "ID Card", "Wallet", "Keys", "Accessories", "Others" });
            CATEGORY.Location = new Point(174, 117);
            CATEGORY.Name = "CATEGORY";
            CATEGORY.Size = new Size(479, 28);
            CATEGORY.TabIndex = 8;
            CATEGORY.SelectedIndexChanged += combocategory_SelectedIndexChanged;
            // 
            // LOCATION
            // 
            LOCATION.BorderStyle = BorderStyle.FixedSingle;
            LOCATION.Location = new Point(174, 173);
            LOCATION.Name = "LOCATION";
            LOCATION.Size = new Size(479, 27);
            LOCATION.TabIndex = 9;
            LOCATION.TextChanged += txtlocation_TextChanged;
            // 
            // LOSTDATE
            // 
            LOSTDATE.BorderStyle = BorderStyle.FixedSingle;
            LOSTDATE.Location = new Point(174, 322);
            LOSTDATE.Name = "LOSTDATE";
            LOSTDATE.Size = new Size(479, 27);
            LOSTDATE.TabIndex = 10;
            // 
            // DESCRIPTION
            // 
            DESCRIPTION.BorderStyle = BorderStyle.FixedSingle;
            DESCRIPTION.Location = new Point(174, 228);
            DESCRIPTION.Multiline = true;
            DESCRIPTION.Name = "DESCRIPTION";
            DESCRIPTION.Size = new Size(479, 66);
            DESCRIPTION.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(329, 394);
            button1.Name = "button1";
            button1.Size = new Size(8, 8);
            button1.TabIndex = 12;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btndubmit
            // 
            btndubmit.BackColor = Color.RoyalBlue;
            btndubmit.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btndubmit.ForeColor = Color.White;
            btndubmit.Location = new Point(356, 367);
            btndubmit.Name = "btndubmit";
            btndubmit.Size = new Size(120, 71);
            btndubmit.TabIndex = 13;
            btndubmit.Text = "Submit";
            btndubmit.UseVisualStyleBackColor = false;
            btndubmit.Click += btndubmit_Click;
            // 
            // Btnlostclear
            // 
            Btnlostclear.BackColor = Color.LightBlue;
            Btnlostclear.BackgroundImageLayout = ImageLayout.Zoom;
            Btnlostclear.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Btnlostclear.Location = new Point(174, 376);
            Btnlostclear.Name = "Btnlostclear";
            Btnlostclear.Size = new Size(94, 41);
            Btnlostclear.TabIndex = 14;
            Btnlostclear.Text = "Clear";
            Btnlostclear.UseVisualStyleBackColor = false;
            Btnlostclear.Click += Btnlostclear_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightBlue;
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button2.Location = new Point(559, 376);
            button2.Name = "button2";
            button2.Size = new Size(94, 41);
            button2.TabIndex = 15;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 53);
            panel1.TabIndex = 16;
            // 
            // ADDLOSTITEMFORM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(Btnlostclear);
            Controls.Add(btndubmit);
            Controls.Add(button1);
            Controls.Add(DESCRIPTION);
            Controls.Add(LOSTDATE);
            Controls.Add(LOCATION);
            Controls.Add(CATEGORY);
            Controls.Add(ITEMNAME);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "ADDLOSTITEMFORM";
            Text = "ADD LOST ITEM FORM";
            Load += ADDLOSTITEMFORM_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private TextBox ITEMNAME;
        private ComboBox CATEGORY;
        private TextBox LOCATION;
        private TextBox LOSTDATE;
        private TextBox DESCRIPTION;
        private Button button1;
        private Button btndubmit;
        private Button Btnlostclear;
        private Button button2;
        private Panel panel1;
    }
}