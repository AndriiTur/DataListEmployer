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
        public const string PathToFile = "WriteData.xml";
        public const string DateFomat = "dd.MM.yy HH:mm";
        public const string DialogAskMesage = "Are you sure ?";
        public const string ButtonTextSave = "Save";
        public const string ButtonTextEdit = "Edit";
        public const string MesageDeleteShow = "Delete";
        public const string ExeptionError = "Error";

        public const string XMLNodeManager = "Manager";
        public const string XMLNodeEmployees = "Employees";
        public const string XMLNodeEmployee = "Employee";
        public const string XMLEmployeeAtributeID = "employeeID";
        public const string XMLEmployeeAtributeName = "name";
        public const string XMLEmployeeAtributeSurname = "surname";
        public const string XMLEmployeeAtributeSalary = "salary";
        public const string XMLNodeCustomers = "Customers";
        public const string XMLNodeCustomer = "Customer";
        public const string XMLCustomerAtributeID = "customerID";
        public const string XMLCustomerAtributeName = "name";
        public const string XMLCustomerAtributeSurname = "surname";
        public const string XMLCustomerAtributeCountry = "country";
        public const string XMLNodeProjects = "Projects";
        public const string XMLNodeProject = "Project";
        public const string XMLProjectAtributeID = "projectID";
        public const string XMLProjectAtributeName = "name";
        public const string XMLProjectAtributeCost = "cost";
        public const string XMLProjectAtributeStatus = "status";
        public const string XMLProjectAtributeCustomer = "customer";

        public Employee employee;
        public List<Employee> employees;

        public Customer customer;
        public List<Customer> customers;

        public Project project;
        public List<Project> projects;

        List<string> customerInfo;
        List<string> ProjectStatus;

        int curentRowIndex = -1;
        public int ProjectCurentID;

        public Form1()
        {
            ProjectCurentID = 0;
            ProjectStatus = new List<string>();
            customerInfo = new List<string>();
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
                XmlTextWriter writer = new XmlTextWriter(PathToFile, Encoding.UTF8);
                writer.Formatting = Formatting.Indented;
                writer.WriteStartDocument();
                writer.WriteStartElement(XMLNodeManager);
                writer.WriteElementString(XMLNodeEmployees, "");
                writer.WriteElementString(XMLNodeCustomers, "");
                writer.WriteElementString(XMLNodeProjects, "");
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Flush();
                writer.Close();

                foreach (var employee in employees)
                {
                    employee.LoadToNode(employee, PathToFile);
                }

                foreach (var customer in customers)
                {
                    customer.LoadToNode(customer, PathToFile);
                }

                foreach (var project in projects)
                {
                    project.LoadToNode(project, PathToFile);
                }
            }
            catch (Exception) { }
        }

        internal void LoadToEmployeesList()
        {
            if (File.Exists(PathToFile))
            {
                try
                {
                    XmlDocument employeeDoc = new XmlDocument();
                    employeeDoc.Load(PathToFile);

                    foreach (XmlNode node in employeeDoc)
                    {
                        if (XMLNodeManager == node.Name)
                        {
                            for (XmlNode employeesNode = node.FirstChild; employeesNode != null; employeesNode = employeesNode.NextSibling)
                            {
                                if (XMLNodeEmployees == employeesNode.Name)
                                {
                                    for (XmlNode employeeNode = employeesNode.FirstChild; employeeNode != null; employeeNode = employeeNode.NextSibling)
                                    {
                                        var employee = new Employee();
                                        if (XMLNodeEmployee == employeeNode.Name)
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
                catch (Exception e) { MessageBox.Show(ExeptionError + e.Message); }
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
            DateTime date_Of_Employment = DateTime.Parse(EmployeeDateTimePicker.Value.ToString(DateFomat));
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
            if (e.ColumnIndex == DeleteEmployeeButton.Index && e.RowIndex >= 0)
            {
                if (curentRowIndex == -1)
                {
                    DialogResult dialogResult = MessageBox.Show(DialogAskMesage, MesageDeleteShow, MessageBoxButtons.YesNo);
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
            if (e.ColumnIndex == EditEmployeeButton.Index && e.RowIndex >= 0)
            {
                if (curentRowIndex == -1)
                {
                    EditEmployeeButton.UseColumnTextForButtonValue = false;
                    EditEmployeeButton.DataGridView.CurrentCell.Value = ButtonTextSave;
                    for (int i = 0; i < EmployeeDataGridView.RowCount; i++)
                        if (i != e.RowIndex)
                        {
                            EmployeeDataGridView[EditEmployeeButton.Index, i].Value = ButtonTextEdit;
                        }
                    EmployeeDataGridView.Refresh();
                    curentRowIndex = e.RowIndex;
                    EmployeeDataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
                }
                else
                {
                    if (EmployeeDataGridView.CurrentCell.Value.ToString() == ButtonTextSave)
                    {
                        SaveEditCellEmployeeTable(curentRowIndex);
                        EditEmployeeButton.UseColumnTextForButtonValue = true;
                        EmployeeDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        employeeBindingSource.EndEdit();
                        EmployeeDataGridView.EndEdit();
                        EmployeeDataGridView.ReadOnly = true;
                        curentRowIndex = -1;
                    }
                }
            }
            if (e.ColumnIndex > employeeIDDataGridViewTextBoxColumn.Index
                && e.ColumnIndex <= SalaryEmployeeDataGridViewTextBoxColumn.Index 
                && e.RowIndex == curentRowIndex && e.ColumnIndex != dateOfEmploymentDataGridViewTextBoxColumn.Index)
            {
                EmployeeDataGridView.ReadOnly = false;
                EmployeeDataGridView.BeginEdit(false);
            }
            else
                EmployeeDataGridView.ReadOnly = true;
        }

        internal void SaveEditCellEmployeeTable(int rowIndex)
        {
            employees[rowIndex].Name = EmployeeDataGridView[NameEmployeeDataGridViewTextBoxColumn.Index, rowIndex].Value.ToString();
            employees[rowIndex].Surname = EmployeeDataGridView[SurnameEmployeeDataGridViewTextBoxColumn.Index, rowIndex].Value.ToString();
            employees[rowIndex].Salary = double.Parse(EmployeeDataGridView[SalaryEmployeeDataGridViewTextBoxColumn.Index, rowIndex].Value.ToString());
            try
            {
                XmlDocument employeeDoc = new XmlDocument();
                employeeDoc.Load(PathToFile);
                XmlNodeList nodes = employeeDoc.ChildNodes;

                foreach (XmlNode node in employeeDoc)
                {
                    if (XMLNodeManager == node.Name)
                    {
                        for (XmlNode employeesNode = node.FirstChild; employeesNode != null; employeesNode = employeesNode.NextSibling)
                        {
                            if (XMLNodeEmployees == employeesNode.Name)
                            {
                                for (XmlNode employeeNode = employeesNode.FirstChild; employeeNode != null; employeeNode = employeeNode.NextSibling)
                                {
                                    if ((XMLNodeEmployee == employeeNode.Name) && (int.Parse(employeeNode.Attributes.GetNamedItem(XMLEmployeeAtributeID).Value) == employees[rowIndex].EmployeeID))
                                    {
                                        if (employeeNode.Attributes.GetNamedItem(XMLEmployeeAtributeName).Value != employees[rowIndex].Name)
                                        {
                                            employeeNode.Attributes.GetNamedItem(XMLEmployeeAtributeName).Value = employees[rowIndex].Name;
                                        }
                                        if (employeeNode.Attributes.GetNamedItem(XMLEmployeeAtributeSurname).Value != employees[rowIndex].Surname)
                                        {
                                            employeeNode.Attributes.GetNamedItem(XMLEmployeeAtributeSurname).Value = employees[rowIndex].Surname;
                                        }
                                        if (double.Parse(employeeNode.Attributes.GetNamedItem(XMLEmployeeAtributeSalary).Value) == employees[rowIndex].Salary)
                                        {
                                            employeeNode.Attributes.GetNamedItem(XMLEmployeeAtributeSalary).Value = employees[rowIndex].Salary.ToString();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                employeeDoc.Save(PathToFile);
            }
            catch (Exception e) { MessageBox.Show(ExeptionError + e.Message); }
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
            if (File.Exists(PathToFile))
            {
                try
                {
                    XmlDocument customerDoc = new XmlDocument();
                    customerDoc.Load(PathToFile);
                    foreach (XmlNode node in customerDoc)
                    {
                        if (XMLNodeManager == node.Name)
                        {
                            for (XmlNode customersNode = node.FirstChild; customersNode != null; customersNode = customersNode.NextSibling)
                            {
                                if (XMLNodeCustomers == customersNode.Name)
                                {
                                    for (XmlNode customerNode = customersNode.FirstChild; customerNode != null; customerNode = customerNode.NextSibling)
                                    {
                                        var customer = new Customer();
                                        if (XMLNodeCustomer == customerNode.Name)
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
                catch (Exception e) { MessageBox.Show(ExeptionError + e.Message); }
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
            DateTime dateAgreement = DateTime.Parse(AgreementDateTimePicker.Value.ToString(DateFomat));
            var customer = new Customer(customerID, name, surname, country, 
                                        dateAgreement);

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
                LoadProjectInfoToCustomer(customer);
            }
            CustomerNameTextBox.Clear();
            CustomerSurnameTextBox.Clear();
            CountryTextBox.Clear();
            AgreementDateTimePicker.Value = DateTime.Now;
            CustomerDataGridView.ClearSelection();
        }

        internal void LoadProjectInfoToCustomer(Customer customer)
        {
            double money = 0;
            int quantity = 0;
            for (int i = 0; i < projects.Count; i++)
            {
                if (customer.CustomerID == projects[i].CustomerID)
                {
                    quantity += 1;
                    money += projects[i].Cost;
                }
                CustomerDataGridView[CustomerMoney.Index, customers.IndexOf(customer)].Value = money.ToString();
                CustomerDataGridView[CustomerQuantity.Index, customers.IndexOf(customer)].Value = quantity.ToString();
            }
        }

        private void CustomerDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == CustomerDelete.Index && e.RowIndex >= 0)
            {
                if (curentRowIndex == -1)
                {
                    DialogResult dialogResult = MessageBox.Show(DialogAskMesage, MesageDeleteShow, MessageBoxButtons.YesNo);
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
            if (e.ColumnIndex == CustomerEdit.Index && e.RowIndex >= 0)
            {
                if (curentRowIndex == -1)
                {
                    CustomerEdit.UseColumnTextForButtonValue = false;
                    CustomerEdit.DataGridView.CurrentCell.Value = ButtonTextSave;
                    for (int i = 0; i < CustomerDataGridView.RowCount; i++)
                        if (i != e.RowIndex)
                        {
                            CustomerDataGridView[CustomerEdit.Index, i].Value = ButtonTextEdit;
                        }
                    CustomerDataGridView.Refresh();
                    curentRowIndex = e.RowIndex;
                    CustomerDataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
                }
                else
                {
                    if (CustomerDataGridView.CurrentCell.Value.ToString() == ButtonTextSave)
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
            if (e.ColumnIndex > customerIDDataGridViewTextBoxColumn.Index 
                && e.ColumnIndex <= dateAgreementDataGridViewTextBoxColumn.Index)
            {
                CustomerDataGridView.ReadOnly = false;
                CustomerDataGridView.BeginEdit(false);
            }
            else
                CustomerDataGridView.ReadOnly = true;
        }

        internal void SaveEditCellCustomerTable(int rowIndex)
        {
            customers[rowIndex].Name = CustomerDataGridView[NameCustomerDataGridViewTextBoxColumn.Index,rowIndex].Value.ToString();
            customers[rowIndex].Surname = CustomerDataGridView[SurnameCustomerDataGridViewTextBoxColumn.Index, rowIndex].Value.ToString();
            customers[rowIndex].Country = CustomerDataGridView[CountryCustomerDataGridViewTextBoxColumn.Index, rowIndex].Value.ToString();

            try
            {
                XmlDocument CustomerDoc = new XmlDocument();
                CustomerDoc.Load(PathToFile);
                XmlNodeList nodes = CustomerDoc.ChildNodes;
                foreach (XmlNode node in nodes)
                {
                    if (XMLNodeManager == node.Name)
                    {
                        for (XmlNode CustomersNode = node.FirstChild; CustomersNode != null; CustomersNode = CustomersNode.NextSibling)
                        {
                            if (XMLNodeCustomers == CustomersNode.Name)
                            {
                                for (XmlNode customerNode = CustomersNode.FirstChild; customerNode != null; customerNode = customerNode.NextSibling)
                                {
                                    if ((XMLNodeCustomer == customerNode.Name) && (int.Parse(customerNode.Attributes.GetNamedItem(XMLCustomerAtributeID).Value) == customers[rowIndex].CustomerID))
                                    {
                                        if (customerNode.Attributes.GetNamedItem(XMLCustomerAtributeName).Value != customers[rowIndex].Name)
                                        {
                                            customerNode.Attributes.GetNamedItem(XMLCustomerAtributeName).Value = customers[rowIndex].Name;
                                        }
                                        if (customerNode.Attributes.GetNamedItem(XMLCustomerAtributeSurname).Value != customers[rowIndex].Surname)
                                        {
                                            customerNode.Attributes.GetNamedItem(XMLCustomerAtributeSurname).Value = customers[rowIndex].Surname;
                                        }
                                        if (customerNode.Attributes.GetNamedItem(XMLCustomerAtributeCountry).Value != customers[rowIndex].Country)
                                        {
                                            customerNode.Attributes.GetNamedItem(XMLCustomerAtributeCountry).Value = customers[rowIndex].Country;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                CustomerDoc.Save(PathToFile);
            }
            catch (Exception e) { MessageBox.Show(ExeptionError + e.Message); }
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

        private void UpdateAddCustomerButtonVisibility()
        {
            if ((CustomerSurnameTextBox.Text != "") &&
                (CustomerNameTextBox.Text != "") &&
                (CountryTextBox.Text != "")
                )
                AddCutomerButton.Visible = true;
        }

        private void UpdateAddProjectButtonVisibility()
        {
            if ((ProjectNameTextBox.Text != "") &&
                (ProjectCostTextBox.Text != "")
                )
                AddProjectButton.Visible = true;
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
        }

        private void AddProjectButton_Click(object sender, EventArgs e)
        {
            int projectsID = GenerateNewProjectID();
            string name = ProjectNameTextBox.Text;
            DateTime dateAgreement = DateTime.Parse(ProjectDateTimePicker.Text);
            double cost = double.Parse(ProjectCostTextBox.Text);
            Project.ProjestStatus status = (Project.ProjestStatus)Enum.Parse(typeof(Project.ProjestStatus), StatusComboBox.SelectedItem.ToString());
            int customID = int.Parse(ProjectCustomerComboBox.SelectedItem.ToString());
            var project = new Project(projectsID, name, dateAgreement, cost, status, customID);

            AddProject(project);
            SaveAllToFile();
            RefreshTabProject();
            AddProjectButton.Visible = false;
        }

        internal void RefreshTabProject()
        {
            if (ProjectCustomerComboBox.Items.Count > 0)
                customerInfo.Clear();
            if (StatusComboBox.Items.Count > 0)
                ProjectStatus.Clear();
            int rowIndex = 0;
            if (ProjectStatus.Count > 0)
                ProjectStatus.Clear();
            if (customerInfo.Count > 0)
                customerInfo.Clear();
            if (ProjectDataGridView.Rows.Count >= 0)
                ProjectDataGridView.Rows.Clear();
            ProjectStatus.Add(Project.ProjestStatus.start.ToString());
            ProjectStatus.Add(Project.ProjestStatus.active.ToString());
            ProjectStatus.Add(Project.ProjestStatus.suspended.ToString());
            ProjectStatus.Add(Project.ProjestStatus.done.ToString());
            if (customers.Count != 0)
            {
                foreach (var customer in customers)
                {
                    customerInfo.Add(customer.CustomerID.ToString());
                }
            }
            ProjectCustomerComboBox.DataSource = customerInfo;
            StatusComboBox.DataSource = ProjectStatus;
            foreach (var project in projects)
            {
                ProjectDataGridView.Rows.Add();
                ProjectDataGridView[ProjectIDColumn.Index, rowIndex].Value = project.ProjectID.ToString();
                ProjectDataGridView[ProjectNameColumn.Index, rowIndex].Value = project.Name.ToString();
                ProjectDataGridView[ProjectDataColumn.Index, rowIndex].Value = project.DateAgreement.ToString(DateFomat).ToString();
                ProjectDataGridView[ProjectCostColumn.Index, rowIndex].Value = project.Cost.ToString();
                ProjectStatusColumn.DataSource = ProjectStatus;
                ProjectDataGridView[ProjectStatusColumn.Index,rowIndex].Value = project.Status.ToString();
                ProjectCustomerColumn.DataSource = customerInfo;
                ProjectDataGridView[ProjectCustomerColumn.Index, rowIndex].Value = project.CustomerID.ToString();
                rowIndex++;
            }
            ProjectDateTimePicker.Value = DateTime.Now;
            ProjectNameTextBox.Clear();
            ProjectCostTextBox.Clear();
            ProjectCustomerComboBox.Text = "";
            ProjectCustomerComboBox.SelectedText = "Choise...";
            StatusComboBox.Text = "";
            StatusComboBox.SelectedText = "Choise...";
        }
        
        internal void SaveEditProject(int Index)
        {
            projects[Index].Name = ProjectDataGridView[ProjectNameColumn.Index,Index].Value.ToString();
            projects[Index].Cost = double.Parse(ProjectDataGridView[ProjectCostColumn.Index, Index].Value.ToString());
            projects[Index].Status = (Project.ProjestStatus)Enum.Parse(typeof(Project.ProjestStatus), ProjectDataGridView[ProjectStatusColumn.Index, Index].Value.ToString());
            projects[Index].CustomerID = int.Parse(ProjectDataGridView[ProjectCustomerColumn.Index, Index].Value.ToString());

            try
            {
                XmlDocument projectDoc = new XmlDocument();
                projectDoc.Load(PathToFile);
                XmlNodeList nodes = projectDoc.ChildNodes;
                foreach (XmlNode node in nodes)
                {
                    if (XMLNodeManager == node.Name)
                    {
                        for (XmlNode projectsNode = node.FirstChild; projectsNode != null; projectsNode = projectsNode.NextSibling)
                        {
                            if (XMLNodeProjects == projectsNode.Name)
                            {
                                for (XmlNode projectNode = projectsNode.FirstChild; projectNode != null; projectNode = projectNode.NextSibling)
                                {
                                    if ((XMLNodeProject == projectNode.Name) && (int.Parse(projectNode.Attributes.GetNamedItem(XMLProjectAtributeID).Value) == projects[Index].ProjectID))
                                    {
                                        if (projectNode.Attributes.GetNamedItem(XMLProjectAtributeName).Value == projects[Index].Name)
                                        {
                                            projectNode.Attributes.SetNamedItem(projectNode.Attributes.GetNamedItem(XMLProjectAtributeName)).Value = projects[Index].Name;
                                        }
                                        if (double.Parse(projectNode.Attributes.GetNamedItem(XMLProjectAtributeCost).Value) == projects[Index].Cost)
                                        {
                                            projectNode.Attributes.GetNamedItem(XMLProjectAtributeCost).Value = projects[Index].Cost.ToString();
                                        }
                                        if (projectNode.Attributes.GetNamedItem(XMLProjectAtributeStatus).Value.ToString() != projects[Index].Status.ToString())
                                        {
                                            projectNode.Attributes.GetNamedItem(XMLProjectAtributeStatus).Value = projects[Index].Status.ToString();
                                        }
                                        if (projectNode.Attributes.GetNamedItem(XMLProjectAtributeCustomer).Value == projects[Index].CustomerID.ToString())
                                        {
                                            projectNode.Attributes.GetNamedItem(XMLProjectAtributeCustomer).Value = projects[Index].CustomerID.ToString();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                projectDoc.Save(PathToFile);
            }
            catch (Exception e) { MessageBox.Show(ExeptionError + e.Message); }
        }

        internal void LoadProjectToList()
        {
            if (File.Exists(PathToFile))
            {
                try
                {
                    XmlDocument projectDoc = new XmlDocument();
                    projectDoc.Load(PathToFile);
                    XmlNodeList nodes = projectDoc.ChildNodes;
                    foreach (XmlNode node in nodes)
                    {
                        if (XMLNodeManager == node.Name)
                        {
                            for (XmlNode projectsNode = node.FirstChild; projectsNode != null; projectsNode = projectsNode.NextSibling)
                            {
                                if (XMLNodeProjects == projectsNode.Name)
                                {
                                    for (XmlNode projectNode = projectsNode.FirstChild; projectNode != null; projectNode = projectNode.NextSibling)
                                    {
                                        var project = new Project();
                                        if (XMLNodeProject == projectNode.Name)
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
                catch (Exception e) { MessageBox.Show(ExeptionError + e.Message); }
            }
            RefreshTabProject();
        }

        private void ProjectDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == EditEmployeeInProject.Index && e.RowIndex >= 0)
            {
                var form2 = new Form2();
                form2.Text = ProjectDataGridView[ProjectNameColumn.Index, e.RowIndex].Value.ToString();
                form2.projectID = int.Parse(ProjectDataGridView[ProjectIDColumn.Index, e.RowIndex].Value.ToString());
                form2.LoadEmployeesOnProjectToList();
                form2.ShowDialog();
                form2.Dispose();
            }
            if (e.ColumnIndex == ProjectDeleteColumn.Index && e.RowIndex >= 0)
            {
                if (curentRowIndex == -1)
                {
                    DialogResult dialogResult = MessageBox.Show(DialogAskMesage, MesageDeleteShow, MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        RemoveProject(e.RowIndex);
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        ProjectDataGridView.CurrentCell = null;
                    }
                }
            }
            if (e.ColumnIndex == ProjectEditColumn.Index && e.RowIndex >= 0)
            {
                if (curentRowIndex == -1)
                {
                    ProjectEditColumn.UseColumnTextForButtonValue = false;
                    ProjectDataGridView[ProjectEditColumn.Index, e.RowIndex].Value = ButtonTextSave; 
                    for (int i = 0; i < ProjectDataGridView.RowCount; i++)
                        if (i != e.RowIndex)
                        {
                            ProjectDataGridView[ProjectEditColumn.Index, i].Value = ButtonTextEdit;
                        }
                    ProjectDataGridView.Refresh();
                    curentRowIndex = e.RowIndex;
                }
                else
                {
                    if (ProjectDataGridView.CurrentCell.Value.ToString() == ButtonTextSave)
                    {
                        ProjectDataGridView[ProjectEditColumn.Index, curentRowIndex].Value = ButtonTextEdit;
                        ProjectEditColumn.UseColumnTextForButtonValue = true;
                        SaveEditProject(curentRowIndex);
                        ProjectDataGridView.EndEdit();
                        ProjectDataGridView.ReadOnly = true;
                        curentRowIndex = -1;
                    }
                }
            }
            if (e.ColumnIndex > ProjectIDColumn.Index 
                && e.ColumnIndex <= ProjectCustomerColumn.Index
                && e.RowIndex == curentRowIndex && e.ColumnIndex != ProjectDataColumn.Index)
            {
                ProjectDataGridView.ReadOnly = false;
                ProjectDataGridView.BeginEdit(false);
            }
            else
                ProjectDataGridView.ReadOnly = true;
        }

        internal Customer GetCustomer(int customerID)
        {
            Customer resultCustomer = new Customer();  
            foreach (var customer in customers)
            {
                if (customer.CustomerID == customerID)
                    resultCustomer = customer;
            }
            return resultCustomer;
        }

        private void MenegerTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTabEmployee();
            RefreshTabProject();
            RefreshTabCustomer();
            AddCutomerButton.Visible = false;
            AddEmployeeButton.Visible = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var form2 = new Form2();
            form2.Close();
        }
    }
}
