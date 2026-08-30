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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnlost_Click(object sender, EventArgs e)
        {
            ADDLOSTITEMFORM f = new ADDLOSTITEMFORM();
            f.Show();
            this.Hide();
        }

        private void btnfound_Click(object sender, EventArgs e)
        {
            AddFoundItems f = new AddFoundItems();
            f.Show();
            this.Hide();

        }

        private void btnviewlost_Click(object sender, EventArgs e)

        {

            ViewLostItems f = new ViewLostItems();
            f.Show();
            this.Hide();
        }

        private void btnviewfound_Click(object sender, EventArgs e)
        {
            ViewFoundItems f = new ViewFoundItems();
            f.Show();
            this.Hide();
        }

        private void btnclaim_Click(object sender, EventArgs e)
        {
            ClaimItem f = new ClaimItem();
            f.Show();
            this.Hide();

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            adminlogin f = new adminlogin();
            f.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

            SqlConnection sqlcon = new SqlConnection(
                @"Data Source=.\SQLEXPRESS;Initial Catalog=LOSTANDFOUNDB;Integrated Security=True");

            sqlcon.Open();

            string query = "select Count(*) from Lostitems";
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            int loscount = (int)cmd.ExecuteScalar();
            numberlost.Text = loscount.ToString();
            sqlcon.Close();


            SqlConnection sqlcon1 = new SqlConnection(
                @"Data Source=.\SQLEXPRESS;Initial Catalog=LOSTANDFOUNDB;Integrated Security=True");

            sqlcon1.Open();

            string query1 = "select Count(*) from Founditems";
            SqlCommand cmdf = new SqlCommand(query, sqlcon1);
            int foundcount = (int)cmdf.ExecuteScalar();
            numberfound.Text = foundcount.ToString();
            sqlcon1.Close();

        }

        private void numberlost_Click(object sender, EventArgs e)
        {

        }
    }
}