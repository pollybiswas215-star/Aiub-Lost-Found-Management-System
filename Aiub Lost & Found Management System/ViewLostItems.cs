using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aiub_Lost___Found_Management_System
{
    public partial class ViewLostItems : Form
    {
        public ViewLostItems()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(
                           @"Data Source=.\SQLEXPRESS;Initial Catalog=LOSTANDFOUNDB;Integrated Security=True");
            sqlcon.Open();
            string query = "select * from Lostitems WHERE Status='Lost'";
            SqlDataAdapter a = new SqlDataAdapter(query, sqlcon);
            DataTable d = new DataTable();
            a.Fill(d);
            dataGridView1.DataSource = d;
            sqlcon.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string title = this.dataGridView1.CurrentRow.Cells["ITEMBNAME"].Value.ToString();
            string conString = @"Data Source=.\SQLEXPRESS;Initial Catalog=LOSTANDFOUNDB;Integrated Security=True";


            string query = @"update Lostitems 
                    set Status = 'Found' 
                    where ITEMBNAME = '" + title + "';";

            SqlConnection con = new SqlConnection(conString);
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            int count = cmd.ExecuteNonQuery();
            con.Close();

            if (count > 0)
            {
                MessageBox.Show("Updated successfully!");
                Dashboard d = new Dashboard();
                d.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("error found!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            d.Show();
            this.Hide();
        }


        private void searchtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)

        {
            SqlConnection sqlcon = new SqlConnection(
                           @"Data Source=.\SQLEXPRESS;Initial Catalog=LOSTANDFOUNDB;Integrated Security=True");
            string s = searchtxt.Text.Trim();
            string query = "SELECT * FROM LostItems WHERE ITEMBNAME LIKE '%" + s + "%' OR CATEGORY LIKE '%" + s + "%'";

            SqlDataAdapter ada = new SqlDataAdapter(query, sqlcon);
            DataTable d = new DataTable();
            ada.Fill(d);

            dataGridView1.DataSource = d;

        }
    }

}