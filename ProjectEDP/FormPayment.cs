using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectEDP
{
    public partial class FormPayment : Form
    {
        public string receiptDate;
        public string receiptStadium;
        public string receiptMatch;
        public string receiptSeatType;
        public string receiptTicketType;
        public string receiptQuantity;

        public string receiptName;
        public string receiptPhone;
        public string receiptEmail;

        public string receiptPaymentMethod;
        public string receiptTotalPaid;
        public FormPayment()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormReceipt receipt = new FormReceipt();

            receipt.label3.Text = receiptDate;
            receipt.label5.Text = receiptStadium;
            receipt.label7.Text = receiptMatch;
            receipt.label9.Text = receiptSeatType;
            receipt.label11.Text = receiptTicketType;
            receipt.label13.Text = receiptQuantity;

            receipt.label17.Text = receiptName;
            receipt.label18.Text = receiptPhone;
            receipt.label19.Text = receiptEmail;

            receipt.label22.Text = receiptPaymentMethod;
            receipt.label23.Text = "Paid";
            receipt.label25.Text = receiptTotalPaid;

            this.Hide();
            receipt.ShowDialog();
            this.Close();
        }

        private void FormPayment_Load(object sender, EventArgs e)
        {
            comboBox1.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                comboBox1.Visible = false;
                comboBox1.Items.Clear();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                comboBox1.Visible = true;
                comboBox1.Items.Clear();

                comboBox1.Items.Add("Maybank");
                comboBox1.Items.Add("CIMB Bank");
                comboBox1.Items.Add("Public Bank");
                comboBox1.Items.Add("RHB Bank");
                comboBox1.Items.Add("Bank Islam");

                comboBox1.SelectedIndex = 0;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                comboBox1.Visible = true;
                comboBox1.Items.Clear();

                comboBox1.Items.Add("Touch 'n Go");
                comboBox1.Items.Add("GrabPay");
                comboBox1.Items.Add("Boost");
                comboBox1.Items.Add("ShopeePay");

                comboBox1.SelectedIndex = 0;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Maybank")
                pictureBox1.Image = Properties.Resources.Maybank;

            else if (comboBox1.Text == "CIMB Bank")
                pictureBox1.Image = Properties.Resources.CIMB;

            else if (comboBox1.Text == "Public Bank")
                pictureBox1.Image = Properties.Resources.PublicBank;

            else if (comboBox1.Text == "RHB Bank")
                pictureBox1.Image = Properties.Resources.RHB;

            else if (comboBox1.Text == "Bank Islam")
                pictureBox1.Image = Properties.Resources.BankIslam;

            else if (comboBox1.Text == "Touch 'n Go")
                pictureBox1.Image = Properties.Resources.TnG;

            else if (comboBox1.Text == "GrabPay")
                pictureBox1.Image = Properties.Resources.GrabPay;

            else if (comboBox1.Text == "Boost")
                pictureBox1.Image = Properties.Resources.Boost;

            else if (comboBox1.Text == "ShopeePay")
                pictureBox1.Image = Properties.Resources.ShopeePay;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormHome home = new FormHome();
            this.Hide();
            home.ShowDialog();
            this.Close();
        }
    }
}
