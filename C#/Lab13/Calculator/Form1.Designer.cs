namespace Calculator
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
            TextCalculator = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            zeroBTN = new Button();
            clearBTN = new Button();
            dotBTN = new Button();
            addBTN = new Button();
            subtractBTN = new Button();
            multiplyBTN = new Button();
            divisionBTN = new Button();
            equalBTN = new Button();
            modulasBTN = new Button();
            SuspendLayout();
            // 
            // TextCalculator
            // 
            TextCalculator.Dock = DockStyle.Top;
            TextCalculator.Location = new Point(0, 0);
            TextCalculator.Name = "TextCalculator";
            TextCalculator.Size = new Size(451, 27);
            TextCalculator.TabIndex = 0;
            TextCalculator.TextAlign = HorizontalAlignment.Center;
            TextCalculator.KeyPress += TextCalculator_KeyPress;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.Location = new Point(16, 77);
            button1.Name = "button1";
            button1.Size = new Size(66, 54);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.Location = new Point(114, 77);
            button2.Name = "button2";
            button2.Size = new Size(66, 54);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button3.Location = new Point(225, 77);
            button3.Name = "button3";
            button3.Size = new Size(66, 54);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button1_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button4.Location = new Point(16, 167);
            button4.Name = "button4";
            button4.Size = new Size(66, 54);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button1_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button5.Location = new Point(114, 168);
            button5.Name = "button5";
            button5.Size = new Size(66, 54);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button1_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button6.Location = new Point(225, 168);
            button6.Name = "button6";
            button6.Size = new Size(66, 54);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button1_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.White;
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button7.Location = new Point(16, 259);
            button7.Name = "button7";
            button7.Size = new Size(66, 54);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button1_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.White;
            button8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button8.Location = new Point(114, 259);
            button8.Name = "button8";
            button8.Size = new Size(66, 54);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button1_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.White;
            button9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button9.Location = new Point(225, 259);
            button9.Name = "button9";
            button9.Size = new Size(66, 54);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button1_Click;
            // 
            // zeroBTN
            // 
            zeroBTN.BackColor = Color.White;
            zeroBTN.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            zeroBTN.Location = new Point(114, 341);
            zeroBTN.Name = "zeroBTN";
            zeroBTN.Size = new Size(66, 54);
            zeroBTN.TabIndex = 10;
            zeroBTN.Text = "0";
            zeroBTN.UseVisualStyleBackColor = false;
            zeroBTN.Click += button1_Click;
            // 
            // clearBTN
            // 
            clearBTN.BackColor = Color.White;
            clearBTN.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            clearBTN.Location = new Point(16, 341);
            clearBTN.Name = "clearBTN";
            clearBTN.Size = new Size(66, 54);
            clearBTN.TabIndex = 11;
            clearBTN.Text = "C";
            clearBTN.UseVisualStyleBackColor = false;
            clearBTN.Click += clearBTN_Click;
            // 
            // dotBTN
            // 
            dotBTN.BackColor = Color.White;
            dotBTN.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dotBTN.Location = new Point(225, 341);
            dotBTN.Name = "dotBTN";
            dotBTN.Size = new Size(66, 54);
            dotBTN.TabIndex = 12;
            dotBTN.Text = ".";
            dotBTN.UseVisualStyleBackColor = false;
            dotBTN.Click += dotBTN_Click;
            // 
            // addBTN
            // 
            addBTN.BackColor = Color.White;
            addBTN.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            addBTN.ForeColor = SystemColors.HotTrack;
            addBTN.Location = new Point(342, 77);
            addBTN.Name = "addBTN";
            addBTN.Size = new Size(66, 51);
            addBTN.TabIndex = 13;
            addBTN.Text = "+";
            addBTN.UseVisualStyleBackColor = false;
            addBTN.Click += button13_Click;
            // 
            // subtractBTN
            // 
            subtractBTN.BackColor = Color.White;
            subtractBTN.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            subtractBTN.ForeColor = SystemColors.HotTrack;
            subtractBTN.Location = new Point(342, 167);
            subtractBTN.Name = "subtractBTN";
            subtractBTN.Size = new Size(66, 54);
            subtractBTN.TabIndex = 14;
            subtractBTN.Text = "-";
            subtractBTN.UseVisualStyleBackColor = false;
            subtractBTN.Click += button13_Click;
            // 
            // multiplyBTN
            // 
            multiplyBTN.BackColor = Color.White;
            multiplyBTN.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            multiplyBTN.ForeColor = SystemColors.HotTrack;
            multiplyBTN.Location = new Point(342, 259);
            multiplyBTN.Name = "multiplyBTN";
            multiplyBTN.Size = new Size(66, 54);
            multiplyBTN.TabIndex = 15;
            multiplyBTN.Text = "X";
            multiplyBTN.UseVisualStyleBackColor = false;
            multiplyBTN.Click += button13_Click;
            // 
            // divisionBTN
            // 
            divisionBTN.BackColor = Color.White;
            divisionBTN.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            divisionBTN.ForeColor = SystemColors.HotTrack;
            divisionBTN.Location = new Point(342, 344);
            divisionBTN.Name = "divisionBTN";
            divisionBTN.Size = new Size(66, 54);
            divisionBTN.TabIndex = 16;
            divisionBTN.Text = "/";
            divisionBTN.UseVisualStyleBackColor = false;
            divisionBTN.Click += button13_Click;
            // 
            // equalBTN
            // 
            equalBTN.BackColor = Color.White;
            equalBTN.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            equalBTN.ForeColor = SystemColors.HotTrack;
            equalBTN.Location = new Point(16, 426);
            equalBTN.Name = "equalBTN";
            equalBTN.Size = new Size(275, 54);
            equalBTN.TabIndex = 17;
            equalBTN.Text = "=";
            equalBTN.UseVisualStyleBackColor = false;
            equalBTN.Click += button17_Click;
            // 
            // modulasBTN
            // 
            modulasBTN.BackColor = Color.White;
            modulasBTN.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            modulasBTN.ForeColor = SystemColors.HotTrack;
            modulasBTN.Location = new Point(342, 426);
            modulasBTN.Name = "modulasBTN";
            modulasBTN.Size = new Size(66, 54);
            modulasBTN.TabIndex = 18;
            modulasBTN.Text = "%";
            modulasBTN.UseVisualStyleBackColor = false;
            modulasBTN.Click += button13_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 505);
            Controls.Add(modulasBTN);
            Controls.Add(equalBTN);
            Controls.Add(divisionBTN);
            Controls.Add(multiplyBTN);
            Controls.Add(subtractBTN);
            Controls.Add(addBTN);
            Controls.Add(dotBTN);
            Controls.Add(clearBTN);
            Controls.Add(zeroBTN);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(TextCalculator);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void DivisionBTN_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TextBox TextCalculator;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button zeroBTN;
        private Button clearBTN;
        private Button dotBTN;
        private Button addBTN;
        private Button subtractBTN;
        private Button multiplyBTN;
        private Button divisionBTN;
        private Button equalBTN;
        private Button modulasBTN;
    }
}
