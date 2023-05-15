namespace GUI
{
    partial class adminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources eing used.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminForm));
            viewCombo = new ComboBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label18 = new Label();
            courseBox = new CheckedListBox();
            panel1 = new Panel();
            malebtn = new RadioButton();
            femalebtn = new RadioButton();
            feeLbl = new Label();
            unpaidbtn = new RadioButton();
            paidbtn = new RadioButton();
            bloodbox = new ComboBox();
            bloodGrouplbl = new Label();
            depBox = new ComboBox();
            Adresstxt = new TextBox();
            adresslbl = new Label();
            qualiftxt = new TextBox();
            qualiflbl = new Label();
            gndrlbl = new Label();
            Deplbl = new Label();
            ContactTxt = new TextBox();
            Contactlbl = new Label();
            lNametxt = new TextBox();
            lNamelbl = new Label();
            fnametxt = new TextBox();
            addStdBtn = new Button();
            fNameLbl = new Label();
            tabPage4 = new TabPage();
            detailEditPanel = new Panel();
            UpdateBtn = new Button();
            FeeEditLbl = new Label();
            UnpaidEditBtn = new RadioButton();
            PaidEditBtn = new RadioButton();
            AdressEditTxt = new TextBox();
            AdressEditlbl = new Label();
            ContactEditTxt = new TextBox();
            contactEditLbl = new Label();
            LNameEditTxt = new TextBox();
            LNameEditLbl = new Label();
            FNameEditTxt = new TextBox();
            FNameEditLbl = new Label();
            findstdpnl = new Panel();
            rollNoEditlbl = new Label();
            editStdbtn = new Button();
            rollNoEdittxt = new TextBox();
            tabPage3 = new TabPage();
            rollNotxt = new TextBox();
            rollNolbl = new Label();
            selectlbl = new Label();
            viewlbl = new Label();
            depCombo = new ComboBox();
            searchbtn = new Button();
            dataGridView1 = new DataGridView();
            tabPage2 = new TabPage();
            label17 = new Label();
            courseTxt = new ComboBox();
            depTeacherCombo = new ComboBox();
            salaryTxt = new TextBox();
            panel2 = new Panel();
            MaleTeacherTxt = new RadioButton();
            FemaleTeacherTxt = new RadioButton();
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
            AddTeacherbtn = new Button();
            label9 = new Label();
            tabPage5 = new TabPage();
            label11 = new Label();
            dataGridView2 = new DataGridView();
            tabPage6 = new TabPage();
            panel4 = new Panel();
            SalaryTeacherEditTxt = new TextBox();
            label16 = new Label();
            QualificationEditTeacherTxt = new TextBox();
            UpdateEditTeacherBtn = new Button();
            label10 = new Label();
            AddressEditTeacherTxt = new TextBox();
            label12 = new Label();
            ContactEditTeacherTxt = new TextBox();
            label13 = new Label();
            LNameEditTeacherTxt = new TextBox();
            label14 = new Label();
            FNameEditTeacherTxt = new TextBox();
            label15 = new Label();
            panel3 = new Panel();
            label1 = new Label();
            FindEditTeacherBtn = new Button();
            TIDEditTeacherTxt = new TextBox();
            pictureBox1 = new PictureBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            tabPage4.SuspendLayout();
            detailEditPanel.SuspendLayout();
            findstdpnl.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            panel2.SuspendLayout();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage6.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // viewCombo
            // 
            viewCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            viewCombo.FormattingEnabled = true;
            viewCombo.Items.AddRange(new object[] { "View All Students", "Search by Department", "Search by Roll No." });
            viewCombo.Location = new Point(172, 20);
            viewCombo.Name = "viewCombo";
            viewCombo.Size = new Size(200, 23);
            viewCombo.TabIndex = 2;
            viewCombo.SelectedIndexChanged += ViewStudent;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Location = new Point(12, 30);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(589, 385);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label18);
            tabPage1.Controls.Add(courseBox);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(feeLbl);
            tabPage1.Controls.Add(unpaidbtn);
            tabPage1.Controls.Add(paidbtn);
            tabPage1.Controls.Add(bloodbox);
            tabPage1.Controls.Add(bloodGrouplbl);
            tabPage1.Controls.Add(depBox);
            tabPage1.Controls.Add(Adresstxt);
            tabPage1.Controls.Add(adresslbl);
            tabPage1.Controls.Add(qualiftxt);
            tabPage1.Controls.Add(qualiflbl);
            tabPage1.Controls.Add(gndrlbl);
            tabPage1.Controls.Add(Deplbl);
            tabPage1.Controls.Add(ContactTxt);
            tabPage1.Controls.Add(Contactlbl);
            tabPage1.Controls.Add(lNametxt);
            tabPage1.Controls.Add(lNamelbl);
            tabPage1.Controls.Add(fnametxt);
            tabPage1.Controls.Add(addStdBtn);
            tabPage1.Controls.Add(fNameLbl);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(581, 357);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Add Student";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(329, 189);
            label18.Name = "label18";
            label18.Size = new Size(52, 15);
            label18.TabIndex = 43;
            label18.Text = "Courses:";
            // 
            // courseBox
            // 
            courseBox.FormattingEnabled = true;
            courseBox.Items.AddRange(new object[] { "DLD", "Linear Algebra", "OOP", "PF", "Calculus" });
            courseBox.Location = new Point(395, 189);
            courseBox.Name = "courseBox";
            courseBox.Size = new Size(132, 94);
            courseBox.TabIndex = 42;
            // 
            // panel1
            // 
            panel1.Controls.Add(malebtn);
            panel1.Controls.Add(femalebtn);
            panel1.Location = new Point(116, 151);
            panel1.Name = "panel1";
            panel1.Size = new Size(132, 32);
            panel1.TabIndex = 41;
            // 
            // malebtn
            // 
            malebtn.AutoSize = true;
            malebtn.Location = new Point(3, 4);
            malebtn.Name = "malebtn";
            malebtn.Size = new Size(51, 19);
            malebtn.TabIndex = 23;
            malebtn.TabStop = true;
            malebtn.Text = "Male";
            malebtn.UseVisualStyleBackColor = true;
            // 
            // femalebtn
            // 
            femalebtn.AutoSize = true;
            femalebtn.Location = new Point(66, 4);
            femalebtn.Name = "femalebtn";
            femalebtn.Size = new Size(63, 19);
            femalebtn.TabIndex = 29;
            femalebtn.TabStop = true;
            femalebtn.Text = "Female";
            femalebtn.UseVisualStyleBackColor = true;
            // 
            // feeLbl
            // 
            feeLbl.AutoSize = true;
            feeLbl.Location = new Point(318, 159);
            feeLbl.Name = "feeLbl";
            feeLbl.Size = new Size(63, 15);
            feeLbl.TabIndex = 40;
            feeLbl.Text = "Fee Status:";
            // 
            // unpaidbtn
            // 
            unpaidbtn.AutoSize = true;
            unpaidbtn.Location = new Point(467, 157);
            unpaidbtn.Name = "unpaidbtn";
            unpaidbtn.Size = new Size(63, 19);
            unpaidbtn.TabIndex = 39;
            unpaidbtn.TabStop = true;
            unpaidbtn.Text = "Unpaid";
            unpaidbtn.UseVisualStyleBackColor = true;
            // 
            // paidbtn
            // 
            paidbtn.AutoSize = true;
            paidbtn.Location = new Point(398, 157);
            paidbtn.Name = "paidbtn";
            paidbtn.Size = new Size(48, 19);
            paidbtn.TabIndex = 38;
            paidbtn.TabStop = true;
            paidbtn.Text = "Paid";
            paidbtn.UseVisualStyleBackColor = true;
            // 
            // bloodbox
            // 
            bloodbox.BackColor = SystemColors.Window;
            bloodbox.DropDownStyle = ComboBoxStyle.DropDownList;
            bloodbox.FormattingEnabled = true;
            bloodbox.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "O+", "O-", "AB+", "AB-" });
            bloodbox.Location = new Point(395, 114);
            bloodbox.Name = "bloodbox";
            bloodbox.Size = new Size(132, 23);
            bloodbox.TabIndex = 37;
            // 
            // bloodGrouplbl
            // 
            bloodGrouplbl.AutoSize = true;
            bloodGrouplbl.Location = new Point(312, 119);
            bloodGrouplbl.Name = "bloodGrouplbl";
            bloodGrouplbl.Size = new Size(77, 15);
            bloodGrouplbl.TabIndex = 36;
            bloodGrouplbl.Text = "Blood Group:";
            // 
            // depBox
            // 
            depBox.BackColor = SystemColors.Window;
            depBox.DropDownStyle = ComboBoxStyle.DropDownList;
            depBox.FormattingEnabled = true;
            depBox.Items.AddRange(new object[] { "Computer Science", "Electric Engineering", "Software Engineering", "Business", "Social Sciences" });
            depBox.Location = new Point(395, 80);
            depBox.Name = "depBox";
            depBox.Size = new Size(132, 23);
            depBox.TabIndex = 35;
            depBox.SelectedIndexChanged += depBox_SelectedIndexChanged;
            // 
            // Adresstxt
            // 
            Adresstxt.Location = new Point(113, 189);
            Adresstxt.Multiline = true;
            Adresstxt.Name = "Adresstxt";
            Adresstxt.Size = new Size(135, 45);
            Adresstxt.TabIndex = 34;
            // 
            // adresslbl
            // 
            adresslbl.AutoSize = true;
            adresslbl.Location = new Point(48, 192);
            adresslbl.Name = "adresslbl";
            adresslbl.Size = new Size(45, 15);
            adresslbl.TabIndex = 33;
            adresslbl.Text = "Adress:";
            // 
            // qualiftxt
            // 
            qualiftxt.Location = new Point(116, 122);
            qualiftxt.Name = "qualiftxt";
            qualiftxt.Size = new Size(132, 23);
            qualiftxt.TabIndex = 32;
            // 
            // qualiflbl
            // 
            qualiflbl.AutoSize = true;
            qualiflbl.Location = new Point(15, 122);
            qualiflbl.Name = "qualiflbl";
            qualiflbl.Size = new Size(78, 15);
            qualiflbl.TabIndex = 31;
            qualiflbl.Text = "Qualification:";
            // 
            // gndrlbl
            // 
            gndrlbl.AutoSize = true;
            gndrlbl.Location = new Point(45, 155);
            gndrlbl.Name = "gndrlbl";
            gndrlbl.Size = new Size(48, 15);
            gndrlbl.TabIndex = 30;
            gndrlbl.Text = "Gender:";
            // 
            // Deplbl
            // 
            Deplbl.AutoSize = true;
            Deplbl.Location = new Point(315, 80);
            Deplbl.Name = "Deplbl";
            Deplbl.Size = new Size(73, 15);
            Deplbl.TabIndex = 28;
            Deplbl.Text = "Department:";
            // 
            // ContactTxt
            // 
            ContactTxt.Location = new Point(116, 80);
            ContactTxt.Name = "ContactTxt";
            ContactTxt.Size = new Size(132, 23);
            ContactTxt.TabIndex = 27;
            // 
            // Contactlbl
            // 
            Contactlbl.AutoSize = true;
            Contactlbl.Location = new Point(26, 83);
            Contactlbl.Name = "Contactlbl";
            Contactlbl.Size = new Size(71, 15);
            Contactlbl.TabIndex = 26;
            Contactlbl.Text = "Contact No:";
            // 
            // lNametxt
            // 
            lNametxt.Location = new Point(395, 40);
            lNametxt.Name = "lNametxt";
            lNametxt.Size = new Size(132, 23);
            lNametxt.TabIndex = 25;
            // 
            // lNamelbl
            // 
            lNamelbl.AutoSize = true;
            lNamelbl.Location = new Point(315, 40);
            lNamelbl.Name = "lNamelbl";
            lNamelbl.Size = new Size(66, 15);
            lNamelbl.TabIndex = 24;
            lNamelbl.Text = "Last Name:";
            // 
            // fnametxt
            // 
            fnametxt.Location = new Point(116, 40);
            fnametxt.Name = "fnametxt";
            fnametxt.Size = new Size(132, 23);
            fnametxt.TabIndex = 22;
            // 
            // addStdBtn
            // 
            addStdBtn.Location = new Point(182, 274);
            addStdBtn.Name = "addStdBtn";
            addStdBtn.Size = new Size(167, 56);
            addStdBtn.TabIndex = 21;
            addStdBtn.Text = "Add Student";
            addStdBtn.UseVisualStyleBackColor = true;
            addStdBtn.Click += addStdBtn_Click;
            // 
            // fNameLbl
            // 
            fNameLbl.AutoSize = true;
            fNameLbl.Location = new Point(26, 43);
            fNameLbl.Name = "fNameLbl";
            fNameLbl.Size = new Size(67, 15);
            fNameLbl.TabIndex = 20;
            fNameLbl.Text = "First Name:";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(detailEditPanel);
            tabPage4.Controls.Add(findstdpnl);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(581, 357);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Edit Student";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // detailEditPanel
            // 
            detailEditPanel.Controls.Add(UpdateBtn);
            detailEditPanel.Controls.Add(FeeEditLbl);
            detailEditPanel.Controls.Add(UnpaidEditBtn);
            detailEditPanel.Controls.Add(PaidEditBtn);
            detailEditPanel.Controls.Add(AdressEditTxt);
            detailEditPanel.Controls.Add(AdressEditlbl);
            detailEditPanel.Controls.Add(ContactEditTxt);
            detailEditPanel.Controls.Add(contactEditLbl);
            detailEditPanel.Controls.Add(LNameEditTxt);
            detailEditPanel.Controls.Add(LNameEditLbl);
            detailEditPanel.Controls.Add(FNameEditTxt);
            detailEditPanel.Controls.Add(FNameEditLbl);
            detailEditPanel.Location = new Point(215, 10);
            detailEditPanel.Name = "detailEditPanel";
            detailEditPanel.Size = new Size(363, 339);
            detailEditPanel.TabIndex = 4;
            // 
            // UpdateBtn
            // 
            UpdateBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateBtn.Location = new Point(151, 231);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(132, 57);
            UpdateBtn.TabIndex = 44;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // FeeEditLbl
            // 
            FeeEditLbl.AutoSize = true;
            FeeEditLbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FeeEditLbl.Location = new Point(78, 196);
            FeeEditLbl.Name = "FeeEditLbl";
            FeeEditLbl.Size = new Size(70, 17);
            FeeEditLbl.TabIndex = 43;
            FeeEditLbl.Text = "Fee Status:";
            // 
            // UnpaidEditBtn
            // 
            UnpaidEditBtn.AutoSize = true;
            UnpaidEditBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            UnpaidEditBtn.Location = new Point(227, 194);
            UnpaidEditBtn.Name = "UnpaidEditBtn";
            UnpaidEditBtn.Size = new Size(68, 21);
            UnpaidEditBtn.TabIndex = 42;
            UnpaidEditBtn.TabStop = true;
            UnpaidEditBtn.Text = "Unpaid";
            UnpaidEditBtn.UseVisualStyleBackColor = true;
            // 
            // PaidEditBtn
            // 
            PaidEditBtn.AutoSize = true;
            PaidEditBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            PaidEditBtn.Location = new Point(158, 194);
            PaidEditBtn.Name = "PaidEditBtn";
            PaidEditBtn.Size = new Size(51, 21);
            PaidEditBtn.TabIndex = 41;
            PaidEditBtn.TabStop = true;
            PaidEditBtn.Text = "Paid";
            PaidEditBtn.UseVisualStyleBackColor = true;
            // 
            // AdressEditTxt
            // 
            AdressEditTxt.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            AdressEditTxt.Location = new Point(151, 154);
            AdressEditTxt.Name = "AdressEditTxt";
            AdressEditTxt.Size = new Size(132, 25);
            AdressEditTxt.TabIndex = 33;
            // 
            // AdressEditlbl
            // 
            AdressEditlbl.AutoSize = true;
            AdressEditlbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            AdressEditlbl.Location = new Point(85, 157);
            AdressEditlbl.Name = "AdressEditlbl";
            AdressEditlbl.Size = new Size(59, 17);
            AdressEditlbl.TabIndex = 32;
            AdressEditlbl.Text = "Address:";
            // 
            // ContactEditTxt
            // 
            ContactEditTxt.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ContactEditTxt.Location = new Point(151, 109);
            ContactEditTxt.Name = "ContactEditTxt";
            ContactEditTxt.Size = new Size(132, 25);
            ContactEditTxt.TabIndex = 31;
            // 
            // contactEditLbl
            // 
            contactEditLbl.AutoSize = true;
            contactEditLbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            contactEditLbl.Location = new Point(71, 112);
            contactEditLbl.Name = "contactEditLbl";
            contactEditLbl.Size = new Size(77, 17);
            contactEditLbl.TabIndex = 30;
            contactEditLbl.Text = "Contact No:";
            // 
            // LNameEditTxt
            // 
            LNameEditTxt.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            LNameEditTxt.Location = new Point(151, 66);
            LNameEditTxt.Name = "LNameEditTxt";
            LNameEditTxt.Size = new Size(132, 25);
            LNameEditTxt.TabIndex = 29;
            // 
            // LNameEditLbl
            // 
            LNameEditLbl.AutoSize = true;
            LNameEditLbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            LNameEditLbl.Location = new Point(71, 66);
            LNameEditLbl.Name = "LNameEditLbl";
            LNameEditLbl.Size = new Size(73, 17);
            LNameEditLbl.TabIndex = 28;
            LNameEditLbl.Text = "Last Name:";
            // 
            // FNameEditTxt
            // 
            FNameEditTxt.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FNameEditTxt.Location = new Point(151, 16);
            FNameEditTxt.Name = "FNameEditTxt";
            FNameEditTxt.Size = new Size(132, 25);
            FNameEditTxt.TabIndex = 27;
            // 
            // FNameEditLbl
            // 
            FNameEditLbl.AutoSize = true;
            FNameEditLbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FNameEditLbl.Location = new Point(70, 20);
            FNameEditLbl.Name = "FNameEditLbl";
            FNameEditLbl.Size = new Size(74, 17);
            FNameEditLbl.TabIndex = 26;
            FNameEditLbl.Text = "First Name:";
            // 
            // findstdpnl
            // 
            findstdpnl.Controls.Add(rollNoEditlbl);
            findstdpnl.Controls.Add(editStdbtn);
            findstdpnl.Controls.Add(rollNoEdittxt);
            findstdpnl.Location = new Point(3, 13);
            findstdpnl.Name = "findstdpnl";
            findstdpnl.Size = new Size(206, 96);
            findstdpnl.TabIndex = 3;
            // 
            // rollNoEditlbl
            // 
            rollNoEditlbl.AutoSize = true;
            rollNoEditlbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            rollNoEditlbl.Location = new Point(3, 10);
            rollNoEditlbl.Name = "rollNoEditlbl";
            rollNoEditlbl.Size = new Size(62, 20);
            rollNoEditlbl.TabIndex = 0;
            rollNoEditlbl.Text = "Roll No:";
            // 
            // editStdbtn
            // 
            editStdbtn.Location = new Point(84, 51);
            editStdbtn.Name = "editStdbtn";
            editStdbtn.Size = new Size(100, 26);
            editStdbtn.TabIndex = 2;
            editStdbtn.Text = "FIND";
            editStdbtn.UseVisualStyleBackColor = true;
            editStdbtn.Click += editstdbtn_Click;
            // 
            // rollNoEdittxt
            // 
            rollNoEdittxt.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            rollNoEdittxt.Location = new Point(66, 7);
            rollNoEdittxt.Name = "rollNoEdittxt";
            rollNoEdittxt.Size = new Size(131, 27);
            rollNoEdittxt.TabIndex = 1;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(rollNotxt);
            tabPage3.Controls.Add(rollNolbl);
            tabPage3.Controls.Add(selectlbl);
            tabPage3.Controls.Add(viewlbl);
            tabPage3.Controls.Add(depCombo);
            tabPage3.Controls.Add(viewCombo);
            tabPage3.Controls.Add(searchbtn);
            tabPage3.Controls.Add(dataGridView1);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(581, 357);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "View Student";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // rollNotxt
            // 
            rollNotxt.Location = new Point(172, 49);
            rollNotxt.Name = "rollNotxt";
            rollNotxt.Size = new Size(100, 23);
            rollNotxt.TabIndex = 7;
            rollNotxt.Visible = false;
            // 
            // rollNolbl
            // 
            rollNolbl.AutoSize = true;
            rollNolbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rollNolbl.Location = new Point(107, 51);
            rollNolbl.Name = "rollNolbl";
            rollNolbl.Size = new Size(59, 17);
            rollNolbl.TabIndex = 6;
            rollNolbl.Text = "Roll No: ";
            rollNolbl.Visible = false;
            // 
            // selectlbl
            // 
            selectlbl.AutoSize = true;
            selectlbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            selectlbl.Location = new Point(51, 50);
            selectlbl.Name = "selectlbl";
            selectlbl.Size = new Size(115, 17);
            selectlbl.TabIndex = 5;
            selectlbl.Text = "Select Department";
            selectlbl.Visible = false;
            // 
            // viewlbl
            // 
            viewlbl.AutoSize = true;
            viewlbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            viewlbl.Location = new Point(122, 23);
            viewlbl.Name = "viewlbl";
            viewlbl.Size = new Size(44, 20);
            viewlbl.TabIndex = 4;
            viewlbl.Text = "View:\r\n";
            // 
            // depCombo
            // 
            depCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            depCombo.FormattingEnabled = true;
            depCombo.Items.AddRange(new object[] { "Computer Science", "Electric Engineering", "Software Engineering", "Business", "Social Sciences" });
            depCombo.Location = new Point(172, 49);
            depCombo.Name = "depCombo";
            depCombo.Size = new Size(200, 23);
            depCombo.TabIndex = 3;
            depCombo.Visible = false;
            depCombo.SelectedIndexChanged += ViewDepStudent;
            // 
            // searchbtn
            // 
            searchbtn.Location = new Point(327, 49);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(75, 23);
            searchbtn.TabIndex = 1;
            searchbtn.Text = "Search";
            searchbtn.UseVisualStyleBackColor = true;
            searchbtn.Visible = false;
            searchbtn.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 88);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(569, 263);
            dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label17);
            tabPage2.Controls.Add(courseTxt);
            tabPage2.Controls.Add(depTeacherCombo);
            tabPage2.Controls.Add(salaryTxt);
            tabPage2.Controls.Add(panel2);
            tabPage2.Controls.Add(salaryLbl);
            tabPage2.Controls.Add(AdressTeacherTxt);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(QualificationTeacherTxt);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(ContactTeacherTxt);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(lastNameTeacherTxt);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(FNameTeacherTxt);
            tabPage2.Controls.Add(AddTeacherbtn);
            tabPage2.Controls.Add(label9);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(581, 357);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Add Teacher";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(340, 134);
            label17.Name = "label17";
            label17.Size = new Size(47, 15);
            label17.TabIndex = 65;
            label17.Text = "Course:";
            // 
            // courseTxt
            // 
            courseTxt.DropDownStyle = ComboBoxStyle.DropDownList;
            courseTxt.FormattingEnabled = true;
            courseTxt.Items.AddRange(new object[] { "DLD", "LA", "OOP", "PF", "Calculus" });
            courseTxt.Location = new Point(407, 131);
            courseTxt.Name = "courseTxt";
            courseTxt.Size = new Size(132, 23);
            courseTxt.TabIndex = 64;
            // 
            // depTeacherCombo
            // 
            depTeacherCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            depTeacherCombo.FormattingEnabled = true;
            depTeacherCombo.Items.AddRange(new object[] { "Computer Science", "Electric Engineering", "Software Engineering", "Business", "Social Sciences" });
            depTeacherCombo.Location = new Point(407, 97);
            depTeacherCombo.Name = "depTeacherCombo";
            depTeacherCombo.Size = new Size(132, 23);
            depTeacherCombo.TabIndex = 63;
            // 
            // salaryTxt
            // 
            salaryTxt.Location = new Point(407, 209);
            salaryTxt.Name = "salaryTxt";
            salaryTxt.Size = new Size(132, 23);
            salaryTxt.TabIndex = 62;
            // 
            // panel2
            // 
            panel2.Controls.Add(MaleTeacherTxt);
            panel2.Controls.Add(FemaleTeacherTxt);
            panel2.Location = new Point(407, 171);
            panel2.Name = "panel2";
            panel2.Size = new Size(132, 32);
            panel2.TabIndex = 61;
            // 
            // MaleTeacherTxt
            // 
            MaleTeacherTxt.AutoSize = true;
            MaleTeacherTxt.Location = new Point(3, 6);
            MaleTeacherTxt.Name = "MaleTeacherTxt";
            MaleTeacherTxt.Size = new Size(51, 19);
            MaleTeacherTxt.TabIndex = 23;
            MaleTeacherTxt.TabStop = true;
            MaleTeacherTxt.Text = "Male";
            MaleTeacherTxt.UseVisualStyleBackColor = true;
            // 
            // FemaleTeacherTxt
            // 
            FemaleTeacherTxt.AutoSize = true;
            FemaleTeacherTxt.Location = new Point(66, 6);
            FemaleTeacherTxt.Name = "FemaleTeacherTxt";
            FemaleTeacherTxt.Size = new Size(63, 19);
            FemaleTeacherTxt.TabIndex = 29;
            FemaleTeacherTxt.TabStop = true;
            FemaleTeacherTxt.Text = "Female";
            FemaleTeacherTxt.UseVisualStyleBackColor = true;
            // 
            // salaryLbl
            // 
            salaryLbl.AutoSize = true;
            salaryLbl.Location = new Point(340, 212);
            salaryLbl.Name = "salaryLbl";
            salaryLbl.Size = new Size(41, 15);
            salaryLbl.TabIndex = 60;
            salaryLbl.Text = "Salary:";
            // 
            // AdressTeacherTxt
            // 
            AdressTeacherTxt.Location = new Point(127, 179);
            AdressTeacherTxt.Multiline = true;
            AdressTeacherTxt.Name = "AdressTeacherTxt";
            AdressTeacherTxt.Size = new Size(132, 44);
            AdressTeacherTxt.TabIndex = 54;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 182);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 53;
            label3.Text = "Address:";
            // 
            // QualificationTeacherTxt
            // 
            QualificationTeacherTxt.Location = new Point(128, 139);
            QualificationTeacherTxt.Name = "QualificationTeacherTxt";
            QualificationTeacherTxt.Size = new Size(132, 23);
            QualificationTeacherTxt.TabIndex = 52;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 139);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 51;
            label4.Text = "Qualification:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(336, 179);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 50;
            label5.Text = "Gender:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(327, 100);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 49;
            label6.Text = "Department:";
            // 
            // ContactTeacherTxt
            // 
            ContactTeacherTxt.Location = new Point(127, 97);
            ContactTeacherTxt.Name = "ContactTeacherTxt";
            ContactTeacherTxt.Size = new Size(132, 23);
            ContactTeacherTxt.TabIndex = 48;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(37, 100);
            label7.Name = "label7";
            label7.Size = new Size(71, 15);
            label7.TabIndex = 47;
            label7.Text = "Contact No:";
            // 
            // lastNameTeacherTxt
            // 
            lastNameTeacherTxt.Location = new Point(407, 60);
            lastNameTeacherTxt.Name = "lastNameTeacherTxt";
            lastNameTeacherTxt.Size = new Size(132, 23);
            lastNameTeacherTxt.TabIndex = 46;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(327, 60);
            label8.Name = "label8";
            label8.Size = new Size(66, 15);
            label8.TabIndex = 45;
            label8.Text = "Last Name:";
            // 
            // FNameTeacherTxt
            // 
            FNameTeacherTxt.Location = new Point(127, 57);
            FNameTeacherTxt.Name = "FNameTeacherTxt";
            FNameTeacherTxt.Size = new Size(132, 23);
            FNameTeacherTxt.TabIndex = 44;
            // 
            // AddTeacherbtn
            // 
            AddTeacherbtn.Location = new Point(202, 246);
            AddTeacherbtn.Name = "AddTeacherbtn";
            AddTeacherbtn.Size = new Size(182, 53);
            AddTeacherbtn.TabIndex = 43;
            AddTeacherbtn.Text = "Add Teacher";
            AddTeacherbtn.UseVisualStyleBackColor = true;
            AddTeacherbtn.Click += AddTeacherbtn_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(37, 60);
            label9.Name = "label9";
            label9.Size = new Size(67, 15);
            label9.TabIndex = 42;
            label9.Text = "First Name:";
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(label11);
            tabPage5.Controls.Add(dataGridView2);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(581, 357);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "View Teacher";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(227, 15);
            label11.Name = "label11";
            label11.Size = new Size(108, 20);
            label11.TabIndex = 12;
            label11.Text = "ALL TEACHERS";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(6, 65);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(569, 279);
            dataGridView2.TabIndex = 8;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(panel4);
            tabPage6.Controls.Add(panel3);
            tabPage6.Location = new Point(4, 24);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(581, 357);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Edit Teacher";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(SalaryTeacherEditTxt);
            panel4.Controls.Add(label16);
            panel4.Controls.Add(QualificationEditTeacherTxt);
            panel4.Controls.Add(UpdateEditTeacherBtn);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(AddressEditTeacherTxt);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(ContactEditTeacherTxt);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(LNameEditTeacherTxt);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(FNameEditTeacherTxt);
            panel4.Controls.Add(label15);
            panel4.Location = new Point(212, 9);
            panel4.Name = "panel4";
            panel4.Size = new Size(363, 339);
            panel4.TabIndex = 5;
            // 
            // SalaryTeacherEditTxt
            // 
            SalaryTeacherEditTxt.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            SalaryTeacherEditTxt.Location = new Point(151, 227);
            SalaryTeacherEditTxt.Name = "SalaryTeacherEditTxt";
            SalaryTeacherEditTxt.Size = new Size(132, 25);
            SalaryTeacherEditTxt.TabIndex = 47;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(98, 230);
            label16.Name = "label16";
            label16.Size = new Size(46, 17);
            label16.TabIndex = 46;
            label16.Text = "Salary:";
            // 
            // QualificationEditTeacherTxt
            // 
            QualificationEditTeacherTxt.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            QualificationEditTeacherTxt.Location = new Point(151, 191);
            QualificationEditTeacherTxt.Name = "QualificationEditTeacherTxt";
            QualificationEditTeacherTxt.Size = new Size(132, 25);
            QualificationEditTeacherTxt.TabIndex = 45;
            // 
            // UpdateEditTeacherBtn
            // 
            UpdateEditTeacherBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateEditTeacherBtn.Location = new Point(151, 266);
            UpdateEditTeacherBtn.Name = "UpdateEditTeacherBtn";
            UpdateEditTeacherBtn.Size = new Size(132, 57);
            UpdateEditTeacherBtn.TabIndex = 44;
            UpdateEditTeacherBtn.Text = "Update";
            UpdateEditTeacherBtn.UseVisualStyleBackColor = true;
            UpdateEditTeacherBtn.Click += UpdateEditTeacherBtn_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(65, 194);
            label10.Name = "label10";
            label10.Size = new Size(83, 17);
            label10.TabIndex = 43;
            label10.Text = "Qualification:";
            // 
            // AddressEditTeacherTxt
            // 
            AddressEditTeacherTxt.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            AddressEditTeacherTxt.Location = new Point(151, 154);
            AddressEditTeacherTxt.Name = "AddressEditTeacherTxt";
            AddressEditTeacherTxt.Size = new Size(132, 25);
            AddressEditTeacherTxt.TabIndex = 33;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(85, 157);
            label12.Name = "label12";
            label12.Size = new Size(59, 17);
            label12.TabIndex = 32;
            label12.Text = "Address:";
            // 
            // ContactEditTeacherTxt
            // 
            ContactEditTeacherTxt.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ContactEditTeacherTxt.Location = new Point(151, 109);
            ContactEditTeacherTxt.Name = "ContactEditTeacherTxt";
            ContactEditTeacherTxt.Size = new Size(132, 25);
            ContactEditTeacherTxt.TabIndex = 31;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(71, 112);
            label13.Name = "label13";
            label13.Size = new Size(77, 17);
            label13.TabIndex = 30;
            label13.Text = "Contact No:";
            // 
            // LNameEditTeacherTxt
            // 
            LNameEditTeacherTxt.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            LNameEditTeacherTxt.Location = new Point(151, 66);
            LNameEditTeacherTxt.Name = "LNameEditTeacherTxt";
            LNameEditTeacherTxt.Size = new Size(132, 25);
            LNameEditTeacherTxt.TabIndex = 29;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(71, 66);
            label14.Name = "label14";
            label14.Size = new Size(73, 17);
            label14.TabIndex = 28;
            label14.Text = "Last Name:";
            // 
            // FNameEditTeacherTxt
            // 
            FNameEditTeacherTxt.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FNameEditTeacherTxt.Location = new Point(151, 16);
            FNameEditTeacherTxt.Name = "FNameEditTeacherTxt";
            FNameEditTeacherTxt.Size = new Size(132, 25);
            FNameEditTeacherTxt.TabIndex = 27;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(70, 20);
            label15.Name = "label15";
            label15.Size = new Size(74, 17);
            label15.TabIndex = 26;
            label15.Text = "First Name:";
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Controls.Add(FindEditTeacherBtn);
            panel3.Controls.Add(TIDEditTeacherTxt);
            panel3.Location = new Point(6, 6);
            panel3.Name = "panel3";
            panel3.Size = new Size(206, 96);
            panel3.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(25, 10);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 0;
            label1.Text = "TID:";
            // 
            // FindEditTeacherBtn
            // 
            FindEditTeacherBtn.Location = new Point(97, 49);
            FindEditTeacherBtn.Name = "FindEditTeacherBtn";
            FindEditTeacherBtn.Size = new Size(100, 26);
            FindEditTeacherBtn.TabIndex = 2;
            FindEditTeacherBtn.Text = "FIND";
            FindEditTeacherBtn.UseVisualStyleBackColor = true;
            FindEditTeacherBtn.Click += FindEditTeacherBtn_Click;
            // 
            // TIDEditTeacherTxt
            // 
            TIDEditTeacherTxt.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            TIDEditTeacherTxt.Location = new Point(66, 7);
            TIDEditTeacherTxt.Name = "TIDEditTeacherTxt";
            TIDEditTeacherTxt.Size = new Size(131, 27);
            TIDEditTeacherTxt.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(537, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 44);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // adminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 418);
            Controls.Add(pictureBox1);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "adminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ADMIN PANEL";
            Load += adminForm_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage4.ResumeLayout(false);
            detailEditPanel.ResumeLayout(false);
            detailEditPanel.PerformLayout();
            findstdpnl.ResumeLayout(false);
            findstdpnl.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage6.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private ComboBox bloodbox;
        private Label bloodGrouplbl;
        private ComboBox depBox;
        private TextBox Adresstxt;
        private Label adresslbl;
        private TextBox qualiftxt;
        private Label qualiflbl;
        private Label gndrlbl;
        private RadioButton femalebtn;
        private Label Deplbl;
        private TextBox ContactTxt;
        private Label Contactlbl;
        private TextBox lNametxt;
        private Label lNamelbl;
        private RadioButton malebtn;
        private TextBox fnametxt;
        private Button addStdBtn;
        private Label fNameLbl;
        private TabPage tabPage2;
        private Label feeLbl;
        private RadioButton unpaidbtn;
        private RadioButton paidbtn;

        private TextBox textBox3;
        private Panel panel1;
        private TabPage tabPage3;
        private DataGridView dataGridView1;
        private Button searchbtn;
        private ComboBox viewCombo;
        private ComboBox depCombo;
        private Label selectlbl;
        private Label viewlbl;
        private TextBox rollNotxt;
        private Label rollNolbl;
        private TabPage tabPage4;
        private Panel detailEditPanel;
        private Label FeeEditLbl;
        private RadioButton UnpaidEditBtn;
        private RadioButton PaidEditBtn;
        private TextBox AdressEditTxt;
        private Label AdressEditlbl;
        private TextBox ContactEditTxt;
        private Label contactEditLbl;
        private TextBox LNameEditTxt;
        private Label LNameEditLbl;
        private TextBox FNameEditTxt;
        private Label FNameEditLbl;
        private Panel findstdpnl;
        private Label rollNoEditlbl;
        private Button editStdbtn;
        private TextBox rollNoEdittxt;
        private Button UpdateBtn;
        private Panel panel2;
        private RadioButton MaleTeacherTxt;
        private RadioButton FemaleTeacherTxt;
        private Label salaryLbl;

        private Label label2;
        private ComboBox comboBox2;
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
        private TextBox salaryTxt;
        private ComboBox depTeacherCombo;
        private TabPage tabPage5;
        private Label label11;
        private DataGridView dataGridView2;
        private TabPage tabPage6;
        private Panel panel4;
        private TextBox SalaryTeacherEditTxt;
        private Label label16;
        private TextBox QualificationEditTeacherTxt;
        private Button UpdateEditTeacherBtn;
        private Label label10;
        private TextBox AddressEditTeacherTxt;
        private Label label12;
        private TextBox ContactEditTeacherTxt;
        private Label label13;
        private TextBox LNameEditTeacherTxt;
        private Label label14;
        private TextBox FNameEditTeacherTxt;
        private Label label15;
        private Panel panel3;
        private Label label1;
        private Button FindEditTeacherBtn;
        private TextBox TIDEditTeacherTxt;
        private Button AddTeacherbtn;
        private Label label17;
        private ComboBox courseTxt;
        private Label label18;
        private CheckedListBox courseBox;
        private PictureBox pictureBox1;
    }
}