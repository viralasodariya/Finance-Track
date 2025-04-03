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
using BCrypt.Net;
using System.Text.RegularExpressions;

namespace WinForms_Expense_Manager
{
    public partial class
        Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void linkLabel_signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();

        }

        private void linkLabel_forgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string email = txtEmail.Text.Trim();  // Get the email from the text field

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter your email address to reset the password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ForgotPassword pass = new ForgotPassword(email);

            pass.Show();

            this.Hide();

        }
        private string connectionString = "server=cipg01;port=5432;Database=Group_E_FT;User Id=postgres;Password=123456;";



        private void btn_login_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;


            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please Enter  Email Address ");
                return;
            }
            string emailRegex = @"^\S+@\S+\.\S+$";
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !Regex.IsMatch(txtEmail.Text, emailRegex))
            {
                MessageBox.Show("Please Enter Valid Email Address\nexample: abc@example.com");
                return;
            }

            string passRegex = @"^(?=.[a-z])(?=.[A-Z])(?=.\d)(?=.[@$#^!%*?&])[A-Za-z\d@$#^!%*?&]{8,16}$";
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter password");
                return;
            }
           

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    // Fetch user details and hashed password
                    string query = "SELECT c_userid,c_email,c_username,c_password FROM t_user WHERE c_email = @Email";


                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);

                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // int userId = reader.GetInt32(0);
                                int userId = Convert.ToInt32(reader["c_userid"]);
                                // string username = reader.GetString(1);
                                string username = reader["c_username"].ToString();
                                // string userEmail = reader.GetString(2);
                                string userEmail = reader["c_email"].ToString();

                                // string hashedPassword = reader.GetString(3); // Get stored hashed password
                                // Console.WriteLine(hashedPassword);
                                string? hashedPassword = reader["c_password"].ToString();
                                Console.WriteLine(hashedPassword);
                                Console.WriteLine(userId);




                                // Verify the entered password with the hashed password
                                if (BCrypt.Net.BCrypt.Verify(password, hashedPassword))
                                {
                                    UserSession.UserId = userId;
                                    UserSession.Username = username;
                                    UserSession.Email = userEmail;

                                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    txtEmail.Text = string.Empty;
                                    txtPassword.Text = string.Empty;

                                  
                                    MainForm mainform = new MainForm();
                                    mainform.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Invalid email or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid email or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
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
            // Check if the password is currently visible or not
            if (txtPassword.UseSystemPasswordChar)
            {
                // If it is hidden, show it
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
       

    }
}