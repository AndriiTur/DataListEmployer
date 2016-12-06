using System;
using System.Xml;
namespace ManagerProject
{
    public class Employee
    {
        public enum EmployeeToStringMode { store, displayInfo }

        public int EmployeeID { get; private set; }
        public string Surname { get; private set; }
        public string Name { get; private set; }
        public DateTime Date_Of_Employment { get; private set; }
        public double Salary { get; set; }

        public Employee(int emploeeID, string surname, string name, DateTime date_Of_Employment, double salary)
        {
            this.EmployeeID = emploeeID;
            this.Surname = surname;
            this.Name = name;
            this.Date_Of_Employment = date_Of_Employment;
            this.Salary = salary;
        }

        public Employee()
        {
            this.EmployeeID = 0;
            this.Surname = "";
            this.Name = "";
            this.Date_Of_Employment = new DateTime { };
            this.Salary = 0;
        }

        public void LoadFromString(string employeeStr)
        {
            string[] result = new string[] { };
            result = employeeStr.Split('\t');
            this.EmployeeID = int.Parse(result[0]);
            this.Surname = result[1];
            this.Name = result[2];
            this.Date_Of_Employment = DateTime.Parse(result[3]);
            this.Salary = int.Parse(result[4]);
        }

        public void LoadFromNode(XmlNode employeeNode)
        {
            this.EmployeeID = int.Parse(employeeNode.Attributes[0].Value);
            this.Surname = employeeNode.Attributes[1].Value;
            this.Name = employeeNode.Attributes[2].Value;
            this.Date_Of_Employment = DateTime.Parse(employeeNode.Attributes[3].Value);
            this.Salary = int.Parse(employeeNode.Attributes[4].Value);
        }

        public XmlNode LoadToNode(Employee employee)
        {
            XmlDocument document = new XmlDocument();
            document.Load("WriteData.xml");
            XmlNode employeElement = document.CreateElement("employee");
            document.DocumentElement.AppendChild(employeElement);
            XmlAttribute employeeID = document.CreateAttribute("employeeID");
            employeeID.Value = employee.EmployeeID.ToString();
            employeElement.Attributes.Append(employeeID);
            XmlAttribute surname = document.CreateAttribute("surname");
            surname.Value = employee.Surname;
            employeElement.Attributes.Append(surname);
            XmlAttribute name = document.CreateAttribute("name");
            name.Value = employee.Name;
            employeElement.Attributes.Append(name);
            XmlAttribute date = document.CreateAttribute("date");
            date.Value = employee.Date_Of_Employment.ToString("dd.MM.yyyy HH: mm");
            employeElement.Attributes.Append(date);
            XmlAttribute salary = document.CreateAttribute("salary");
            salary.Value = employee.Salary.ToString();
            employeElement.Attributes.Append(salary);
            employeElement = employeElement.NextSibling;
            document.Save("WriteData.xml");
            return employeElement;
        }

        public string SaveToString(Employee employee, EmployeeToStringMode mode = EmployeeToStringMode.store)
        {
            string resultStr = "";
            if (mode == EmployeeToStringMode.displayInfo)
            {
                resultStr += employee.EmployeeID.ToString() +
                    "\t" + employee.Surname.ToString() +
                    " " + employee.Name.ToString() +
                    "\t" + string.Format("{0:ddd} {1:dd MMMM yyyy}y. Time{2:HH:mm}",
                    employee.Date_Of_Employment,
                    employee.Date_Of_Employment,
                    employee.Date_Of_Employment) +
                    "\t" + string.Format("${0:#,###}", employee.Salary) + "\r\n";
            }
            else
            {
                resultStr += employee.EmployeeID.ToString() +
                    "\t" + employee.Surname.ToString() +
                    "\t" + employee.Name.ToString() +
                    "\t" + string.Format("{0:dd.MM.yyyy HH:mm}", employee.Date_Of_Employment) +
                    "\t" + employee.Salary.ToString() + "\r\n";
            }
            return resultStr;
        }
    }
}