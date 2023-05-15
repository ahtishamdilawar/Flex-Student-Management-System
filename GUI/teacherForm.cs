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
using static General.FLEXsharp;
//using static General.FLEXsharp.Timetable;
namespace GUI
{
    public partial class teacherForm : Form
    {
        private string ID = "";
        public Teacher t = new Teacher();
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
            //SET DATAGRID VIEW FOR MARKS AND ATTENDANCE           
            dataGridView2.DataSource = ShowMarks(teachers[index].getCourse());
            t = teachers[index];


        }

        // STORE THE UPGRADED QUIZ MARKS IN THE CSV FILE
        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataTable table = (DataTable)dataGridView2.DataSource;
            WriteMarksToCsv(t.getCourse(), table);
            MessageBox.Show("MARKS UPDATED", "UPDATED");
        }


        private void QualificationTeacherTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataTable p = (DataTable)dataGridView1.DataSource;
            dataGridView2.DataSource = p;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView3.DataSource = AttendanceTable(t.getCourse(), dateTimePicker1.Value.ToString("dd/MM/yyyy"));
            dataGridView3.Columns[0].ReadOnly = true;
            dataGridView3.Columns[1].ReadOnly = true;
        }

        private void dataGridView3_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dataTable = new DataTable();

            using (StreamReader sr = new StreamReader(attendanceFile + t.getCourse() + "A.csv"))
            {
                string[] headers = sr.ReadLine().Split(',');
                foreach (string header in headers)
                {
                    dataTable.Columns.Add(header);
                }

                while (!sr.EndOfStream)
                {
                    string[] rows = sr.ReadLine().Split(',');
                    DataRow dataRow = dataTable.NewRow();
                    for (int i = 0; i < headers.Length; i++)
                    {
                        dataRow[i] = rows[i];
                    }
                    dataTable.Rows.Add(dataRow);
                }
            }
            //Now check if the changes from datasources3 and dataTable are same or not
            //If not then update the dataTable and write it to the file
            bool check = true;
            int index = 0;
            string date = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                if (dataTable.Columns[i].ColumnName == dateTimePicker1.Value.ToString("dd/MM/yyyy"))
                {
                    check = false;
                    index = i;
                }
            }
            if (check)
            {
                dataTable.Columns.Add(date);
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    dataTable.Rows[i][dataTable.Columns.Count - 1] = dataGridView3.Rows[i].Cells[2].Value.ToString();

                }
            }
            else
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    dataTable.Rows[i][index] = dataGridView3.Rows[i].Cells[2].Value.ToString();

                }
            }

            //Now write the dataTable to the file
            WriteAttendanceToCsv(t.getCourse(), dataTable);





        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
