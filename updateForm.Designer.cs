namespace UpdateImage
{
    partial class Form1
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
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label1 = new Label();
            txtName = new TextBox();
            txtOldPass = new TextBox();
            label2 = new Label();
            textNewPass = new TextBox();
            label3 = new Label();
            submitBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(343, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(184, 170);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(569, 188);
            button1.Name = "button1";
            button1.Size = new Size(155, 34);
            button1.TabIndex = 1;
            button1.Text = "UploadPicture";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(260, 264);
            label1.Name = "label1";
            label1.Size = new Size(94, 25);
            label1.TabIndex = 2;
            label1.Text = "UserName";
            // 
            // txtName
            // 
            txtName.Location = new Point(412, 261);
            txtName.Name = "txtName";
            txtName.Size = new Size(188, 31);
            txtName.TabIndex = 3;
            // 
            // txtOldPass
            // 
            txtOldPass.Location = new Point(412, 317);
            txtOldPass.Name = "txtOldPass";
            txtOldPass.Size = new Size(188, 31);
            txtOldPass.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(250, 323);
            label2.Name = "label2";
            label2.Size = new Size(118, 25);
            label2.TabIndex = 4;
            label2.Text = "old Password";
            // 
            // textNewPass
            // 
            textNewPass.Location = new Point(412, 372);
            textNewPass.Name = "textNewPass";
            textNewPass.Size = new Size(188, 31);
            textNewPass.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(250, 378);
            label3.Name = "label3";
            label3.Size = new Size(127, 25);
            label3.TabIndex = 6;
            label3.Text = "New Password";
            // 
            // submitBtn
            // 
            submitBtn.Location = new Point(355, 442);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(112, 34);
            submitBtn.TabIndex = 8;
            submitBtn.Text = "Save";
            submitBtn.UseVisualStyleBackColor = true;
            submitBtn.Click += submitBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1155, 501);
            Controls.Add(submitBtn);
            Controls.Add(textNewPass);
            Controls.Add(label3);
            Controls.Add(txtOldPass);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Label label1;
        private TextBox txtName;
        private TextBox txtOldPass;
        private Label label2;
        private TextBox textNewPass;
        private Label label3;
        private Button submitBtn;
    }
}