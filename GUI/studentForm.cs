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

namespace GUI
{
    public partial class studentForm : Form
    {
        public string std = "";
        public studentForm(string student)
        {
            InitializeComponent();
            std = student;
        }
        public studentForm()
        {
            InitializeComponent();
        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        //public JsonSerializer GetSerializer()
        //{
        //    var settings = new JsonSerializerSettings();
        //    settings.ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor;
        //    settings.ContractResolver = new ContractResolverWithPrivates();

        //    serializer = JsonSerializer.Create(settings);
        //}


        //public void AppendToCsv(Student student, string filePath)
        //{
        //    // Open the file for appending
        //    using (StreamWriter sw = new StreamWriter(filePath, true))
        //    {
        //        // Write the student data as a CSV string
        //        string csvLine = $"{student.getRollNo()},{student.getFirstName()},{student.getLastName()},{student.getDepName()},{student.getGender()},{student.getContactNo()},{student.getAddress()},{student.getQualification()},{student.getBloodGroup()},{student.getFeeStatus()},{student.getRegDate()}";
        //        sw.WriteLine(csvLine);
        //    }
        //}
        //USED TO CONVERT PAID OR NOT PAID TO BOOLEAN




        //public Student ReadFromCsv(string filePath, string rollNo)
        //{
        //    // Open the file for reading
        //    using (TextFieldParser parser = new TextFieldParser(filePath))
        //    {
        //        parser.TextFieldType = FieldType.Delimited;
        //        parser.SetDelimiters(",");

        //        // Read each line until we find the student with the specified roll number
        //        while (!parser.EndOfData)
        //        {
        //            string[] fields = parser.ReadFields();

        //            if (fields[0] == rollNo)
        //            {

        //                // Create a new student object from the CSV data
        //                Student student = new Student();
        //                student.setRollNo(fields[0]);
        //                student.setFirstName(fields[1]);
        //                student.setLastName(fields[2]);
        //                student.setDepName(fields[3]);
        //                student.setGender(Convert.ToChar(fields[4]));
        //                student.setContactNo(fields[5]);
        //                student.setAddress(fields[6]);
        //                student.setQualification(fields[7]);
        //                student.setBloodGroup(fields[8]);
        //                student.setFeeStatus(Convert.ToBoolean(isPaid(fields[9])));
        //                student.setRegDate(fields[10]);
        //                return student;
        //            }
        //        }

        //        // Student with specified roll number not found
        //        return null;
        //    }
        //}
        public static List<Student> ReadStudentsFromCsv(string filename)
        {
            List<Student> students = new List<Student>();
            string[] lines = File.ReadAllLines(filename);
            for (int i = 1; i < lines.Length; i++)
            {
                string[] fields = lines[i].Split(',');
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
               // s.setFeeStatus(isPaid(fields[9]));
                s.setRegDate(fields[10]);
                students.Add(s);
            }
            return students;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Student student = new Student();
            // student.setFirstName(textBox1.Text);
            string filename = "E:\\OOP SEM PROJECT\\FLEX\\GUI\\text\\student.csv";
            //AppendToCsv(student, filename);
            List<Student> students = new List<Student>();
            students = ReadStudentsFromCsv(filename);
            MessageBox.Show(students[1].getRegDate());
            //student = ReadFromCsv(filename, "123");
            button1.Text = students[1].getFirstName();
        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            //Student student = new Student();
            // student.setFirstName(textBox1.Text);
            string filename = "E:\\OOP SEM PROJECT\\FLEX\\GUI\\text\\student.csv";
            //AppendToCsv(student, filename);
            List<Student> students = new List<Student>();
            students = ReadStudentsFromCsv(filename);
           MessageBox.Show(students[0].getRegDate());
            //student = ReadFromCsv(filename, "123");
            button1.Text = students[1].getFirstName();
            Student s = new Student();
            s.setFirstName("BONDU222");
            s.setGender('M');
            s.setLastName("BON22D");
            s.setDepName("CS2");
            s.setContactNo("12342256789");
            s.setAddress("KARAC2222HI");
            s.setQualification("BS22CS");
            s.setBloodGroup("B22+");
            s.setRollNo("12223");
            s.setRegDate("12/22212/2012");
            students.Add(s);            
          //  WriteStudentsToCsv(filename, students);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           
        }
    }
}
