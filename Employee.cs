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
        public const string XMLEmployeeAtributeDate = "date";
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

        public void LoadFromString(string employeeStr)
        {
            string[] result = new string[] { };
            result = employeeStr.Split('\t');
            this.EmployeeID = int.Parse(result[0]);
            this.Name = result[2];
            this.Surname = result[1];
            this.Date_Of_Employment = DateTime.Parse(result[3]);
            this.Salary = double.Parse(result[4]);
        }

        public void LoadFromNode(XmlNode employeeNode)
        {
            this.EmployeeID = int.Parse(employeeNode.Attributes.GetNamedItem(XMLEmployeeAtributeID).Value);
            this.Name = employeeNode.Attributes.GetNamedItem(XMLEmployeeAtributeName).Value;
            this.Surname = employeeNode.Attributes.GetNamedItem(XMLEmployeeAtributeSurname).Value;
            this.Date_Of_Employment = DateTime.Parse(employeeNode.Attributes.GetNamedItem(XMLEmployeeAtributeDate).Value);
            this.Salary = double.Parse(employeeNode.Attributes.GetNamedItem(XMLEmployeeAtributeSalary).Value);
        }

        public void SaveToNode(XmlNode employeeNode)
        {
            XmlNodeHelper.SetNodeAtribute(employeeNode, XMLEmployeeAtributeID, this.EmployeeID.ToString());
            XmlNodeHelper.SetNodeAtribute(employeeNode, XMLEmployeeAtributeName, this.Name);
            XmlNodeHelper.SetNodeAtribute(employeeNode, XMLEmployeeAtributeSurname, this.Surname);
            XmlNodeHelper.SetNodeAtribute(employeeNode, XMLEmployeeAtributeDate, this.Date_Of_Employment.ToString(DateFormat));
            XmlNodeHelper.SetNodeAtribute(employeeNode, XMLEmployeeAtributeSalary, this.Salary.ToString());

        }

        //public string SaveToString(Employee employee, EmployeeToStringMode mode = EmployeeToStringMode.store)
        //{
        //    string resultStr = "";
        //    if (mode == EmployeeToStringMode.displayInfo)
        //    {
        //        resultStr += employee.EmployeeID.ToString() +
        //            "\t" + employee.Surname.ToString() +
        //            " " + employee.Name.ToString() +
        //            "\t" + string.Format("{0:ddd} {1:dd MMMM yyyy}y. Time{2:HH:mm}",
        //            employee.Date_Of_Employment,
        //            employee.Date_Of_Employment,
        //            employee.Date_Of_Employment) +
        //            "\t" + string.Format("${0:#,###}", employee.Salary) + "\r\n";
        //    }
        //    else
        //    {
        //        resultStr += employee.EmployeeID.ToString() +
        //            "\t" + employee.Surname.ToString() +
        //            "\t" + employee.Name.ToString() +
        //            "\t" + string.Format("{0:dd.MM.yyyy HH:mm}", employee.Date_Of_Employment) +
        //            "\t" + employee.Salary.ToString() + "\r\n";
        //    }
        //    return resultStr;
        //}
    }
}