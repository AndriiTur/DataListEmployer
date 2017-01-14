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
        public const string ExeptionError = "Error";
        
        List<string> employeeComboBoxList;
        List<int> employeeIDComboBoxList;

        public Project CurentProject { get; set; }
        
        public AddEmployeProjectForm()
        {
            InitializeComponent();

            employeeComboBoxList = new List<string>();
            employeeIDComboBoxList = new List<int>();
        }

        private void AddEmployeToProjectButton_Click(object sender, EventArgs e)
        {
            int employeeID = employeeIDComboBoxList[employeeComboBoxList.IndexOf(EmployeesComboBox.SelectedValue.ToString())];
            CurentProject.EmployeesID.Add(employeeID);
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
            employeeComboBoxList.Clear();
            employeeIDComboBoxList.Clear();
            EmployesInProjectDataGridView.Rows.Clear();
            for (var i = 0; i < CurentProject.Manager.Employees.Count; i ++)
            {
                if (ExistsEmployee(CurentProject.Manager.Employees[i]))
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
                EmployesInProjectDataGridView[EployeeNameProject.Index, row].Value = CurentProject.Manager.Employees.GetEmployeeByID(employeeID).Name;
                EmployesInProjectDataGridView[EmployeSurnameProject.Index, row].Value = CurentProject.Manager.Employees.GetEmployeeByID(employeeID).Surname;
                row++;
            }
        }

        internal bool ExistsEmployee(Employee employee)
        {
            return CurentProject.EmployeesID.IndexOf(employee.EmployeeID) < 0;
        }
    }
}
