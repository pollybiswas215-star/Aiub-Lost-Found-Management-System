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
            addfounditem f = new addfounditem();
            f.Show();
            this.Hide();

        }

        private void btnviewlost_Click(object sender, EventArgs e)

        {

            Form6 f = new Form6();
            f.Show();
            this.Hide();
        }

        private void btnviewfound_Click(object sender, EventArgs e)
        {
            Form8 f = new Form8();
            f.Show();
            this.Hide();
        }

        private void btnclaim_Click(object sender, EventArgs e)
        {
            Form9 f = new Form9();
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
            Form1 f = new Form1();
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
            SqlDataReader r = cmd.ExecuteReader();
            int count = 0;
            while (r.Read())
            {
                count++;
            }
            numberlost.Text = count.ToString();
            r.Close();
            sqlcon.Close();
            SqlConnection sqlcon1 = new SqlConnection(
               @"Data Source=.\SQLEXPRESS;Initial Catalog=LOSTANDFOUNDB;Integrated Security=True");

            sqlcon.Open();


            string query1 = "select Count(*) from Founditems";
            SqlCommand cmdf = new SqlCommand(query, sqlcon1);
            SqlDataReader r1 = cmd.ExecuteReader();
            int countf = 0;
            while (r1.Read())
            {
                countf++;
            }
            numberfound.Text = countf.ToString();
           
            r1.Close();
            sqlcon1.Close();
        }

    }
}