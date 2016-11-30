using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataListEmployer
{
    public partial class Form1 : Form
    {
        public static Employee employee;
        public static List<Employee> employees;
        public static int employeeID = 1;
        public static string surname;
        public static string name;
        public static DateTime date_Of_Employment;
        public static double salary;
        
        public Form1()
        {
            var date_Of_Employment = new DateTime { };
            employees = new List<Employee>();
            InitializeComponent();
            LoadToEmployersList();
            ResultTextBox.Text = RefreshString();
            foreach (var employee in employees)
            {
                RemoveComboBox.Items.Add(employee.Surname + " " + employee.Name);
            }
            RemoveComboBox.Text = "Choice...";
        }

        internal static void LoadToEmployersList()
        {
            string lineFromFile = "";
            string[] strArray = new string[] { };
            using (System.IO.StreamReader file =
               new System.IO.StreamReader(@"D:\job\projects\DataListEmployer\WriteData.txt"))
                lineFromFile = file.ReadToEnd();
            strArray = lineFromFile.Split(' ');

            for (int i = 1; i <= strArray.Length - 6; i += 6)
            {
                employeeID = int.Parse(strArray[i]);
                surname = strArray[i + 1];
                name = strArray[i + 2];
                date_Of_Employment = DateTime.Parse(strArray[i + 3]);
                salary = double.Parse(strArray[i + 4]);
                AddEmployer();
            }
        }

        internal static void AddEmployer()
        {
            employeeID++;
            employee = new Employee(employeeID, surname, name, date_Of_Employment, salary);
            employees.Add(employee);
            RefreshString();
        }

        private void AddEmployerButton_Click(object sender, EventArgs e)
        {
            surname = SurnameTextBox.Text;
            name = NameTextBox.Text;
            date_Of_Employment = Convert.ToDateTime(DateTextBox.Text);
            salary = double.Parse(SalaryTextBox.Text);
            AddEmployer();
            SaveToFile();
            RemoveComboBox.Items.Add(surname + " " + name);
            RemoveComboBox.Text = "Choice...";
            SurnameTextBox.Clear();
            DateTextBox.Clear();
            NameTextBox.Clear();
            SalaryTextBox.Clear();
            ResultTextBox.Clear();
            ResultTextBox.Text = RefreshString();
            AddEmployerButton.Visible = false;
        }

        internal static void RemoveEmployer(object fullEmployeeName)
        {
            string[] arrSrr = new string[] { };
            arrSrr = fullEmployeeName.ToString().Split(' ');
            foreach (var employee in employees)
            {
                if (employee.Surname == arrSrr[0])
                {
                    employees.Remove(employee);
                    break;
                }
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (RemoveComboBox.SelectedItem != null)
            {
                RemoveEmployer(RemoveComboBox.SelectedItem);
                RemoveComboBox.Items.Remove(RemoveComboBox.SelectedItem);
                RemoveComboBox.Text = "Choice...";
                ResultTextBox.Clear();
                ResultTextBox.Text = RefreshString();
                SaveToFile();
                RemoveButton.Visible = false;
            }
        }

        internal static string RefreshString()
        {
            string resultStr = "";
            int index = 0;
            foreach (var employee in employees)
            {
                index++;
                resultStr += " " + index.ToString() +
                             " " + employee.Surname.ToString() +
                             " " + employee.Name.ToString() +
                             " " + employee.Date_Of_Employment.Day.ToString() +
                             "." + employee.Date_Of_Employment.Month.ToString() +
                             "." + employee.Date_Of_Employment.Year.ToString() +
                             " " + employee.Salary.ToString() + " " + "$" + "\r\n";
            }
            return resultStr;
        }

        internal static void SaveToFile()
        {
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"D:\job\projects\DataListEmployer\WriteData.txt"))
                file.WriteLine(RefreshString());
        }

        private void SurnameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
            if ((SurnameTextBox.Text != "") &&
                   (NameTextBox.Text != "") &&
                   (DateTextBox.Text != "") &&
                   (SalaryTextBox.Text != ""))
                AddEmployerButton.Visible = true;
        }

        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
            if ((SurnameTextBox.Text != "") &&
                   (NameTextBox.Text != "") &&
                   (DateTextBox.Text != "") &&
                   (SalaryTextBox.Text != ""))
                AddEmployerButton.Visible = true;
        }

        private void DateTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(46) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
            if ((SurnameTextBox.Text != "") &&
                   (NameTextBox.Text != "") &&
                   (DateTextBox.Text != "") &&
                   (SalaryTextBox.Text != ""))
                AddEmployerButton.Visible = true;
        }

        private void SalaryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(44) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
            if ((SurnameTextBox.Text != "") &&
                   (NameTextBox.Text != "") &&
                   (DateTextBox.Text != "") &&
                   (SalaryTextBox.Text != ""))
                AddEmployerButton.Visible = true;
        }

        private void RemoveComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemoveButton.Visible = true;
        }

        private void SurnameTextBox_Enter(object sender, EventArgs e)
        {
            ToolTip ttSur = new ToolTip();
            ttSur.IsBalloon = true;
            ttSur.InitialDelay = 0;
            ttSur.ShowAlways = true;
            ttSur.SetToolTip(SurnameTextBox, "Only Letter");
        }

        private void NameTextBox_Enter(object sender, EventArgs e)
        {
            ToolTip ttName = new ToolTip();
            ttName.IsBalloon = true;
            ttName.InitialDelay = 0;
            ttName.ShowAlways = true;
            ttName.SetToolTip(NameTextBox, "Only Letter");
        }

        private void DateTextBox_Enter(object sender, EventArgs e)
        {
            ToolTip ttDate = new ToolTip();
            ttDate.IsBalloon = true;
            ttDate.InitialDelay = 0;
            ttDate.ShowAlways = true;
            ttDate.SetToolTip(DateTextBox, "Enter date 20.12.2000");
        }

        private void SalaryTextBox_Enter(object sender, EventArgs e)
        {
            ToolTip ttSalary = new ToolTip();
            ttSalary.IsBalloon = true;
            ttSalary.InitialDelay = 0;
            ttSalary.ShowAlways = true;
            ttSalary.SetToolTip(SalaryTextBox, "Enter digit 1,234");
        }
    }
}
