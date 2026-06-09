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
    public partial class FormBuyTicket : Form
    {
        public FormBuyTicket()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string seatType = "";

            if (radioButton1.Checked)
                seatType = "Standard";
            else if (radioButton2.Checked)
                seatType = "Premium";
            else if (radioButton3.Checked)
                seatType = "VIP";
            else
            {
                MessageBox.Show("Please select seat type.");
                return;
            }

            string paymentMethod = "";

            if (radioButton4.Checked)
                paymentMethod = "Cash";
            else if (radioButton5.Checked)
                paymentMethod = "Online Banking";
            else if (radioButton6.Checked)
                paymentMethod = "E-Wallet";
            else
            {
                MessageBox.Show("Please select payment method.");
                return;
            }

            if (comboBox1.Text == "")
            {
                MessageBox.Show("Please select ticket type.");
                return;
            }

            if (numericUpDown1.Value <= 0)
            {
                MessageBox.Show("Quantity must be at least 1.");
                return;
            }

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Please fill in customer details.");
                return;
            }

            FormPayment payment = new FormPayment();

            payment.label3.Text = label19.Text; // Total Amount

            payment.receiptDate = label8.Text;
            payment.receiptStadium = label6.Text;
            payment.receiptMatch = label7.Text;
            payment.receiptSeatType = seatType;
            payment.receiptTicketType = comboBox1.Text;
            payment.receiptQuantity = numericUpDown1.Value.ToString();

            payment.receiptName = textBox1.Text;
            payment.receiptPhone = textBox2.Text;
            payment.receiptEmail = textBox3.Text;

            payment.receiptPaymentMethod = paymentMethod;
            payment.receiptTotalPaid = label19.Text;

            payment.ShowDialog();
        }
    }
}
