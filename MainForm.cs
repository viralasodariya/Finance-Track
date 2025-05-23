using System.Diagnostics;
using System.IO;
using System.Text.Json;
using WinForms_Expense_Manager.Classes;
using WinForms_Expense_Manager.Forms;
using UpdateImage;

namespace WinForms_Expense_Manager
{
    public partial class MainForm : Form
    {
        public static MainForm instance;
        public Label lb1;
        #region Fields
        private readonly ExpenseManager _manager = new();
        private readonly List<Predicate<Entry>> _filters;
        private (decimal Income, decimal Expense) _total;
        private (decimal Income, decimal Expense) _visibleTotal;
        #endregion

        #region Constructor
        public MainForm()
        {
            _manager.LoadData();
            InitializeComponent();
            instance = this;
            lb1 = label1;

            _filters = new()
            {
                DateRangeFilter,
                TypeFilter,
                CategoryFilter,
            };
        }
        #endregion

        #region Methods
        private (decimal Income, decimal Expense) CalculateTotal(List<Entry> entries)
        {
            decimal income = 0, expense = 0;
            foreach (var e in entries)
            {
                if (e.IsIncome)
                {
                    income += e.Value;
                }
                if (e.IsExpense)
                {
                    expense += e.Value;
                }
            }
            return (income, expense);
        }

        #region Filter Methods
        private List<Entry> ApplyFilters()
        {
            List<Entry> output = new();
            foreach (var entry in _manager.Entries)
            {
                bool pass = true;
                foreach (var filter in _filters)
                {
                    pass = pass && filter(entry);
                }
                if (pass)
                    output.Add(entry);
            }
            _visibleTotal = CalculateTotal(output);
            UpdateVisibleSummary();
            return output;
        }

        private bool DateRangeFilter(Entry e)
        {
            if (!checkBoxFilterDateTime.Checked)
                return true;
            if (e.CreatedAt >= filterFromDateTime.Value && e.CreatedAt <= filterToDateTime.Value)
                return true;
            return false;
        }

        private bool TypeFilter(Entry e)
        {
            if (radioButtonAll.Checked)
                return true;
            if (radioButtonExpenses.Checked)
                return e.IsExpense;
            if (radioButtonIncome.Checked)
                return e.IsIncome;
            return false;
        }

        private bool CategoryFilter(Entry e)
        {
            if (comboBoxCategories.SelectedIndex == 0) // Show all categories
                return true;
            string categoryName = comboBoxCategories.SelectedItem.ToString()!;
            _manager.TryGetCategoryId(categoryName, out Guid id);
            if (e.CategoryId == id)
                return true;
            return false;
        }
        #endregion

        #region UI Utilities
        private void UpdateTitle()
        {
            if (_manager.DefaultDataFilePath != _manager.WorkingDataFilePath)
            {
                Text = $"Expense Manager @ {_manager.WorkingDataFilePath}";
                return;
            }
            Text = "Expense Manager";
        }

        private void PopulateListViewEntries()
        {
            List<Entry> entries = ApplyFilters();

            // Sort by date of creation
            entries.Sort((e1, e2) => e1.CreatedAt.CompareTo(e2.CreatedAt));

            listViewEntries.Items.Clear();
            for (int i = entries.Count - 1; i >= 0; i--)
            {
                Entry? entry = entries[i];
                var item = new ListViewItem(entry.Title);
                item.SubItems.Add($"{entry.Value} {_manager.CurrencySign}");
                item.SubItems.Add(entry.CreatedAt.ToString());
                _manager.TryGetCategoryName(entry.CategoryId, out string categoryName);
                item.SubItems.Add(categoryName);
                item.Tag = entry.Id;
                listViewEntries.Items.Add(item);
            }
        }

        private void PopulateComboBoxCategories()
        {
            comboBoxCategories.Items.Clear();
            comboBoxCategories.Items.Add("Show all");
            comboBoxCategories.SelectedIndex = 0;
            comboBoxCategories.Items.AddRange(_manager.Categories.Values.ToArray());
        }

        private void UpdateSummary()
        {
            labelSummary.Text = $"Summary: " +
                $"\u25bc {_total.Expense}{_manager.CurrencySign}   " +
                $"\u25b2 {_total.Income}{_manager.CurrencySign}   " +
                $"\u03a3 {_total.Income + _total.Expense}{_manager.CurrencySign}";
        }

        private void UpdateVisibleSummary()
        {
            labelVisibleSummary.Text = $"Filtered summary: " +
                $"\u25bc {_visibleTotal.Expense}{_manager.CurrencySign}   " +
                $"\u25b2{_visibleTotal.Income}{_manager.CurrencySign}   " +
                $"\u03a3 {_visibleTotal.Income + _visibleTotal.Expense}{_manager.CurrencySign}";
        }

        private void UpdateListViewAndSummary()
        {
            PopulateListViewEntries();
            _total = CalculateTotal(_manager.Entries);
            UpdateSummary();
        }
        #endregion

        #region Events
        private void MainForm_Load(object sender, EventArgs e)
        {
            PopulateComboBoxCategories();
            // Init DateTime pickers
            filterFromDateTime.Value = new DateTime(DateTime.UtcNow.AddMonths(-1).Ticks);
            filterToDateTime.Value = new DateTime(DateTime.UtcNow.Ticks);
            UpdateListViewAndSummary();
        }

