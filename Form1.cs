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

namespace ManagerProject
{
    public partial class Form1 : Form
    {
        public Employee employee;
        public List<Employee> employees;

        public Customer customer;
        public List<Customer> customers;

        public Form1()
        {
            employees = new List<Employee>();
            customers = new List<Customer>();
            InitializeComponent();
            LoadToEmployeesList();
            LoadToCustomerList();
        }

        internal int GenerateNewemployeeID()
        {
            int iD = 0;
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].EmployeeID >= iD)
                    iD = employees[i].EmployeeID;
            }
            return iD += 1;
        }

        internal void LoadToEmployeesList()
        {
            if (File.Exists("WriteData.xml"))
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
                                    AddEmployee(employee);
                                }
                            }
                        }
                    }
                }
                catch (Exception e) { MessageBox.Show("exeption" + e.Message); }
                RefreshForm();
            }
        }
        
        internal void AddEmployee(Employee employee)
        {
            employees.Add(employee);
            SurnameTextBox.Clear();
            DateTime result = DateTime.Today.Subtract(TimeSpan.FromDays(0));
            EmployeeDateTimePicker.Value = result;

            NameTextBox.Clear();
            SalaryTextBox.Clear();
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            int employeeID = GenerateNewemployeeID();
            string name = NameTextBox.Text;
            string surname = SurnameTextBox.Text;
            DateTime date_Of_Employment = DateTime.Parse(EmployeeDateTimePicker.Value.ToString("dd MM yy HH:mm"));
            double salary = double.Parse(SalaryTextBox.Text);
            var employee = new Employee(employeeID, name, surname, date_Of_Employment, salary);

            AddEmployee(employee);
            RefreshForm();
            SaveToFile();
            AddEmployeeButton.Visible = false;
        }

        internal void RemoveEmployee(int val)
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
                RemoveEmployee(RemoveComboBox.SelectedIndex);
                RemoveComboBox.Items.Remove(RemoveComboBox.SelectedItem);
            }
        }

        internal void SaveToFile()
        {
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
            if (EmployeeDataGridView.Rows.Count > 0)
            EmployeeDataGridView.Rows.Clear();
            RemoveComboBox.Items.Clear();
            foreach (var employee in employees)
            {
                RemoveComboBox.Items.Add(employee.Surname + " " + employee.Name);
                employeeBindingSource.Add(employee);
            }
            RemoveComboBox.Text = "Choice...";
            DateTime result = DateTime.Today.Subtract(TimeSpan.FromDays(0));
            EmployeeDateTimePicker.Value = result;
            EmployeeDataGridView.ClearSelection();
        }

        private void UpdateAddButtonVisibility()
        {
            if ((SurnameTextBox.Text != "") &&
                (NameTextBox.Text != "") &&
                (SalaryTextBox.Text != "")
                )
                
                AddEmployeeButton.Visible = true;
        }

        private void SurnameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
            this.UpdateAddButtonVisibility();
        }

        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
            this.UpdateAddButtonVisibility();
        }

        private void SalaryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)
                && e.KeyChar != Convert.ToChar(44)
                && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
            this.UpdateAddButtonVisibility();
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

        private void EmployeeDateTimePicker_Enter(object sender, EventArgs e)
        {
            ToolTipAdd().SetToolTip(EmployeeDateTimePicker, "Enter date DD.MM.Year and time 00:00");
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

        internal int GenerateNewcustomerID()
        {
            int iD = 0;
            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].CustomerID >= iD)
                    iD = customers[i].CustomerID;
            }
            return iD += 1;
        }

        internal void LoadToCustomerList()
        {
            if (File.Exists("WriteDataCustomer.xml"))
            {
                try
                {
                    XmlDocument customerDoc = new XmlDocument();
                    customerDoc.Load("WriteDataCustomer.xml");
                    foreach (XmlNode node in customerDoc)
                    {
                        if ("customers".Equals(node.Name))
                        {
                            for (XmlNode customerNode = node.FirstChild; customerNode != null; customerNode = customerNode.NextSibling)
                            {
                                var customer = new Customer();
                                if ("customer".Equals(customerNode.Name))
                                {
                                    customer.LoadFromNode(customerNode);
                                    AddCustomer(customer);
                                }
                            }
                        }
                    }
                }
                catch (Exception e) { MessageBox.Show("exeption" + e.Message); }
            }
            RefreshCustomer();
        }

        internal void AddCustomer(Customer customer)
        {
            customers.Add(customer);
            CustomerSurnameTextBox.Clear();
            CountryTextBox.Clear();
            DateTime result = DateTime.Now.Date;
            AgreementDateTimePicker.Value = result;
            CustomerNameTextBox.Clear();
            MoneyTextBox.Clear();
        }

        private void UpdateAddCustomerButtonVisibility()
        {
            if ((CustomerSurnameTextBox.Text != "") &&
                (CustomerNameTextBox.Text != "") &&
                (CountryTextBox.Text != "") &&
                (MoneyTextBox.Text != "")
                )
                AddCutomerButton.Visible = true;
        }

        private void AddCutomerButton_Click(object sender, EventArgs e)
        {
            int customerID = GenerateNewcustomerID();
            string name = CustomerNameTextBox.Text;
            string surname = CustomerSurnameTextBox.Text;
            string country = CountryTextBox.Text;
            DateTime dateAgreement = DateTime.Parse(AgreementDateTimePicker.Value.ToString("dd MM yy HH:mm"));
            double money = double.Parse(MoneyTextBox.Text.ToString());
            var customer = new Customer(customerID, name, surname, country, 
                                        dateAgreement, money);

            AddCustomer(customer);
            SaveCustomerToFile();
            RefreshCustomer();
            AddCutomerButton.Visible = false;
        }

        internal void SaveCustomerToFile()
        {
            XmlTextWriter cutomerWritter = new XmlTextWriter("WriteDataCustomer.xml", Encoding.UTF8);
            cutomerWritter.WriteStartDocument();
            cutomerWritter.WriteStartElement("customers");
            cutomerWritter.WriteEndElement();
            cutomerWritter.Close();

            foreach (var customer in customers)
            {
                customer.LoadToNode(customer);
            }
        }

        internal void RefreshCustomer()
        {

            if (CustomerDataGridView.Rows.Count > 0)
                CustomerDataGridView.Rows.Clear();
            foreach (var customer in customers)
            {
                customerBindingSource.Add(customer);
            }
            DateTime result = DateTime.Now.Date;
            AgreementDateTimePicker.Value = result;
            CustomerDataGridView.ClearSelection();
        }

        private void RemoveCustomerButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < customers.Count; i++)
            {
                if (i == CustomerDataGridView.CurrentRow.Index)
                {
                    customers.Remove(customers[i]);
                    break;
                }
            }
            SaveCustomerToFile();
            RefreshCustomer();
            RemoveCustomerButton.Visible = false;
        }

        private void CustomerNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
            UpdateAddCustomerButtonVisibility();
        }

        private void CuustomerSurnameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
            UpdateAddCustomerButtonVisibility();
        }

        private void CountryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
            UpdateAddCustomerButtonVisibility();
        }

        private void MoneyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)
                && e.KeyChar != Convert.ToChar(44)
                && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
            UpdateAddCustomerButtonVisibility();
        }

        private void CustomerDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RemoveCustomerButton.Visible = true;
        }

        private void MenegerTabControl_Click(object sender, EventArgs e)
        {
            CustomerDataGridView.ClearSelection();
            EmployeeDataGridView.ClearSelection();
            RemoveCustomerButton.Visible = false;
        }
    }
}
