using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{

    public class FLEXsharp
    {
        public static string stdFile = "E:\\OOP SEM PROJECT\\FLEX\\GUI\\text\\student.csv";
        public static string loginFile = "E:\\OOP SEM PROJECT\\FLEX\\GUI\\text\\stdlogin.txt";
        public static string teacherFile = "E:\\OOP SEM PROJECT\\FLEX\\GUI\\text\\teacher.csv";
        public static string teacherLoginFile = "E:\\OOP SEM PROJECT\\FLEX\\GUI\\text\\teacherlogin.txt";
        public static string marksFile = "E:\\OOP SEM PROJECT\\FLEX\\GUI\\text\\Marks\\";
        public static string dldFile= "E:\\OOP SEM PROJECT\\FLEX\\GUI\\text\\Marks\\DLD.csv";
        //TIMETABLE CLASS
        public class Timetable
        {
            public static string timetableFile = "E:\\OOP SEM PROJECT\\FLEX\\GUI\\text\\timetables\\";
            private string Day { get; set; }
            public string Time { get; set; }
            public string Subject { get; set; }

            public Timetable(string day, string time, string subject)
            {
                Day = day;
                Time = time;
                Subject = subject;
            }

            //RETURNS DATATABLE ON BASIS OF DEPARTMENT NAME OF TEACHER
            public static DataTable ShowTimetable(string depName)
            {
                DataTable dataTable = new DataTable();
                using (TextFieldParser parser = new TextFieldParser(timetableFile + depName + ".csv"))
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");
                    // FIRST ROW CONTAINS THE NAME OF FIELDS SO WE MAKE COLUMNS BASED ON IT
                    if (!parser.EndOfData)
                    {
                        string[] fields = parser.ReadFields();
                        for (int i = 0; i < fields.Length; i++)
                        {
                            dataTable.Columns.Add(fields[i]);
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




        }
      
        //COURSE CLASS WITH MARKS INLCLUDES MARKS
        public class Course
        {
            public string rollNo;
            public string courseName;
            public char grade;
            public int marks;
            public Course()
            {
                rollNo = string.Empty;
                courseName = string.Empty;               
                grade = 'I';
                marks = 0;
            }


        }
        //
        


        //MARKS
        public static DataTable ShowMarks(string course)
        {
            DataTable dataTable = new DataTable();
            course=course+".csv";
            using (TextFieldParser parser = new TextFieldParser(marksFile+course))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                // FIRST ROW CONTAINS THE NAME OF FIELDS SO WE MAKE COLUMNS BASED ON IT
                if (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();
                    for (int i = 0; i < fields.Length; i++)
                    {
                        dataTable.Columns.Add(fields[i]);
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
        
        public static void WriteMarksToCsv(string course,DataTable table)
        {
            string filePath = marksFile + course + ".csv";
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                // Write the column headers
                foreach (DataColumn column in table.Columns)
                {
                    writer.Write($"{column.ColumnName},");
                }
                writer.WriteLine();

                // Write the rows
                foreach (DataRow row in table.Rows)
                {
                    foreach (var item in row.ItemArray)
                    {
                        writer.Write($"{item},");
                    }
                    writer.WriteLine();
                }
            }
        }






       
        public static List<Teacher> ReadTeachersFromCsv()
        {
            string filename = teacherFile;

            List<Teacher> teachers = new List<Teacher>();
            string[] lines = File.ReadAllLines(filename);
            for (int i = 1; i < lines.Length; i++)
            {
                string[] fields = lines[i].Split(',');
                if (fields.Length <= 11)
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
                    t.setCourse(fields[10]);
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
                writer.WriteLine("TID,First Name,Last Name,Department Name,Gender,Contact Number,Address,Qualification,Salary,Registration Date,Course");

                foreach (Teacher s in teachers)
                {

                    writer.WriteLine($"{s.getTID()},{s.getFirstName()},{s.getLastName()},{s.getDepName()},{s.getGender()},{s.getContactNo()},{s.getAddress()},{s.getQualification()},{s.getSalary()},{s.getRegDate()},{s.getCourse()}");
                }
            }
        }
        //RETURNS A DATATABLE WITH ALL TEACHER DATA IN IT
        public static DataTable ShowTeacherData()
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

        //WRITE TEACHER TO CSV FILE USERNAME PASSWORD
        public static void WriteUsernamePassToTxt(string filename, Teacher std)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine($"{std.getUserName()},{std.getPassword()}");
            }
        }



        //READS THE FILE AND RETURNS A LIST OF STUDENTS
        public static List<Student> ReadStudentsFromCsv()
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
        public static string RollNoGenerator(string dep)
        {
            string rollNo = "";

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

        ///////VIEW STUDENT DATA////
        ///////////////////////////
        //////////////////////////
        //RETURNS A DATATABLE WITH ALL STUDENT DATA IN IT
        public static DataTable ShowStudentData()
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
        public static DataTable ShowStudentData(string depname)
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
        //WRITE STUDENT USERNAME PASSWORD TO TXT FILE
        public static void WriteUsernamePassToTxt(string filename, Student std)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine($"{std.getUserName()},{std.getPassword()}");
            }
        }
        //WRITE USERNAME TO RESPECTIVE COURSE MARKS
        public static void WriteUsernameToMarks(string filename, string rollNo)
        {
            using (StreamWriter writer = new StreamWriter(filename,true))
            {
                writer.WriteLine($"{rollNo}");
            }
        }
    }
}
