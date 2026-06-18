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
    public partial class FormHome : Form
    {
        private List<DataRow> currentMatches = new List<DataRow>();
        private int currentIndex = 0;
        public FormHome()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database2DataSet.MatchTable' table. You can move, or remove it, as needed.
            this.matchTableTableAdapter.Fill(this.database2DataSet.MatchTable);
            // TODO: This line of code loads data into the 'database2DataSet.Team' table. You can move, or remove it, as needed.
            this.teamTableAdapter.Fill(this.database2DataSet.Team);
            // TODO: This line of code loads data into the 'database2DataSet.Stadium' table. You can move, or remove it, as needed.
            this.stadiumTableAdapter.Fill(this.database2DataSet.Stadium);
            this.teamTableAdapter.Fill(this.database2DataSet.Team);
            this.stadiumTableAdapter.Fill(this.database2DataSet.Stadium);
            this.matchTableTableAdapter.Fill(this.database2DataSet.MatchTable);
            comboBox1.DataSource = database2DataSet.Team;
            comboBox1.DisplayMember = "team_name";
            comboBox1.ValueMember = "team_id";
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.teamTableAdapter.FillBy(this.database2DataSet.Team);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string team = comboBox1.Text;

            switch (team)
            {
                case "Argentina":
                    pictureBox1.Image = Properties.Resources.Argentina;
                    break;

                case "Brazil":
                    pictureBox1.Image = Properties.Resources.Brazil;
                    break;

                case "England":
                    pictureBox1.Image = Properties.Resources.England;
                    break;

                case "France":
                    pictureBox1.Image = Properties.Resources.FranceI;
                    break;

                case "Germany":
                    pictureBox1.Image = Properties.Resources.German;
                    break;

                case "Morocco":
                    pictureBox1.Image = Properties.Resources.Morocco;
                    break;

                case "Spain":
                    pictureBox1.Image = Properties.Resources.Spain;
                    break;

                case "Uruguay":
                    pictureBox1.Image = Properties.Resources.Uruguay;
                    break;
            }

            currentMatches.Clear();
            currentIndex = 0;

            foreach (DataRow row in database2DataSet.MatchTable.Rows)
            {
                if (row["match_name"].ToString().Contains(team))
                {
                    currentMatches.Add(row);
                }
            }

            ShowMatch();
        }

        private void ShowMatch()
        {
            if (currentMatches.Count == 0)
                return;

            DataRow row = currentMatches[currentIndex];

            lblMatch.Text = row["match_name"].ToString();

            lblDate.Text =
                Convert.ToDateTime(row["match_date"])
                .ToString("dd/MM/yyyy");

            lblPrice.Text =
                "RM" + row["ticket_price"].ToString();

            int stadiumId =
                Convert.ToInt32(row["stadium_id"]);

            foreach (DataRow stadiumRow in database2DataSet.Stadium.Rows)
            {
                if (Convert.ToInt32(stadiumRow["stadium_id"]) == stadiumId)
                {
                    lblStadium.Text =
                        stadiumRow["stadium_name"].ToString();

                    break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentMatches.Count == 0)
                return;

            currentIndex++;

            if (currentIndex >= currentMatches.Count)
                currentIndex = 0;

            ShowMatch();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormBuyTicket buyTicket = new FormBuyTicket(
        lblStadium.Text,
        lblMatch.Text,
        lblDate.Text,
        lblPrice.Text
    );

            buyTicket.Show();
            this.Hide();
        }
    }
    }

