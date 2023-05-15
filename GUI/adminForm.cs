using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static General.FLEXsharp;
using System.Runtime.Intrinsics.Arm;

namespace GUI
{

    public partial class adminForm : Form
    {

        public adminForm()
        {
            InitializeComponent();
        }
        #region Student code



        ///////EDIT STUDENT DATA////
        ///////////////////////////
        //////////////////////////
        private void editstdbtn_Click(object sender, EventArgs e)
        {
            List<Student> students = ReadStudentsFromCsv();
            string rollNo = rollNoEdittxt.Text;
            bool check = false;
            int index = 0;
            for (int i = 0; i < students.Count(); i++)
            {
                if (students[i].getRollNo() == rollNo.ToUpper())
                {
                    index = i;
                    check = true;
                    break;
                }
            }
            if (!check)
            {
                MessageBox.Show("No Student Found");
            }
            else
            {
                FNameEditTxt.Text = students[index].getFirstName();
                LNameEditTxt.Text = students[index].getLastName();
                ContactEditTxt.Text = students[index].getContactNo();
                AdressEditTxt.Text = students[index].getAddress();
                if (students[index].getFeeStatus() == "Paid")
                {
                    PaidEditBtn.Checked = true;
                }
                else
                {
                    unpaidbtn.Checked = true;
                }
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            List<Student> students = ReadStudentsFromCsv();
            string rollNo = rollNoEdittxt.Text;
            bool check = false;
            int index = 0;
            for (int i = 0; i < students.Count(); i++)
            {
                if (students[i].getRollNo() == rollNo.ToUpper())
                {
                    index = i;
                    check = true;
                    break;
                }
            }
            if (!check)
            {
                MessageBox.Show("No Student Found");
            }
            else
            {
                students[index].setFirstName(FNameEditTxt.Text);
                students[index].setLastName(LNameEditTxt.Text);
                students[index].setContactNo(ContactEditTxt.Text);
                students[index].setAddress(AdressEditTxt.Text);
                if (PaidEditBtn.Checked)
                {
                    students[index].setFeeStatus(true);
                }
                else
                {
                    students[index].setFeeStatus(false);
                }
                WriteStudentsToCsv(stdFile, students);
                MessageBox.Show("Student Updated");
            }


        }




        //SETS GENDER BASED ON RADIO BUTTON
        public char GenderCheck()
        {
            if (malebtn.Checked)
            {
                return 'M';
            }
            else if (femalebtn.Checked)
            {
                return 'F';
            }
            else
            {
                return 'O';
            }
        }
        //sets FEE STATUS BASED ON RADIO BUTTON
        public bool FeeStatusCheck()
        {
            if (paidbtn.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //CHECK IF FIELDS ARE EMPTY
        public bool CheckEmpty()
        {
            if (fnametxt.Text == "" || lNametxt.Text == "" || ContactTxt.Text == "" || qualiftxt.Text == "" || depBox.SelectedItem.ToString() == "" || bloodbox.SelectedItem.ToString() == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //RETURNS DEPARTMENT FILE NAME
        public string DepNameReturn()
        {

            if (depBox.SelectedItem.ToString() == "Computer Science")
            {
                return "CS";
            }
            else if (depBox.SelectedItem.ToString() == "Electric Engineering")
            {
                return "EE";
            }
            else if (depBox.SelectedItem.ToString() == "Software Engineering")
            {
                return "SE";
            }
            else if (depBox.SelectedItem.ToString() == "Business")
            {
                return "B";
            }
            else if (depBox.SelectedItem.ToString() == "Social Sciences")
            {
                return "SS";
            }
            else
            {
                return "ERROR";
            }


        }
        public void AddStudent()
        {
            while (CheckEmpty())
            {
                MessageBox.Show("Please fill all the fields");
                break;
            }
            if (CheckEmpty() == false)
            {
                // string dep = DepNameReturn();
                List<Student> students = ReadStudentsFromCsv();
                Student std = new Student();
                std.setRollNo(RollNoGenerator(depBox.SelectedItem.ToString()));
                std.setUserName(std.getRollNo());
                std.setPassword(std.getRollNo());
                std.setFirstName(fnametxt.Text);
                std.setLastName(lNametxt.Text);
                std.setContactNo(ContactTxt.Text);
                std.setDepName(depBox.SelectedItem.ToString());
                std.setQualification(qualiftxt.Text);
                std.setBloodGroup(bloodbox.SelectedItem.ToString());
                std.setGender(GenderCheck());
                std.setFeeStatus(FeeStatusCheck());
                std.setAddress(Adresstxt.Text);
                std.setRegDate(DateTime.Now.ToString("dd/MM/yyyy"));
                students.Add(std);
                WriteStudentsToCsv(stdFile, students);
                WriteUsernamePassToTxt(loginFile, std);
                MessageBox.Show("Student Added Successfully", "SUCESS");
                //ADD STUDENT TO COURSE FILE
                foreach (var item in courseBox.CheckedItems)
                {
                    if (item.ToString() == "DLD")
                    {
                        WriteUsernameToMarks(marksFile + "DLD.csv", std.getRollNo());

                    }
                    if (item.ToString() == "PF")
                    {
                        WriteUsernameToMarks(marksFile + "PF.csv", std.getRollNo());
                    }
                    if (item.ToString() == "Linear Algebra")
                    {
                        WriteUsernameToMarks(marksFile + "LA.csv", std.getRollNo());
                    }
                    if (item.ToString() == "Calculus")
                    {
                        WriteUsernameToMarks(marksFile + "Calculus.csv", std.getRollNo());
                    }
                    if (item.ToString() == "OOP")
                    {
                        WriteUsernameToMarks(marksFile + "OOP.csv", std.getRollNo());
                    }
                }
                //ADD student to attendance file
                foreach (var item in courseBox.CheckedItems)
                {
                    if (item.ToString() == "DLD")
                    {
                        WriteRollNoNameToAttendance(attendanceFile + "DLDA.csv", std.getRollNo(), std.getFirstName() + " " + std.getLastName());

                    }
                    if (item.ToString() == "PF")
                    {
                        WriteRollNoNameToAttendance(attendanceFile + "PFA.csv", std.getRollNo(), std.getFirstName() + " " + std.getLastName());
                    }
                    if (item.ToString() == "Linear Algebra")
                    {
                        WriteRollNoNameToAttendance(attendanceFile + "LAA.csv", std.getRollNo(), std.getFirstName() + " " + std.getLastName());
                    }
                    if (item.ToString() == "Calculus")
                    {
                        WriteRollNoNameToAttendance(attendanceFile + "CalculusA.csv", std.getRollNo(), std.getFirstName() + " " + std.getLastName());
                    }
                    if (item.ToString() == "OOP")
                    {
                        WriteRollNoNameToAttendance(attendanceFile + "OOPA.csv", std.getRollNo(), std.getFirstName() + " " + std.getLastName());
                    }
                }
            }



        }




        private void addStdBtn_Click(object sender, EventArgs e)
        {
            AddStudent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = ShowStudentData(rollNotxt.Text);
        }

        private void ViewStudent(object sender, EventArgs e)
        {

            depCombo.Visible = false;
            selectlbl.Visible = false;
            rollNolbl.Visible = false;
            rollNotxt.Visible = false;
            searchbtn.Visible = false;
            if (viewCombo.SelectedIndex == 1)
            {
                depCombo.Visible = true;
                selectlbl.Visible = true;
                if (depCombo.SelectedIndex == 0)
                {
                    selectlbl.Visible = false;
                }
            }
            else if (viewCombo.SelectedIndex == 0)
            {
                depCombo.Visible = false;
                selectlbl.Visible = false;
                dataGridView1.DataSource = ShowStudentData();
            }
            else if (viewCombo.SelectedIndex == 2)
            {
                depCombo.Visible = false;
                selectlbl.Visible = false;
                rollNolbl.Visible = true;
                rollNotxt.Visible = true;
                searchbtn.Visible = true;

            }
        }
        private void ViewDepStudent(object sender, EventArgs e)
        {
            selectlbl.Visible = false;
            if (depCombo.Visible == true)
            {
                selectlbl.Visible = true;
                dataGridView1.DataSource = ShowStudentData(depCombo.SelectedItem.ToString());

            }
            else
            {
                selectlbl.Visible = false;
            }
        }
        #endregion
        #region Teacher Code




        ////ADD Teacher

        private void AddTeacherbtn_Click(object sender, EventArgs e)
        {
            AddTeacher();
        }
        public void AddTeacher()
        {
            while (CheckEmptyTeacher())
            {
                MessageBox.Show("Please fill all the fields");
                break;
            }
            if (CheckEmptyTeacher() == false)
            {
                //string dep = DepNameReturn();
                List<Teacher> teachers = ReadTeachersFromCsv();
                Teacher t = new Teacher();
                t.setTID(TIDGenerator());
                t.setUserName(t.getTID());
                t.setPassword(t.getTID());
                t.setFirstName(FNameTeacherTxt.Text);
                t.setLastName(lastNameTeacherTxt.Text);
                t.setContactNo(ContactTeacherTxt.Text);
                t.setDepName(depTeacherCombo.SelectedItem.ToString());
                t.setQualification(QualificationTeacherTxt.Text);
                t.setGender((MaleTeacherTxt.Checked == true) ? 'M' : 'F');
                t.setAddress(AdressTeacherTxt.Text);
                t.setSalary(salaryTxt.Text);
                t.setRegDate(DateTime.Now.ToString("dd/MM/yyyy"));
                t.setCourse(courseTxt.SelectedItem.ToString());
                teachers.Add(t);
                WriteTeachersToCsv(teacherFile, teachers);
                WriteUsernamePassToTxt(teacherLoginFile, t);
                MessageBox.Show("Teacher Added Successfully", "SUCESS");
                dataGridView2.DataSource = ShowTeacherData();//UPDATE THE VIEW TEACHER TABLE
            }
        }
        //GENERATE TEACHER ID
        public string TIDGenerator()
        {
            string TID = "";
            string dep = depTeacherCombo.SelectedItem.ToString();

            List<Teacher> teachers = ReadTeachersFromCsv();
            int last = 1;
            //count students of same department
            for (int i = 0; i < teachers.Count(); i++)
            {
                if (teachers[i].getDepName() == dep)
                {
                    last++;
                }
            }
            //generate TID
            if (dep == "Computer Science")
            {
                TID = "CST-" + last.ToString("D4");
            }
            else if (dep == "Electric Engineering")
            {
                TID = "EET-" + last.ToString("D4");
            }
            else if (dep == "Software Engineering")
            {
                TID = "SET-" + last.ToString("D4");
            }
            else if (dep == "Business")
            {
                TID = "BT-" + last.ToString("D4");
            }
            else if (dep == "Social Sciences")
            {
                TID = "SST-" + last.ToString("D4");
            }
            return TID;

        }

        //CHECK EMPTY FIELDS
        public bool CheckEmptyTeacher()
        {
            bool empty = false;
            if (FNameTeacherTxt.Text == "" || lastNameTeacherTxt.Text == "" || ContactTeacherTxt.Text == "" || QualificationTeacherTxt.Text == "" || AdressTeacherTxt.Text == "" || salaryTxt.Text == "")
            {
                empty = true;
            }
            return empty;
        }

        //LOADS THE TEACHER DATA IN THE DATAGRIDVIEW and All Student Data 
        //in the view student table
        private void adminForm_Load(object sender, EventArgs e)
        {
            dataGridView2.DataSource = ShowTeacherData();
            dataGridView1.DataSource = ShowStudentData();
            viewCombo.SelectedIndex = 0;
        }





        ///////EDIT TEACHER DATA////
        ///////////////////////////
        //////////////////////////

        private void FindEditTeacherBtn_Click(object sender, EventArgs e)
        {


            List<Teacher> teachers = ReadTeachersFromCsv();
            string TID = TIDEditTeacherTxt.Text;
            bool check1 = false;
            int index1 = 0;
            for (int i = 0; i < teachers.Count(); i++)
            {
                if (teachers[i].getTID() == TID.ToUpper())
                {
                    index1 = i;
                    check1 = true;
                    break;
                }
            }
            if (!check1)
            {
                MessageBox.Show("No Teacher Found");
            }
            else
            {
                FNameEditTeacherTxt.Text = teachers[index1].getFirstName();
                LNameEditTeacherTxt.Text = teachers[index1].getLastName();
                ContactEditTeacherTxt.Text = teachers[index1].getContactNo();
                AddressEditTeacherTxt.Text = teachers[index1].getAddress();
                QualificationEditTeacherTxt.Text = teachers[index1].getQualification();
                SalaryTeacherEditTxt.Text = teachers[index1].getSalary();
            }

        }

        private void UpdateEditTeacherBtn_Click(object sender, EventArgs e)
        {

            List<Teacher> teachers = ReadTeachersFromCsv();
            string TID = TIDEditTeacherTxt.Text;
            bool check1 = false;
            int index1 = 0;
            for (int i = 0; i < teachers.Count(); i++)
            {
                if (teachers[i].getTID() == TID.ToUpper())
                {
                    index1 = i;
                    check1 = true;
                    break;
                }
            }
            if (!check1)
            {
                MessageBox.Show("No Teacher Found");
            }
            else
            {
                teachers[index1].setFirstName(FNameEditTeacherTxt.Text);
                teachers[index1].setLastName(LNameEditTeacherTxt.Text);
                teachers[index1].setContactNo(ContactEditTeacherTxt.Text);
                teachers[index1].setAddress(AddressEditTeacherTxt.Text);
                teachers[index1].setQualification(QualificationEditTeacherTxt.Text);
                teachers[index1].setSalary(SalaryTeacherEditTxt.Text);
                WriteTeachersToCsv(teacherFile, teachers);
                MessageBox.Show("Teacher Updated");
                dataGridView2.DataSource = ShowTeacherData();//UPDATE THE VIEW TEACHER TABLE
            }


        }





        #endregion





        private void depBox_SelectedIndexChanged(object sender, EventArgs e)
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

