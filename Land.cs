using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Configuration;
using System.Xml.Linq;

namespace SHEILLA
{
    public partial class Land : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;

        public void showDataOnGridView()
        {
            using (con = new SqlConnection(cs))
            {
                adapter = new SqlDataAdapter("select * from sheilla_table", con);
                dt=new DataTable();
                adapter.Fill(dt);
                dgviewData.DataSource = dt;
            }
           
        }

        public void clearAllData()
        {
            upiTB.Text = "";
            priceTB.Text = "";
            sizeTB.Text = "";
            descriptionTB.Text = "";
            typeBox.SelectedItem = null;

        }

        public Land()
        {
            InitializeComponent();
            showDataOnGridView();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        

            private void dviewClick(object sender, DataGridViewCellEventArgs e)
        {

            upiTB.Text = this.dgviewData.CurrentRow.Cells["UPI"].Value.ToString();
            sizeTB.Text = this.dgviewData.CurrentRow.Cells["size"].Value.ToString();
            priceTB.Text = this.dgviewData.CurrentRow.Cells["price"].Value.ToString();
            typeBox.Text = this.dgviewData.CurrentRow.Cells["type"].Value.ToString();
            descriptionTB.Text = this.dgviewData.CurrentRow.Cells["description"].Value.ToString();


            //lblID.Text = this.dgViewStudent.CurrentRow.Cells["StudentID"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO sheilla_table (UPI, size, type, price, description) VALUES (@upi, @size, @type, @price,@description)", con))
                {
                    cmd.Parameters.AddWithValue("@upi", upiTB.Text);
                    cmd.Parameters.AddWithValue("@size", sizeTB.Text);
                    cmd.Parameters.AddWithValue("@type", typeBox.SelectedItem);
                    cmd.Parameters.AddWithValue("@price", priceTB.Text);
                    cmd.Parameters.AddWithValue("@description", descriptionTB.Text);
                    //cmd.ExecuteQuery();
                    cmd.ExecuteReader().Close();
                    con.Close();
                    MessageBox.Show("Data inserted successfully");
                    showDataOnGridView();
                   clearAllData();
                }
                // cmd = new SqlCommand("Insert into Students (Name, Gender, phone, Email) values (@name, @gender, @phone, @email)", con);

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("update sheilla_table set UPI=@upi, size=@size, type=@type, price=@price, description=@description where UPI=@upi", con))
                {
                    cmd.Parameters.AddWithValue("@upi", upiTB.Text);
                    cmd.Parameters.AddWithValue("@size", sizeTB.Text);
                    cmd.Parameters.AddWithValue("@type", typeBox.SelectedItem);
                    cmd.Parameters.AddWithValue("@price", priceTB.Text);
                    cmd.Parameters.AddWithValue("@description", descriptionTB.Text);
                    //cmd.ExecuteQuery();
                    cmd.ExecuteReader().Close();
                    con.Close();
                    MessageBox.Show("Data updated successfully");
                    showDataOnGridView();
                    clearAllData();
                }
                // cmd = new SqlCommand("Insert into Students (Name, Gender, phone, Email) values (@name, @gender, @phone, @email)", con);

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("delete from sheilla_table where UPI=@upi", con))
                {
                    cmd.Parameters.AddWithValue("@upi", getUPI.Text);
                    //cmd.ExecuteQuery();
                    cmd.ExecuteReader().Close();
                    con.Close();
                    MessageBox.Show("Data deleted successfully");
                    showDataOnGridView();
                    clearAllData();
                }
                // cmd = new SqlCommand("Insert into Students (Name, Gender, phone, Email) values (@name, @gender, @phone, @email)", con);

            }
        }

        private void viewClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchBTN_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(cs))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM sheilla_table WHERE UPI = @upi", con))
                    {
                        // Add the UPI parameter
                        cmd.Parameters.AddWithValue("@upi", getUPI.Text.Trim());

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Check if data exists for the provided UPI
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    
                                    upiTB.Text = reader["UPI"].ToString();
                                    sizeTB.Text = reader["size"].ToString();
                                    typeBox.Text = reader["type"].ToString();
                                    priceTB.Text = reader["price"].ToString();
                                    descriptionTB.Text = reader["description"].ToString();
                                }
                            }
                            else
                            {
                                // UPI does not exist
                                MessageBox.Show("UPI does not exist", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle any errors during the database operation
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Close the connection if it's still open
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
            }
        }

        private void typeBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
