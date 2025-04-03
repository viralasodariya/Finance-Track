namespace WinForms_Expense_Manager
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip = new MenuStrip();
            fileMenu = new ToolStripMenuItem();
            saveAsFileMenuItem = new ToolStripMenuItem();
            openMenuItem = new ToolStripMenuItem();
            categoriesMenu = new ToolStripMenuItem();
            manageCategoriesMenuItem = new ToolStripMenuItem();
            moreMenu = new ToolStripMenuItem();
            exportMoreMenuItem = new ToolStripMenuItem();
            exportAsCsvMoreMenuItem = new ToolStripMenuItem();
            optionsMoreMenuItem = new ToolStripMenuItem();
            reportMenu = new ToolStripMenuItem();
            profileToolStripMenuItem = new ToolStripMenuItem();
            filterFromDateTime = new DateTimePicker();
            filterToDateTime = new DateTimePicker();
            labelFilterFrom = new Label();
            labelFilterTo = new Label();
            labelFilter = new Label();
            checkBoxFilterDateTime = new CheckBox();
            radioButtonAll = new RadioButton();
            radioButtonIncome = new RadioButton();
            radioButtonExpenses = new RadioButton();
            labelFilterByType = new Label();
            labelFilterByCategory = new Label();
            comboBoxCategories = new ComboBox();
            labelActions = new Label();
            buttonAddNewEntry = new Button();
            listViewEntries = new ListView();
            columnHeaderTitle = new ColumnHeader();
            columnHeaderValue = new ColumnHeader();
            columnHeaderDate = new ColumnHeader();
            columnHeaderCategory = new ColumnHeader();
            contextMenuStripEntry = new ContextMenuStrip(components);
            showDescriptionMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            labelSummary = new Label();
            labelVisibleSummary = new Label();
            label1 = new Label();
            btn_theme = new Button();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            contextMenuStripEntry.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { fileMenu, categoriesMenu, moreMenu, reportMenu, profileToolStripMenuItem, logoutToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(7, 3, 0, 3);
            menuStrip.Size = new Size(870, 30);
            menuStrip.TabIndex = 0;
            // 
            // fileMenu
            // 
            fileMenu.DropDownItems.AddRange(new ToolStripItem[] { saveAsFileMenuItem, openMenuItem });
            fileMenu.Name = "fileMenu";
            fileMenu.Size = new Size(46, 24);
            fileMenu.Text = "File";
            // 
            // saveAsFileMenuItem
            // 
            saveAsFileMenuItem.Name = "saveAsFileMenuItem";
            saveAsFileMenuItem.Size = new Size(141, 26);
            saveAsFileMenuItem.Text = "Save as";
            saveAsFileMenuItem.Click += saveAsFileMenuItem_Click;
            // 
            // openMenuItem
            // 
            openMenuItem.Name = "openMenuItem";
            openMenuItem.Size = new Size(141, 26);
            openMenuItem.Text = "Open";
            openMenuItem.Click += openMenuItem_Click;
            // 
            // categoriesMenu
            // 
            categoriesMenu.DropDownItems.AddRange(new ToolStripItem[] { manageCategoriesMenuItem });
            categoriesMenu.Name = "categoriesMenu";
            categoriesMenu.Size = new Size(94, 24);
            categoriesMenu.Text = "Categories";
            // 
            // manageCategoriesMenuItem
            // 
            manageCategoriesMenuItem.Name = "manageCategoriesMenuItem";
            manageCategoriesMenuItem.Size = new Size(146, 26);
            manageCategoriesMenuItem.Text = "Manage";
            manageCategoriesMenuItem.Click += manageCategoriesMenuItem_Click;
            // 
            // moreMenu
            // 
            moreMenu.DropDownItems.AddRange(new ToolStripItem[] { exportMoreMenuItem, optionsMoreMenuItem });
            moreMenu.Name = "moreMenu";
            moreMenu.Size = new Size(58, 24);
            moreMenu.Text = "More";
            // 
            // exportMoreMenuItem
            // 
            exportMoreMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exportAsCsvMoreMenuItem });
            exportMoreMenuItem.Name = "exportMoreMenuItem";
            exportMoreMenuItem.Size = new Size(144, 26);
            exportMoreMenuItem.Text = "Export";
            // 
            // exportAsCsvMoreMenuItem
            // 
            exportAsCsvMoreMenuItem.Name = "exportAsCsvMoreMenuItem";
            exportAsCsvMoreMenuItem.Size = new Size(135, 26);
            exportAsCsvMoreMenuItem.Text = "As .csv";
            exportAsCsvMoreMenuItem.Click += exportAsCsvMoreMenuItem_Click;
            // 
            // optionsMoreMenuItem
            // 
            optionsMoreMenuItem.Name = "optionsMoreMenuItem";
            optionsMoreMenuItem.Size = new Size(144, 26);
            optionsMoreMenuItem.Text = "Options";
            optionsMoreMenuItem.Click += optionsMoreMenuItem_Click;
            // 
            // reportMenu
            // 
            reportMenu.Name = "reportMenu";
            reportMenu.Size = new Size(68, 24);
            reportMenu.Text = "Report";
            reportMenu.Click += reportMenu_Click;
            // 
            // profileToolStripMenuItem
            // 
            profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            profileToolStripMenuItem.Size = new Size(119, 24);
            profileToolStripMenuItem.Text = "Update Profile";
            profileToolStripMenuItem.Click += profileToolStripMenuItem_Click;
            // 
            // filterFromDateTime
            // 
            filterFromDateTime.Enabled = false;
            filterFromDateTime.Location = new Point(605, 133);
            filterFromDateTime.Margin = new Padding(3, 4, 3, 4);
            filterFromDateTime.Name = "filterFromDateTime";
            filterFromDateTime.Size = new Size(253, 27);
            filterFromDateTime.TabIndex = 0;
            filterFromDateTime.Value = new DateTime(2001, 1, 1, 0, 0, 0, 0);
            filterFromDateTime.ValueChanged += filterFromDateTime_ValueChanged;
            // 
            // filterToDateTime
            // 
            filterToDateTime.Enabled = false;
            filterToDateTime.Location = new Point(605, 192);
            filterToDateTime.Margin = new Padding(3, 4, 3, 4);
            filterToDateTime.Name = "filterToDateTime";
            filterToDateTime.Size = new Size(253, 27);
            filterToDateTime.TabIndex = 2;
            filterToDateTime.Value = new DateTime(2099, 12, 31, 0, 0, 0, 0);
            filterToDateTime.ValueChanged += filterToDateTime_ValueChanged;
            // 
            // labelFilterFrom
            // 
            labelFilterFrom.AutoSize = true;
            labelFilterFrom.Enabled = false;
            labelFilterFrom.Location = new Point(617, 109);
            labelFilterFrom.Name = "labelFilterFrom";
            labelFilterFrom.Size = new Size(81, 20);
            labelFilterFrom.TabIndex = 3;
            labelFilterFrom.Text = "Filter from:";
            // 
            // labelFilterTo
            // 
            labelFilterTo.AutoSize = true;
            labelFilterTo.Enabled = false;
            labelFilterTo.Location = new Point(617, 168);
            labelFilterTo.Name = "labelFilterTo";
            labelFilterTo.Size = new Size(63, 20);
            labelFilterTo.TabIndex = 4;
            labelFilterTo.Text = "Filter to:";
            // 
            // labelFilter
            // 
            labelFilter.AutoSize = true;
            labelFilter.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelFilter.Location = new Point(601, 36);
            labelFilter.Name = "labelFilter";
            labelFilter.Size = new Size(64, 28);
            labelFilter.TabIndex = 5;
            labelFilter.Text = "Filters";
            // 
            // checkBoxFilterDateTime
            // 
            checkBoxFilterDateTime.AutoSize = true;
            checkBoxFilterDateTime.Location = new Point(605, 80);
            checkBoxFilterDateTime.Margin = new Padding(3, 4, 3, 4);
            checkBoxFilterDateTime.Name = "checkBoxFilterDateTime";
            checkBoxFilterDateTime.Size = new Size(143, 24);
            checkBoxFilterDateTime.TabIndex = 6;
            checkBoxFilterDateTime.Text = "Filter date range.";
            checkBoxFilterDateTime.UseVisualStyleBackColor = true;
            checkBoxFilterDateTime.CheckedChanged += checkBoxFilterDateTime_CheckedChanged;
            // 
            // radioButtonAll
            // 
            radioButtonAll.AutoSize = true;
            radioButtonAll.Checked = true;
            radioButtonAll.Location = new Point(609, 267);
            radioButtonAll.Margin = new Padding(3, 4, 3, 4);
            radioButtonAll.Name = "radioButtonAll";
            radioButtonAll.Size = new Size(48, 24);
            radioButtonAll.TabIndex = 7;
            radioButtonAll.TabStop = true;
            radioButtonAll.Text = "All";
            radioButtonAll.UseVisualStyleBackColor = true;
            radioButtonAll.CheckedChanged += radioButtonAll_CheckedChanged;
            // 
            // radioButtonIncome
            // 
            radioButtonIncome.AutoSize = true;
            radioButtonIncome.Location = new Point(661, 267);
            radioButtonIncome.Margin = new Padding(3, 4, 3, 4);
            radioButtonIncome.Name = "radioButtonIncome";
            radioButtonIncome.Size = new Size(79, 24);
            radioButtonIncome.TabIndex = 8;
            radioButtonIncome.Text = "Income";
            radioButtonIncome.UseVisualStyleBackColor = true;
            radioButtonIncome.CheckedChanged += radioButtonIncome_CheckedChanged;
            // 
            // radioButtonExpenses
            // 
            radioButtonExpenses.AutoSize = true;
            radioButtonExpenses.Location = new Point(742, 267);
            radioButtonExpenses.Margin = new Padding(3, 4, 3, 4);
            radioButtonExpenses.Name = "radioButtonExpenses";
            radioButtonExpenses.Size = new Size(90, 24);
            radioButtonExpenses.TabIndex = 9;
            radioButtonExpenses.Text = "Expenses";
            radioButtonExpenses.UseVisualStyleBackColor = true;
            radioButtonExpenses.CheckedChanged += radioButtonExpenses_CheckedChanged;
            // 
            // labelFilterByType
            // 
            labelFilterByType.AutoSize = true;
            labelFilterByType.Location = new Point(605, 243);
            labelFilterByType.Name = "labelFilterByType";
            labelFilterByType.Size = new Size(98, 20);
            labelFilterByType.TabIndex = 10;
            labelFilterByType.Text = "Filter by type:";
            // 
            // labelFilterByCategory
            // 
            labelFilterByCategory.AutoSize = true;
            labelFilterByCategory.Location = new Point(607, 309);
            labelFilterByCategory.Name = "labelFilterByCategory";
            labelFilterByCategory.Size = new Size(127, 20);
            labelFilterByCategory.TabIndex = 11;
            labelFilterByCategory.Text = "Filter by category:";
            // 
            // comboBoxCategories
            // 
            comboBoxCategories.FormattingEnabled = true;
            comboBoxCategories.Location = new Point(607, 333);
            comboBoxCategories.Margin = new Padding(3, 4, 3, 4);
            comboBoxCategories.Name = "comboBoxCategories";
            comboBoxCategories.Size = new Size(247, 28);
            comboBoxCategories.TabIndex = 12;
            comboBoxCategories.SelectedIndexChanged += comboBoxCategories_SelectedIndexChanged;
            // 
            // labelActions
            // 
            labelActions.AutoSize = true;
            labelActions.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelActions.Location = new Point(601, 447);
            labelActions.Name = "labelActions";
            labelActions.Size = new Size(77, 28);
            labelActions.TabIndex = 13;
            labelActions.Text = "Actions";
            // 
            // buttonAddNewEntry
            // 
            buttonAddNewEntry.Location = new Point(608, 479);
            buttonAddNewEntry.Margin = new Padding(3, 4, 3, 4);
            buttonAddNewEntry.Name = "buttonAddNewEntry";
            buttonAddNewEntry.Size = new Size(248, 76);
            buttonAddNewEntry.TabIndex = 14;
            buttonAddNewEntry.Text = "Add new entry";
            buttonAddNewEntry.UseVisualStyleBackColor = true;
            buttonAddNewEntry.Click += buttonAddNewEntry_Click;
            // 
            // listViewEntries
            // 
            listViewEntries.Alignment = ListViewAlignment.Default;
            listViewEntries.AutoArrange = false;
            listViewEntries.Columns.AddRange(new ColumnHeader[] { columnHeaderTitle, columnHeaderValue, columnHeaderDate, columnHeaderCategory });
            listViewEntries.ContextMenuStrip = contextMenuStripEntry;
            listViewEntries.FullRowSelect = true;
            listViewEntries.GridLines = true;
            listViewEntries.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listViewEntries.Location = new Point(14, 36);
            listViewEntries.Margin = new Padding(3, 4, 3, 4);
            listViewEntries.MultiSelect = false;
            listViewEntries.Name = "listViewEntries";
            listViewEntries.Size = new Size(580, 517);
            listViewEntries.TabIndex = 15;
            listViewEntries.UseCompatibleStateImageBehavior = false;
            listViewEntries.View = View.Details;
            listViewEntries.SelectedIndexChanged += listViewEntries_SelectedIndexChanged;
            // 
            // columnHeaderTitle
            // 
            columnHeaderTitle.Text = "Title";
            columnHeaderTitle.Width = 100;
            // 
            // columnHeaderValue
            // 
            columnHeaderValue.Text = "Value";
            columnHeaderValue.Width = 100;
            // 
            // columnHeaderDate
            // 
            columnHeaderDate.Text = "Date";
            columnHeaderDate.Width = 150;
            // 
            // columnHeaderCategory
            // 
            columnHeaderCategory.Text = "Category";
            columnHeaderCategory.Width = 150;
            // 
            // contextMenuStripEntry
            // 
            contextMenuStripEntry.ImageScalingSize = new Size(20, 20);
            contextMenuStripEntry.Items.AddRange(new ToolStripItem[] { showDescriptionMenuItem, editToolStripMenuItem, deleteToolStripMenuItem });
            contextMenuStripEntry.Name = "contextMenuStripEntry";
            contextMenuStripEntry.Size = new Size(193, 76);
            contextMenuStripEntry.Text = "Entry Context Menu";
            contextMenuStripEntry.Opening += contextMenuStripEntry_Opening;
            // 
            // showDescriptionMenuItem
            // 
            showDescriptionMenuItem.Name = "showDescriptionMenuItem";
            showDescriptionMenuItem.Size = new Size(192, 24);
            showDescriptionMenuItem.Text = "Show description";
            showDescriptionMenuItem.Click += showDescriptionMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(192, 24);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(192, 24);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // labelSummary
            // 
            labelSummary.AutoSize = true;
            labelSummary.Location = new Point(14, 559);
            labelSummary.Name = "labelSummary";
            labelSummary.Size = new Size(74, 20);
            labelSummary.TabIndex = 16;
            labelSummary.Text = "Summary:";
            // 
            // labelVisibleSummary
            // 
            labelVisibleSummary.AutoSize = true;
            labelVisibleSummary.Location = new Point(14, 581);
            labelVisibleSummary.Name = "labelVisibleSummary";
            labelVisibleSummary.Size = new Size(126, 20);
            labelVisibleSummary.TabIndex = 17;
            labelVisibleSummary.Text = "Filtered summary:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(790, 574);
            label1.Name = "label1";
            label1.Size = new Size(0, 28);
            label1.TabIndex = 18;
            // 
            // btn_theme
            // 
            btn_theme.Location = new Point(764, 39);
            btn_theme.Name = "btn_theme";
            btn_theme.Size = new Size(94, 29);
            btn_theme.TabIndex = 19;
            btn_theme.Text = "Theme";
            btn_theme.UseVisualStyleBackColor = true;
            btn_theme.Click += btn_theme_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(70, 24);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 609);
            Controls.Add(btn_theme);
            Controls.Add(label1);
            Controls.Add(labelVisibleSummary);
            Controls.Add(labelSummary);
            Controls.Add(listViewEntries);
            Controls.Add(buttonAddNewEntry);
            Controls.Add(labelActions);
            Controls.Add(comboBoxCategories);
            Controls.Add(labelFilterByCategory);
            Controls.Add(labelFilterByType);
            Controls.Add(radioButtonExpenses);
            Controls.Add(radioButtonIncome);
            Controls.Add(radioButtonAll);
            Controls.Add(checkBoxFilterDateTime);
            Controls.Add(labelFilter);
            Controls.Add(labelFilterTo);
            Controls.Add(labelFilterFrom);
            Controls.Add(filterToDateTime);
            Controls.Add(filterFromDateTime);
            Controls.Add(menuStrip);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            Text = "Expense manager";
            Load += MainForm_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            contextMenuStripEntry.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem fileMenu;
        private ToolStripMenuItem saveAsFileMenuItem;
        private ToolStripMenuItem categoriesMenu;
        private ToolStripMenuItem manageCategoriesMenuItem;
        private ToolStripMenuItem moreMenu;
        private ToolStripMenuItem exportMoreMenuItem;
        private ToolStripMenuItem optionsMoreMenuItem;
        private DateTimePicker filterFromDateTime;
        private DateTimePicker filterToDateTime;
        private Label labelFilterFrom;
        private Label labelFilterTo;
        private Label labelFilter;
        private CheckBox checkBoxFilterDateTime;
        private RadioButton radioButtonAll;
        private RadioButton radioButtonIncome;
        private RadioButton radioButtonExpenses;
        private Label labelFilterByType;
        private Label labelFilterByCategory;
        private ComboBox comboBoxCategories;
        private Label labelActions;
        private Button buttonAddNewEntry;
        private ListView listViewEntries;
        private ColumnHeader columnHeaderTitle;
        private ColumnHeader columnHeaderValue;
        private ColumnHeader columnHeaderDate;
        private ColumnHeader columnHeaderCategory;
        private ContextMenuStrip contextMenuStripEntry;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem openMenuItem;
        private Label labelSummary;
        private Label labelVisibleSummary;
        private ToolStripMenuItem showDescriptionMenuItem;
        private ToolStripMenuItem exportAsCsvMoreMenuItem;
        private ToolStripMenuItem reportMenu;
        public Label label1;
        private ToolStripMenuItem profileToolStripMenuItem;
        private Button btn_theme;
        private ToolStripMenuItem logoutToolStripMenuItem;
    }
}