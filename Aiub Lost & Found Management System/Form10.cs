using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aiub_Lost___Found_Management_System
{
    public partial class adminlogin : Form
    {
        public adminlogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (adminuser.Text == "" || adminpass.Text == "")
            {
                MessageBox.Show("Please enter official credentials!");
                return;
            }


            if (adminuser.Text == "admin" && adminpass.Text == "admin123")
            {
                MessageBox.Show("Access Granted!");

                Form11 f = new Form11();
                f.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("Invalid!", "Access Denied");

                Form11 f = new Form11();
                f.Show();
                this.Hide();
            }
        }

        private void adminlogin_Load(object sender, EventArgs e)
        {

        }

        private void adminlogout_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            d.Show();
            this.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
