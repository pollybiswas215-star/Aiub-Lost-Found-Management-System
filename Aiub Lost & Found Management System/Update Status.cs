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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }
        private void Form11_Load(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(
                           @"Data Source=.\SQLEXPRESS;Initial Catalog=LOSTANDFOUNDB;Integrated Security=True");
            sqlcon.Open();
            string query = "select * from Founditems WHERE Status='Pending'";
            SqlDataAdapter a = new SqlDataAdapter(query, sqlcon);
            DataTable d = new DataTable();
            a.Fill(d);
            dataGridView1.DataSource = d;
            sqlcon.Close();

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedItem == null) return;
            string option = comboBox1.SelectedItem.ToString();
            SqlConnection sqlcon = new SqlConnection(
                @"Data Source=.\SQLEXPRESS;Initial Catalog=LOSTANDFOUNDB;Integrated Security=True");

            sqlcon.Open();
            
            if (option=="Approved")
            {
                string query = "UPDATE Founditems SET Status = 'Approved'";

                SqlCommand cmd = new SqlCommand(query, sqlcon);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Approved!");
            }
            else if (option=="Rejected")
            {
                string query = "UPDATE Founditems SET Status = 'Rejected'";

                SqlCommand cmd = new SqlCommand(query, sqlcon);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Rejected!");
            }


            sqlcon.Close();
        }
        }
    }

