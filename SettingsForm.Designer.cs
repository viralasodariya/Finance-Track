// Settings.Designer.cs
//using static System.Net.Mime.MediaTypeNames;
//using System.Windows.Forms;
//using System.Xml.Linq;

namespace WinForms_Expense_Manager
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private TrackBar trkFontSize;
        private Label lblFontSize;
        private Button btnSave;

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            trkFontSize = new TrackBar();
            lblFontSize = new Label();
            btnSave = new Button();
            grpTheme = new GroupBox();
            radDarkTheme = new RadioButton();
            radLightTheme = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)trkFontSize).BeginInit();
            grpTheme.SuspendLayout();
            SuspendLayout();
            // 
            // trkFontSize
            // 
            trkFontSize.Location = new Point(0, 0);
            trkFontSize.Name = "trkFontSize";
            trkFontSize.Size = new Size(104, 56);
            trkFontSize.TabIndex = 0;
            // 
            // lblFontSize
            // 
            lblFontSize.Location = new Point(0, 0);
            lblFontSize.Name = "lblFontSize";
            lblFontSize.Size = new Size(100, 23);
            lblFontSize.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(150, 260);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 30);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save Settings";
            // 
            // grpTheme
            // 
            grpTheme.Controls.Add(radLightTheme);
            grpTheme.Controls.Add(radDarkTheme);
            grpTheme.Location = new Point(12, 12);
            grpTheme.Name = "grpTheme";
            grpTheme.Size = new Size(311, 100);
            grpTheme.TabIndex = 0;
            grpTheme.TabStop = false;
            grpTheme.Text = "Theme";
            // 
            // radDarkTheme
            // 
            radDarkTheme.Location = new Point(180, 30);
            radDarkTheme.Name = "radDarkTheme";
            radDarkTheme.Size = new Size(104, 24);
            radDarkTheme.TabIndex = 1;
            radDarkTheme.Tag = "Dark";
            radDarkTheme.Text = "Dark Theme";
            // 
            // radLightTheme
            // 
            radLightTheme.Location = new Point(20, 30);
            radLightTheme.Name = "radLightTheme";
            radLightTheme.Size = new Size(104, 24);
            radLightTheme.TabIndex = 0;
            radLightTheme.Tag = "Light";
            radLightTheme.Text = "Light Theme";
            // 
            // SettingsForm
            // 
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(382, 253);
            Controls.Add(grpTheme);
            Controls.Add(btnSave);
            Name = "SettingsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)trkFontSize).EndInit();
            grpTheme.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpTheme;
        private RadioButton radLightTheme;
        private RadioButton radDarkTheme;
    }
}