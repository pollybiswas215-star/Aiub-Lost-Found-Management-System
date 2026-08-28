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
    public partial class ADDLOSTITEMFORM : Form
    {
        public ADDLOSTITEMFORM()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ADDLOSTITEMFORM_Load(object sender, EventArgs e)
        {

        }

        private void btndubmit_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(
               @"Data Source=.\SQLEXPRESS;Initial Catalog=LOSTANDFOUNDB;Integrated Security=True");

            sqlcon.Open();

            string query = @"insert into Lostitems
            values('" + ITEMNAME.Text + "','" +
            CATEGORY.Text + "','" +
            LOCATION.Text + "','" +
          DESCRIPTION.Text + "','" +
            LOSTDATE.Text + "','Lost')";
            SqlCommand cmd = new SqlCommand(query, sqlcon);

            int count = cmd.ExecuteNonQuery();

            sqlcon.Close();
            MessageBox.Show("Lost Item Added Successfully");
            Dashboard d = new Dashboard();
            d.Show();
            this.Hide();
        }

        private void txtitem_TextChanged(object sender, EventArgs e)
        {

        }

        private void combocategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtlocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btnlostclear_Click(object sender, EventArgs e)
        {
            ITEMNAME.Clear();
            CATEGORY.SelectedIndex = -1;
            LOCATION.Clear();
            LOSTDATE.Clear();
            DESCRIPTION.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            d.Show();
            this.Hide();
        }
    }
}
