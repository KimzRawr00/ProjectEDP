using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectEDP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnLogin.FlatAppearance.BorderSize = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUsername.Text = "Enter your email";
            txtUsername.ForeColor = Color.Gray;

            txtPassword.Text = "Enter your password";
            txtPassword.ForeColor = Color.Gray;
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Enter your email")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Enter your email";
                txtUsername.ForeColor = Color.Gray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Enter your password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.Text = "Enter your password";
                txtPassword.ForeColor = Color.Gray;
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "admin" && password == "admin123")
            {
                MessageBox.Show("Admin Login Success!");

                FormAdmin admin = new FormAdmin();
                admin.Show();
                this.Hide();
                return;
            }


            string connStr =
                @"Data Source=(LocalDB)\MSSQLLocalDB;
           AttachDbFilename=|DataDirectory|\Database2.mdf;
           Integrated Security=True";

            SqlConnection conn = new SqlConnection(connStr);

            string query =
                "SELECT * FROM Customer WHERE customer_name=@name AND password=@pass";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@name", username);
            cmd.Parameters.AddWithValue("@pass", password);

            conn.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("User Login Success!");

                FormHome home = new FormHome();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }

            conn.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 secondForm = new Form2();
            secondForm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}