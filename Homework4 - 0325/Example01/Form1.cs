using EmployeeLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example01
{
    public partial class Form1 : Form
    {
        private List<Employee> employees;

        public Form1()
        {
            InitializeComponent();
            employees = new List<Employee>();
            employeeCatagory.SelectedIndex = 0;  //選單項目顯示
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //Employee employee = new Employee();
            //employee.Id = idTextBox.Text;
            //employee.Name = nameTextBox.Text;
            //employee.BaseSalary = int.Parse(baseSalaryTextBox.Text);

            //  Employee employee = new Employee(idTextBox.Text, nameTextBox.Text, baseSalaryTextBox.Text);
            Employee employee = null;
            if (employeeCatagory.SelectedIndex == 0)
            {
                employee = new Employee(idTextBox.Text, nameTextBox.Text, baseSalaryTextBox.Text);
            }
            else if (employeeCatagory.SelectedIndex == 1)
            {
                employee = new Sales(idTextBox.Text, nameTextBox.Text, baseSalaryTextBox.Text, performanceTextBox.Text);
            }
            else if (employeeCatagory.SelectedIndex == 2)
            {
                employee = new Manager(idTextBox.Text, nameTextBox.Text, baseSalaryTextBox.Text, otherBounsTextBox.Text);
            }
            else
            {
                employee = new Engineer(idTextBox.Text, nameTextBox.Text, baseSalaryTextBox.Text, performanceTextBox.Text, otherBounsTextBox.Text);
            }
            employees.Add(employee);
            UpdateEmployeesInfo();
        }

        private void UpdateEmployeesInfo()
        {
            inforRichTextBox.Text = string.Empty;
            idTextBox.Text = string.Empty;
            nameTextBox.Text = string.Empty;
            baseSalaryTextBox.Text = string.Empty;

            foreach (Employee employee in employees)
            {
                inforRichTextBox.Text += string.Format("{0}\n", employee);
            }
        }

        private void employeeCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            performanceLabel.Visible = employeeCatagory.SelectedIndex == 1 | employeeCatagory.SelectedIndex == 3;
            performanceTextBox.Visible = employeeCatagory.SelectedIndex == 1 | employeeCatagory.SelectedIndex == 3;
            otherBounsLabel.Visible = employeeCatagory.SelectedIndex == 2 | employeeCatagory.SelectedIndex == 3;
            otherBounsTextBox.Visible = employeeCatagory.SelectedIndex == 2 | employeeCatagory.SelectedIndex == 3;
        }
    }
}