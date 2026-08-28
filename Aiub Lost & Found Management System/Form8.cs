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
    public partial class Form8 : Form
    {
        public Form8()
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
    }
}
