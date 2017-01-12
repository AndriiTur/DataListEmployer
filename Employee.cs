using System;
using System.Collections;
using System.Text;
using System.Xml;
namespace ManagerProject
{
    public class Employee : ManagerBase
    {
        public enum EmployeeToStringMode { store, displayInfo }

        public const string XMLEmployeeAttributeID = "employeeID";
        public const string XMLEmployeeAttributeName = "name";
        public const string XMLEmployeeAttributeSurname = "surname";
        public const string XMLEmployeeAttributeSalary = "salary";
        public const string XMLEmployeeAttributeDateOfEmployeement = "dateOfEmployeement";
        public const string XMLNodeEmployee = "Employee";
        public const string DateFormat = "dd.MM.yyyy HH:mm";

        public int EmployeeID { get; private set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfEmployment { get; private set; }
        public double Salary { get; set; }

        public Employee(int emploeeID, string name, string surname, DateTime dateOfEmployment, double salary,Manager manager) : base(manager) 
        {
            this.EmployeeID = emploeeID;
            this.Name = name;
            this.Surname = surname;
            this.DateOfEmployment = dateOfEmployment;
            this.Salary = salary;
        }

        public Employee(Manager manager) : base (manager)
        {
            this.EmployeeID = 0;
            this.Name = "";
            this.Surname = "";
            this.DateOfEmployment = new DateTime { };
            this.Salary = 0;
        }

        public void LoadFromNode(XmlNode employeeNode)
        {
            this.EmployeeID = int.Parse(XmlNodeHelper.GetNodeAttribute(employeeNode,XMLEmployeeAttributeID));
            this.Name = XmlNodeHelper.GetNodeAttribute(employeeNode, XMLEmployeeAttributeName);
            this.Surname = XmlNodeHelper.GetNodeAttribute(employeeNode, XMLEmployeeAttributeSurname);
            this.DateOfEmployment = DateTime.Parse(XmlNodeHelper.GetNodeAttribute(employeeNode, XMLEmployeeAttributeDateOfEmployeement));
            this.Salary = double.Parse(XmlNodeHelper.GetNodeAttribute(employeeNode, XMLEmployeeAttributeSalary));
        }

        public void SaveToNode(XmlNode employeeNode)
        {
            XmlNodeHelper.SetNodeAttribute(employeeNode, XMLEmployeeAttributeID, this.EmployeeID.ToString());
            XmlNodeHelper.SetNodeAttribute(employeeNode, XMLEmployeeAttributeName, this.Name, XmlNodeHelper.GetNodeAttribute(employeeNode, XMLEmployeeAttributeName));
            XmlNodeHelper.SetNodeAttribute(employeeNode, XMLEmployeeAttributeSurname, this.Surname, XmlNodeHelper.GetNodeAttribute(employeeNode, XMLEmployeeAttributeSurname));
            XmlNodeHelper.SetNodeAttribute(employeeNode, XMLEmployeeAttributeDateOfEmployeement, this.DateOfEmployment.ToString(DateFormat), XmlNodeHelper.GetNodeAttribute(employeeNode, XMLEmployeeAttributeDateOfEmployeement));
            XmlNodeHelper.SetNodeAttribute(employeeNode, XMLEmployeeAttributeSalary, this.Salary.ToString(), XmlNodeHelper.GetNodeAttribute(employeeNode, XMLEmployeeAttributeSalary));

        }
    }
}