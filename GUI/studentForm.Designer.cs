namespace GUI
{
    partial class studentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(studentForm));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            genderTxt = new TextBox();
            DepTeacherTxt = new TextBox();
            bloodGrptxt = new TextBox();
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
            attendanceCourseBox = new ComboBox();
            dataGridView3 = new DataGridView();
            tabPage4 = new TabPage();
            marksCourseBox = new ComboBox();
            dataGridView4 = new DataGridView();
            tabPage5 = new TabPage();
            label1 = new Label();
            tabPage6 = new TabPage();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            tabPage5.SuspendLayout();
            tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Location = new Point(12, 46);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(541, 395);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(genderTxt);
            tabPage1.Controls.Add(DepTeacherTxt);
            tabPage1.Controls.Add(bloodGrptxt);
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
            tabPage1.Size = new Size(533, 367);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Home";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // genderTxt
            // 
            genderTxt.BackColor = SystemColors.Window;
            genderTxt.BorderStyle = BorderStyle.None;
            genderTxt.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            genderTxt.Location = new Point(356, 188);
            genderTxt.Name = "genderTxt";
            genderTxt.ReadOnly = true;
            genderTxt.Size = new Size(132, 18);
            genderTxt.TabIndex = 97;
            // 
            // DepTeacherTxt
            // 
            DepTeacherTxt.BackColor = SystemColors.Window;
            DepTeacherTxt.BorderStyle = BorderStyle.None;
            DepTeacherTxt.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            DepTeacherTxt.Location = new Point(356, 102);
            DepTeacherTxt.Name = "DepTeacherTxt";
            DepTeacherTxt.ReadOnly = true;
            DepTeacherTxt.Size = new Size(132, 18);
            DepTeacherTxt.TabIndex = 96;
            // 
            // bloodGrptxt
            // 
            bloodGrptxt.BackColor = SystemColors.Window;
            bloodGrptxt.BorderStyle = BorderStyle.None;
            bloodGrptxt.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            bloodGrptxt.Location = new Point(356, 145);
            bloodGrptxt.Name = "bloodGrptxt";
            bloodGrptxt.ReadOnly = true;
            bloodGrptxt.Size = new Size(132, 18);
            bloodGrptxt.TabIndex = 95;
            // 
            // salaryLbl
            // 
            salaryLbl.AutoSize = true;
            salaryLbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            salaryLbl.Location = new Point(260, 142);
            salaryLbl.Name = "salaryLbl";
            salaryLbl.Size = new Size(90, 17);
            salaryLbl.TabIndex = 94;
            salaryLbl.Text = "Blood Group:";
            // 
            // AdressTeacherTxt
            // 
            AdressTeacherTxt.BackColor = SystemColors.Window;
            AdressTeacherTxt.BorderStyle = BorderStyle.None;
            AdressTeacherTxt.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            AdressTeacherTxt.Location = new Point(120, 188);
            AdressTeacherTxt.Multiline = true;
            AdressTeacherTxt.Name = "AdressTeacherTxt";
            AdressTeacherTxt.ReadOnly = true;
            AdressTeacherTxt.Size = new Size(132, 44);
            AdressTeacherTxt.TabIndex = 93;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(45, 188);
            label3.Name = "label3";
            label3.Size = new Size(61, 17);
            label3.TabIndex = 92;
            label3.Text = "Address:";
            // 
            // QualificationTeacherTxt
            // 
            QualificationTeacherTxt.BackColor = SystemColors.Window;
            QualificationTeacherTxt.BorderStyle = BorderStyle.None;
            QualificationTeacherTxt.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            QualificationTeacherTxt.Location = new Point(120, 145);
            QualificationTeacherTxt.Name = "QualificationTeacherTxt";
            QualificationTeacherTxt.ReadOnly = true;
            QualificationTeacherTxt.Size = new Size(132, 18);
            QualificationTeacherTxt.TabIndex = 91;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(27, 142);
            label4.Name = "label4";
            label4.Size = new Size(92, 17);
            label4.TabIndex = 90;
            label4.Text = "Qualification:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(293, 188);
            label5.Name = "label5";
            label5.Size = new Size(57, 17);
            label5.TabIndex = 89;
            label5.Text = "Gender:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(267, 103);
            label6.Name = "label6";
            label6.Size = new Size(86, 17);
            label6.TabIndex = 88;
            label6.Text = "Department:";
            // 
            // ContactTeacherTxt
            // 
            ContactTeacherTxt.BackColor = SystemColors.Window;
            ContactTeacherTxt.BorderStyle = BorderStyle.None;
            ContactTeacherTxt.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ContactTeacherTxt.Location = new Point(120, 102);
            ContactTeacherTxt.Name = "ContactTeacherTxt";
            ContactTeacherTxt.ReadOnly = true;
            ContactTeacherTxt.Size = new Size(132, 18);
            ContactTeacherTxt.TabIndex = 87;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(27, 103);
            label7.Name = "label7";
            label7.Size = new Size(81, 17);
            label7.TabIndex = 86;
            label7.Text = "Contact No:";
            // 
            // lastNameTeacherTxt
            // 
            lastNameTeacherTxt.BackColor = SystemColors.Window;
            lastNameTeacherTxt.BorderStyle = BorderStyle.None;
            lastNameTeacherTxt.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameTeacherTxt.Location = new Point(356, 66);
            lastNameTeacherTxt.Name = "lastNameTeacherTxt";
            lastNameTeacherTxt.ReadOnly = true;
            lastNameTeacherTxt.Size = new Size(132, 18);
            lastNameTeacherTxt.TabIndex = 85;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(273, 66);
            label8.Name = "label8";
            label8.Size = new Size(77, 17);
            label8.TabIndex = 84;
            label8.Text = "Last Name:";
            // 
            // FNameTeacherTxt
            // 
            FNameTeacherTxt.BackColor = SystemColors.Window;
            FNameTeacherTxt.BorderStyle = BorderStyle.None;
            FNameTeacherTxt.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FNameTeacherTxt.Location = new Point(120, 62);
            FNameTeacherTxt.Name = "FNameTeacherTxt";
            FNameTeacherTxt.ReadOnly = true;
            FNameTeacherTxt.Size = new Size(132, 18);
            FNameTeacherTxt.TabIndex = 83;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(27, 63);
            label9.Name = "label9";
            label9.Size = new Size(79, 17);
            label9.TabIndex = 82;
            label9.Text = "First Name:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(attendanceCourseBox);
            tabPage2.Controls.Add(dataGridView3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(533, 367);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Attendance";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // attendanceCourseBox
            // 
            attendanceCourseBox.DropDownStyle = ComboBoxStyle.DropDownList;
            attendanceCourseBox.FormattingEnabled = true;
            attendanceCourseBox.Location = new Point(148, 45);
            attendanceCourseBox.Name = "attendanceCourseBox";
            attendanceCourseBox.Size = new Size(200, 23);
            attendanceCourseBox.TabIndex = 4;
            attendanceCourseBox.SelectedIndexChanged += attendanceCourseBox_SelectedIndexChanged;
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(-20, 99);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.ReadOnly = true;
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.ShowEditingIcon = false;
            dataGridView3.Size = new Size(569, 265);
            dataGridView3.TabIndex = 3;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(marksCourseBox);
            tabPage4.Controls.Add(dataGridView4);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(533, 367);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Marks";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // marksCourseBox
            // 
            marksCourseBox.DropDownStyle = ComboBoxStyle.DropDownList;
            marksCourseBox.FormattingEnabled = true;
            marksCourseBox.Location = new Point(150, 24);
            marksCourseBox.Name = "marksCourseBox";
            marksCourseBox.Size = new Size(200, 23);
            marksCourseBox.TabIndex = 6;
            marksCourseBox.SelectedIndexChanged += marksCourseBox_SelectedIndexChanged;
            // 
            // dataGridView4
            // 
            dataGridView4.AllowUserToAddRows = false;
            dataGridView4.AllowUserToDeleteRows = false;
            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(-18, 78);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowTemplate.Height = 25;
            dataGridView4.ShowEditingIcon = false;
            dataGridView4.Size = new Size(569, 265);
            dataGridView4.TabIndex = 5;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(label1);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(533, 367);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Registered Courses";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(202, 70);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 0;
            label1.Click += label1_Click;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(label2);
            tabPage6.Location = new Point(4, 24);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(533, 367);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Fee Status";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(187, 131);
            label2.Name = "label2";
            label2.Size = new Size(120, 50);
            label2.TabIndex = 0;
            label2.Text = "label2";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(477, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // studentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 453);
            Controls.Add(pictureBox1);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "studentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "studentForm";
            Load += studentForm_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TextBox genderTxt;
        private TextBox DepTeacherTxt;
        private TextBox bloodGrptxt;
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
        private DataGridView dataGridView3;
        private DateTimePicker dateTimePicker1;
        private ComboBox attendanceCourseBox;
        private ComboBox marksCourseBox;
        private DataGridView dataGridView4;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}