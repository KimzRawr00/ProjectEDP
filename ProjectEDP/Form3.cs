using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ProjectEDP
{
    public partial class Form3 : Form
    {
        private List<Stadium> stadiums = new List<Stadium>();
        private Stadium selectedStadium = null;
        private int currentMatchIndex = 0;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LoadStadiumData();
            PopulateComboBox();
        }

        private void LoadStadiumData()
        {
            stadiums.Clear();

            string downloads = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads\";

            string[] stadiumNames =
            {
        "Stadium Sultan Ibrahim",
        "Stadium Tunku Abdul Rahman",
        "Stadium Hang Jebat",
        "Stadium Sarawak",
        "Stadium MBPJ",
        "Stadium Kuala Lumpur",
        "Stadium Petaling Jaya",
        "Stadium Sultan Mizan Zainal Abidin",
        "Stadium Likas",
        "Stadium Sultan Muhammad IV"
    };

            string[,] matches =
            {
        { "JDT vs Terengganu FC", "JDT vs Selangor FC", "JDT vs Sabah FC", "JDT vs Kedah FC" },
        { "Negeri Sembilan vs Kedah", "Negeri Sembilan vs Perak", "Negeri Sembilan vs PDRM", "Negeri Sembilan vs Kelantan" },
        { "Melaka FC vs Kelantan", "Melaka FC vs Penang", "Melaka FC vs KL City", "Melaka FC vs Pahang" },
        { "Kuching City vs PDRM", "Kuching City vs Sabah FC", "Kuching City vs Perak", "Kuching City vs Kedah" },
        { "PJ City vs Penang", "PJ City vs Kelantan", "PJ City vs Perak", "PJ City vs Sabah FC" },
        { "KL City vs Sabah FC", "KL City vs JDT", "KL City vs Selangor FC", "KL City vs Terengganu FC" },
        { "PJ Rangers vs UiTM FC", "PJ Rangers vs Kelantan", "PJ Rangers vs Melaka FC", "PJ Rangers vs PDRM" },
        { "Terengganu FC vs Perak", "Terengganu FC vs JDT", "Terengganu FC vs Selangor FC", "Terengganu FC vs Kedah FC" },
        { "Sabah FC vs Sarawak United", "Sabah FC vs KL City", "Sabah FC vs JDT", "Sabah FC vs Penang" },
        { "Kelantan FC vs Pahang", "Kelantan FC vs Melaka FC", "Kelantan FC vs Perak", "Kelantan FC vs Negeri Sembilan" }
    };

            string[] dates =
            {
        "12 June 2026",
        "20 June 2026",
        "28 June 2026",
        "5 July 2026"
    };

            string[] prices =
            {
        "RM20",
        "RM30",
        "RM40",
        "RM50"
    };

            for (int i = 0; i < stadiumNames.Length; i++)
            {
                Stadium stadium = new Stadium
                {
                    Name = stadiumNames[i],
                    ImagePath = downloads + stadiumNames[i] + ".jpg"
                };

                for (int j = 0; j < 4; j++)
                {
                    stadium.Matches.Add(new FootballMatch
                    {
                        MatchName = matches[i, j],
                        Date = dates[j],
                        Price = prices[j]
                    });
                }

                stadiums.Add(stadium);
            }
        }

        private void PopulateComboBox()
        {
            comboBox1.Items.Clear();

            foreach (var s in stadiums)
            {
                comboBox1.Items.Add(s);
            }

            comboBox1.SelectedIndex = 0;
        }

        private void ShowMatch()
        {
            if (selectedStadium == null) return;

            try
            {
                if (File.Exists(selectedStadium.ImagePath))
                {
                    if (pictureBox3.Image != null)
                        pictureBox3.Image.Dispose();

                    pictureBox3.Image = Image.FromFile(selectedStadium.ImagePath);
                }
                else
                {
                    pictureBox3.Image = null;
                }
            }
            catch
            {
                pictureBox3.Image = null;
            }

            if (selectedStadium.Matches.Count > 0)
            {
                var match = selectedStadium.Matches[currentMatchIndex];

                lblMatch.Text = match.MatchName;
                lblDate.Text = match.Date;
                lblPrice.Text = match.Price;

                btnPrevious.Enabled = currentMatchIndex > 0;
                btnNext.Enabled = currentMatchIndex < selectedStadium.Matches.Count - 1;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedStadium = (Stadium)comboBox1.SelectedItem;
            currentMatchIndex = 0;
            ShowMatch();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentMatchIndex < selectedStadium.Matches.Count - 1)
            {
                currentMatchIndex++;
                ShowMatch();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentMatchIndex > 0)
            {
                currentMatchIndex--;
                ShowMatch();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var match = selectedStadium.Matches[currentMatchIndex];

            MessageBox.Show(
                "Ticket Purchased!\n\n" +
                "Stadium: " + selectedStadium.Name + "\n" +
                "Match: " + match.MatchName + "\n" +
                "Date: " + match.Date + "\n" +
                "Price: " + match.Price,
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }

    public class FootballMatch
    {
        public string MatchName { get; set; }
        public string Date { get; set; }
        public string Price { get; set; }
    }

    public class Stadium
    {
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public List<FootballMatch> Matches { get; set; } = new List<FootballMatch>();

        public override string ToString() => Name;
    }
}