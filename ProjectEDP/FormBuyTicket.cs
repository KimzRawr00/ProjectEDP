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

        public FormBuyTicket(string stadium, string match, string date, string price)
        {
            InitializeComponent();

            label6.Text = stadium;
            label7.Text = match;
            label8.Text = date;
            label9.Text = price;
            label19.Text = price;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ticketType = comboBox1.Text;
            decimal ticketDiscount = 0;

            if (ticketType == "Adult")
                ticketDiscount = 0;
            else if (ticketType == "Child")
                ticketDiscount = 0.05m;
            else if (ticketType == "Senior Citizen")
                ticketDiscount = 0.02m;
            else
            {
                MessageBox.Show("Please select ticket type.");
                return;
            }

            int quantity = (int)numericUpDown1.Value;

            if (quantity <= 0)
            {
                MessageBox.Show("Quantity must be at least 1.");
                return;
            }

            string seatType = "";
            decimal seatExtra = 0;

            if (radioButton1.Checked)
            {
                seatType = "Standard";
                seatExtra = 0;
            }
            else if (radioButton2.Checked)
            {
                seatType = "Premium";
                seatExtra = 0.02m;
            }
            else if (radioButton3.Checked)
            {
                seatType = "VIP";
                seatExtra = 0.05m;
            }
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

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Please fill in customer details.");
                return;
            }

            decimal basePrice = decimal.Parse(label9.Text.Replace("RM", ""));
            decimal priceAfterDiscount = basePrice - (basePrice * ticketDiscount);
            decimal priceAfterSeat = priceAfterDiscount + (priceAfterDiscount * seatExtra);
            decimal total = priceAfterSeat * quantity;

            label19.Text = "RM" + total.ToString("0.00");

            FormPayment payment = new FormPayment();

            payment.label3.Text = label19.Text;

            payment.receiptDate = label8.Text;
            payment.receiptStadium = label6.Text;
            payment.receiptMatch = label7.Text;
            payment.receiptSeatType = seatType;
            payment.receiptTicketType = ticketType;
            payment.receiptQuantity = quantity.ToString();

            payment.receiptName = textBox1.Text;
            payment.receiptPhone = textBox2.Text;
            payment.receiptEmail = textBox3.Text;

            payment.receiptPaymentMethod = paymentMethod;
            payment.receiptTotalPaid = label19.Text;

            this.Hide();
            payment.ShowDialog();
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

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
