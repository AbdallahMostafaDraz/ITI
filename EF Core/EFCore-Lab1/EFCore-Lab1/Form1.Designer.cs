namespace EFCore_Lab1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            DeleteDept_BTN = new Button();
            ChangeDept_BTN = new Button();
            AddDept_BTN = new Button();
            DeptLocation_TXT = new TextBox();
            label4 = new Label();
            DeptName_TXT = new TextBox();
            label3 = new Label();
            DeptID_TXT = new TextBox();
            label2 = new Label();
            Department_ComboBox = new ComboBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            EmpDept_COMBO = new ComboBox();
            label5 = new Label();
            DeleteEmp_BTN = new Button();
            ChangeEmp_BTN = new Button();
            AddEmp_BTN = new Button();
            EmpName_TXT = new TextBox();
            label6 = new Label();
            EmpID_TXT = new TextBox();
            label7 = new Label();
            Exit_BTN = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.Controls.Add(DeleteDept_BTN);
            groupBox1.Controls.Add(ChangeDept_BTN);
            groupBox1.Controls.Add(AddDept_BTN);
            groupBox1.Controls.Add(DeptLocation_TXT);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(DeptName_TXT);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(DeptID_TXT);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(Department_ComboBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(90, 17);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(629, 367);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Departments";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // DeleteDept_BTN
            // 
            DeleteDept_BTN.Location = new Point(442, 308);
            DeleteDept_BTN.Name = "DeleteDept_BTN";
            DeleteDept_BTN.Size = new Size(94, 31);
            DeleteDept_BTN.TabIndex = 10;
            DeleteDept_BTN.Text = "Delete";
            DeleteDept_BTN.UseVisualStyleBackColor = true;
            DeleteDept_BTN.Click += DeleteDept_BTN_Click;
            // 
            // ChangeDept_BTN
            // 
            ChangeDept_BTN.Location = new Point(342, 308);
            ChangeDept_BTN.Name = "ChangeDept_BTN";
            ChangeDept_BTN.Size = new Size(94, 31);
            ChangeDept_BTN.TabIndex = 9;
            ChangeDept_BTN.Text = "Change";
            ChangeDept_BTN.UseVisualStyleBackColor = true;
            ChangeDept_BTN.Click += ChangeDept_BTN_Click;
            // 
            // AddDept_BTN
            // 
            AddDept_BTN.Location = new Point(242, 308);
            AddDept_BTN.Name = "AddDept_BTN";
            AddDept_BTN.Size = new Size(94, 31);
            AddDept_BTN.TabIndex = 8;
            AddDept_BTN.Text = "Add";
            AddDept_BTN.UseVisualStyleBackColor = true;
            AddDept_BTN.Click += AddDept_BTN_Click;
            // 
            // DeptLocation_TXT
            // 
            DeptLocation_TXT.Location = new Point(236, 247);
            DeptLocation_TXT.Name = "DeptLocation_TXT";
            DeptLocation_TXT.Size = new Size(301, 31);
            DeptLocation_TXT.TabIndex = 7;
            DeptLocation_TXT.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 250);
            label4.Name = "label4";
            label4.Size = new Size(198, 25);
            label4.TabIndex = 6;
            label4.Text = "Department Location:";
            // 
            // DeptName_TXT
            // 
            DeptName_TXT.Location = new Point(236, 198);
            DeptName_TXT.Name = "DeptName_TXT";
            DeptName_TXT.Size = new Size(301, 31);
            DeptName_TXT.TabIndex = 5;
            DeptName_TXT.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 198);
            label3.Name = "label3";
            label3.Size = new Size(175, 25);
            label3.TabIndex = 4;
            label3.Text = "Department Name:";
            // 
            // DeptID_TXT
            // 
            DeptID_TXT.BackColor = Color.White;
            DeptID_TXT.Location = new Point(236, 148);
            DeptID_TXT.Name = "DeptID_TXT";
            DeptID_TXT.Size = new Size(301, 31);
            DeptID_TXT.TabIndex = 3;
            DeptID_TXT.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 147);
            label2.Name = "label2";
            label2.Size = new Size(144, 25);
            label2.TabIndex = 2;
            label2.Text = "Department ID:";
            // 
            // Department_ComboBox
            // 
            Department_ComboBox.BackColor = Color.White;
            Department_ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            Department_ComboBox.FormattingEnabled = true;
            Department_ComboBox.Location = new Point(236, 69);
            Department_ComboBox.Name = "Department_ComboBox";
            Department_ComboBox.Size = new Size(301, 33);
            Department_ComboBox.TabIndex = 1;
            Department_ComboBox.SelectedIndexChanged += Department_ComboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 69);
            label1.Name = "label1";
            label1.Size = new Size(175, 25);
            label1.TabIndex = 0;
            label1.Text = "Department Name:";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top;
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(EmpDept_COMBO);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(DeleteEmp_BTN);
            groupBox2.Controls.Add(ChangeEmp_BTN);
            groupBox2.Controls.Add(AddEmp_BTN);
            groupBox2.Controls.Add(EmpName_TXT);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(EmpID_TXT);
            groupBox2.Controls.Add(label7);
            groupBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(90, 390);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(629, 302);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Employees";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // button1
            // 
            button1.Location = new Point(442, 194);
            button1.Name = "button1";
            button1.Size = new Size(94, 31);
            button1.TabIndex = 15;
            button1.Text = ">";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(342, 194);
            button2.Name = "button2";
            button2.Size = new Size(94, 31);
            button2.TabIndex = 14;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(242, 194);
            button3.Name = "button3";
            button3.Size = new Size(94, 31);
            button3.TabIndex = 13;
            button3.Text = "<";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // EmpDept_COMBO
            // 
            EmpDept_COMBO.DropDownStyle = ComboBoxStyle.DropDownList;
            EmpDept_COMBO.FormattingEnabled = true;
            EmpDept_COMBO.Location = new Point(238, 142);
            EmpDept_COMBO.Name = "EmpDept_COMBO";
            EmpDept_COMBO.Size = new Size(301, 33);
            EmpDept_COMBO.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 142);
            label5.Name = "label5";
            label5.Size = new Size(175, 25);
            label5.TabIndex = 11;
            label5.Text = "Department Name:";
            // 
            // DeleteEmp_BTN
            // 
            DeleteEmp_BTN.Location = new Point(440, 231);
            DeleteEmp_BTN.Name = "DeleteEmp_BTN";
            DeleteEmp_BTN.Size = new Size(94, 31);
            DeleteEmp_BTN.TabIndex = 10;
            DeleteEmp_BTN.Text = "Delete";
            DeleteEmp_BTN.UseVisualStyleBackColor = true;
            DeleteEmp_BTN.Click += DeleteEmp_BTN_Click;
            // 
            // ChangeEmp_BTN
            // 
            ChangeEmp_BTN.Location = new Point(340, 231);
            ChangeEmp_BTN.Name = "ChangeEmp_BTN";
            ChangeEmp_BTN.Size = new Size(94, 31);
            ChangeEmp_BTN.TabIndex = 9;
            ChangeEmp_BTN.Text = "Change";
            ChangeEmp_BTN.UseVisualStyleBackColor = true;
            ChangeEmp_BTN.Click += ChangeEmp_BTN_Click;
            // 
            // AddEmp_BTN
            // 
            AddEmp_BTN.Location = new Point(240, 231);
            AddEmp_BTN.Name = "AddEmp_BTN";
            AddEmp_BTN.Size = new Size(94, 31);
            AddEmp_BTN.TabIndex = 8;
            AddEmp_BTN.Text = "Add";
            AddEmp_BTN.UseVisualStyleBackColor = true;
            AddEmp_BTN.Click += button5_Click;
            // 
            // EmpName_TXT
            // 
            EmpName_TXT.Location = new Point(236, 95);
            EmpName_TXT.Name = "EmpName_TXT";
            EmpName_TXT.Size = new Size(301, 31);
            EmpName_TXT.TabIndex = 5;
            EmpName_TXT.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 95);
            label6.Name = "label6";
            label6.Size = new Size(155, 25);
            label6.TabIndex = 4;
            label6.Text = "Employee Name:";
            // 
            // EmpID_TXT
            // 
            EmpID_TXT.BackColor = Color.White;
            EmpID_TXT.Location = new Point(236, 48);
            EmpID_TXT.Name = "EmpID_TXT";
            EmpID_TXT.Size = new Size(301, 31);
            EmpID_TXT.TabIndex = 3;
            EmpID_TXT.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(36, 47);
            label7.Name = "label7";
            label7.Size = new Size(129, 25);
            label7.TabIndex = 2;
            label7.Text = "Employee ID: ";
            // 
            // Exit_BTN
            // 
            Exit_BTN.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Exit_BTN.Location = new Point(90, 701);
            Exit_BTN.Name = "Exit_BTN";
            Exit_BTN.Size = new Size(629, 35);
            Exit_BTN.TabIndex = 9;
            Exit_BTN.Text = "Exit";
            Exit_BTN.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 751);
            Controls.Add(Exit_BTN);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox DeptName_TXT;
        private Label label3;
        private TextBox DeptID_TXT;
        private Label label2;
        private ComboBox Department_ComboBox;
        private Label label1;
        private TextBox DeptLocation_TXT;
        private Label label4;
        private Button ChangeDept_BTN;
        private Button AddDept_BTN;
        private Button DeleteDept_BTN;
        private GroupBox groupBox2;
        private Button DeleteEmp_BTN;
        private Button ChangeEmp_BTN;
        private Button AddEmp_BTN;
        private TextBox EmpName_TXT;
        private Label label6;
        private TextBox EmpID_TXT;
        private Label label7;
        private Button Exit_BTN;
        private ComboBox EmpDept_COMBO;
        private Label label5;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
