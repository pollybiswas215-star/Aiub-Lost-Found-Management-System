using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Aiub_Lost___Found_Management_System
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fullname.Text == "" || txtpassword.Text == "" || conpass.Text == "" || username.Text == "")
            {
                MessageBox.Show("Fill the box");

            }
            else if (txtpassword.Text != conpass.Text)
            {
                MessageBox.Show("Password does not match");


            }
            else
            {
                SqlConnection sqlcon = new SqlConnection(
                @"Data Source=.\SQLEXPRESS;Initial Catalog=LOSTANDFOUNDB;Integrated Security=True");

                sqlcon.Open();

                string query = @"insert into users
            values('" + fullname.Text + "','" +
                username.Text + "','" +
                txtemail.Text + "','" +
                txtpassword.Text + "')";
                SqlCommand cmd = new SqlCommand(query, sqlcon);

                int count = cmd.ExecuteNonQuery();

                sqlcon.Close();

                if (count > 0)
                {
                    MessageBox.Show("Registration Successful");
                    Login f = new Login();
                    f.Show();
                    this.Hide();
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            fullname.Clear();
            username.Clear();
            txtemail.Clear();
            txtpassword.Clear();
            conpass.Clear();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Login F = new Login();
            F.Show();
            this.Hide();
        }
    }
}
