namespace WinForms_Expense_Manager
{
    partial class SignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            lblTitle = new Label();
            lblName = new Label();
            txtName = new TextBox();
            lblMobile = new Label();
            lblEmail = new Label();
            txtEmail = new TextBox();
            txtMobile = new TextBox();
            lblDoB = new Label();
            rdoMale = new RadioButton();
            rdoFemale = new RadioButton();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            gbGender = new GroupBox();
            lblAccount = new Label();
            btnRegister = new Button();
            pictureBox1 = new PictureBox();
            lblPicture = new Label();
            dateTimePicker1 = new DateTimePicker();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtConfirmPassword = new TextBox();
            lblConfirmPassword = new Label();
            chkTermsConditions = new CheckBox();
            lblArrow = new Label();
            linkLogIn = new LinkLabel();
            btnSendOtp = new Button();
            btnVerifyOtp = new Button();
            txtOtp = new TextBox();
            lblOtp = new Label();
            eyePass = new Label();
            eyeConfirm = new Label();
            gbGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(309, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(433, 81);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Register Now!";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold);
            lblName.Location = new Point(62, 246);
            lblName.Name = "lblName";
            lblName.Size = new Size(112, 46);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(379, 249);
            txtName.Name = "txtName";
            txtName.Size = new Size(551, 43);
            txtName.TabIndex = 2;
            // 
            // lblMobile
            // 
            lblMobile.AutoSize = true;
            lblMobile.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold);
            lblMobile.Location = new Point(62, 373);
            lblMobile.Name = "lblMobile";
            lblMobile.Size = new Size(127, 46);
            lblMobile.TabIndex = 5;
            lblMobile.Text = "Mobile";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold);
            lblEmail.Location = new Point(62, 309);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(104, 46);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(379, 312);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(551, 43);
            txtEmail.TabIndex = 11;
            // 
            // txtMobile
            // 
            txtMobile.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMobile.Location = new Point(379, 376);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(551, 43);
            txtMobile.TabIndex = 13;
            // 
            // lblDoB
            // 
            lblDoB.AutoSize = true;
            lblDoB.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold);
            lblDoB.Location = new Point(62, 564);
            lblDoB.Name = "lblDoB";
            lblDoB.Size = new Size(217, 46);
            lblDoB.TabIndex = 12;
            lblDoB.Text = "Date of Birth";
            // 
            // rdoMale
            // 
            rdoMale.AutoSize = true;
            rdoMale.Cursor = Cursors.Hand;
            rdoMale.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdoMale.Location = new Point(251, 29);
            rdoMale.Name = "rdoMale";
            rdoMale.Size = new Size(101, 42);
            rdoMale.TabIndex = 16;
            rdoMale.TabStop = true;
            rdoMale.Text = "Male";
            rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            rdoFemale.AutoSize = true;
            rdoFemale.Cursor = Cursors.Hand;
            rdoFemale.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdoFemale.Location = new Point(455, 29);
            rdoFemale.Name = "rdoFemale";
            rdoFemale.Size = new Size(129, 42);
            rdoFemale.TabIndex = 17;
            rdoFemale.TabStop = true;
            rdoFemale.Text = "Female";
            rdoFemale.UseVisualStyleBackColor = true;
            // 
            // gbGender
            // 
            gbGender.Controls.Add(rdoMale);
            gbGender.Controls.Add(rdoFemale);
            gbGender.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbGender.Location = new Point(62, 616);
            gbGender.Name = "gbGender";
            gbGender.Size = new Size(868, 77);
            gbGender.TabIndex = 18;
            gbGender.TabStop = false;
            gbGender.Text = "Gender";
            // 
            // lblAccount
            // 
            lblAccount.AutoSize = true;
            lblAccount.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccount.Location = new Point(60, 925);
            lblAccount.Name = "lblAccount";
            lblAccount.Size = new Size(298, 31);
            lblAccount.TabIndex = 19;
            lblAccount.Text = "Already have an Account??";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.CornflowerBlue;
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = SystemColors.Control;
            btnRegister.Location = new Point(408, 863);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(177, 47);
            btnRegister.TabIndex = 20;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveBorder;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Location = new Point(62, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(178, 145);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblPicture
            // 
            lblPicture.AutoSize = true;
            lblPicture.Location = new Point(62, 215);
            lblPicture.Name = "lblPicture";
            lblPicture.Size = new Size(167, 20);
            lblPicture.TabIndex = 22;
            lblPicture.Text = "Enter you Profile Picture";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(379, 567);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(551, 43);
            dateTimePicker1.TabIndex = 23;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(379, 441);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(504, 43);
            txtPassword.TabIndex = 25;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold);
            lblPassword.Location = new Point(62, 438);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(166, 46);
            lblPassword.TabIndex = 24;
            lblPassword.Text = "Password";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmPassword.Location = new Point(379, 503);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(504, 43);
            txtConfirmPassword.TabIndex = 27;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold);
            lblConfirmPassword.Location = new Point(62, 500);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(300, 46);
            lblConfirmPassword.TabIndex = 26;
            lblConfirmPassword.Text = "Confirm Password";
            // 
            // chkTermsConditions
            // 
            chkTermsConditions.AutoSize = true;
            chkTermsConditions.Cursor = Cursors.Hand;
            chkTermsConditions.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkTermsConditions.Location = new Point(62, 836);
            chkTermsConditions.Name = "chkTermsConditions";
            chkTermsConditions.Size = new Size(272, 35);
            chkTermsConditions.TabIndex = 29;
            chkTermsConditions.Text = "Terms and condititions";
            chkTermsConditions.UseVisualStyleBackColor = true;
            // 
            // lblArrow
            // 
            lblArrow.AutoSize = true;
            lblArrow.Cursor = Cursors.Hand;
            lblArrow.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblArrow.Location = new Point(323, 832);
            lblArrow.Name = "lblArrow";
            lblArrow.Size = new Size(39, 38);
            lblArrow.TabIndex = 30;
            lblArrow.Text = "↗️";
            lblArrow.Click += lblArrow_Click;
            // 
            // linkLogIn
            // 
            linkLogIn.AutoSize = true;
            linkLogIn.Cursor = Cursors.Hand;
            linkLogIn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLogIn.LinkColor = Color.DodgerBlue;
            linkLogIn.Location = new Point(355, 925);
            linkLogIn.Name = "linkLogIn";
            linkLogIn.Size = new Size(75, 31);
            linkLogIn.TabIndex = 31;
            linkLogIn.TabStop = true;
            linkLogIn.Text = "LogIn";
            linkLogIn.LinkClicked += linkLogIn_LinkClicked;
            // 
            // btnSendOtp
            // 
            btnSendOtp.BackColor = SystemColors.ControlLight;
            btnSendOtp.Cursor = Cursors.Hand;
            btnSendOtp.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSendOtp.ForeColor = SystemColors.ControlText;
            btnSendOtp.Location = new Point(205, 767);
            btnSendOtp.Name = "btnSendOtp";
            btnSendOtp.Size = new Size(167, 46);
            btnSendOtp.TabIndex = 32;
            btnSendOtp.Text = "Send OTP";
            btnSendOtp.UseVisualStyleBackColor = false;
            btnSendOtp.Click += btnSendOtp_Click;
            // 
            // btnVerifyOtp
            // 
            btnVerifyOtp.BackColor = SystemColors.ControlLight;
            btnVerifyOtp.Cursor = Cursors.Hand;
            btnVerifyOtp.Enabled = false;
            btnVerifyOtp.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerifyOtp.ForeColor = SystemColors.ControlText;
            btnVerifyOtp.Location = new Point(621, 767);
            btnVerifyOtp.Name = "btnVerifyOtp";
            btnVerifyOtp.Size = new Size(167, 46);
            btnVerifyOtp.TabIndex = 33;
            btnVerifyOtp.Text = "Verify OTP";
            btnVerifyOtp.UseVisualStyleBackColor = false;
            btnVerifyOtp.Click += btnVerifyOtp_Click;
            // 
            // txtOtp
            // 
            txtOtp.Enabled = false;
            txtOtp.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOtp.Location = new Point(379, 712);
            txtOtp.Name = "txtOtp";
            txtOtp.Size = new Size(551, 43);
            txtOtp.TabIndex = 35;
            // 
            // lblOtp
            // 
            lblOtp.AutoSize = true;
            lblOtp.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold);
            lblOtp.Location = new Point(62, 709);
            lblOtp.Name = "lblOtp";
            lblOtp.Size = new Size(84, 46);
            lblOtp.TabIndex = 34;
            lblOtp.Text = "OTP";
            // 
            // eyePass
            // 
            eyePass.AutoSize = true;
            eyePass.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            eyePass.Location = new Point(883, 449);
            eyePass.Name = "eyePass";
            eyePass.Size = new Size(47, 31);
            eyePass.TabIndex = 36;
            eyePass.Text = "👁️‍🗨️";
            eyePass.Click += eyePass_Click;
            // 
            // eyeConfirm
            // 
            eyeConfirm.AutoSize = true;
            eyeConfirm.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            eyeConfirm.Location = new Point(883, 511);
            eyeConfirm.Name = "eyeConfirm";
            eyeConfirm.Size = new Size(47, 31);
            eyeConfirm.TabIndex = 37;
            eyeConfirm.Text = "👁️‍🗨️";
            eyeConfirm.Click += eyeConfirm_Click;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(992, 998);
            Controls.Add(eyeConfirm);
            Controls.Add(eyePass);
            Controls.Add(txtOtp);
            Controls.Add(lblOtp);
            Controls.Add(btnVerifyOtp);
            Controls.Add(btnSendOtp);
            Controls.Add(linkLogIn);
            Controls.Add(lblArrow);
            Controls.Add(chkTermsConditions);
            Controls.Add(txtConfirmPassword);
            Controls.Add(lblConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblPicture);
            Controls.Add(pictureBox1);
            Controls.Add(btnRegister);
            Controls.Add(lblAccount);
            Controls.Add(gbGender);
            Controls.Add(lblTitle);
            Controls.Add(txtMobile);
            Controls.Add(lblDoB);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(lblMobile);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Registration";
            Text = "Registration";
            gbGender.ResumeLayout(false);
            gbGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private Label lblTitle;
        private Label lblName;
        private TextBox txtName;
        private Label lblMobile;
        private Label lblEmail;
        private TextBox txtEmail;
        private TextBox txtMobile;
        private Label lblDoB;
        private RadioButton rdoMale;
        private RadioButton rdoFemale;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox gbGender;
        private Label lblAccount;
        private Button btnRegister;
        private PictureBox pictureBox1;
        private Label lblPicture;
        private DateTimePicker dateTimePicker1;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtConfirmPassword;
        private Label lblConfirmPassword;
        private CheckBox chkTermsConditions;
        private Label lblArrow;
        private LinkLabel linkLogIn;
        private Button btnSendOtp;
        private Button btnVerifyOtp;
        private TextBox txtOtp;
        private Label lblOtp;
        private Label eyePass;
        private Label eyeConfirm;
    }
}