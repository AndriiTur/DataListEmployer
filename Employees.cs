using System;
using System.Collections;
using System.Collections.Generic;
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

        public void Remove(Employee employee)
        {
            ListEmployees.Remove(employee);
        }

        internal void LoadFromNode(XmlNode employeesNode)
        {
            XmlNodeList xmlEmployeeList = employeesNode.SelectNodes(Employee.XMLNodeEmployee);
            foreach (XmlNode employeeNode in xmlEmployeeList)
            {
                XmlNode attributeID = employeeNode.Attributes.GetNamedItem(Employee.XMLEmployeeAtributeID);
                Employee employee = this.GetEmployeeByID(int.Parse(attributeID.Value));
                if (employee == null)
                {
                    employee = new Employee(this.Manager);
                    this.Add(employee);
                }
                employee.LoadFromNode(employeeNode);
            }

            for (int i = 0; i < this.Count; i++)
            {
                var employee = this[i];
                string xPath = Employee.XMLNodeEmployee + String.Format("[@{0}='{1}']", Employee.XMLEmployeeAtributeID, employee.EmployeeID.ToString());
                var res = employeesNode.SelectSingleNode(xPath);
                if (res == null)
                    this.Remove(employee);
            }
        }

        internal void SaveToNode(XmlNode employeesNode)
        {
            for (var i = 0; i < this.Count; i++)
            {
                Employee employee = this[i];
                XmlNode employeeNode = XmlNodeHelper.RequiredNode(employeesNode, Employee.XMLNodeEmployee,
                    Employee.XMLEmployeeAtributeID, employee.EmployeeID.ToString());
                 employee.SaveToNode(employeeNode);
            }
        }
    }
}
