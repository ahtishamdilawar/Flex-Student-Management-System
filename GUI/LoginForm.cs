using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class LoginForm : Form
    {
        public static bool VerifyLogin(Login user, string filepath)
        {
            string[] lines = File.ReadAllLines(@filepath);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(',');
                if (parts[0] == user.getUserName() && parts[1] == user.getPassword())
                {
                    return true;
                }
            }
            return false;
        }
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void lblusername_Click(object sender, EventArgs e)
        {


        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            Login user = new Login(txtusername.Text, txtpassword.Text);
            bool check = false;
            try
            {

                
                if (txtusername.Text == "")
                {
                    MessageBox.Show("Please, Enter UserName !!", "Error");

                }
                else if (txtpassword.Text == "")
                {
                    MessageBox.Show("Please, Enter Password !!", "Error");

                }
                else if (VerifyLogin(user, "E:\\OOP SEM PROJECT\\FLEX\\GUI\\text\\stdlogin.txt"))
                {
                    MessageBox.Show("Login Successful", "Login");                   
                    studentForm std = new studentForm();
                    
                    this.Hide();
                    std.Show();
                }
                else if(check = VerifyLogin(user, "E:\\OOP SEM PROJECT\\FLEX\\GUI\\text\\teacherlogin.txt"))
                {
                    MessageBox.Show("Login Successful", "Login");
                    
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(),"Error");
            }

        }


        private void lblforgor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please contact your administrator","Forgot Password");
        }

        private void lblforgor_MouseHover(object sender, EventArgs e)
        {
            lblforgor.Cursor = Cursors.Hand;
        }
    }

}
