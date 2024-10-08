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
    public partial class Signup : Form
    {

        string cs = ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        public Signup()
        {
            InitializeComponent();
        }
        public void clearAllData()
        {
            emailTB.Text = "";
            passwordTB.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(emailTB.Text) || string.IsNullOrWhiteSpace(passwordTB.Text))
            {
                // Display an error message
                MessageBox.Show("Email and password cannot be empty", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method to prevent further execution
            }

            using (con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO users1 (email,password) VALUES (@email, @password)", con))
                {
                    cmd.Parameters.AddWithValue("@email", emailTB.Text);
                    cmd.Parameters.AddWithValue("@password", passwordTB.Text);
                    //cmd.ExecuteQuery();
                    cmd.ExecuteReader().Close();
                    con.Close();
                    MessageBox.Show("Account created successfully");
                    //  showDataOnGridView();
                    clearAllData();
                }
                // cmd = new SqlCommand("Insert into Students (Name, Gender, phone, Email) values (@name, @gender, @phone, @email)", con);

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void emailTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
