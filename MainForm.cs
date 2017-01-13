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
using static ManagerProject.AddEmployeProjectForm;

namespace ManagerProject
{
    public partial class MainForm : Form
    {
        public const string PathToFile = "WriteData.xml";
        public const string DateFomat = "dd.MM.yy HH:mm";
        public const string DialogAskMesage = "Are you sure ?";
        public const string ButtonTextSave = "Save";
        public const string ButtonTextEdit = "Edit";
        public const string MesageDeleteShow = "Delete";
        public const string ExeptionError = "Error";
        public const string XMLNodeManager = "Manager";
        
        public Manager manager;
        List<int> customerIDList;
        int curentRowIndex = -1;

        public MainForm()
        {
            manager = new Manager();
            customerIDList = new List<int> { };
            InitializeComponent();
            LoadToManager();
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
            for (int i = 0; i < manager.Employees.Count; i++)
            {
                if (manager.Employees[i].EmployeeID >= iD)
                    iD = manager.Employees[i].EmployeeID;
            }
            return iD += 1;
        }

        internal int GenerateNewcustomerID()
        {
            int iD = 0;
            for (int i = 0; i < manager.Customers.Count; i++)
            {
                if (manager.Customers[i].CustomerID >= iD)
                    iD = manager.Customers[i].CustomerID;
            }
            return iD += 1;
        }

        internal int GenerateNewProjectID()
        {
            int iD = 0;
            for (int i = 0; i < manager.Projects.Count; i++)
            {
                if (manager.Projects[i].ProjectID >= iD)
                    iD = manager.Projects[i].ProjectID;
            }
            return iD += 1;
        }

        internal void SaveAllToFile()
        {
            XmlDocument Doc = new XmlDocument();
            Doc.Load(PathToFile);
            manager.SaveToNode(XmlNodeHelper.RequiredNode(Doc, XMLNodeManager));
            Doc.Save(PathToFile);
        }

        internal void LoadToManager()
        {
            XmlDocument Doc = new XmlDocument();
            Doc.Load(PathToFile);
            manager.LoadFromNode(XmlNodeHelper.RequiredNode(Doc, XMLNodeManager));
            RefreshTabEmployee();
            RefreshTabProject();
            RefreshTabCustomer();
        }

        internal void AddEmployee(Employee employee)
        {
            manager.Employees.Add(employee);
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            int employeeID = GenerateNewemployeeID();
            string name = NameTextBox.Text;
            string surname = SurnameTextBox.Text;
            DateTime dateOfEmployment = DateTime.Parse(EmployeeDateTimePicker.Value.ToString(DateFomat));
            double salary = double.Parse(SalaryTextBox.Text);
            var employee = new Employee(employeeID, name, surname, dateOfEmployment, salary, manager);

            AddEmployee(employee);
            RefreshTabEmployee();
            SaveAllToFile();
            AddEmployeeButton.Visible = false;
        }

        internal void AddCustomer(Customer customer)
        {
            manager.Customers.Add(customer);
        }

        private void AddCutomerButton_Click(object sender, EventArgs e)
        {
            int customerID = GenerateNewcustomerID();
            string name = CustomerNameTextBox.Text;
            string surname = CustomerSurnameTextBox.Text;
            string country = CountryTextBox.Text;
            DateTime dateAgreement = DateTime.Parse(AgreementDateTimePicker.Value.ToString(DateFomat));
            var customer = new Customer(customerID, name, surname, country, dateAgreement, manager);

            AddCustomer(customer);
            SaveAllToFile();
            RefreshTabCustomer();
            AddCutomerButton.Visible = false;
        }

        internal void AddProject(Project project)
        {
            manager.Projects.Add(project);
        }

        private void AddProjectButton_Click(object sender, EventArgs e)
        {
            int projectsID = GenerateNewProjectID();
            string name = ProjectNameTextBox.Text;
            DateTime dateAgreement = DateTime.Parse(ProjectDateTimePicker.Text);
            double cost = double.Parse(ProjectCostTextBox.Text);
            Project.ProjestStatus status = (Project.ProjestStatus)Enum.Parse(typeof(Project.ProjestStatus), StatusComboBox.SelectedItem.ToString());
            int customer = customerIDList[ProjectCustomerComboBox.SelectedIndex];
            List<int> employees = new List<int> { };
            var project = new Project(projectsID, name, dateAgreement, cost, status, customer, employees, manager);

            AddProject(project);
            SaveAllToFile();
            RefreshTabProject();
            AddProjectButton.Visible = false;
        }

