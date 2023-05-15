namespace GUI
{
    partial class teacherForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(teacherForm));
            tabControl = new TabControl();
            tabPage1 = new TabPage();
            genderTxt = new TextBox();
            DepTeacherTxt = new TextBox();
            salaryTxt = new TextBox();
            salaryLbl = new Label();
            AdressTeacherTxt = new TextBox();
            label3 = new Label();
            QualificationTeacherTxt = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ContactTeacherTxt = new TextBox();
            label7 = new Label();
            lastNameTeacherTxt = new TextBox();
            label8 = new Label();
            FNameTeacherTxt = new TextBox();
            label9 = new Label();
            tabPage2 = new TabPage();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            tabPage3 = new TabPage();
            dataGridView2 = new DataGridView();
            tabPage4 = new TabPage();
            dataGridView3 = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            pictureBox1 = new PictureBox();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Controls.Add(tabPage3);
            tabControl.Controls.Add(tabPage4);
            tabControl.Location = new Point(12, 33);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(583, 380);
            tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(genderTxt);
            tabPage1.Controls.Add(DepTeacherTxt);
            tabPage1.Controls.Add(salaryTxt);
            tabPage1.Controls.Add(salaryLbl);
            tabPage1.Controls.Add(AdressTeacherTxt);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(QualificationTeacherTxt);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(ContactTeacherTxt);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(lastNameTeacherTxt);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(FNameTeacherTxt);
            tabPage1.Controls.Add(label9);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(575, 352);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Home";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // genderTxt
            // 
            genderTxt.BackColor = SystemColors.Window;
            genderTxt.BorderStyle = BorderStyle.None;
            genderTxt.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            genderTxt.Location = new Point(359, 211);
            genderTxt.Name = "genderTxt";
            genderTxt.ReadOnly = true;
            genderTxt.Size = new Size(132, 18);
            genderTxt.TabIndex = 81;
            // 
            // DepTeacherTxt
            // 
            DepTeacherTxt.BackColor = SystemColors.Window;
            DepTeacherTxt.BorderStyle = BorderStyle.None;
            DepTeacherTxt.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            DepTeacherTxt.Location = new Point(359, 125);
            DepTeacherTxt.Name = "DepTeacherTxt";
            DepTeacherTxt.ReadOnly = true;
            DepTeacherTxt.Size = new Size(132, 18);
            DepTeacherTxt.TabIndex = 80;
            DepTeacherTxt.TextChanged += textBox1_TextChanged;
            // 
            // salaryTxt
            // 
            salaryTxt.BackColor = SystemColors.Window;
            salaryTxt.BorderStyle = BorderStyle.None;
            salaryTxt.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            salaryTxt.Location = new Point(359, 168);
            salaryTxt.Name = "salaryTxt";
            salaryTxt.ReadOnly = true;
            salaryTxt.Size = new Size(132, 18);
            salaryTxt.TabIndex = 79;
            // 
            // salaryLbl
            // 
            salaryLbl.AutoSize = true;
            salaryLbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            salaryLbl.Location = new Point(293, 168);
            salaryLbl.Name = "salaryLbl";
            salaryLbl.Size = new Size(50, 17);
            salaryLbl.TabIndex = 77;
            salaryLbl.Text = "Salary:";
            // 
            // AdressTeacherTxt
            // 
            AdressTeacherTxt.BackColor = SystemColors.Window;
            AdressTeacherTxt.BorderStyle = BorderStyle.None;
            AdressTeacherTxt.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            AdressTeacherTxt.Location = new Point(128, 207);
            AdressTeacherTxt.Multiline = true;
            AdressTeacherTxt.Name = "AdressTeacherTxt";
            AdressTeacherTxt.ReadOnly = true;
            AdressTeacherTxt.Size = new Size(132, 44);
            AdressTeacherTxt.TabIndex = 76;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(39, 211);
            label3.Name = "label3";
            label3.Size = new Size(61, 17);
            label3.TabIndex = 75;
            label3.Text = "Address:";
            label3.Click += label3_Click;
            // 
            // QualificationTeacherTxt
            // 
            QualificationTeacherTxt.BackColor = SystemColors.Window;
            QualificationTeacherTxt.BorderStyle = BorderStyle.None;
            QualificationTeacherTxt.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            QualificationTeacherTxt.Location = new Point(128, 168);
            QualificationTeacherTxt.Name = "QualificationTeacherTxt";
            QualificationTeacherTxt.ReadOnly = true;
            QualificationTeacherTxt.Size = new Size(132, 18);
            QualificationTeacherTxt.TabIndex = 74;
            QualificationTeacherTxt.TextChanged += QualificationTeacherTxt_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(30, 165);
            label4.Name = "label4";
            label4.Size = new Size(92, 17);
            label4.TabIndex = 73;
            label4.Text = "Qualification:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(286, 211);
            label5.Name = "label5";
            label5.Size = new Size(57, 17);
            label5.TabIndex = 72;
            label5.Text = "Gender:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(260, 126);
            label6.Name = "label6";
            label6.Size = new Size(86, 17);
            label6.TabIndex = 71;
            label6.Text = "Department:";
            label6.Click += label6_Click;
            // 
            // ContactTeacherTxt
            // 
            ContactTeacherTxt.BackColor = SystemColors.Window;
            ContactTeacherTxt.BorderStyle = BorderStyle.None;
            ContactTeacherTxt.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ContactTeacherTxt.Location = new Point(128, 125);
            ContactTeacherTxt.Name = "ContactTeacherTxt";
            ContactTeacherTxt.ReadOnly = true;
            ContactTeacherTxt.Size = new Size(132, 18);
            ContactTeacherTxt.TabIndex = 70;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(30, 126);
            label7.Name = "label7";
            label7.Size = new Size(81, 17);
            label7.TabIndex = 69;
            label7.Text = "Contact No:";
            // 
            // lastNameTeacherTxt
            // 
            lastNameTeacherTxt.BackColor = SystemColors.Window;
            lastNameTeacherTxt.BorderStyle = BorderStyle.None;
            lastNameTeacherTxt.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameTeacherTxt.Location = new Point(359, 89);
            lastNameTeacherTxt.Name = "lastNameTeacherTxt";
            lastNameTeacherTxt.ReadOnly = true;
            lastNameTeacherTxt.Size = new Size(132, 18);
            lastNameTeacherTxt.TabIndex = 68;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(266, 89);
            label8.Name = "label8";
            label8.Size = new Size(77, 17);
            label8.TabIndex = 67;
            label8.Text = "Last Name:";
            // 
            // FNameTeacherTxt
            // 
            FNameTeacherTxt.BackColor = SystemColors.Window;
            FNameTeacherTxt.BorderStyle = BorderStyle.None;
            FNameTeacherTxt.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FNameTeacherTxt.Location = new Point(128, 85);
            FNameTeacherTxt.Name = "FNameTeacherTxt";
            FNameTeacherTxt.ReadOnly = true;
            FNameTeacherTxt.Size = new Size(132, 18);
            FNameTeacherTxt.TabIndex = 66;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(30, 86);
            label9.Name = "label9";
            label9.Size = new Size(79, 17);
            label9.TabIndex = 64;
            label9.Text = "First Name:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(575, 352);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "View TimeTable";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 71);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(563, 296);
            dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(225, 22);
            label1.Name = "label1";
            label1.Size = new Size(94, 21);
            label1.TabIndex = 1;
            label1.Text = "TIMETABLE";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dataGridView2);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(575, 352);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Marks And Grade";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(3, 94);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(569, 276);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellValueChanged += dataGridView2_CellValueChanged;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(dataGridView3);
            tabPage4.Controls.Add(dateTimePicker1);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(575, 352);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Attendance";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(3, 105);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.ShowEditingIcon = false;
            dataGridView3.Size = new Size(569, 265);
            dataGridView3.TabIndex = 1;
            dataGridView3.CellValueChanged += dataGridView3_CellValueChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(168, 40);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 0;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(514, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 44);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // teacherForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 425);
            Controls.Add(pictureBox1);
            Controls.Add(tabControl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "teacherForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Teacher Home";
            Load += teacherForm_Load;
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TextBox salaryTxt;
        private Label salaryLbl;
        private TextBox AdressTeacherTxt;
        private Label label3;
        private TextBox QualificationTeacherTxt;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox ContactTeacherTxt;
        private Label label7;
        private TextBox lastNameTeacherTxt;
        private Label label8;
        private TextBox FNameTeacherTxt;
        private Label label9;
        private TextBox DepTeacherTxt;
        private TextBox genderTxt;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private DateTimePicker dateTimePicker1;
        private PictureBox pictureBox1;
    }
}