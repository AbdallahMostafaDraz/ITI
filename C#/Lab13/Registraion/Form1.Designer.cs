namespace Registraion
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
            txtConfirmPassword = new TextBox();
            label7 = new Label();
            txtPassword = new TextBox();
            label6 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            txtAddress = new TextBox();
            label4 = new Label();
            txtAge = new TextBox();
            label3 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            txtID = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            txtPhone = new TextBox();
            label8 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtConfirmPassword);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtAge);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(81, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(633, 534);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Data";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(291, 462);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(307, 34);
            txtConfirmPassword.TabIndex = 13;
            txtConfirmPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(83, 464);
            label7.Name = "label7";
            label7.Size = new Size(188, 28);
            label7.TabIndex = 12;
            label7.Text = "Confrim Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(291, 407);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(307, 34);
            txtPassword.TabIndex = 11;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(83, 409);
            label6.Name = "label6";
            label6.Size = new Size(106, 28);
            label6.TabIndex = 10;
            label6.Text = "Password:";
            label6.Click += label6_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(291, 345);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(307, 34);
            txtEmail.TabIndex = 9;
            txtEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(83, 347);
            label5.Name = "label5";
            label5.Size = new Size(75, 28);
            label5.TabIndex = 8;
            label5.Text = "Email: ";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(291, 236);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(307, 34);
            txtAddress.TabIndex = 7;
            txtAddress.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(83, 238);
            label4.Name = "label4";
            label4.Size = new Size(98, 28);
            label4.TabIndex = 6;
            label4.Text = "Address: ";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(291, 178);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(307, 34);
            txtAge.TabIndex = 5;
            txtAge.TextAlign = HorizontalAlignment.Center;
            txtAge.KeyPress += txtID_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(83, 180);
            label3.Name = "label3";
            label3.Size = new Size(60, 28);
            label3.TabIndex = 4;
            label3.Text = "Age: ";
            // 
            // txtName
            // 
            txtName.Location = new Point(291, 123);
            txtName.Name = "txtName";
            txtName.Size = new Size(307, 34);
            txtName.TabIndex = 3;
            txtName.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 125);
            label2.Name = "label2";
            label2.Size = new Size(79, 28);
            label2.TabIndex = 2;
            label2.Text = "Name: ";
            // 
            // txtID
            // 
            txtID.Location = new Point(291, 64);
            txtID.Name = "txtID";
            txtID.Size = new Size(307, 34);
            txtID.TabIndex = 1;
            txtID.TextAlign = HorizontalAlignment.Center;
            txtID.TextChanged += txtID_TextChanged;
            txtID.KeyPress += txtID_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 66);
            label1.Name = "label1";
            label1.Size = new Size(44, 28);
            label1.TabIndex = 0;
            label1.Text = "ID: ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Location = new Point(81, 586);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(634, 87);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.Location = new Point(291, 26);
            button2.Name = "button2";
            button2.Size = new Size(207, 41);
            button2.TabIndex = 1;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(75, 26);
            button1.Name = "button1";
            button1.Size = new Size(207, 41);
            button1.TabIndex = 0;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(291, 290);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(307, 34);
            txtPhone.TabIndex = 15;
            txtPhone.TextAlign = HorizontalAlignment.Center;
            txtPhone.KeyPress += txtID_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(83, 292);
            label8.Name = "label8";
            label8.Size = new Size(71, 28);
            label8.TabIndex = 14;
            label8.Text = "Phone";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 715);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtPassword;
        private Label label6;
        private TextBox txtEmail;
        private Label label5;
        private TextBox txtAddress;
        private Label label4;
        private TextBox txtAge;
        private Label label3;
        private TextBox txtName;
        private Label label2;
        private TextBox txtID;
        private Label label1;
        private TextBox txtConfirmPassword;
        private Label label7;
        private GroupBox groupBox2;
        private Button button1;
        private Button button2;
        private TextBox txtPhone;
        private Label label8;
    }
}
