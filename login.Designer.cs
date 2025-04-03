namespace WinForms_Expense_Manager
{
    partial class Login
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
            groupBox1 = new GroupBox();
            linkLabel_forgot = new LinkLabel();
            eyePass = new Label();
            label3 = new Label();
            linkLabel_signup = new LinkLabel();
            btn_login = new Button();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(linkLabel_forgot);
            groupBox1.Controls.Add(eyePass);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(linkLabel_signup);
            groupBox1.Controls.Add(btn_login);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(186, 91);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(452, 387);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login";
            // 
            // linkLabel_forgot
            // 
            linkLabel_forgot.AutoSize = true;
            linkLabel_forgot.Location = new Point(37, 321);
            linkLabel_forgot.Name = "linkLabel_forgot";
            linkLabel_forgot.Size = new Size(125, 20);
            linkLabel_forgot.TabIndex = 7;
            linkLabel_forgot.TabStop = true;
            linkLabel_forgot.Text = "Forgot Password?";
            linkLabel_forgot.LinkClicked += linkLabel_forgot_LinkClicked;
            // 
            // eyePass
            // 
            eyePass.AutoSize = true;
            eyePass.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            eyePass.Location = new Point(399, 171);
            eyePass.Name = "eyePass";
            eyePass.Size = new Size(47, 31);
            eyePass.TabIndex = 36;
            eyePass.Text = "👁️‍🗨️";
            eyePass.Click += eyePass_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(35, 286);
            label3.Name = "label3";
            label3.Size = new Size(163, 23);
            label3.TabIndex = 6;
            label3.Text = "Create new account";
            // 
            // linkLabel_signup
            // 
            linkLabel_signup.AutoSize = true;
            linkLabel_signup.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel_signup.Location = new Point(193, 289);
            linkLabel_signup.Name = "linkLabel_signup";
            linkLabel_signup.Size = new Size(61, 20);
            linkLabel_signup.TabIndex = 5;
            linkLabel_signup.TabStop = true;
            linkLabel_signup.Text = "Sign up";
            linkLabel_signup.LinkClicked += linkLabel_signup_LinkClicked;
            // 
            // btn_login
            // 
            btn_login.BackColor = SystemColors.ActiveCaption;
            btn_login.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_login.Location = new Point(37, 230);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(106, 39);
            btn_login.TabIndex = 4;
            btn_login.Text = "Sign in";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(178, 168);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(218, 34);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(178, 106);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(218, 34);
            txtEmail.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(35, 168);
            label2.Name = "label2";
            label2.Size = new Size(97, 28);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(37, 106);
            label1.Name = "label1";
            label1.Size = new Size(60, 28);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 556);
            Controls.Add(groupBox1);
            Name = "Login";
            Text = "Login";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btn_login;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label label2;
        private Label label1;
        private Label label3;
        private LinkLabel linkLabel_signup;
        private LinkLabel linkLabel_forgot;
        private Label eyePass;

    }
}