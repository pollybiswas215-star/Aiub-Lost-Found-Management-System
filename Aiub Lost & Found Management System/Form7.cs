using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Aiub_Lost___Found_Management_System
{
    public partial class addfounditem : Form
    {
        public addfounditem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string condition = "";
            if (checkBox1.Checked)
            {
                condition = "Good";
            }
            else if (checkBox2.Checked)
            {
                condition = "Damaged";
            }
            else if (checkBox3.Checked)
            {
                condition = "Slightly Damage";
            }
            else
            {
                MessageBox.Show("select a condition!");

            }
            SqlConnection sqlcon = new SqlConnection(
                 @"Data Source=.\SQLEXPRESS;Initial Catalog=LOSTANDFOUNDB;Integrated Security=True");

            sqlcon.Open();

            string query = @"insert into Founditems(itemname,category,location,condition,email,description)
values('" + itemname.Text + "','" +
            category.Text + "','" +
            location.Text + "','" +
            condition + "','" +
            email.Text + "','" +
            description.Text + "')";

            SqlCommand cmd = new SqlCommand(query, sqlcon);

            int count = cmd.ExecuteNonQuery();

            sqlcon.Close();
            MessageBox.Show("Found Item Added Successfully");
            Dashboard d = new Dashboard();
            d.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            d.Show();
            this.Hide();
        }
    }
}