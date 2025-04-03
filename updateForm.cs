using BCrypt.Net;
using Npgsql;
using System.Windows.Forms;
using System.Xml.Linq;
using WinForms_Expense_Manager;



namespace UpdateImage
{
    public partial class Form1 : Form
    {

        private readonly string connectionString = "server=cipg01;port=5432;Database=Group_E_FT;User Id=postgres;Password=123456;";
        private string imageUrl;
        private string oldPassword;
        private string nameUpdate;
        private int userId = UserSession.UserId;
        private string cloudinaryImageUrl = "";
        private string selectedImagePath;


        private readonly NpgsqlConnection connection;

        public Form1()
        {
            InitializeComponent();
            LoadUser();

        }


        private void LoadUser()
        {


            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {

                conn.Open();

                string query = "SELECT c_profilepicture, c_username, c_password FROM t_user WHERE c_userid = @userId";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("userId", userId);

                    using (var reader = cmd.ExecuteReader())
                    {


                        if (reader.Read()) 
                        {
                            if (reader["c_profilepicture"] != DBNull.Value)
                            {
                                imageUrl = reader["c_profilepicture"].ToString();
                                LoadImageFromUrl(imageUrl);
                            }

                            oldPassword = reader["c_password"].ToString();
                            nameUpdate = reader["c_username"].ToString(); 
                        }
                        else
                        {
                            MessageBox.Show("User not found."); 
                        }

                    }
                }
            }
        }

        private void LoadImageFromUrl(string imageUrl)
        {
            try
            {
                // Load the image from the URL into the PictureBox
                using (var webClient = new System.Net.WebClient())
                {
                    byte[] imageData = webClient.DownloadData(imageUrl);
                    using (var ms = new MemoryStream(imageData))
                    {
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load image: " + ex.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                    selectedImagePath=openFileDialog.FileName;
                    cloudinaryImageUrl = CloudinaryHelper.UploadImageToCloudinary(selectedImagePath);
                }
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {

            if (!BCrypt.Net.BCrypt.Verify(txtOldPass.Text, oldPassword))
            {
                MessageBox.Show("Old password is incorrect.");
                return;
            }
            string newPasswordHash = BCrypt.Net.BCrypt.HashPassword(textNewPass.Text);

           

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("UPDATE t_user SET c_username = @username, c_password = @password, c_profilepicture = @profilePicture WHERE c_userid = @userId", conn))
                {
                    cmd.Parameters.AddWithValue("username", txtName.Text);
                    cmd.Parameters.AddWithValue("password", newPasswordHash);
                    cmd.Parameters.AddWithValue("profilePicture", cloudinaryImageUrl);
                    cmd.Parameters.AddWithValue("userId", userId);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Profile updated successfully.");
                        this.Hide();
                        MainForm sc = new MainForm();
                        sc.Show();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update profile.");
                    }
                }
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}