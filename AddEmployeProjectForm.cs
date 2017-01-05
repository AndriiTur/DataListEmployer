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
    public partial class AddEmployeProjectForm : Form
    {
        public const string PathToFile = "WriteData.xml";
        public const string XMLNodeEmployees = "Employees";
        public const string XMLNodeCustomers = "Customers";
        public const string ExeptionError = "Error";
        public const string XMLNodeManager = "Manager";
        public const string XMLNodeProjects = "Projects";
        public const string XMLNodeProject = "Project";
        public const string XMLProjectAtributeID = "projectID";
        public const string XMLEmployeeProject = "Employee";
        
        public Project CurentProject { get; set; }
        List<string> employeeComboBoxList;
        List<int> employeeIDComboBoxList;
        
        public AddEmployeProjectForm()
        {
            InitializeComponent();

            employeeComboBoxList = new List<string>();
            employeeIDComboBoxList = new List<int>();
        }

        private void AddEmployeToProjectButton_Click(object sender, EventArgs e)
        {
            string[] words = EmployeesComboBox.Text.Split(' ');
            int employeeID = int.Parse(words[0]);
            string name = words[1];
            string surname = words[2];
            RefreshForm2();
        }

        internal void RemovEmployeeFromProject(int employeeID)
        {
            CurentProject.EmployeesID.Remove(CurentProject.EmployeesID[CurentProject.EmployeesID.IndexOf(employeeID)]);
            RefreshForm2();
        }

        private void EmployesInProjectDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == EmployeeDeleteButtonProject.Index && e.RowIndex >= 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    RemovEmployeeFromProject(int.Parse(EmployesInProjectDataGridView[EmployeeIDProject.Index,e.RowIndex].Value.ToString()));
                }
                else if (dialogResult == DialogResult.No)
                {
                    EmployesInProjectDataGridView.CurrentCell = null;
                }
            }
        }

        internal void RefreshForm2()
        {
            int row = 0;
            if (employeeComboBoxList.Count > 0)
                employeeComboBoxList.Clear();
            if (employeeIDComboBoxList.Count > 0)
                employeeComboBoxList.Clear();
            if (EmployesInProjectDataGridView.Rows.Count > 0)
                EmployesInProjectDataGridView.Rows.Clear();
            for (var i = 0; i < CurentProject.Manager.Employees.Count; i ++)
            {
                if (FindEmployeeFromID(CurentProject.Manager.Employees[i].EmployeeID) == false)
                {
                    employeeComboBoxList.Add(CurentProject.Manager.Employees[i].Name + " " + CurentProject.Manager.Employees[i].Surname);
                    employeeIDComboBoxList.Add(CurentProject.Manager.Employees[i].EmployeeID);
                }
            }
            EmployeesComboBox.DataSource = employeeComboBoxList;
            EmployeesComboBox.Text = "";
            EmployeesComboBox.SelectedText = "Choise..";
            
            foreach (var employeeID in CurentProject.EmployeesID)
            {
                EmployesInProjectDataGridView.Rows.Add();
                EmployesInProjectDataGridView[EmployeeIDProject.Index, row].Value = employeeID.ToString();
                EmployesInProjectDataGridView[EployeeNameProject.Index, row].Value = GetEmployee(employeeID).Name;
                EmployesInProjectDataGridView[EmployeSurnameProject.Index, row].Value = GetEmployee(employeeID).Surname;
                row++;
            }
        }

        internal Employee GetEmployee(int employeeID)
        {
            Employee resultEmployee = new Employee(CurentProject.Manager);
            for (int i = 0; i < CurentProject.Manager.Employees.Count; i++)
            {
                if (CurentProject.Manager.Employees[i].EmployeeID == employeeID)
                {
                    resultEmployee = CurentProject.Manager.Employees[i];
                    break;
                }
            }
            return resultEmployee;
        }

        internal bool FindEmployeeFromID(int employeeID)
        {
            foreach (var employeeOnProject in CurentProject.EmployeesID)
            {
                if (employeeOnProject == employeeID)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
