using EFCore_Lab1.Data;
using EFCore_Lab1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace EFCore_Lab1
{
    public partial class Form1 : Form
    {
        AppDBContext _context = new AppDBContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (_context.Employees.FirstOrDefault(e => e.Id == int.Parse(EmpID_TXT.Text)) != null)
            {
                MessageBox.Show("This Employee ID Is Already Exist!", "Duplicated Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Employee empToAdd = new Employee()
                {
                    Id = int.Parse(EmpID_TXT.Text),
                    Name = EmpName_TXT.Text,
                    DepartmentId = int.Parse(EmpDept_COMBO.SelectedValue!.ToString()!)
                };
                _context.Employees.Add(empToAdd);
                _context.SaveChanges();
                MessageBox.Show("Employee Add Successfullyt!", "Data Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EmpID_TXT.Text = EmpName_TXT.Text = "";
                Form1_Load(sender, e);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var allDepartments = _context.Departments;
            Department_ComboBox.DataSource = allDepartments.ToList();
            Department_ComboBox.DisplayMember = "Name";
            Department_ComboBox.ValueMember = "ID";
            
            DeptID_TXT.Text = DeptName_TXT.Text = DeptLocation_TXT.Text = Department_ComboBox.Text = 
                EmpDept_COMBO.Text = "";
         
            EmpDept_COMBO.DataSource = allDepartments.ToList();
            EmpDept_COMBO.DisplayMember = "Name";
            EmpDept_COMBO.ValueMember = "ID";
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void AddDept_BTN_Click(object sender, EventArgs e)
        {
            if (_context.Departments.FirstOrDefault(e => e.Id == int.Parse(DeptID_TXT.Text)) != null)
            {
                MessageBox.Show("This Department ID Is Already Exist!", "Duplicated Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Department departmentToAdd = new Department()
                {
                    Id = int.Parse(DeptID_TXT.Text),
                    Name = DeptName_TXT.Text,
                    Location = DeptLocation_TXT.Text,
                };
                _context.Departments.Add(departmentToAdd);
                _context.SaveChanges();
                MessageBox.Show("Department Add Successfullyt!", "Data Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1_Load(sender, e);
            }
        }

        private void Department_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        
                Department department = (Department)Department_ComboBox.SelectedItem!;
                DeptID_TXT.Text = department.Id.ToString();
                DeptName_TXT.Text = department.Name;
                DeptLocation_TXT.Text = department.Location;
            
        }

        private void ChangeDept_BTN_Click(object sender, EventArgs e)
        {
            if (Department_ComboBox.Text != "")
            {

                var departmenttToUpdate = _context.Departments.FirstOrDefault(e => e.Id == int.Parse(Department_ComboBox.SelectedValue!.ToString()!));


                departmenttToUpdate!.Name = DeptName_TXT.Text;
                departmenttToUpdate.Location = DeptLocation_TXT.Text;
                _context.SaveChanges();
                MessageBox.Show("Department Updated Successfullyt!", "Data Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1_Load(sender, e);
            }
        }

        private void DeleteDept_BTN_Click(object sender, EventArgs e)
        {

            if (Department_ComboBox.Text != "")
            {
                var departmenttToDelete = _context.Departments.AsNoTracking().
                    FirstOrDefault(e => e.Id == int.Parse(Department_ComboBox.SelectedValue!.ToString()!));
                _context.Departments.Remove(departmenttToDelete!);
                _context.SaveChanges();
                MessageBox.Show("Department Deleted Successfullyt!", "Data Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1_Load(sender, e);

            }
        }

        private void ChangeEmp_BTN_Click(object sender, EventArgs e)
        {

            if (EmpName_TXT.Text != "")
            {

                var empToUpdate = _context.Employees.FirstOrDefault(e => e.Id == int.Parse(EmpID_TXT.Text!));

                empToUpdate!.Name = EmpName_TXT.Text;
                empToUpdate.DepartmentId = int.Parse(EmpDept_COMBO.SelectedValue!.ToString()!);
                _context.SaveChanges();
                MessageBox.Show("Employee Updated Successfullyt!", "Data Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EmpID_TXT.Text = EmpName_TXT.Text = "";
                Form1_Load(sender, e);
                AddEmp_BTN.Enabled = true;
                EmpID_TXT.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please Selcet A Deprtment!", "Incompleted Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Enter Employee ID:");

            if (int.TryParse(input, out int empId))
            {
                var employee = _context.Employees.AsNoTracking().FirstOrDefault(e => e.Id == empId);
                if (employee != null)
                {
                    EmpID_TXT.Text = employee.Id.ToString();
                    EmpName_TXT.Text = employee.Name;
                    EmpDept_COMBO.SelectedValue = employee.DepartmentId;
                    AddEmp_BTN.Enabled = false;
                    EmpID_TXT.Enabled = false;
                }
                else
                {
                    MessageBox.Show("There no employees with this ID!", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid ID.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var employee = _context.Employees.FirstOrDefault(e => e.Id == (int.Parse(EmpID_TXT.Text) + 1));
            if (employee != null)
            {
                EmpID_TXT.Text = employee.Id.ToString();
                EmpName_TXT.Text = employee.Name;
                EmpDept_COMBO.SelectedValue = employee.DepartmentId;
            }
            else
            {
                MessageBox.Show("This Is The Last employee!", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var employee = _context.Employees.FirstOrDefault(e => e.Id == (int.Parse(EmpID_TXT.Text) - 1));
            if (employee != null)
            {
                EmpID_TXT.Text = employee.Id.ToString();
                EmpName_TXT.Text = employee.Name;
                EmpDept_COMBO.SelectedValue = employee.DepartmentId;
            }
            else
            {
                MessageBox.Show("This Is The First employee!", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void DeleteEmp_BTN_Click(object sender, EventArgs e)
        {
            if (EmpID_TXT.Text != "")
            {
                var empToDelete = _context.Employees.FirstOrDefault(e => e.Id == int.Parse(EmpID_TXT.Text));
                _context.Employees.Remove(empToDelete!);
                _context.SaveChanges();
                MessageBox.Show("Employee Deleted Successfullyt!", "Data Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1_Load(sender, e);
                EmpID_TXT.Text = EmpName_TXT.Text = "";
                AddEmp_BTN.Enabled = true;
                EmpID_TXT.Enabled = true;
            }
        }

        private void Exit_BTN_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void EmpDept_COMBO_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
