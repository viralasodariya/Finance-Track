using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Npgsql;

namespace WinForms_Expense_Manager
{
    public partial class Charts : Form
    {
        private readonly string connectionString = "Server=cipg01; port=5432;Database=Group_E_FT;User Id=postgres;password=123456";

        public Charts()
        {
            InitializeComponent();
        }

        private void Charts_Load(object sender, EventArgs e)
        {
            InitializePieChart();
        }

        private void InitializePieChart()
        {
            string query = "SELECT c_category, SUM(c_amount) FROM t_transactions GROUP BY c_category";

            using (var con = new NpgsqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    //MessageBox.Show("connected");
                    using (var cmd = new NpgsqlCommand(query, con))
                    using (var reader = cmd.ExecuteReader())
                    {
                        chart1.Series.Clear();

                        Series series = new Series("Expense Breakdown")
                        {
                            ChartType = SeriesChartType.Pie
                        };

                        while (reader.Read())
                        {
                            //MessageBox.Show(Convert.ToString(reader.GetString(0)));
                            //MessageBox.Show(reader.GetString(1));
                            string category = reader.GetString(0);
                            decimal sum = reader.GetDecimal(1);
                            series.Points.AddXY(category, sum);
                        }

                        chart1.Series.Add(series);
                        chart1.Titles.Clear();
                        chart1.Titles.Add("Expense Breakdown");

                        series.Label = "#PERCENT{P0}";
                        series.LegendText = "#VALX";
                        chart1.Update();
                        chart1.Refresh();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading chart: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        con.Close(); // Explicitly close the connection
                    }
                }
            }
        }
    }
}