        private void checkBoxFilterDateTime_CheckedChanged(object sender, EventArgs e)
        {
            labelFilterFrom.Enabled = checkBoxFilterDateTime.Checked;
            labelFilterTo.Enabled = checkBoxFilterDateTime.Checked;
            filterFromDateTime.Enabled = checkBoxFilterDateTime.Checked;
            filterToDateTime.Enabled = checkBoxFilterDateTime.Checked;

            PopulateListViewEntries();
        }

        private void buttonAddNewEntry_Click(object sender, EventArgs e)
        {
            var addNewEntryForm = new AddNewEntryForm(_manager);
            addNewEntryForm.ShowDialog();
            UpdateListViewAndSummary();
            _manager.SaveData();
        }

        private void comboBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateListViewEntries();
        }

        private void radioButtonAll_CheckedChanged(object sender, EventArgs e)
        {
            PopulateListViewEntries();
        }

        private void radioButtonIncome_CheckedChanged(object sender, EventArgs e)
        {
            PopulateListViewEntries();
        }

        private void radioButtonExpenses_CheckedChanged(object sender, EventArgs e)
        {
            PopulateListViewEntries();
        }

        private void filterFromDateTime_ValueChanged(object sender, EventArgs e)
        {
            PopulateListViewEntries();
        }

        private void filterToDateTime_ValueChanged(object sender, EventArgs e)
        {
            PopulateListViewEntries();
        }

        private void contextMenuStripEntry_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (listViewEntries.SelectedItems.Count < 1)
            {
                e.Cancel = true;
                return;
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Guid id = (Guid)listViewEntries.SelectedItems[0].Tag;

            EditExistingEntryForm editExistingEntryForm = new(_manager, id);
            editExistingEntryForm.ShowDialog();
            UpdateListViewAndSummary();
            _manager.SaveData();
        }

        private void showDescriptionMenuItem_Click(object sender, EventArgs e)
        {
            Guid id = (Guid)listViewEntries.SelectedItems[0].Tag;
            ShowDescriptionForm showDescriptionForm = new(_manager, id);
            showDescriptionForm.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to delete this entry?",
                "Warning",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                return;
            }

            _manager.RemoveEntry((Guid)listViewEntries.SelectedItems[0].Tag);
            UpdateListViewAndSummary();
            _manager.SaveData();
        }

        private void saveAsFileMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new()
            {
                InitialDirectory = Environment.CurrentDirectory,
                Filter = "json files (*.json) | *.json",
                FileName = "expense-manager-data.json",
                OverwritePrompt = true,
                AddExtension = true,
                DefaultExt = ".json",
                Title = "Save file"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                _manager.SaveDataTo(saveFileDialog.FileName);
                MessageBox.Show($"Successfully saved file to: {saveFileDialog.FileName}.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
            }
            UpdateListViewAndSummary();
            UpdateTitle();
        }

        private void openMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new()
            {
                InitialDirectory = Environment.CurrentDirectory,
                Filter = "json files (*.json) | *.json",
                FileName = "expense-manager-data.json",
                AddExtension = true,
                DefaultExt = ".json",
                Title = "Open file"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _manager.LoadDataFrom(openFileDialog.FileName);
                MessageBox.Show($"Successfully loaded data from: {openFileDialog.FileName}.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
            }
            UpdateListViewAndSummary();
            UpdateTitle();
        }

        private void manageCategoriesMenuItem_Click(object sender, EventArgs e)
        {
            ManageCategoriesForm manageCategoriesForm = new(_manager);
            manageCategoriesForm.ShowDialog();
            PopulateComboBoxCategories();
            UpdateListViewAndSummary();
            _manager.SaveData();
        }
        #endregion

        #endregion

        private void exportAsCsvMoreMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new()
            {
                InitialDirectory = Environment.CurrentDirectory,
                Filter = "csv files (*.csv) | *.csv",
                FileName = "expense-manager-export.csv",
                OverwritePrompt = true,
                AddExtension = true,
                DefaultExt = ".csv",
                Title = "Export data"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                _manager.SaveDataTo(saveFileDialog.FileName);
                MessageBox.Show($"Successfully saved file to: {saveFileDialog.FileName}.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );

                string data = "Title, Description, Value, Category name, Created at\n";
                foreach (var entry in _manager.Entries)
                {
                    _manager.TryGetCategoryName(entry.CategoryId, out string categoryName);
                    data += ($"{entry.Title}," +
                        $"{(string.IsNullOrWhiteSpace(entry.Description) ? "No description" : entry.Description)}," +
                        $"{entry.Value}," +
                        $"{categoryName}," +
                        $"{entry.CreatedAt}" +
                        $"\n");
                }
                using StreamWriter sw = new(saveFileDialog.FileName);
                sw.Write(data);
            }
        }

        private void optionsMoreMenuItem_Click(object sender, EventArgs e)
        {
            OptionsForm optionsForm = new(_manager);
            optionsForm.ShowDialog();
            UpdateListViewAndSummary();
            _manager.SaveData();
        }

        private void reportMenu_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("This action will open the Report.\n" +
                "Do you want to continue?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question))
            {
                try
                {
                    Charts charts = new Charts();
                    charts.ShowDialog();
                }
                catch (Exception)
                {
                    MessageBox.Show("Cannot open a \n" + MessageBoxButtons.OK + MessageBoxIcon.Warning);
                }
            }
        }

        private void listViewEntries_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 sc = new Form1();
            sc.Show();
            this.Hide();

        }



        private void btn_theme_Click(object sender, EventArgs e)
        {
            SettingsForm sf = new SettingsForm(this);
            sf.Show();

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}