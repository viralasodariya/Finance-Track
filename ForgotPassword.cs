using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinForms_Expense_Manager
{
    public partial class ForgotPassword : Form
    {
        private string connectionString = "server=cipg01;port=5432;Database=Group_E_FT;User Id=postgres;Password=123456;";

        private string userEmail;
        public ForgotPassword(string email)
        {
            this.Load += new EventHandler(ForgotPassword_Load);

            InitializeComponent();
            userEmail = email;
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {
            // Set the email field with the value passed from the Login form
            txtEmail.Text = userEmail;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string newPassword = txtPassword.Text;
            string confirmPassword = txtConPass.Text;

            // Validate Passwords
            if (string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please enter both new password and confirm password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hash the new password
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(newPassword);

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    // Update password query
                    string query = "UPDATE t_user SET c_password = @Password WHERE c_email = @Email";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", hashedPassword);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password has been successfully reset.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close(); // Close the ForgotPassword form after successful reset
                            Login loginForm = new Login();
                            loginForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("No user found with the provided email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void eyePass_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar)
            {
                txtPassword.UseSystemPasswordChar = false;
                eyePass.Text = "👁️";
            }
            else
            {
                // If it is visible, hide it
                txtPassword.UseSystemPasswordChar = true;
                eyePass.Text = "👁️‍🗨️";
            }
        }

        private void eyeConfirm_Click(object sender, EventArgs e)
        {
            // Check if the password is currently visible or not
            if (txtConPass.UseSystemPasswordChar)
            {
                // If it is hidden, show it
                txtConPass.UseSystemPasswordChar = false;
                eyeConfirm.Text = "👁️";
            }
            else
            {
                txtConPass.UseSystemPasswordChar = true;
                eyeConfirm.Text = "👁️‍🗨️";
            }
        }


    }
}