        internal void RemoveEmployee(int val)
        {
            manager.Employees.Remove(manager.Employees[val]);
            RefreshTabEmployee();
            SaveAllToFile();
        }

        internal void RemoveCustomer(int val)
        {
            manager.Customers.Remove(manager.Customers[val]);
            RefreshTabCustomer();
            SaveAllToFile();
        }

        internal void RemoveProject(int val)
        {
            manager.Projects.Remove(manager.Projects[val]);
            RefreshTabProject();
            SaveAllToFile();
        }

        internal void RefreshTabEmployee()
        {
            if (EmployeeDataGridView.Rows.Count > 0)
                EmployeeDataGridView.Rows.Clear();
            for (int i = 0; i < manager.Employees.Count; i++)
            {
                employeeBindingSource.Add(manager.Employees[i]);
            }
            NameTextBox.Clear();
            SurnameTextBox.Clear();
            EmployeeDateTimePicker.Value = DateTime.Now;
            SalaryTextBox.Clear();
            EmployeeDataGridView.ClearSelection();
        }

        internal void RefreshTabCustomer()
        {
            if (CustomerDataGridView.Rows.Count > 0)
                CustomerDataGridView.Rows.Clear();
            for (int i = 0; i < manager.Customers.Count; i++)
            {
                customerBindingSource.Add(manager.Customers[i]);
            }
            CustomerNameTextBox.Clear();
            CustomerSurnameTextBox.Clear();
            CountryTextBox.Clear();
            AgreementDateTimePicker.Value = DateTime.Now;
            CustomerDataGridView.ClearSelection();


            for (int i = 0; i < manager.Customers.Count; i++)
            {
                LoadProjectInfoToCustomer(manager.Customers[i]);
            }
        }

