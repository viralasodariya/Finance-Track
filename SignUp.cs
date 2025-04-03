using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;




namespace WinForms_Expense_Manager
{
    
    public partial class SignUp : Form
    {
        private readonly string connectionString = "server=cipg01;port=5432;Database=Group_E_FT;User Id=postgres;Password=123456;";
        public string selectedImagePath;
        // Store OTP
        private string generatedOTP = "";
        // Store OTP generation time
        private DateTime otpGeneratedTime;
        private bool isOtpVerified = false;
        private string cloudinaryImageUrl = "";
        private Cloudinary cloudinary;


        public SignUp()
        {
            InitializeComponent();
            
        }

        private void linkLogIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = openFileDialog.FileName;

                    try
                    {
                        pictureBox1.Image = Image.FromFile(selectedImagePath);
                        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

                       cloudinaryImageUrl= CloudinaryHelper.UploadImageToCloudinary(selectedImagePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

       
        private string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        private void btnSendOtp_Click(object sender, EventArgs e)
        {
            try
            {
                string toEmail = txtEmail.Text.Trim();
                if (string.IsNullOrEmpty(toEmail))
                {
                    MessageBox.Show("Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Generate and store OTP
                generatedOTP = GenerateOTP();
                // Store the current time
                otpGeneratedTime = DateTime.Now;

                string subject = "OTP Code for Verification";
                string body = "Your OTP for verification is: " + generatedOTP + "\nThis OTP is valid for 2 minutes.";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential("jeminlad2003@gmail.com", "pkerjfvwgxwsmezw"), // Use App Password here
                    EnableSsl = true,
                    UseDefaultCredentials = false
                };

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("jeminlad2003@gmail.com");
                mail.To.Add(toEmail);
                mail.Subject = subject;
                mail.Body = body;

                smtp.Send(mail);
                MessageBox.Show("OTP sent successfully! (Valid for 2 minutes)", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Enable verify button
                btnVerifyOtp.Enabled = true;
                // Enable OTP textbox
                txtOtp.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send email. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVerifyOtp_Click(object sender, EventArgs e)
        {
            string enteredOTP = txtOtp.Text.Trim();
            // Calculate time
            TimeSpan otpAge = DateTime.Now - otpGeneratedTime;

            // Check if OTP is older than 2 minutes
            if (otpAge.TotalMinutes > 2)
            {
                MessageBox.Show("OTP expired. Please request a new one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                generatedOTP = "";
                return;
            }

            if (enteredOTP == generatedOTP)
            {
                MessageBox.Show("OTP verified successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isOtpVerified = true;
            }
            else
            {
                MessageBox.Show("Invalid OTP. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isOtpVerified = false;
            }
        }
        private string GenerateOTP()
        {
            // Generates a 4-digit OTP
            Random random = new Random();
            return random.Next(1000, 9999).ToString();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                return;
            }

            // Check if the email already exists in the database
            if (IsEmailAlreadyRegistered(txtEmail.Text))
            {
                MessageBox.Show("This email is already registered. Please use a different email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string hashedPassword = HashPassword(txtPassword.Text);

            DateTime currentDate = DateTime.Now;
            string query = "INSERT INTO t_user (c_username, c_password, c_email, c_phonenumber, c_dateofbirth, c_gender, c_profilepicture, c_createdat) " +
                           "VALUES (@username, @password, @email, @phonenumber, @dob, @gender, @profilepicture, @createdate)";

            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", txtName.Text);
                        command.Parameters.AddWithValue("@password", hashedPassword);
                        command.Parameters.AddWithValue("@email", txtEmail.Text);
                        command.Parameters.AddWithValue("@phonenumber", txtMobile.Text);
                        command.Parameters.AddWithValue("@dob", dateTimePicker1.Value);
                        command.Parameters.AddWithValue("@gender", rdoMale.Checked ? "Male" : "Female");
                        command.Parameters.AddWithValue("@profilepicture", cloudinaryImageUrl ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@createdate", currentDate);

                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("An error occurred while registering. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting to the database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool IsEmailAlreadyRegistered(string email)
        {
            string query = "SELECT COUNT(*) FROM t_user WHERE c_email = @email";

            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@email", email);

                        int count = Convert.ToInt32(command.ExecuteScalar());

                        return count > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error checking email: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(cloudinaryImageUrl))
            {
                MessageBox.Show("Please select a profile picture and upload it successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
           

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name cannot be empty.");
                return false;
            }

            string emailRegex = @"^\S+@\S+\.\S+$";
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !Regex.IsMatch(txtEmail.Text, emailRegex))
            {
                MessageBox.Show("Please Enter Valid Email Address\nexample: abc@example.com");
                return false;
            }

            string mobileRegex = @"^[6-9]\d{9}$";
            if (string.IsNullOrWhiteSpace(txtMobile.Text) || !Regex.IsMatch(txtMobile.Text, mobileRegex))
            {
                MessageBox.Show("Please Enter Valid Mobile Number[only 10 digits starting with 6-9]");
                return false;
            }

            string passRegex = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$#_^!%*?&])[A-Za-z\d@$#_^!%*?&]{8,16}$";
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter password");
                return false;
            }
            if (txtPassword.Text.Length < 8 || !Regex.IsMatch(txtPassword.Text, passRegex))
            {
                MessageBox.Show("Password must have at least 8 characters and include at least one lowercase letter, one uppercase letter, one digit, and one special character\nexample: Abc#$1234");
                return false;
            }

            if (txtConfirmPassword.Text != txtPassword.Text)
            {
                MessageBox.Show("Passwords do not match");
                return false;
            }

            if (dateTimePicker1.Value > DateTime.Now)
            {
                MessageBox.Show("Birth date cannot be in future.");
                return false;
            }

            if (!rdoMale.Checked && !rdoFemale.Checked)
            {
                MessageBox.Show("Please select a gender.");
                return false;
            }

            if (!chkTermsConditions.Checked)
            {
                MessageBox.Show("You must agree to the terms and conditions.");
                return false;
            }

            if (!isOtpVerified)
            {
                MessageBox.Show("Please verify OTP before registration.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void lblArrow_Click(object sender, EventArgs e)
        {
            string termsAndConditions = "Terms and Conditions:\n" +
                                            "1. You are responsible for keeping your account details secure.\n" +
                                            "2. Ensure the financial data you input is accurate to get the best results.\n" +
                                            "3. We are not responsible for any financial decisions or losses made based on the app's data.\n" +
                                            "4. Use this app responsibly and avoid any illegal or unauthorized activities.\n" +
                                            "5. We may suspend or terminate your account for misuse or violations of these terms.\n" +
                                            "6. These terms may change over time. Continued use of the app indicates acceptance of updated terms..";

            MessageBox.Show(termsAndConditions, "Terms and Conditions", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ClearFields()
        {
            txtName.Clear();
            txtEmail.Clear();
            txtMobile.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            dateTimePicker1.Value = DateTime.Now;
            txtOtp.Clear();
            pictureBox1.Image = null;
            selectedImagePath = null;
            chkTermsConditions.Checked = false;
            isOtpVerified = false;
            rdoFemale.Checked = false;
            rdoMale.Checked = false;
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
        private void eyeConfirm_Click(object sender, EventArgs e)
        {
            // Check if the password is currently visible or not
            if (txtConfirmPassword.UseSystemPasswordChar)
            {
                // If it is hidden, show it
                txtConfirmPassword.UseSystemPasswordChar = false;
                eyeConfirm.Text = "👁️";
            }
            else
            {
                txtConfirmPassword.UseSystemPasswordChar = true;
                eyeConfirm.Text = "👁️‍🗨️";
            }
        }

        


    }
}
