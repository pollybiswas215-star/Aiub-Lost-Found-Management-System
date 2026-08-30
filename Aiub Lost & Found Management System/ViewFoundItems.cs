using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aiub_Lost___Found_Management_System
{
    public partial class ViewFoundItems : Form
    {
        public ViewFoundItems()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(
                           @"Data Source=.\SQLEXPRESS;Initial Catalog=LOSTANDFOUNDB;Integrated Security=True");
            sqlcon.Open();
            string query = "select * from Founditems";
            SqlDataAdapter a = new SqlDataAdapter(query, sqlcon);
            DataTable d = new DataTable();
            a.Fill(d);
            dataGridView2.DataSource = d;
            sqlcon.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(
                           @"Data Source=.\SQLEXPRESS;Initial Catalog=LOSTANDFOUNDB;Integrated Security=True");
            string s = search.Text.Trim();
            string query = "SELECT * FROM Founditems WHERE itemname LIKE '%" + s + "%' OR category LIKE '%" + s + "%'";

            SqlDataAdapter ada = new SqlDataAdapter(query, sqlcon);
            DataTable d = new DataTable();
            ada.Fill(d);

            dataGridView2.DataSource = d;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            d.Show();
            this.Hide();
        }
    }
}
