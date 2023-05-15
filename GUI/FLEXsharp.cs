using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static General.FLEXsharp;

namespace General
{

    public class FLEXsharp
    {
        public static string file="E:\\OOP SEM PROJECT\\FLEX\\GUI\\";
        public static string stdFile = file + "text\\student.csv";
        public static string loginFile = file +"text\\stdlogin.txt";
        public static string teacherFile = file+"text\\teacher.csv";
        public static string teacherLoginFile = file+"text\\teacherlogin.txt";
        public static string marksFile = file+"text\\Marks\\";
        public static string dldFile= file+"text\\Marks\\DLD.csv";
        public static string attendanceFile = file+"text\\Attendance\\";
        public static string timetableFile = file+ "text\\Timetables\\";
        //TIMETABLE CLASS

        public class AttendanceDate
        {
            public string date { get; set; }
            public List<Attendance> attendanceList { get; set; }
            public AttendanceDate()
            {
                date = string.Empty;
                attendanceList = new List<Attendance>();
            }
        }
        public class Attendance
        {
           
            public string rollNo { get; set; }
            public string name { get; set; }
            public bool present { get; set; }
            public Attendance()
            {
                rollNo = string.Empty;
                name = string.Empty;
                present = false;
            }
        }

        //RETURN DATATABLE OF ATTENDANCE OF A COURSE
        public static DataTable AttendanceTable(string course, string targetDate)
        {           
            DataTable dataTable = new DataTable();
            int Index=0;
            using (StreamReader sr = new StreamReader(attendanceFile + course + "A.csv"))
            {             
                
                    dataTable.Columns.Add("Roll NO");
                    dataTable.Columns.Add("Name");
                    dataTable.Columns.Add("Present",typeof(bool));
                   
                if(!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    for (int i = 0; i < fields.Length; i++)
                    {
                        if (fields[i]==targetDate)
                        {
                            Index = i;
                        }    
                    }
                }
                while (!sr.EndOfStream)
                {
                    string[] rows = sr.ReadLine().Split(',');
                    DataRow dataRow = dataTable.NewRow();
                    for (int i = 0; i < rows.Length; i++)
                    {
                        dataRow["Roll NO"] = rows[0];
                        dataRow["Name"] = rows[1];
                        if (rows[Index] == "True")
                        {
                            dataRow["Present"] = true;
                        }
                        else
                        {
                            dataRow["Present"] = false;
                        }
                    }
                    dataTable.Rows.Add(dataRow);
                }
            }

            return dataTable;


        }


        //RETURN DATATABLE OF ATTENDANCE OF A COURSE
        public static DataTable AttendanceTableRollNo(string course,string RollNo)
        {
            DataTable dataTable = new DataTable();
            
            using (StreamReader sr = new StreamReader(attendanceFile + course + "A.csv"))
            {

                dataTable.Columns.Add("DATE");
                dataTable.Columns.Add("Present", typeof(bool));
              
                if (!sr.EndOfStream)
                {
                    
                }
                string[] dates = sr.ReadLine().Split(',');
                while (!sr.EndOfStream)
                {
                    string[] rows = sr.ReadLine().Split(',');
                    if (rows[0]==RollNo)
                    {
                        for (int i = 2; i < rows.Length; i++)
                        {
                        DataRow dataRow = dataTable.NewRow();
                            if (rows[i] == "True")
                            {
                                dataRow["Present"] = true;
                            }
                            else
                            {
                                dataRow["Present"] = false;
                            }
                            dataRow["DATE"] = dates[i];
                        dataTable.Rows.Add(dataRow);
                        }
                    }


                }
            }

            return dataTable;


        }




