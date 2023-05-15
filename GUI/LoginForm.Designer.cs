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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblusername
            // 
            lblusername.AutoSize = true;
            lblusername.BackColor = Color.FromArgb(224, 224, 224);
            lblusername.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblusername.Location = new Point(30, 122);
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
            lblpassword.Location = new Point(33, 164);
            lblpassword.Name = "lblpassword";
            lblpassword.Size = new Size(70, 17);
            lblpassword.TabIndex = 1;
            lblpassword.Text = "Password:";
            // 
            // txtusername
            // 
            txtusername.Location = new Point(130, 116);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(135, 23);
            txtusername.TabIndex = 2;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(130, 163);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(135, 23);
            txtpassword.TabIndex = 3;
            // 
            // lblforgor
            // 
            lblforgor.AutoSize = true;
            lblforgor.Font = new Font("Segoe UI", 8.25F, FontStyle.Underline, GraphicsUnit.Point);
            lblforgor.Location = new Point(194, 189);
            lblforgor.Name = "lblforgor";
            lblforgor.Size = new Size(99, 13);
            lblforgor.TabIndex = 4;
            lblforgor.Text = "Forgot Password?";
            lblforgor.Click += lblforgor_Click;
            lblforgor.MouseHover += lblforgor_MouseHover;
            // 
            // btnlogin
            // 
            btnlogin.Location = new Point(130, 219);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(110, 26);
            btnlogin.TabIndex = 5;
            btnlogin.Text = "OK";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(304, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(518, 423);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(834, 447);
            Controls.Add(pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
    }
}