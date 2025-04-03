using Npgsql;

namespace WinForms_Expense_Manager.Forms
{
    public partial class AddNewEntryForm : Form
    {
        private string connectionString = "server=cipg01;port=5432;Database=Group_E_FT;User Id=postgres;Password=123456;";

        Classes.ExpenseManager _manager;
        public AddNewEntryForm(Classes.ExpenseManager manager)
        {
            _manager=manager;
            InitializeComponent();
        }

        private void AddNewEntryForm_Load(object sender, EventArgs e)
        {
            // Initially populate the comboBoxCategories
            comboBoxCategories.Items.AddRange(_manager.Categories.Values.ToArray());
            comboBoxCategories.SelectedIndex = 0;
        }

        private void buttonAddNewEntry_Click(object sender, EventArgs e)
        {   
            string title = textBoxTitle.Text;
            string description = textBoxDescription.Text;
            string value = textBoxValue.Text;
            decimal parsedValue;

            if (string.IsNullOrEmpty(value))
            {
                MessageBox.Show("Value is a required field!\nPlease fill out the field first.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            if(!decimal.TryParse(value, out parsedValue))
            {
                MessageBox.Show("Value must be a number!\nPlease try again.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if(comboBoxCategories.SelectedIndex == 0)
            {
                DialogResult result = MessageBox.Show("You are about to save the entry with no category.\nAre you sure?",
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if(result == DialogResult.No)
                {
                    return;
                }
            }
            string category = comboBoxCategories.SelectedItem.ToString();

            Guid categoryId;
            _manager.TryGetCategoryId(comboBoxCategories.SelectedItem.ToString(), out categoryId);
            Classes.Entry entry = new(title,description,parsedValue);
            entry.CategoryId = categoryId;
            _manager.AddEntry(entry);


            string query = "INSERT INTO t_transactions (c_userid,c_title, c_desc, c_amount, c_category) " +
                "VALUES (@UserId, @Title, @Description, @Value, @Category)";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    // Add Parameters to Prevent SQL Injection
                    command.Parameters.AddWithValue("@UserId", UserSession.UserId);
                    command.Parameters.AddWithValue("@Title", title);
                    command.Parameters.AddWithValue("@Description", description);
                    command.Parameters.AddWithValue("@Value", parsedValue);
                    command.Parameters.AddWithValue("@Category", category);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Data inserted into the database successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while inserting data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }



            Close();
        }
    }
}