        internal void RefreshTabProject()
        {
            var customersOnProject = new List<CustomerInProject>();

            var ProjectStatus = new List<string>();

            if (StatusComboBox.Items.Count > 0)
                ProjectStatus.Clear();
            int rowIndex = 0;
            if (customerIDList.Count > 0)
                customerIDList.Clear();
            if (ProjectStatus.Count > 0)
                ProjectStatus.Clear();
            if (ProjectDataGridView.Rows.Count >= 0)
                ProjectDataGridView.Rows.Clear();
            foreach (Project.ProjestStatus status in Enum.GetValues(typeof(Project.ProjestStatus)))
                ProjectStatus.Add(status.ToString());
            if (manager.Customers.Count != 0)
            {

                for (int i = 0; i < manager.Customers.Count; i++)
                {
                    var customerProject = new CustomerInProject(manager.Customers[i].Name.ToString() + " " + manager.Customers[i].Surname.ToString(), manager.Customers[i].CustomerID);
                    customersOnProject.Add(customerProject);
                    //customerIDList.Add(customer.CustomerID);
                    //customerInfo.Add(customer.Name.ToString() + " " + customer.Surname.ToString());
                }
            }
            ProjectCustomerComboBox.DataSource = customersOnProject;
            ProjectCustomerComboBox.DisplayMember = "CustomerName";
            ProjectCustomerComboBox.ValueMember = "CustomerID";
            StatusComboBox.DataSource = ProjectStatus;
            for (int i = 0; i < manager.Projects.Count; i++)
            {
                ProjectDataGridView.Rows.Add();
                ProjectDataGridView[ProjectIDColumn.Index, rowIndex].Value = manager.Projects[i].ProjectID.ToString();
                ProjectDataGridView[ProjectNameColumn.Index, rowIndex].Value = manager.Projects[i].Name.ToString();
                ProjectDataGridView[ProjectDataColumn.Index, rowIndex].Value = manager.Projects[i].DateAgreement.ToString(DateFomat).ToString();
                ProjectDataGridView[ProjectCostColumn.Index, rowIndex].Value = manager.Projects[i].Cost.ToString();
                ProjectStatusColumn.DataSource = ProjectStatus;
                ProjectDataGridView[ProjectStatusColumn.Index, rowIndex].Value = manager.Projects[i].Status.ToString();
                ProjectCustomerColumn.DataSource = customersOnProject;
                ProjectCustomerColumn.DisplayMember = "CustomerName";
                ProjectCustomerColumn.ValueMember = "CustomerID";
                ProjectDataGridView[ProjectCustomerColumn.Index, rowIndex].Value = manager.Projects[i].CustomerID;
                if (manager.Projects[i].EmployeesID.Count > 0)
                    ProjectDataGridView[EmployeeCountColumn.Index, rowIndex].Value = manager.Projects[i].EmployeesID.Count.ToString();
                else
                    ProjectDataGridView[EmployeeCountColumn.Index, rowIndex].Value = "0";
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

        internal void LoadProjectInfoToCustomer(Customer customer)
        {
            int customerIndex = manager.Customers.IndexOf(customer);
            double money = 0;
            int quantity = 0;
            for (int i = 0; i < manager.Projects.Count; i++)
            {
                if (manager.Projects[i].CustomerID == customer.CustomerID)
                {
                    quantity += 1;
                    money += manager.Projects[i].Cost;
                }
            }
            CustomerDataGridView[CustomerMoney.Index, customerIndex].Value = money.ToString();
            CustomerDataGridView[CustomerQuantity.Index, customerIndex].Value = quantity.ToString();
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
                        SaveAllToFile();
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
                        SaveAllToFile();
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

        private void ProjectDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == EditEmployeeInProject.Index && e.RowIndex >= 0)
            {
                var AddEmployeProjectForm = new AddEmployeProjectForm();
                AddEmployeProjectForm.Text = ProjectDataGridView[ProjectNameColumn.Index, e.RowIndex].Value.ToString();
                AddEmployeProjectForm.CurentProject = manager.Projects[e.RowIndex];
                AddEmployeProjectForm.RefreshForm2();
                AddEmployeProjectForm.ShowDialog();
                SaveAllToFile();
                AddEmployeProjectForm.Dispose();
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
                        SaveAllToFile();
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

        private void UpdateAddButtonVisibility()
        {
            if ((SurnameTextBox.Text != "") &&
                (NameTextBox.Text != "") &&
                (SalaryTextBox.Text != "")
            )
                AddEmployeeButton.Visible = true;
            else
                AddEmployeeButton.Visible = false;
        }

        private void UpdateAddCustomerButtonVisibility()
        {
            if ((CustomerSurnameTextBox.Text == "") ||
                (CustomerNameTextBox.Text == "") ||
                (CountryTextBox.Text == "")
                )
                AddCutomerButton.Visible = false;
            else
                AddCutomerButton.Visible = true;
        }

        private void UpdateAddProjectButtonVisibility()
        {
            if ((ProjectNameTextBox.Text == "") ||
                (ProjectCostTextBox.Text == "")
                )
                AddProjectButton.Visible = false;
            else
                AddProjectButton.Visible = true;
        }

        private void SurnameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            { e.Handled = true; }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            this.UpdateAddButtonVisibility();
        }

        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            { e.Handled = true; }
        }

        private void SurnameTextBox_TextChanged(object sender, EventArgs e)
        {
            this.UpdateAddButtonVisibility();
        }

        private void SalaryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)
                && e.KeyChar != Convert.ToChar(44)
                && e.KeyChar != Convert.ToChar(8))
            { e.Handled = true; }
        }

        private void SalaryTextBox_TextChanged(object sender, EventArgs e)
        {
            this.UpdateAddButtonVisibility();
        }

        private ToolTip ToolTipAdd()
        {
            ToolTip tt = new ToolTip();
            tt.IsBalloon = true;
            tt.InitialDelay = 0;
            tt.ShowAlways = true;
            return tt;
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

        private void CustomerNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            { e.Handled = true; }
        }

        private void CustomerNameTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateAddCustomerButtonVisibility();
        }

        private void CuustomerSurnameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            { e.Handled = true; }
        }

        private void CustomerSurnameTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateAddCustomerButtonVisibility();
        }

        private void CountryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            { e.Handled = true; }
        }

        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateAddCustomerButtonVisibility();
        }

        private void ProjectNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            { e.Handled = true; }
        }

        private void ProjectNameTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateAddProjectButtonVisibility();
        }

        private void ProjectCostTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)
                && e.KeyChar != Convert.ToChar(44)
                && e.KeyChar != Convert.ToChar(8))
            { e.Handled = true; }
        }

        private void ProjectCostTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateAddProjectButtonVisibility();
        }

        private void MenegerTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTabEmployee();
            RefreshTabProject();
            RefreshTabCustomer();
            UpdateAddButtonVisibility();
            UpdateAddCustomerButtonVisibility();
            UpdateAddProjectButtonVisibility();
        }

    }
    public class CustomerInProject
    {
        public string CustomerName { get; private set; }
        public int CustomerID { get; private set; }
        public CustomerInProject(string customerName, int customerID)
        {
            CustomerName = customerName;
            CustomerID = customerID;
        }
    }
}
