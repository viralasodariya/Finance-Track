using System.Windows.Forms.DataVisualization.Charting;

namespace WinForms_Expense_Manager
{
    partial class Charts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Make chart1 accessible in Charts.cs
        /// </summary>
        public System.Windows.Forms.DataVisualization.Charting.Chart chart1;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ChartArea chartArea1 = new ChartArea();
            Legend legend1 = new Legend();
            Series series1 = new Series();
            chart1 = new Chart();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();

            // Chart Area
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);

            // Legend
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);

            // Chart Properties
            chart1.Location = new Point(49, 39);
            chart1.Name = "chart1";

            // Series
            series1.ChartArea = "ChartArea1";
            series1.ChartType = SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Expense Breakdown";
            chart1.Series.Add(series1);

            // Chart Size
            chart1.Size = new Size(375, 375);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";

            // Form Properties
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 450);
            Controls.Add(chart1);
            Name = "Charts";
            Text = "Expense Breakdown Chart";

            // Ensure Form Load event is connected
            this.Load += new System.EventHandler(this.Charts_Load);

            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}
