using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GUI
{

    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            lblusername = new Label();
            lblpassword = new Label();
            txtusername = new TextBox();
            txtpassword = new TextBox();
            lblforgor = new Label();
            btnlogin = new Button();
            SuspendLayout();
            // 
            // lblusername
            // 
            lblusername.AutoSize = true;
            lblusername.BackColor = Color.FromArgb(224, 224, 224);
            lblusername.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblusername.Location = new Point(114, 87);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(73, 17);
            lblusername.TabIndex = 0;
            lblusername.Text = "Username:";
            lblusername.Click += lblusername_Click;
            // 
            // lblpassword
            // 
            lblpassword.AutoSize = true;
            lblpassword.BackColor = Color.FromArgb(224, 224, 224);
            lblpassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblpassword.Location = new Point(117, 129);
            lblpassword.Name = "lblpassword";
            lblpassword.Size = new Size(70, 17);
            lblpassword.TabIndex = 1;
            lblpassword.Text = "Password:";
            // 
            // txtusername
            // 
            txtusername.Location = new Point(214, 81);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(135, 23);
            txtusername.TabIndex = 2;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(214, 128);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(135, 23);
            txtpassword.TabIndex = 3;
            // 
            // lblforgor
            // 
            lblforgor.AutoSize = true;
            lblforgor.Font = new Font("Segoe UI", 8.25F, FontStyle.Underline, GraphicsUnit.Point);
            lblforgor.Location = new Point(278, 154);
            lblforgor.Name = "lblforgor";
            lblforgor.Size = new Size(99, 13);
            lblforgor.TabIndex = 4;
            lblforgor.Text = "Forgot Password?";
            lblforgor.Click += lblforgor_Click;
            lblforgor.MouseHover += lblforgor_MouseHover;
            // 
            // btnlogin
            // 
            btnlogin.Location = new Point(214, 184);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(110, 26);
            btnlogin.TabIndex = 5;
            btnlogin.Text = "OK";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(468, 381);
            Controls.Add(btnlogin);
            Controls.Add(lblforgor);
            Controls.Add(txtpassword);
            Controls.Add(txtusername);
            Controls.Add(lblpassword);
            Controls.Add(lblusername);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Flex Management System";
            TransparencyKey = Color.FromArgb(64, 64, 64);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblusername;
        private Label lblpassword;
        private TextBox txtusername;
        private TextBox txtpassword;
        private Label lblforgor;
        private Button btnlogin;
    }
}