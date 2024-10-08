
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
    public partial class Login : Form
    {

        string cs = ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        public Login()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string enteredEmail = emailTB.Text.Trim();
            string enteredPswd = passwordTB.Text.Trim();

            using (con = new SqlConnection(cs))
            {
                try
                {
                    con.Open();
                    string query = "SELECT COUNT(*) FROM users1 WHERE email = @email AND password = @password";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@email", enteredEmail);
                        cmd.Parameters.AddWithValue("@password", enteredPswd);

                        int count = (int)cmd.ExecuteScalar();

                        if (count > 0)
                        {
                            Land land = new Land();
                            land.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect credentials");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void emailTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup signup = new Signup();
            signup.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Subdivision sub = new Subdivision();
            sub.Show();
            this.Hide();
        }
    }
}
