// Settings.cs
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
//using static System.Windows.Forms.DataFormats;

namespace WinForms_Expense_Manager
{
    public partial class SettingsForm : Form
    {
        private readonly string connectionString = "server=cipg01;port=5432;Database=Group_E_FT;User Id=postgres;Password=123456";
        private int currentUserId = UserSession.UserId; // Replace with actual logged-in user ID
        private string currentTheme;
        MainForm form = null;


        public SettingsForm(MainForm frm)
        {
            form = frm;
            InitializeComponent();
            LoadCurrentSettings();
            SetupEventHandlers();
        }

        private void SetupEventHandlers()
        {
            // Theme radio buttons
            radLightTheme.CheckedChanged += Theme_CheckedChanged;
            radDarkTheme.CheckedChanged += Theme_CheckedChanged;

            // Save button
            btnSave.Click += SaveButton_Click;
        }

        private void LoadCurrentSettings()
        {
            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "SELECT  c_theme FROM t_settings WHERE c_userid = @userId";
                        cmd.Parameters.AddWithValue("userId", currentUserId);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                currentTheme = reader.GetString(1);

                                if (currentTheme == "Light")
                                    radLightTheme.Checked = true;
                                else
                                    radDarkTheme.Checked = true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading settings: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Theme_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton rb && rb.Checked)
            {
                currentTheme = Convert.ToString(rb.Tag);
                CommonMethods.UpdateTheme(currentTheme, this);
                CommonMethods.UpdateTheme(currentTheme, form);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = @"
                            UPDATE t_settings 
                            SET c_theme = @theme 
                            WHERE c_userid = @userId";

                        cmd.Parameters.AddWithValue("theme", currentTheme);
                        cmd.Parameters.AddWithValue("userId", currentUserId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Settings saved successfully!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No changes were made to the settings.", "Information",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving settings: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}