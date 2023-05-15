using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
using static General.FLEXsharp;
namespace GUI
{
    public partial class studentForm : Form
    {
        public string RollNo = "";
        public studentForm(string student)
        {
            InitializeComponent();
            RollNo = student;
        }
        public studentForm()
        {
            InitializeComponent();
        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click_1(object sender, EventArgs e)
        {


        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void studentForm_Load(object sender, EventArgs e)
        {
            //DISPLAY ALL DATA OF Student
            List<Student> students = ReadStudentsFromCsv();
            bool check = false;
            int index = 0;
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].getRollNo() == RollNo)
                {
                    check = true;
                    index = i;
                    break;
                }
            }
            if (!check)
            {
                MessageBox.Show("Student not found");
                this.Close();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
            else
            {
                FNameTeacherTxt.Text = students[index].getFirstName();
                lastNameTeacherTxt.Text = students[index].getLastName();
                ContactTeacherTxt.Text = students[index].getContactNo();
                DepTeacherTxt.Text = students[index].getDepName();
                QualificationTeacherTxt.Text = students[index].getQualification();
                AdressTeacherTxt.Text = students[index].getAddress();
                bloodGrptxt.Text = students[index].getBloodGroup();
                if (students[index].getGender() == 'M')
                {
                    genderTxt.Text = "Male";
                }
                else
                {
                    genderTxt.Text = "Female";
                }
                setAttendanceComboBox();
                setmarksComboBox();
                setRegisteredCourse();
                if (students[index].getFeeStatus() == "Paid")
                {
                    label2.Text = "Paid";
                }
                else
                {
                    label2.Text = "Not Paid";
                }
                //attendanceCourseBox.SelectedIndex = 0;
            }


        }

        bool checkRollNo(string rollNo, string filepath)
        {
            StreamReader sr = new StreamReader(filepath);
            string line = sr.ReadLine();
            while (line != null)
            {
                string[] arr = line.Split(',');
                if (arr[0] == rollNo)
                {
                    return true;
                }
                line = sr.ReadLine();
            }
            return false;
        }

        void setRegisteredCourse()
        {
            if (checkRollNo(RollNo, marksFile + "DLD.csv"))
            {
                label1.Text = "DLD";
            }
            if (checkRollNo(RollNo, marksFile + "OOP.csv"))
            {
                label1.Text += "\nOOP";
            }
            if (checkRollNo(RollNo, marksFile + "Calculus.csv"))
            {
                label1.Text += "\nCalculus";
            }
            if (checkRollNo(RollNo, marksFile + "LA.csv"))
            {
                label1.Text += "\nLA";
            }
            if (checkRollNo(RollNo, marksFile + "PF.csv"))
            {
                label1.Text += "\nPF";
            }
        }

        void setmarksComboBox()
        {

            if (checkRollNo(RollNo, marksFile + "DLD.csv"))
            {
                marksCourseBox.Items.Add("DLD");
            }
            if (checkRollNo(RollNo, marksFile + "OOP.csv"))
            {
                marksCourseBox.Items.Add("OOP");
            }
            if (checkRollNo(RollNo, marksFile + "Calculus.csv"))
            {
                marksCourseBox.Items.Add("Calculus");
            }
            if (checkRollNo(RollNo, marksFile + "LA.csv"))
            {
                marksCourseBox.Items.Add("LA");
            }
            if (checkRollNo(RollNo, marksFile + "PF.csv"))
            {
                marksCourseBox.Items.Add("PF");
            }
        }
        void setAttendanceComboBox()
        {

            if (checkRollNo(RollNo, attendanceFile + "DLDA.csv"))
            {
                attendanceCourseBox.Items.Add("DLD");
            }
            if (checkRollNo(RollNo, attendanceFile + "OOPA.csv"))
            {
                attendanceCourseBox.Items.Add("OOP");
            }
            if (checkRollNo(RollNo, attendanceFile + "CalculusA.csv"))
            {
                attendanceCourseBox.Items.Add("Calculus");
            }
            if (checkRollNo(RollNo, attendanceFile + "LAA.csv"))
            {
                attendanceCourseBox.Items.Add("LA");
            }
            if (checkRollNo(RollNo, attendanceFile + "PFA.csv"))
            {
                attendanceCourseBox.Items.Add("PF");
            }
        }

        private void attendanceCourseBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView3.DataSource = AttendanceTableRollNo(attendanceCourseBox.SelectedItem.ToString(), RollNo);
        }

        private void marksCourseBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView4.DataSource = MarksRollNo(marksCourseBox.SelectedItem.ToString(), RollNo);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }

}
