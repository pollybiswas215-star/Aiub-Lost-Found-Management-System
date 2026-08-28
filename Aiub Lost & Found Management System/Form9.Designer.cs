namespace Aiub_Lost___Found_Management_System
{
    partial class Form9
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
            cid = new TextBox();
            proof = new TextBox();
            claimemail = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            claimsubmit = new Button();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // cid
            // 
            cid.Location = new Point(378, 111);
            cid.Margin = new Padding(4);
            cid.Name = "cid";
            cid.Size = new Size(556, 32);
            cid.TabIndex = 0;
            cid.TextChanged += cid_TextChanged;
            // 
            // proof
            // 
            proof.Location = new Point(378, 252);
            proof.Margin = new Padding(4);
            proof.Multiline = true;
            proof.Name = "proof";
            proof.Size = new Size(556, 199);
            proof.TabIndex = 2;
            // 
            // claimemail
            // 
            claimemail.Location = new Point(378, 179);
            claimemail.Margin = new Padding(4);
            claimemail.Name = "claimemail";
            claimemail.Size = new Size(556, 32);
            claimemail.TabIndex = 7;
            claimemail.TextChanged += textBox8_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(295, 105);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 32);
            label1.TabIndex = 8;
            label1.Text = "ID :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(169, 177);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(180, 32);
            label2.TabIndex = 9;
            label2.Text = "Email/Phone  :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.Location = new Point(257, 250);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(92, 32);
            label3.TabIndex = 10;
            label3.Text = "Proof :";
            // 
            // claimsubmit
            // 
            claimsubmit.Location = new Point(379, 485);
            claimsubmit.Margin = new Padding(4);
            claimsubmit.Name = "claimsubmit";
            claimsubmit.Size = new Size(507, 56);
            claimsubmit.TabIndex = 11;
            claimsubmit.Text = "Submit";
            claimsubmit.UseVisualStyleBackColor = true;
            claimsubmit.Click += claimsubmit_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(552, 44);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(0, 25);
            label4.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(411, 23);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(321, 37);
            label5.TabIndex = 13;
            label5.Text = "Claim Your Found items";
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1129, 563);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(claimsubmit);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(claimemail);
            Controls.Add(proof);
            Controls.Add(cid);
            Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Margin = new Padding(4);
            Name = "Form9";
            Text = "Form9";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox cid;
        private TextBox proof;
        private TextBox claimemail;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button claimsubmit;
        private Label label4;
        private Label label5;
    }
}