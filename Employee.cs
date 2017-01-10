using System;
using System.Collections;
using System.Text;
using System.Xml;
namespace ManagerProject
{
    public class Employee : ManagerBase
    {
        public enum EmployeeToStringMode { store, displayInfo }

        public const string XMLEmployeeAtributeID = "employeeID";
        public const string XMLEmployeeAtributeName = "name";
        public const string XMLEmployeeAtributeSurname = "surname";
        public const string XMLEmployeeAtributeSalary = "salary";
        public const string XMLEmployeeAtributeDateOfEmployeement = "dateOfEmployeement";
        public const string XMLNodeEmployee = "Employee";
        public const string DateFormat = "dd.MM.yyyy HH:mm";

        public int EmployeeID { get; private set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Date_Of_Employment { get; private set; }
        public double Salary { get; set; }

        public Employee(int emploeeID, string name, string surname, DateTime date_Of_Employment, double salary,Manager manager) : base(manager) 
        {
            this.EmployeeID = emploeeID;
            this.Name = name;
            this.Surname = surname;
            this.Date_Of_Employment = date_Of_Employment;
            this.Salary = salary;
        }

        public Employee(Manager manager) : base (manager)
        {
            this.EmployeeID = 0;
            this.Name = "";
            this.Surname = "";
            this.Date_Of_Employment = new DateTime { };
            this.Salary = 0;
        }

        public void LoadFromNode(XmlNode employeeNode)
        {
            this.EmployeeID = int.Parse(employeeNode.Attributes.GetNamedItem(XMLEmployeeAtributeID).Value);
            this.Name = employeeNode.Attributes.GetNamedItem(XMLEmployeeAtributeName).Value;
            this.Surname = employeeNode.Attributes.GetNamedItem(XMLEmployeeAtributeSurname).Value;
            this.Date_Of_Employment = DateTime.Parse(employeeNode.Attributes.GetNamedItem(XMLEmployeeAtributeDateOfEmployeement).Value);
            this.Salary = double.Parse(employeeNode.Attributes.GetNamedItem(XMLEmployeeAtributeSalary).Value);
        }

        public void SaveToNode(XmlNode employeeNode)
        {
            XmlNodeHelper.SetNodeAtribute(employeeNode, XMLEmployeeAtributeID, this.EmployeeID.ToString());
            XmlNodeHelper.SetNodeAtribute(employeeNode, XMLEmployeeAtributeName, this.Name);
            XmlNodeHelper.SetNodeAtribute(employeeNode, XMLEmployeeAtributeSurname, this.Surname);
            XmlNodeHelper.SetNodeAtribute(employeeNode, XMLEmployeeAtributeDateOfEmployeement, this.Date_Of_Employment.ToString(DateFormat));
            XmlNodeHelper.SetNodeAtribute(employeeNode, XMLEmployeeAtributeSalary, this.Salary.ToString());

        }
    }
}