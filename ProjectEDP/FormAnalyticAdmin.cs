using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProjectEDP
{
    public partial class FormAnalyticAdmin : Form
    {
        public FormAnalyticAdmin()
        {
            InitializeComponent();
        }

        private void chartBookingStadium_Click(object sender, EventArgs e)
        {

        }

        private void FormAnalyticAdmin_Load(object sender, EventArgs e)
        {
            LoadBookingByStadiumChart();
            LoadPopularMatchChart();
            LoadPaymentUsageChart();

            LoadSummaryData();
        }

        private void LoadSummaryData()
        {
            string connectionString =
                @"Data Source=(LocalDB)\MSSQLLocalDB;
          AttachDbFilename=|DataDirectory|\Database2.mdf;
          Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionString);

            con.Open();

            // Total Customer
            SqlCommand cmdCustomer =
                new SqlCommand("SELECT COUNT(*) FROM Customer", con);

            labelCustomer.Text =
                cmdCustomer.ExecuteScalar().ToString();


            // Total Booking
            SqlCommand cmdBooking =
                new SqlCommand("SELECT COUNT(*) FROM Booking", con);

            labelBooking.Text =
                cmdBooking.ExecuteScalar().ToString();


            // Total Revenue
            SqlCommand cmdRevenue =
                new SqlCommand("SELECT SUM(total_amount) FROM Booking", con);

            object revenue = cmdRevenue.ExecuteScalar();

            labelReveneu.Text =
                "RM " + Convert.ToDecimal(revenue).ToString("N2");

            con.Close();
        }

        private void LoadBookingByStadiumChart()
        {
            chartBookingStadium.Series.Clear();

            Series series = new Series("Booking");
            series.ChartType = SeriesChartType.Bar;
            series.IsValueShownAsLabel = true;

            string connectionString =
                @"Data Source=(LocalDB)\MSSQLLocalDB;
          AttachDbFilename=|DataDirectory|\Database2.mdf;
          Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionString);

            string query = @"
                                SELECT s.stadium_name,
                                       COUNT(b.booking_id) AS TotalBooking
                                FROM Stadium s
                                JOIN MatchTable m
                                    ON s.stadium_id = m.stadium_id
                                JOIN Booking b
                                    ON m.match_id = b.match_id
                                GROUP BY s.stadium_name
                                ORDER BY TotalBooking DESC";

            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                series.Points.AddXY(
                    reader["stadium_name"].ToString(),
                    Convert.ToInt32(reader["TotalBooking"])
                );
            }

            con.Close();

            chartBookingStadium.Series.Add(series);

            chartBookingStadium.Legends.Clear();
            chartBookingStadium.Titles.Clear();
            chartBookingStadium.Titles.Add("Booking By Stadium");
        }

        private void LoadPopularMatchChart()
        {
            chartPopularMatch.Series.Clear();

            Series series = new Series("Match");
            series.ChartType = SeriesChartType.Bar;
            series.IsValueShownAsLabel = true;

            string connectionString =
                @"Data Source=(LocalDB)\MSSQLLocalDB;
          AttachDbFilename=|DataDirectory|\Database2.mdf;
          Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionString);

            string query = @"
    SELECT m.match_name,
           COUNT(b.booking_id) AS TotalBooking
    FROM MatchTable m
    JOIN Booking b
        ON m.match_id = b.match_id
    GROUP BY m.match_name
    ORDER BY TotalBooking DESC";

            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                series.Points.AddXY(
                    reader["match_name"].ToString(),
                    Convert.ToInt32(reader["TotalBooking"])
                );
            }

            con.Close();

            chartPopularMatch.Series.Add(series);

            chartPopularMatch.Legends.Clear();
            chartPopularMatch.Titles.Clear();
            chartPopularMatch.Titles.Add("Popular Match");
        }

        private void LoadPaymentUsageChart()
        {
            chartPaymentUsage.Series.Clear();

            Series series = new Series("Payment");
            series.ChartType = SeriesChartType.Pie;

            series.IsValueShownAsLabel = true;
            series.Label = "#PERCENT";
            series.LegendText = "#VALX";

            string connectionString =
                @"Data Source=(LocalDB)\MSSQLLocalDB;
          AttachDbFilename=|DataDirectory|\Database2.mdf;
          Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionString);

            string query = @"
    SELECT type,
           COUNT(*) AS TotalUsage
    FROM Payment
    GROUP BY type";

            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                series.Points.AddXY(
                    reader["type"].ToString(),
                    Convert.ToInt32(reader["TotalUsage"])
                );
            }

            reader.Close();
            con.Close();

            chartPaymentUsage.Series.Add(series);

            chartPaymentUsage.Titles.Clear();
            chartPaymentUsage.Titles.Add("Payment Type Distribution");
        }

        private void chartPopularMatch_Click(object sender, EventArgs e)
        {

        }

        private void labelReveneu_Click(object sender, EventArgs e)
        {

        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
