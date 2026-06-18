using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProjectEDP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string connStr =
    @"Data Source=(LocalDB)\MSSQLLocalDB;
      AttachDbFilename=|DataDirectory|\Database2.mdf;
      Integrated Security=True";

            SqlConnection conn = new SqlConnection(connStr);

            string query =
            @"INSERT INTO Customer
      (customer_name, phone_number, email, password)
      VALUES
      (@name,@phone,@email,@password)";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            cmd.Parameters.AddWithValue("@phone", textBox2.Text);
            cmd.Parameters.AddWithValue("@email", textBox3.Text);
            cmd.Parameters.AddWithValue("@password", textBox4.Text);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Account Created Successfully!");

            Form1 login = new Form1();
            login.Show();
            this.Close();
        }

        private void btnCreateAccount_Click_1(object sender, EventArgs e)
        {
            string connStr =
    @"Data Source=(LocalDB)\MSSQLLocalDB;
      AttachDbFilename=|DataDirectory|\Database2.mdf;
      Integrated Security=True";

            SqlConnection conn = new SqlConnection(connStr);

            string query =
            @"INSERT INTO Customer
      (customer_name, phone_number, email, password)
      VALUES
      (@name,@phone,@email,@password)";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            cmd.Parameters.AddWithValue("@phone", textBox2.Text);
            cmd.Parameters.AddWithValue("@email", textBox3.Text);
            cmd.Parameters.AddWithValue("@password", textBox4.Text);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Account Created Successfully!");

            Form1 login = new Form1();
            login.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
