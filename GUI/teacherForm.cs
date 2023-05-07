using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static General.FLEXsharp;
using static General.FLEXsharp.Timetable;
namespace GUI
{
    public partial class teacherForm : Form
    {
        public string ID = "CST-0002";
        public teacherForm()
        {
            InitializeComponent();
        }
        public teacherForm(string ID)
        {
            this.ID = ID;
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void teacherForm_Load(object sender, EventArgs e)
        {
            //DISPLAY ALL DATA OF TEACHER
            List<Teacher> teachers = ReadTeachersFromCsv();
            bool check = false;
            int index = 0;
            for (int i = 0; i < teachers.Count; i++)
            {
                if (teachers[i].getTID() == ID)
                {
                    check = true;
                    index = i;
                    break;
                }
            }
            if (!check)
            {
                MessageBox.Show("Teacher not found");
                this.Close();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
            else
            {
                FNameTeacherTxt.Text = teachers[index].getFirstName();
                lastNameTeacherTxt.Text = teachers[index].getLastName();
                ContactTeacherTxt.Text = teachers[index].getContactNo();
                DepTeacherTxt.Text = teachers[index].getDepName();
                QualificationTeacherTxt.Text = teachers[index].getQualification();
                AdressTeacherTxt.Text = teachers[index].getAddress();
                salaryTxt.Text = "Rs. " + teachers[index].getSalary();
                if (teachers[index].getGender() == 'M')
                {
                    genderTxt.Text = "Male";
                }
                else
                {
                    genderTxt.Text = "Female";

                }


            }
            //SET DATAGRID VIEW TO TIMETABLE
            dataGridView1.DataSource = ShowTimetable(teachers[index].getDepName());


        }

        private void QualificationTeacherTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
