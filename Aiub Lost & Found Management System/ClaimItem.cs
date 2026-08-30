using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Aiub_Lost___Found_Management_System
{
    public partial class ClaimItem : Form
    {
        public ClaimItem()
        {
            InitializeComponent();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void claimsubmit_Click(object sender, EventArgs e)
        {
            if (cid.Text == "" || claimemail.Text == "" || proof.Text == "")
            {
                MessageBox.Show("Fill the box");
                return;
            }
            SqlConnection sqlcon = new SqlConnection(
              @"Data Source=.\SQLEXPRESS;Initial Catalog=LOSTANDFOUNDB;Integrated Security=True");

            sqlcon.Open();

            string query = @"update Founditems 
                set Status = 'Pending', 
                    Claimercontact = '" + claimemail.Text + @"', 
                    Proofdetails = '" + proof.Text + @"' 
                where Id = '" + cid.Text + "'";

            SqlCommand cmd = new SqlCommand(query, sqlcon);

            int count = cmd.ExecuteNonQuery();

            sqlcon.Close();
            if (count > 0)
            {
                MessageBox.Show("Your claim item request has been submitted Successfully.Please wait for admin approval");
                Dashboard d = new Dashboard();
                d.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid.Please try again!");
                Dashboard d = new Dashboard();
                d.Show();
                this.Hide();

            }
        }

        private void cid_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            d.Show();
            this.Hide();
        }
    }
}
