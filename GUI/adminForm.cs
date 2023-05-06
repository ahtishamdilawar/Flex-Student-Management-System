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

namespace GUI
{

    public partial class adminForm : Form
    {
        string stdFile = "E:\\OOP SEM PROJECT\\FLEX\\GUI\\text\\student.csv";
        string loginFile = "E:\\OOP SEM PROJECT\\FLEX\\GUI\\text\\stdlogin.txt";
        string teacherFile = "E:\\OOP SEM PROJECT\\FLEX\\GUI\\text\\teacher.csv";
        string teacherLoginFile = "E:\\OOP SEM PROJECT\\FLEX\\GUI\\text\\teacherlogin.txt";
        public adminForm()
        {
            InitializeComponent();
        }
        #region Student code
        ///////VIEW STUDENT DATA////
        ///////////////////////////
        //////////////////////////
        //RETURNS A DATATABLE WITH ALL STUDENT DATA IN IT
        public DataTable ShowStudentData()
        {

            DataTable dataTable = new DataTable();

            using (TextFieldParser parser = new TextFieldParser(stdFile))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");

                // FIRST ROW CONTAINS THE NAME OF FIELDS SO WE MAKE COLUMNS BASED ON IT
                if (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();
                    foreach (string field in fields)
                    {
                        dataTable.Columns.Add(field);
                    }
                }

                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();
                    dataTable.Rows.Add(fields);
                }
            }
            return dataTable;
        }
        ////////RETURN TABLE BASED ON DEPARTMENT or roll NO
        public DataTable ShowStudentData(string depname)
        {
            DataTable dataTable = new DataTable();
            bool check = false;
            using (TextFieldParser parser = new TextFieldParser(stdFile))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");

                // FIRST ROW CONTAINS THE NAME OF FIELDS SO WE MAKE COLUMNS BASED ON IT
                if (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();
                    foreach (string field in fields)
                    {
                        dataTable.Columns.Add(field);
                    }
                }

                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();
                    if (fields[3] == depname || fields[0] == depname)
                    {
                        check = true;
                        dataTable.Rows.Add(fields);
                    }
                }
                if (check == false)
                {
                    MessageBox.Show("No Student Found");
                }
            }

            return dataTable;
        }


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

        //WRITES THE UPDATED LIST OF STUDENTS TO THE FILE
        public static void WriteStudentsToCsv(string filename, List<Student> students)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine("Roll Number,First Name,Last Name,Department Name,Gender,Contact Number,Address,Qualification,Blood Group,Fee Status,Registration Date");

                foreach (Student s in students)
                {

                    writer.WriteLine($"{s.getRollNo()},{s.getFirstName()},{s.getLastName()},{s.getDepName()},{s.getGender()},{s.getContactNo()},{s.getAddress()},{s.getQualification()},{s.getBloodGroup()},{s.getFeeStatus()},{s.getRegDate()}");
                }
            }
        }
        //READS THE FILE AND RETURNS A LIST OF STUDENTS
        public List<Student> ReadStudentsFromCsv()
        {
            string filename = stdFile;
            List<Student> students = new List<Student>();
            string[] lines = File.ReadAllLines(filename);
            for (int i = 1; i < lines.Length; i++)
            {
                string[] fields = lines[i].Split(',');
                if (fields.Length >= 11)
                {
                    Student s = new Student();
                    s.setRollNo(fields[0]);
                    s.setFirstName(fields[1]);
                    s.setLastName(fields[2]);
                    s.setDepName(fields[3]);
                    if (fields[4].Length > 0)
                    {
                        s.setGender(fields[4][0]);
                    }
                    s.setContactNo(fields[5]);
                    s.setAddress(fields[6]);
                    s.setQualification(fields[7]);
                    s.setBloodGroup(fields[8]);
                    s.setFeeStatus(isPaid(fields[9]));
                    s.setRegDate(fields[10]);

                    students.Add(s);
                }
                else
                {
                    MessageBox.Show("Error in reading file");
                }
            }
            return students;
        }
        //VALIDATES IF PAID OR NOT PAID
        public static bool isPaid(string s)
        {
            if (s == "Paid")
                return true;
            else
                return false;
        }
        //GENERATE ROLL NUMBER
        public string RollNoGenerator()
        {
            string rollNo = "";
            string dep = depBox.SelectedItem.ToString();

            List<Student> students = ReadStudentsFromCsv();
            int last = 1;
            //count students of same department
            for (int i = 0; i < students.Count(); i++)
            {
                if (students[i].getDepName() == dep)
                {
                    last++;
                }
            }
            //generate roll number
            if (dep == "Computer Science")
            {
                rollNo = "CS-" + last.ToString("D4");
            }
            else if (dep == "Electric Engineering")
            {
                rollNo = "EE-" + last.ToString("D4");
            }
            else if (dep == "Software Engineering")
            {
                rollNo = "SE-" + last.ToString("D4");
            }
            else if (dep == "Business")
            {
                rollNo = "B-" + last.ToString("D4");
            }
            else if (dep == "Social Sciences")
            {
                rollNo = "SS-" + last.ToString("D4");
            }
            return rollNo;

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
                std.setRollNo(RollNoGenerator());
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

        public List<Teacher> ReadTeachersFromCsv()
        {
            string filename = teacherFile;

            List<Teacher> teachers = new List<Teacher>();
            string[] lines = File.ReadAllLines(filename);
            for (int i = 1; i < lines.Length; i++)
            {
                string[] fields = lines[i].Split(',');
                if (fields.Length < 11)
                {
                    Teacher t = new Teacher();
                    t.setTID(fields[0]);
                    t.setFirstName(fields[1]);
                    t.setLastName(fields[2]);
                    t.setDepName(fields[3]);
                    t.setGender(fields[4][0]);
                    t.setContactNo(fields[5]);
                    t.setAddress(fields[6]);
                    t.setQualification(fields[7]);
                    t.setSalary(fields[8]);
                    t.setRegDate(fields[9]);
                    teachers.Add(t);
                }
                else
                {
                    MessageBox.Show("Error in reading file");
                }
            }
            return teachers;
        }
        //WRITE TO TEACHER CSV FILE
        public static void WriteTeachersToCsv(string filename, List<Teacher> teachers)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine("TID,First Name,Last Name,Department Name,Gender,Contact Number,Address,Qualification,Salary,Registration Date");

                foreach (Teacher s in teachers)
                {

                    writer.WriteLine($"{s.getTID()},{s.getFirstName()},{s.getLastName()},{s.getDepName()},{s.getGender()},{s.getContactNo()},{s.getAddress()},{s.getQualification()},{s.getSalary()},{s.getRegDate()}");
                }
            }
        }

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
                teachers.Add(t);
                WriteTeachersToCsv(teacherFile, teachers);
                WriteUsernamePassToTxt(teacherLoginFile, t);
                MessageBox.Show("Teacher Added Successfully", "SUCESS");
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
        //RETURNS A DATATABLE WITH ALL TEACHER DATA IN IT
        public DataTable ShowTeacherData()
        {

            DataTable dataTable = new DataTable();

            using (TextFieldParser parser = new TextFieldParser(teacherFile))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");

                // FIRST ROW CONTAINS THE NAME OF FIELDS SO WE MAKE COLUMNS BASED ON IT
                if (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();
                    for (int i = 0; i < fields.Length; i++)
                    {
                        if (i == 1)
                        {
                            dataTable.Columns.Add("Name");
                        }
                        else if (i == 2)
                        {
                            //SKIP SO THERE IS NO COLUMN FOR last name
                        }
                        else
                        {
                            dataTable.Columns.Add(fields[i]);
                        }
                    }
                }

                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();
                    string[] fieldWithoutLastName = new string[fields.Length - 1];
                    for (int i = 0; i < fields.Length; i++)
                    {
                        if (i == 1)
                        {
                            fieldWithoutLastName[i] = fields[i] + " " + fields[i + 1];
                        }
                        else if (i == 2)
                        {
                            //SKIP as THERE IS NO COLUMN FOR last name
                        }
                        else
                        {
                            if (i > 2)
                                fieldWithoutLastName[i - 1] = fields[i];
                            else
                                fieldWithoutLastName[i] = fields[i];
                        }
                    }
                    dataTable.Rows.Add(fieldWithoutLastName);
                }
            }
            return dataTable;
        }
        //LOADS THE TEACHER DATA IN THE DATAGRIDVIEW
        private void adminForm_Load(object sender, EventArgs e)
        {
            dataGridView2.DataSource = ShowTeacherData();
        }





        ///////EDIT STUDENT DATA////
        ///////////////////////////
        //////////////////////////
        //private void editstdbtn_Click(object sender, EventArgs e)
        //{
        //    List<Student> students = ReadStudentsFromCsv();
        //    string rollNo = rollNoEdittxt.Text;
        //    bool check = false;
        //    int index = 0;
        //    for (int i = 0; i < students.Count(); i++)
        //    {
        //        if (students[i].getRollNo() == rollNo.ToUpper())
        //        {
        //            index = i;
        //            check = true;
        //            break;
        //        }
        //    }
        //    if (!check)
        //    {
        //        MessageBox.Show("No Student Found");
        //    }
        //    else
        //    {
        //        FNameEditTxt.Text = students[index].getFirstName();
        //        LNameEditTxt.Text = students[index].getLastName();
        //        ContactEditTxt.Text = students[index].getContactNo();
        //        AdressEditTxt.Text = students[index].getAddress();
        //        if (students[index].getFeeStatus() == "Paid")
        //        {
        //            PaidEditBtn.Checked = true;
        //        }
        //        else
        //        {
        //            unpaidbtn.Checked = true;
        //        }
        //    }
        //}

        //private void UpdateBtn_Click(object sender, EventArgs e)
        //{
        //    List<Student> students = ReadStudentsFromCsv();
        //    string rollNo = rollNoEdittxt.Text;
        //    bool check = false;
        //    int index = 0;
        //    for (int i = 0; i < students.Count(); i++)
        //    {
        //        if (students[i].getRollNo() == rollNo.ToUpper())
        //        {
        //            index = i;
        //            check = true;
        //            break;
        //        }
        //    }
        //    if (!check)
        //    {
        //        MessageBox.Show("No Student Found");
        //    }
        //    else
        //    {
        //        students[index].setFirstName(FNameEditTxt.Text);
        //        students[index].setLastName(LNameEditTxt.Text);
        //        students[index].setContactNo(ContactEditTxt.Text);
        //        students[index].setAddress(AdressEditTxt.Text);
        //        if (PaidEditBtn.Checked)
        //        {
        //            students[index].setFeeStatus(true);
        //        }
        //        else
        //        {
        //            students[index].setFeeStatus(false);
        //        }
        //        WriteStudentsToCsv(stdFile, students);
        //        MessageBox.Show("Student Updated");
        //    }


        //}








        #endregion
        public static void WriteUsernamePassToTxt(string filename, Student std)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine($"{std.getUserName()},{std.getPassword()}");
            }
        }


        public static void WriteUsernamePassToTxt(string filename, Teacher std)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine($"{std.getUserName()},{std.getPassword()}");
            }
        }


    }
}

