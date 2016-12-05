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
using System.Xml;

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

        internal int GenerateNewEmployeeID()
        {
            int iD = -1;
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].EmployeeID >= iD)
                    iD = employees[i].EmployeeID;
            }
            return iD += 1;
        }

        internal void LoadToEmployersList()
        {
            try
            {
                XmlDocument employeeDoc = new XmlDocument();
                employeeDoc.Load("WriteData.xml");

                foreach (XmlNode node in employeeDoc)
                {
                    if ("employees".Equals(node.Name))
                    {
                        for (XmlNode employeeNode = node.FirstChild; employeeNode != null; employeeNode = employeeNode.NextSibling)
                        {
                            var employee = new Employee();
                            if ("employee".Equals(employeeNode.Name))
                            {
                                employee.LoadFromNode(employeeNode);
                                AddEmployer(employee);
                            }
                        }
                    }
                }
            }
            catch (Exception e) { MessageBox.Show("exeption" + e.Message); }
            RefreshForm();
        }

        internal void AddEmployer(Employee employee)
        {
            employees.Add(employee);
            SurnameTextBox.Clear();
            DateTextBox.Clear();
            NameTextBox.Clear();
            SalaryTextBox.Clear();
        }

        private void AddEmployerButton_Click(object sender, EventArgs e)
        {
            int employeeID = GenerateNewEmployeeID();
            string surname = SurnameTextBox.Text;
            string name = NameTextBox.Text;
            DateTime date_Of_Employment = DateTime.Parse(DateTextBox.Text);
            double salary = double.Parse(SalaryTextBox.Text);
            var employee = new Employee(employeeID, surname, name, date_Of_Employment, salary);

            AddEmployer(employee);
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
            //XmlTextWriter writer = new XmlTextWriter("WriteData.xml", Encoding.UTF8);
            //writer.Formatting = Formatting.Indented;
            //writer.WriteStartDocument();
            //writer.WriteStartElement("employees");
            //foreach (var employee in employees)
            //{
            //    writer.WriteStartElement("employee");
            //    writer.WriteAttributeString("employyeeID", employee.EmployeeID.ToString());
            //    writer.WriteAttributeString("surname", employee.Surname);
            //    writer.WriteAttributeString("name", employee.Name);
            //    writer.WriteAttributeString("date", employee.Date_Of_Employment.ToString("dd.MM.yyyy H:mm"));
            //    writer.WriteAttributeString("salary", employee.Salary.ToString());
            //    writer.WriteEndElement();
            //}
            //writer.WriteEndElement();
            //writer.WriteEndDocument();
            //writer.Flush();
            //writer.Close();

            XmlTextWriter employeeWritter = new XmlTextWriter("WriteData.xml", Encoding.UTF8);
            employeeWritter.WriteStartDocument();
            employeeWritter.WriteStartElement("employees");
            employeeWritter.WriteEndElement();
            employeeWritter.Close();

            foreach (var employee in employees)
            {
                employee.LoadToNode(employee);
            }
        }

        internal void RefreshForm()
        {
            EmployeeDataGridView.Rows.Clear();
            RemoveComboBox.Items.Clear();
            ResultTextBox.Clear();
            foreach (var employee in employees)
            {
                RemoveComboBox.Items.Add(employee.Surname + " " + employee.Name);
                ResultTextBox.Text += employee.SaveToString(employee, Employee.EmployeeToStringMode.displayInfo);
                EmployeeDataGridView.Rows.Add(employee.EmployeeID.ToString(), employee.Surname, employee.Name,
                    employee.Date_Of_Employment.ToString("ddd dd MMMM yyyy HH:mm"),
                    employee.Salary.ToString("$ #,###"));
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
            if (!Char.IsDigit(e.KeyChar)
                && e.KeyChar != Convert.ToChar(44)
                && e.KeyChar != Convert.ToChar(8))
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

        private void RemoveComboBox_Enter(object sender, EventArgs e)
        {
            ToolTipAdd().SetToolTip(RemoveComboBox, "Choice employee to remove");
        }

        private ToolTip ToolTipAdd()
        {
            ToolTip tt = new ToolTip();
            tt.IsBalloon = true;
            tt.InitialDelay = 0;
            tt.ShowAlways = true;
            return tt;
        }
    }
}
