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

        public Project project;
        public List<Project> projects;
        int curentRowIndex = -1;
        int curentIndex = 0;

        public Form1()
        {
            employees = new List<Employee>();
            customers = new List<Customer>();
            projects = new List<Project>();
            InitializeComponent();
            LoadToEmployeesList();
            LoadToCustomerList();
            LoadProjectToList();
            EmployeeDataGridView.SelectionChanged += PrintText;
        }

        protected override void OnActivated(EventArgs e)
        {
            EmployeeDataGridView.ClearSelection();
            CustomerDataGridView.ClearSelection();
        }

        void PrintText(object sender, EventArgs e)
        {
           // MessageBox.Show(sender.ToString());
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

        internal void SaveAllToFile()
        {
            try
            {
                XmlTextWriter writer = new XmlTextWriter("WriteData.xml", Encoding.UTF8);
                writer.Formatting = Formatting.Indented;
                writer.WriteStartDocument();
                writer.WriteStartElement("Manager");
                writer.WriteElementString("employees", "");
                writer.WriteElementString("customers", "");
                writer.WriteElementString("projects", "");
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Flush();
                writer.Close();

                foreach (var employee in employees)
                {
                    employee.LoadToNode(employee);
                }

                foreach (var customer in customers)
                {
                    customer.LoadToNode(customer);
                }

                foreach (var project in projects)
                {
                    project.LoadToNode(project);
                }
            }
            catch (Exception) { }
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
                        if ("Manager".Equals(node.Name))
                        {
                            for (XmlNode employeesNode = node.FirstChild; employeesNode != null; employeesNode = employeesNode.NextSibling)
                            {
                                if ("employees".Equals(employeesNode.Name))
                                {
                                    for (XmlNode employeeNode = employeesNode.FirstChild; employeeNode != null; employeeNode = employeeNode.NextSibling)
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
                    }
                }
                catch (Exception e) { MessageBox.Show("exeption" + e.Message); }
                RefreshTabEmployee();
            }
        }
        
        internal void AddEmployee(Employee employee)
        {
            employees.Add(employee);
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
            RefreshTabEmployee();
            SaveAllToFile();
            AddEmployeeButton.Visible = false;
        }

        internal void RemoveEmployee(int val)
        {
            employees.Remove(employees[val]);
            RefreshTabEmployee();
            SaveAllToFile();
        }

        internal void RefreshTabEmployee()
        {
            if (EmployeeDataGridView.Rows.Count > 0)
                EmployeeDataGridView.Rows.Clear();
            foreach (var employee in employees)
            {
                employeeBindingSource.Add(employee);
            }
            NameTextBox.Clear();
            SurnameTextBox.Clear();
            EmployeeDateTimePicker.Value = DateTime.Now;
            SalaryTextBox.Clear();
            EmployeeDataGridView.ClearSelection();
        }

        private void EmployeeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == EmployeeDataGridView.Columns[6].Index && e.RowIndex >= 0)
            {
                if (curentRowIndex == -1)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure", "Delete", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        RemoveEmployee(e.RowIndex);
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        CustomerDataGridView.CurrentCell = null;
                    }
                }
            }
            if (e.ColumnIndex == EmployeeDataGridView.Columns[5].Index && e.RowIndex >= 0)
            {
                if (curentRowIndex == -1)
                {
                    Edit.UseColumnTextForButtonValue = false;
                    Edit.DataGridView.CurrentCell.Value = "save";
                    for (int i = 0; i < EmployeeDataGridView.RowCount; i++)
                        if (i != e.RowIndex)
                        {
                            EmployeeDataGridView[5, i].Value = "Edit";
                        }
                    EmployeeDataGridView.Refresh();
                    curentRowIndex = e.RowIndex;
                    EmployeeDataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
                }
                else
                {
                    if (EmployeeDataGridView.CurrentCell.Value.Equals("save"))
                    {
                        SaveEditCellEmployeeTable(curentRowIndex);
                        Edit.UseColumnTextForButtonValue = true;
                        EmployeeDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        employeeBindingSource.EndEdit();
                        EmployeeDataGridView.EndEdit();
                        EmployeeDataGridView.ReadOnly = true;
                        curentRowIndex = -1;
                    }
                }
            }
            if (e.ColumnIndex > 0 && e.ColumnIndex <= 4 && e.RowIndex == curentRowIndex && e.ColumnIndex != 3)
            {
                EmployeeDataGridView.ReadOnly = false;
                EmployeeDataGridView.BeginEdit(false);
            }
            else
                EmployeeDataGridView.ReadOnly = true;
        }

        internal void SaveEditCellEmployeeTable(int rowIndex)
        {
            employees[rowIndex].Name = EmployeeDataGridView.Rows[rowIndex].Cells[1].Value.ToString();
            employees[rowIndex].Surname = EmployeeDataGridView.Rows[rowIndex].Cells[2].Value.ToString();
            employees[rowIndex].Salary = double.Parse(EmployeeDataGridView.Rows[rowIndex].Cells[4].Value.ToString());
            try
            {
                XmlDocument employeeDoc = new XmlDocument();
                employeeDoc.Load("WriteData.xml");
                XmlNodeList nodes = employeeDoc.ChildNodes;

                foreach (XmlNode node in employeeDoc)
                {
                    if ("Manager".Equals(node.Name))
                    {
                        for (XmlNode employeesNode = node.FirstChild; employeesNode != null; employeesNode = employeesNode.NextSibling)
                        {
                            if ("employees".Equals(employeesNode.Name))
                            {
                                for (XmlNode employeeNode = employeesNode.FirstChild; employeeNode != null; employeeNode = employeeNode.NextSibling)
                                {
                                    if (("employee".Equals(employeeNode.Name)) && (int.Parse(employeeNode.Attributes.GetNamedItem("employeeID").Value).Equals(employees[rowIndex].EmployeeID)))
                                    {
                                        if (!employeeNode.Attributes.GetNamedItem("name").Value.Equals(employees[rowIndex].Name))
                                        {
                                            employeeNode.Attributes.SetNamedItem(employeeNode.Attributes.GetNamedItem("name")).Value = employees[rowIndex].Name;
                                        }
                                        if (!employeeNode.Attributes.GetNamedItem("surname").Value.Equals(employees[rowIndex].Surname))
                                        {
                                            employeeNode.Attributes.GetNamedItem("surname").Value = employees[rowIndex].Surname;
                                        }
                                        if (!double.Parse(employeeNode.Attributes.GetNamedItem("salary").Value).Equals(employees[rowIndex].Salary))
                                        {
                                            employeeNode.Attributes.GetNamedItem("salary").Value = employees[rowIndex].Salary.ToString();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                employeeDoc.Save("WriteData.xml");
            }
            catch (Exception e) { MessageBox.Show("exeption" + e.Message); }
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
            { e.Handled = true; }
            this.UpdateAddButtonVisibility();
        }

        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            { e.Handled = true; }
            this.UpdateAddButtonVisibility();
        }

        private void SalaryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)
                && e.KeyChar != Convert.ToChar(44)
                && e.KeyChar != Convert.ToChar(8))
            { e.Handled = true; }
            this.UpdateAddButtonVisibility();
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
            if (File.Exists("WriteData.xml"))
            {
                try
                {
                    XmlDocument customerDoc = new XmlDocument();
                    customerDoc.Load("WriteData.xml");
                    foreach (XmlNode node in customerDoc)
                    {
                        if ("Manager".Equals(node.Name))
                        {
                            for (XmlNode customersNode = node.FirstChild; customersNode != null; customersNode = customersNode.NextSibling)
                            {
                                if ("customers".Equals(customersNode.Name))
                                {
                                    for (XmlNode customerNode = customersNode.FirstChild; customerNode != null; customerNode = customerNode.NextSibling)
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
                    }
                }
                catch (Exception e) { MessageBox.Show("exeption" + e.Message); }
            }
            RefreshTabCustomer();
        }

        internal void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }

        private void AddCutomerButton_Click(object sender, EventArgs e)
        {
            int customerID = GenerateNewcustomerID();
            string name = CustomerNameTextBox.Text;
            string surname = CustomerSurnameTextBox.Text;
            string country = CountryTextBox.Text;
            DateTime dateAgreement = DateTime.Parse(AgreementDateTimePicker.Value.ToString("dd.MM.yy HH:mm"));
            double money = double.Parse(MoneyTextBox.Text.ToString());
            var customer = new Customer(customerID, name, surname, country, 
                                        dateAgreement, money);

            AddCustomer(customer);
            SaveAllToFile();
            RefreshTabCustomer();
            AddCutomerButton.Visible = false;
        }

        internal void RemoveCustomer(int val)
        {
            customers.Remove(customers[val]);
            RefreshTabCustomer();
            SaveAllToFile();
        }

        internal void RefreshTabCustomer()
        {
            if (CustomerDataGridView.Rows.Count > 0)
                CustomerDataGridView.Rows.Clear();
            foreach (var customer in customers)
            {
                customerBindingSource.Add(customer);
            }
            CustomerNameTextBox.Clear();
            CustomerSurnameTextBox.Clear();
            CountryTextBox.Clear();
            MoneyTextBox.Clear();
            AgreementDateTimePicker.Value = DateTime.Now;
            CustomerDataGridView.ClearSelection();
        }

        private void CustomerDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == CustomerDataGridView.Columns[7].Index && e.RowIndex >= 0)
            {
                if (curentRowIndex == -1)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure", "Delete", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        RemoveCustomer(e.RowIndex);
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        CustomerDataGridView.CurrentCell = null;
                    }
                }
            }
            if (e.ColumnIndex == CustomerDataGridView.Columns[6].Index && e.RowIndex >= 0)
            {
                if (curentRowIndex == -1)
                {
                    CustomerEdit.UseColumnTextForButtonValue = false;
                    CustomerEdit.DataGridView.CurrentCell.Value = "save";
                    for (int i = 0; i < CustomerDataGridView.RowCount; i++)
                        if (i != e.RowIndex)
                        {
                            CustomerDataGridView[6, i].Value = "Edit";
                        }
                    CustomerDataGridView.Refresh();
                    curentRowIndex = e.RowIndex;
                    CustomerDataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
                }
                else
                {
                    if (CustomerDataGridView.CurrentCell.Value.Equals("save"))
                    {
                        SaveEditCellCustomerTable(curentRowIndex);
                        CustomerEdit.UseColumnTextForButtonValue = true;
                        CustomerDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        customerBindingSource.EndEdit();
                        CustomerDataGridView.EndEdit();
                        CustomerDataGridView.ReadOnly = true;
                        curentRowIndex = -1;
                    }
                }
            }
            if (e.ColumnIndex > 0 && e.ColumnIndex <= 5 && e.RowIndex == curentRowIndex && e.ColumnIndex != 4)
            {
                CustomerDataGridView.ReadOnly = false;
                CustomerDataGridView.BeginEdit(false);
            }
            else
                CustomerDataGridView.ReadOnly = true;
        }

        internal void SaveEditCellCustomerTable(int rowIndex)
        {
            customers[rowIndex].Name = CustomerDataGridView.Rows[rowIndex].Cells[1].Value.ToString();
            customers[rowIndex].Surname = CustomerDataGridView.Rows[rowIndex].Cells[2].Value.ToString();
            customers[rowIndex].Country = CustomerDataGridView.Rows[rowIndex].Cells[3].Value.ToString();
            customers[rowIndex].Money = double.Parse(CustomerDataGridView.Rows[rowIndex].Cells[5].Value.ToString());

            try
            {
                XmlDocument CustomerDoc = new XmlDocument();
                CustomerDoc.Load("WriteData.xml");
                XmlNodeList nodes = CustomerDoc.ChildNodes;
                foreach (XmlNode node in nodes)
                {
                    if ("Manager".Equals(node.Name))
                    {
                        for (XmlNode CustomersNode = node.FirstChild; CustomersNode != null; CustomersNode = CustomersNode.NextSibling)
                        {
                            if ("customers".Equals(CustomersNode.Name))
                            {
                                for (XmlNode customerNode = CustomersNode.FirstChild; customerNode != null; customerNode = customerNode.NextSibling)
                                {
                                    if (("customer".Equals(customerNode.Name)) && (int.Parse(customerNode.Attributes.GetNamedItem("customerID").Value).Equals(customers[rowIndex].CustomerID)))
                                    {
                                        if (!customerNode.Attributes.GetNamedItem("name").Value.Equals(customers[rowIndex].Name))
                                        {
                                            customerNode.Attributes.SetNamedItem(customerNode.Attributes.GetNamedItem("name")).Value = customers[rowIndex].Name;
                                        }
                                        if (!customerNode.Attributes.GetNamedItem("surname").Value.Equals(customers[rowIndex].Surname))
                                        {
                                            customerNode.Attributes.GetNamedItem("surname").Value = customers[rowIndex].Surname;
                                        }
                                        if (!customerNode.Attributes.GetNamedItem("country").Value.Equals(customers[rowIndex].Country))
                                        {
                                            customerNode.Attributes.GetNamedItem("country").Value = customers[rowIndex].Country;
                                        }
                                        if (!double.Parse(customerNode.Attributes.GetNamedItem("money").Value).Equals(double.Parse(customers[rowIndex].Money.ToString())))
                                        {
                                            customerNode.Attributes.GetNamedItem("money").Value = customers[rowIndex].Money.ToString();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                CustomerDoc.Save("WriteData.xml");
            }
            catch (Exception e) { MessageBox.Show("exeption" + e.Message); }
        }

        private void CustomerNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            { e.Handled = true; }
            UpdateAddCustomerButtonVisibility();
        }

        private void CuustomerSurnameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            { e.Handled = true; }
            UpdateAddCustomerButtonVisibility();
        }

        private void CountryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            { e.Handled = true; }
            UpdateAddCustomerButtonVisibility();
        }

        private void MoneyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)
                && e.KeyChar != Convert.ToChar(44)
                && e.KeyChar != Convert.ToChar(8))
            { e.Handled = true; }
            UpdateAddCustomerButtonVisibility();
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

        private void MenegerTabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            RefreshTabCustomer();
            RefreshTabEmployee();
            RefreshTabProject();
            AddCutomerButton.Visible = false;
            AddEmployeeButton.Visible = false;
        }

        private void UpdateAddProjectButtonVisibility()
        {
            if (ProjectEditButton.Text == "ProjectEdit")
            {
                if ((ProjectNameTextBox.Text != "") &&
                    (ProjectCostTextBox.Text != "")
                    )
                    AddProjectButton.Visible = true;
            }
        }

        private void ProjectNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            { e.Handled = true; }
            UpdateAddProjectButtonVisibility();
        }

        private void ProjectCostTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)
                && e.KeyChar != Convert.ToChar(44)
                && e.KeyChar != Convert.ToChar(8))
            { e.Handled = true; }
            UpdateAddProjectButtonVisibility();
        }

        private void DeleteProjectButton_Click(object sender, EventArgs e)
        {
            RemoveProject(ProjectInfoComboBox.SelectedIndex);
            DeleteProjectButton.Visible = false;
        }

        internal void RemoveProject(int val)
        {
            projects.Remove(projects[val]);
            RefreshTabProject();
            SaveAllToFile();
        }

        internal int GenerateNewProjectID()
        {
            int iD = 0;
            for (int i = 0; i < projects.Count; i++)
            {
                if (projects[i].ProjectID >= iD)
                    iD = projects[i].ProjectID;
            }
            return iD += 1;
        }

        internal void AddProject(Project project)
        {
            projects.Add(project);
            RefreshTabProject();
        }

        private void AddProjectButton_Click(object sender, EventArgs e)
        {
            int projectsID = GenerateNewProjectID();
            string name = ProjectNameTextBox.Text;
            DateTime dateAgreement = DateTime.Parse(ProjectDateTimePicker.Text);
            double cost = double.Parse(ProjectCostTextBox.Text);
            Project.ProjestStatus status = (Project.ProjestStatus)Enum.Parse(typeof(Project.ProjestStatus), StatusComboBox.Text.ToString());
            int customID = customers[ProjectCustomerComboBox.SelectedIndex].CustomerID;
            var project = new Project(projectsID, name, dateAgreement, cost, status, customID);

            AddProject(project);
            SaveAllToFile();
            RefreshTabProject();
            AddProjectButton.Visible = false;
        }

        private void ProjectInfoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeleteProjectButton.Visible = true;
            ProjectEditButton.Visible = true;
        }
        internal void RefreshTabProject()
        {
            if (ProjectCustomerComboBox.Items.Count > 0)
                ProjectCustomerComboBox.Items.Clear();
            if (ProjectInfoComboBox.Items.Count > 0)
                ProjectInfoComboBox.Items.Clear();
            projestStatusBindingSource.Clear();
            foreach (var customer in customers)
            {
                ProjectCustomerComboBox.Items.Add(customer.CustomerID + " " 
                                                      + customer.Name + " "
                                                      + customer.Surname);
            }
            foreach (var project in projects)
            {
                ProjectInfoComboBox.Items.Add("ID=" + project.ProjectID + " " 
                                            + "Proj=" + project.Name + " " 
                                            + "Date=" + project.DateAgreement + " " 
                                            + "Cust=" + project.CustomerID + " "
                                            //+ customers[ProjectCustomerComboBox.SelectedIndex].Name + " "
                                            //+ customers[ProjectCustomerComboBox.SelectedIndex].Surname + " "
                                            + "Cost= $" + project.Cost + " "
                                            + "St=" + project.Status);
            }

            projestStatusBindingSource.Add(Project.ProjestStatus.start);
            projestStatusBindingSource.Add(Project.ProjestStatus.active);
            projestStatusBindingSource.Add(Project.ProjestStatus.suspended);
            projestStatusBindingSource.Add(Project.ProjestStatus.done);
            ProjectDateTimePicker.Value = DateTime.Now;
            ProjectNameTextBox.Clear();
            ProjectCostTextBox.Clear();
            ProjectCustomerComboBox.Text = "Choise...";
            StatusComboBox.Text = "Choise...";
            ProjectInfoComboBox.Text = "Choise...";
        }

        internal void EditProjectInfo(int SelIndex)
        {
            ProjectEditButton.Text = "SaveChanges";
            ProjectCustomerComboBox.Text = "";
            foreach (var customer in customers)
            {
                if (customer.CustomerID == projects[SelIndex].CustomerID)
                    ProjectCustomerComboBox.SelectedText = customer.CustomerID.ToString() + " "
                                                           + customer.Name + " "
                                                           + customer.Surname;
            }
            ProjectNameTextBox.Text = projects[SelIndex].Name;
            ProjectCostTextBox.Text = projects[SelIndex].Cost.ToString();
            ProjectDateTimePicker.Value = DateTime.Parse(projects[SelIndex].DateAgreement.ToString());
            StatusComboBox.Text = "";
            StatusComboBox.SelectedText = projects[SelIndex].Status.ToString();
            DeleteProjectButton.Enabled = false;
            ProjectInfoComboBox.Enabled = false;
        }

        private void ProjectEditButton_Click(object sender, EventArgs e)
        {
            if (ProjectEditButton.Text == "ProjectEdit")
            {
                curentIndex = ProjectInfoComboBox.SelectedIndex;
                EditProjectInfo(curentIndex);
            }
            else
            if (ProjectEditButton.Text == "SaveChanges")
            {
                SaveEditProject(curentIndex);
                ProjectEditButton.Text = "ProjectEdit";
                RefreshTabProject();
            }
        }

        internal void SaveEditProject(int Index)
        {
            projects[Index].Name = ProjectNameTextBox.Text;
            projects[Index].Cost = double.Parse(ProjectCostTextBox.Text);
            projects[Index].Status = (Project.ProjestStatus)Enum.Parse(typeof(Project.ProjestStatus), StatusComboBox.SelectedItem.ToString());
            projects[Index].CustomerID = customers[ProjectCustomerComboBox.SelectedIndex].CustomerID;

            try
            {
                XmlDocument projectDoc = new XmlDocument();
                projectDoc.Load("WriteData.xml");
                XmlNodeList nodes = projectDoc.ChildNodes;
                foreach (XmlNode node in nodes)
                {
                    if ("Manager".Equals(node.Name))
                    {
                        for (XmlNode projectsNode = node.FirstChild; projectsNode != null; projectsNode = projectsNode.NextSibling)
                        {
                            if ("projects".Equals(projectsNode.Name))
                            {
                                for (XmlNode projectNode = projectsNode.FirstChild; projectNode != null; projectNode = projectNode.NextSibling)
                                {
                                    if (("project".Equals(projectNode.Name)) && (int.Parse(projectNode.Attributes.GetNamedItem("projectID").Value).Equals(projects[Index].ProjectID)))
                                    {
                                        if (!projectNode.Attributes.GetNamedItem("name").Value.Equals(projects[Index].Name))
                                        {
                                            projectNode.Attributes.SetNamedItem(projectNode.Attributes.GetNamedItem("name")).Value = projects[Index].Name;
                                        }
                                        if (!projectNode.Attributes.GetNamedItem("status").Value.Equals(projects[Index].Status))
                                        {
                                            projectNode.Attributes.GetNamedItem("status").Value = projects[Index].Status.ToString();
                                        }
                                        if (!projectNode.Attributes.GetNamedItem("projectcustID").Value.Equals(projects[Index].CustomerID))
                                        {
                                            projectNode.Attributes.GetNamedItem("projectcustID").Value = projects[Index].CustomerID.ToString();
                                        }
                                        if (!double.Parse(projectNode.Attributes.GetNamedItem("cost").Value).Equals(projects[Index].Cost))
                                        {
                                            projectNode.Attributes.GetNamedItem("cost").Value = projects[Index].Cost.ToString();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                projectDoc.Save("WriteData.xml");
                DeleteProjectButton.Enabled = true;
                ProjectInfoComboBox.Enabled = true;
            }
            catch (Exception e) { MessageBox.Show("exeption" + e.Message); }
        }

        internal void LoadProjectToList()
        {
            if (File.Exists("WriteData.xml"))
            {
                try
                {
                    XmlDocument projectDoc = new XmlDocument();
                    projectDoc.Load("WriteData.xml");
                    XmlNodeList nodes = projectDoc.ChildNodes;
                    foreach (XmlNode node in nodes)
                    {
                        if ("Manager".Equals(node.Name))
                        {
                            for (XmlNode projectsNode = node.FirstChild; projectsNode != null; projectsNode = projectsNode.NextSibling)
                            {
                                if ("projects".Equals(projectsNode.Name))
                                {
                                    for (XmlNode projectNode = projectsNode.FirstChild; projectNode != null; projectNode = projectNode.NextSibling)
                                    {
                                        var project = new Project();
                                        if ("project".Equals(projectNode.Name))
                                        {
                                            project.LoadFromNode(projectNode);
                                            AddProject(project);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception e) { MessageBox.Show("exeption" + e.Message); }
            }
            RefreshTabProject();
        }
    }
}
