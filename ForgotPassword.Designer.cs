namespace WinForms_Expense_Manager
{
    partial class ForgotPassword
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "ForgotPass";
            label1 = new Label();
            label2 = new Label();
            txtPassword = new TextBox();
            txtConPass = new TextBox();
            btn_save = new Button();
            txtEmail = new TextBox();
            eyePass = new Label();
            eyeConfirm = new Label();

            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(45, 70);
            label1.Name = "label1";
            label1.Size = new Size(97, 28);
            label1.TabIndex = 0;
            label1.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(45, 127);
            label2.Name = "label2";
            label2.Size = new Size(176, 28);
            label2.TabIndex = 1;
            label2.Text = "Confirm Password";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(246, 70);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(191, 34);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;


            // 
            // txtConPass
            // 
            txtConPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtConPass.Location = new Point(246, 131);
            txtConPass.Name = "txtConPass";
            txtConPass.Size = new Size(191, 34);
            txtConPass.TabIndex = 3;
            txtConPass.UseSystemPasswordChar = true;


            // txtEmail
            // 
            // 
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(45, 12);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(392, 34);
            txtEmail.TabIndex = 6;

            // 
            // eyePass
            // 
            eyePass.AutoSize = true;
            eyePass.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            eyePass.Location = new Point(434, 71);
            eyePass.Name = "eyePass";
            eyePass.Size = new Size(47, 31);
            eyePass.TabIndex = 36;
            eyePass.Text = "👁️‍🗨️";
            eyePass.Click += eyePass_Click;

            // 
            // eyeConfirm
            // 
            eyeConfirm.AutoSize = true;
            eyeConfirm.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            eyeConfirm.Location = new Point(434, 131);
            eyeConfirm.Name = "eyeConfirm";
            eyeConfirm.Size = new Size(47, 31);
            eyeConfirm.TabIndex = 37;
            eyeConfirm.Text = "👁️‍🗨️";
            eyeConfirm.Click += eyeConfirm_Click;

            // 
            // btn_save
            // 
            btn_save.BackColor = SystemColors.ActiveCaption;
            btn_save.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_save.Location = new Point(45, 197);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(106, 39);
            btn_save.TabIndex = 5;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // ForgetPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 338);
            Controls.Add(txtEmail);

            Controls.Add(btn_save);
            Controls.Add(txtConPass);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(eyePass);
            Controls.Add(eyeConfirm);
            Name = "ForgotPassword";
            Text = "ForgotPassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtPassword;
        private TextBox txtConPass;
        private Button btn_save;
        private TextBox txtEmail;
        private Label eyePass;

        private Label eyeConfirm;
    }
}