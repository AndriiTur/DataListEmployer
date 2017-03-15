using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ManagerProject
{
    public class Employees : ManagerBase 
    {
        public const string XMLNodeEmployees = "Employees";
        
        private List<Employee> ListEmployees { get; set; }
        public int Count { get { return ListEmployees.Count; } private set { } }
        public Employee this[int index] { get { return ListEmployees[index]; } }

        public Employees(Manager manager) : base (manager) 
        {
            ListEmployees = new List<Employee>();
        }

        public Employee GetEmployeeByID(int employeeID)
        {
            foreach (var employee in ListEmployees)
                if (employee.EmployeeID == employeeID)
                    return employee;
            return null;
        }

        public void Add(Employee employee)
        {
            ListEmployees.Add(employee);
        }

        public void Clear()
        {
            ListEmployees.Clear();
        }

        //public void Remove(Employee employee)
        //{
        //    if (this.EmployeeHasProject(employee))
        //        throw new Exception(string.Format("Employee {0}  {1} can't be Deleted, because has project",
        //            employee.Name,employee.Surname));
        //    ListEmployees.Remove(employee);
        //}

        private bool EmployeeHasProject(Employee employee)
        {
            for (int i = 0; i < Manager.Projects.Count; i++)
            {
                if (Manager.Projects[i].EmployeesID.IndexOf(employee.EmployeeID) >= 0)
                    return true;
            }
            return false;
        }

        //internal void LoadFromNode(XmlNode employeesNode)
        //{
        //    XmlNodeList xmlEmployeeList = employeesNode.SelectNodes(Employee.XMLNodeEmployee);
        //    foreach (XmlNode employeeNode in xmlEmployeeList)
        //    {
        //        var attributeID = XmlNodeHelper.GetNodeAttribute(employeeNode, Employee.XMLEmployeeAttributeID);
        //        Employee employee = this.GetEmployeeByID(int.Parse(attributeID));
        //        if (employee == null)
        //        {
        //            employee = new Employee(this.Manager);
        //            this.Add(employee);
        //        }
        //        employee.LoadFromNode(employeeNode);
        //    }

        //    for (int i = this.Count - 1; i >= 0 ; i--)
        //    {
        //        var employee = this[i];
        //        string xPath = Employee.XMLNodeEmployee + String.Format("[@{0}='{1}']", Employee.XMLEmployeeAttributeID, employee.EmployeeID.ToString());
        //        var res = employeesNode.SelectSingleNode(xPath);
        //        if (res == null)
        //            this.Remove(employee);
        //    }
        //}

        //internal void SaveToNode(XmlNode employeesNode)
        //{
        //    XmlNodeList xmlEmployeesList = employeesNode.SelectNodes(Employee.XMLNodeEmployee);
        //    foreach (XmlNode node in xmlEmployeesList)
        //    {
        //        int employeeID = XmlNodeHelper.GetNodeAttributeI(node, Employee.XMLEmployeeAttributeID);
        //        if (this.ListEmployees.IndexOf(this.GetEmployeeByID(employeeID)) < 0)
        //        {
        //            node.ParentNode.RemoveChild(node);
        //        }
        //    }

        //    for (var i = 0; i < this.Count; i++)
        //    {
        //        Employee employee = this[i];
        //        XmlNode employeeNode = XmlNodeHelper.RequiredNode(employeesNode, Employee.XMLNodeEmployee,
        //            Employee.XMLEmployeeAttributeID, employee.EmployeeID.ToString());
        //         employee.SaveToNode(employeeNode);
        //    }
        //}

        public void LoadEmployeesFromSQL()
        {
            Manager.Employees.Clear();
            string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\job\projects\ManagerProject\ManagerProject\Manager.mdf;Integrated Security=True;Connect Timeout=30";

            using (SqlConnection myConnection = new SqlConnection(con))
            {
                string oString = "Select EmployeeID, Name, Surname, DateOfEmployment, Salary from Employees";
                SqlCommand oCmd = new SqlCommand(oString, myConnection);
                myConnection.Open();
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        int employeeID = int.Parse(oReader["EmployeeID"].ToString());
                        string name = oReader["Name"].ToString();
                        string surname = oReader["Surname"].ToString();
                        DateTime dateOfEmployment = DateTime.Parse(oReader["DateOfEmployment"].ToString());
                        float salary = float.Parse(oReader["Salary"].ToString());
                        var employee = new Employee(employeeID, name, surname, dateOfEmployment, salary, Manager.Manager);
                        Manager.Employees.Add(employee);
                    }
                    myConnection.Close();
                }
            }

        }

    }
}
