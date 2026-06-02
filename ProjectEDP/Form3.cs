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

    public partial class Form3 : Form
    {
        private int currentMatch = 0;

        string[] matches =
        {
            "JDT vs Kuching City",
            "Selangor vs Terengganu",
            "Sabah vs Kedah",
            "Penang vs Negeri Sembilan"
};

        string[] dates =
        {
            "25/10/2026",
            "01/11/2026",
            "05/11/2026",
            "08/11/2026"
};

        string[] venues =
        {
            "Sultan Ibrahim Stadium",
            "MBPJ Stadium",
            "Likas Stadium",
            "Penang Stadium"
};

        string[] prices =
        {
            "RM50",
            "RM40",
            "RM30",
            "RM34"
};

        
        private void ShowMatch()
        {
            lblMatch.Text = matches[currentMatch];
            lblDate.Text = dates[currentMatch];
            lblVenue.Text = venues[currentMatch];
            lblPrice.Text = prices[currentMatch];
            dgvMatches.ClearSelection();
            if (currentMatch < dgvMatches.Rows.Count)
            {
                dgvMatches.ClearSelection();
                dgvMatches.Rows[currentMatch].Selected = true;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            dgvMatches.Rows.Add(matches[0], dates[0], venues[0], prices[0]);
            dgvMatches.Rows.Add(matches[1], dates[1], venues[1], prices[1]);
            dgvMatches.Rows.Add(matches[2], dates[2], venues[2], prices[2]);
            dgvMatches.Rows.Add(matches[3], dates[3], venues[3], prices[3]);

            ShowMatch();
        }
        public Form3()
        {
            InitializeComponent();
        }

        private void lblDesc_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            currentMatch++;

            if (currentMatch >= matches.Length)
            {
                currentMatch = 0;
            }

            ShowMatch();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            currentMatch--;

            if (currentMatch < 0)
            {
                currentMatch = matches.Length - 1;
            }

            ShowMatch();
        }

        private void dgvMatches_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
