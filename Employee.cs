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
        public int Salary { get; set; }

        public Employee(int emploeeID, string name, string surname, DateTime dateOfEmployment, int salary,Manager manager) : base(manager) 
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
            this.EmployeeID = XmlNodeHelper.GetNodeAttributeI(employeeNode,XMLEmployeeAttributeID);
            this.Name = XmlNodeHelper.GetNodeAttribute(employeeNode, XMLEmployeeAttributeName);
            this.Surname = XmlNodeHelper.GetNodeAttribute(employeeNode, XMLEmployeeAttributeSurname);
            this.DateOfEmployment = XmlNodeHelper.GetNodeAttributeDT(employeeNode, XMLEmployeeAttributeDateOfEmployeement, DateFormat);
            this.Salary = XmlNodeHelper.GetNodeAttributeI(employeeNode, XMLEmployeeAttributeSalary);
        }

        public void SaveToNode(XmlNode employeeNode)
        {
            XmlNodeHelper.SetNodeAttributeI(employeeNode, XMLEmployeeAttributeID, this.EmployeeID);
            XmlNodeHelper.SetNodeAttribute(employeeNode, XMLEmployeeAttributeName, this.Name);
            XmlNodeHelper.SetNodeAttribute(employeeNode, XMLEmployeeAttributeSurname, this.Surname);
            XmlNodeHelper.SetNodeAttribute(employeeNode, XMLEmployeeAttributeDateOfEmployeement, this.DateOfEmployment.ToString(DateFormat));
            XmlNodeHelper.SetNodeAttributeI(employeeNode, XMLEmployeeAttributeSalary, this.Salary);

        }
    }
}