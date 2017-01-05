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
        
        private List<Employee> listEmployees;

        public int Count { get { return listEmployees.Count; } private set { } }

        public Employees(Manager manager) : base (manager) 
        {
            listEmployees = new List<Employee>();
        }

        public Employee this[int index] { get { return listEmployees[index]; } }

        public Employee GetEmployeeByID(int employeeID)
        {
            foreach (var employee in listEmployees)
                if (employee.EmployeeID == employeeID)
                    return employee;
            return null;
        }

        public void Add(Employee employee)
        {
            listEmployees.Add(employee);
        }

        public void Remove(Employee employee)
        {
            listEmployees.Remove(employee);
        }

        internal void LoadFromFile(XmlNode employeesNode)
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

        internal void SaveToFile(XmlNode employeesNode)
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
