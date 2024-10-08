using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHEILLA
{
    public partial class Subdivision : Form

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
                adapter = new SqlDataAdapter("select * from subdivison1 ", con);
                dt = new DataTable();
                adapter.Fill(dt);
                dgviewData.DataSource = dt;
            }

        }
        public void clearAllData()
        {
            plotnoTXT.Text = "";
            pricetxt.Text = "";
            plotsTXT.Text = "";
            sizeTXT.Text = "";
            searchTXT.Text = "";
            landcombo.SelectedItem = null;

        }

       
        public Subdivision()
        {
            InitializeComponent();
            showDataOnGridView();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO subdivison1 (plotno, land, totalplots, sizeofplots, price) VALUES (@plotno, @land, @totalplots, @sizeofplots, @price)", con))
                {
                    cmd.Parameters.AddWithValue("@plotno", plotnoTXT.Text);
                    cmd.Parameters.AddWithValue("@land", landcombo.SelectedItem);
                    cmd.Parameters.AddWithValue("@totalplots", plotsTXT.Text);
                    cmd.Parameters.AddWithValue("@sizeofplots", sizeTXT.Text);
                    cmd.Parameters.AddWithValue("@price", pricetxt.Text);
                    //cmd.ExecuteQuery();
                    cmd.ExecuteReader().Close();
                    con.Close();
                    MessageBox.Show("Data inserted successfully");
                    showDataOnGridView();
                    clearAllData();
                }
               
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("DELETE from subdivison1 where plotno=@plotno", con))
                {
                    cmd.Parameters.AddWithValue("@plotno", searchTXT.Text);
                   
                    //cmd.ExecuteQuery();
                    cmd.ExecuteReader().Close();
                    con.Close();
                    MessageBox.Show("Data deleted successfully");
                    showDataOnGridView();
                    clearAllData();
                }

            }
        }

        private void pricetxt_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void plotsTXT_TextChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        private void Subdivision_Load(object sender, EventArgs e)
        {
          
        }

        private void sizeTXT_TextChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }
        private void CalculatePrice()
        {
            // Check if both fields have valid numeric values
            if (double.TryParse(plotsTXT.Text, out double total) && double.TryParse(sizeTXT.Text, out double size))
            {
                // Calculate the price and set it in the pricetxt
                double price = total * size;
                pricetxt.Text = price.ToString();
            }
            else
            {
                // If input is invalid, clear the pricetxt
                pricetxt.Text = string.Empty;
            }
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE subdivison1 set plotno= @plotno, land=@land, totalplots=@totalplots, sizeofplots=@sizeofplots, price=@price where plotno= @plotno", con))
                {
                    cmd.Parameters.AddWithValue("@plotno", plotnoTXT.Text);
                    cmd.Parameters.AddWithValue("@land", landcombo.SelectedItem);
                    cmd.Parameters.AddWithValue("@totalplots", plotsTXT.Text);
                    cmd.Parameters.AddWithValue("@sizeofplots", sizeTXT.Text);
                    cmd.Parameters.AddWithValue("@price", pricetxt.Text);
                    //cmd.ExecuteQuery();
                    cmd.ExecuteReader().Close();
                    con.Close();
                    MessageBox.Show("Data updated successfully");
                    showDataOnGridView();
                    clearAllData();
                }

            }
        }

        private void searchBTN_Click(object sender, EventArgs e)
        {

            using (con = new SqlConnection(cs))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM subdivison1 WHERE plotno= @plotno", con))
                    {
                        // Add the UPI parameter
                        cmd.Parameters.AddWithValue("@plotno", searchTXT.Text.Trim());

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Check if data exists for the provided UPI
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {

                                    plotnoTXT.Text = reader["plotno"].ToString();
                                    pricetxt.Text = reader["price"].ToString();
                                    plotsTXT.Text = reader["totalplots"].ToString();
                                    sizeTXT.Text = reader["sizeofplots"].ToString();
                                    landcombo.Text = reader["land"].ToString();
                                }
                            }
                            else
                            {
                                // UPI does not exist
                                MessageBox.Show("Plot Number does not exist", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