        //WRITE ATTENDANCE TO CSV FILE
        public static void WriteAttendanceToCsv(string course, DataTable table)
        {
            string filePath = attendanceFile + course + "A.csv";
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                //// Write the column headers
                //for(int i=0;i<table.Columns.Count;i++)
                //{
                //    if(i==table.Columns.Count-1)
                //    {
                //        writer.Write($"{table.Columns[i].ColumnName}");
                //    }
                //    else
                //    {
                //        writer.Write($"{table.Columns[i].ColumnName},");
                //    }


                //   // writer.Write($"{table.Columns[i].ColumnName},");
                //}
                //writer.WriteLine();
                ////Write the rows
                //for(int i=0;i<table.Rows.Count;i++)
                //{
                //    for(int j=0;j<table.Columns.Count;j++)
                //    {
                //       if(j==table.Columns.Count-1)
                //       {
                //            writer.Write($"{table.Rows[i][j]}");
                //       }
                //       else
                //       {
                //            writer.Write($"{table.Rows[i][j]},");
                //       }

                      
                //    }
                //    writer.WriteLine();
                //}



                int count = table.Columns.Count;
                foreach (DataColumn column in table.Columns)
                {
                    if(count == 1)
                    {
                        writer.Write($"{column.ColumnName}");
                    }
                    else
                    {
                        writer.Write($"{column.ColumnName},");
                    }
                    count--;
                    //writer.Write($"{column.ColumnName},");
                }
                writer.WriteLine();

                // Write the rows
                foreach (DataRow row in table.Rows)
                {
                   
                          count = table.Columns.Count;

                     foreach (var item in row.ItemArray)
                     {
                          if (count == 1)
                          {
                              writer.Write($"{item}");
                          }
                          else
                          {
                              writer.Write($"{item},");
                          }
                        count--;
                     } 
                    
                   

                    


                    //foreach (var item in row.ItemArray)
                    //{
                    //    writer.Write($"{item},");
                    //}
                    writer.WriteLine();
                }
                writer.Close();
            }
            
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
                //// Write the column headers
                //foreach (DataColumn column in table.Columns)
                //{
                //    writer.Write($"{column.ColumnName},");
                //}
                //writer.WriteLine();

                //// Write the rows
                //foreach (DataRow row in table.Rows)
                //{
                //    foreach (var item in row.ItemArray)
                //    {
                //        writer.Write($"{item},");
                //    }
                //    writer.WriteLine();
                //}

                int count = table.Columns.Count;
                foreach (DataColumn column in table.Columns)
                {
                    if (count == 1)
                    {
                        writer.Write($"{column.ColumnName}");
                    }
                    else
                    {
                        writer.Write($"{column.ColumnName},");
                    }
                    count--;
                    //writer.Write($"{column.ColumnName},");
                }
                writer.WriteLine();

                // Write the rows
                foreach (DataRow row in table.Rows)
                {
                                       
                    count = table.Columns.Count;

                        foreach (var item in row.ItemArray)
                        {
                            if (count != 1)
                            {

                                writer.Write($"{item},");
                            }
                            else
                            {
                                writer.Write($"{item}");
                            }
                        count--;
                        }
                    


                    //foreach (var item in row.ItemArray)
                    //{
                    //    writer.Write($"{item},");
                    //}
                    writer.WriteLine();
                }

                writer.Close();

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
                writer.Close();
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
            using (StreamWriter writer = new StreamWriter(filename,true))
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
        //RETURN DATATABLE OF ATTENDANCE OF A COURSE
        public static DataTable MarksRollNo(string course, string RollNo)
        {
            DataTable dataTable = new DataTable();

            using (StreamReader sr = new StreamReader(marksFile + course + ".csv"))
            {

                dataTable.Columns.Add("Assessment");
                dataTable.Columns.Add("Marks");

                if (!sr.EndOfStream)
                {

                }
                string[] dates = sr.ReadLine().Split(',');
                while (!sr.EndOfStream)
                {
                    string[] rows = sr.ReadLine().Split(',');
                    if (rows[0] == RollNo)
                    {
                        for (int i = 1; i < rows.Length; i++)
                        {
                            DataRow dataRow = dataTable.NewRow();
                            dataRow["Marks"]= rows[i];
                            dataRow["Assessment"] = dates[i];
                            dataTable.Rows.Add(dataRow);
                        }
                    }
                                        
                }
            }

            return dataTable;


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
                writer.Close();
            }
        }
        //WRITE STUDENT USERNAME PASSWORD TO TXT FILE
        public static void WriteUsernamePassToTxt(string filename, Student std)
        {
            using (StreamWriter writer = new StreamWriter(filename,true))
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
        //WRITE ROLL NO AND NAME IN RESPECTIVE COURSE ATTENDANCE FILE
        public static void WriteRollNoNameToAttendance(string filename, string rollNo, string name)
        {
            using (StreamWriter writer = new StreamWriter(filename, true))
            {
                writer.WriteLine($"{rollNo},{name}");
            }
        }
    }
}
