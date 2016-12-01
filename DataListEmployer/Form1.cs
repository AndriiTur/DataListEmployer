using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataListEmployer
{
    public partial class Form1 : Form
    {
        public Employee employee;
        public List<Employee> employees;
        
        public Form1()
        {
            employees = new List<Employee>();
            InitializeComponent();
            LoadToEmployersList();
        }

        internal void LoadToEmployersList()
        {
            string lineFromFile = "";
            string[] strArray = new string[] { };
            if (File.Exists(@"WriteData.txt"))
            {
                using (StreamReader file = new StreamReader(@"WriteData.txt"))
                      lineFromFile = file.ReadToEnd();
                if (lineFromFile != "")
                {
                    strArray = lineFromFile.Split(new string[] { "\r\n" }, StringSplitOptions.None);
                    for (int i = 0; i < strArray.Length; i++)
                    {
                        if (strArray[i] != "")
                        AddEmployer(strArray[i]);
                    }
                    RefreshForm();
                }
            }
        }

        internal void AddEmployer(string employeeStr)
        {
            employees.Add(Employee.LoadFromString(employeeStr));
            SurnameTextBox.Clear();
            DateTextBox.Clear();
            NameTextBox.Clear();
            SalaryTextBox.Clear();
        }

        private void AddEmployerButton_Click(object sender, EventArgs e)
        {
            int employeeID = 1;
            string surname = "";
            string name = "";
            DateTime date_Of_Employment = new DateTime { };
            double salary = 0;
            
            employeeID = employees.Count + 1;
            surname = SurnameTextBox.Text;
            name = NameTextBox.Text;
            date_Of_Employment = DateTime.Parse(DateTextBox.Text);
            salary = double.Parse(SalaryTextBox.Text);
            employee = new Employee(employeeID, surname, name, date_Of_Employment, salary);
            AddEmployer(Employee.SaveToString(employee, Employee.EmployeeToStringMode.store));
            RefreshForm();
            SaveToFile();
            AddEmployerButton.Visible = false;
        }

        internal void RemoveEmployer(int val)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                if (i == val)
                {
                    employees.Remove(employees[i]);
                    break;
                }
            }
            RefreshForm();
            SaveToFile();
            RemoveButton.Visible = false;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (RemoveComboBox.SelectedItem != null)
            {
                RemoveEmployer(RemoveComboBox.SelectedIndex);
                RemoveComboBox.Items.Remove(RemoveComboBox.SelectedItem);
            }
        }

        internal void SaveToFile()
        {
            using (StreamWriter file =
                new StreamWriter(@"WriteData.txt"))
            {
                foreach (var employee in employees)
                file.WriteLine(Employee.SaveToString(employee,Employee.EmployeeToStringMode.store));
            }
        }

        internal void RefreshForm()
        {
            RemoveComboBox.Items.Clear();
            ResultTextBox.Clear();
            foreach (var employee in employees)
            {
                RemoveComboBox.Items.Add(employee.Surname + " " + employee.Name);
                ResultTextBox.Text += Employee.SaveToString(employee, Employee.EmployeeToStringMode.displayInfo);
            }
            RemoveComboBox.Text = "Choice...";
        }

        private void EpdateAddButtonVisibility()
        {
            if ((SurnameTextBox.Text != "") &&
                (NameTextBox.Text != "") &&
                (DateTextBox.Text != "") &&
                (SalaryTextBox.Text != "")
            )
                AddEmployerButton.Visible = true;
        }

        private void SurnameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
            this.EpdateAddButtonVisibility();
        }

        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
            this.EpdateAddButtonVisibility();
        }

        private void DateTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) 
                && e.KeyChar != Convert.ToChar(46) 
                && e.KeyChar != Convert.ToChar(8)
                && e.KeyChar != Convert.ToChar(32)
                && e.KeyChar != Convert.ToChar(58)
               )
            {
                e.Handled = true;
            }
            this.EpdateAddButtonVisibility();
        }

        private void SalaryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(44) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
            this.EpdateAddButtonVisibility();
        }

        private void RemoveComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemoveButton.Visible = true;
        }

        private void SurnameTextBox_Enter(object sender, EventArgs e)
        {
            ToolTipAdd().SetToolTip(SurnameTextBox, "Only Letter");
        }

        private void NameTextBox_Enter(object sender, EventArgs e)
        {
            ToolTipAdd().SetToolTip(NameTextBox, "Only Letter");
        }

        private void DateTextBox_Enter(object sender, EventArgs e)
        {
            ToolTipAdd().SetToolTip(DateTextBox, "Enter date DD.MM.Year and time 00:00");
        }

        private void SalaryTextBox_Enter(object sender, EventArgs e)
        {
            ToolTipAdd().SetToolTip(SalaryTextBox, "Enter digit 1,234");
        }

        private ToolTip ToolTipAdd()
        {
            ToolTip tt = new ToolTip();
            tt.IsBalloon = true;
            tt.InitialDelay = 0;
            tt.ShowAlways = true;
            return tt;
        }

        private void RemoveComboBox_Enter(object sender, EventArgs e)
        {
            ToolTipAdd().SetToolTip(RemoveComboBox, "Choice employee to remove");
        }
    }
}
